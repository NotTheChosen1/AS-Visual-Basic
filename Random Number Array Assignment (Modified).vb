Module Module1
    ' Modified Algorithm, so that each element of array contains a unique element.
    Sub Main()
        Dim randomNum(0 To 99) As Integer
        Dim index As Integer
        Dim count As Integer
        Dim uniqueValue(0 To 200) As Boolean
        count = 0

        For index = 0 To 99
            Do
                randomNum(index) = Int(Rnd() * 200) + 1
            Loop While uniqueValue(randomNum(index))
            uniqueValue(randomNum(index)) = True
            If randomNum(index) >= 66 And randomNum(index) <= 173 Then
                count = count + 1
            End If
        Next index

        Console.Write("Unique Numbers generated between 66 and 173 inclusive: " & count) 'Or use msgbox (looks nicer) ; MsgBox("Count: " & Count)

        Console.ReadKey()
    End Sub
End Module
