Imports System

Module Program
    Sub Main()
        While True
            Console.Write("Elija una opción <1-5>: ")
            Dim respuesta As Integer = Console.ReadLine()
            Console.WriteLine()
            If respuesta = 1 Then
                Dim hi As holamundo = New holamundo
                hi.saludo()
            ElseIf respuesta = 2 Then
                Dim vehiculo As carro = New carro
                vehiculo.marca = "TOYOTA"
                vehiculo.modelo = "Hilux"
                vehiculo.año = 2010
                vehiculo.color = "rojo"
                vehiculo.newcar()
                Console.ReadLine()
                vehiculo.marca = "Tesla"
                vehiculo.modelo = "Modelo X"
                vehiculo.año = 2012
                vehiculo.color = "Amarrillo"
                vehiculo.newcar()
                Console.ReadLine()
                vehiculo.marca = "Suzuki"
                vehiculo.modelo = "Jimmy"
                vehiculo.año = 2018
                vehiculo.color = "Gris"
                vehiculo.newcar()
                Console.WriteLine()
            ElseIf respuesta = 3 Then
                While True
                    Dim VehiculoB As carroB = New carroB
                    Console.Write("Ingrese la marca de tú carro: ")
                    Dim marcaa As String = Console.ReadLine()
                    VehiculoB.MetGyS = marcaa
                    Console.Write("" + vbCrLf + "Ingrese el modelo de tú carro: ")
                    Dim modeloo As String = Console.ReadLine()
                    VehiculoB.MetGyS = modeloo
                    Console.Write("" + vbCrLf + "Ingrese el año de tú carro: ")
                    Dim añoo As String = Console.ReadLine()
                    VehiculoB.MetGyS = añoo
                    Console.Write("" + vbCrLf + "Ingrese el color de tú carro: ")
                    Dim colorr As String = Console.ReadLine()
                    VehiculoB.MetGyS = colorr
                    VehiculoB.newcar2()
                    Console.Write("" + vbCrLf + "¿Desea continuar ingresando datos? Presione <Y> si desea seguir o cualquier otra letra para salir <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Console.WriteLine()
                        Continue While
                    Else
                        Console.WriteLine()
                        Exit While
                    End If
                End While
            ElseIf respuesta = 4 Then
                Dim usuario1 As CuentaBancaria = New CuentaBancaria
                Console.Write("Ingrese su número de cuenta: ")
                Dim numcuen As String = Console.ReadLine()
                usuario1.numeroCuenta = numcuen
                Console.Write("" + vbCrLf + "Ingrese la cantidad de dinero que posee: $")
                Dim inicio As Integer = Console.ReadLine()
                usuario1.balance = inicio
                usuario1.Depositar()
                usuario1.MostrarBalance()
                usuario1.Retirar()
                usuario1.MostrarBalance()
            End If
        End While
    End Sub
End Module
