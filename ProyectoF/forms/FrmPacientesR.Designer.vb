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
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegPac = New System.Windows.Forms.Button()
        Me.BtnEditarPac = New System.Windows.Forms.Button()
        Me.BtnNuevoPac = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPac = New System.Windows.Forms.Button()
        Me.TBBuscPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
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
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientes.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPac.SuspendLayout()
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
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPPaciente)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(794, 431)
        Me.TCPacientes.TabIndex = 3
        '
        'TPPaciente
        '
        Me.TPPaciente.Controls.Add(Me.BtnEliminarRegPac)
        Me.TPPaciente.Controls.Add(Me.BtnEditarPac)
        Me.TPPaciente.Controls.Add(Me.BtnNuevoPac)
        Me.TPPaciente.Controls.Add(Me.DataGridView1)
        Me.TPPaciente.Controls.Add(Me.BtnBuscarPac)
        Me.TPPaciente.Controls.Add(Me.TBBuscPac)
        Me.TPPaciente.Controls.Add(Me.Label2)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 22)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPaciente.Size = New System.Drawing.Size(786, 405)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Pacientes"
        Me.TPPaciente.UseVisualStyleBackColor = True
        '
        'BtnEliminarRegPac
        '
        Me.BtnEliminarRegPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegPac.Location = New System.Drawing.Point(689, 178)
        Me.BtnEliminarRegPac.Name = "BtnEliminarRegPac"
        Me.BtnEliminarRegPac.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegPac.TabIndex = 6
        Me.BtnEliminarRegPac.Text = "Eliminar"
        Me.BtnEliminarRegPac.UseVisualStyleBackColor = True
        '
        'BtnEditarPac
        '
        Me.BtnEditarPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPac.Location = New System.Drawing.Point(689, 122)
        Me.BtnEditarPac.Name = "BtnEditarPac"
        Me.BtnEditarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarPac.TabIndex = 5
        Me.BtnEditarPac.Text = "Editar"
        Me.BtnEditarPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoPac
        '
        Me.BtnNuevoPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPac.Location = New System.Drawing.Point(689, 67)
        Me.BtnNuevoPac.Name = "BtnNuevoPac"
        Me.BtnNuevoPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoPac.TabIndex = 4
        Me.BtnNuevoPac.Text = "Nuevo"
        Me.BtnNuevoPac.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarPac
        '
        Me.BtnBuscarPac.Image = Global.ProyectoF.My.Resources.Resources.searchVet
        Me.BtnBuscarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPac.Location = New System.Drawing.Point(605, 38)
        Me.BtnBuscarPac.Name = "BtnBuscarPac"
        Me.BtnBuscarPac.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarPac.TabIndex = 2
        Me.BtnBuscarPac.Text = "Buscar"
        Me.BtnBuscarPac.UseVisualStyleBackColor = True
        '
        'TBBuscPac
        '
        Me.TBBuscPac.Location = New System.Drawing.Point(14, 38)
        Me.TBBuscPac.Name = "TBBuscPac"
        Me.TBBuscPac.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscPac.TabIndex = 1
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
        Me.TPDetPac.Controls.Add(Me.BtnEliminarPac)
        Me.TPDetPac.Controls.Add(Me.BtnGuardarPac)
        Me.TPDetPac.Controls.Add(Me.TBNombrePac)
        Me.TPDetPac.Controls.Add(Me.Label10)
        Me.TPDetPac.Controls.Add(Me.TBFechaNac)
        Me.TPDetPac.Controls.Add(Me.Label9)
        Me.TPDetPac.Controls.Add(Me.TBSenPar)
        Me.TPDetPac.Controls.Add(Me.Label8)
        Me.TPDetPac.Controls.Add(Me.TBColorPac)
        Me.TPDetPac.Controls.Add(Me.Label7)
        Me.TPDetPac.Controls.Add(Me.TBRazaPac)
        Me.TPDetPac.Controls.Add(Me.Label6)
        Me.TPDetPac.Controls.Add(Me.TBSexoPac)
        Me.TPDetPac.Controls.Add(Me.Label5)
        Me.TPDetPac.Controls.Add(Me.TBEspeciePac)
        Me.TPDetPac.Controls.Add(Me.Label3)
        Me.TPDetPac.Controls.Add(Me.TBIdPac)
        Me.TPDetPac.Controls.Add(Me.Label4)
        Me.TPDetPac.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPac.Size = New System.Drawing.Size(786, 405)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        Me.TPDetPac.UseVisualStyleBackColor = True
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(434, 300)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnEliminarPac.TabIndex = 18
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnGuardarPac
        '
        Me.BtnGuardarPac.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPac.Location = New System.Drawing.Point(271, 300)
        Me.BtnGuardarPac.Name = "BtnGuardarPac"
        Me.BtnGuardarPac.Size = New System.Drawing.Size(82, 37)
        Me.BtnGuardarPac.TabIndex = 17
        Me.BtnGuardarPac.Text = "Guardar"
        Me.BtnGuardarPac.UseVisualStyleBackColor = True
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Location = New System.Drawing.Point(579, 132)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(166, 20)
        Me.TBNombrePac.TabIndex = 12
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
        'TBFechaNac
        '
        Me.TBFechaNac.Location = New System.Drawing.Point(580, 165)
        Me.TBFechaNac.Name = "TBFechaNac"
        Me.TBFechaNac.Size = New System.Drawing.Size(166, 20)
        Me.TBFechaNac.TabIndex = 14
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
        'TBSenPar
        '
        Me.TBSenPar.Location = New System.Drawing.Point(580, 200)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(166, 65)
        Me.TBSenPar.TabIndex = 16
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
        'TBColorPac
        '
        Me.TBColorPac.Location = New System.Drawing.Point(580, 96)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(166, 20)
        Me.TBColorPac.TabIndex = 10
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
        'TBRazaPac
        '
        Me.TBRazaPac.Location = New System.Drawing.Point(207, 198)
        Me.TBRazaPac.Name = "TBRazaPac"
        Me.TBRazaPac.Size = New System.Drawing.Size(166, 20)
        Me.TBRazaPac.TabIndex = 8
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
        'TBSexoPac
        '
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(207, 164)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(166, 21)
        Me.TBSexoPac.TabIndex = 6
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
        'TBEspeciePac
        '
        Me.TBEspeciePac.Location = New System.Drawing.Point(207, 130)
        Me.TBEspeciePac.Name = "TBEspeciePac"
        Me.TBEspeciePac.Size = New System.Drawing.Size(166, 20)
        Me.TBEspeciePac.TabIndex = 4
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
        'TBIdPac
        '
        Me.TBIdPac.Location = New System.Drawing.Point(207, 97)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(98, 20)
        Me.TBIdPac.TabIndex = 2
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
        'FrmPacientes
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 469)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPacientes"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientes.ResumeLayout(False)
        Me.TPPaciente.ResumeLayout(False)
        Me.TPPaciente.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnBuscarPac As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnEliminarRegPac As Button
    Friend WithEvents BtnEditarPac As Button
    Friend WithEvents BtnNuevoPac As Button
    Friend WithEvents TBBuscPac As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBIdPac As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBEspeciePac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBRazaPac As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents TBColorPac As TextBox
    Friend WithEvents TBSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBNombrePac As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBFechaNac As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnGuardarPac As Button
End Class
