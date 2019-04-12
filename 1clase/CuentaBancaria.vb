Public Class CuentaBancaria
    ' --- atributos ---
    Public numeroCuenta As String
    Public balance As Integer
    ' --- Métodos ---
    Public Sub Depositar()
        Console.Write("" + vbCrLf + "¿Cuánto dinero desea depositar? : $")
        Dim add As Integer = Console.ReadLine()
        balance = add + balance
    End Sub
    Public Sub Retirar()
        Console.Write("" + vbCrLf + "¿Cuánto dinero desea retirar? : $")
        Dim salida As Integer = Console.ReadLine()
        balance = balance - salida
    End Sub
    Public Sub MostrarBalance()
        Console.Write("" + vbCrLf + $"El número de cuenta : {numeroCuenta} posee un balance de: ${balance}")
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Class
