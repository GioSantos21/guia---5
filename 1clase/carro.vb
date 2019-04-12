Public Class carro
    '--- PROPIEDAD ---
    Public marca As String
    Public modelo As String
    Public año As Integer
    Public color As String
    ' --- FUNCIÓN ---
    Public Sub newcar()
        Console.WriteLine($"La marca del carro es: {marca}, el modelo es: {modelo}, el año es : {año} y su color es : {color}")
    End Sub
End Class
