<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientesM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPacientesM))
        Me.TCPacientesMed = New System.Windows.Forms.TabControl()
        Me.TPPacMedico = New System.Windows.Forms.TabPage()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetPacMed = New System.Windows.Forms.TabPage()
        Me.TPPacientesMed = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtBIdPac = New System.Windows.Forms.TextBox()
        Me.TxtNombrePac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.CmbRazaPac = New System.Windows.Forms.ComboBox()
        Me.CmbEspeciePac = New System.Windows.Forms.ComboBox()
        Me.DtPac = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtSenPar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtColorPac = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPac = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TPExpDuenio = New System.Windows.Forms.TabPage()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TBapellidoClt = New System.Windows.Forms.TextBox()
        Me.TBtelClt = New System.Windows.Forms.TextBox()
        Me.TBdireccionClt = New System.Windows.Forms.TextBox()
        Me.TBcorreoClt = New System.Windows.Forms.TextBox()
        Me.TBnombreClt = New System.Windows.Forms.TextBox()
        Me.TBcedulaClt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesMed.SuspendLayout()
        Me.TPPacMedico.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacMed.SuspendLayout()
        Me.TPPacientesMed.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPExpDuenio.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCPacientesMed
        '
        Me.TCPacientesMed.Controls.Add(Me.TPPacMedico)
        Me.TCPacientesMed.Controls.Add(Me.TPDetPacMed)
        Me.TCPacientesMed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientesMed.Location = New System.Drawing.Point(0, 47)
        Me.TCPacientesMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TCPacientesMed.Name = "TCPacientesMed"
        Me.TCPacientesMed.SelectedIndex = 0
        Me.TCPacientesMed.Size = New System.Drawing.Size(1124, 656)
        Me.TCPacientesMed.TabIndex = 5
        '
        'TPPacMedico
        '
        Me.TPPacMedico.BackColor = System.Drawing.Color.SeaShell
        Me.TPPacMedico.Controls.Add(Me.GbRegistros)
        Me.TPPacMedico.Controls.Add(Me.PictureBox3)
        Me.TPPacMedico.Controls.Add(Me.PictureBox2)
        Me.TPPacMedico.Controls.Add(Me.Label17)
        Me.TPPacMedico.Controls.Add(Me.txtBusqueda)
        Me.TPPacMedico.Location = New System.Drawing.Point(4, 25)
        Me.TPPacMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPacMedico.Name = "TPPacMedico"
        Me.TPPacMedico.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPacMedico.Size = New System.Drawing.Size(1116, 627)
        Me.TPPacMedico.TabIndex = 0
        Me.TPPacMedico.Text = "Pacientes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(32, 164)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(4)
        Me.GbRegistros.Size = New System.Drawing.Size(1047, 450)
        Me.GbRegistros.TabIndex = 3
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.BackgroundColor = System.Drawing.Color.White
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(4, 19)
        Me.dgvRegistrosAlmacenados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(1039, 427)
        Me.dgvRegistrosAlmacenados.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox3.Location = New System.Drawing.Point(332, 28)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 20
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox2.Location = New System.Drawing.Point(735, 28)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(401, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(314, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Registro de Pacientes"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(32, 116)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1045, 34)
        Me.txtBusqueda.TabIndex = 2
        Me.txtBusqueda.Text = "Buscar Registro de Pacientes por ID CLIENTE"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetPacMed
        '
        Me.TPDetPacMed.Controls.Add(Me.TPPacientesMed)
        Me.TPDetPacMed.Location = New System.Drawing.Point(4, 25)
        Me.TPDetPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TPDetPacMed.Name = "TPDetPacMed"
        Me.TPDetPacMed.Padding = New System.Windows.Forms.Padding(4)
        Me.TPDetPacMed.Size = New System.Drawing.Size(1116, 627)
        Me.TPDetPacMed.TabIndex = 1
        Me.TPDetPacMed.Text = "Detalles"
        Me.TPDetPacMed.UseVisualStyleBackColor = True
        '
        'TPPacientesMed
        '
        Me.TPPacientesMed.Controls.Add(Me.TPPaciente)
        Me.TPPacientesMed.Controls.Add(Me.TPExpDuenio)
        Me.TPPacientesMed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TPPacientesMed.Location = New System.Drawing.Point(4, 4)
        Me.TPPacientesMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPacientesMed.Name = "TPPacientesMed"
        Me.TPPacientesMed.SelectedIndex = 0
        Me.TPPacientesMed.Size = New System.Drawing.Size(1108, 619)
        Me.TPPacientesMed.TabIndex = 0
        '
        'TPPaciente
        '
        Me.TPPaciente.BackColor = System.Drawing.Color.SeaShell
        Me.TPPaciente.Controls.Add(Me.PictureBox1)
        Me.TPPaciente.Controls.Add(Me.PictureBox4)
        Me.TPPaciente.Controls.Add(Me.Label19)
        Me.TPPaciente.Controls.Add(Me.TxtBIdPac)
        Me.TPPaciente.Controls.Add(Me.TxtNombrePac)
        Me.TPPaciente.Controls.Add(Me.Label9)
        Me.TPPaciente.Controls.Add(Me.Label4)
        Me.TPPaciente.Controls.Add(Me.Label18)
        Me.TPPaciente.Controls.Add(Me.Label2)
        Me.TPPaciente.Controls.Add(Me.TxtPeso)
        Me.TPPaciente.Controls.Add(Me.BtnEditar)
        Me.TPPaciente.Controls.Add(Me.BtnLimpiar)
        Me.TPPaciente.Controls.Add(Me.BtnGuardar)
        Me.TPPaciente.Controls.Add(Me.CmbRazaPac)
        Me.TPPaciente.Controls.Add(Me.CmbEspeciePac)
        Me.TPPaciente.Controls.Add(Me.DtPac)
        Me.TPPaciente.Controls.Add(Me.Label10)
        Me.TPPaciente.Controls.Add(Me.TxtSenPar)
        Me.TPPaciente.Controls.Add(Me.Label8)
        Me.TPPaciente.Controls.Add(Me.TxtColorPac)
        Me.TPPaciente.Controls.Add(Me.Label7)
        Me.TPPaciente.Controls.Add(Me.Label6)
        Me.TPPaciente.Controls.Add(Me.TBSexoPac)
        Me.TPPaciente.Controls.Add(Me.Label5)
        Me.TPPaciente.Controls.Add(Me.Label3)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 25)
        Me.TPPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPaciente.Size = New System.Drawing.Size(1100, 590)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Paciente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox1.Location = New System.Drawing.Point(315, 53)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox4.Location = New System.Drawing.Point(715, 53)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 59
        Me.PictureBox4.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label19.Location = New System.Drawing.Point(384, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(312, 32)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Detalles de Pacientes"
        '
        'TxtBIdPac
        '
        Me.TxtBIdPac.Location = New System.Drawing.Point(247, 191)
        Me.TxtBIdPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBIdPac.Name = "TxtBIdPac"
        Me.TxtBIdPac.Size = New System.Drawing.Size(129, 22)
        Me.TxtBIdPac.TabIndex = 3
        '
        'TxtNombrePac
        '
        Me.TxtNombrePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombrePac.Location = New System.Drawing.Point(247, 234)
        Me.TxtNombrePac.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNombrePac.Name = "TxtNombrePac"
        Me.TxtNombrePac.Size = New System.Drawing.Size(267, 22)
        Me.TxtNombrePac.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 232)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 25)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 191)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "ID del paciente:"
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(954, 235)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 25)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Kg"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(583, 236)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Peso:"
        '
        'TxtPeso
        '
        Me.TxtPeso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPeso.Location = New System.Drawing.Point(806, 235)
        Me.TxtPeso.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(139, 22)
        Me.TxtPeso.TabIndex = 15
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(448, 470)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(195, 46)
        Me.BtnEditar.TabIndex = 22
        Me.BtnEditar.Text = "   Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(664, 470)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(195, 46)
        Me.BtnLimpiar.TabIndex = 23
        Me.BtnLimpiar.Text = "   Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(236, 470)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(195, 46)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "   Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CmbRazaPac
        '
        Me.CmbRazaPac.FormattingEnabled = True
        Me.CmbRazaPac.Location = New System.Drawing.Point(804, 190)
        Me.CmbRazaPac.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbRazaPac.Name = "CmbRazaPac"
        Me.CmbRazaPac.Size = New System.Drawing.Size(265, 24)
        Me.CmbRazaPac.TabIndex = 13
        '
        'CmbEspeciePac
        '
        Me.CmbEspeciePac.FormattingEnabled = True
        Me.CmbEspeciePac.Location = New System.Drawing.Point(247, 316)
        Me.CmbEspeciePac.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbEspeciePac.Name = "CmbEspeciePac"
        Me.CmbEspeciePac.Size = New System.Drawing.Size(265, 24)
        Me.CmbEspeciePac.TabIndex = 9
        '
        'DtPac
        '
        Me.DtPac.Location = New System.Drawing.Point(247, 279)
        Me.DtPac.Margin = New System.Windows.Forms.Padding(4)
        Me.DtPac.Name = "DtPac"
        Me.DtPac.Size = New System.Drawing.Size(265, 22)
        Me.DtPac.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 275)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TxtSenPar
        '
        Me.TxtSenPar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSenPar.Location = New System.Drawing.Point(806, 316)
        Me.TxtSenPar.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSenPar.Multiline = True
        Me.TxtSenPar.Name = "TxtSenPar"
        Me.TxtSenPar.Size = New System.Drawing.Size(265, 79)
        Me.TxtSenPar.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(583, 279)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Color:"
        '
        'TxtColorPac
        '
        Me.TxtColorPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtColorPac.Location = New System.Drawing.Point(806, 278)
        Me.TxtColorPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtColorPac.Name = "TxtColorPac"
        Me.TxtColorPac.Size = New System.Drawing.Size(265, 22)
        Me.TxtColorPac.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(583, 188)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Raza:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(583, 316)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(180, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(249, 359)
        Me.TBSexoPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(265, 24)
        Me.TBSexoPac.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 360)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 314)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Especie:"
        '
        'TPExpDuenio
        '
        Me.TPExpDuenio.BackColor = System.Drawing.Color.SeaShell
        Me.TPExpDuenio.Controls.Add(Me.PictureBox5)
        Me.TPExpDuenio.Controls.Add(Me.PictureBox6)
        Me.TPExpDuenio.Controls.Add(Me.Label20)
        Me.TPExpDuenio.Controls.Add(Me.TBapellidoClt)
        Me.TPExpDuenio.Controls.Add(Me.TBtelClt)
        Me.TPExpDuenio.Controls.Add(Me.TBdireccionClt)
        Me.TPExpDuenio.Controls.Add(Me.TBcorreoClt)
        Me.TPExpDuenio.Controls.Add(Me.TBnombreClt)
        Me.TPExpDuenio.Controls.Add(Me.TBcedulaClt)
        Me.TPExpDuenio.Controls.Add(Me.Label11)
        Me.TPExpDuenio.Controls.Add(Me.Label12)
        Me.TPExpDuenio.Controls.Add(Me.Label13)
        Me.TPExpDuenio.Controls.Add(Me.Label14)
        Me.TPExpDuenio.Controls.Add(Me.Label15)
        Me.TPExpDuenio.Controls.Add(Me.Label16)
        Me.TPExpDuenio.Location = New System.Drawing.Point(4, 25)
        Me.TPExpDuenio.Margin = New System.Windows.Forms.Padding(4)
        Me.TPExpDuenio.Name = "TPExpDuenio"
        Me.TPExpDuenio.Padding = New System.Windows.Forms.Padding(4)
        Me.TPExpDuenio.Size = New System.Drawing.Size(1100, 590)
        Me.TPExpDuenio.TabIndex = 1
        Me.TPExpDuenio.Text = "Dueño"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.ProyectoF.My.Resources.Resources.cliente
        Me.PictureBox5.Location = New System.Drawing.Point(335, 58)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 33
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.ProyectoF.My.Resources.Resources.cliente
        Me.PictureBox6.Location = New System.Drawing.Point(695, 58)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 32
        Me.PictureBox6.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label20.Location = New System.Drawing.Point(404, 85)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(274, 32)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Detalles del Dueño"
        '
        'TBapellidoClt
        '
        Me.TBapellidoClt.Location = New System.Drawing.Point(239, 290)
        Me.TBapellidoClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBapellidoClt.Name = "TBapellidoClt"
        Me.TBapellidoClt.Size = New System.Drawing.Size(265, 22)
        Me.TBapellidoClt.TabIndex = 6
        '
        'TBtelClt
        '
        Me.TBtelClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBtelClt.Location = New System.Drawing.Point(813, 248)
        Me.TBtelClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBtelClt.Name = "TBtelClt"
        Me.TBtelClt.Size = New System.Drawing.Size(265, 22)
        Me.TBtelClt.TabIndex = 10
        '
        'TBdireccionClt
        '
        Me.TBdireccionClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBdireccionClt.Location = New System.Drawing.Point(814, 296)
        Me.TBdireccionClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBdireccionClt.Multiline = True
        Me.TBdireccionClt.Name = "TBdireccionClt"
        Me.TBdireccionClt.Size = New System.Drawing.Size(264, 79)
        Me.TBdireccionClt.TabIndex = 12
        '
        'TBcorreoClt
        '
        Me.TBcorreoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcorreoClt.Location = New System.Drawing.Point(813, 208)
        Me.TBcorreoClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcorreoClt.Name = "TBcorreoClt"
        Me.TBcorreoClt.Size = New System.Drawing.Size(265, 22)
        Me.TBcorreoClt.TabIndex = 8
        '
        'TBnombreClt
        '
        Me.TBnombreClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBnombreClt.Location = New System.Drawing.Point(241, 247)
        Me.TBnombreClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBnombreClt.Name = "TBnombreClt"
        Me.TBnombreClt.Size = New System.Drawing.Size(265, 22)
        Me.TBnombreClt.TabIndex = 5
        '
        'TBcedulaClt
        '
        Me.TBcedulaClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcedulaClt.Location = New System.Drawing.Point(241, 207)
        Me.TBcedulaClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcedulaClt.Name = "TBcedulaClt"
        Me.TBcedulaClt.Size = New System.Drawing.Size(265, 22)
        Me.TBcedulaClt.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(591, 252)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 25)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Teléfono:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(591, 210)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 25)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(591, 294)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 25)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Dirección:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(18, 290)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 25)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Apellido:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 248)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 25)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Nombre:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(18, 208)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 25)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Cédula:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1124, 47)
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pacientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1071, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'FrmPacientesM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 703)
        Me.Controls.Add(Me.TCPacientesMed)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPacientesM"
        Me.Text = "FrmExpedientePacientes"
        Me.TCPacientesMed.ResumeLayout(False)
        Me.TPPacMedico.ResumeLayout(False)
        Me.TPPacMedico.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacMed.ResumeLayout(False)
        Me.TPPacientesMed.ResumeLayout(False)
        Me.TPPaciente.ResumeLayout(False)
        Me.TPPaciente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPExpDuenio.ResumeLayout(False)
        Me.TPExpDuenio.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientesMed As TabControl
    Friend WithEvents TPPacMedico As TabPage
    Friend WithEvents TPDetPacMed As TabPage
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TPPacientesMed As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents DtPac As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtColorPac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TPExpDuenio As TabPage
    Friend WithEvents TBapellidoClt As TextBox
    Friend WithEvents TBtelClt As TextBox
    Friend WithEvents TBdireccionClt As TextBox
    Friend WithEvents TBcorreoClt As TextBox
    Friend WithEvents TBnombreClt As TextBox
    Friend WithEvents TBcedulaClt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CmbRazaPac As ComboBox
    Friend WithEvents CmbEspeciePac As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents TxtBIdPac As TextBox
    Friend WithEvents TxtNombrePac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label20 As Label
End Class
