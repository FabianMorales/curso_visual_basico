Public Class CTemperatura
    Public Property nombre As String
    Public Property simbolo As String
    Public Property conversiones As Dictionary(Of String, Func(Of Double, Double))

    Public Sub New(nombre As String, simbolo As String, conversiones As Dictionary(Of String, Func(Of Double, Double)))
        Me.nombre = nombre
        Me.simbolo = simbolo
        Me.conversiones = conversiones
    End Sub

    Public Function convertir(unidadMedida As String, valor As Double)
        Dim ret As Double = 0

        If (unidadMedida = Me.simbolo) Then
            Return valor
        End If

        If (conversiones IsNot Nothing AndAlso conversiones.Keys.Contains(unidadMedida)) Then
            ret = Math.Round(conversiones(unidadMedida).Invoke(valor), 3)
        End If

        Return ret
    End Function
End Class
