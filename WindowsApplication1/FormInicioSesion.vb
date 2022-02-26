Public Class FormInicioSesion


    Private Sub IrRegistro_Click(sender As Object, e As EventArgs) Handles IrRegistro.Click
        My.Forms.FormRegistro = FormRegistro
        FormRegistro.Show()


    End Sub

    Private Sub IrIngresoProductos_Click(sender As Object, e As EventArgs) Handles IrIngresoProductos.Click
        My.Forms.FormInventario = FormInventario
        FormInventario.Show()
    End Sub

    Public Sub TextListadeusuarios_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Database1DataSet.CONTRASEÑAS' Puede moverla o quitarla según sea necesario.
        Me.CONTRASEÑASTableAdapter.Fill(Me.Database1DataSet.CONTRASEÑAS)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextListadeusuarios.Text = "Prueba" Then TextListadeusuarios.Text = ""
        If TextContraseña.Text = "1234" Then MessageBox.Show("Sesión iniciada correctamente")
        If TextContraseña.Text = "" Then MessageBox.Show("Datos Erroneos")

    End Sub
End Class
