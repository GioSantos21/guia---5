Public Class Calculadora

    Public Function suma()
        Console.Write("A continuación sumaremos dos números" + vbCrLf + "" + vbCrLf + "Ingrese el primer número :")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("" + vbCrLf + "Ingrese el segundo número :")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 + num2
        Console.WriteLine("" + vbCrLf + $"La suma de {num1} + {num2} es : {sumar}" + vbCrLf + "")
    End Function
    Public Function resta()
        Console.Write("A continuación restaremos dos números" + vbCrLf + "" + vbCrLf + "Ingrese el primer número :")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("" + vbCrLf + "Ingrese el segundo número :")
        Dim num2 As Double = Console.ReadLine()
        If num1 < 0 And num2 < 0 Then
            num2 = (num2 * -1)
        ElseIf num1 < 0 Then
            num1 = (num1 * -1)
        ElseIf num2 < 0 Then
            num2 = (num2 * -1)
        End If
        Dim restar As Double = (num1 - num2)
        Console.WriteLine("" + vbCrLf + $"La resta de {num1} - {num2} es : {restar}" + vbCrLf + "")
    End Function
    Public Function multiplicacion()
        Console.Write("A continuación multiplicaremos dos números" + vbCrLf + "" + vbCrLf + "Ingrese el primer número :")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("" + vbCrLf + "Ingrese el segundo número :")
        Dim num2 As Double = Console.ReadLine()
        Dim multi As Double = num1 * num2
        Console.WriteLine("" + vbCrLf + $"La multiplicación de {num1} * {num2} es : {multi}" + vbCrLf + "")
    End Function
    Public Function division()
        Console.Write("A continuación dividiremos dos números" + vbCrLf + "" + vbCrLf + "Ingrese el primer número :")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("" + vbCrLf + "Ingrese el segundo número :")
        Dim num2 As Double = Console.ReadLine()
        Dim divi As Double = num1 / num2
        Console.WriteLine("" + vbCrLf + $"La división de {num1} / {num2} es : {divi}" + vbCrLf + "")
    End Function
    Public Function todas()
        Console.Write("A continuación se harán las 4 operaciones básicas de matemáticas con dos números" + vbCrLf + "Ingrese el primer número :")
        Dim num1 As Double = Console.ReadLine()
        Console.Write("" + vbCrLf + "Ingrese el segundo número :")
        Dim num2 As Double = Console.ReadLine()
        Dim sumar As Double = num1 + num2
        Console.WriteLine("" + vbCrLf + $"La suma de {num1} + {num2} es : {sumar}" + vbCrLf + "")
        Dim multi As Double = num1 * num2
        Console.WriteLine($"La multiplicación de {num1} * {num2} es : {multi}" + vbCrLf + "")
        Dim divi As Double = num1 / num2
        Console.WriteLine($"La división de {num1} / {num2} es : {divi}" + vbCrLf + "")
        If num1 < 0 And num2 < 0 Then
            num2 = (num2 * -1)
        ElseIf num1 < 0 Then
            num1 = (num1 * -1)
        ElseIf num2 < 0 Then
            num2 = (num2 * -1)
        End If
        Dim restar As Double = num1 - num2
        Console.WriteLine($"La resta de {num1} - {num2} es : {restar}" + vbCrLf + "")
    End Function
End Class
