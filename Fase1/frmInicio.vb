Public Class frmInicio
    Private Sub btnAcceso_Click(sender As Object, e As EventArgs) Handles btnAcceso.Click
        Dim frm As New frmClave
        If frm.ShowDialog() = DialogResult.OK Then
            Dim frmSecreto As New frmAreaSecreta
            frmSecreto.ShowDialog()
        Else
            MessageBox.Show("Acceso denegado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCinematica_Click(sender As Object, e As EventArgs) Handles btnCinematica.Click
        Dim frm As New frmCinematica
        frm.ShowDialog()
    End Sub

    Private Sub btnFiltroTexto_Click(sender As Object, e As EventArgs) Handles btnFiltroTexto.Click
        Dim frm As New frmFiltroTexto
        frm.ShowDialog()
    End Sub

    Private Sub btnNomina_Click(sender As Object, e As EventArgs) Handles btnNomina.Click
        Dim frm As New frmNomina
        frm.ShowDialog()
    End Sub

    Private Sub btnConvUnidades_Click(sender As Object, e As EventArgs) Handles btnConvUnidades.Click
        Dim frm As New frmConversionUnidades
        frm.ShowDialog()
    End Sub

    Private Sub btnConvDivisas_Click(sender As Object, e As EventArgs) Handles btnConvDivisas.Click
        Dim frm As New frmConversionDivisas
        frm.ShowDialog()
    End Sub

    Private Sub btnConvTemperaturas_Click(sender As Object, e As EventArgs) Handles btnConvTemperaturas.Click
        Dim frm As New frmConversionTemp
        frm.ShowDialog()
    End Sub

    Private Sub btnInteres_Click(sender As Object, e As EventArgs) Handles btnInteres.Click
        Dim frm As New frmCalculoInteres
        frm.ShowDialog()
    End Sub

    Private Sub btnCuadratica_Click(sender As Object, e As EventArgs) Handles btnCuadratica.Click
        Dim frm As New frmEcCuadratica
        frm.ShowDialog()
    End Sub

    Private Sub btnImagenes_Click(sender As Object, e As EventArgs) Handles btnImagenes.Click
        Dim frm As New frmManejoImagenes
        frm.ShowDialog()
    End Sub
End Class
