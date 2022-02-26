Public Class FormRegistro

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextRegistroContraseña.Text = ""
        TextRegistroUsuario.Text = ""
    End Sub

    Private Sub TextRegistroUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextRegistroUsuario.TextChanged

    End Sub

    Private Sub Registro_Click(sender As Object, e As EventArgs) Handles Registro.Click
        If TextRegistroUsuario.TextLength = 0 Then
            MessageBox.Show("Ingrese un nombre de usuario valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextRegistroUsuario.Focus()

            'Else
            'usuariosregistradoslista.Items.Add(TextRegistroUsuario)
            'TextRegistroUsuario.Clear()
            'TextRegistroUsuario.Focus()
        End If
        If TextRegistroUsuario.TextLength > 0 Then
            MessageBox.Show("Usuario registrado correctamente")
        End If
        Using FormInicioSesion As New FormInicioSesion
            FormInicioSesion.ShowDialog()
        End Using
    End Sub
End Class