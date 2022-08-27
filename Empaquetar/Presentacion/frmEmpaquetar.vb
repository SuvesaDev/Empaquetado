Public Class frmEmpaquetar

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmteclado.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class