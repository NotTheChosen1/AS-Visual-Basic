Module Module1
    'Unmodified PG 45 Algorithm
    Sub Main()
        Dim randomNum(0 To 99) As Integer
        Dim index As Integer
        Dim count As Integer
        count = 0

        For index = 0 To 99
            randomNum(index) = Int(Rnd() * 200) + 1
            If randomNum(index) >= 66 And randomNum(index) <= 173 Then
                count = count + 1
            End If
        Next index

        Console.Write("Numbers generated between 66 and 173 inclvusive: " & count) 'Learnt something new called 'MsgBox' ; MsgBox("Count: " & Count)

        Console.ReadKey()
    End Sub
End Module
