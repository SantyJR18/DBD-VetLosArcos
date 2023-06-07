<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportes))
        Me.titleBar = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Vet = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoRolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesYPacientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RazasYServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosYCostrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacunasYRazasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesparasitantesYRazasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacunasYEspeciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesparasitantesYEspeciesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacunasYMarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesparasitantesYMarcasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.titleBar.SuspendLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleBar
        '
        Me.titleBar.BackColor = System.Drawing.Color.DodgerBlue
        Me.titleBar.Controls.Add(Me.BtnClose)
        Me.titleBar.Controls.Add(Me.Vet)
        Me.titleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titleBar.Location = New System.Drawing.Point(61, 0)
        Me.titleBar.Margin = New System.Windows.Forms.Padding(2)
        Me.titleBar.Name = "titleBar"
        Me.titleBar.Size = New System.Drawing.Size(782, 47)
        Me.titleBar.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnClose.Location = New System.Drawing.Point(734, 10)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(31, 32)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.TabStop = False
        '
        'Vet
        '
        Me.Vet.AutoSize = True
        Me.Vet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vet.ForeColor = System.Drawing.SystemColors.Control
        Me.Vet.Location = New System.Drawing.Point(244, 12)
        Me.Vet.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Vet.Name = "Vet"
        Me.Vet.Size = New System.Drawing.Size(313, 24)
        Me.Vet.TabIndex = 0
        Me.Vet.Text = "Veterinaria Los Arcos - Reportes"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.logoVetPreview
        Me.PictureBox1.Location = New System.Drawing.Point(244, 188)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(355, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(61, 521)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(782, 50)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(61, 571)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.HuellaAnimal
        Me.PictureBox2.Location = New System.Drawing.Point(0, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(377, 98)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(191, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoRolToolStripMenuItem, Me.ClientesYPacientesToolStripMenuItem, Me.RazasYServiciosToolStripMenuItem, Me.ServiciosYCostrosToolStripMenuItem, Me.VacunasYRazasToolStripMenuItem, Me.DesparasitantesYRazasToolStripMenuItem, Me.VacunasYEspeciesToolStripMenuItem, Me.DesparasitantesYEspeciesToolStripMenuItem, Me.VacunasYMarcasToolStripMenuItem, Me.DesparasitantesYMarcasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'EmpleadoRolToolStripMenuItem
        '
        Me.EmpleadoRolToolStripMenuItem.Name = "EmpleadoRolToolStripMenuItem"
        Me.EmpleadoRolToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EmpleadoRolToolStripMenuItem.Text = "Empleados y sus roles"
        '
        'ClientesYPacientesToolStripMenuItem
        '
        Me.ClientesYPacientesToolStripMenuItem.Name = "ClientesYPacientesToolStripMenuItem"
        Me.ClientesYPacientesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClientesYPacientesToolStripMenuItem.Text = "Clientes y pacientes"
        '
        'RazasYServiciosToolStripMenuItem
        '
        Me.RazasYServiciosToolStripMenuItem.Name = "RazasYServiciosToolStripMenuItem"
        Me.RazasYServiciosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.RazasYServiciosToolStripMenuItem.Text = "Razas y servicios"
        '
        'ServiciosYCostrosToolStripMenuItem
        '
        Me.ServiciosYCostrosToolStripMenuItem.Name = "ServiciosYCostrosToolStripMenuItem"
        Me.ServiciosYCostrosToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ServiciosYCostrosToolStripMenuItem.Text = "Servicios y costos"
        '
        'VacunasYRazasToolStripMenuItem
        '
        Me.VacunasYRazasToolStripMenuItem.Name = "VacunasYRazasToolStripMenuItem"
        Me.VacunasYRazasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.VacunasYRazasToolStripMenuItem.Text = "Vacunas y razas"
        '
        'DesparasitantesYRazasToolStripMenuItem
        '
        Me.DesparasitantesYRazasToolStripMenuItem.Name = "DesparasitantesYRazasToolStripMenuItem"
        Me.DesparasitantesYRazasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DesparasitantesYRazasToolStripMenuItem.Text = "Desparasitantes y razas"
        '
        'VacunasYEspeciesToolStripMenuItem
        '
        Me.VacunasYEspeciesToolStripMenuItem.Name = "VacunasYEspeciesToolStripMenuItem"
        Me.VacunasYEspeciesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.VacunasYEspeciesToolStripMenuItem.Text = "Vacunas y especies"
        '
        'DesparasitantesYEspeciesToolStripMenuItem
        '
        Me.DesparasitantesYEspeciesToolStripMenuItem.Name = "DesparasitantesYEspeciesToolStripMenuItem"
        Me.DesparasitantesYEspeciesToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DesparasitantesYEspeciesToolStripMenuItem.Text = "Desparasitantes y especies"
        '
        'VacunasYMarcasToolStripMenuItem
        '
        Me.VacunasYMarcasToolStripMenuItem.Name = "VacunasYMarcasToolStripMenuItem"
        Me.VacunasYMarcasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.VacunasYMarcasToolStripMenuItem.Text = "Vacunas y marcas"
        '
        'DesparasitantesYMarcasToolStripMenuItem
        '
        Me.DesparasitantesYMarcasToolStripMenuItem.Name = "DesparasitantesYMarcasToolStripMenuItem"
        Me.DesparasitantesYMarcasToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DesparasitantesYMarcasToolStripMenuItem.Text = "Desparasitantes y marcas"
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 571)
        Me.Controls.Add(Me.titleBar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmReportes"
        Me.Text = "FrmReportes"
        Me.titleBar.ResumeLayout(False)
        Me.titleBar.PerformLayout()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titleBar As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Vet As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EmpleadoRolToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents ClientesYPacientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RazasYServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosYCostrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacunasYRazasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesparasitantesYRazasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacunasYEspeciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesparasitantesYEspeciesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VacunasYMarcasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DesparasitantesYMarcasToolStripMenuItem As ToolStripMenuItem
End Class
