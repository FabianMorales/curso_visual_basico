Public Class frmCalculoInteres
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valorInicial As Double = 0
        Double.TryParse(txtValorInicial.Text, valorInicial)

        If valorInicial <= 0 Then
            MessageBox.Show("Ha ingresado un valor no válido para el valor inicial del crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim tasaInteres As Double = 0
        Double.TryParse(txtTasa.Text, tasaInteres)

        If tasaInteres <= 0 AndAlso tasaInteres >= 100 Then
            MessageBox.Show("La tasa de interés debe estar entre el 1% y el 100%", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim duracion As Double = 0
        Integer.TryParse(txtTiempo.Text, duracion)

        If duracion <= 0 Then
            MessageBox.Show("Ha ingresado un valor no válido para la duración del crédito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If

        Dim simple As Double = (valorInicial * (tasaInteres / 100)) * duracion
        Dim compuesto As Double = (valorInicial * (1 + (tasaInteres / 100)) ^ duracion) - valorInicial

        lblSimple.Text = String.Format("{0:C0}", simple)
        lblCompuesto.Text = String.Format("{0:C0}", compuesto)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class