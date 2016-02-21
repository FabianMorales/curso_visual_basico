<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversionUnidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversionUnidades))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCmCalcular = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbCentimetros = New System.Windows.Forms.GroupBox()
        Me.lblCmResultado = New System.Windows.Forms.Label()
        Me.rdbCmKilometros = New System.Windows.Forms.RadioButton()
        Me.rdbCmMilimetros = New System.Windows.Forms.RadioButton()
        Me.rdbCmMetros = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCm = New System.Windows.Forms.TextBox()
        Me.rdbCmPulgadas = New System.Windows.Forms.RadioButton()
        Me.grbKilometros = New System.Windows.Forms.GroupBox()
        Me.rdbPies = New System.Windows.Forms.RadioButton()
        Me.rdbKmYardas = New System.Windows.Forms.RadioButton()
        Me.lblKmResultado = New System.Windows.Forms.Label()
        Me.btnKmCalcular = New System.Windows.Forms.Button()
        Me.rdbKmMillas = New System.Windows.Forms.RadioButton()
        Me.rdbCentimetros = New System.Windows.Forms.RadioButton()
        Me.rdbKmMetros = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbCentimetros.SuspendLayout()
        Me.grbKilometros.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 32)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Ingrese el valor en centímetros o kilómetros, seleccione la unidad a la que desea" &
    " convertir y haga clic en el botón Calcular"
        '
        'btnCmCalcular
        '
        Me.btnCmCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCmCalcular.Image = Global.Fase1.My.Resources.Resources.procesar
        Me.btnCmCalcular.Location = New System.Drawing.Point(9, 187)
        Me.btnCmCalcular.Name = "btnCmCalcular"
        Me.btnCmCalcular.Size = New System.Drawing.Size(95, 40)
        Me.btnCmCalcular.TabIndex = 5
        Me.btnCmCalcular.Text = "Calcular"
        Me.btnCmCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCmCalcular.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(505, 394)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.calculadora
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 37)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Conversión de unidades"
        '
        'grbCentimetros
        '
        Me.grbCentimetros.Controls.Add(Me.lblCmResultado)
        Me.grbCentimetros.Controls.Add(Me.rdbCmKilometros)
        Me.grbCentimetros.Controls.Add(Me.rdbCmMilimetros)
        Me.grbCentimetros.Controls.Add(Me.btnCmCalcular)
        Me.grbCentimetros.Controls.Add(Me.rdbCmMetros)
        Me.grbCentimetros.Controls.Add(Me.Label3)
        Me.grbCentimetros.Controls.Add(Me.txtCm)
        Me.grbCentimetros.Controls.Add(Me.rdbCmPulgadas)
        Me.grbCentimetros.Location = New System.Drawing.Point(15, 99)
        Me.grbCentimetros.Name = "grbCentimetros"
        Me.grbCentimetros.Size = New System.Drawing.Size(288, 289)
        Me.grbCentimetros.TabIndex = 0
        Me.grbCentimetros.TabStop = False
        Me.grbCentimetros.Text = "Centímetros"
        '
        'lblCmResultado
        '
        Me.lblCmResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCmResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCmResultado.Location = New System.Drawing.Point(9, 230)
        Me.lblCmResultado.Name = "lblCmResultado"
        Me.lblCmResultado.Size = New System.Drawing.Size(273, 56)
        Me.lblCmResultado.TabIndex = 27
        Me.lblCmResultado.Text = "-"
        Me.lblCmResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdbCmKilometros
        '
        Me.rdbCmKilometros.AutoSize = True
        Me.rdbCmKilometros.Location = New System.Drawing.Point(6, 119)
        Me.rdbCmKilometros.Name = "rdbCmKilometros"
        Me.rdbCmKilometros.Size = New System.Drawing.Size(73, 17)
        Me.rdbCmKilometros.TabIndex = 4
        Me.rdbCmKilometros.Tag = "km"
        Me.rdbCmKilometros.Text = "Kilómetros"
        Me.rdbCmKilometros.UseVisualStyleBackColor = True
        '
        'rdbCmMilimetros
        '
        Me.rdbCmMilimetros.AutoSize = True
        Me.rdbCmMilimetros.Location = New System.Drawing.Point(6, 96)
        Me.rdbCmMilimetros.Name = "rdbCmMilimetros"
        Me.rdbCmMilimetros.Size = New System.Drawing.Size(73, 17)
        Me.rdbCmMilimetros.TabIndex = 3
        Me.rdbCmMilimetros.Tag = "mm"
        Me.rdbCmMilimetros.Text = "Milímetros"
        Me.rdbCmMilimetros.UseVisualStyleBackColor = True
        '
        'rdbCmMetros
        '
        Me.rdbCmMetros.AutoSize = True
        Me.rdbCmMetros.Location = New System.Drawing.Point(6, 73)
        Me.rdbCmMetros.Name = "rdbCmMetros"
        Me.rdbCmMetros.Size = New System.Drawing.Size(57, 17)
        Me.rdbCmMetros.TabIndex = 2
        Me.rdbCmMetros.Tag = "m"
        Me.rdbCmMetros.Text = "Metros"
        Me.rdbCmMetros.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Valor"
        '
        'txtCm
        '
        Me.txtCm.Location = New System.Drawing.Point(83, 24)
        Me.txtCm.Name = "txtCm"
        Me.txtCm.Size = New System.Drawing.Size(82, 20)
        Me.txtCm.TabIndex = 0
        '
        'rdbCmPulgadas
        '
        Me.rdbCmPulgadas.AutoSize = True
        Me.rdbCmPulgadas.Checked = True
        Me.rdbCmPulgadas.Location = New System.Drawing.Point(6, 50)
        Me.rdbCmPulgadas.Name = "rdbCmPulgadas"
        Me.rdbCmPulgadas.Size = New System.Drawing.Size(69, 17)
        Me.rdbCmPulgadas.TabIndex = 1
        Me.rdbCmPulgadas.TabStop = True
        Me.rdbCmPulgadas.Tag = "inch"
        Me.rdbCmPulgadas.Text = "Pulgadas"
        Me.rdbCmPulgadas.UseVisualStyleBackColor = True
        '
        'grbKilometros
        '
        Me.grbKilometros.Controls.Add(Me.rdbPies)
        Me.grbKilometros.Controls.Add(Me.rdbKmYardas)
        Me.grbKilometros.Controls.Add(Me.lblKmResultado)
        Me.grbKilometros.Controls.Add(Me.btnKmCalcular)
        Me.grbKilometros.Controls.Add(Me.rdbKmMillas)
        Me.grbKilometros.Controls.Add(Me.rdbCentimetros)
        Me.grbKilometros.Controls.Add(Me.rdbKmMetros)
        Me.grbKilometros.Controls.Add(Me.Label5)
        Me.grbKilometros.Controls.Add(Me.txtKm)
        Me.grbKilometros.Controls.Add(Me.RadioButton4)
        Me.grbKilometros.Location = New System.Drawing.Point(309, 95)
        Me.grbKilometros.Name = "grbKilometros"
        Me.grbKilometros.Size = New System.Drawing.Size(291, 293)
        Me.grbKilometros.TabIndex = 1
        Me.grbKilometros.TabStop = False
        Me.grbKilometros.Text = "Kilómetros"
        '
        'rdbPies
        '
        Me.rdbPies.AutoSize = True
        Me.rdbPies.Location = New System.Drawing.Point(6, 143)
        Me.rdbPies.Name = "rdbPies"
        Me.rdbPies.Size = New System.Drawing.Size(45, 17)
        Me.rdbPies.TabIndex = 5
        Me.rdbPies.Tag = "feet"
        Me.rdbPies.Text = "Pies"
        Me.rdbPies.UseVisualStyleBackColor = True
        '
        'rdbKmYardas
        '
        Me.rdbKmYardas.AutoSize = True
        Me.rdbKmYardas.Location = New System.Drawing.Point(6, 120)
        Me.rdbKmYardas.Name = "rdbKmYardas"
        Me.rdbKmYardas.Size = New System.Drawing.Size(58, 17)
        Me.rdbKmYardas.TabIndex = 4
        Me.rdbKmYardas.Tag = "yard"
        Me.rdbKmYardas.Text = "Yardas"
        Me.rdbKmYardas.UseVisualStyleBackColor = True
        '
        'lblKmResultado
        '
        Me.lblKmResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKmResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKmResultado.Location = New System.Drawing.Point(6, 234)
        Me.lblKmResultado.Name = "lblKmResultado"
        Me.lblKmResultado.Size = New System.Drawing.Size(279, 56)
        Me.lblKmResultado.TabIndex = 27
        Me.lblKmResultado.Text = "-"
        Me.lblKmResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKmCalcular
        '
        Me.btnKmCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKmCalcular.Image = Global.Fase1.My.Resources.Resources.procesar
        Me.btnKmCalcular.Location = New System.Drawing.Point(6, 191)
        Me.btnKmCalcular.Name = "btnKmCalcular"
        Me.btnKmCalcular.Size = New System.Drawing.Size(95, 40)
        Me.btnKmCalcular.TabIndex = 7
        Me.btnKmCalcular.Text = "Calcular"
        Me.btnKmCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKmCalcular.UseVisualStyleBackColor = True
        '
        'rdbKmMillas
        '
        Me.rdbKmMillas.AutoSize = True
        Me.rdbKmMillas.Location = New System.Drawing.Point(6, 97)
        Me.rdbKmMillas.Name = "rdbKmMillas"
        Me.rdbKmMillas.Size = New System.Drawing.Size(51, 17)
        Me.rdbKmMillas.TabIndex = 3
        Me.rdbKmMillas.Tag = "milla"
        Me.rdbKmMillas.Text = "Millas"
        Me.rdbKmMillas.UseVisualStyleBackColor = True
        '
        'rdbCentimetros
        '
        Me.rdbCentimetros.AutoSize = True
        Me.rdbCentimetros.Location = New System.Drawing.Point(6, 74)
        Me.rdbCentimetros.Name = "rdbCentimetros"
        Me.rdbCentimetros.Size = New System.Drawing.Size(82, 17)
        Me.rdbCentimetros.TabIndex = 2
        Me.rdbCentimetros.Tag = "cm"
        Me.rdbCentimetros.Text = "Centímetros"
        Me.rdbCentimetros.UseVisualStyleBackColor = True
        '
        'rdbKmMetros
        '
        Me.rdbKmMetros.AutoSize = True
        Me.rdbKmMetros.Checked = True
        Me.rdbKmMetros.Location = New System.Drawing.Point(6, 51)
        Me.rdbKmMetros.Name = "rdbKmMetros"
        Me.rdbKmMetros.Size = New System.Drawing.Size(57, 17)
        Me.rdbKmMetros.TabIndex = 1
        Me.rdbKmMetros.TabStop = True
        Me.rdbKmMetros.Tag = "m"
        Me.rdbKmMetros.Text = "Metros"
        Me.rdbKmMetros.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Valor"
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(83, 24)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(82, 20)
        Me.txtKm.TabIndex = 0
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 166)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.Tag = "inch"
        Me.RadioButton4.Text = "Pulgadas"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'frmConversionUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 446)
        Me.Controls.Add(Me.grbKilometros)
        Me.Controls.Add(Me.grbCentimetros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversionUnidades"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversión de unidades"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbCentimetros.ResumeLayout(False)
        Me.grbCentimetros.PerformLayout()
        Me.grbKilometros.ResumeLayout(False)
        Me.grbKilometros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnCmCalcular As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grbCentimetros As GroupBox
    Friend WithEvents rdbCmPulgadas As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCm As TextBox
    Friend WithEvents rdbCmMetros As RadioButton
    Friend WithEvents rdbCmMilimetros As RadioButton
    Friend WithEvents rdbCmKilometros As RadioButton
    Friend WithEvents lblCmResultado As Label
    Friend WithEvents grbKilometros As GroupBox
    Friend WithEvents lblKmResultado As Label
    Friend WithEvents rdbKmMillas As RadioButton
    Friend WithEvents rdbCentimetros As RadioButton
    Friend WithEvents rdbKmMetros As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKm As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents rdbPies As RadioButton
    Friend WithEvents rdbKmYardas As RadioButton
    Friend WithEvents btnKmCalcular As Button
End Class
