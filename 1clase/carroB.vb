Public Class carroB
    Private marca As String
    Private modelo As String
    Private año As String
    Private color As String
    Dim contador As Integer = 0
    Public Property MetGyS() As String
        Get
            Return marca
            Return modelo
            Return año
            Return color
        End Get
        Set(ByVal value As String)
            While True
                If contador = 0 Then
                    marca = value
                    contador = contador + 1
                    Exit While
                ElseIf contador = 1 Then
                    modelo = value
                    contador = contador + 1
                    Exit While
                ElseIf contador = 2 Then
                    año = value
                    contador = contador + 1
                    Exit While
                ElseIf contador = 3 Then
                    color = value
                    Exit While
                Else
                    Exit While
                End If
            End While
        End Set
    End Property
    Public Sub newcar2()
        Console.WriteLine("" + vbCrLf + $"La marca del carro es: {marca}, el modelo es: {modelo}, el año es : {año} y su color es : {color}")
    End Sub
End Class
