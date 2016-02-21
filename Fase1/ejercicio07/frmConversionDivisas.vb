Public Class frmConversionDivisas

    Const dolares = 3349
    Const euros = 3727
    Const yenes = 29.74
    Const francos = 3382
    Const aud = 2394
    Const rublos = 43.47

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim pesos As Double = 0
        Double.TryParse(txtPesos.Text, pesos)
        txtUsd.Text = String.Format("{0} $USD", Math.Round(pesos / dolares, 6))
        txtEuro.Text = String.Format("{0} €", Math.Round(pesos / euros, 6))
        txtYen.Text = String.Format("{0} ¥", Math.Round(pesos / yenes, 6))
        txtChf.Text = String.Format("{0} Fr", Math.Round(pesos / francos, 6))
        txtAud.Text = String.Format("{0} $AUD", Math.Round(pesos / aud, 6))
        txtRub.Text = String.Format("{0} RUB", Math.Round(pesos / rublos, 6))
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class