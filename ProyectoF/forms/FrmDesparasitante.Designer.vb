﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDesparasitante
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesparasitante))
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.CmbMarcaDesp = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbDesp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DtApliDesp = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtIdPac = New System.Windows.Forms.TextBox()
        Me.CmbRazaPac = New System.Windows.Forms.ComboBox()
        Me.CmbEspeciePac = New System.Windows.Forms.ComboBox()
        Me.DtPac = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombrePac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmbSexoPac = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        Me.TCPacientes.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPac.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(843, 38)
        Me.PnlTitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desparasitante"
        '
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPPaciente)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCPacientes.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(843, 533)
        Me.TCPacientes.TabIndex = 6
        '
        'TPPaciente
        '
        Me.TPPaciente.BackColor = System.Drawing.Color.SeaShell
        Me.TPPaciente.Controls.Add(Me.GbRegistros)
        Me.TPPaciente.Controls.Add(Me.PictureBox3)
        Me.TPPaciente.Controls.Add(Me.PictureBox2)
        Me.TPPaciente.Controls.Add(Me.Label17)
        Me.TPPaciente.Controls.Add(Me.txtBusqueda)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 22)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPPaciente.Size = New System.Drawing.Size(835, 507)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Pacientes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(25, 128)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Size = New System.Drawing.Size(785, 366)
        Me.GbRegistros.TabIndex = 3
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistrosAlmacenados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistrosAlmacenados.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistrosAlmacenados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 15)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(779, 348)
        Me.dgvRegistrosAlmacenados.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(274, 35)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(301, 26)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Registro de Desparasitante"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(25, 84)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(785, 28)
        Me.txtBusqueda.TabIndex = 2
        Me.txtBusqueda.Text = "Buscar Registro de Desparasitantes por ID CLIENTE"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetPac
        '
        Me.TPDetPac.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetPac.Controls.Add(Me.CmbMarcaDesp)
        Me.TPDetPac.Controls.Add(Me.Label12)
        Me.TPDetPac.Controls.Add(Me.CmbDesp)
        Me.TPDetPac.Controls.Add(Me.Label8)
        Me.TPDetPac.Controls.Add(Me.DtApliDesp)
        Me.TPDetPac.Controls.Add(Me.Label6)
        Me.TPDetPac.Controls.Add(Me.Label2)
        Me.TPDetPac.Controls.Add(Me.TxtPeso)
        Me.TPDetPac.Controls.Add(Me.BtnEditar)
        Me.TPDetPac.Controls.Add(Me.BtnLimpiar)
        Me.TPDetPac.Controls.Add(Me.BtnGuardar)
        Me.TPDetPac.Controls.Add(Me.TxtIdPac)
        Me.TPDetPac.Controls.Add(Me.CmbRazaPac)
        Me.TPDetPac.Controls.Add(Me.CmbEspeciePac)
        Me.TPDetPac.Controls.Add(Me.DtPac)
        Me.TPDetPac.Controls.Add(Me.TxtNombrePac)
        Me.TPDetPac.Controls.Add(Me.Label10)
        Me.TPDetPac.Controls.Add(Me.Label9)
        Me.TPDetPac.Controls.Add(Me.Label7)
        Me.TPDetPac.Controls.Add(Me.CmbSexoPac)
        Me.TPDetPac.Controls.Add(Me.Label5)
        Me.TPDetPac.Controls.Add(Me.Label4)
        Me.TPDetPac.Controls.Add(Me.Label11)
        Me.TPDetPac.Controls.Add(Me.PictureBox1)
        Me.TPDetPac.Controls.Add(Me.PictureBox4)
        Me.TPDetPac.Controls.Add(Me.Label3)
        Me.TPDetPac.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPDetPac.Size = New System.Drawing.Size(835, 507)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(276, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Detalles Desparasitantes "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox3.Location = New System.Drawing.Point(223, 13)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox2.Location = New System.Drawing.Point(574, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox1.Location = New System.Drawing.Point(224, 61)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox4.Location = New System.Drawing.Point(565, 61)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(48, 49)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(799, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'CmbMarcaDesp
        '
        Me.CmbMarcaDesp.FormattingEnabled = True
        Me.CmbMarcaDesp.Location = New System.Drawing.Point(610, 223)
        Me.CmbMarcaDesp.Name = "CmbMarcaDesp"
        Me.CmbMarcaDesp.Size = New System.Drawing.Size(200, 21)
        Me.CmbMarcaDesp.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Marca:"
        '
        'CmbDesp
        '
        Me.CmbDesp.FormattingEnabled = True
        Me.CmbDesp.Location = New System.Drawing.Point(610, 194)
        Me.CmbDesp.Name = "CmbDesp"
        Me.CmbDesp.Size = New System.Drawing.Size(200, 21)
        Me.CmbDesp.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(443, 193)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Vacuna:"
        '
        'DtApliDesp
        '
        Me.DtApliDesp.Location = New System.Drawing.Point(610, 259)
        Me.DtApliDesp.Name = "DtApliDesp"
        Me.DtApliDesp.Size = New System.Drawing.Size(200, 19)
        Me.DtApliDesp.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 20)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Fecha de Aplicación:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Peso:"
        '
        'TxtPeso
        '
        Me.TxtPeso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPeso.Location = New System.Drawing.Point(610, 157)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.ReadOnly = True
        Me.TxtPeso.Size = New System.Drawing.Size(105, 19)
        Me.TxtPeso.TabIndex = 15
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(343, 347)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(146, 37)
        Me.BtnEditar.TabIndex = 23
        Me.BtnEditar.Text = "   Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(505, 347)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(146, 37)
        Me.BtnLimpiar.TabIndex = 24
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
        Me.BtnGuardar.Location = New System.Drawing.Point(184, 347)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(146, 37)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "   Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtIdPac
        '
        Me.TxtIdPac.Location = New System.Drawing.Point(193, 124)
        Me.TxtIdPac.Name = "TxtIdPac"
        Me.TxtIdPac.ReadOnly = True
        Me.TxtIdPac.Size = New System.Drawing.Size(98, 19)
        Me.TxtIdPac.TabIndex = 3
        '
        'CmbRazaPac
        '
        Me.CmbRazaPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbRazaPac.Enabled = False
        Me.CmbRazaPac.FormattingEnabled = True
        Me.CmbRazaPac.Location = New System.Drawing.Point(610, 123)
        Me.CmbRazaPac.Name = "CmbRazaPac"
        Me.CmbRazaPac.Size = New System.Drawing.Size(200, 21)
        Me.CmbRazaPac.TabIndex = 13
        '
        'CmbEspeciePac
        '
        Me.CmbEspeciePac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEspeciePac.Enabled = False
        Me.CmbEspeciePac.FormattingEnabled = True
        Me.CmbEspeciePac.Location = New System.Drawing.Point(192, 223)
        Me.CmbEspeciePac.Name = "CmbEspeciePac"
        Me.CmbEspeciePac.Size = New System.Drawing.Size(200, 21)
        Me.CmbEspeciePac.TabIndex = 9
        '
        'DtPac
        '
        Me.DtPac.Enabled = False
        Me.DtPac.Location = New System.Drawing.Point(192, 193)
        Me.DtPac.Name = "DtPac"
        Me.DtPac.Size = New System.Drawing.Size(200, 19)
        Me.DtPac.TabIndex = 7
        '
        'TxtNombrePac
        '
        Me.TxtNombrePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombrePac.Location = New System.Drawing.Point(192, 159)
        Me.TxtNombrePac.Name = "TxtNombrePac"
        Me.TxtNombrePac.ReadOnly = True
        Me.TxtNombrePac.Size = New System.Drawing.Size(201, 19)
        Me.TxtNombrePac.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(443, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Raza:"
        '
        'CmbSexoPac
        '
        Me.CmbSexoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CmbSexoPac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexoPac.Enabled = False
        Me.CmbSexoPac.FormattingEnabled = True
        Me.CmbSexoPac.Location = New System.Drawing.Point(192, 258)
        Me.CmbSexoPac.Name = "CmbSexoPac"
        Me.CmbSexoPac.Size = New System.Drawing.Size(200, 21)
        Me.CmbSexoPac.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sexo:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Especie:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "ID del paciente:"
        '
        'FrmDesparasitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 571)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDesparasitante"
        Me.Text = "FrmVacunas"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.TCPacientes.ResumeLayout(False)
        Me.TPPaciente.ResumeLayout(False)
        Me.TPPaciente.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents CmbMarcaDesp As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbDesp As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DtApliDesp As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtIdPac As TextBox
    Friend WithEvents CmbRazaPac As ComboBox
    Friend WithEvents CmbEspeciePac As ComboBox
    Friend WithEvents DtPac As DateTimePicker
    Friend WithEvents TxtNombrePac As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CmbSexoPac As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
End Class
