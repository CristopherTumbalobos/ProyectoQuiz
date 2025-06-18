Public Class Form1
    Private preguntas As New List(Of Pregunta)
    Private preguntaActual As Integer = 0
    Private puntaje As Integer = 0
    Private tiempoRestante As Integer = 30

    Friend WithEvents Timer1 As Timer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1 = New Timer()
        Timer1.Interval = 1000 ' 1 segundo
        AddHandler Timer1.Tick, AddressOf Timer1_Tick

        ' Hacer que el botón Enviar se active con Enter
        Me.AcceptButton = ButtonResponder

        ' Centrar el texto del label de la pregunta
        LabelPregunta.TextAlign = ContentAlignment.MiddleCenter

        ' Inicializar el puntaje en el label
        LabelPuntaje.Text = "Puntaje: 0"

        ' Pregunta 1
        preguntas.Add(New Pregunta With {
        .Texto = "¿Cuál es el 25% de 200?",
        .Opciones = New List(Of String) From {"25", "50", "100", "75"},
        .RespuestaCorrecta = 1 ' 50
    })

        ' Pregunta 2
        preguntas.Add(New Pregunta With {
        .Texto = "Si tienes 80 manzanas y regalas el 10%, ¿cuántas manzanas regalas?",
        .Opciones = New List(Of String) From {"8", "10", "18", "80"},
        .RespuestaCorrecta = 0 ' 8
    })

        ' Pregunta 3
        preguntas.Add(New Pregunta With {
        .Texto = "¿Qué porcentaje es 30 de 120?",
        .Opciones = New List(Of String) From {"10%", "20%", "25%", "30%"},
        .RespuestaCorrecta = 2 ' 25%
    })

        ' Mezclar las preguntas
        preguntas = preguntas.OrderBy(Function(x) Guid.NewGuid()).ToList()

        MostrarPregunta()
    End Sub

    Private Sub MostrarPregunta()
        ' Actualizar el número de pregunta
        LabelNumeroPregunta.Text = "PREGUNTA " & (preguntaActual + 1).ToString()

        ' Limpiar selección de opciones
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False

        ' Muestra la pregunta en el label
        LabelPregunta.Text = preguntas(preguntaActual).Texto

        ' Mezclar las opciones
        Dim opcionesOriginales = preguntas(preguntaActual).Opciones
        Dim opcionesMezcladas = opcionesOriginales.OrderBy(Function(x) Guid.NewGuid()).ToList()

        ' Asignar las opciones mezcladas a los RadioButton
        RadioButton1.Text = opcionesMezcladas(0)
        RadioButton2.Text = opcionesMezcladas(1)
        RadioButton3.Text = opcionesMezcladas(2)
        RadioButton4.Text = opcionesMezcladas(3)

        ' Guardar el índice de la respuesta correcta después de mezclar
        preguntas(preguntaActual).RespuestaCorrecta = opcionesMezcladas.IndexOf(opcionesOriginales(preguntas(preguntaActual).RespuestaCorrecta))

        tiempoRestante = 30
        LabelTiempo.Text = "Tiempo restante: " & tiempoRestante.ToString()
        Timer1.Start()

        ' Centrar el LabelPregunta respecto al formulario
        CentrarLabelPregunta()

        ' Centrar las opciones de respuesta
        CentrarOpciones()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        tiempoRestante -= 1
        LabelTiempo.Text = "Tiempo restante: " & tiempoRestante.ToString()
        If tiempoRestante = 0 Then
            Timer1.Stop()
            EvaluarRespuesta(-1) ' No respondió
        End If
    End Sub

    Private Sub ButtonResponder_Click(sender As Object, e As EventArgs) Handles ButtonResponder.Click
        If ButtonResponder.Text = "Salir" Then
            Me.Close()
            Return
        End If

        Timer1.Stop()
        Dim respuestaSeleccionada As Integer = ObtenerRespuestaSeleccionada()
        EvaluarRespuesta(respuestaSeleccionada)
    End Sub

    Private Sub EvaluarRespuesta(respuesta As Integer)
        If respuesta = preguntas(preguntaActual).RespuestaCorrecta Then
            puntaje += tiempoRestante ' Más rápido, más puntos
            MessageBox.Show("¡Correcto!")
        Else
            MessageBox.Show("Incorrecto. La respuesta correcta es: " & preguntas(preguntaActual).Opciones(preguntas(preguntaActual).RespuestaCorrecta))
        End If

        ' Actualizar el puntaje en el label
        LabelPuntaje.Text = "Puntaje: " & puntaje.ToString()

        preguntaActual += 1
        If preguntaActual < preguntas.Count Then
            MostrarPregunta()
        Else
            MessageBox.Show("¡Quiz terminado! Puntaje: " & puntaje)
            ButtonResponder.Text = "Salir"
            ' Opcional: deshabilitar los RadioButton para evitar más respuestas
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            RadioButton4.Enabled = False
        End If
    End Sub

    Private Function ObtenerRespuestaSeleccionada() As Integer
        If RadioButton1.Checked Then Return 0
        If RadioButton2.Checked Then Return 1
        If RadioButton3.Checked Then Return 2
        If RadioButton4.Checked Then Return 3
        Return -1 ' Ninguno seleccionado
    End Function

    Private Sub LabelPuntaje_Click(sender As Object, e As EventArgs) Handles LabelPuntaje.Click

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CentrarLabelPregunta()
        CentrarOpciones()
    End Sub

    Private Sub CentrarLabelPregunta()
        LabelPregunta.Left = (Me.ClientSize.Width - LabelPregunta.Width) \ 2
        LabelNumeroPregunta.Left = (Me.ClientSize.Width - LabelNumeroPregunta.Width) \ 2
    End Sub

    Private Sub CentrarOpciones()
        ' Espacio horizontal entre los RadioButton
        Dim espacio As Integer = 50

        ' Calcular el ancho total ocupado por los 4 RadioButton y los espacios
        Dim anchoTotal As Integer = RadioButton1.Width + RadioButton2.Width + RadioButton3.Width + RadioButton4.Width + (3 * espacio)

        ' Calcular la posición inicial (izquierda) para el primer RadioButton
        Dim inicioX As Integer = (Me.ClientSize.Width - anchoTotal) \ 2

        ' Alinear los RadioButton en una sola línea, centrados
        RadioButton1.Top = RadioButton2.Top ' Asegúrate que todos estén en la misma línea
        RadioButton3.Top = RadioButton2.Top
        RadioButton4.Top = RadioButton2.Top

        RadioButton1.Left = inicioX
        RadioButton2.Left = RadioButton1.Left + RadioButton1.Width + espacio
        RadioButton3.Left = RadioButton2.Left + RadioButton2.Width + espacio
        RadioButton4.Left = RadioButton3.Left + RadioButton3.Width + espacio
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FormMenu.Show()
    End Sub
End Class