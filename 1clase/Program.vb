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
                While True
                    Dim usuario1 As CuentaBancaria = New CuentaBancaria
                    Console.Write("Ingrese su número de cuenta: ")
                    Dim numcuen As String = Console.ReadLine()
                    usuario1.numeroCuenta = numcuen
                    Console.Write("" + vbCrLf + "Ingrese la cantidad de dinero que posee en su cuenta: $")
                    Dim inicio As Double = Console.ReadLine()
                    usuario1.balance = inicio
                    Console.Write("" + vbCrLf + "¿Qué operación desea realizar?" + vbCrLf + "1. Depositar" + vbCrLf + "2. Retirar" + vbCrLf + "3. Mostrar la cantidad de dinero" + vbCrLf + ":")
                    Dim operacion As Integer = Console.ReadLine()
                    If operacion = 1 Then
                        usuario1.Depositar()
                        Exit While
                    ElseIf operacion = 2 Then
                        usuario1.Retirar()
                        Exit While
                    ElseIf operacion = 3 Then
                        usuario1.MostrarBalance()
                        Exit While
                    End If
                End While
            ElseIf respuesta = 5 Then
                While True
                    Console.Write("¿Qué operación desea realizar?" + vbCrLf + "" + vbCrLf + "1. Suma" + vbCrLf + "2. Resta" + vbCrLf + "3. Multiplicación" + vbCrLf + "4. División" + vbCrLf + "5. Todas" + vbCrLf + "" + vbCrLf + "Elija el número con la operación que desea realizar" + vbCrLf + ": ")
                    Dim opcion As Integer = Console.ReadLine()
                    Console.WriteLine()
                    Select Case opcion
                        Case 1
                            Dim sume As Calculadora = New Calculadora
                            sume.suma()
                            Exit While
                        Case 2
                            Dim reste As Calculadora = New Calculadora
                            reste.resta()
                            Exit While
                        Case 3
                            Dim multi As Calculadora = New Calculadora
                            multi.multiplicacion()
                            Exit While
                        Case 4
                            Dim div As Calculadora = New Calculadora
                            div.division()
                            Exit While
                        Case 5
                            Dim all As Calculadora = New Calculadora
                            all.todas()
                            Exit While
                    End Select
                End While
            End If
        End While
    End Sub
End Module
