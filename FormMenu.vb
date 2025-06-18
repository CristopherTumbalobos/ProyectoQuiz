Public Class FormMenu
    Private Sub ButtonPorcentajes_Click(sender As Object, e As EventArgs) Handles ButtonPorcentajes.Click
        Dim frm As New Form1()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonDecimales_Click(sender As Object, e As EventArgs) Handles ButtonDecimales.Click
        MessageBox.Show("Próximamente: Números Decimales")
    End Sub

    Private Sub ButtonFracciones_Click(sender As Object, e As EventArgs) Handles ButtonFracciones.Click
        MessageBox.Show("Próximamente: Fracciones")
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
    End Sub

    Private Sub FormMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        AjustarAnchoLabelInstrucciones()
        CentrarLabelInstrucciones()
        CentrarLabelAutor()
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

End Class

Module Program
    Sub Main()
        Application.Run(New FormMenu())
    End Sub
End Module