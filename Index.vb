Public Class Index
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInsertar.Click
        FrmInsertarComponentes.Show()
    End Sub

    Private Sub btnVer_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        FrmVerComponentes.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        FrmBuscarComponentes.Show()
    End Sub
End Class