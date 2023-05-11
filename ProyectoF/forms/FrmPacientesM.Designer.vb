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
        Me.BtnEliminarRegPacMed = New System.Windows.Forms.Button()
        Me.BtnEditarPacMed = New System.Windows.Forms.Button()
        Me.BtnNuevoPacMed = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPacMed = New System.Windows.Forms.Button()
        Me.TBBuscMedPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPacMed = New System.Windows.Forms.TabPage()
        Me.TPPacientesMed = New System.Windows.Forms.TabControl()
        Me.TPPacienteMed = New System.Windows.Forms.TabPage()
        Me.BtnCancelarPacMed = New System.Windows.Forms.Button()
        Me.BtnGuardarPacMed = New System.Windows.Forms.Button()
        Me.TBNombrePacMed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBFechaNacMed = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBSenParMed = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBColorPacMed = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBRazaPacMed = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPacMed = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEspeciePacMed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBIdPacMed = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TPExpDuenio = New System.Windows.Forms.TabPage()
        Me.TBtelClienteMed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBdireccionClienteMed = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TBcorreoClienteMed = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TBapellidoClienteMed = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TBnombreClienteMed = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TBcedulaClienteMed = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesMed.SuspendLayout()
        Me.TPPacMedico.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacMed.SuspendLayout()
        Me.TPPacientesMed.SuspendLayout()
        Me.TPPacienteMed.SuspendLayout()
        Me.TPExpDuenio.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCPacientesMed
        '
        Me.TCPacientesMed.Controls.Add(Me.TPPacMedico)
        Me.TCPacientesMed.Controls.Add(Me.TPDetPacMed)
        Me.TCPacientesMed.Location = New System.Drawing.Point(0, 47)
        Me.TCPacientesMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TCPacientesMed.Name = "TCPacientesMed"
        Me.TCPacientesMed.SelectedIndex = 0
        Me.TCPacientesMed.Size = New System.Drawing.Size(1059, 530)
        Me.TCPacientesMed.TabIndex = 5
        '
        'TPPacMedico
        '
        Me.TPPacMedico.Controls.Add(Me.BtnEliminarRegPacMed)
        Me.TPPacMedico.Controls.Add(Me.BtnEditarPacMed)
        Me.TPPacMedico.Controls.Add(Me.BtnNuevoPacMed)
        Me.TPPacMedico.Controls.Add(Me.DataGridView1)
        Me.TPPacMedico.Controls.Add(Me.BtnBuscarPacMed)
        Me.TPPacMedico.Controls.Add(Me.TBBuscMedPac)
        Me.TPPacMedico.Controls.Add(Me.Label2)
        Me.TPPacMedico.Location = New System.Drawing.Point(4, 25)
        Me.TPPacMedico.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPacMedico.Name = "TPPacMedico"
        Me.TPPacMedico.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPacMedico.Size = New System.Drawing.Size(1051, 501)
        Me.TPPacMedico.TabIndex = 0
        Me.TPPacMedico.Text = "Pacientes"
        Me.TPPacMedico.UseVisualStyleBackColor = True
        '
        'BtnEliminarRegPacMed
        '
        Me.BtnEliminarRegPacMed.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegPacMed.Location = New System.Drawing.Point(919, 219)
        Me.BtnEliminarRegPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminarRegPacMed.Name = "BtnEliminarRegPacMed"
        Me.BtnEliminarRegPacMed.Size = New System.Drawing.Size(109, 44)
        Me.BtnEliminarRegPacMed.TabIndex = 6
        Me.BtnEliminarRegPacMed.Text = "Eliminar"
        Me.BtnEliminarRegPacMed.UseVisualStyleBackColor = True
        '
        'BtnEditarPacMed
        '
        Me.BtnEditarPacMed.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPacMed.Location = New System.Drawing.Point(919, 150)
        Me.BtnEditarPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditarPacMed.Name = "BtnEditarPacMed"
        Me.BtnEditarPacMed.Size = New System.Drawing.Size(109, 46)
        Me.BtnEditarPacMed.TabIndex = 5
        Me.BtnEditarPacMed.Text = "Editar"
        Me.BtnEditarPacMed.UseVisualStyleBackColor = True
        '
        'BtnNuevoPacMed
        '
        Me.BtnNuevoPacMed.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPacMed.Location = New System.Drawing.Point(919, 82)
        Me.BtnNuevoPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevoPacMed.Name = "BtnNuevoPacMed"
        Me.BtnNuevoPacMed.Size = New System.Drawing.Size(109, 46)
        Me.BtnNuevoPacMed.TabIndex = 4
        Me.BtnNuevoPacMed.Text = "Nuevo"
        Me.BtnNuevoPacMed.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 82)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(888, 401)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarPacMed
        '
        Me.BtnBuscarPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPacMed.Location = New System.Drawing.Point(807, 47)
        Me.BtnBuscarPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscarPacMed.Name = "BtnBuscarPacMed"
        Me.BtnBuscarPacMed.Size = New System.Drawing.Size(100, 28)
        Me.BtnBuscarPacMed.TabIndex = 2
        Me.BtnBuscarPacMed.Text = "Buscar"
        Me.BtnBuscarPacMed.UseVisualStyleBackColor = True
        '
        'TBBuscMedPac
        '
        Me.TBBuscMedPac.Location = New System.Drawing.Point(19, 47)
        Me.TBBuscMedPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscMedPac.Name = "TBBuscMedPac"
        Me.TBBuscMedPac.Size = New System.Drawing.Size(753, 22)
        Me.TBBuscMedPac.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar paciente:"
        '
        'TPDetPacMed
        '
        Me.TPDetPacMed.Controls.Add(Me.TPPacientesMed)
        Me.TPDetPacMed.Location = New System.Drawing.Point(4, 25)
        Me.TPDetPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TPDetPacMed.Name = "TPDetPacMed"
        Me.TPDetPacMed.Padding = New System.Windows.Forms.Padding(4)
        Me.TPDetPacMed.Size = New System.Drawing.Size(1051, 501)
        Me.TPDetPacMed.TabIndex = 1
        Me.TPDetPacMed.Text = "Detalles"
        Me.TPDetPacMed.UseVisualStyleBackColor = True
        '
        'TPPacientesMed
        '
        Me.TPPacientesMed.Controls.Add(Me.TPPacienteMed)
        Me.TPPacientesMed.Controls.Add(Me.TPExpDuenio)
        Me.TPPacientesMed.Location = New System.Drawing.Point(36, 55)
        Me.TPPacientesMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPacientesMed.Name = "TPPacientesMed"
        Me.TPPacientesMed.SelectedIndex = 0
        Me.TPPacientesMed.Size = New System.Drawing.Size(977, 389)
        Me.TPPacientesMed.TabIndex = 0
        '
        'TPPacienteMed
        '
        Me.TPPacienteMed.Controls.Add(Me.BtnCancelarPacMed)
        Me.TPPacienteMed.Controls.Add(Me.BtnGuardarPacMed)
        Me.TPPacienteMed.Controls.Add(Me.TBNombrePacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label10)
        Me.TPPacienteMed.Controls.Add(Me.TBFechaNacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label9)
        Me.TPPacienteMed.Controls.Add(Me.TBSenParMed)
        Me.TPPacienteMed.Controls.Add(Me.Label8)
        Me.TPPacienteMed.Controls.Add(Me.TBColorPacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label7)
        Me.TPPacienteMed.Controls.Add(Me.TBRazaPacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label6)
        Me.TPPacienteMed.Controls.Add(Me.TBSexoPacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label5)
        Me.TPPacienteMed.Controls.Add(Me.TBEspeciePacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label3)
        Me.TPPacienteMed.Controls.Add(Me.TBIdPacMed)
        Me.TPPacienteMed.Controls.Add(Me.Label4)
        Me.TPPacienteMed.Location = New System.Drawing.Point(4, 25)
        Me.TPPacienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPacienteMed.Name = "TPPacienteMed"
        Me.TPPacienteMed.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPacienteMed.Size = New System.Drawing.Size(969, 360)
        Me.TPPacienteMed.TabIndex = 0
        Me.TPPacienteMed.Text = "Paciente"
        Me.TPPacienteMed.UseVisualStyleBackColor = True
        '
        'BtnCancelarPacMed
        '
        Me.BtnCancelarPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPacMed.Location = New System.Drawing.Point(537, 282)
        Me.BtnCancelarPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCancelarPacMed.Name = "BtnCancelarPacMed"
        Me.BtnCancelarPacMed.Size = New System.Drawing.Size(109, 46)
        Me.BtnCancelarPacMed.TabIndex = 36
        Me.BtnCancelarPacMed.Text = "Cancelar"
        Me.BtnCancelarPacMed.UseVisualStyleBackColor = True
        '
        'BtnGuardarPacMed
        '
        Me.BtnGuardarPacMed.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPacMed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPacMed.Location = New System.Drawing.Point(320, 282)
        Me.BtnGuardarPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarPacMed.Name = "BtnGuardarPacMed"
        Me.BtnGuardarPacMed.Size = New System.Drawing.Size(109, 46)
        Me.BtnGuardarPacMed.TabIndex = 35
        Me.BtnGuardarPacMed.Text = "Guardar"
        Me.BtnGuardarPacMed.UseVisualStyleBackColor = True
        '
        'TBNombrePacMed
        '
        Me.TBNombrePacMed.Location = New System.Drawing.Point(731, 75)
        Me.TBNombrePacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombrePacMed.Name = "TBNombrePacMed"
        Me.TBNombrePacMed.Size = New System.Drawing.Size(220, 22)
        Me.TBNombrePacMed.TabIndex = 30
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(509, 114)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNacMed
        '
        Me.TBFechaNacMed.Location = New System.Drawing.Point(732, 116)
        Me.TBFechaNacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBFechaNacMed.Name = "TBFechaNacMed"
        Me.TBFechaNacMed.Size = New System.Drawing.Size(220, 22)
        Me.TBFechaNacMed.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(509, 74)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Nombre:"
        '
        'TBSenParMed
        '
        Me.TBSenParMed.Location = New System.Drawing.Point(732, 159)
        Me.TBSenParMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSenParMed.Multiline = True
        Me.TBSenParMed.Name = "TBSenParMed"
        Me.TBSenParMed.Size = New System.Drawing.Size(220, 79)
        Me.TBSenParMed.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(509, 32)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Color:"
        '
        'TBColorPacMed
        '
        Me.TBColorPacMed.Location = New System.Drawing.Point(732, 31)
        Me.TBColorPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBColorPacMed.Name = "TBColorPacMed"
        Me.TBColorPacMed.Size = New System.Drawing.Size(220, 22)
        Me.TBColorPacMed.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 159)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPacMed
        '
        Me.TBRazaPacMed.Location = New System.Drawing.Point(235, 156)
        Me.TBRazaPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBRazaPacMed.Name = "TBRazaPacMed"
        Me.TBRazaPacMed.Size = New System.Drawing.Size(220, 22)
        Me.TBRazaPacMed.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(509, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 20)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPacMed
        '
        Me.TBSexoPacMed.FormattingEnabled = True
        Me.TBSexoPacMed.Location = New System.Drawing.Point(235, 114)
        Me.TBSexoPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSexoPacMed.Name = "TBSexoPacMed"
        Me.TBSexoPacMed.Size = New System.Drawing.Size(220, 24)
        Me.TBSexoPacMed.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePacMed
        '
        Me.TBEspeciePacMed.Location = New System.Drawing.Point(235, 73)
        Me.TBEspeciePacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBEspeciePacMed.Name = "TBEspeciePacMed"
        Me.TBEspeciePacMed.Size = New System.Drawing.Size(220, 22)
        Me.TBEspeciePacMed.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Especie:"
        '
        'TBIdPacMed
        '
        Me.TBIdPacMed.Location = New System.Drawing.Point(235, 32)
        Me.TBIdPacMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBIdPacMed.Name = "TBIdPacMed"
        Me.TBIdPacMed.Size = New System.Drawing.Size(129, 22)
        Me.TBIdPacMed.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "ID del paciente:"
        '
        'TPExpDuenio
        '
        Me.TPExpDuenio.Controls.Add(Me.TBtelClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label11)
        Me.TPExpDuenio.Controls.Add(Me.TBdireccionClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label12)
        Me.TPExpDuenio.Controls.Add(Me.TBcorreoClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label13)
        Me.TPExpDuenio.Controls.Add(Me.TBapellidoClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label14)
        Me.TPExpDuenio.Controls.Add(Me.TBnombreClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label15)
        Me.TPExpDuenio.Controls.Add(Me.TBcedulaClienteMed)
        Me.TPExpDuenio.Controls.Add(Me.Label16)
        Me.TPExpDuenio.Location = New System.Drawing.Point(4, 25)
        Me.TPExpDuenio.Margin = New System.Windows.Forms.Padding(4)
        Me.TPExpDuenio.Name = "TPExpDuenio"
        Me.TPExpDuenio.Padding = New System.Windows.Forms.Padding(4)
        Me.TPExpDuenio.Size = New System.Drawing.Size(969, 360)
        Me.TPExpDuenio.TabIndex = 1
        Me.TPExpDuenio.Text = "Dueño"
        Me.TPExpDuenio.UseVisualStyleBackColor = True
        '
        'TBtelClienteMed
        '
        Me.TBtelClienteMed.Location = New System.Drawing.Point(731, 140)
        Me.TBtelClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBtelClienteMed.Name = "TBtelClienteMed"
        Me.TBtelClienteMed.Size = New System.Drawing.Size(220, 22)
        Me.TBtelClienteMed.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(509, 139)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 20)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Teléfono:"
        '
        'TBdireccionClienteMed
        '
        Me.TBdireccionClienteMed.Location = New System.Drawing.Point(732, 181)
        Me.TBdireccionClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBdireccionClienteMed.Multiline = True
        Me.TBdireccionClienteMed.Name = "TBdireccionClienteMed"
        Me.TBdireccionClienteMed.Size = New System.Drawing.Size(220, 79)
        Me.TBdireccionClienteMed.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(509, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Correo:"
        '
        'TBcorreoClienteMed
        '
        Me.TBcorreoClienteMed.Location = New System.Drawing.Point(732, 96)
        Me.TBcorreoClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcorreoClienteMed.Name = "TBcorreoClienteMed"
        Me.TBcorreoClienteMed.Size = New System.Drawing.Size(220, 22)
        Me.TBcorreoClienteMed.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(509, 181)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 20)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Dirección:"
        '
        'TBapellidoClienteMed
        '
        Me.TBapellidoClienteMed.FormattingEnabled = True
        Me.TBapellidoClienteMed.Location = New System.Drawing.Point(235, 180)
        Me.TBapellidoClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBapellidoClienteMed.Name = "TBapellidoClienteMed"
        Me.TBapellidoClienteMed.Size = New System.Drawing.Size(220, 24)
        Me.TBapellidoClienteMed.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 181)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 20)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Apellido:"
        '
        'TBnombreClienteMed
        '
        Me.TBnombreClienteMed.Location = New System.Drawing.Point(235, 138)
        Me.TBnombreClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBnombreClienteMed.Name = "TBnombreClienteMed"
        Me.TBnombreClienteMed.Size = New System.Drawing.Size(220, 22)
        Me.TBnombreClienteMed.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 139)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 20)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Nombre:"
        '
        'TBcedulaClienteMed
        '
        Me.TBcedulaClienteMed.Location = New System.Drawing.Point(235, 97)
        Me.TBcedulaClienteMed.Margin = New System.Windows.Forms.Padding(4)
        Me.TBcedulaClienteMed.Name = "TBcedulaClienteMed"
        Me.TBcedulaClienteMed.Size = New System.Drawing.Size(129, 22)
        Me.TBcedulaClienteMed.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 98)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Cédula:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1059, 47)
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.BtnCerrar.Location = New System.Drawing.Point(1000, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'FrmPacientesM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 577)
        Me.Controls.Add(Me.TCPacientesMed)
        Me.Controls.Add(Me.PnlTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmPacientesM"
        Me.Text = "FrmExpedientePacientes"
        Me.TCPacientesMed.ResumeLayout(False)
        Me.TPPacMedico.ResumeLayout(False)
        Me.TPPacMedico.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacMed.ResumeLayout(False)
        Me.TPPacientesMed.ResumeLayout(False)
        Me.TPPacienteMed.ResumeLayout(False)
        Me.TPPacienteMed.PerformLayout()
        Me.TPExpDuenio.ResumeLayout(False)
        Me.TPExpDuenio.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnEliminarRegPacMed As Button
    Friend WithEvents BtnEditarPacMed As Button
    Friend WithEvents BtnNuevoPacMed As Button
    Friend WithEvents BtnBuscarPacMed As Button
    Friend WithEvents TCPacientesMed As TabControl
    Friend WithEvents TPPacMedico As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBBuscMedPac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetPacMed As TabPage
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TPPacientesMed As TabControl
    Friend WithEvents TPPacienteMed As TabPage
    Friend WithEvents TBNombrePacMed As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBFechaNacMed As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TBSenParMed As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBColorPacMed As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBRazaPacMed As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPacMed As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEspeciePacMed As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBIdPacMed As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TPExpDuenio As TabPage
    Friend WithEvents TBtelClienteMed As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBdireccionClienteMed As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TBcorreoClienteMed As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TBapellidoClienteMed As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TBnombreClienteMed As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TBcedulaClienteMed As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnCancelarPacMed As Button
    Friend WithEvents BtnGuardarPacMed As Button
End Class
