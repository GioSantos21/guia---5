Imports System

Module Program
    Sub Main()
        While True
            Console.Write("Si desea salir del programa presione la tecla <0>" + vbCrLf + "" + vbCrLf + "1. Hola mundo." + vbCrLf + "2. Mostrar informaci�n sobre vehiculos." + vbCrLf + "3. Vehiculo B, M�todo Get and Set." + vbCrLf + "4. Cuenta Bancaria." + vbCrLf + "5. Calculadora." + vbCrLf + "" + vbCrLf + "Elija una opci�n <1-5>: ")
            Dim respuesta As Integer = Console.ReadLine()
            Console.WriteLine()
            If respuesta = 1 Then
                Dim hi As holamundo = New holamundo
                hi.saludo()
            ElseIf respuesta = 2 Then
                Dim vehiculo As carro = New carro
                vehiculo.marca = "TOYOTA"
                vehiculo.modelo = "Hilux"
                vehiculo.a�o = 2010
                vehiculo.color = "rojo"
                vehiculo.newcar()
                Console.ReadLine()
                vehiculo.marca = "Tesla"
                vehiculo.modelo = "Modelo X"
                vehiculo.a�o = 2012
                vehiculo.color = "Amarrillo"
                vehiculo.newcar()
                Console.ReadLine()
                vehiculo.marca = "Suzuki"
                vehiculo.modelo = "Jimmy"
                vehiculo.a�o = 2018
                vehiculo.color = "Gris"
                vehiculo.newcar()
                Console.WriteLine()
            ElseIf respuesta = 3 Then
                While True
                    Dim VehiculoB As carroB = New carroB
                    Console.Write("Ingrese la marca de t� carro: ")
                    Dim marcaa As String = Console.ReadLine()
                    VehiculoB.MetGyS = marcaa
                    Console.Write("" + vbCrLf + "Ingrese el modelo de t� carro: ")
                    Dim modeloo As String = Console.ReadLine()
                    VehiculoB.MetGyS = modeloo
                    Console.Write("" + vbCrLf + "Ingrese el a�o de t� carro: ")
                    Dim a�oo As String = Console.ReadLine()
                    VehiculoB.MetGyS = a�oo
                    Console.Write("" + vbCrLf + "Ingrese el color de t� carro: ")
                    Dim colorr As String = Console.ReadLine()
                    VehiculoB.MetGyS = colorr
                    VehiculoB.newcar2()
                    Console.Write("" + vbCrLf + "�Desea continuar ingresando datos? Presione <Y> si desea seguir o cualquier otra letra para salir <X>: ")
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
                    Console.Write("Ingrese su n�mero de cuenta: ")
                    Dim numcuen As String = Console.ReadLine()
                    usuario1.numeroCuenta = numcuen
                    Console.Write("" + vbCrLf + "Ingrese la cantidad de dinero que posee en su cuenta: $")
                    Dim inicio As Double = Console.ReadLine()
                    usuario1.balance = inicio
                    Dim salir As Integer = 1
                    While salir <> 0
                        Console.Write("" + vbCrLf + "�Qu� operaci�n desea realizar?" + vbCrLf + "1. Depositar" + vbCrLf + "2. Retirar" + vbCrLf + "3. Mostrar la cantidad de dinero" + vbCrLf + ":")
                    Dim operacion As Integer = Console.ReadLine()
                        If operacion = 1 Then
                            usuario1.Depositar()
                            salir = 0
                        ElseIf operacion = 2 Then
                            usuario1.Retirar()
                            salir = 0
                        ElseIf operacion = 3 Then
                            usuario1.MostrarBalance()
                            salir = 0
                        Else
                            Console.WriteLine("" + vbCrLf + "ERROR. Opci�n fuera de rango")
                            Continue While
                        End If
                    End While
                    Console.Write("�Desea continuar ingresando datos? Presione <Y> si desea seguir o cualquier otra letra para salir <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Console.WriteLine()
                        Continue While
                    Else
                        Console.WriteLine()
                        Exit While
                    End If
                End While
            ElseIf respuesta = 5 Then
                While True
                    Console.Write("�Qu� operaci�n desea realizar?" + vbCrLf + "" + vbCrLf + "1. Suma" + vbCrLf + "2. Resta" + vbCrLf + "3. Multiplicaci�n" + vbCrLf + "4. Divisi�n" + vbCrLf + "5. Todas" + vbCrLf + "" + vbCrLf + "Elija el n�mero con la operaci�n que desea realizar" + vbCrLf + ": ")
                    Dim opcion As Integer = Console.ReadLine()
                    Console.WriteLine()
                    Select Case opcion
                        Case 1
                            Dim sume As Calculadora = New Calculadora
                            sume.suma()
                        Case 2
                            Dim reste As Calculadora = New Calculadora
                            reste.resta()
                        Case 3
                            Dim multi As Calculadora = New Calculadora
                            multi.multiplicacion()
                        Case 4
                            Dim div As Calculadora = New Calculadora
                            div.division()
                        Case 5
                            Dim all As Calculadora = New Calculadora
                            all.todas()
                        Case Else
                            Console.WriteLine("ERROR. Opci�n fuera de rango." + vbCrLf + "")
                            Continue While
                    End Select
                    Console.Write("�Desea continuar ingresando datos? Presione <Y> si desea seguir o cualquier otra letra para salir <X>: ")
                    Dim sigo As String = Console.ReadLine()
                    If sigo = "y" Or sigo = "Y" Then
                        Console.WriteLine()
                        Continue While
                    Else
                        Console.WriteLine()
                        Exit While
                    End If
                End While
            ElseIf respuesta = 0 Then
                Exit While
            Else
                Console.WriteLine("ERROR. Opci�n fuera de rango." + vbCrLf + "")
            End If
        End While
    End Sub
End Module
