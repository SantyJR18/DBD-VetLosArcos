<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleados
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
        Me.components = New System.ComponentModel.Container()
        Dim lblUsuario As System.Windows.Forms.Label
        Dim lblPwd As System.Windows.Forms.Label
        Dim lblPrimerNombre As System.Windows.Forms.Label
        Dim lblPrimerApe As System.Windows.Forms.Label
        Dim lblSegundoApe As System.Windows.Forms.Label
        Dim lblIdRol As System.Windows.Forms.Label
        Dim lblSegundoNombre As System.Windows.Forms.Label
        Dim lblFechaC As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleados))
        Me.TitleBar = New System.Windows.Forms.Panel()
        Me.BtnMinimize = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.DBLosArcosDs = New ProyectoF.DBLosArcosDs()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New ProyectoF.DBLosArcosDsTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New ProyectoF.DBLosArcosDsTableAdapters.TableAdapterManager()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtPrimerNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApe = New System.Windows.Forms.TextBox()
        Me.txtSegundoApe = New System.Windows.Forms.TextBox()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.dtFechaC = New System.Windows.Forms.DateTimePicker()
        Me.cmbIdRol = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.tcEmpleados = New System.Windows.Forms.TabControl()
        Me.tpEmpleados = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.tbRegistros = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        lblUsuario = New System.Windows.Forms.Label()
        lblPwd = New System.Windows.Forms.Label()
        lblPrimerNombre = New System.Windows.Forms.Label()
        lblPrimerApe = New System.Windows.Forms.Label()
        lblSegundoApe = New System.Windows.Forms.Label()
        lblIdRol = New System.Windows.Forms.Label()
        lblSegundoNombre = New System.Windows.Forms.Label()
        lblFechaC = New System.Windows.Forms.Label()
        Me.TitleBar.SuspendLayout()
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcEmpleados.SuspendLayout()
        Me.tpEmpleados.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegistros.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        lblUsuario.AutoSize = True
        lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUsuario.Location = New System.Drawing.Point(97, 119)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New System.Drawing.Size(69, 17)
        lblUsuario.TabIndex = 3
        lblUsuario.Text = "Usuario:"
        '
        'lblPwd
        '
        lblPwd.AutoSize = True
        lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPwd.Location = New System.Drawing.Point(73, 181)
        lblPwd.Name = "lblPwd"
        lblPwd.Size = New System.Drawing.Size(96, 17)
        lblPwd.TabIndex = 7
        lblPwd.Text = "Contraseña:"
        '
        'lblPrimerNombre
        '
        lblPrimerNombre.AutoSize = True
        lblPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPrimerNombre.Location = New System.Drawing.Point(55, 242)
        lblPrimerNombre.Name = "lblPrimerNombre"
        lblPrimerNombre.Size = New System.Drawing.Size(121, 17)
        lblPrimerNombre.TabIndex = 8
        lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblPrimerApe
        '
        lblPrimerApe.AutoSize = True
        lblPrimerApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPrimerApe.Location = New System.Drawing.Point(423, 244)
        lblPrimerApe.Name = "lblPrimerApe"
        lblPrimerApe.Size = New System.Drawing.Size(123, 17)
        lblPrimerApe.TabIndex = 9
        lblPrimerApe.Text = "Primer Apellido:"
        '
        'lblSegundoApe
        '
        lblSegundoApe.AutoSize = True
        lblSegundoApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSegundoApe.Location = New System.Drawing.Point(407, 314)
        lblSegundoApe.Name = "lblSegundoApe"
        lblSegundoApe.Size = New System.Drawing.Size(140, 17)
        lblSegundoApe.TabIndex = 11
        lblSegundoApe.Text = "Segundo Apellido:"
        '
        'lblIdRol
        '
        lblIdRol.AutoSize = True
        lblIdRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblIdRol.Location = New System.Drawing.Point(480, 183)
        lblIdRol.Name = "lblIdRol"
        lblIdRol.Size = New System.Drawing.Size(57, 17)
        lblIdRol.TabIndex = 13
        lblIdRol.Text = "ID Rol:"
        '
        'lblSegundoNombre
        '
        lblSegundoNombre.AutoSize = True
        lblSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSegundoNombre.Location = New System.Drawing.Point(35, 310)
        lblSegundoNombre.Name = "lblSegundoNombre"
        lblSegundoNombre.Size = New System.Drawing.Size(138, 17)
        lblSegundoNombre.TabIndex = 15
        lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'lblFechaC
        '
        lblFechaC.AutoSize = True
        lblFechaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFechaC.Location = New System.Drawing.Point(395, 120)
        lblFechaC.Name = "lblFechaC"
        lblFechaC.Size = New System.Drawing.Size(154, 17)
        lblFechaC.TabIndex = 17
        lblFechaC.Text = "Fecha Contratación:"
        '
        'TitleBar
        '
        Me.TitleBar.BackColor = System.Drawing.Color.DodgerBlue
        Me.TitleBar.Controls.Add(Me.BtnMinimize)
        Me.TitleBar.Controls.Add(Me.BtnClose)
        Me.TitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBar.Location = New System.Drawing.Point(0, 0)
        Me.TitleBar.Name = "TitleBar"
        Me.TitleBar.Size = New System.Drawing.Size(890, 47)
        Me.TitleBar.TabIndex = 0
        '
        'BtnMinimize
        '
        Me.BtnMinimize.Image = Global.ProyectoF.My.Resources.Resources.minusIcon
        Me.BtnMinimize.Location = New System.Drawing.Point(822, 11)
        Me.BtnMinimize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMinimize.TabIndex = 4
        Me.BtnMinimize.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(853, 11)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(25, 25)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.TabStop = False
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.DodgerBlue
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 535)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(890, 46)
        Me.BottomPanel.TabIndex = 1
        '
        'DBLosArcosDs
        '
        Me.DBLosArcosDs.DataSetName = "DBLosArcosDs"
        Me.DBLosArcosDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.DBLosArcosDs
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.DesparasitantesTableAdapter = Nothing
        Me.TableAdapterManager.DiagnosticosTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
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
        'txtUsuario
        '
        Me.txtUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "usuario", True))
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(179, 116)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(160, 22)
        Me.txtUsuario.TabIndex = 4
        '
        'txtPwd
        '
        Me.txtPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "contrasenia", True))
        Me.txtPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPwd.Location = New System.Drawing.Point(179, 178)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(160, 22)
        Me.txtPwd.TabIndex = 8
        Me.txtPwd.UseSystemPasswordChar = True
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "primerNombreEmp", True))
        Me.txtPrimerNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(179, 239)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(160, 22)
        Me.txtPrimerNombre.TabIndex = 9
        '
        'txtPrimerApe
        '
        Me.txtPrimerApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "primerApellidoEmp", True))
        Me.txtPrimerApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApe.Location = New System.Drawing.Point(562, 238)
        Me.txtPrimerApe.Name = "txtPrimerApe"
        Me.txtPrimerApe.Size = New System.Drawing.Size(157, 22)
        Me.txtPrimerApe.TabIndex = 10
        '
        'txtSegundoApe
        '
        Me.txtSegundoApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SegundoApellidoEmp", True))
        Me.txtSegundoApe.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApe.Location = New System.Drawing.Point(562, 306)
        Me.txtSegundoApe.Name = "txtSegundoApe"
        Me.txtSegundoApe.Size = New System.Drawing.Size(155, 22)
        Me.txtSegundoApe.TabIndex = 12
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "segundoNombreEmp", True))
        Me.txtSegundoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(179, 307)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(158, 22)
        Me.txtSegundoNombre.TabIndex = 16
        '
        'dtFechaC
        '
        Me.dtFechaC.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechaContratacion", True))
        Me.dtFechaC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaC.Location = New System.Drawing.Point(562, 117)
        Me.dtFechaC.Name = "dtFechaC"
        Me.dtFechaC.Size = New System.Drawing.Size(281, 22)
        Me.dtFechaC.TabIndex = 18
        '
        'cmbIdRol
        '
        Me.cmbIdRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdRol.FormattingEnabled = True
        Me.cmbIdRol.Location = New System.Drawing.Point(562, 177)
        Me.cmbIdRol.Name = "cmbIdRol"
        Me.cmbIdRol.Size = New System.Drawing.Size(158, 24)
        Me.cmbIdRol.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(282, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 36)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Datos de Empleado"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.ProyectoF.My.Resources.Resources.limpiar
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevo.Location = New System.Drawing.Point(707, 392)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(169, 46)
        Me.BtnNuevo.TabIndex = 22
        Me.BtnNuevo.Text = "   Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(183, 392)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(169, 46)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "   Crear"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVolver.Image = Global.ProyectoF.My.Resources.Resources.volver
        Me.BtnVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVolver.Location = New System.Drawing.Point(8, 392)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(169, 46)
        Me.BtnVolver.TabIndex = 23
        Me.BtnVolver.Text = "   Volver"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'tcEmpleados
        '
        Me.tcEmpleados.Controls.Add(Me.tpEmpleados)
        Me.tcEmpleados.Controls.Add(Me.tbRegistros)
        Me.tcEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tcEmpleados.Location = New System.Drawing.Point(0, 41)
        Me.tcEmpleados.Name = "tcEmpleados"
        Me.tcEmpleados.SelectedIndex = 0
        Me.tcEmpleados.Size = New System.Drawing.Size(890, 500)
        Me.tcEmpleados.TabIndex = 24
        '
        'tpEmpleados
        '
        Me.tpEmpleados.BackColor = System.Drawing.Color.SeaShell
        Me.tpEmpleados.Controls.Add(Me.PictureBox4)
        Me.tpEmpleados.Controls.Add(Me.PictureBox3)
        Me.tpEmpleados.Controls.Add(Me.BtnEliminar)
        Me.tpEmpleados.Controls.Add(Me.BtnEditar)
        Me.tpEmpleados.Controls.Add(Me.cmbIdRol)
        Me.tpEmpleados.Controls.Add(Me.BtnGuardar)
        Me.tpEmpleados.Controls.Add(Me.BtnVolver)
        Me.tpEmpleados.Controls.Add(Me.Label1)
        Me.tpEmpleados.Controls.Add(Me.BtnNuevo)
        Me.tpEmpleados.Controls.Add(lblSegundoNombre)
        Me.tpEmpleados.Controls.Add(lblFechaC)
        Me.tpEmpleados.Controls.Add(lblPwd)
        Me.tpEmpleados.Controls.Add(Me.txtPrimerNombre)
        Me.tpEmpleados.Controls.Add(lblUsuario)
        Me.tpEmpleados.Controls.Add(Me.txtPwd)
        Me.tpEmpleados.Controls.Add(lblPrimerNombre)
        Me.tpEmpleados.Controls.Add(Me.dtFechaC)
        Me.tpEmpleados.Controls.Add(Me.txtPrimerApe)
        Me.tpEmpleados.Controls.Add(lblIdRol)
        Me.tpEmpleados.Controls.Add(Me.txtSegundoNombre)
        Me.tpEmpleados.Controls.Add(lblPrimerApe)
        Me.tpEmpleados.Controls.Add(Me.txtUsuario)
        Me.tpEmpleados.Controls.Add(Me.txtSegundoApe)
        Me.tpEmpleados.Controls.Add(lblSegundoApe)
        Me.tpEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.tpEmpleados.Name = "tpEmpleados"
        Me.tpEmpleados.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmpleados.Size = New System.Drawing.Size(882, 471)
        Me.tpEmpleados.TabIndex = 0
        Me.tpEmpleados.Text = "Empleados"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.veterinario
        Me.PictureBox4.Location = New System.Drawing.Point(596, 12)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoF.My.Resources.Resources.veterinario
        Me.PictureBox3.Location = New System.Drawing.Point(210, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 26
        Me.PictureBox3.TabStop = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = Global.ProyectoF.My.Resources.Resources.delete
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminar.Location = New System.Drawing.Point(533, 392)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(169, 46)
        Me.BtnEliminar.TabIndex = 25
        Me.BtnEliminar.Text = "   Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.ProyectoF.My.Resources.Resources.edit
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(358, 392)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(169, 46)
        Me.BtnEditar.TabIndex = 24
        Me.BtnEditar.Text = "   Editar "
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'tbRegistros
        '
        Me.tbRegistros.BackColor = System.Drawing.Color.SeaShell
        Me.tbRegistros.Controls.Add(Me.PictureBox2)
        Me.tbRegistros.Controls.Add(Me.PictureBox1)
        Me.tbRegistros.Controls.Add(Me.Label2)
        Me.tbRegistros.Controls.Add(Me.txtBusqueda)
        Me.tbRegistros.Controls.Add(Me.GbRegistros)
        Me.tbRegistros.Location = New System.Drawing.Point(4, 25)
        Me.tbRegistros.Name = "tbRegistros"
        Me.tbRegistros.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegistros.Size = New System.Drawing.Size(882, 471)
        Me.tbRegistros.TabIndex = 1
        Me.tbRegistros.Text = "Registros Almacenados"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.veterinario
        Me.PictureBox2.Location = New System.Drawing.Point(606, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.veterinario
        Me.PictureBox1.Location = New System.Drawing.Point(195, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(283, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(294, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Registro Empleado " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(22, 110)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(818, 33)
        Me.txtBusqueda.TabIndex = 1
        Me.txtBusqueda.Text = "Buscar Empleado Por Nombre"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(22, 154)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Size = New System.Drawing.Size(821, 292)
        Me.GbRegistros.TabIndex = 0
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.BackgroundColor = System.Drawing.Color.White
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 18)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.RowTemplate.Height = 24
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(815, 271)
        Me.dgvRegistrosAlmacenados.TabIndex = 0
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(890, 581)
        Me.Controls.Add(Me.tcEmpleados)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEmpleados"
        Me.TitleBar.ResumeLayout(False)
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcEmpleados.ResumeLayout(False)
        Me.tpEmpleados.ResumeLayout(False)
        Me.tpEmpleados.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegistros.ResumeLayout(False)
        Me.tbRegistros.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleBar As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents BtnMinimize As PictureBox
    Friend WithEvents DBLosArcosDs As DBLosArcosDs
    Friend WithEvents EmpleadosBindingSource As BindingSource
    Friend WithEvents EmpleadosTableAdapter As DBLosArcosDsTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As DBLosArcosDsTableAdapters.TableAdapterManager
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents txtPrimerApe As TextBox
    Friend WithEvents txtSegundoApe As TextBox
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents dtFechaC As DateTimePicker
    Friend WithEvents cmbIdRol As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnVolver As Button
    Friend WithEvents tcEmpleados As TabControl
    Friend WithEvents tpEmpleados As TabPage
    Friend WithEvents tbRegistros As TabPage
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
