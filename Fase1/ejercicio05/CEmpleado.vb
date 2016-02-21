Public Class CEmpleado

    Public Const salarioMinimo As Double = 689454
    Public Const porcComision As Double = 0.05

    Property nombre As String
    Property ventas As Double
    Property comision As Double
    Property salario As Double

    Public Function calcularSalarioTotal() As Double
        Me.comision = Me.ventas * porcComision
        Me.salario = salarioMinimo + Me.comision
        Return Me.salario
    End Function
End Class
