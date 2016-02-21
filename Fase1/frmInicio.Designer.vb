<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImagenes = New System.Windows.Forms.Button()
        Me.btnCuadratica = New System.Windows.Forms.Button()
        Me.btnInteres = New System.Windows.Forms.Button()
        Me.btnConvTemperaturas = New System.Windows.Forms.Button()
        Me.btnConvDivisas = New System.Windows.Forms.Button()
        Me.btnConvUnidades = New System.Windows.Forms.Button()
        Me.btnNomina = New System.Windows.Forms.Button()
        Me.btnFiltroTexto = New System.Windows.Forms.Button()
        Me.btnCinematica = New System.Windows.Forms.Button()
        Me.btnAcceso = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Actividad Fase 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Curso Visual Basic Básico 201416A_288"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Grupo 201416_33"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fabián Morales"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCuadratica)
        Me.GroupBox1.Controls.Add(Me.btnInteres)
        Me.GroupBox1.Controls.Add(Me.btnConvTemperaturas)
        Me.GroupBox1.Controls.Add(Me.btnConvDivisas)
        Me.GroupBox1.Controls.Add(Me.btnConvUnidades)
        Me.GroupBox1.Controls.Add(Me.btnNomina)
        Me.GroupBox1.Controls.Add(Me.btnFiltroTexto)
        Me.GroupBox1.Controls.Add(Me.btnImagenes)
        Me.GroupBox1.Controls.Add(Me.btnCinematica)
        Me.GroupBox1.Controls.Add(Me.btnAcceso)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 304)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ejercicios"
        '
        'btnImagenes
        '
        Me.btnImagenes.Image = Global.Fase1.My.Resources.Resources.imagenes
        Me.btnImagenes.Location = New System.Drawing.Point(329, 40)
        Me.btnImagenes.Name = "btnImagenes"
        Me.btnImagenes.Size = New System.Drawing.Size(147, 55)
        Me.btnImagenes.TabIndex = 2
        Me.btnImagenes.Text = "Manejo de imágenes"
        Me.btnImagenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImagenes.UseVisualStyleBackColor = True
        '
        'btnCuadratica
        '
        Me.btnCuadratica.Image = Global.Fase1.My.Resources.Resources.funcion
        Me.btnCuadratica.Location = New System.Drawing.Point(23, 223)
        Me.btnCuadratica.Name = "btnCuadratica"
        Me.btnCuadratica.Size = New System.Drawing.Size(147, 55)
        Me.btnCuadratica.TabIndex = 9
        Me.btnCuadratica.Text = "Ecuación cuadrática"
        Me.btnCuadratica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCuadratica.UseVisualStyleBackColor = True
        '
        'btnInteres
        '
        Me.btnInteres.Image = Global.Fase1.My.Resources.Resources.dinero
        Me.btnInteres.Location = New System.Drawing.Point(329, 162)
        Me.btnInteres.Name = "btnInteres"
        Me.btnInteres.Size = New System.Drawing.Size(147, 55)
        Me.btnInteres.TabIndex = 8
        Me.btnInteres.Text = "Cálculo de interés"
        Me.btnInteres.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnInteres.UseVisualStyleBackColor = True
        '
        'btnConvTemperaturas
        '
        Me.btnConvTemperaturas.Image = Global.Fase1.My.Resources.Resources.temperatura
        Me.btnConvTemperaturas.Location = New System.Drawing.Point(176, 162)
        Me.btnConvTemperaturas.Name = "btnConvTemperaturas"
        Me.btnConvTemperaturas.Size = New System.Drawing.Size(147, 55)
        Me.btnConvTemperaturas.TabIndex = 7
        Me.btnConvTemperaturas.Text = "Conversión de temperaturas"
        Me.btnConvTemperaturas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConvTemperaturas.UseVisualStyleBackColor = True
        '
        'btnConvDivisas
        '
        Me.btnConvDivisas.Image = Global.Fase1.My.Resources.Resources.divisas
        Me.btnConvDivisas.Location = New System.Drawing.Point(23, 162)
        Me.btnConvDivisas.Name = "btnConvDivisas"
        Me.btnConvDivisas.Size = New System.Drawing.Size(147, 55)
        Me.btnConvDivisas.TabIndex = 6
        Me.btnConvDivisas.Text = "Conversión de divisas"
        Me.btnConvDivisas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConvDivisas.UseVisualStyleBackColor = True
        '
        'btnConvUnidades
        '
        Me.btnConvUnidades.Image = Global.Fase1.My.Resources.Resources.calculadora
        Me.btnConvUnidades.Location = New System.Drawing.Point(329, 101)
        Me.btnConvUnidades.Name = "btnConvUnidades"
        Me.btnConvUnidades.Size = New System.Drawing.Size(147, 55)
        Me.btnConvUnidades.TabIndex = 5
        Me.btnConvUnidades.Text = "Conversión de unidades"
        Me.btnConvUnidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConvUnidades.UseVisualStyleBackColor = True
        '
        'btnNomina
        '
        Me.btnNomina.Image = Global.Fase1.My.Resources.Resources.vendedor
        Me.btnNomina.Location = New System.Drawing.Point(176, 101)
        Me.btnNomina.Name = "btnNomina"
        Me.btnNomina.Size = New System.Drawing.Size(147, 55)
        Me.btnNomina.TabIndex = 4
        Me.btnNomina.Text = "Cálculo de nómina"
        Me.btnNomina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNomina.UseVisualStyleBackColor = True
        '
        'btnFiltroTexto
        '
        Me.btnFiltroTexto.Image = CType(resources.GetObject("btnFiltroTexto.Image"), System.Drawing.Image)
        Me.btnFiltroTexto.Location = New System.Drawing.Point(23, 101)
        Me.btnFiltroTexto.Name = "btnFiltroTexto"
        Me.btnFiltroTexto.Size = New System.Drawing.Size(147, 55)
        Me.btnFiltroTexto.TabIndex = 3
        Me.btnFiltroTexto.Text = "Filtro de textos"
        Me.btnFiltroTexto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltroTexto.UseVisualStyleBackColor = True
        '
        'btnCinematica
        '
        Me.btnCinematica.Image = Global.Fase1.My.Resources.Resources.crono
        Me.btnCinematica.Location = New System.Drawing.Point(176, 40)
        Me.btnCinematica.Name = "btnCinematica"
        Me.btnCinematica.Size = New System.Drawing.Size(147, 55)
        Me.btnCinematica.TabIndex = 1
        Me.btnCinematica.Text = "Cálculo de velocidad, tiempo y distancia"
        Me.btnCinematica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCinematica.UseVisualStyleBackColor = True
        '
        'btnAcceso
        '
        Me.btnAcceso.Image = Global.Fase1.My.Resources.Resources.llaves48
        Me.btnAcceso.Location = New System.Drawing.Point(23, 40)
        Me.btnAcceso.Name = "btnAcceso"
        Me.btnAcceso.Size = New System.Drawing.Size(147, 55)
        Me.btnAcceso.TabIndex = 0
        Me.btnAcceso.Text = "Acceso con clave"
        Me.btnAcceso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAcceso.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fase1.My.Resources.Resources.logo_unad
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 479)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAcceso As Button
    Friend WithEvents btnCinematica As Button
    Friend WithEvents btnImagenes As Button
    Friend WithEvents btnFiltroTexto As Button
    Friend WithEvents btnNomina As Button
    Friend WithEvents btnConvUnidades As Button
    Friend WithEvents btnConvDivisas As Button
    Friend WithEvents btnConvTemperaturas As Button
    Friend WithEvents btnInteres As Button
    Friend WithEvents btnCuadratica As Button
End Class
