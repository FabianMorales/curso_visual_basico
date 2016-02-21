<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNomina
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNomina))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comision = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSalarioMinimo = New System.Windows.Forms.Label()
        Me.lblPorComision = New System.Windows.Forms.Label()
        Me.lblTotalSalarios = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(486, 423)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.vendedor
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 37)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cálculo de nómina"
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.ventas, Me.comision, Me.salario})
        Me.dgvEmpleados.Location = New System.Drawing.Point(12, 157)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(569, 260)
        Me.dgvEmpleados.TabIndex = 22
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre empleado"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'ventas
        '
        Me.ventas.DataPropertyName = "ventas"
        Me.ventas.HeaderText = "Ventas"
        Me.ventas.Name = "ventas"
        '
        'comision
        '
        Me.comision.DataPropertyName = "comision"
        DataGridViewCellStyle1.Format = "C0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.comision.DefaultCellStyle = DataGridViewCellStyle1
        Me.comision.HeaderText = "Comisión ganada"
        Me.comision.Name = "comision"
        Me.comision.ReadOnly = True
        '
        'salario
        '
        Me.salario.DataPropertyName = "salario"
        DataGridViewCellStyle2.Format = "C0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.salario.DefaultCellStyle = DataGridViewCellStyle2
        Me.salario.HeaderText = "Salario a pagar"
        Me.salario.Name = "salario"
        Me.salario.ReadOnly = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Fase1.My.Resources.Resources.procesar
        Me.btnCalcular.Location = New System.Drawing.Point(385, 423)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(95, 40)
        Me.btnCalcular.TabIndex = 23
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Ingrese las ventas por cada empleado en la celda correspondiente y luego haga cli" &
    "c en el botón calcular. Debe llenar todos los datos para poder realizar el cálcu" &
    "lo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Salario mínimo legal vigente: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Porcentaje de comisión:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Total de salarios: "
        '
        'lblSalarioMinimo
        '
        Me.lblSalarioMinimo.AutoSize = True
        Me.lblSalarioMinimo.Location = New System.Drawing.Point(193, 95)
        Me.lblSalarioMinimo.Name = "lblSalarioMinimo"
        Me.lblSalarioMinimo.Size = New System.Drawing.Size(22, 13)
        Me.lblSalarioMinimo.TabIndex = 28
        Me.lblSalarioMinimo.Text = "$ 0"
        '
        'lblPorComision
        '
        Me.lblPorComision.AutoSize = True
        Me.lblPorComision.Location = New System.Drawing.Point(161, 113)
        Me.lblPorComision.Name = "lblPorComision"
        Me.lblPorComision.Size = New System.Drawing.Size(21, 13)
        Me.lblPorComision.TabIndex = 29
        Me.lblPorComision.Text = "0%"
        '
        'lblTotalSalarios
        '
        Me.lblTotalSalarios.AutoSize = True
        Me.lblTotalSalarios.Location = New System.Drawing.Point(127, 132)
        Me.lblTotalSalarios.Name = "lblTotalSalarios"
        Me.lblTotalSalarios.Size = New System.Drawing.Size(22, 13)
        Me.lblTotalSalarios.TabIndex = 30
        Me.lblTotalSalarios.Text = "$ 0"
        '
        'frmNomina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 475)
        Me.Controls.Add(Me.lblTotalSalarios)
        Me.Controls.Add(Me.lblPorComision)
        Me.Controls.Add(Me.lblSalarioMinimo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNomina"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de nómina"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents btnCalcular As Button
    Friend WithEvents salario As DataGridViewTextBoxColumn
    Friend WithEvents comision As DataGridViewTextBoxColumn
    Friend WithEvents ventas As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblSalarioMinimo As Label
    Friend WithEvents lblPorComision As Label
    Friend WithEvents lblTotalSalarios As Label
End Class
