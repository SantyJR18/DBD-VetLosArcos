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
        Me.BtnGuardar = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        lblUsuario.AutoSize = True
        lblUsuario.Location = New System.Drawing.Point(153, 187)
        lblUsuario.Name = "lblUsuario"
        lblUsuario.Size = New System.Drawing.Size(61, 17)
        lblUsuario.TabIndex = 3
        lblUsuario.Text = "Usuario:"
        '
        'lblPwd
        '
        lblPwd.AutoSize = True
        lblPwd.Location = New System.Drawing.Point(136, 246)
        lblPwd.Name = "lblPwd"
        lblPwd.Size = New System.Drawing.Size(85, 17)
        lblPwd.TabIndex = 7
        lblPwd.Text = "Contraseña:"
        '
        'lblPrimerNombre
        '
        lblPrimerNombre.AutoSize = True
        lblPrimerNombre.Location = New System.Drawing.Point(130, 301)
        lblPrimerNombre.Name = "lblPrimerNombre"
        lblPrimerNombre.Size = New System.Drawing.Size(107, 17)
        lblPrimerNombre.TabIndex = 8
        lblPrimerNombre.Text = "Primer Nombre:"
        '
        'lblPrimerApe
        '
        lblPrimerApe.AutoSize = True
        lblPrimerApe.Location = New System.Drawing.Point(456, 302)
        lblPrimerApe.Name = "lblPrimerApe"
        lblPrimerApe.Size = New System.Drawing.Size(107, 17)
        lblPrimerApe.TabIndex = 9
        lblPrimerApe.Text = "Primer Apellido:"
        '
        'lblSegundoApe
        '
        lblSegundoApe.AutoSize = True
        lblSegundoApe.Location = New System.Drawing.Point(448, 358)
        lblSegundoApe.Name = "lblSegundoApe"
        lblSegundoApe.Size = New System.Drawing.Size(123, 17)
        lblSegundoApe.TabIndex = 11
        lblSegundoApe.Text = "Segundo Apellido:"
        '
        'lblIdRol
        '
        lblIdRol.AutoSize = True
        lblIdRol.Location = New System.Drawing.Point(520, 242)
        lblIdRol.Name = "lblIdRol"
        lblIdRol.Size = New System.Drawing.Size(50, 17)
        lblIdRol.TabIndex = 13
        lblIdRol.Text = "ID Rol:"
        '
        'lblSegundoNombre
        '
        lblSegundoNombre.AutoSize = True
        lblSegundoNombre.Location = New System.Drawing.Point(116, 359)
        lblSegundoNombre.Name = "lblSegundoNombre"
        lblSegundoNombre.Size = New System.Drawing.Size(123, 17)
        lblSegundoNombre.TabIndex = 15
        lblSegundoNombre.Text = "Segundo Nombre:"
        '
        'lblFechaC
        '
        lblFechaC.AutoSize = True
        lblFechaC.Location = New System.Drawing.Point(437, 186)
        lblFechaC.Name = "lblFechaC"
        lblFechaC.Size = New System.Drawing.Size(135, 17)
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
        Me.TableAdapterManager.ExpedientesTableAdapter = Nothing
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
        Me.txtUsuario.Location = New System.Drawing.Point(244, 184)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(160, 22)
        Me.txtUsuario.TabIndex = 4
        '
        'txtPwd
        '
        Me.txtPwd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "contrasenia", True))
        Me.txtPwd.Location = New System.Drawing.Point(244, 243)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(160, 22)
        Me.txtPwd.TabIndex = 8
        '
        'txtPrimerNombre
        '
        Me.txtPrimerNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "primerNombreEmp", True))
        Me.txtPrimerNombre.Location = New System.Drawing.Point(244, 298)
        Me.txtPrimerNombre.Name = "txtPrimerNombre"
        Me.txtPrimerNombre.Size = New System.Drawing.Size(160, 22)
        Me.txtPrimerNombre.TabIndex = 9
        '
        'txtPrimerApe
        '
        Me.txtPrimerApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "primerApellidoEmp", True))
        Me.txtPrimerApe.Location = New System.Drawing.Point(575, 299)
        Me.txtPrimerApe.Name = "txtPrimerApe"
        Me.txtPrimerApe.Size = New System.Drawing.Size(157, 22)
        Me.txtPrimerApe.TabIndex = 10
        '
        'txtSegundoApe
        '
        Me.txtSegundoApe.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SegundoApellidoEmp", True))
        Me.txtSegundoApe.Location = New System.Drawing.Point(577, 355)
        Me.txtSegundoApe.Name = "txtSegundoApe"
        Me.txtSegundoApe.Size = New System.Drawing.Size(155, 22)
        Me.txtSegundoApe.TabIndex = 12
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "segundoNombreEmp", True))
        Me.txtSegundoNombre.Location = New System.Drawing.Point(246, 356)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(158, 22)
        Me.txtSegundoNombre.TabIndex = 16
        '
        'dtFechaC
        '
        Me.dtFechaC.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "fechaContratacion", True))
        Me.dtFechaC.Location = New System.Drawing.Point(574, 182)
        Me.dtFechaC.Name = "dtFechaC"
        Me.dtFechaC.Size = New System.Drawing.Size(241, 22)
        Me.dtFechaC.TabIndex = 18
        '
        'cmbIdRol
        '
        Me.cmbIdRol.FormattingEnabled = True
        Me.cmbIdRol.Location = New System.Drawing.Point(574, 239)
        Me.cmbIdRol.Name = "cmbIdRol"
        Me.cmbIdRol.Size = New System.Drawing.Size(158, 24)
        Me.cmbIdRol.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(243, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 44)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Veterinaria Los Arcos"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.verify
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(378, 437)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(134, 46)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Crear"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(890, 581)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIdRol)
        Me.Controls.Add(lblFechaC)
        Me.Controls.Add(Me.dtFechaC)
        Me.Controls.Add(lblSegundoNombre)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(lblIdRol)
        Me.Controls.Add(lblSegundoApe)
        Me.Controls.Add(Me.txtSegundoApe)
        Me.Controls.Add(lblPrimerApe)
        Me.Controls.Add(Me.txtPrimerApe)
        Me.Controls.Add(lblPrimerNombre)
        Me.Controls.Add(Me.txtPrimerNombre)
        Me.Controls.Add(lblPwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.TitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleados"
        Me.Text = "FrmEmpleados"
        Me.TitleBar.ResumeLayout(False)
        CType(Me.BtnMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBLosArcosDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
