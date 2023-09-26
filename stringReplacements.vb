Module stringReplacements
    'Brooks Keller
    '9/26/2023
    'string replacements
    Sub main()
        Dim input As String
        Dim newString As String
        Dim originalString As String = "Mr. Klins is the teacher of this class"

        Console.WriteLine(originalString)
        Console.Write("What should we change Mr. Klins' name to? >> ")
        input = Console.ReadLine
        newString = originalString.Replace("Mr. Klins", input) 'STRING REPLACEMENT HERE LOOK LOOOOOOOK
        Console.WriteLine("The new string is {0} characters long and is as follows: ", newString.Length)
        Console.WriteLine(newString)
    End Sub
End Module
