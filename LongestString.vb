Module Module1

    Sub Main()
        ' How long is it?
        ' Write a program that asks a user to input sentence.
        ' The program is to find the longest word in the sentence

        Dim inputSent As String
        Dim longestWord As String

        longestWord = " "

        Console.WriteLine("Please enter a string:")
        inputSent = Console.ReadLine()

        Dim words As String() = inputSent.Split(New Char() {" "c})
        For Each word As String In words
            If word.Length > longestWord.Length Then
                longestWord = word
            End If
        Next
        Console.WriteLine("The longest word in your string is: " & longestWord)

        Console.ReadLine()
    End Sub

End Module
