<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelEspacio = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.BtnCerrarSes = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.BtnDesparasitacion = New System.Windows.Forms.Button()
        Me.BtnVacunas = New System.Windows.Forms.Button()
        Me.BtnDiagnostico = New System.Windows.Forms.Button()
        Me.BtnServicio = New System.Windows.Forms.Button()
        Me.BtnPaciente = New System.Windows.Forms.Button()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.LblVet = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm.SuspendLayout()
        Me.TitleBar.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.SystemColors.Control
        Me.PanelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelChildForm.Controls.Add(Me.LblVet)
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.ForeColor = System.Drawing.Color.SteelBlue
        Me.PanelChildForm.Location = New System.Drawing.Point(185, 38)
        Me.PanelChildForm.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(843, 571)
        Me.PanelChildForm.TabIndex = 1
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.White
        Me.TitleBar.Controls.Add(Me.BtnMinimize)
        Me.TitleBar.Controls.Add(Me.BtnClose)
        Me.TitleBar.Controls.Add(Me.Panel1)
        Me.TitleBar.Controls.Add(Me.BtnCerrar)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(1028, 38)
        Me.TitleBar.TabIndex = 5
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimize.Image = Global.ProyectoF.My.Resources.Resources.minicon
        Me.BtnMinimize.Location = New System.Drawing.Point(960, 7)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMinimize.TabIndex = 3
        Me.BtnMinimize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnClose.Location = New System.Drawing.Point(991, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(25, 25)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Azure
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 38)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.logoVetPreview
        Me.PictureBox1.Location = New System.Drawing.Point(0, -1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Location = New System.Drawing.Point(1176, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'PanelEspacio
        '
        Me.PanelEspacio.Location = New System.Drawing.Point(2, 2)
        Me.PanelEspacio.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelEspacio.Name = "PanelEspacio"
        Me.PanelEspacio.Size = New System.Drawing.Size(188, 28)
        Me.PanelEspacio.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 37)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 102)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel2.TabIndex = 6
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(0, 167)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel3.TabIndex = 8
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(0, 232)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel4.TabIndex = 10
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(0, 297)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel5.TabIndex = 12
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(0, 362)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(188, 28)
        Me.FlowLayoutPanel6.TabIndex = 14
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.DodgerBlue
        Me.PanelMenu.Controls.Add(Me.BtnCerrarSes)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel8)
        Me.PanelMenu.Controls.Add(Me.BtnReportes)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel6)
        Me.PanelMenu.Controls.Add(Me.BtnDesparasitacion)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel5)
        Me.PanelMenu.Controls.Add(Me.BtnVacunas)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel4)
        Me.PanelMenu.Controls.Add(Me.BtnDiagnostico)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel3)
        Me.PanelMenu.Controls.Add(Me.BtnServicio)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel2)
        Me.PanelMenu.Controls.Add(Me.BtnPaciente)
        Me.PanelMenu.Controls.Add(Me.FlowLayoutPanel1)
        Me.PanelMenu.Controls.Add(Me.BtnCliente)
        Me.PanelMenu.Controls.Add(Me.PanelEspacio)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 38)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(188, 571)
        Me.PanelMenu.TabIndex = 6
        '
        'BtnCerrarSes
        '
        Me.BtnCerrarSes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCerrarSes.FlatAppearance.BorderSize = 0
        Me.BtnCerrarSes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarSes.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSes.Image = CType(resources.GetObject("BtnCerrarSes.Image"), System.Drawing.Image)
        Me.BtnCerrarSes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarSes.Location = New System.Drawing.Point(0, 494)
        Me.BtnCerrarSes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarSes.Name = "BtnCerrarSes"
        Me.BtnCerrarSes.Size = New System.Drawing.Size(188, 37)
        Me.BtnCerrarSes.TabIndex = 21
        Me.BtnCerrarSes.Text = "Cerrar Sesión"
        Me.BtnCerrarSes.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(0, 427)
        Me.FlowLayoutPanel8.Margin = New System.Windows.Forms.Padding(2)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(188, 67)
        Me.FlowLayoutPanel8.TabIndex = 19
        '
        'BtnReportes
        '
        Me.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.Color.White
        Me.BtnReportes.Image = Global.ProyectoF.My.Resources.Resources.MenuInforme
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 390)
        Me.BtnReportes.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(188, 37)
        Me.BtnReportes.TabIndex = 18
        Me.BtnReportes.Text = "   Reportes"
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'BtnDesparasitacion
        '
        Me.BtnDesparasitacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDesparasitacion.FlatAppearance.BorderSize = 0
        Me.BtnDesparasitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDesparasitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDesparasitacion.ForeColor = System.Drawing.Color.White
        Me.BtnDesparasitacion.Image = Global.ProyectoF.My.Resources.Resources.medicina24
        Me.BtnDesparasitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDesparasitacion.Location = New System.Drawing.Point(0, 325)
        Me.BtnDesparasitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDesparasitacion.Name = "BtnDesparasitacion"
        Me.BtnDesparasitacion.Size = New System.Drawing.Size(188, 37)
        Me.BtnDesparasitacion.TabIndex = 13
        Me.BtnDesparasitacion.Text = "   Desparasitación"
        Me.BtnDesparasitacion.UseVisualStyleBackColor = True
        '
        'BtnVacunas
        '
        Me.BtnVacunas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVacunas.FlatAppearance.BorderSize = 0
        Me.BtnVacunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVacunas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVacunas.ForeColor = System.Drawing.Color.White
        Me.BtnVacunas.Image = Global.ProyectoF.My.Resources.Resources.vac24
        Me.BtnVacunas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVacunas.Location = New System.Drawing.Point(0, 260)
        Me.BtnVacunas.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnVacunas.Name = "BtnVacunas"
        Me.BtnVacunas.Size = New System.Drawing.Size(188, 37)
        Me.BtnVacunas.TabIndex = 11
        Me.BtnVacunas.Text = "   Vacunas"
        Me.BtnVacunas.UseVisualStyleBackColor = True
        '
        'BtnDiagnostico
        '
        Me.BtnDiagnostico.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnDiagnostico.FlatAppearance.BorderSize = 0
        Me.BtnDiagnostico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDiagnostico.ForeColor = System.Drawing.Color.White
        Me.BtnDiagnostico.Image = Global.ProyectoF.My.Resources.Resources.MenuDiag
        Me.BtnDiagnostico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDiagnostico.Location = New System.Drawing.Point(0, 195)
        Me.BtnDiagnostico.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnDiagnostico.Name = "BtnDiagnostico"
        Me.BtnDiagnostico.Size = New System.Drawing.Size(188, 37)
        Me.BtnDiagnostico.TabIndex = 9
        Me.BtnDiagnostico.Text = "   Diagnóstico"
        Me.BtnDiagnostico.UseVisualStyleBackColor = True
        '
        'BtnServicio
        '
        Me.BtnServicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnServicio.FlatAppearance.BorderSize = 0
        Me.BtnServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnServicio.ForeColor = System.Drawing.Color.White
        Me.BtnServicio.Image = Global.ProyectoF.My.Resources.Resources.MenuServicio
        Me.BtnServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnServicio.Location = New System.Drawing.Point(0, 130)
        Me.BtnServicio.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnServicio.Name = "BtnServicio"
        Me.BtnServicio.Size = New System.Drawing.Size(188, 37)
        Me.BtnServicio.TabIndex = 7
        Me.BtnServicio.Text = "   Servicio"
        Me.BtnServicio.UseVisualStyleBackColor = True
        '
        'BtnPaciente
        '
        Me.BtnPaciente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPaciente.FlatAppearance.BorderSize = 0
        Me.BtnPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPaciente.ForeColor = System.Drawing.Color.White
        Me.BtnPaciente.Image = Global.ProyectoF.My.Resources.Resources.MenuPaciente
        Me.BtnPaciente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPaciente.Location = New System.Drawing.Point(0, 65)
        Me.BtnPaciente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPaciente.Name = "BtnPaciente"
        Me.BtnPaciente.Size = New System.Drawing.Size(188, 37)
        Me.BtnPaciente.TabIndex = 5
        Me.BtnPaciente.Text = "   Registro Paciente"
        Me.BtnPaciente.UseVisualStyleBackColor = True
        '
        'BtnCliente
        '
        Me.BtnCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnCliente.FlatAppearance.BorderSize = 0
        Me.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCliente.ForeColor = System.Drawing.Color.White
        Me.BtnCliente.Image = Global.ProyectoF.My.Resources.Resources.MenuCliente
        Me.BtnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCliente.Location = New System.Drawing.Point(0, 0)
        Me.BtnCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(188, 37)
        Me.BtnCliente.TabIndex = 3
        Me.BtnCliente.Text = "   Registro Cliente"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'LblVet
        '
        Me.LblVet.AutoSize = True
        Me.LblVet.Font = New System.Drawing.Font("Georgia", 25.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVet.Location = New System.Drawing.Point(225, 455)
        Me.LblVet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblVet.Name = "LblVet"
        Me.LblVet.Size = New System.Drawing.Size(421, 41)
        Me.LblVet.TabIndex = 1
        Me.LblVet.Text = "Veterinaria Los Arcos"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.la_tienda_de_animales
        Me.PictureBox2.Location = New System.Drawing.Point(209, 123)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(427, 325)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.TitleBar)
        Me.Controls.Add(Me.PanelChildForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelChildForm.ResumeLayout(False)
        Me.PanelChildForm.PerformLayout()
        Me.TitleBar.ResumeLayout(False)
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TitleBar As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents PanelEspacio As FlowLayoutPanel
    Friend WithEvents BtnCliente As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents BtnPaciente As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents BtnServicio As Button
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents BtnDiagnostico As Button
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents BtnVacunas As Button
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents BtnDesparasitacion As Button
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents BtnCerrarSes As Button
    Friend WithEvents LblVet As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
