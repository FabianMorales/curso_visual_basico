Public Class frmConversionTemp
    Dim conversionC As New Dictionary(Of String, Func(Of Double, Double))
    Dim conversionF As New Dictionary(Of String, Func(Of Double, Double))
    Dim conversionK As New Dictionary(Of String, Func(Of Double, Double))
    Dim listaUnidades As New List(Of CTemperatura)

    Private Sub frmConversionTemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conversionC.Add("°F", Function(c As Double) c * 1.8 + 32)
        conversionC.Add("°K", Function(c As Double) c + 273.15)

        conversionF.Add("°C", Function(f As Double) (f - 32) / 1.8)
        conversionF.Add("°K", Function(f As Double) 5 / 9 * (f - 32) + 273.15)

        conversionK.Add("°C", Function(k As Double) k - 273.15)
        conversionK.Add("°F", Function(k As Double) 1.8 * (k - 273.15) + 32)

        listaUnidades.Add(New CTemperatura("Centígrados", "°C", conversionC))
        listaUnidades.Add(New CTemperatura("Farenheit", "°F", conversionF))
        listaUnidades.Add(New CTemperatura("Kelvin", "°K", conversionC))

        lstInicial.DataSource = listaUnidades.ToList()
        lstFinal.DataSource = listaUnidades.ToList()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim inicial As CTemperatura = CType(lstInicial.SelectedItem, CTemperatura)
        If inicial Is Nothing Then
            MessageBox.Show("Debe seleccionar la unidad de medida temperatura inicial", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim final As CTemperatura = CType(lstFinal.SelectedItem, CTemperatura)
        If final Is Nothing Then
            MessageBox.Show("Debe seleccionar la unidad de medida temperatura a la que desea convertir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim valor As Double = 0
        Double.TryParse(txtTemp.Text, valor)

        Dim res As Double = inicial.convertir(final.simbolo, valor)

        lblResultado.Text = String.Format("{0}{1} = {2}{3}", valor, inicial.simbolo, res, final.simbolo)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class