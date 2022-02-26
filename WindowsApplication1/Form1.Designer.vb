<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventario
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBTipoMedicamento = New System.Windows.Forms.ComboBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.TBPrincipioActivo = New System.Windows.Forms.TextBox()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(209, 117)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Ingresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBTipoMedicamento
        '
        Me.TBTipoMedicamento.FormattingEnabled = True
        Me.TBTipoMedicamento.Items.AddRange(New Object() {"Psicotrópico", "Importado", "Nacional"})
        Me.TBTipoMedicamento.Location = New System.Drawing.Point(209, 73)
        Me.TBTipoMedicamento.Name = "TBTipoMedicamento"
        Me.TBTipoMedicamento.Size = New System.Drawing.Size(175, 21)
        Me.TBTipoMedicamento.TabIndex = 21
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(9, 73)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(52, 20)
        Me.TBCantidad.TabIndex = 20
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(12, 26)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(157, 20)
        Me.TBNombreProducto.TabIndex = 19
        '
        'TBPrincipioActivo
        '
        Me.TBPrincipioActivo.Location = New System.Drawing.Point(209, 26)
        Me.TBPrincipioActivo.Name = "TBPrincipioActivo"
        Me.TBPrincipioActivo.Size = New System.Drawing.Size(175, 20)
        Me.TBPrincipioActivo.TabIndex = 18
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(107, 73)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(72, 20)
        Me.TBStock.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tipo de medicamento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Stock mínimo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Precio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre del Producto:"
        '
        'FormInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 158)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBTipoMedicamento)
        Me.Controls.Add(Me.TBCantidad)
        Me.Controls.Add(Me.TBNombreProducto)
        Me.Controls.Add(Me.TBPrincipioActivo)
        Me.Controls.Add(Me.TBStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormInventario"
        Me.Text = "Farmacia Anónima - Ingreso productos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TBTipoMedicamento As System.Windows.Forms.ComboBox
    Friend WithEvents TBCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TBNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents TBPrincipioActivo As System.Windows.Forms.TextBox
    Friend WithEvents TBStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
