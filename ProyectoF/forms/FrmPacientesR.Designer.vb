<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientesR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPacientesR))
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesRec = New System.Windows.Forms.TabControl()
        Me.TPPacienteRec = New System.Windows.Forms.TabPage()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetPacRec = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBIdPac = New System.Windows.Forms.TextBox()
        Me.TxtNombrePac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPeso = New System.Windows.Forms.TextBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientesRec.SuspendLayout()
        Me.TPPacienteRec.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacRec.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1124, 47)
        Me.PnlTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pacientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1065, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'TCPacientesRec
        '
        Me.TCPacientesRec.Controls.Add(Me.TPPacienteRec)
        Me.TCPacientesRec.Controls.Add(Me.TPDetPacRec)
        Me.TCPacientesRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientesRec.Location = New System.Drawing.Point(0, 47)
        Me.TCPacientesRec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TCPacientesRec.Name = "TCPacientesRec"
        Me.TCPacientesRec.SelectedIndex = 0
        Me.TCPacientesRec.Size = New System.Drawing.Size(1124, 656)
        Me.TCPacientesRec.TabIndex = 3
        '
        'TPPacienteRec
        '
        Me.TPPacienteRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPPacienteRec.Controls.Add(Me.GbRegistros)
        Me.TPPacienteRec.Controls.Add(Me.PictureBox3)
        Me.TPPacienteRec.Controls.Add(Me.PictureBox2)
        Me.TPPacienteRec.Controls.Add(Me.Label17)
        Me.TPPacienteRec.Controls.Add(Me.txtBusqueda)
        Me.TPPacienteRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TPPacienteRec.Location = New System.Drawing.Point(4, 25)
        Me.TPPacienteRec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPPacienteRec.Name = "TPPacienteRec"
        Me.TPPacienteRec.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPPacienteRec.Size = New System.Drawing.Size(1116, 627)
        Me.TPPacienteRec.TabIndex = 0
        Me.TPPacienteRec.Text = "Pacientes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(32, 178)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(1048, 417)
        Me.GbRegistros.TabIndex = 3
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 17)
        Me.dgvRegistrosAlmacenados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(1042, 398)
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
        Me.PictureBox3.TabIndex = 25
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
        Me.PictureBox2.TabIndex = 24
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
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1045, 34)
        Me.txtBusqueda.TabIndex = 2
        Me.txtBusqueda.Text = "Buscar Registro de Pacientes Por ID CLIENTE"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetPacRec
        '
        Me.TPDetPacRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetPacRec.Controls.Add(Me.PictureBox1)
        Me.TPDetPacRec.Controls.Add(Me.PictureBox4)
        Me.TPDetPacRec.Controls.Add(Me.Label2)
        Me.TPDetPacRec.Controls.Add(Me.TxtBIdPac)
        Me.TPDetPacRec.Controls.Add(Me.TxtNombrePac)
        Me.TPDetPacRec.Controls.Add(Me.Label9)
        Me.TPDetPacRec.Controls.Add(Me.Label4)
        Me.TPDetPacRec.Controls.Add(Me.Label18)
        Me.TPDetPacRec.Controls.Add(Me.Label3)
        Me.TPDetPacRec.Controls.Add(Me.TxtPeso)
        Me.TPDetPacRec.Controls.Add(Me.BtnEliminar)
        Me.TPDetPacRec.Controls.Add(Me.BtnEditar)
        Me.TPDetPacRec.Controls.Add(Me.BtnLimpiar)
        Me.TPDetPacRec.Controls.Add(Me.BtnGuardar)
        Me.TPDetPacRec.Controls.Add(Me.CmbRazaPac)
        Me.TPDetPacRec.Controls.Add(Me.CmbEspeciePac)
        Me.TPDetPacRec.Controls.Add(Me.DtPac)
        Me.TPDetPacRec.Controls.Add(Me.Label10)
        Me.TPDetPacRec.Controls.Add(Me.TxtSenPar)
        Me.TPDetPacRec.Controls.Add(Me.Label8)
        Me.TPDetPacRec.Controls.Add(Me.TxtColorPac)
        Me.TPDetPacRec.Controls.Add(Me.Label7)
        Me.TPDetPacRec.Controls.Add(Me.Label6)
        Me.TPDetPacRec.Controls.Add(Me.TBSexoPac)
        Me.TPDetPacRec.Controls.Add(Me.Label5)
        Me.TPDetPacRec.Controls.Add(Me.Label11)
        Me.TPDetPacRec.Location = New System.Drawing.Point(4, 25)
        Me.TPDetPacRec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPDetPacRec.Name = "TPDetPacRec"
        Me.TPDetPacRec.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPDetPacRec.Size = New System.Drawing.Size(1116, 627)
        Me.TPDetPacRec.TabIndex = 1
        Me.TPDetPacRec.Text = "Detalles"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox1.Location = New System.Drawing.Point(323, 69)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.pets
        Me.PictureBox4.Location = New System.Drawing.Point(725, 69)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 82
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(392, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Registro de Pacientes"
        '
        'TxtBIdPac
        '
        Me.TxtBIdPac.Location = New System.Drawing.Point(256, 210)
        Me.TxtBIdPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBIdPac.Name = "TxtBIdPac"
        Me.TxtBIdPac.Size = New System.Drawing.Size(129, 22)
        Me.TxtBIdPac.TabIndex = 3
        '
        'TxtNombrePac
        '
        Me.TxtNombrePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtNombrePac.Location = New System.Drawing.Point(255, 254)
        Me.TxtNombrePac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNombrePac.Name = "TxtNombrePac"
        Me.TxtNombrePac.Size = New System.Drawing.Size(267, 22)
        Me.TxtNombrePac.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 252)
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
        Me.Label4.Location = New System.Drawing.Point(33, 210)
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
        Me.Label18.Location = New System.Drawing.Point(961, 255)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 25)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Kg"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(591, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Peso:"
        '
        'TxtPeso
        '
        Me.TxtPeso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtPeso.Location = New System.Drawing.Point(813, 255)
        Me.TxtPeso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtPeso.Name = "TxtPeso"
        Me.TxtPeso.Size = New System.Drawing.Size(139, 22)
        Me.TxtPeso.TabIndex = 15
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.Image = Global.ProyectoF.My.Resources.Resources.delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(779, 496)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(195, 46)
        Me.BtnEliminar.TabIndex = 24
        Me.BtnEliminar.Text = "   Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(351, 496)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.BtnLimpiar.Location = New System.Drawing.Point(567, 496)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(139, 496)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(195, 46)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "   Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'CmbRazaPac
        '
        Me.CmbRazaPac.FormattingEnabled = True
        Me.CmbRazaPac.Location = New System.Drawing.Point(813, 209)
        Me.CmbRazaPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbRazaPac.Name = "CmbRazaPac"
        Me.CmbRazaPac.Size = New System.Drawing.Size(265, 24)
        Me.CmbRazaPac.TabIndex = 13
        '
        'CmbEspeciePac
        '
        Me.CmbEspeciePac.FormattingEnabled = True
        Me.CmbEspeciePac.Location = New System.Drawing.Point(256, 336)
        Me.CmbEspeciePac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbEspeciePac.Name = "CmbEspeciePac"
        Me.CmbEspeciePac.Size = New System.Drawing.Size(265, 24)
        Me.CmbEspeciePac.TabIndex = 9
        '
        'DtPac
        '
        Me.DtPac.Location = New System.Drawing.Point(256, 299)
        Me.DtPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DtPac.Name = "DtPac"
        Me.DtPac.Size = New System.Drawing.Size(265, 22)
        Me.DtPac.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 295)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(175, 25)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TxtSenPar
        '
        Me.TxtSenPar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtSenPar.Location = New System.Drawing.Point(813, 336)
        Me.TxtSenPar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Label8.Location = New System.Drawing.Point(591, 299)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Color:"
        '
        'TxtColorPac
        '
        Me.TxtColorPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtColorPac.Location = New System.Drawing.Point(813, 298)
        Me.TxtColorPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtColorPac.Name = "TxtColorPac"
        Me.TxtColorPac.Size = New System.Drawing.Size(265, 22)
        Me.TxtColorPac.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(591, 208)
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
        Me.Label6.Location = New System.Drawing.Point(591, 336)
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
        Me.TBSexoPac.Location = New System.Drawing.Point(256, 379)
        Me.TBSexoPac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(265, 24)
        Me.TBSexoPac.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 380)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sexo:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(33, 334)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Especie:"
        '
        'FrmPacientesR
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 703)
        Me.Controls.Add(Me.TCPacientesRec)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmPacientesR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPacientes"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientesRec.ResumeLayout(False)
        Me.TPPacienteRec.ResumeLayout(False)
        Me.TPPacienteRec.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacRec.ResumeLayout(False)
        Me.TPDetPacRec.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientesRec As TabControl
    Friend WithEvents TPPacienteRec As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents TPDetPacRec As TabPage
    Friend WithEvents TxtBIdPac As TextBox
    Friend WithEvents TxtNombrePac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPeso As TextBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents CmbRazaPac As ComboBox
    Friend WithEvents CmbEspeciePac As ComboBox
    Friend WithEvents DtPac As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtColorPac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
End Class
