Public Class frmNomina

    Private Sub frmNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSalarioMinimo.Text = String.Format("{0:C0}", CEmpleado.salarioMinimo)
        lblPorComision.Text = String.Format("{0:P0}", CEmpleado.porcComision)

        Dim listaEmpleados As New List(Of CEmpleado)
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Juanito Vendedor"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Pepito Supervisor"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Jaimito Coordinador"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Fulanito Gerente"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Sultano Perez"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Perencejo Mayor"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Benito Empleado"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Tomás Vino"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Armando Casas"})
        listaEmpleados.Add(New CEmpleado() With {.nombre = "Carlitos Diez"})

        dgvEmpleados.AutoGenerateColumns = False
        dgvEmpleados.DataSource = listaEmpleados
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim listaEmpleados As List(Of CEmpleado) = CType(dgvEmpleados.DataSource, List(Of CEmpleado))

        Dim query = From a In listaEmpleados Where a.ventas <= 0 Select a

        If (query.Count() > 0) Then
            Dim empleados As String = String.Join(vbNewLine, query.Select(Function(p) p.nombre).ToArray())
            MessageBox.Show("No ha ingresado la venta de todos los empleados. Por favor ingresar este dato para estas personas: " & vbNewLine & empleados)
        End If

        For Each l In listaEmpleados
            l.calcularSalarioTotal()
        Next

        dgvEmpleados.DataSource = listaEmpleados
        dgvEmpleados.Refresh()

        lblTotalSalarios.Text = String.Format("{0:C0}", listaEmpleados.Sum(Function(p) p.salario))
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class