Module Module1
    'Brooks Keller
    '9/26/2023
    'basic string functions and integers
    Sub Main()
        Dim input As String
        Dim city, state As String
        Dim commaLocation, stringLength As Integer

        Console.Write("Please enter a city and state separated by only a comma (no spaces) >> ")
        input = Console.ReadLine

        'our goal is so separate this into two different string variables (city and state)
        'we assume we have a string in the format city,state

        'find the comma
        commaLocation = input.IndexOf(",") 'find the comma !!!
        Console.WriteLine("The comma is located at position {0}", commaLocation)
        stringLength = input.Length
        Console.WriteLine("The length of the string is {0}", stringLength)

        'take the first part of the string up to the comma
        city = input.Substring(0, commaLocation)
        Console.WriteLine("The city is {0}", city)

        'take the last part of the string after the comma, that is the state
        state = input.Substring(commaLocation + 1, stringLength - commaLocation - 1)
        Console.WriteLine("The state is {0}", state)
    End Sub

End Module
