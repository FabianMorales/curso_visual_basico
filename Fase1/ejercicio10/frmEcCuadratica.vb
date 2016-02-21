Public Class frmEcCuadratica
    Private Sub btnCmCalcular_Click(sender As Object, e As EventArgs) Handles btnCmCalcular.Click
        Dim a As Double = 0
        Double.TryParse(txtA.Text, a)

        If (a = 0) Then
            MessageBox.Show("La variable 'a' no puede ser igual a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim b As Double = 0
        Double.TryParse(txtB.Text, b)

        Dim c As Double = 0
        Double.TryParse(txtC.Text, c)

        Dim seccionRaiz As Double = (b ^ 2) - (4 * a * c)

        If seccionRaiz < 0 Then
            txtSolucion1.Text = "No tiene"
            txtSolucion2.Text = "No tiene"
        Else
            Dim solucion1 As Double = (-b + Math.Sqrt(seccionRaiz)) / (2 * a)
            Dim solucion2 As Double = (-b - Math.Sqrt(seccionRaiz)) / (2 * a)

            txtSolucion1.Text = solucion1.ToString()
            txtSolucion2.Text = solucion2.ToString()
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class