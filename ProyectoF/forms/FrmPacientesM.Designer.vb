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
        Me.TCPacientesMed = New System.Windows.Forms.TabControl()
        Me.TPPacMedico = New System.Windows.Forms.TabPage()
        Me.BtnEliminarPac = New System.Windows.Forms.Button()
        Me.BtnEditarPac = New System.Windows.Forms.Button()
        Me.BtnNuevoPac = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPac = New System.Windows.Forms.Button()
        Me.TBBuscarPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPacMed = New System.Windows.Forms.TabPage()
        Me.TPPacientesMed = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
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
        Me.TBtelClt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBdireccionClt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBcorreoClt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBapellidoClt = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBnombreClt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBcedulaClt = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TCPacientesMed.SuspendLayout()
        Me.TPPacMedico.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacMed.SuspendLayout()
        Me.TPPacientesMed.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        Me.TPExpDuenio.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCPacientesMed
        '
        Me.TCPacientesMed.Controls.Add(Me.TPPacMedico)
        Me.TCPacientesMed.Controls.Add(Me.TPDetPacMed)
        Me.TCPacientesMed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientesMed.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientesMed.Name = "TCPacientesMed"
        Me.TCPacientesMed.SelectedIndex = 0
        Me.TCPacientesMed.Size = New System.Drawing.Size(1028, 571)
        Me.TCPacientesMed.TabIndex = 5
        '
        'TPPacMedico
        '
        Me.TPPacMedico.BackColor = System.Drawing.Color.SeaShell
        Me.TPPacMedico.Controls.Add(Me.BtnEliminarPac)
        Me.TPPacMedico.Controls.Add(Me.BtnEditarPac)
        Me.TPPacMedico.Controls.Add(Me.BtnNuevoPac)
        Me.TPPacMedico.Controls.Add(Me.DataGridView1)
        Me.TPPacMedico.Controls.Add(Me.BtnBuscarPac)
        Me.TPPacMedico.Controls.Add(Me.TBBuscarPac)
        Me.TPPacMedico.Controls.Add(Me.Label2)
        Me.TPPacMedico.Location = New System.Drawing.Point(4, 22)
        Me.TPPacMedico.Name = "TPPacMedico"
        Me.TPPacMedico.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPacMedico.Size = New System.Drawing.Size(1020, 545)
        Me.TPPacMedico.TabIndex = 0
        Me.TPPacMedico.Text = "Pacientes"
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminarPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(808, 247)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarPac.TabIndex = 6
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnEditarPac
        '
        Me.BtnEditarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditarPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPac.Location = New System.Drawing.Point(808, 191)
        Me.BtnEditarPac.Name = "BtnEditarPac"
        Me.BtnEditarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarPac.TabIndex = 5
        Me.BtnEditarPac.Text = "Editar"
        Me.BtnEditarPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoPac
        '
        Me.BtnNuevoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNuevoPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPac.Location = New System.Drawing.Point(808, 136)
        Me.BtnNuevoPac.Name = "BtnNuevoPac"
        Me.BtnNuevoPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoPac.TabIndex = 4
        Me.BtnNuevoPac.Text = "Nuevo"
        Me.BtnNuevoPac.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(133, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarPac
        '
        Me.BtnBuscarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBuscarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPac.Location = New System.Drawing.Point(724, 107)
        Me.BtnBuscarPac.Name = "BtnBuscarPac"
        Me.BtnBuscarPac.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarPac.TabIndex = 2
        Me.BtnBuscarPac.Text = "Buscar"
        Me.BtnBuscarPac.UseVisualStyleBackColor = True
        '
        'TBBuscarPac
        '
        Me.TBBuscarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBBuscarPac.Location = New System.Drawing.Point(133, 107)
        Me.TBBuscarPac.Name = "TBBuscarPac"
        Me.TBBuscarPac.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscarPac.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar paciente:"
        '
        'TPDetPacMed
        '
        Me.TPDetPacMed.Controls.Add(Me.TPPacientesMed)
        Me.TPDetPacMed.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPacMed.Name = "TPDetPacMed"
        Me.TPDetPacMed.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPacMed.Size = New System.Drawing.Size(1020, 545)
        Me.TPDetPacMed.TabIndex = 1
        Me.TPDetPacMed.Text = "Detalles"
        Me.TPDetPacMed.UseVisualStyleBackColor = True
        '
        'TPPacientesMed
        '
        Me.TPPacientesMed.Controls.Add(Me.TPPaciente)
        Me.TPPacientesMed.Controls.Add(Me.TPExpDuenio)
        Me.TPPacientesMed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TPPacientesMed.Location = New System.Drawing.Point(3, 3)
        Me.TPPacientesMed.Name = "TPPacientesMed"
        Me.TPPacientesMed.SelectedIndex = 0
        Me.TPPacientesMed.Size = New System.Drawing.Size(1014, 539)
        Me.TPPacientesMed.TabIndex = 0
        '
        'TPPaciente
        '
        Me.TPPaciente.BackColor = System.Drawing.Color.SeaShell
        Me.TPPaciente.Controls.Add(Me.BtnGuardar)
        Me.TPPaciente.Controls.Add(Me.BtnCancelar)
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
        Me.TPPaciente.Size = New System.Drawing.Size(1006, 513)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Paciente"
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBNombrePac.Location = New System.Drawing.Point(689, 172)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(166, 20)
        Me.TBNombrePac.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(523, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNac
        '
        Me.TBFechaNac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBFechaNac.Location = New System.Drawing.Point(690, 205)
        Me.TBFechaNac.Name = "TBFechaNac"
        Me.TBFechaNac.Size = New System.Drawing.Size(166, 20)
        Me.TBFechaNac.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(523, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Nombre:"
        '
        'TBSenPar
        '
        Me.TBSenPar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSenPar.Location = New System.Drawing.Point(690, 240)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(166, 65)
        Me.TBSenPar.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(523, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Color:"
        '
        'TBColorPac
        '
        Me.TBColorPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBColorPac.Location = New System.Drawing.Point(690, 136)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(166, 20)
        Me.TBColorPac.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(150, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPac
        '
        Me.TBRazaPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBRazaPac.Location = New System.Drawing.Point(317, 238)
        Me.TBRazaPac.Name = "TBRazaPac"
        Me.TBRazaPac.Size = New System.Drawing.Size(166, 20)
        Me.TBRazaPac.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(523, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(317, 204)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(166, 21)
        Me.TBSexoPac.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePac
        '
        Me.TBEspeciePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBEspeciePac.Location = New System.Drawing.Point(317, 170)
        Me.TBEspeciePac.Name = "TBEspeciePac"
        Me.TBEspeciePac.Size = New System.Drawing.Size(166, 20)
        Me.TBEspeciePac.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(150, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Especie:"
        '
        'TBIdPac
        '
        Me.TBIdPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBIdPac.Location = New System.Drawing.Point(317, 137)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(166, 20)
        Me.TBIdPac.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(150, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID del paciente:"
        '
        'TPExpDuenio
        '
        Me.TPExpDuenio.BackColor = System.Drawing.Color.SeaShell
        Me.TPExpDuenio.Controls.Add(Me.TBtelClt)
        Me.TPExpDuenio.Controls.Add(Me.Label11)
        Me.TPExpDuenio.Controls.Add(Me.TBdireccionClt)
        Me.TPExpDuenio.Controls.Add(Me.Label12)
        Me.TPExpDuenio.Controls.Add(Me.TBcorreoClt)
        Me.TPExpDuenio.Controls.Add(Me.Label13)
        Me.TPExpDuenio.Controls.Add(Me.TBapellidoClt)
        Me.TPExpDuenio.Controls.Add(Me.Label14)
        Me.TPExpDuenio.Controls.Add(Me.TBnombreClt)
        Me.TPExpDuenio.Controls.Add(Me.Label15)
        Me.TPExpDuenio.Controls.Add(Me.TBcedulaClt)
        Me.TPExpDuenio.Controls.Add(Me.Label16)
        Me.TPExpDuenio.Location = New System.Drawing.Point(4, 22)
        Me.TPExpDuenio.Name = "TPExpDuenio"
        Me.TPExpDuenio.Padding = New System.Windows.Forms.Padding(3)
        Me.TPExpDuenio.Size = New System.Drawing.Size(1006, 513)
        Me.TPExpDuenio.TabIndex = 1
        Me.TPExpDuenio.Text = "Dueño"
        '
        'TBtelClt
        '
        Me.TBtelClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBtelClt.Location = New System.Drawing.Point(689, 225)
        Me.TBtelClt.Name = "TBtelClt"
        Me.TBtelClt.Size = New System.Drawing.Size(166, 20)
        Me.TBtelClt.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(523, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Teléfono:"
        '
        'TBdireccionClt
        '
        Me.TBdireccionClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBdireccionClt.Location = New System.Drawing.Point(690, 258)
        Me.TBdireccionClt.Multiline = True
        Me.TBdireccionClt.Name = "TBdireccionClt"
        Me.TBdireccionClt.Size = New System.Drawing.Size(166, 65)
        Me.TBdireccionClt.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(523, 190)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Correo:"
        '
        'TBcorreoClt
        '
        Me.TBcorreoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcorreoClt.Location = New System.Drawing.Point(690, 189)
        Me.TBcorreoClt.Name = "TBcorreoClt"
        Me.TBcorreoClt.Size = New System.Drawing.Size(166, 20)
        Me.TBcorreoClt.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(523, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Dirección:"
        '
        'TBapellidoClt
        '
        Me.TBapellidoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBapellidoClt.FormattingEnabled = True
        Me.TBapellidoClt.Location = New System.Drawing.Point(317, 257)
        Me.TBapellidoClt.Name = "TBapellidoClt"
        Me.TBapellidoClt.Size = New System.Drawing.Size(166, 21)
        Me.TBapellidoClt.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(150, 258)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Apellido:"
        '
        'TBnombreClt
        '
        Me.TBnombreClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBnombreClt.Location = New System.Drawing.Point(317, 223)
        Me.TBnombreClt.Name = "TBnombreClt"
        Me.TBnombreClt.Size = New System.Drawing.Size(166, 20)
        Me.TBnombreClt.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(150, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Nombre:"
        '
        'TBcedulaClt
        '
        Me.TBcedulaClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcedulaClt.Location = New System.Drawing.Point(317, 190)
        Me.TBcedulaClt.Name = "TBcedulaClt"
        Me.TBcedulaClt.Size = New System.Drawing.Size(98, 20)
        Me.TBcedulaClt.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(150, 191)
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
        Me.PnlTitle.Size = New System.Drawing.Size(1028, 38)
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
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
        Me.BtnCerrar.Location = New System.Drawing.Point(988, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(382, 340)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 36
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(525, 340)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancelar.TabIndex = 37
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmPacientesM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.TCPacientesMed)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPacientesM"
        Me.Text = "FrmExpedientePacientes"
        Me.TCPacientesMed.ResumeLayout(False)
        Me.TPPacMedico.ResumeLayout(False)
        Me.TPPacMedico.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacMed.ResumeLayout(False)
        Me.TPPacientesMed.ResumeLayout(False)
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
    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnEditarPac As Button
    Friend WithEvents BtnNuevoPac As Button
    Friend WithEvents BtnBuscarPac As Button
    Friend WithEvents TCPacientesMed As TabControl
    Friend WithEvents TPPacMedico As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBBuscarPac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetPacMed As TabPage
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TPPacientesMed As TabControl
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
    Friend WithEvents TBtelClt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBdireccionClt As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBcorreoClt As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBapellidoClt As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBnombreClt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBcedulaClt As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
End Class
