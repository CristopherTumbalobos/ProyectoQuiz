<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.LabelAutor = New System.Windows.Forms.Label()
        Me.ButtonPorcentajes = New System.Windows.Forms.Button()
        Me.ButtonDecimales = New System.Windows.Forms.Button()
        Me.ButtonFracciones = New System.Windows.Forms.Button()
        Me.LabelInstrucciones = New System.Windows.Forms.Label()
        Me.ButtonSalirMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelAutor
        '
        Me.LabelAutor.AutoSize = True
        Me.LabelAutor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAutor.Location = New System.Drawing.Point(324, 46)
        Me.LabelAutor.Name = "LabelAutor"
        Me.LabelAutor.Size = New System.Drawing.Size(152, 46)
        Me.LabelAutor.TabIndex = 0
        Me.LabelAutor.Text = "Label1"
        '
        'ButtonPorcentajes
        '
        Me.ButtonPorcentajes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPorcentajes.Location = New System.Drawing.Point(159, 268)
        Me.ButtonPorcentajes.Name = "ButtonPorcentajes"
        Me.ButtonPorcentajes.Size = New System.Drawing.Size(111, 46)
        Me.ButtonPorcentajes.TabIndex = 1
        Me.ButtonPorcentajes.TabStop = False
        Me.ButtonPorcentajes.Text = "Button1"
        Me.ButtonPorcentajes.UseVisualStyleBackColor = True
        '
        'ButtonDecimales
        '
        Me.ButtonDecimales.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDecimales.Location = New System.Drawing.Point(355, 268)
        Me.ButtonDecimales.Name = "ButtonDecimales"
        Me.ButtonDecimales.Size = New System.Drawing.Size(111, 46)
        Me.ButtonDecimales.TabIndex = 2
        Me.ButtonDecimales.TabStop = False
        Me.ButtonDecimales.Text = "Button2"
        Me.ButtonDecimales.UseVisualStyleBackColor = True
        '
        'ButtonFracciones
        '
        Me.ButtonFracciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFracciones.Location = New System.Drawing.Point(533, 268)
        Me.ButtonFracciones.Name = "ButtonFracciones"
        Me.ButtonFracciones.Size = New System.Drawing.Size(111, 46)
        Me.ButtonFracciones.TabIndex = 3
        Me.ButtonFracciones.TabStop = False
        Me.ButtonFracciones.Text = "Button3"
        Me.ButtonFracciones.UseVisualStyleBackColor = True
        '
        'LabelInstrucciones
        '
        Me.LabelInstrucciones.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInstrucciones.Location = New System.Drawing.Point(363, 161)
        Me.LabelInstrucciones.Name = "LabelInstrucciones"
        Me.LabelInstrucciones.Size = New System.Drawing.Size(78, 68)
        Me.LabelInstrucciones.TabIndex = 4
        Me.LabelInstrucciones.Text = "Label1"
        '
        'ButtonSalirMenu
        '
        Me.ButtonSalirMenu.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalirMenu.Location = New System.Drawing.Point(677, 392)
        Me.ButtonSalirMenu.Name = "ButtonSalirMenu"
        Me.ButtonSalirMenu.Size = New System.Drawing.Size(111, 46)
        Me.ButtonSalirMenu.TabIndex = 5
        Me.ButtonSalirMenu.TabStop = False
        Me.ButtonSalirMenu.Text = "Button4"
        Me.ButtonSalirMenu.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonSalirMenu)
        Me.Controls.Add(Me.LabelInstrucciones)
        Me.Controls.Add(Me.ButtonFracciones)
        Me.Controls.Add(Me.ButtonDecimales)
        Me.Controls.Add(Me.ButtonPorcentajes)
        Me.Controls.Add(Me.LabelAutor)
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelAutor As Label
    Friend WithEvents ButtonPorcentajes As Button
    Friend WithEvents ButtonDecimales As Button
    Friend WithEvents ButtonFracciones As Button
    Friend WithEvents LabelInstrucciones As Label
    Friend WithEvents ButtonSalirMenu As Button
End Class
