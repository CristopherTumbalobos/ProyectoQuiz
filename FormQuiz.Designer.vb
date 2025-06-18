<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuiz
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelPregunta = New System.Windows.Forms.Label()
        Me.ButtonResponder = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.LabelPuntaje = New System.Windows.Forms.Label()
        Me.LabelTiempo = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelNumeroPregunta = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'LabelPregunta
        '
        Me.LabelPregunta.AutoSize = True
        Me.LabelPregunta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPregunta.Location = New System.Drawing.Point(53, 150)
        Me.LabelPregunta.Name = "LabelPregunta"
        Me.LabelPregunta.Size = New System.Drawing.Size(78, 24)
        Me.LabelPregunta.TabIndex = 0
        Me.LabelPregunta.Text = "Label1"
        '
        'ButtonResponder
        '
        Me.ButtonResponder.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonResponder.Location = New System.Drawing.Point(360, 364)
        Me.ButtonResponder.Name = "ButtonResponder"
        Me.ButtonResponder.Size = New System.Drawing.Size(91, 39)
        Me.ButtonResponder.TabIndex = 1
        Me.ButtonResponder.Text = "Enviar"
        Me.ButtonResponder.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(230, 301)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(167, 28)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(403, 301)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(167, 28)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(576, 301)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(167, 28)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'LabelPuntaje
        '
        Me.LabelPuntaje.AutoSize = True
        Me.LabelPuntaje.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPuntaje.Location = New System.Drawing.Point(588, 31)
        Me.LabelPuntaje.Name = "LabelPuntaje"
        Me.LabelPuntaje.Size = New System.Drawing.Size(83, 24)
        Me.LabelPuntaje.TabIndex = 6
        Me.LabelPuntaje.Text = "Label 1"
        '
        'LabelTiempo
        '
        Me.LabelTiempo.AutoSize = True
        Me.LabelTiempo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTiempo.Location = New System.Drawing.Point(34, 31)
        Me.LabelTiempo.Name = "LabelTiempo"
        Me.LabelTiempo.Size = New System.Drawing.Size(78, 24)
        Me.LabelTiempo.TabIndex = 7
        Me.LabelTiempo.Text = "Label1"
        '
        'LabelNumeroPregunta
        '
        Me.LabelNumeroPregunta.AutoSize = True
        Me.LabelNumeroPregunta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroPregunta.Location = New System.Drawing.Point(53, 103)
        Me.LabelNumeroPregunta.Name = "LabelNumeroPregunta"
        Me.LabelNumeroPregunta.Size = New System.Drawing.Size(78, 24)
        Me.LabelNumeroPregunta.TabIndex = 8
        Me.LabelNumeroPregunta.Text = "Label1"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(57, 301)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(167, 28)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FormQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Peru
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.LabelNumeroPregunta)
        Me.Controls.Add(Me.LabelTiempo)
        Me.Controls.Add(Me.LabelPuntaje)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.ButtonResponder)
        Me.Controls.Add(Me.LabelPregunta)
        Me.Name = "FormQuiz"
        Me.Text = "Formulario sobre Porcentajes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelPregunta As Label
    Friend WithEvents ButtonResponder As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents LabelPuntaje As Label
    Friend WithEvents LabelTiempo As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LabelNumeroPregunta As Label
    Friend WithEvents RadioButton1 As RadioButton
End Class
