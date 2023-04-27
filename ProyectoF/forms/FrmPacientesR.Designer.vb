<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPacientesR
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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesRec = New System.Windows.Forms.TabControl()
        Me.TPPacienteRec = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegPacRec = New System.Windows.Forms.Button()
        Me.BtnEditarPacRec = New System.Windows.Forms.Button()
        Me.BtnNuevoPacRec = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPacRec = New System.Windows.Forms.Button()
        Me.TBBuscPacRec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPacRec = New System.Windows.Forms.TabPage()
        Me.BtnCancelarPacRec = New System.Windows.Forms.Button()
        Me.BtnGuardarPacRec = New System.Windows.Forms.Button()
        Me.TBNombrePacRec = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBFechaNacRec = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBSenParRec = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBColorPacRec = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBRazaPacRec = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPacRec = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBEspeciePacRec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBIdPacRec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientesRec.SuspendLayout()
        Me.TPPacienteRec.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPacRec.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PnlTitle.TabIndex = 1
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
        'TCPacientesRec
        '
        Me.TCPacientesRec.Controls.Add(Me.TPPacienteRec)
        Me.TCPacientesRec.Controls.Add(Me.TPDetPacRec)
        Me.TCPacientesRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientesRec.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientesRec.Name = "TCPacientesRec"
        Me.TCPacientesRec.SelectedIndex = 0
        Me.TCPacientesRec.Size = New System.Drawing.Size(794, 431)
        Me.TCPacientesRec.TabIndex = 3
        '
        'TPPacienteRec
        '
        Me.TPPacienteRec.Controls.Add(Me.BtnEliminarRegPacRec)
        Me.TPPacienteRec.Controls.Add(Me.BtnEditarPacRec)
        Me.TPPacienteRec.Controls.Add(Me.BtnNuevoPacRec)
        Me.TPPacienteRec.Controls.Add(Me.DataGridView1)
        Me.TPPacienteRec.Controls.Add(Me.BtnBuscarPacRec)
        Me.TPPacienteRec.Controls.Add(Me.TBBuscPacRec)
        Me.TPPacienteRec.Controls.Add(Me.Label2)
        Me.TPPacienteRec.Location = New System.Drawing.Point(4, 22)
        Me.TPPacienteRec.Name = "TPPacienteRec"
        Me.TPPacienteRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPacienteRec.Size = New System.Drawing.Size(786, 405)
        Me.TPPacienteRec.TabIndex = 0
        Me.TPPacienteRec.Text = "Pacientes"
        Me.TPPacienteRec.UseVisualStyleBackColor = True
        '
        'BtnEliminarRegPacRec
        '
        Me.BtnEliminarRegPacRec.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegPacRec.Location = New System.Drawing.Point(689, 178)
        Me.BtnEliminarRegPacRec.Name = "BtnEliminarRegPacRec"
        Me.BtnEliminarRegPacRec.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegPacRec.TabIndex = 6
        Me.BtnEliminarRegPacRec.Text = "Eliminar"
        Me.BtnEliminarRegPacRec.UseVisualStyleBackColor = True
        '
        'BtnEditarPacRec
        '
        Me.BtnEditarPacRec.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPacRec.Location = New System.Drawing.Point(689, 122)
        Me.BtnEditarPacRec.Name = "BtnEditarPacRec"
        Me.BtnEditarPacRec.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarPacRec.TabIndex = 5
        Me.BtnEditarPacRec.Text = "Editar"
        Me.BtnEditarPacRec.UseVisualStyleBackColor = True
        '
        'BtnNuevoPacRec
        '
        Me.BtnNuevoPacRec.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPacRec.Location = New System.Drawing.Point(689, 67)
        Me.BtnNuevoPacRec.Name = "BtnNuevoPacRec"
        Me.BtnNuevoPacRec.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoPacRec.TabIndex = 4
        Me.BtnNuevoPacRec.Text = "Nuevo"
        Me.BtnNuevoPacRec.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarPacRec
        '
        Me.BtnBuscarPacRec.Image = Global.ProyectoF.My.Resources.Resources.searchVet
        Me.BtnBuscarPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPacRec.Location = New System.Drawing.Point(605, 38)
        Me.BtnBuscarPacRec.Name = "BtnBuscarPacRec"
        Me.BtnBuscarPacRec.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarPacRec.TabIndex = 2
        Me.BtnBuscarPacRec.Text = "Buscar"
        Me.BtnBuscarPacRec.UseVisualStyleBackColor = True
        '
        'TBBuscPacRec
        '
        Me.TBBuscPacRec.Location = New System.Drawing.Point(14, 38)
        Me.TBBuscPacRec.Name = "TBBuscPacRec"
        Me.TBBuscPacRec.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscPacRec.TabIndex = 1
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
        'TPDetPacRec
        '
        Me.TPDetPacRec.Controls.Add(Me.BtnCancelarPacRec)
        Me.TPDetPacRec.Controls.Add(Me.BtnGuardarPacRec)
        Me.TPDetPacRec.Controls.Add(Me.TBNombrePacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label10)
        Me.TPDetPacRec.Controls.Add(Me.TBFechaNacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label9)
        Me.TPDetPacRec.Controls.Add(Me.TBSenParRec)
        Me.TPDetPacRec.Controls.Add(Me.Label8)
        Me.TPDetPacRec.Controls.Add(Me.TBColorPacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label7)
        Me.TPDetPacRec.Controls.Add(Me.TBRazaPacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label6)
        Me.TPDetPacRec.Controls.Add(Me.TBSexoPacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label5)
        Me.TPDetPacRec.Controls.Add(Me.TBEspeciePacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label3)
        Me.TPDetPacRec.Controls.Add(Me.TBIdPacRec)
        Me.TPDetPacRec.Controls.Add(Me.Label4)
        Me.TPDetPacRec.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPacRec.Name = "TPDetPacRec"
        Me.TPDetPacRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPacRec.Size = New System.Drawing.Size(786, 405)
        Me.TPDetPacRec.TabIndex = 1
        Me.TPDetPacRec.Text = "Detalles"
        Me.TPDetPacRec.UseVisualStyleBackColor = True
        '
        'BtnCancelarPacRec
        '
        Me.BtnCancelarPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarPacRec.Location = New System.Drawing.Point(434, 300)
        Me.BtnCancelarPacRec.Name = "BtnCancelarPacRec"
        Me.BtnCancelarPacRec.Size = New System.Drawing.Size(82, 37)
        Me.BtnCancelarPacRec.TabIndex = 18
        Me.BtnCancelarPacRec.Text = "Cancelar"
        Me.BtnCancelarPacRec.UseVisualStyleBackColor = True
        '
        'BtnGuardarPacRec
        '
        Me.BtnGuardarPacRec.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPacRec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPacRec.Location = New System.Drawing.Point(271, 300)
        Me.BtnGuardarPacRec.Name = "BtnGuardarPacRec"
        Me.BtnGuardarPacRec.Size = New System.Drawing.Size(82, 37)
        Me.BtnGuardarPacRec.TabIndex = 17
        Me.BtnGuardarPacRec.Text = "Guardar"
        Me.BtnGuardarPacRec.UseVisualStyleBackColor = True
        '
        'TBNombrePacRec
        '
        Me.TBNombrePacRec.Location = New System.Drawing.Point(579, 132)
        Me.TBNombrePacRec.Name = "TBNombrePacRec"
        Me.TBNombrePacRec.Size = New System.Drawing.Size(166, 20)
        Me.TBNombrePacRec.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(413, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNacRec
        '
        Me.TBFechaNacRec.Location = New System.Drawing.Point(580, 165)
        Me.TBFechaNacRec.Name = "TBFechaNacRec"
        Me.TBFechaNacRec.Size = New System.Drawing.Size(166, 20)
        Me.TBFechaNacRec.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(413, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nombre:"
        '
        'TBSenParRec
        '
        Me.TBSenParRec.Location = New System.Drawing.Point(580, 200)
        Me.TBSenParRec.Multiline = True
        Me.TBSenParRec.Name = "TBSenParRec"
        Me.TBSenParRec.Size = New System.Drawing.Size(166, 65)
        Me.TBSenParRec.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(413, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Color:"
        '
        'TBColorPacRec
        '
        Me.TBColorPacRec.Location = New System.Drawing.Point(580, 96)
        Me.TBColorPacRec.Name = "TBColorPacRec"
        Me.TBColorPacRec.Size = New System.Drawing.Size(166, 20)
        Me.TBColorPacRec.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPacRec
        '
        Me.TBRazaPacRec.Location = New System.Drawing.Point(207, 198)
        Me.TBRazaPacRec.Name = "TBRazaPacRec"
        Me.TBRazaPacRec.Size = New System.Drawing.Size(166, 20)
        Me.TBRazaPacRec.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(413, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPacRec
        '
        Me.TBSexoPacRec.FormattingEnabled = True
        Me.TBSexoPacRec.Location = New System.Drawing.Point(207, 164)
        Me.TBSexoPacRec.Name = "TBSexoPacRec"
        Me.TBSexoPacRec.Size = New System.Drawing.Size(166, 21)
        Me.TBSexoPacRec.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePacRec
        '
        Me.TBEspeciePacRec.Location = New System.Drawing.Point(207, 130)
        Me.TBEspeciePacRec.Name = "TBEspeciePacRec"
        Me.TBEspeciePacRec.Size = New System.Drawing.Size(166, 20)
        Me.TBEspeciePacRec.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especie:"
        '
        'TBIdPacRec
        '
        Me.TBIdPacRec.Location = New System.Drawing.Point(207, 97)
        Me.TBIdPacRec.Name = "TBIdPacRec"
        Me.TBIdPacRec.Size = New System.Drawing.Size(98, 20)
        Me.TBIdPacRec.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID del paciente:"
        '
        'FrmPacientesR
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 469)
        Me.Controls.Add(Me.TCPacientesRec)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPacientesR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPacientes"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientesRec.ResumeLayout(False)
        Me.TPPacienteRec.ResumeLayout(False)
        Me.TPPacienteRec.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacRec.ResumeLayout(False)
        Me.TPDetPacRec.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientesRec As TabControl
    Friend WithEvents TPPacienteRec As TabPage
    Friend WithEvents TPDetPacRec As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscarPacRec As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEliminarRegPacRec As Button
    Friend WithEvents BtnEditarPacRec As Button
    Friend WithEvents BtnNuevoPacRec As Button
    Friend WithEvents TBBuscPacRec As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBIdPacRec As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEspeciePacRec As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBRazaPacRec As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPacRec As ComboBox
    Friend WithEvents TBColorPacRec As TextBox
    Friend WithEvents TBSenParRec As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNombrePacRec As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBFechaNacRec As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnCancelarPacRec As Button
    Friend WithEvents BtnGuardarPacRec As Button
End Class
