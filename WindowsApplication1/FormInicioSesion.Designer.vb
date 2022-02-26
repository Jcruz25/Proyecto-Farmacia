<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInicioSesion))
        Me.TextContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IrRegistro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IrIngresoProductos = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.CONTRASEÑASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRASEÑASTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.CONTRASEÑASTableAdapter()
        Me.TextListadeusuarios = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRASEÑASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextContraseña
        '
        Me.TextContraseña.Location = New System.Drawing.Point(97, 42)
        Me.TextContraseña.Name = "TextContraseña"
        Me.TextContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextContraseña.Size = New System.Drawing.Size(100, 20)
        Me.TextContraseña.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CONTRASEÑA"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "INICIAR SESION"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IrRegistro
        '
        Me.IrRegistro.Location = New System.Drawing.Point(122, 68)
        Me.IrRegistro.Name = "IrRegistro"
        Me.IrRegistro.Size = New System.Drawing.Size(75, 23)
        Me.IrRegistro.TabIndex = 5
        Me.IrRegistro.Text = "REGISTRO"
        Me.IrRegistro.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(205, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'IrIngresoProductos
        '
        Me.IrIngresoProductos.Location = New System.Drawing.Point(10, 97)
        Me.IrIngresoProductos.Name = "IrIngresoProductos"
        Me.IrIngresoProductos.Size = New System.Drawing.Size(187, 23)
        Me.IrIngresoProductos.TabIndex = 8
        Me.IrIngresoProductos.Text = "INGRESAR PRODUCTOS"
        Me.IrIngresoProductos.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(187, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "VER LISTA DE PRODUCTOS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRASEÑASBindingSource
        '
        Me.CONTRASEÑASBindingSource.DataMember = "CONTRASEÑAS"
        Me.CONTRASEÑASBindingSource.DataSource = Me.Database1DataSet
        '
        'CONTRASEÑASTableAdapter
        '
        Me.CONTRASEÑASTableAdapter.ClearBeforeFill = True
        '
        'TextListadeusuarios
        '
        Me.TextListadeusuarios.DataSource = Me.CONTRASEÑASBindingSource
        Me.TextListadeusuarios.DisplayMember = "USUARIO"
        Me.TextListadeusuarios.FormattingEnabled = True
        Me.TextListadeusuarios.Location = New System.Drawing.Point(97, 14)
        Me.TextListadeusuarios.Name = "TextListadeusuarios"
        Me.TextListadeusuarios.Size = New System.Drawing.Size(100, 21)
        Me.TextListadeusuarios.TabIndex = 10
        '
        'FormInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 159)
        Me.Controls.Add(Me.TextListadeusuarios)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.IrIngresoProductos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IrRegistro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextContraseña)
        Me.Name = "FormInicioSesion"
        Me.Text = "Farmacia Anónima - Inicio de Sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRASEÑASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents IrRegistro As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents IrIngresoProductos As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents CONTRASEÑASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONTRASEÑASTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.CONTRASEÑASTableAdapter
    Friend WithEvents TextListadeusuarios As System.Windows.Forms.ComboBox

End Class
