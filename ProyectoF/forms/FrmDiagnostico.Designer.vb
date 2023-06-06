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
        Dim Label3 As System.Windows.Forms.Label
        Me.TCClientes = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
        Me.txtNombrePac = New System.Windows.Forms.TextBox()
        Me.DiagnosticosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBLosArcosDs = New ProyectoF.DBLosArcosDs()
        Me.dtFechaDiag = New System.Windows.Forms.DateTimePicker()
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
        Me.cmbIdPac = New System.Windows.Forms.ComboBox()
        DescripcionDiagLabel = New System.Windows.Forms.Label()
        FechaDiagLabel = New System.Windows.Forms.Label()
        IdPacienteLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.TCClientes.SuspendLayout()
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
        DescripcionDiagLabel.Location = New System.Drawing.Point(258, 127)
        DescripcionDiagLabel.Name = "DescripcionDiagLabel"
        DescripcionDiagLabel.Size = New System.Drawing.Size(164, 17)
        DescripcionDiagLabel.TabIndex = 16
        DescripcionDiagLabel.Text = "Descripción Diagnóstico:"
        '
        'FechaDiagLabel
        '
        FechaDiagLabel.AutoSize = True
        FechaDiagLabel.Location = New System.Drawing.Point(305, 251)
        FechaDiagLabel.Name = "FechaDiagLabel"
        FechaDiagLabel.Size = New System.Drawing.Size(129, 17)
        FechaDiagLabel.TabIndex = 17
        FechaDiagLabel.Text = "Fecha Diagnóstico:"
        '
        'IdPacienteLabel
        '
        IdPacienteLabel.AutoSize = True
        IdPacienteLabel.Location = New System.Drawing.Point(350, 316)
        IdPacienteLabel.Name = "IdPacienteLabel"
        IdPacienteLabel.Size = New System.Drawing.Size(84, 17)
        IdPacienteLabel.TabIndex = 18
        IdPacienteLabel.Text = "ID Paciente:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(313, 372)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(121, 17)
        Label3.TabIndex = 20
        Label3.Text = "Nombre Paciente:"
        '
        'TCClientes
        '
        Me.TCClientes.Controls.Add(Me.TPClt)
        Me.TCClientes.Controls.Add(Me.TPDetClt)
        Me.TCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCClientes.Location = New System.Drawing.Point(0, 47)
        Me.TCClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.TCClientes.Name = "TCClientes"
        Me.TCClientes.SelectedIndex = 0
        Me.TCClientes.Size = New System.Drawing.Size(1103, 608)
        Me.TCClientes.TabIndex = 8
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.Label2)
        Me.TPClt.Controls.Add(Me.GbRegistros)
        Me.TPClt.Controls.Add(Me.txtBusqueda)
        Me.TPClt.Location = New System.Drawing.Point(4, 25)
        Me.TPClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(4)
        Me.TPClt.Size = New System.Drawing.Size(1095, 579)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Registros Diagnósticos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(344, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(388, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Registros de Diagnósticos"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(25, 144)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Size = New System.Drawing.Size(1048, 406)
        Me.GbRegistros.TabIndex = 6
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 18)
        Me.dgvRegistrosAlmacenados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(1042, 385)
        Me.dgvRegistrosAlmacenados.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(25, 89)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1045, 34)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = "...."
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetClt
        '
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetClt.Controls.Add(Me.cmbIdPac)
        Me.TPDetClt.Controls.Add(Label3)
        Me.TPDetClt.Controls.Add(Me.txtNombrePac)
        Me.TPDetClt.Controls.Add(IdPacienteLabel)
        Me.TPDetClt.Controls.Add(FechaDiagLabel)
        Me.TPDetClt.Controls.Add(Me.dtFechaDiag)
        Me.TPDetClt.Controls.Add(DescripcionDiagLabel)
        Me.TPDetClt.Controls.Add(Me.txtDesDiag)
        Me.TPDetClt.Controls.Add(Me.BtnLimpiar)
        Me.TPDetClt.Controls.Add(Me.BtnEditar)
        Me.TPDetClt.Controls.Add(Me.BtnGuardar)
        Me.TPDetClt.Controls.Add(Me.BtnEliminar)
        Me.TPDetClt.Location = New System.Drawing.Point(4, 25)
        Me.TPDetClt.Margin = New System.Windows.Forms.Padding(4)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(4)
        Me.TPDetClt.Size = New System.Drawing.Size(1095, 579)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Datos "
        '
        'txtNombrePac
        '
        Me.txtNombrePac.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosticosBindingSource, "idPaciente", True))
        Me.txtNombrePac.Location = New System.Drawing.Point(440, 372)
        Me.txtNombrePac.Name = "txtNombrePac"
        Me.txtNombrePac.ReadOnly = True
        Me.txtNombrePac.Size = New System.Drawing.Size(167, 22)
        Me.txtNombrePac.TabIndex = 21
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
        'dtFechaDiag
        '
        Me.dtFechaDiag.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DiagnosticosBindingSource, "fechaDiag", True))
        Me.dtFechaDiag.Location = New System.Drawing.Point(440, 251)
        Me.dtFechaDiag.Name = "dtFechaDiag"
        Me.dtFechaDiag.Size = New System.Drawing.Size(270, 22)
        Me.dtFechaDiag.TabIndex = 18
        '
        'txtDesDiag
        '
        Me.txtDesDiag.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DiagnosticosBindingSource, "descripcionDiag", True))
        Me.txtDesDiag.Location = New System.Drawing.Point(440, 127)
        Me.txtDesDiag.Multiline = True
        Me.txtDesDiag.Name = "txtDesDiag"
        Me.txtDesDiag.Size = New System.Drawing.Size(396, 92)
        Me.txtDesDiag.TabIndex = 17
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLimpiar.Location = New System.Drawing.Point(553, 447)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(203, 46)
        Me.BtnLimpiar.TabIndex = 16
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(320, 447)
        Me.BtnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(203, 46)
        Me.BtnEditar.TabIndex = 15
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(76, 447)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(203, 46)
        Me.BtnGuardar.TabIndex = 13
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ProyectoF.My.Resources.Resources.delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(781, 447)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(203, 46)
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
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1103, 47)
        Me.PnlTitle.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diagnóstico"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1044, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
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
        'cmbIdPac
        '
        Me.cmbIdPac.FormattingEnabled = True
        Me.cmbIdPac.Location = New System.Drawing.Point(441, 316)
        Me.cmbIdPac.Name = "cmbIdPac"
        Me.cmbIdPac.Size = New System.Drawing.Size(166, 24)
        Me.cmbIdPac.TabIndex = 22
        '
        'FrmDiagnostico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 655)
        Me.Controls.Add(Me.TCClientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDiagnostico"
        Me.Text = "FrmDiagnostico"
        Me.TCClientes.ResumeLayout(False)
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

    Friend WithEvents TCClientes As TabControl
    Friend WithEvents TPClt As TabPage
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents TPDetClt As TabPage
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnEliminar As Button
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
    Friend WithEvents txtNombrePac As TextBox
    Friend WithEvents cmbIdPac As ComboBox
End Class
