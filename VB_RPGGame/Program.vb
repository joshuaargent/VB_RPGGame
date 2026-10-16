Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("====================" & vbCrLf & "Welcome to the game!" & vbCrLf & "====================")
        Console.ReadLine()
    End Sub

    Sub GameLoop()

    End Sub
End Module

Module Entities
    Class Enemy
        Public Name As String
        Public Health As String
        Public Weapon As Weapon
        Public Gold As String
    End Class

    Class Player

    End Class

    Class Weapon
        Public Name As String
    End Class

End Module
