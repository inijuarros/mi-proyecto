Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("introduce el numero de numeros de fibonacci que quieres  mostrar")
        Dim x As Integer = Console.ReadLine()

        For y As Integer = 0 To x - 1
            Console.Write($"{Fibo(y)},")

        Next

    End Sub
    Public Function Fibo(ByVal j As Integer) As Integer
        If (j = 0 Or j = 1) Then
            Return j
        Else
            Return Fibo(j - 1) + Fibo(j - 2)
        End If
    End Function

End Module
