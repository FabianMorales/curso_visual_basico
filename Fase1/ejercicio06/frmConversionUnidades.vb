Public Class frmConversionUnidades

    Dim conversionCm As New Dictionary(Of String, Double)
    Dim conversionKm As New Dictionary(Of String, Double)

    Private Sub frmConversionUnidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conversionCm.Add("inch", 1 / 2.54)
        conversionCm.Add("m", 0.01)
        conversionCm.Add("mm", 10)
        conversionCm.Add("km", 0.00001)

        conversionKm.Add("m", 1000)
        conversionKm.Add("cm", 100000)
        conversionKm.Add("milla", 1 / 1.609344)
        conversionKm.Add("yard", 1 / 0.0009144)
        conversionKm.Add("feet", 1 / 0.00030480000000000004)
        conversionKm.Add("inch", 1 / 0.000025399999999999997)
    End Sub

    Private Sub btnCmCalcular_Click(sender As Object, e As EventArgs) Handles btnCmCalcular.Click
        Dim valorCm As Double = 0
        Double.TryParse(txtCm.Text, valorCm)

        Dim query = From a In grbCentimetros.Controls
                    Where TypeOf (a) Is RadioButton _
                    AndAlso CType(a, RadioButton).Checked
                    Select CType(a, RadioButton)

        Dim radio As RadioButton = query.First
        Dim res As Double = Math.Round(valorCm * conversionCm(radio.Tag.ToString()), 5)

        lblCmResultado.Text = String.Format("{0} Cm = {1} {2}", valorCm, res, radio.Text)
    End Sub

    Private Sub btnKmCalcular_Click(sender As Object, e As EventArgs) Handles btnKmCalcular.Click
        Dim valorKm As Double = 0
        Double.TryParse(txtKm.Text, valorKm)

        Dim query = From a In grbKilometros.Controls
                    Where TypeOf (a) Is RadioButton _
                    AndAlso CType(a, RadioButton).Checked
                    Select CType(a, RadioButton)

        Dim radio As RadioButton = query.First
        Dim res As Double = Math.Round(valorKm * conversionKm(radio.Tag.ToString()), 5)

        lblKmResultado.Text = String.Format("{0} Km = {1} {2}", valorKm, res, radio.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class