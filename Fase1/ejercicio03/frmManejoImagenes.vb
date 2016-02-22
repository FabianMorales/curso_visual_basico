Public Class frmManejoImagenes
    Dim listaImagenes As New Dictionary(Of String, Image)

    Private Sub frmManejoImagenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listaImagenes.Add("auto_antiguo", My.Resources.auto_antiguo)
        listaImagenes.Add("auto_policia", My.Resources.auto_policia)
        listaImagenes.Add("deportivo", My.Resources.deportivo)
        listaImagenes.Add("camion_bomberos", My.Resources.camion_bomberos)
        listaImagenes.Add("camion", My.Resources.camion)
        listaImagenes.Add("camion_carga", My.Resources.camion_carga)
        listaImagenes.Add("remolque", My.Resources.remolque)
        listaImagenes.Add("helicoptero", My.Resources.helicoptero)

    End Sub

    Private Sub lblAutoAntiguo_MouseHover(sender As Object, e As EventArgs) Handles lblRemolque.MouseHover, lblHelipcoptero.MouseHover, lblCamionCarga.MouseHover, lblCamionBomberos.MouseHover, lblCamion.MouseHover, lblAutoPolicia.MouseHover, lblAutoDeportivo.MouseHover, lblAutoAntiguo.MouseHover
        Dim lbl As Label = CType(sender, Label)
        If listaImagenes.ContainsKey(lbl.Tag.ToString()) Then
            imgDestino.Image = listaImagenes(lbl.Tag.ToString())
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAutoAntiguo_Click(sender As Object, e As EventArgs) Handles btnRemolque.Click, btnHelicoptero.Click, btnCamionCarga.Click, btnCamionBomberos.Click, btnCamion.Click, btnAutoPolicia.Click, btnAutoDeportivo.Click, btnAutoAntiguo.Click
        Dim btn As Button = CType(sender, Button)
        If listaImagenes.ContainsKey(btn.Tag.ToString()) Then
            imgDestino.Image = listaImagenes(btn.Tag.ToString())
        End If
    End Sub

    Private Sub rdbAutoAntiguo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbRemolque.CheckedChanged, rdbHelicoptero.CheckedChanged, rdbCamionCarga.CheckedChanged, rdbCamionBomberos.CheckedChanged, rdbCamion.CheckedChanged, rdbAutoPolicia.CheckedChanged, rdbAutoDeportivo.CheckedChanged, rdbAutoAntiguo.CheckedChanged
        Dim rdb As RadioButton = CType(sender, RadioButton)
        If rdb.Checked Then
            If listaImagenes.ContainsKey(rdb.Tag.ToString()) Then
                imgDestino.Image = listaImagenes(rdb.Tag.ToString())
            End If
        End If
    End Sub
End Class