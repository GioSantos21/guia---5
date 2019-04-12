Public Class CuentaBancaria
    ' --- atributos ---
    Public numeroCuenta As String
    Public balance As Double
    ' --- Métodos ---
    Public Sub Depositar()
        Console.Write("" + vbCrLf + "¿Cuánto dinero desea depositar? : $")
        Dim add As Double = Console.ReadLine()
        balance = add + balance
        Console.WriteLine("" + vbCrLf + $"La nueva cantidad es: {balance}")
        Console.WriteLine()
    End Sub
    Public Sub Retirar()
        Console.Write("" + vbCrLf + "¿Cuánto dinero desea retirar? : $")
        Dim salida As Double = Console.ReadLine()
        balance = balance - salida
        Console.WriteLine("" + vbCrLf + $"La nueva cantidad es: {balance}")
        Console.WriteLine()
    End Sub
    Public Sub MostrarBalance()
        Console.Write("" + vbCrLf + $"El número de cuenta : {numeroCuenta} posee un total de: ${balance}")
        Console.WriteLine()
        Console.WriteLine()
    End Sub
End Class
