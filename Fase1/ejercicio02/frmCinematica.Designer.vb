<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCinematica
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCinematica))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDistancia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxUnidadDistancia = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtValorTiempo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxUnidadTiempo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtValorVel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxUnidadVel = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCalcularTiempo = New System.Windows.Forms.Button()
        Me.btnCalcularVel = New System.Windows.Forms.Button()
        Me.btnCalcularDistancia = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDistancia)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.cbxUnidadDistancia)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(231, 82)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Distancia"
        '
        'txtDistancia
        '
        Me.txtDistancia.Location = New System.Drawing.Point(6, 47)
        Me.txtDistancia.Name = "txtDistancia"
        Me.txtDistancia.Size = New System.Drawing.Size(82, 20)
        Me.txtDistancia.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(92, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Unidad de medida"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valor"
        '
        'cbxUnidadDistancia
        '
        Me.cbxUnidadDistancia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadDistancia.FormattingEnabled = True
        Me.cbxUnidadDistancia.Items.AddRange(New Object() {"Km", "m"})
        Me.cbxUnidadDistancia.Location = New System.Drawing.Point(94, 47)
        Me.cbxUnidadDistancia.Name = "cbxUnidadDistancia"
        Me.cbxUnidadDistancia.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnidadDistancia.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtValorTiempo)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbxUnidadTiempo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(231, 82)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempo"
        '
        'txtValorTiempo
        '
        Me.txtValorTiempo.Location = New System.Drawing.Point(6, 47)
        Me.txtValorTiempo.Name = "txtValorTiempo"
        Me.txtValorTiempo.Size = New System.Drawing.Size(82, 20)
        Me.txtValorTiempo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Unidad de medida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Valor"
        '
        'cbxUnidadTiempo
        '
        Me.cbxUnidadTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadTiempo.FormattingEnabled = True
        Me.cbxUnidadTiempo.Items.AddRange(New Object() {"h", "m", "s"})
        Me.cbxUnidadTiempo.Location = New System.Drawing.Point(94, 47)
        Me.cbxUnidadTiempo.Name = "cbxUnidadTiempo"
        Me.cbxUnidadTiempo.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnidadTiempo.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtValorVel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxUnidadVel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 82)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Velocidad"
        '
        'txtValorVel
        '
        Me.txtValorVel.Location = New System.Drawing.Point(6, 47)
        Me.txtValorVel.Name = "txtValorVel"
        Me.txtValorVel.Size = New System.Drawing.Size(82, 20)
        Me.txtValorVel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Unidad de medida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor"
        '
        'cbxUnidadVel
        '
        Me.cbxUnidadVel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxUnidadVel.FormattingEnabled = True
        Me.cbxUnidadVel.Items.AddRange(New Object() {"Km/h", "Km/min", "Km/s", "m/h", "m/min", "m/s"})
        Me.cbxUnidadVel.Location = New System.Drawing.Point(94, 47)
        Me.cbxUnidadVel.Name = "cbxUnidadVel"
        Me.cbxUnidadVel.Size = New System.Drawing.Size(121, 21)
        Me.cbxUnidadVel.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(500, 32)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Ingrese los valores, seleccione la unidad de medida necesaria y haga clic en el b" &
    "otón para calcular la variable deseada"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(368, 37)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cálculos de cinemática"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.crono
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnCalcularTiempo
        '
        Me.btnCalcularTiempo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularTiempo.Image = Global.Fase1.My.Resources.Resources.tiempo
        Me.btnCalcularTiempo.Location = New System.Drawing.Point(269, 426)
        Me.btnCalcularTiempo.Name = "btnCalcularTiempo"
        Me.btnCalcularTiempo.Size = New System.Drawing.Size(95, 40)
        Me.btnCalcularTiempo.TabIndex = 4
        Me.btnCalcularTiempo.Text = "Calcular tiempo"
        Me.btnCalcularTiempo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcularTiempo.UseVisualStyleBackColor = True
        '
        'btnCalcularVel
        '
        Me.btnCalcularVel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularVel.Image = Global.Fase1.My.Resources.Resources.velocidad
        Me.btnCalcularVel.Location = New System.Drawing.Point(168, 426)
        Me.btnCalcularVel.Name = "btnCalcularVel"
        Me.btnCalcularVel.Size = New System.Drawing.Size(95, 40)
        Me.btnCalcularVel.TabIndex = 3
        Me.btnCalcularVel.Text = "Calcular velocidad"
        Me.btnCalcularVel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcularVel.UseVisualStyleBackColor = True
        '
        'btnCalcularDistancia
        '
        Me.btnCalcularDistancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalcularDistancia.Image = Global.Fase1.My.Resources.Resources.distancia
        Me.btnCalcularDistancia.Location = New System.Drawing.Point(370, 426)
        Me.btnCalcularDistancia.Name = "btnCalcularDistancia"
        Me.btnCalcularDistancia.Size = New System.Drawing.Size(95, 40)
        Me.btnCalcularDistancia.TabIndex = 5
        Me.btnCalcularDistancia.Text = "Calcular distancia"
        Me.btnCalcularDistancia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCalcularDistancia.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(471, 426)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmCinematica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 478)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCalcularTiempo)
        Me.Controls.Add(Me.btnCalcularVel)
        Me.Controls.Add(Me.btnCalcularDistancia)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCinematica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCinematica"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDistancia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbxUnidadDistancia As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtValorTiempo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbxUnidadTiempo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbxUnidadVel As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtValorVel As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCalcularDistancia As Button
    Friend WithEvents btnCalcularVel As Button
    Friend WithEvents btnCalcularTiempo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
End Class
