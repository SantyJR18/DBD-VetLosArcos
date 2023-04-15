<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMedico
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
        Me.BtnEliminarRegPac = New System.Windows.Forms.Button()
        Me.BtnEditarPac = New System.Windows.Forms.Button()
        Me.BtnNuevoPac = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarPac = New System.Windows.Forms.Button()
        Me.TBBuscPac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPPac = New System.Windows.Forms.TabPage()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientes.SuspendLayout()
        Me.TPPac.SuspendLayout()
        Me.TPDetPac.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(579, 369)
        Me.BtnEliminarPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(109, 46)
        Me.BtnEliminarPac.TabIndex = 18
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnGuardarPac
        '
        Me.BtnGuardarPac.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarPac.Location = New System.Drawing.Point(361, 369)
        Me.BtnGuardarPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardarPac.Name = "BtnGuardarPac"
        Me.BtnGuardarPac.Size = New System.Drawing.Size(109, 46)
        Me.BtnGuardarPac.TabIndex = 17
        Me.BtnGuardarPac.Text = "Guardar"
        Me.BtnGuardarPac.UseVisualStyleBackColor = True
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Location = New System.Drawing.Point(772, 162)
        Me.TBNombrePac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(220, 22)
        Me.TBNombrePac.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(551, 202)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'TBFechaNac
        '
        Me.TBFechaNac.Location = New System.Drawing.Point(773, 203)
        Me.TBFechaNac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBFechaNac.Name = "TBFechaNac"
        Me.TBFechaNac.Size = New System.Drawing.Size(220, 22)
        Me.TBFechaNac.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(551, 161)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Nombre:"
        '
        'TBSenPar
        '
        Me.TBSenPar.Location = New System.Drawing.Point(773, 246)
        Me.TBSenPar.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(220, 79)
        Me.TBSenPar.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(551, 119)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Color:"
        '
        'TBColorPac
        '
        Me.TBColorPac.Location = New System.Drawing.Point(773, 118)
        Me.TBColorPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(220, 22)
        Me.TBColorPac.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(53, 246)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Raza:"
        '
        'TBRazaPac
        '
        Me.TBRazaPac.Location = New System.Drawing.Point(276, 244)
        Me.TBRazaPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBRazaPac.Name = "TBRazaPac"
        Me.TBRazaPac.Size = New System.Drawing.Size(220, 22)
        Me.TBRazaPac.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(551, 246)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(276, 202)
        Me.TBSexoPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(220, 24)
        Me.TBSexoPac.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 203)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Sexo:"
        '
        'TBEspeciePac
        '
        Me.TBEspeciePac.Location = New System.Drawing.Point(276, 160)
        Me.TBEspeciePac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBEspeciePac.Name = "TBEspeciePac"
        Me.TBEspeciePac.Size = New System.Drawing.Size(220, 22)
        Me.TBEspeciePac.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especie:"
        '
        'TBIdPac
        '
        Me.TBIdPac.Location = New System.Drawing.Point(276, 119)
        Me.TBIdPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(129, 22)
        Me.TBIdPac.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 121)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "ID del paciente:"
        '
        'BtnEliminarRegPac
        '
        Me.BtnEliminarRegPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegPac.Location = New System.Drawing.Point(919, 219)
        Me.BtnEliminarRegPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEliminarRegPac.Name = "BtnEliminarRegPac"
        Me.BtnEliminarRegPac.Size = New System.Drawing.Size(109, 44)
        Me.BtnEliminarRegPac.TabIndex = 6
        Me.BtnEliminarRegPac.Text = "Eliminar"
        Me.BtnEliminarRegPac.UseVisualStyleBackColor = True
        '
        'BtnEditarPac
        '
        Me.BtnEditarPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPac.Location = New System.Drawing.Point(919, 150)
        Me.BtnEditarPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnEditarPac.Name = "BtnEditarPac"
        Me.BtnEditarPac.Size = New System.Drawing.Size(109, 46)
        Me.BtnEditarPac.TabIndex = 5
        Me.BtnEditarPac.Text = "Editar"
        Me.BtnEditarPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoPac
        '
        Me.BtnNuevoPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPac.Location = New System.Drawing.Point(919, 82)
        Me.BtnNuevoPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnNuevoPac.Name = "BtnNuevoPac"
        Me.BtnNuevoPac.Size = New System.Drawing.Size(109, 46)
        Me.BtnNuevoPac.TabIndex = 4
        Me.BtnNuevoPac.Text = "Nuevo"
        Me.BtnNuevoPac.UseVisualStyleBackColor = True
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
        'BtnBuscarPac
        '
        Me.BtnBuscarPac.Image = Global.ProyectoF.My.Resources.Resources.searchVet
        Me.BtnBuscarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarPac.Location = New System.Drawing.Point(807, 47)
        Me.BtnBuscarPac.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnBuscarPac.Name = "BtnBuscarPac"
        Me.BtnBuscarPac.Size = New System.Drawing.Size(100, 28)
        Me.BtnBuscarPac.TabIndex = 2
        Me.BtnBuscarPac.Text = "Buscar"
        Me.BtnBuscarPac.UseVisualStyleBackColor = True
        '
        'TBBuscPac
        '
        Me.TBBuscPac.Location = New System.Drawing.Point(19, 47)
        Me.TBBuscPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscPac.Name = "TBBuscPac"
        Me.TBBuscPac.Size = New System.Drawing.Size(753, 22)
        Me.TBBuscPac.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pacientes"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1023, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPPac)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Location = New System.Drawing.Point(0, 66)
        Me.TCPacientes.Margin = New System.Windows.Forms.Padding(4)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(1082, 637)
        Me.TCPacientes.TabIndex = 5
        '
        'TPPac
        '
        Me.TPPac.Controls.Add(Me.BtnEliminarRegPac)
        Me.TPPac.Controls.Add(Me.BtnEditarPac)
        Me.TPPac.Controls.Add(Me.BtnNuevoPac)
        Me.TPPac.Controls.Add(Me.DataGridView1)
        Me.TPPac.Controls.Add(Me.BtnBuscarPac)
        Me.TPPac.Controls.Add(Me.TBBuscPac)
        Me.TPPac.Controls.Add(Me.Label2)
        Me.TPPac.Location = New System.Drawing.Point(4, 25)
        Me.TPPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPac.Name = "TPPac"
        Me.TPPac.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPac.Size = New System.Drawing.Size(1074, 608)
        Me.TPPac.TabIndex = 0
        Me.TPPac.Text = "Pacientes"
        Me.TPPac.UseVisualStyleBackColor = True
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
        Me.TPDetPac.Location = New System.Drawing.Point(4, 25)
        Me.TPDetPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(4)
        Me.TPDetPac.Size = New System.Drawing.Size(1074, 608)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        Me.TPDetPac.UseVisualStyleBackColor = True
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.White
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1082, 66)
        Me.PnlTitle.TabIndex = 4
        '
        'FrmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 703)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMedico"
        Me.Text = "FrmMedico"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientes.ResumeLayout(False)
        Me.TPPac.ResumeLayout(False)
        Me.TPPac.PerformLayout()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnGuardarPac As Button
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
    Friend WithEvents BtnEliminarRegPac As Button
    Friend WithEvents BtnEditarPac As Button
    Friend WithEvents BtnNuevoPac As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBuscarPac As Button
    Friend WithEvents TBBuscPac As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPPac As TabPage
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents PnlTitle As Panel
End Class
