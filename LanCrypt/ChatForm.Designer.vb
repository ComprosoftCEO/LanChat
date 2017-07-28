<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChatForm))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbMessageToSend = New System.Windows.Forms.TextBox()
        Me.btnSendMessage = New System.Windows.Forms.Button()
        Me.rtbConversation = New System.Windows.Forms.RichTextBox()
        Me.btnSendPage = New System.Windows.Forms.Button()
        Me.AckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cbMute = New System.Windows.Forms.CheckBox()
        Me.cbFlash = New System.Windows.Forms.CheckBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'tbMessageToSend
        '
        Me.tbMessageToSend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMessageToSend.Enabled = False
        Me.tbMessageToSend.Location = New System.Drawing.Point(12, 230)
        Me.tbMessageToSend.Name = "tbMessageToSend"
        Me.tbMessageToSend.Size = New System.Drawing.Size(259, 20)
        Me.tbMessageToSend.TabIndex = 0
        '
        'btnSendMessage
        '
        Me.btnSendMessage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendMessage.Enabled = False
        Me.btnSendMessage.Location = New System.Drawing.Point(277, 228)
        Me.btnSendMessage.Name = "btnSendMessage"
        Me.btnSendMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnSendMessage.TabIndex = 1
        Me.btnSendMessage.Text = "Send"
        Me.btnSendMessage.UseVisualStyleBackColor = True
        '
        'rtbConversation
        '
        Me.rtbConversation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbConversation.Location = New System.Drawing.Point(12, 35)
        Me.rtbConversation.Name = "rtbConversation"
        Me.rtbConversation.ReadOnly = True
        Me.rtbConversation.Size = New System.Drawing.Size(421, 189)
        Me.rtbConversation.TabIndex = 2
        Me.rtbConversation.TabStop = False
        Me.rtbConversation.Text = ""
        '
        'btnSendPage
        '
        Me.btnSendPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSendPage.Enabled = False
        Me.btnSendPage.Location = New System.Drawing.Point(358, 228)
        Me.btnSendPage.Name = "btnSendPage"
        Me.btnSendPage.Size = New System.Drawing.Size(75, 23)
        Me.btnSendPage.TabIndex = 3
        Me.btnSendPage.Text = "Page"
        Me.btnSendPage.UseVisualStyleBackColor = True
        '
        'AckTimer
        '
        Me.AckTimer.Interval = 60000
        '
        'cbMute
        '
        Me.cbMute.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbMute.AutoSize = True
        Me.cbMute.Location = New System.Drawing.Point(383, 12)
        Me.cbMute.Name = "cbMute"
        Me.cbMute.Size = New System.Drawing.Size(50, 17)
        Me.cbMute.TabIndex = 4
        Me.cbMute.Text = "Mute"
        Me.cbMute.UseVisualStyleBackColor = True
        '
        'cbFlash
        '
        Me.cbFlash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFlash.AutoSize = True
        Me.cbFlash.Checked = True
        Me.cbFlash.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFlash.Location = New System.Drawing.Point(326, 12)
        Me.cbFlash.Name = "cbFlash"
        Me.cbFlash.Size = New System.Drawing.Size(51, 17)
        Me.cbFlash.TabIndex = 5
        Me.cbFlash.Text = "Flash"
        Me.cbFlash.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoEllipsis = True
        Me.lblStatus.Location = New System.Drawing.Point(12, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(308, 17)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChatForm
        '
        Me.AcceptButton = Me.btnSendMessage
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 262)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.cbFlash)
        Me.Controls.Add(Me.cbMute)
        Me.Controls.Add(Me.btnSendPage)
        Me.Controls.Add(Me.rtbConversation)
        Me.Controls.Add(Me.btnSendMessage)
        Me.Controls.Add(Me.tbMessageToSend)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChatForm"
        Me.Text = "Chat With..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents tbMessageToSend As System.Windows.Forms.TextBox
    Friend WithEvents btnSendMessage As System.Windows.Forms.Button
    Friend WithEvents rtbConversation As System.Windows.Forms.RichTextBox
    Friend WithEvents btnSendPage As System.Windows.Forms.Button
    Friend WithEvents AckTimer As System.Windows.Forms.Timer
    Friend WithEvents cbMute As System.Windows.Forms.CheckBox
    Friend WithEvents cbFlash As System.Windows.Forms.CheckBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label

End Class
