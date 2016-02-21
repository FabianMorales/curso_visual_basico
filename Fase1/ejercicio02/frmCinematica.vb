Public Class frmCinematica

    Dim variableProcesar As String = ""

    Private Function calcularDistancia() As Double
        If (String.IsNullOrWhiteSpace(cbxUnidadVel.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para la velocidad")
        End If

        If (String.IsNullOrWhiteSpace(cbxUnidadTiempo.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para el tiempo")
        End If

        Dim velocidad As Double = convertirVelocidad()
        Dim tiempo As Double = convertirTiempo()
        Dim distancia As Double = velocidad * tiempo

        Return distancia
    End Function

    Private Function calcularTiempo() As Double
        If (String.IsNullOrWhiteSpace(cbxUnidadVel.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para la velocidad")
        End If

        If (String.IsNullOrWhiteSpace(cbxUnidadDistancia.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para la distancia")
        End If

        Dim velocidad As Double = convertirVelocidad()

        If (velocidad < 0) Then
            Throw New Exception("La velocidad no puede ser igual a cero")
        End If

        Dim distancia As Double = convertirDistancia()
        Dim tiempo As Double = distancia / velocidad

        Return tiempo
    End Function

    Private Function calcularVelocidad() As Double
        If (String.IsNullOrWhiteSpace(cbxUnidadTiempo.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para el tiempo")
        End If

        If (String.IsNullOrWhiteSpace(cbxUnidadDistancia.Text)) Then
            Throw New Exception("Debe seleccionar la unidad de medida para la distancia")
        End If

        Dim tiempo As Double = convertirTiempo()

        If (tiempo < 0) Then
            Throw New Exception("El tiempo no puede ser igual a cero")
        End If

        Dim distancia As Double = convertirDistancia()

        Dim velocidad As Double = distancia / tiempo

        Return velocidad
    End Function

    Private Function convertirVelocidad() As Double
        Dim ret As Double = 0
        Dim valor As Double = Math.Abs(Double.Parse(txtValorVel.Text))
        Select Case cbxUnidadVel.Text
            Case "Km/h"
                ret = valor
            Case "Km/min"
                ret = valor * 60
            Case "Km/s"
                ret = valor * 3600
            Case "m/h"
                ret = valor / 1000
            Case "m/min"
                ret = valor * 60 / 1000
            Case "m/s"
                ret = valor * 3600 / 1000
        End Select

        Return ret
    End Function

    Private Function convertirTiempo() As Double
        Dim ret As Double = 0
        Dim valor As Double = Math.Abs(Double.Parse(txtValorTiempo.Text))
        Select Case cbxUnidadTiempo.Text
            Case "h"
                ret = valor
            Case "m"
                ret = valor / 60
            Case "s"
                ret = valor / 3600
        End Select

        Return ret
    End Function

    Public Function convertirDistancia() As Double
        Dim ret As Double = 0
        Dim valor As Double = Math.Abs(Double.Parse(txtDistancia.Text))
        Select Case cbxUnidadDistancia.Text
            Case "Km"
                ret = valor
            Case "m"
                ret = valor / 1000
        End Select

        Return ret
    End Function

    Private Sub btnCalcularVel_Click(sender As Object, e As EventArgs) Handles btnCalcularVel.Click
        Try
            txtValorVel.Text = calcularVelocidad().ToString
            cbxUnidadVel.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCalcularTiempo_Click(sender As Object, e As EventArgs) Handles btnCalcularTiempo.Click
        Try
            txtValorTiempo.Text = calcularTiempo().ToString
            cbxUnidadTiempo.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCalcularDistancia_Click(sender As Object, e As EventArgs) Handles btnCalcularDistancia.Click
        Try
            txtDistancia.Text = calcularDistancia().ToString
            cbxUnidadDistancia.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class