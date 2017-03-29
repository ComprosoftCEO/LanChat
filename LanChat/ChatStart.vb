Imports System.Runtime.InteropServices
Public Class ChatStart

    Private Sub ChatStart_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        btnRefresh.PerformClick()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        btnRefresh.Enabled = False
        lbComputers.DataSource = Nothing
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        e.Result = ChatStart.GetNetworkComputers()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        lbComputers.DataSource = CType(e.Result, List(Of String))
        btnRefresh.Enabled = True
    End Sub

    Private Sub lbComputers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbComputers.DoubleClick
        btnChat.PerformClick()
    End Sub

    Private Sub btnChat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChat.Click
        If lbComputers.SelectedIndex <> -1 Then
            Dim chat As New ChatForm(lbComputers.SelectedItem.ToString)
            chat.Show()
            'Me.Close()
        End If
    End Sub

#Region "NetServerEnum_API"

    Public Const SV_TYPE_ALL As Integer = &HFFFFFFFF

    Public Structure SERVER_INFO_101
        Public Platform_ID As Integer
        <MarshalAsAttribute(UnmanagedType.LPWStr)> Public Name As String
        Public Version_Major As Integer
        Public Version_Minor As Integer
        Public Type As Integer
        <MarshalAsAttribute(UnmanagedType.LPWStr)> Public Comment As String
    End Structure

    Public Declare Unicode Function NetServerEnum Lib "Netapi32.dll" ( _
        ByVal Servername As Integer, ByVal Level As Integer, ByRef Buffer As Integer, ByVal PrefMaxLen As Integer, _
        ByRef EntriesRead As Integer, ByRef TotalEntries As Integer, ByVal ServerType As Integer, _
        ByVal DomainName As String, ByRef ResumeHandle As Integer) As Integer

    Public Declare Function NetApiBufferFree Lib "Netapi32.dll" (ByVal lpBuffer As Integer) As Integer

    Public Shared Function GetNetworkComputers(Optional ByVal DomainName As String = Nothing) As List(Of String)
        Dim ServerInfo As SERVER_INFO_101
        Dim MaxLenPref As Integer = -1
        Dim level As Integer = 101
        Dim ResumeHandle As Integer = 0
        Dim ret, EntriesRead, TotalEntries, BufPtr, CurPtr As Integer
        Dim ReturnList As New List(Of String)

        Try
            ret = NetServerEnum(0, level, BufPtr, MaxLenPref, EntriesRead, TotalEntries, SV_TYPE_ALL, DomainName, ResumeHandle)
            If ret = 0 Then
                CurPtr = BufPtr
                For i As Integer = 0 To EntriesRead - 1
                    ServerInfo = CType(Marshal.PtrToStructure(New IntPtr(CurPtr), GetType(SERVER_INFO_101)), SERVER_INFO_101)
                    CurPtr = CurPtr + Len(ServerInfo)
                    ReturnList.Add(ServerInfo.Name)
                Next
            End If
            NetApiBufferFree(BufPtr)
        Catch ex As Exception
        End Try

        Return ReturnList
    End Function

#End Region

    Private Sub ChatStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class