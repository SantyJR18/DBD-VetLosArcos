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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.tcServicios = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
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
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetClt.SuspendLayout()
        CType(Me.RegistroServiciosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FechaConsultaLabel
        '
        FechaConsultaLabel.AutoSize = True
        FechaConsultaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaConsultaLabel.Location = New System.Drawing.Point(251, 120)
        FechaConsultaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FechaConsultaLabel.Name = "FechaConsultaLabel"
        FechaConsultaLabel.Size = New System.Drawing.Size(135, 20)
        FechaConsultaLabel.TabIndex = 14
        FechaConsultaLabel.Text = "fecha Consulta:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdClienteLabel.Location = New System.Drawing.Point(182, 180)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(89, 20)
        IdClienteLabel.TabIndex = 15
        IdClienteLabel.Text = "id Cliente:"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPacienteLabel.Location = New System.Drawing.Point(429, 236)
        IdPacienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(84, 20)
        IdPacienteLabel.TabIndex = 16
        IdPacienteLabel.Text = "Paciente:"
        '
        'IdServicioLabel
        '
        IdServicioLabel.AutoSize = True
        IdServicioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdServicioLabel.Location = New System.Drawing.Point(194, 238)
        IdServicioLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdServicioLabel.Name = "IdServicioLabel"
        IdServicioLabel.Size = New System.Drawing.Size(77, 20)
        IdServicioLabel.TabIndex = 17
        IdServicioLabel.Text = "Servicio:"
        '
        'IdFacturaLabel
        '
        IdFacturaLabel.AutoSize = True
        IdFacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdFacturaLabel.Location = New System.Drawing.Point(417, 179)
        IdFacturaLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdFacturaLabel.Name = "IdFacturaLabel"
        IdFacturaLabel.Size = New System.Drawing.Size(95, 20)
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
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(827, 38)
        Me.PnlTitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servicio"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(783, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'tcServicios
        '
        Me.tcServicios.Controls.Add(Me.TPClt)
        Me.tcServicios.Controls.Add(Me.TPDetClt)
        Me.tcServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcServicios.Location = New System.Drawing.Point(0, 38)
        Me.tcServicios.Name = "tcServicios"
        Me.tcServicios.SelectedIndex = 0
        Me.tcServicios.Size = New System.Drawing.Size(827, 494)
        Me.tcServicios.TabIndex = 6
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.GbRegistros)
        Me.TPClt.Controls.Add(Me.txtBusqueda)
        Me.TPClt.Location = New System.Drawing.Point(4, 22)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPClt.Size = New System.Drawing.Size(819, 468)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Clientes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(19, 115)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(786, 339)
        Me.GbRegistros.TabIndex = 6
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(2, 15)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(782, 322)
        Me.dgvRegistrosAlmacenados.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(19, 69)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(785, 28)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = "Buscar Servicio"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetClt
        '
        Me.TPDetClt.AutoScroll = True
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
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
        Me.TPDetClt.Location = New System.Drawing.Point(4, 22)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPDetClt.Size = New System.Drawing.Size(819, 468)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Detalles"
        '
        'cmbIdPaciente
        '
        Me.cmbIdPaciente.FormattingEnabled = True
        Me.cmbIdPaciente.Location = New System.Drawing.Point(520, 236)
        Me.cmbIdPaciente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbIdPaciente.Name = "cmbIdPaciente"
        Me.cmbIdPaciente.Size = New System.Drawing.Size(138, 21)
        Me.cmbIdPaciente.TabIndex = 25
        '
        'cmbIdFactura
        '
        Me.cmbIdFactura.FormattingEnabled = True
        Me.cmbIdFactura.Location = New System.Drawing.Point(520, 179)
        Me.cmbIdFactura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbIdFactura.Name = "cmbIdFactura"
        Me.cmbIdFactura.Size = New System.Drawing.Size(138, 21)
        Me.cmbIdFactura.TabIndex = 24
        '
        'cmbIdServicio
        '
        Me.cmbIdServicio.FormattingEnabled = True
        Me.cmbIdServicio.Location = New System.Drawing.Point(274, 240)
        Me.cmbIdServicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbIdServicio.Name = "cmbIdServicio"
        Me.cmbIdServicio.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdServicio.TabIndex = 23
        '
        'cmbIdCliente
        '
        Me.cmbIdCliente.FormattingEnabled = True
        Me.cmbIdCliente.Location = New System.Drawing.Point(274, 181)
        Me.cmbIdCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbIdCliente.Name = "cmbIdCliente"
        Me.cmbIdCliente.Size = New System.Drawing.Size(121, 21)
        Me.cmbIdCliente.TabIndex = 22
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(331, 363)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(100, 37)
        Me.BtnEditar.TabIndex = 21
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(448, 363)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 37)
        Me.BtnLimpiar.TabIndex = 20
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'dtFechaConsulta
        '
        Me.dtFechaConsulta.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RegistroServiciosBindingSource, "fechaConsulta", True))
        Me.dtFechaConsulta.Location = New System.Drawing.Point(384, 123)
        Me.dtFechaConsulta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtFechaConsulta.Name = "dtFechaConsulta"
        Me.dtFechaConsulta.Size = New System.Drawing.Size(212, 20)
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
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(214, 363)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
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
        Me.TableAdapterManager.ExpedientesTableAdapter = Nothing
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 532)
        Me.Controls.Add(Me.tcServicios)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmServicio"
        Me.Text = "FrmServicio"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcServicios.ResumeLayout(False)
        Me.TPClt.ResumeLayout(False)
        Me.TPClt.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetClt.ResumeLayout(False)
        Me.TPDetClt.PerformLayout()
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
End Class
