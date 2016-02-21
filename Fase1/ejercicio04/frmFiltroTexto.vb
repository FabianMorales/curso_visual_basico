Public Class frmFiltroTexto
    Private Sub txtNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumeros.KeyPress
        If Not Information.IsNumeric(e.KeyChar) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txtMayusculas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMayusculas.KeyPress
        e.KeyChar = e.KeyChar.ToString.ToUpper()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class