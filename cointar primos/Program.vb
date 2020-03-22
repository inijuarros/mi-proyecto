Imports System

Module Program
    Sub Main(args As String())

        Dim top As Integer
        Dim contador As Integer
        Dim primo As Boolean

        Console.WriteLine("Introduce el numero")
        top = Console.ReadLine

        For i As Integer = top To 2 Step -1
            primo = primob(i)
            If primo = True Then
                contador += 1
            End If
        Next
        Console.Write(contador)
    End Sub
    Public Function primob(ByVal j As Integer) As Boolean
        Dim primos As Boolean = True
        For a As Integer = j - 1 To 2 Step -1
            If (j Mod a = 0) Then
                primos = False
            End If
        Next
        Return primos
    End Function
End Module
