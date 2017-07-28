'Does all the functions to mix up the string
Module StringManipulation

    'Filter out illegal characters
    Function FilterCharacters(ByVal input As String) As String

        'Temporary string to return
        Dim SkipError As Boolean = False
        Dim TempString As String = ""

        'Run through and filter the characters
        For Each c As Char In input

            If AscW(c) > 126 Then
                If SkipError = False Then
                    SkipError = True
                    MessageBox.Show("One or more illegal characters have been filtered out from the input. The message will still encode, but without the illegal characters included.", "Illegal Characters Filtered", MessageBoxButtons.OK, MessageBoxIcon.Question)
                End If
            ElseIf AscW(c) > 31 Then
                TempString += c
            End If
        Next

        Return TempString

    End Function


    'Convert the string to an integer
    Function StringToInteger(ByVal input As String) As Integer

        'Value to return
        Dim ReturnInteger As Integer = 0

        For Each c As Char In input
            ReturnInteger += Asc(c)
        Next

        Return ReturnInteger

    End Function


    'Shuffle the order of the string
    Function ShuffleString(ByVal input As String, ByVal rand As Object) As String

        Dim strOutput As String = ""
        Dim intPlace As Integer

        While input.Length > 0

            intPlace = rand.Next(0, input.Length)
            strOutput += input.Substring(intPlace, 1)
            input = input.Remove(intPlace, 1)

        End While

        Return strOutput

    End Function


    'Add extra text, then shuffle again
    Function AddText(ByVal input As String, ByVal toAdd As String, ByVal rand As Object) As String

        While toAdd.Length > 0

            Dim intPlace = rand.Next(0, toAdd.Length)

            input = input.Replace(toAdd.Substring(intPlace, 1), "")
            input = input & "" & toAdd.Substring(intPlace, 1)
            toAdd = toAdd.Remove(intPlace, 1)

        End While

        Return ShuffleString(input, rand)

    End Function


    'Do a pseudo xor for the string
    Function PseudoXor(ByVal input As String, ByVal key As String)

        Dim AllChars As String = My.Resources.AllChars.ToString

        Dim ReturnString As String = ""
        Dim rand As New Random(StringToInteger(key))

        For i = 0 To input.Length - 1 Step 1

            AllChars = ShuffleString(AllChars, rand)
            AllChars = AddText(AllChars, key, rand)

            Dim CharIndex As Integer = AllChars.IndexOf(input.Substring(i, 1))

            ReturnString = ReturnString & "" & AllChars.Substring(AllChars.Length - (CharIndex) - 1, 1)

        Next


        Return ReturnString

    End Function


    'Add extra characters
    Function AddExtraCharacters(ByVal input As String, ByVal key As String)

        Dim rand As New Random()

        'Pick two random values to add on to the end of the string
        Dim Front As Integer = rand.Next(1, 10)
        Dim Back As Integer = rand.Next(1, 10)

        'Now set the numerical representation key
        rand = New Random(StringToInteger(key))

        Dim AllChars As String = My.Resources.AllChars.ToString
        AllChars = ShuffleString(AllChars, rand)
        AllChars = AddText(AllChars, key, rand)

        rand = New Random

        'Add on characters to the front
        For i = 1 To Front
            input = Chr(rand.Next(32, 126)) & "" & input
        Next

        'Add characters on the back
        For i = 1 To Back
            input = input & "" & Chr(rand.Next(32, 126))
        Next


        'Finally, add on the two characters at the end
        input = input & AllChars.Substring(Front, 1) & AllChars.Substring(Back, 1)

        'And shuffle input
        input = PseudoXor(input, key)

        Return input

    End Function


    'Remove the extra characters added onto the string
    Function RemoveExtraChars(ByVal input As String, ByVal key As String)

        'UnShuffle input
        input = PseudoXor(input, key)

        'Now set the numerical representation key
        Dim rand = New Random(StringToInteger(key))

        Dim AllChars As String = My.Resources.AllChars.ToString
        AllChars = ShuffleString(AllChars, rand)
        AllChars = AddText(AllChars, key, rand)


        'And get the number of characters to remove
        Dim Back = AllChars.IndexOf(input.Substring(input.Length - 1, 1))
        Dim Front = AllChars.IndexOf(input.Substring(input.Length - 2, 1))

        'Pull these extra characters off
        input = input.Substring(Front, ((input.Length - Back) - Front) - 2)

        'And return the result
        Return input

    End Function


End Module
