Imports System.Data.OleDb
Public Class FormRegistro
    Dim conexion As OleDbConnection
    Dim comandos As OleDbCommand
    Dim User1 As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Registro.Click
        '    If TxtRegistroUsuario.TextLength = 0 Then
        '        MessageBox.Show("Ingrese una palabra", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        TxtRegistroUsuario.Focus()

        '    Else
        '        Textlistadeusuarios.Items.Add(TxtPalabra.Text)
        '        TxtPalabra.Clear()
        '        TxtPalabra.Focus()

        '    End If
        'End Sub
    End Sub

    Private Sub TextRegistroUsuario_TextChanged(sender As Object, e As EventArgs) Handles TextRegistroUsuario.TextChanged

    End Sub
End Class
