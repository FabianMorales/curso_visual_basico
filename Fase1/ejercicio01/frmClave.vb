Public Class frmClave
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtUsuario.Text <> "admin" Then
            MessageBox.Show("El usuario no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUsuario.Focus()
            Return
        End If

        If txtClave.Text <> "1234" Then
            MessageBox.Show("La clave no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtClave.Focus()
            Return
        End If

        Me.DialogResult = DialogResult.OK
    End Sub
End Class