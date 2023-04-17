<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPacientesM
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
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPMedico = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegMedPac = New System.Windows.Forms.Button()
        Me.BtnEditarMedPac = New System.Windows.Forms.Button()
        Me.BtnNuevoMedPac = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarMedPac = New System.Windows.Forms.Button()
        Me.TBBuscMedPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
        Me.TPMedPacientes = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.BtnEliminarPac = New System.Windows.Forms.Button()
        Me.BtnGuardarPac = New System.Windows.Forms.Button()
        Me.TBNombrePac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBFechaNac = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBSenPar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBColorPac = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBRazaPac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPac = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEspeciePac = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBIdPac = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPExpDuenio = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TBtelCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBdireccionCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBcorreoCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBapellidoCliente = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBnombreCliente = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBcedulaCliente = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientes.SuspendLayout()
        Me.TPMedico.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPac.SuspendLayout()
        Me.TPMedPacientes.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        Me.TPExpDuenio.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPMedico)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(794, 431)
        Me.TCPacientes.TabIndex = 5
        '
        'TPMedico
        '
        Me.TPMedico.Controls.Add(Me.BtnEliminarRegMedPac)
        Me.TPMedico.Controls.Add(Me.BtnEditarMedPac)
        Me.TPMedico.Controls.Add(Me.BtnNuevoMedPac)
        Me.TPMedico.Controls.Add(Me.DataGridView1)
        Me.TPMedico.Controls.Add(Me.BtnBuscarMedPac)
        Me.TPMedico.Controls.Add(Me.TBBuscMedPac)
        Me.TPMedico.Controls.Add(Me.Label2)
        Me.TPMedico.Location = New System.Drawing.Point(4, 22)
        Me.TPMedico.Name = "TPMedico"
        Me.TPMedico.Padding = New System.Windows.Forms.Padding(3)
        Me.TPMedico.Size = New System.Drawing.Size(786, 405)
        Me.TPMedico.TabIndex = 0
        Me.TPMedico.Text = "Pacientes"
        Me.TPMedico.UseVisualStyleBackColor = True
        '
        'BtnEliminarRegMedPac
        '
        Me.BtnEliminarRegMedPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegMedPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegMedPac.Location = New System.Drawing.Point(689, 178)
        Me.BtnEliminarRegMedPac.Name = "BtnEliminarRegMedPac"
        Me.BtnEliminarRegMedPac.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegMedPac.TabIndex = 6
        Me.BtnEliminarRegMedPac.Text = "Eliminar"
        Me.BtnEliminarRegMedPac.UseVisualStyleBackColor = True
        '
        'BtnEditarMedPac
        '
        Me.BtnEditarMedPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarMedPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarMedPac.Location = New System.Drawing.Point(689, 122)
        Me.BtnEditarMedPac.Name = "BtnEditarMedPac"
        Me.BtnEditarMedPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarMedPac.TabIndex = 5
        Me.BtnEditarMedPac.Text = "Editar"
        Me.BtnEditarMedPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoMedPac
        '
        Me.BtnNuevoMedPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoMedPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoMedPac.Location = New System.Drawing.Point(689, 67)
        Me.BtnNuevoMedPac.Name = "BtnNuevoMedPac"
        Me.BtnNuevoMedPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoMedPac.TabIndex = 4
        Me.BtnNuevoMedPac.Text = "Nuevo"
        Me.BtnNuevoMedPac.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarMedPac
        '
        Me.BtnBuscarMedPac.Image = Global.ProyectoF.My.Resources.Resources.searchVet
        Me.BtnBuscarMedPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarMedPac.Location = New System.Drawing.Point(605, 38)
        Me.BtnBuscarMedPac.Name = "BtnBuscarMedPac"
        Me.BtnBuscarMedPac.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarMedPac.TabIndex = 2
        Me.BtnBuscarMedPac.Text = "Buscar"
        Me.BtnBuscarMedPac.UseVisualStyleBackColor = True
        '
        'TBBuscMedPac
        '
        Me.TBBuscMedPac.Location = New System.Drawing.Point(14, 38)
        Me.TBBuscMedPac.Name = "TBBuscMedPac"
        Me.TBBuscMedPac.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscMedPac.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar paciente:"
        '
        'TPDetPac
        '
        Me.TPDetPac.Controls.Add(Me.TPMedPacientes)
        Me.TPDetPac.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPac.Size = New System.Drawing.Size(786, 405)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        Me.TPDetPac.UseVisualStyleBackColor = True
        '
        'TPMedPacientes
        '
        Me.TPMedPacientes.Controls.Add(Me.TPPaciente)
        Me.TPMedPacientes.Controls.Add(Me.TPExpDuenio)
        Me.TPMedPacientes.Location = New System.Drawing.Point(23, 45)
        Me.TPMedPacientes.Name = "TPMedPacientes"
        Me.TPMedPacientes.SelectedIndex = 0
        Me.TPMedPacientes.Size = New System.Drawing.Size(733, 316)
        Me.TPMedPacientes.TabIndex = 0
        '
        'TPPaciente
        '
        Me.TPPaciente.Controls.Add(Me.BtnEliminarPac)
        Me.TPPaciente.Controls.Add(Me.BtnGuardarPac)
        Me.TPPaciente.Controls.Add(Me.TBNombrePac)
        Me.TPPaciente.Controls.Add(Me.Label10)
        Me.TPPaciente.Controls.Add(Me.TBFechaNac)
        Me.TPPaciente.Controls.Add(Me.Label9)
        Me.TPPaciente.Controls.Add(Me.TBSenPar)
        Me.TPPaciente.Controls.Add(Me.Label8)
        Me.TPPaciente.Controls.Add(Me.TBColorPac)
        Me.TPPaciente.Controls.Add(Me.Label7)
        Me.TPPaciente.Controls.Add(Me.TBRazaPac)
        Me.TPPaciente.Controls.Add(Me.Label6)
        Me.TPPaciente.Controls.Add(Me.TBSexoPac)
        Me.TPPaciente.Controls.Add(Me.Label5)
        Me.TPPaciente.Controls.Add(Me.TBEspeciePac)
        Me.TPPaciente.Controls.Add(Me.Label3)
        Me.TPPaciente.Controls.Add(Me.TBIdPac)
        Me.TPPaciente.Controls.Add(Me.Label4)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 22)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPaciente.Size = New System.Drawing.Size(725, 290)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Paciente"
        Me.TPPaciente.UseVisualStyleBackColor = True
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(403, 229)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEliminarPac.TabIndex = 36
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnGuardarPac
        '
        Me.BtnGuardarPac.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPac.Location = New System.Drawing.Point(240, 229)
        Me.BtnGuardarPac.Name = "BtnGuardarPac"
        Me.BtnGuardarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnGuardarPac.TabIndex = 35
        Me.BtnGuardarPac.Text = "Guardar"
        Me.BtnGuardarPac.UseVisualStyleBackColor = True
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Location = New System.Drawing.Point(548, 61)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(166, 20)
        Me.TBNombrePac.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(382, 93)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNac
        '
        Me.TBFechaNac.Location = New System.Drawing.Point(549, 94)
        Me.TBFechaNac.Name = "TBFechaNac"
        Me.TBFechaNac.Size = New System.Drawing.Size(166, 20)
        Me.TBFechaNac.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(382, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Nombre:"
        '
        'TBSenPar
        '
        Me.TBSenPar.Location = New System.Drawing.Point(549, 129)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(166, 65)
        Me.TBSenPar.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(382, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Color:"
        '
        'TBColorPac
        '
        Me.TBColorPac.Location = New System.Drawing.Point(549, 25)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(166, 20)
        Me.TBColorPac.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPac
        '
        Me.TBRazaPac.Location = New System.Drawing.Point(176, 127)
        Me.TBRazaPac.Name = "TBRazaPac"
        Me.TBRazaPac.Size = New System.Drawing.Size(166, 20)
        Me.TBRazaPac.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(382, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(176, 93)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(166, 21)
        Me.TBSexoPac.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePac
        '
        Me.TBEspeciePac.Location = New System.Drawing.Point(176, 59)
        Me.TBEspeciePac.Name = "TBEspeciePac"
        Me.TBEspeciePac.Size = New System.Drawing.Size(166, 20)
        Me.TBEspeciePac.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Especie:"
        '
        'TBIdPac
        '
        Me.TBIdPac.Location = New System.Drawing.Point(176, 26)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(98, 20)
        Me.TBIdPac.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID del paciente:"
        '
        'TPExpDuenio
        '
        Me.TPExpDuenio.Controls.Add(Me.Button1)
        Me.TPExpDuenio.Controls.Add(Me.Button2)
        Me.TPExpDuenio.Controls.Add(Me.TBtelCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label11)
        Me.TPExpDuenio.Controls.Add(Me.TBdireccionCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label12)
        Me.TPExpDuenio.Controls.Add(Me.TBcorreoCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label13)
        Me.TPExpDuenio.Controls.Add(Me.TBapellidoCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label14)
        Me.TPExpDuenio.Controls.Add(Me.TBnombreCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label15)
        Me.TPExpDuenio.Controls.Add(Me.TBcedulaCliente)
        Me.TPExpDuenio.Controls.Add(Me.Label16)
        Me.TPExpDuenio.Location = New System.Drawing.Point(4, 22)
        Me.TPExpDuenio.Name = "TPExpDuenio"
        Me.TPExpDuenio.Padding = New System.Windows.Forms.Padding(3)
        Me.TPExpDuenio.Size = New System.Drawing.Size(725, 290)
        Me.TPExpDuenio.TabIndex = 1
        Me.TPExpDuenio.Text = "Dueño"
        Me.TPExpDuenio.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(403, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 37)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Eliminar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(240, 229)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 37)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TBtelCliente
        '
        Me.TBtelCliente.Location = New System.Drawing.Point(548, 61)
        Me.TBtelCliente.Name = "TBtelCliente"
        Me.TBtelCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBtelCliente.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(382, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Teléfono:"
        '
        'TBdireccionCliente
        '
        Me.TBdireccionCliente.Location = New System.Drawing.Point(549, 94)
        Me.TBdireccionCliente.Multiline = True
        Me.TBdireccionCliente.Name = "TBdireccionCliente"
        Me.TBdireccionCliente.Size = New System.Drawing.Size(166, 65)
        Me.TBdireccionCliente.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(382, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Correo:"
        '
        'TBcorreoCliente
        '
        Me.TBcorreoCliente.Location = New System.Drawing.Point(549, 25)
        Me.TBcorreoCliente.Name = "TBcorreoCliente"
        Me.TBcorreoCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBcorreoCliente.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(382, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Dirección:"
        '
        'TBapellidoCliente
        '
        Me.TBapellidoCliente.FormattingEnabled = True
        Me.TBapellidoCliente.Location = New System.Drawing.Point(176, 93)
        Me.TBapellidoCliente.Name = "TBapellidoCliente"
        Me.TBapellidoCliente.Size = New System.Drawing.Size(166, 21)
        Me.TBapellidoCliente.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Apellido:"
        '
        'TBnombreCliente
        '
        Me.TBnombreCliente.Location = New System.Drawing.Point(176, 59)
        Me.TBnombreCliente.Name = "TBnombreCliente"
        Me.TBnombreCliente.Size = New System.Drawing.Size(166, 20)
        Me.TBnombreCliente.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Nombre:"
        '
        'TBcedulaCliente
        '
        Me.TBcedulaCliente.Location = New System.Drawing.Point(176, 26)
        Me.TBcedulaCliente.Name = "TBcedulaCliente"
        Me.TBcedulaCliente.Size = New System.Drawing.Size(98, 20)
        Me.TBcedulaCliente.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(9, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Cédula:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(794, 38)
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pacientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(750, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'FrmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 469)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedico"
        Me.Text = "FrmExpedientePacientes"
        Me.TCPacientes.ResumeLayout(False)
        Me.TPMedico.ResumeLayout(False)
        Me.TPMedico.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPMedPacientes.ResumeLayout(False)
        Me.TPPaciente.ResumeLayout(False)
        Me.TPPaciente.PerformLayout()
        Me.TPExpDuenio.ResumeLayout(False)
        Me.TPExpDuenio.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnEliminarRegMedPac As Button
    Friend WithEvents BtnEditarMedPac As Button
    Friend WithEvents BtnNuevoMedPac As Button
    Friend WithEvents BtnBuscarMedPac As Button
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPMedico As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBBuscMedPac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TPMedPacientes As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents TBNombrePac As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBFechaNac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBColorPac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBRazaPac As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEspeciePac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBIdPac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TPExpDuenio As TabPage
    Friend WithEvents TBtelCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBdireccionCliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBcorreoCliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBapellidoCliente As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBnombreCliente As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBcedulaCliente As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnGuardarPac As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
