<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDiagnostico
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
        Dim DescripcionDiagLabel As System.Windows.Forms.Label
        Dim FechaDiagLabel As System.Windows.Forms.Label
        Dim IdPacienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDiagnostico))
        Me.tcDiagnosticos = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
        Me.cmbIdPac = New System.Windows.Forms.ComboBox()
        Me.dtFechaDiag = New System.Windows.Forms.DateTimePicker()
        Me.DiagnosticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBLosArcosDs = New ProyectoF.DBLosArcosDs()
        Me.txtDesDiag = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.DiagnosticosTableAdapter = New ProyectoF.DBLosArcosDsTableAdapters.DiagnosticosTableAdapter()
        Me.TableAdapterManager = New ProyectoF.DBLosArcosDsTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtidDiag = New System.Windows.Forms.TextBox()
        DescripcionDiagLabel = New System.Windows.Forms.Label()
        FechaDiagLabel = New System.Windows.Forms.Label()
        IdPacienteLabel = New System.Windows.Forms.Label()
        Me.tcDiagnosticos.SuspendLayout()
        Me.TPClt.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetClt.SuspendLayout()
        CType(Me.DiagnosticosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripcionDiagLabel
        '
        DescripcionDiagLabel.AutoSize = True
        DescripcionDiagLabel.Location = New System.Drawing.Point(184, 119)
        DescripcionDiagLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DescripcionDiagLabel.Name = "DescripcionDiagLabel"
        DescripcionDiagLabel.Size = New System.Drawing.Size(149, 13)
        DescripcionDiagLabel.TabIndex = 16
        DescripcionDiagLabel.Text = "Descripción Diagnóstico:"
        '
        'FechaDiagLabel
        '
        FechaDiagLabel.AutoSize = True
        FechaDiagLabel.Location = New System.Drawing.Point(210, 217)
        FechaDiagLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FechaDiagLabel.Name = "FechaDiagLabel"
        FechaDiagLabel.Size = New System.Drawing.Size(117, 13)
        FechaDiagLabel.TabIndex = 17
        FechaDiagLabel.Text = "Fecha Diagnóstico:"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Location = New System.Drawing.Point(216, 270)
        IdPacienteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(108, 13)
        IdPacienteLabel.TabIndex = 18
        IdPacienteLabel.Text = "Nombre Paciente:"
        '
        'tcDiagnosticos
        '
        Me.tcDiagnosticos.Controls.Add(Me.TPClt)
        Me.tcDiagnosticos.Controls.Add(Me.TPDetClt)
        Me.tcDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcDiagnosticos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcDiagnosticos.Location = New System.Drawing.Point(0, 38)
        Me.tcDiagnosticos.Name = "tcDiagnosticos"
        Me.tcDiagnosticos.SelectedIndex = 0
        Me.tcDiagnosticos.Size = New System.Drawing.Size(827, 494)
        Me.tcDiagnosticos.TabIndex = 8
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.Label2)
        Me.TPClt.Controls.Add(Me.GbRegistros)
        Me.TPClt.Controls.Add(Me.txtBusqueda)
        Me.TPClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPClt.Location = New System.Drawing.Point(4, 22)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPClt.Size = New System.Drawing.Size(819, 468)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Registros Diagnósticos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(258, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(320, 29)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Registros de Diagnósticos"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbRegistros.Location = New System.Drawing.Point(16, 136)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GbRegistros.Size = New System.Drawing.Size(788, 330)
        Me.GbRegistros.TabIndex = 6
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.AllowUserToAddRows = False
        Me.dgvRegistrosAlmacenados.BackgroundColor = System.Drawing.Color.White
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(2, 14)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(784, 314)
        Me.dgvRegistrosAlmacenados.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(16, 72)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(777, 28)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = "Buscar Diagnósticos Por ID Paciente"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetClt
        '
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetClt.Controls.Add(Me.txtidDiag)
        Me.TPDetClt.Controls.Add(Me.Label3)
        Me.TPDetClt.Controls.Add(Me.cmbIdPac)
        Me.TPDetClt.Controls.Add(IdPacienteLabel)
        Me.TPDetClt.Controls.Add(FechaDiagLabel)
        Me.TPDetClt.Controls.Add(Me.dtFechaDiag)
        Me.TPDetClt.Controls.Add(DescripcionDiagLabel)
        Me.TPDetClt.Controls.Add(Me.txtDesDiag)
        Me.TPDetClt.Controls.Add(Me.BtnLimpiar)
        Me.TPDetClt.Controls.Add(Me.BtnEditar)
        Me.TPDetClt.Controls.Add(Me.BtnGuardar)
        Me.TPDetClt.Controls.Add(Me.BtnEliminar)
        Me.TPDetClt.Location = New System.Drawing.Point(4, 22)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPDetClt.Size = New System.Drawing.Size(819, 468)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Datos "
        '
        'cmbIdPac
        '
        Me.cmbIdPac.FormattingEnabled = True
        Me.cmbIdPac.Location = New System.Drawing.Point(340, 270)
        Me.cmbIdPac.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbIdPac.Name = "cmbIdPac"
        Me.cmbIdPac.Size = New System.Drawing.Size(126, 21)
        Me.cmbIdPac.TabIndex = 22
        '
        'dtFechaDiag
        '
        Me.dtFechaDiag.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DiagnosticosBindingSource, "fechaDiag", True))
        Me.dtFechaDiag.Location = New System.Drawing.Point(340, 217)
        Me.dtFechaDiag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtFechaDiag.Name = "dtFechaDiag"
        Me.dtFechaDiag.Size = New System.Drawing.Size(245, 19)
        Me.dtFechaDiag.TabIndex = 18
        '
        'DiagnosticosBindingSource
        '
        Me.DiagnosticosBindingSource.DataMember = "Diagnosticos"
        Me.DiagnosticosBindingSource.DataSource = Me.DBLosArcosDs
        '
        'DBLosArcosDs
        '
        Me.DBLosArcosDs.DataSetName = "DBLosArcosDs"
        Me.DBLosArcosDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDesDiag
        '
        Me.txtDesDiag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosticosBindingSource, "descripcionDiag", True))
        Me.txtDesDiag.Location = New System.Drawing.Point(340, 116)
        Me.txtDesDiag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDesDiag.Multiline = True
        Me.txtDesDiag.Name = "txtDesDiag"
        Me.txtDesDiag.Size = New System.Drawing.Size(298, 76)
        Me.txtDesDiag.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(415, 363)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(152, 37)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(240, 363)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(152, 37)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(57, 363)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(152, 37)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ProyectoF.My.Resources.Resources.delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(586, 363)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(152, 37)
        Me.BtnEliminar.TabIndex = 14
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
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
        Me.PnlTitle.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnóstico"
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
        'DiagnosticosTableAdapter
        '
        Me.DiagnosticosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DesparasitantesTableAdapter = Nothing
        Me.TableAdapterManager.DiagnosticosTableAdapter = Me.DiagnosticosTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.EspeciesTableAdapter = Nothing
        Me.TableAdapterManager.MarcasDesparasitantesTableAdapter = Nothing
        Me.TableAdapterManager.MarcasVacunasTableAdapter = Nothing
        Me.TableAdapterManager.PacientesTableAdapter = Nothing
        Me.TableAdapterManager.RazasTableAdapter = Nothing
        Me.TableAdapterManager.RegistroDesparasitacionesTableAdapter = Nothing
        Me.TableAdapterManager.RegistroFacturasTableAdapter = Nothing
        Me.TableAdapterManager.RegistroServiciosTableAdapter = Nothing
        Me.TableAdapterManager.RegistroVacunacionesTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.ServiciosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoF.DBLosArcosDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VacunasTableAdapter = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "ID Diagnostico: "
        '
        'txtidDiag
        '
        Me.txtidDiag.Location = New System.Drawing.Point(344, 71)
        Me.txtidDiag.Name = "txtidDiag"
        Me.txtidDiag.Size = New System.Drawing.Size(122, 19)
        Me.txtidDiag.TabIndex = 24
        '
        'FrmDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 532)
        Me.Controls.Add(Me.tcDiagnosticos)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDiagnostico"
        Me.Text = "FrmDiagnostico"
        Me.tcDiagnosticos.ResumeLayout(False)
        Me.TPClt.ResumeLayout(False)
        Me.TPClt.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetClt.ResumeLayout(False)
        Me.TPDetClt.PerformLayout()
        CType(Me.DiagnosticosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tcDiagnosticos As TabControl
    Friend WithEvents TPClt As TabPage
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents TPDetClt As TabPage
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents DBLosArcosDs As DBLosArcosDs
    Friend WithEvents DiagnosticosBindingSource As BindingSource
    Friend WithEvents DiagnosticosTableAdapter As DBLosArcosDsTableAdapters.DiagnosticosTableAdapter
    Friend WithEvents TableAdapterManager As DBLosArcosDsTableAdapters.TableAdapterManager
    Friend WithEvents dtFechaDiag As DateTimePicker
    Friend WithEvents txtDesDiag As TextBox
    Friend WithEvents cmbIdPac As ComboBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents txtidDiag As TextBox
    Friend WithEvents Label3 As Label
End Class
