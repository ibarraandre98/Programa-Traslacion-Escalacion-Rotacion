Imports System.IO

Public Class Form1

    Dim zoom As Integer = 10
    Dim vecpuntos As List(Of Puntos) = New List(Of Puntos)
    Dim matrizTraslacion()() As Integer
    Dim matrizEscalamiento()() As Integer
    Dim matrizRotacion()() As Integer



    Private Sub panelDibujo_Paint(sender As Object, e As PaintEventArgs) Handles panelDibujo.Paint
        Dim g As Graphics
        g = e.Graphics()
        cuadricula(g)

    End Sub

    Private Sub cuadricula(ByVal g As Graphics)

        Dim pengray As Pen = New Pen(Color.Gray)

        Dim w As Integer = panelDibujo.Width()
        Dim w2 As Integer = panelDibujo.Width() / 2

        Dim h As Integer = panelDibujo.Height()
        Dim h2 As Integer = panelDibujo.Height() / 2

        Dim penred As Pen = New Pen(Color.Red, zoom)

        g.DrawLine(penred, w2 + 5, 0, w2 + 5, h)
        g.DrawLine(penred, 0, h2 + 5, w, h2 + 5)

        For index = 0 To w2 - 1 Step zoom
            g.DrawLine(pengray, w2 - index, 0, w2 - index, h)
            g.DrawLine(pengray, w2 + index, 0, w2 + index, h)
        Next

        For index = 0 To h2 - 1 Step zoom
            g.DrawLine(pengray, 0, h2 - index, w, h2 - index)
            g.DrawLine(pengray, 0, h2 + index, w, h2 + index)
        Next

    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim nombrearchivo As String
        OPF.Filter = "Text File | *.txt"
        If OPF.ShowDialog Then
            nombrearchivo = OPF.FileName
        End If
        Dim objReader As New StreamReader(nombrearchivo)
        Dim linea As String = ""
        Dim vec As New ArrayList

        Do
            linea = objReader.ReadLine
            If Not linea Is Nothing Then
                vec.Add(linea)
            End If
        Loop Until linea Is Nothing

        For Each v As String In vec
            Dim separador() As String
            separador = v.Split(" ")
            vecpuntos.Add(New Puntos(Convert.ToInt32(separador(0)), Convert.ToInt32(separador(1)), Convert.ToInt32(separador(2)), Convert.ToInt32(separador(3))))
        Next

        Dim hash As HashSet(Of Integer) = New HashSet(Of Integer)

        For Each item In vecpuntos
            hash.Add(item.setgetpol())
        Next

        Dim g As Graphics
        g = panelDibujo.CreateGraphics()




    End Sub


    Private Sub LlenadoDeMatrices(ByVal dx As Integer, dy As Integer, Sx As Integer, Sy As Integer)

        matrizTraslacion(0)(0) = 1
        matrizTraslacion(0)(1) = 0
        matrizTraslacion(0)(2) = dx
        matrizTraslacion(1)(0) = 0
        matrizTraslacion(1)(1) = 1
        matrizTraslacion(1)(2) = dy
        matrizTraslacion(2)(0) = 0
        matrizTraslacion(2)(1) = 0
        matrizTraslacion(2)(2) = 1

        matrizEscalamiento(0)(0) = Sx
        matrizEscalamiento(0)(1) = 0
        matrizEscalamiento(0)(2) = 0
        matrizEscalamiento(1)(0) = 0
        matrizEscalamiento(1)(1) = Sy
        matrizEscalamiento(1)(2) = 0
        matrizEscalamiento(2)(0) = 0
        matrizEscalamiento(2)(1) = 0
        matrizEscalamiento(2)(2) = 1

        'matrizRotacion(0)(0) = 0
        'matrizRotacion(0)(1) = 0
        'matrizRotacion(0)(2) = dx
        'matrizRotacion(1)(0) = 0
        'matrizRotacion(1)(1) = 1
        'matrizRotacion(1)(2) = dy
        'matrizRotacion(2)(0) = 0
        'matrizRotacion(2)(1) = 0
        'matrizRotacion(2)(2) = 1

    End Sub

    Private Sub Operaciones()

    End Sub
End Class
