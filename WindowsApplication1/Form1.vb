Public Class FormInventario

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TBNombreProducto.Text = ""
        TBCantidad.Text = ""
        TBPrincipioActivo.Text = ""
        TBStock.Text = ""
        TBTipoMedicamento.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Cantidad, Principio, Stock, TipoMedicamento, NombreProducto As String

        Cantidad = TBNombreProducto.Text
        Principio = TBPrincipioActivo.Text
        Stock = TBStock.Text
        TipoMedicamento = TBTipoMedicamento.Text
        NombreProducto = TBNombreProducto.Text

        MessageBox.Show("Información ingresada correctamente")
        TBNombreProducto.Text = ""
        TBCantidad.Text = ""
        TBPrincipioActivo.Text = ""
        TBStock.Text = ""
        TBTipoMedicamento.Text = ""

        'Data Source=|DataDirectory|\Database1.sdf 

    End Sub
End Class