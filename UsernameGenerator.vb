Module Module1

    Sub Main()
        Dim username As String
        Dim satisfied As Boolean

        Do
            ' Generate a random username
            Dim letters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"
            Dim numbers As String = "0123456789"
            Dim random As New Random()
            username = ""
            For i As Integer = 1 To 5
                Dim index As Integer = random.Next(letters.Length)
                username &= letters(index)
            Next
            For i As Integer = 1 To 2
                Dim index As Integer = random.Next(numbers.Length)
                username &= numbers(index)
            Next

            ' Ask the user if they are satisfied with the username
            Dim message As String = "Your username is " & username & ". Are you satisfied with this username?"
            Dim result As MsgBoxResult = MsgBox(message, MsgBoxStyle.YesNo)
            satisfied = (result = MsgBoxResult.Yes)
        Loop While Not satisfied
    End Sub

End Module
