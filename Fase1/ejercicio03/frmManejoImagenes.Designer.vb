<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManejoImagenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManejoImagenes))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAutoAntiguo = New System.Windows.Forms.Button()
        Me.btnHelicoptero = New System.Windows.Forms.Button()
        Me.lblAutoAntiguo = New System.Windows.Forms.Label()
        Me.lblHelipcoptero = New System.Windows.Forms.Label()
        Me.lblAutoDeportivo = New System.Windows.Forms.Label()
        Me.lblAutoPolicia = New System.Windows.Forms.Label()
        Me.btnAutoDeportivo = New System.Windows.Forms.Button()
        Me.btnAutoPolicia = New System.Windows.Forms.Button()
        Me.imgDestino = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblRemolque = New System.Windows.Forms.Label()
        Me.lblCamionCarga = New System.Windows.Forms.Label()
        Me.lblCamionBomberos = New System.Windows.Forms.Label()
        Me.lblCamion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCamion = New System.Windows.Forms.Button()
        Me.btnCamionBomberos = New System.Windows.Forms.Button()
        Me.btnCamionCarga = New System.Windows.Forms.Button()
        Me.btnRemolque = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbAutoAntiguo = New System.Windows.Forms.RadioButton()
        Me.rdbHelicoptero = New System.Windows.Forms.RadioButton()
        Me.rdbAutoDeportivo = New System.Windows.Forms.RadioButton()
        Me.rdbAutoPolicia = New System.Windows.Forms.RadioButton()
        Me.rdbCamionBomberos = New System.Windows.Forms.RadioButton()
        Me.rdbCamion = New System.Windows.Forms.RadioButton()
        Me.rdbRemolque = New System.Windows.Forms.RadioButton()
        Me.rdbCamionCarga = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(598, 32)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Para cargar una imagen haga clic en el botón correspondiente o pase el mouse sobr" &
    "e la palabra correspondiente. Tambien puede seleccionar las opciones de radiobut" &
    "tons para cargar alguna imagen"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(330, 37)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Manejo de imágenes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblRemolque)
        Me.GroupBox1.Controls.Add(Me.lblCamionCarga)
        Me.GroupBox1.Controls.Add(Me.lblCamionBomberos)
        Me.GroupBox1.Controls.Add(Me.lblCamion)
        Me.GroupBox1.Controls.Add(Me.lblAutoDeportivo)
        Me.GroupBox1.Controls.Add(Me.lblAutoPolicia)
        Me.GroupBox1.Controls.Add(Me.lblHelipcoptero)
        Me.GroupBox1.Controls.Add(Me.lblAutoAntiguo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Palabras"
        '
        'btnAutoAntiguo
        '
        Me.btnAutoAntiguo.Location = New System.Drawing.Point(6, 19)
        Me.btnAutoAntiguo.Name = "btnAutoAntiguo"
        Me.btnAutoAntiguo.Size = New System.Drawing.Size(160, 23)
        Me.btnAutoAntiguo.TabIndex = 0
        Me.btnAutoAntiguo.Tag = "auto_antiguo"
        Me.btnAutoAntiguo.Text = "Auto Antiguo"
        Me.btnAutoAntiguo.UseVisualStyleBackColor = True
        '
        'btnHelicoptero
        '
        Me.btnHelicoptero.Location = New System.Drawing.Point(174, 19)
        Me.btnHelicoptero.Name = "btnHelicoptero"
        Me.btnHelicoptero.Size = New System.Drawing.Size(159, 23)
        Me.btnHelicoptero.TabIndex = 1
        Me.btnHelicoptero.Tag = "helicoptero"
        Me.btnHelicoptero.Text = "Helicóptero"
        Me.btnHelicoptero.UseVisualStyleBackColor = True
        '
        'lblAutoAntiguo
        '
        Me.lblAutoAntiguo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAutoAntiguo.Location = New System.Drawing.Point(7, 34)
        Me.lblAutoAntiguo.Name = "lblAutoAntiguo"
        Me.lblAutoAntiguo.Size = New System.Drawing.Size(160, 23)
        Me.lblAutoAntiguo.TabIndex = 0
        Me.lblAutoAntiguo.Tag = "auto_antiguo"
        Me.lblAutoAntiguo.Text = "Auto Antiguo"
        Me.lblAutoAntiguo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHelipcoptero
        '
        Me.lblHelipcoptero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHelipcoptero.Location = New System.Drawing.Point(173, 34)
        Me.lblHelipcoptero.Name = "lblHelipcoptero"
        Me.lblHelipcoptero.Size = New System.Drawing.Size(160, 23)
        Me.lblHelipcoptero.TabIndex = 1
        Me.lblHelipcoptero.Tag = "helicoptero"
        Me.lblHelipcoptero.Text = "Helicóptero"
        Me.lblHelipcoptero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutoDeportivo
        '
        Me.lblAutoDeportivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAutoDeportivo.Location = New System.Drawing.Point(173, 62)
        Me.lblAutoDeportivo.Name = "lblAutoDeportivo"
        Me.lblAutoDeportivo.Size = New System.Drawing.Size(160, 23)
        Me.lblAutoDeportivo.TabIndex = 3
        Me.lblAutoDeportivo.Tag = "deportivo"
        Me.lblAutoDeportivo.Text = "Auto deportivo"
        Me.lblAutoDeportivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAutoPolicia
        '
        Me.lblAutoPolicia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAutoPolicia.Location = New System.Drawing.Point(7, 62)
        Me.lblAutoPolicia.Name = "lblAutoPolicia"
        Me.lblAutoPolicia.Size = New System.Drawing.Size(160, 23)
        Me.lblAutoPolicia.TabIndex = 2
        Me.lblAutoPolicia.Tag = "auto_policia"
        Me.lblAutoPolicia.Text = "Auto de policía"
        Me.lblAutoPolicia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAutoDeportivo
        '
        Me.btnAutoDeportivo.Location = New System.Drawing.Point(174, 48)
        Me.btnAutoDeportivo.Name = "btnAutoDeportivo"
        Me.btnAutoDeportivo.Size = New System.Drawing.Size(159, 23)
        Me.btnAutoDeportivo.TabIndex = 3
        Me.btnAutoDeportivo.Tag = "deportivo"
        Me.btnAutoDeportivo.Text = "Auto deportivo"
        Me.btnAutoDeportivo.UseVisualStyleBackColor = True
        '
        'btnAutoPolicia
        '
        Me.btnAutoPolicia.Location = New System.Drawing.Point(6, 48)
        Me.btnAutoPolicia.Name = "btnAutoPolicia"
        Me.btnAutoPolicia.Size = New System.Drawing.Size(160, 23)
        Me.btnAutoPolicia.TabIndex = 2
        Me.btnAutoPolicia.Tag = "auto_policia"
        Me.btnAutoPolicia.Text = "Auto de policía"
        Me.btnAutoPolicia.UseVisualStyleBackColor = True
        '
        'imgDestino
        '
        Me.imgDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.imgDestino.Location = New System.Drawing.Point(360, 105)
        Me.imgDestino.Name = "imgDestino"
        Me.imgDestino.Size = New System.Drawing.Size(250, 250)
        Me.imgDestino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgDestino.TabIndex = 0
        Me.imgDestino.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(516, 527)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 40)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.imagenes
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'lblRemolque
        '
        Me.lblRemolque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRemolque.Location = New System.Drawing.Point(173, 118)
        Me.lblRemolque.Name = "lblRemolque"
        Me.lblRemolque.Size = New System.Drawing.Size(160, 23)
        Me.lblRemolque.TabIndex = 7
        Me.lblRemolque.Tag = "remolque"
        Me.lblRemolque.Text = "Remolque"
        Me.lblRemolque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCamionCarga
        '
        Me.lblCamionCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCamionCarga.Location = New System.Drawing.Point(7, 118)
        Me.lblCamionCarga.Name = "lblCamionCarga"
        Me.lblCamionCarga.Size = New System.Drawing.Size(160, 23)
        Me.lblCamionCarga.TabIndex = 6
        Me.lblCamionCarga.Tag = "camion_carga"
        Me.lblCamionCarga.Text = "Camión de carga"
        Me.lblCamionCarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCamionBomberos
        '
        Me.lblCamionBomberos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCamionBomberos.Location = New System.Drawing.Point(173, 90)
        Me.lblCamionBomberos.Name = "lblCamionBomberos"
        Me.lblCamionBomberos.Size = New System.Drawing.Size(160, 23)
        Me.lblCamionBomberos.TabIndex = 5
        Me.lblCamionBomberos.Tag = "camion_bomberos"
        Me.lblCamionBomberos.Text = "Camión de bomberos"
        Me.lblCamionBomberos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCamion
        '
        Me.lblCamion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCamion.Location = New System.Drawing.Point(7, 90)
        Me.lblCamion.Name = "lblCamion"
        Me.lblCamion.Size = New System.Drawing.Size(160, 23)
        Me.lblCamion.TabIndex = 4
        Me.lblCamion.Tag = "camion"
        Me.lblCamion.Text = "Camión"
        Me.lblCamion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCamion)
        Me.GroupBox2.Controls.Add(Me.btnCamionBomberos)
        Me.GroupBox2.Controls.Add(Me.btnCamionCarga)
        Me.GroupBox2.Controls.Add(Me.btnRemolque)
        Me.GroupBox2.Controls.Add(Me.btnAutoAntiguo)
        Me.GroupBox2.Controls.Add(Me.btnHelicoptero)
        Me.GroupBox2.Controls.Add(Me.btnAutoPolicia)
        Me.GroupBox2.Controls.Add(Me.btnAutoDeportivo)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones"
        '
        'btnCamion
        '
        Me.btnCamion.Location = New System.Drawing.Point(6, 77)
        Me.btnCamion.Name = "btnCamion"
        Me.btnCamion.Size = New System.Drawing.Size(160, 23)
        Me.btnCamion.TabIndex = 4
        Me.btnCamion.Tag = "camion"
        Me.btnCamion.Text = "Camión"
        Me.btnCamion.UseVisualStyleBackColor = True
        '
        'btnCamionBomberos
        '
        Me.btnCamionBomberos.Location = New System.Drawing.Point(174, 77)
        Me.btnCamionBomberos.Name = "btnCamionBomberos"
        Me.btnCamionBomberos.Size = New System.Drawing.Size(159, 23)
        Me.btnCamionBomberos.TabIndex = 5
        Me.btnCamionBomberos.Tag = "camion_bomberos"
        Me.btnCamionBomberos.Text = "Camión de bomberos"
        Me.btnCamionBomberos.UseVisualStyleBackColor = True
        '
        'btnCamionCarga
        '
        Me.btnCamionCarga.Location = New System.Drawing.Point(6, 106)
        Me.btnCamionCarga.Name = "btnCamionCarga"
        Me.btnCamionCarga.Size = New System.Drawing.Size(160, 23)
        Me.btnCamionCarga.TabIndex = 6
        Me.btnCamionCarga.Tag = "camion_carga"
        Me.btnCamionCarga.Text = "Camión de carga"
        Me.btnCamionCarga.UseVisualStyleBackColor = True
        '
        'btnRemolque
        '
        Me.btnRemolque.Location = New System.Drawing.Point(174, 106)
        Me.btnRemolque.Name = "btnRemolque"
        Me.btnRemolque.Size = New System.Drawing.Size(159, 23)
        Me.btnRemolque.TabIndex = 7
        Me.btnRemolque.Tag = "remolque"
        Me.btnRemolque.Text = "Remolque"
        Me.btnRemolque.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbRemolque)
        Me.GroupBox3.Controls.Add(Me.rdbCamionCarga)
        Me.GroupBox3.Controls.Add(Me.rdbCamionBomberos)
        Me.GroupBox3.Controls.Add(Me.rdbCamion)
        Me.GroupBox3.Controls.Add(Me.rdbAutoDeportivo)
        Me.GroupBox3.Controls.Add(Me.rdbAutoPolicia)
        Me.GroupBox3.Controls.Add(Me.rdbHelicoptero)
        Me.GroupBox3.Controls.Add(Me.rdbAutoAntiguo)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 412)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 151)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Radios"
        '
        'rdbAutoAntiguo
        '
        Me.rdbAutoAntiguo.AutoSize = True
        Me.rdbAutoAntiguo.Location = New System.Drawing.Point(6, 20)
        Me.rdbAutoAntiguo.Name = "rdbAutoAntiguo"
        Me.rdbAutoAntiguo.Size = New System.Drawing.Size(85, 17)
        Me.rdbAutoAntiguo.TabIndex = 0
        Me.rdbAutoAntiguo.TabStop = True
        Me.rdbAutoAntiguo.Tag = "auto_antiguo"
        Me.rdbAutoAntiguo.Text = "Auto antiguo"
        Me.rdbAutoAntiguo.UseVisualStyleBackColor = True
        '
        'rdbHelicoptero
        '
        Me.rdbHelicoptero.AutoSize = True
        Me.rdbHelicoptero.Location = New System.Drawing.Point(174, 19)
        Me.rdbHelicoptero.Name = "rdbHelicoptero"
        Me.rdbHelicoptero.Size = New System.Drawing.Size(79, 17)
        Me.rdbHelicoptero.TabIndex = 1
        Me.rdbHelicoptero.TabStop = True
        Me.rdbHelicoptero.Tag = "helicoptero"
        Me.rdbHelicoptero.Text = "Helicóptero"
        Me.rdbHelicoptero.UseVisualStyleBackColor = True
        '
        'rdbAutoDeportivo
        '
        Me.rdbAutoDeportivo.AutoSize = True
        Me.rdbAutoDeportivo.Location = New System.Drawing.Point(174, 42)
        Me.rdbAutoDeportivo.Name = "rdbAutoDeportivo"
        Me.rdbAutoDeportivo.Size = New System.Drawing.Size(94, 17)
        Me.rdbAutoDeportivo.TabIndex = 3
        Me.rdbAutoDeportivo.TabStop = True
        Me.rdbAutoDeportivo.Tag = "deportivo"
        Me.rdbAutoDeportivo.Text = "Auto deportivo"
        Me.rdbAutoDeportivo.UseVisualStyleBackColor = True
        '
        'rdbAutoPolicia
        '
        Me.rdbAutoPolicia.AutoSize = True
        Me.rdbAutoPolicia.Location = New System.Drawing.Point(6, 43)
        Me.rdbAutoPolicia.Name = "rdbAutoPolicia"
        Me.rdbAutoPolicia.Size = New System.Drawing.Size(97, 17)
        Me.rdbAutoPolicia.TabIndex = 2
        Me.rdbAutoPolicia.TabStop = True
        Me.rdbAutoPolicia.Tag = "auto_policia"
        Me.rdbAutoPolicia.Text = "Auto de policía"
        Me.rdbAutoPolicia.UseVisualStyleBackColor = True
        '
        'rdbCamionBomberos
        '
        Me.rdbCamionBomberos.AutoSize = True
        Me.rdbCamionBomberos.Location = New System.Drawing.Point(174, 65)
        Me.rdbCamionBomberos.Name = "rdbCamionBomberos"
        Me.rdbCamionBomberos.Size = New System.Drawing.Size(124, 17)
        Me.rdbCamionBomberos.TabIndex = 5
        Me.rdbCamionBomberos.TabStop = True
        Me.rdbCamionBomberos.Tag = "camion_bomberos"
        Me.rdbCamionBomberos.Text = "Camión de bomberos"
        Me.rdbCamionBomberos.UseVisualStyleBackColor = True
        '
        'rdbCamion
        '
        Me.rdbCamion.AutoSize = True
        Me.rdbCamion.Location = New System.Drawing.Point(6, 66)
        Me.rdbCamion.Name = "rdbCamion"
        Me.rdbCamion.Size = New System.Drawing.Size(60, 17)
        Me.rdbCamion.TabIndex = 4
        Me.rdbCamion.TabStop = True
        Me.rdbCamion.Tag = "camion"
        Me.rdbCamion.Text = "Camión"
        Me.rdbCamion.UseVisualStyleBackColor = True
        '
        'rdbRemolque
        '
        Me.rdbRemolque.AutoSize = True
        Me.rdbRemolque.Location = New System.Drawing.Point(174, 88)
        Me.rdbRemolque.Name = "rdbRemolque"
        Me.rdbRemolque.Size = New System.Drawing.Size(73, 17)
        Me.rdbRemolque.TabIndex = 7
        Me.rdbRemolque.TabStop = True
        Me.rdbRemolque.Tag = "remolque"
        Me.rdbRemolque.Text = "Remolque"
        Me.rdbRemolque.UseVisualStyleBackColor = True
        '
        'rdbCamionCarga
        '
        Me.rdbCamionCarga.AutoSize = True
        Me.rdbCamionCarga.Location = New System.Drawing.Point(6, 89)
        Me.rdbCamionCarga.Name = "rdbCamionCarga"
        Me.rdbCamionCarga.Size = New System.Drawing.Size(105, 17)
        Me.rdbCamionCarga.TabIndex = 6
        Me.rdbCamionCarga.TabStop = True
        Me.rdbCamionCarga.Tag = "camion_carga"
        Me.rdbCamionCarga.Text = "Camión de carga"
        Me.rdbCamionCarga.UseVisualStyleBackColor = True
        '
        'frmManejoImagenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 579)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.imgDestino)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManejoImagenes"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manejo de imágenes"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.imgDestino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblAutoDeportivo As Label
    Friend WithEvents lblAutoPolicia As Label
    Friend WithEvents btnAutoDeportivo As Button
    Friend WithEvents btnAutoPolicia As Button
    Friend WithEvents lblHelipcoptero As Label
    Friend WithEvents lblAutoAntiguo As Label
    Friend WithEvents btnHelicoptero As Button
    Friend WithEvents btnAutoAntiguo As Button
    Friend WithEvents imgDestino As PictureBox
    Friend WithEvents lblRemolque As Label
    Friend WithEvents lblCamionCarga As Label
    Friend WithEvents lblCamionBomberos As Label
    Friend WithEvents lblCamion As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCamion As Button
    Friend WithEvents btnCamionBomberos As Button
    Friend WithEvents btnCamionCarga As Button
    Friend WithEvents btnRemolque As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbRemolque As RadioButton
    Friend WithEvents rdbCamionCarga As RadioButton
    Friend WithEvents rdbCamionBomberos As RadioButton
    Friend WithEvents rdbCamion As RadioButton
    Friend WithEvents rdbAutoDeportivo As RadioButton
    Friend WithEvents rdbAutoPolicia As RadioButton
    Friend WithEvents rdbHelicoptero As RadioButton
    Friend WithEvents rdbAutoAntiguo As RadioButton
End Class
