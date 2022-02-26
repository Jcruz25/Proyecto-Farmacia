<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Registro = New System.Windows.Forms.Button()
        Me.TextRegistroContraseña = New System.Windows.Forms.TextBox()
        Me.TextRegistroUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usuariosregistradoslista = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(156, 137)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Vaciar campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.Registro.Location = New System.Drawing.Point(34, 137)
        Me.Registro.Name = "Registro"
        Me.Registro.Size = New System.Drawing.Size(99, 23)
        Me.Registro.TabIndex = 18
        Me.Registro.Text = "Registrarse"
        Me.Registro.UseVisualStyleBackColor = True
        '
        'TextRegistroContraseña
        '
        Me.TextRegistroContraseña.Location = New System.Drawing.Point(167, 103)
        Me.TextRegistroContraseña.Name = "TextRegistroContraseña"
        Me.TextRegistroContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextRegistroContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextRegistroContraseña.TabIndex = 17
        '
        'TextRegistroUsuario
        '
        Me.TextRegistroUsuario.Location = New System.Drawing.Point(167, 12)
        Me.TextRegistroUsuario.Name = "TextRegistroUsuario"
        Me.TextRegistroUsuario.Size = New System.Drawing.Size(100, 20)
        Me.TextRegistroUsuario.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Ingrese su contraseña:"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(21, 60)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(88, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Administrador"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(21, 83)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(71, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Vendedor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Seleccione los privilegios del usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Ingrese nombre de usuario:"
        '
        'usuariosregistradoslista
        '
        Me.usuariosregistradoslista.FormattingEnabled = True
        Me.usuariosregistradoslista.Location = New System.Drawing.Point(145, 167)
        Me.usuariosregistradoslista.Name = "usuariosregistradoslista"
        Me.usuariosregistradoslista.Size = New System.Drawing.Size(121, 21)
        Me.usuariosregistradoslista.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Usuarios ya registrados:"
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 162)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.usuariosregistradoslista)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Registro)
        Me.Controls.Add(Me.TextRegistroContraseña)
        Me.Controls.Add(Me.TextRegistroUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormRegistro"
        Me.Text = "Farmacia Anónima - Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Registro As System.Windows.Forms.Button
    Friend WithEvents TextRegistroContraseña As System.Windows.Forms.TextBox
    Friend WithEvents TextRegistroUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents usuariosregistradoslista As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
