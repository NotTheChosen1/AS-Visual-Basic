Module Module1
    Sub Main()
        ' Validates any email the user inputs.
        ' •	The email should end in .com or .net,
        ' •	It contains a single ‘@’ symbol,
        ' •	The ‘@’ symbol must be preceded by at least three characters,
        ' •	The ‘@’ symbol must be followed by one of the following:
        ' o(gmail)
        ' o(hotmail)
        ' o(outlook)
        ' and a period.
        ' Output an appropriate message regarding the validity of the email.

        Dim email As String

        Console.Write("Please enter your email address: ")
        email = Console.ReadLine

        If email.EndsWith(".com") Or email.EndsWith(".net") Then
            Dim atSymbolIndex As Integer
            atSymbolIndex = email.IndexOf("@")
            If atSymbolIndex > 2 Then
                Dim domain As String
                domain = email.Substring(atSymbolIndex + 1)
                If domain.StartsWith("gmail.") Or domain.StartsWith("hotmail.") Or domain.StartsWith("outlook.") Then
                    MsgBox(email & " is a valid email address.")
                Else
                    MsgBox(email & " is invalid. The domain is not gmail, hotmail, or outlook.")
                End If
            Else
                MsgBox(email & " is invalid. The @ symbol is not preceded by at least three characters.")
            End If
        Else
            MsgBox(email & " is invalid. The email address does not end with .com or .net.")
        End If
    End Sub
End Module
