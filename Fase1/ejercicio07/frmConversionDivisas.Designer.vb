<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversionDivisas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConversionDivisas))
        Me.grbCentimetros = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRub = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAud = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtChf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtYen = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEuro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsd = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPesos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbCentimetros.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbCentimetros
        '
        Me.grbCentimetros.Controls.Add(Me.Label9)
        Me.grbCentimetros.Controls.Add(Me.txtRub)
        Me.grbCentimetros.Controls.Add(Me.Label8)
        Me.grbCentimetros.Controls.Add(Me.txtAud)
        Me.grbCentimetros.Controls.Add(Me.Label7)
        Me.grbCentimetros.Controls.Add(Me.txtChf)
        Me.grbCentimetros.Controls.Add(Me.Label6)
        Me.grbCentimetros.Controls.Add(Me.txtYen)
        Me.grbCentimetros.Controls.Add(Me.Label5)
        Me.grbCentimetros.Controls.Add(Me.txtEuro)
        Me.grbCentimetros.Controls.Add(Me.Label4)
        Me.grbCentimetros.Controls.Add(Me.txtUsd)
        Me.grbCentimetros.Controls.Add(Me.btnCalcular)
        Me.grbCentimetros.Controls.Add(Me.Label3)
        Me.grbCentimetros.Controls.Add(Me.txtPesos)
        Me.grbCentimetros.Location = New System.Drawing.Point(15, 99)
        Me.grbCentimetros.Name = "grbCentimetros"
        Me.grbCentimetros.Size = New System.Drawing.Size(288, 289)
        Me.grbCentimetros.TabIndex = 35
        Me.grbCentimetros.TabStop = False
        Me.grbCentimetros.Text = "Pesos colombianos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Tag = ""
        Me.Label9.Text = "Rublo Ruso"
        '
        'txtRub
        '
        Me.txtRub.Location = New System.Drawing.Point(99, 195)
        Me.txtRub.Name = "txtRub"
        Me.txtRub.ReadOnly = True
        Me.txtRub.Size = New System.Drawing.Size(133, 20)
        Me.txtRub.TabIndex = 39
        Me.txtRub.Tag = "RUB"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 172)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Tag = ""
        Me.Label8.Text = "Dólar Australiano"
        '
        'txtAud
        '
        Me.txtAud.Location = New System.Drawing.Point(99, 169)
        Me.txtAud.Name = "txtAud"
        Me.txtAud.ReadOnly = True
        Me.txtAud.Size = New System.Drawing.Size(133, 20)
        Me.txtAud.TabIndex = 37
        Me.txtAud.Tag = "AUD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Tag = ""
        Me.Label7.Text = "Franco suizo"
        '
        'txtChf
        '
        Me.txtChf.Location = New System.Drawing.Point(99, 143)
        Me.txtChf.Name = "txtChf"
        Me.txtChf.ReadOnly = True
        Me.txtChf.Size = New System.Drawing.Size(133, 20)
        Me.txtChf.TabIndex = 35
        Me.txtChf.Tag = "CHF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Tag = ""
        Me.Label6.Text = "Yen japonés"
        '
        'txtYen
        '
        Me.txtYen.Location = New System.Drawing.Point(99, 117)
        Me.txtYen.Name = "txtYen"
        Me.txtYen.ReadOnly = True
        Me.txtYen.Size = New System.Drawing.Size(133, 20)
        Me.txtYen.TabIndex = 33
        Me.txtYen.Tag = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Tag = ""
        Me.Label5.Text = "Euro"
        '
        'txtEuro
        '
        Me.txtEuro.Location = New System.Drawing.Point(99, 91)
        Me.txtEuro.Name = "txtEuro"
        Me.txtEuro.ReadOnly = True
        Me.txtEuro.Size = New System.Drawing.Size(133, 20)
        Me.txtEuro.TabIndex = 31
        Me.txtEuro.Tag = "E"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Dólar EEUU"
        '
        'txtUsd
        '
        Me.txtUsd.Location = New System.Drawing.Point(99, 65)
        Me.txtUsd.Name = "txtUsd"
        Me.txtUsd.ReadOnly = True
        Me.txtUsd.Size = New System.Drawing.Size(133, 20)
        Me.txtUsd.TabIndex = 29
        Me.txtUsd.Tag = "USD"
        '
        'btnCalcular
        '
        Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcular.Image = Global.Fase1.My.Resources.Resources.procesar
        Me.btnCalcular.Location = New System.Drawing.Point(187, 243)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(95, 40)
        Me.btnCalcular.TabIndex = 28
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcular.UseVisualStyleBackColor = True
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
        'txtPesos
        '
        Me.txtPesos.Location = New System.Drawing.Point(99, 24)
        Me.txtPesos.Name = "txtPesos"
        Me.txtPesos.Size = New System.Drawing.Size(133, 20)
        Me.txtPesos.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(401, 32)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Ingrese el valor en centímetros pesos colombianos y haga clic en el botón Calcula" &
    "r. Se mostrará la conversión a cada moneda en su respectiva casilla de texto"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(354, 348)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.divisas
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 37)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Conversión de unidades"
        '
        'frmConversionDivisas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 402)
        Me.Controls.Add(Me.grbCentimetros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConversionDivisas"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conversión de Divisas"
        Me.grbCentimetros.ResumeLayout(False)
        Me.grbCentimetros.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbCentimetros As GroupBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPesos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtYen As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEuro As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsd As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtAud As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtChf As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRub As TextBox
End Class
