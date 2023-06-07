<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim FechaConsultaLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim IdPacienteLabel As System.Windows.Forms.Label
        Dim IdServicioLabel As System.Windows.Forms.Label
        Dim IdFacturaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmServicio))
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.tcServicios = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.cmbIdPaciente = New System.Windows.Forms.ComboBox()
        Me.cmbIdFactura = New System.Windows.Forms.ComboBox()
        Me.cmbIdServicio = New System.Windows.Forms.ComboBox()
        Me.cmbIdCliente = New System.Windows.Forms.ComboBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.dtFechaConsulta = New System.Windows.Forms.DateTimePicker()
        Me.RegistroServiciosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBLosArcosDs = New ProyectoF.DBLosArcosDs()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.RegistroServiciosTableAdapter = New ProyectoF.DBLosArcosDsTableAdapters.RegistroServiciosTableAdapter()
        Me.TableAdapterManager = New ProyectoF.DBLosArcosDsTableAdapters.TableAdapterManager()
        FechaConsultaLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        IdPacienteLabel = New System.Windows.Forms.Label()
        IdServicioLabel = New System.Windows.Forms.Label()
        IdFacturaLabel = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcServicios.SuspendLayout()
        Me.TPClt.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetClt.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistroServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaConsultaLabel
        '
        FechaConsultaLabel.AutoSize = True
        FechaConsultaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaConsultaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        FechaConsultaLabel.Location = New System.Drawing.Point(324, 171)
        FechaConsultaLabel.Name = "FechaConsultaLabel"
        FechaConsultaLabel.Size = New System.Drawing.Size(171, 25)
        FechaConsultaLabel.TabIndex = 14
        FechaConsultaLabel.Text = "Fecha Consulta:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdClienteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdClienteLabel.Location = New System.Drawing.Point(243, 245)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(110, 25)
        IdClienteLabel.TabIndex = 15
        IdClienteLabel.Text = "id Cliente:"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPacienteLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdPacienteLabel.Location = New System.Drawing.Point(572, 313)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(103, 25)
        IdPacienteLabel.TabIndex = 16
        IdPacienteLabel.Text = "Paciente:"
        '
        'IdServicioLabel
        '
        IdServicioLabel.AutoSize = True
        IdServicioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdServicioLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdServicioLabel.Location = New System.Drawing.Point(259, 316)
        IdServicioLabel.Name = "IdServicioLabel"
        IdServicioLabel.Size = New System.Drawing.Size(97, 25)
        IdServicioLabel.TabIndex = 17
        IdServicioLabel.Text = "Servicio:"
        '
        'IdFacturaLabel
        '
        IdFacturaLabel.AutoSize = True
        IdFacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdFacturaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdFacturaLabel.Location = New System.Drawing.Point(556, 242)
        IdFacturaLabel.Name = "IdFacturaLabel"
        IdFacturaLabel.Size = New System.Drawing.Size(115, 25)
        IdFacturaLabel.TabIndex = 18
        IdFacturaLabel.Text = "id Factura:"
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
        Me.PnlTitle.Size = New System.Drawing.Size(1103, 47)
        Me.PnlTitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicio"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1044, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'tcServicios
        '
        Me.tcServicios.Controls.Add(Me.TPClt)
        Me.tcServicios.Controls.Add(Me.TPDetClt)
        Me.tcServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcServicios.Location = New System.Drawing.Point(0, 47)
        Me.tcServicios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tcServicios.Name = "tcServicios"
        Me.tcServicios.SelectedIndex = 0
        Me.tcServicios.Size = New System.Drawing.Size(1103, 608)
        Me.tcServicios.TabIndex = 6
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.PictureBox2)
        Me.TPClt.Controls.Add(Me.PictureBox1)
        Me.TPClt.Controls.Add(Me.Label2)
        Me.TPClt.Controls.Add(Me.GbRegistros)
        Me.TPClt.Controls.Add(Me.txtBusqueda)
        Me.TPClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPClt.Location = New System.Drawing.Point(4, 27)
        Me.TPClt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPClt.Size = New System.Drawing.Size(1095, 577)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Clientes"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.pet
        Me.PictureBox2.Location = New System.Drawing.Point(723, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.pet
        Me.PictureBox1.Location = New System.Drawing.Point(308, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(387, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Registros de Servicios"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(25, 153)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(1048, 417)
        Me.GbRegistros.TabIndex = 6
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.AllowUserToAddRows = False
        Me.dgvRegistrosAlmacenados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 17)
        Me.dgvRegistrosAlmacenados.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(1042, 398)
        Me.dgvRegistrosAlmacenados.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(25, 90)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1045, 34)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = "Buscar Registro de Servicio Por ID CLIENTE"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetClt
        '
        Me.TPDetClt.AutoScroll = True
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetClt.Controls.Add(Me.Label3)
        Me.TPDetClt.Controls.Add(Me.PictureBox4)
        Me.TPDetClt.Controls.Add(Me.PictureBox3)
        Me.TPDetClt.Controls.Add(Me.BtnEliminar)
        Me.TPDetClt.Controls.Add(Me.cmbIdPaciente)
        Me.TPDetClt.Controls.Add(Me.cmbIdFactura)
        Me.TPDetClt.Controls.Add(Me.cmbIdServicio)
        Me.TPDetClt.Controls.Add(Me.cmbIdCliente)
        Me.TPDetClt.Controls.Add(Me.BtnEditar)
        Me.TPDetClt.Controls.Add(Me.BtnLimpiar)
        Me.TPDetClt.Controls.Add(IdFacturaLabel)
        Me.TPDetClt.Controls.Add(IdServicioLabel)
        Me.TPDetClt.Controls.Add(IdPacienteLabel)
        Me.TPDetClt.Controls.Add(IdClienteLabel)
        Me.TPDetClt.Controls.Add(FechaConsultaLabel)
        Me.TPDetClt.Controls.Add(Me.dtFechaConsulta)
        Me.TPDetClt.Controls.Add(Me.BtnGuardar)
        Me.TPDetClt.Location = New System.Drawing.Point(4, 27)
        Me.TPDetClt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TPDetClt.Size = New System.Drawing.Size(1095, 577)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Detalles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(395, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(307, 32)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Detalles Del Servicio "
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.pet
        Me.PictureBox4.Location = New System.Drawing.Point(771, 50)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 28
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoF.My.Resources.Resources.pet
        Me.PictureBox3.Location = New System.Drawing.Point(276, 50)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 27
        Me.PictureBox3.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEliminar.Image = Global.ProyectoF.My.Resources.Resources.delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(765, 447)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(195, 46)
        Me.BtnEliminar.TabIndex = 26
        Me.BtnEliminar.Text = "   Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'cmbIdPaciente
        '
        Me.cmbIdPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdPaciente.FormattingEnabled = True
        Me.cmbIdPaciente.Location = New System.Drawing.Point(693, 313)
        Me.cmbIdPaciente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIdPaciente.Name = "cmbIdPaciente"
        Me.cmbIdPaciente.Size = New System.Drawing.Size(183, 26)
        Me.cmbIdPaciente.TabIndex = 25
        '
        'cmbIdFactura
        '
        Me.cmbIdFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdFactura.FormattingEnabled = True
        Me.cmbIdFactura.Location = New System.Drawing.Point(693, 242)
        Me.cmbIdFactura.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIdFactura.Name = "cmbIdFactura"
        Me.cmbIdFactura.Size = New System.Drawing.Size(183, 26)
        Me.cmbIdFactura.TabIndex = 24
        '
        'cmbIdServicio
        '
        Me.cmbIdServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdServicio.FormattingEnabled = True
        Me.cmbIdServicio.Location = New System.Drawing.Point(365, 318)
        Me.cmbIdServicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIdServicio.Name = "cmbIdServicio"
        Me.cmbIdServicio.Size = New System.Drawing.Size(160, 26)
        Me.cmbIdServicio.TabIndex = 23
        '
        'cmbIdCliente
        '
        Me.cmbIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdCliente.FormattingEnabled = True
        Me.cmbIdCliente.Location = New System.Drawing.Point(365, 246)
        Me.cmbIdCliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbIdCliente.Name = "cmbIdCliente"
        Me.cmbIdCliente.Size = New System.Drawing.Size(160, 26)
        Me.cmbIdCliente.TabIndex = 22
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(337, 447)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(195, 46)
        Me.BtnEditar.TabIndex = 21
        Me.BtnEditar.Text = "   Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(553, 447)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(195, 46)
        Me.BtnLimpiar.TabIndex = 20
        Me.BtnLimpiar.Text = "   Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'dtFechaConsulta
        '
        Me.dtFechaConsulta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroServiciosBindingSource, "fechaConsulta", True))
        Me.dtFechaConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaConsulta.Location = New System.Drawing.Point(512, 174)
        Me.dtFechaConsulta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dtFechaConsulta.Name = "dtFechaConsulta"
        Me.dtFechaConsulta.Size = New System.Drawing.Size(281, 24)
        Me.dtFechaConsulta.TabIndex = 15
        '
        'RegistroServiciosBindingSource
        '
        Me.RegistroServiciosBindingSource.DataMember = "RegistroServicios"
        Me.RegistroServiciosBindingSource.DataSource = Me.DBLosArcosDs
        '
        'DBLosArcosDs
        '
        Me.DBLosArcosDs.DataSetName = "DBLosArcosDs"
        Me.DBLosArcosDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(125, 447)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(195, 46)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "   Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'RegistroServiciosTableAdapter
        '
        Me.RegistroServiciosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DesparasitantesTableAdapter = Nothing
        Me.TableAdapterManager.DiagnosticosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EspeciesTableAdapter = Nothing
        Me.TableAdapterManager.MarcasDesparasitantesTableAdapter = Nothing
        Me.TableAdapterManager.MarcasVacunasTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.RazasTableAdapter = Nothing
        Me.TableAdapterManager.RegistroDesparasitacionesTableAdapter = Nothing
        Me.TableAdapterManager.RegistroFacturasTableAdapter = Nothing
        Me.TableAdapterManager.RegistroServiciosTableAdapter = Me.RegistroServiciosTableAdapter
        Me.TableAdapterManager.RegistroVacunacionesTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoF.DBLosArcosDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacunasTableAdapter = Nothing
        '
        'FrmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 655)
        Me.Controls.Add(Me.tcServicios)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmServicio"
        Me.Text = "FrmServicio"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcServicios.ResumeLayout(False)
        Me.TPClt.ResumeLayout(False)
        Me.TPClt.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetClt.ResumeLayout(False)
        Me.TPDetClt.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistroServiciosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents tcServicios As TabControl
    Friend WithEvents TPClt As TabPage
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents DBLosArcosDs As DBLosArcosDs
    Friend WithEvents RegistroServiciosBindingSource As BindingSource
    Friend WithEvents RegistroServiciosTableAdapter As DBLosArcosDsTableAdapters.RegistroServiciosTableAdapter
    Friend WithEvents TableAdapterManager As DBLosArcosDsTableAdapters.TableAdapterManager
    Friend WithEvents TPDetClt As TabPage
    Friend WithEvents cmbIdPaciente As ComboBox
    Friend WithEvents cmbIdFactura As ComboBox
    Friend WithEvents cmbIdServicio As ComboBox
    Friend WithEvents cmbIdCliente As ComboBox
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents dtFechaConsulta As DateTimePicker
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
