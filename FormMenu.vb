Public Class FormMenu
    Public Sub New()
        ' Esta llamada es requerida por el diseñador.
        InitializeComponent()
        ' Centrar el formulario en la pantalla antes de que se muestre
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub ButtonPorcentajes_Click(sender As Object, e As EventArgs) Handles ButtonPorcentajes.Click
        Dim preguntasPorcentajes As New List(Of Pregunta) From {
        New Pregunta With {.Texto = "¿Cuál es el 25% de 200?", .Opciones = New List(Of String) From {"25", "50", "100", "75"}, .RespuestaCorrecta = 1},
        New Pregunta With {.Texto = "Si tienes 80 manzanas y regalas el 10%, ¿cuántas manzanas regalas?", .Opciones = New List(Of String) From {"8", "10", "18", "80"}, .RespuestaCorrecta = 0},
        New Pregunta With {.Texto = "¿Qué porcentaje es 30 de 120?", .Opciones = New List(Of String) From {"10%", "20%", "25%", "30%"}, .RespuestaCorrecta = 2}
    }
        Dim frm As New FormQuiz(preguntasPorcentajes, "Porcentajes")
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDecimales_Click(sender As Object, e As EventArgs) Handles ButtonDecimales.Click
        Dim preguntasDecimales As New List(Of Pregunta) From {
        New Pregunta With {.Texto = "¿Cuánto es 0.5 + 0.25?", .Opciones = New List(Of String) From {"0.55", "0.75", "0.8", "0.5"}, .RespuestaCorrecta = 1},
        New Pregunta With {.Texto = "¿Cuál es el resultado de 1.2 x 2?", .Opciones = New List(Of String) From {"2.2", "2.4", "2.6", "2.0"}, .RespuestaCorrecta = 1},
        New Pregunta With {.Texto = "¿Cuánto es 3.5 - 1.1?", .Opciones = New List(Of String) From {"2.4", "2.3", "2.5", "2.6"}, .RespuestaCorrecta = 0}
    }
        Dim frm As New FormQuiz(preguntasDecimales, "Decimales")
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonFracciones_Click(sender As Object, e As EventArgs) Handles ButtonFracciones.Click
        Dim preguntasFracciones As New List(Of Pregunta) From {
        New Pregunta With {.Texto = "¿Cuánto es 1/2 + 1/4?", .Opciones = New List(Of String) From {"1/4", "2/4", "3/4", "1"}, .RespuestaCorrecta = 2},
        New Pregunta With {.Texto = "¿Cuál es el resultado de 2/3 x 3/4?", .Opciones = New List(Of String) From {"1/2", "1/3", "1/4", "1/6"}, .RespuestaCorrecta = 0},
        New Pregunta With {.Texto = "¿Cuánto es 5/8 - 1/8?", .Opciones = New List(Of String) From {"4/8", "3/8", "2/8", "5/8"}, .RespuestaCorrecta = 0}
    }
        Dim frm As New FormQuiz(preguntasFracciones, "Fracciones")
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonSalirMenu_Click(sender As Object, e As EventArgs) Handles ButtonSalirMenu.Click
        Application.Exit()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelAutor.Text = "Math4ever"
        LabelInstrucciones.Text = "Selecciona un tema para comenzar el quiz. Responde cada pregunta antes de que termine el tiempo. ¡Mucha suerte!"
        ButtonSalirMenu.Text = "Salir"
        ButtonPorcentajes.Text = "Porcentajes"
        ButtonDecimales.Text = "Decimales"
        ButtonFracciones.Text = "Fracciones"

        AjustarAnchoBoton(ButtonPorcentajes)
        AjustarAnchoBoton(ButtonDecimales)
        AjustarAnchoBoton(ButtonFracciones)

        AjustarAnchoLabelInstrucciones()
        CentrarLabelInstrucciones()
        CentrarLabelAutor()
        CentrarBotonesTemas()
    End Sub

    Private Sub FormMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AjustarAnchoLabelInstrucciones()
        CentrarLabelInstrucciones()
        CentrarLabelAutor()
        CentrarBotonesTemas()
    End Sub

    Private Sub AjustarAnchoLabelInstrucciones()
        LabelInstrucciones.Width = CInt(Me.ClientSize.Width * 0.8)
    End Sub

    Private Sub CentrarLabelInstrucciones()
        LabelInstrucciones.Left = (Me.ClientSize.Width - LabelInstrucciones.Width) \ 2
    End Sub

    Private Sub CentrarLabelAutor()
        LabelAutor.Left = (Me.ClientSize.Width - LabelAutor.Width) \ 2
    End Sub

    Private Sub AjustarAnchoBoton(boton As Button)
        Dim margen As Integer = 24 ' Espacio extra a cada lado
        Dim g As Graphics = boton.CreateGraphics()
        Dim size As SizeF = g.MeasureString(boton.Text, boton.Font)
        boton.Width = CInt(size.Width) + margen
        g.Dispose()
    End Sub

    Private Sub CentrarBotonesTemas()
        Dim espacio As Integer = 24 ' Espacio entre botones

        ' Calcular el ancho total ocupado por los 3 botones y los espacios
        Dim anchoTotal As Integer = ButtonPorcentajes.Width + ButtonDecimales.Width + ButtonFracciones.Width + (2 * espacio)

        ' Calcular la posición inicial (izquierda) para el primer botón
        Dim inicioX As Integer = (Me.ClientSize.Width - anchoTotal) \ 2

        ' Mantener la misma coordenada Top para los tres botones (puedes ajustar según tu diseño)
        Dim topBotones As Integer = ButtonPorcentajes.Top

        ButtonPorcentajes.Left = inicioX
        ButtonPorcentajes.Top = topBotones

        ButtonDecimales.Left = ButtonPorcentajes.Left + ButtonPorcentajes.Width + espacio
        ButtonDecimales.Top = topBotones

        ButtonFracciones.Left = ButtonDecimales.Left + ButtonDecimales.Width + espacio
        ButtonFracciones.Top = topBotones
    End Sub

End Class

Module Program
    Sub Main()
        Application.Run(New FormMenu())
    End Sub
End Module