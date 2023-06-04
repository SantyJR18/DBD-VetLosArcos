<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPacientesR
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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientesRec = New System.Windows.Forms.TabControl()
        Me.TPPacienteRec = New System.Windows.Forms.TabPage()
        Me.BtnEliminarPac = New System.Windows.Forms.Button()
        Me.BtnEditarPac = New System.Windows.Forms.Button()
        Me.BtnNuevoPac = New System.Windows.Forms.Button()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetPacRec = New System.Windows.Forms.TabPage()
        Me.TBIdPac = New System.Windows.Forms.TextBox()
        Me.CmbRazaPac = New System.Windows.Forms.ComboBox()
        Me.CmbEspeciePac = New System.Windows.Forms.ComboBox()
        Me.DtPac = New System.Windows.Forms.DateTimePicker()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TBNombrePac = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBSenPar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBColorPac = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBSexoPac = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientesRec.SuspendLayout()
        Me.TPPacienteRec.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PnlTitle.Size = New System.Drawing.Size(843, 38)
        Me.PnlTitle.TabIndex = 1
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
        Me.BtnCerrar.Location = New System.Drawing.Point(799, 6)
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
        Me.TCPacientesRec.Size = New System.Drawing.Size(843, 533)
        Me.TCPacientesRec.TabIndex = 3
        '
        'TPPacienteRec
        '
        Me.TPPacienteRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPPacienteRec.Controls.Add(Me.BtnEliminarPac)
        Me.TPPacienteRec.Controls.Add(Me.BtnEditarPac)
        Me.TPPacienteRec.Controls.Add(Me.BtnNuevoPac)
        Me.TPPacienteRec.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.TPPacienteRec.Controls.Add(Me.txtBusqueda)
        Me.TPPacienteRec.Controls.Add(Me.Label2)
        Me.TPPacienteRec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TPPacienteRec.Location = New System.Drawing.Point(4, 22)
        Me.TPPacienteRec.Name = "TPPacienteRec"
        Me.TPPacienteRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPPacienteRec.Size = New System.Drawing.Size(835, 507)
        Me.TPPacienteRec.TabIndex = 0
        Me.TPPacienteRec.Text = "Pacientes"
        '
        'BtnEliminarPac
        '
        Me.BtnEliminarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminarPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarPac.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarPac.Location = New System.Drawing.Point(701, 223)
        Me.BtnEliminarPac.Name = "BtnEliminarPac"
        Me.BtnEliminarPac.Size = New System.Drawing.Size(111, 36)
        Me.BtnEliminarPac.TabIndex = 12
        Me.BtnEliminarPac.Text = "Eliminar"
        Me.BtnEliminarPac.UseVisualStyleBackColor = True
        '
        'BtnEditarPac
        '
        Me.BtnEditarPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditarPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarPac.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarPac.Location = New System.Drawing.Point(701, 168)
        Me.BtnEditarPac.Name = "BtnEditarPac"
        Me.BtnEditarPac.Size = New System.Drawing.Size(111, 37)
        Me.BtnEditarPac.TabIndex = 11
        Me.BtnEditarPac.Text = "Editar"
        Me.BtnEditarPac.UseVisualStyleBackColor = True
        '
        'BtnNuevoPac
        '
        Me.BtnNuevoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNuevoPac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoPac.Image = Global.ProyectoF.My.Resources.Resources.pet_care
        Me.BtnNuevoPac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoPac.Location = New System.Drawing.Point(701, 113)
        Me.BtnNuevoPac.Name = "BtnNuevoPac"
        Me.BtnNuevoPac.Size = New System.Drawing.Size(111, 37)
        Me.BtnNuevoPac.TabIndex = 10
        Me.BtnNuevoPac.Text = "Nuevo"
        Me.BtnNuevoPac.UseVisualStyleBackColor = True
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(26, 122)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(666, 326)
        Me.dgvRegistrosAlmacenados.TabIndex = 9
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Location = New System.Drawing.Point(26, 92)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(666, 24)
        Me.txtBusqueda.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar paciente:"
        '
        'TPDetPacRec
        '
        Me.TPDetPacRec.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetPacRec.Controls.Add(Me.TBIdPac)
        Me.TPDetPacRec.Controls.Add(Me.CmbRazaPac)
        Me.TPDetPacRec.Controls.Add(Me.CmbEspeciePac)
        Me.TPDetPacRec.Controls.Add(Me.DtPac)
        Me.TPDetPacRec.Controls.Add(Me.BtnGuardar)
        Me.TPDetPacRec.Controls.Add(Me.BtnCancelar)
        Me.TPDetPacRec.Controls.Add(Me.TBNombrePac)
        Me.TPDetPacRec.Controls.Add(Me.Label10)
        Me.TPDetPacRec.Controls.Add(Me.Label9)
        Me.TPDetPacRec.Controls.Add(Me.TBSenPar)
        Me.TPDetPacRec.Controls.Add(Me.Label8)
        Me.TPDetPacRec.Controls.Add(Me.TBColorPac)
        Me.TPDetPacRec.Controls.Add(Me.Label7)
        Me.TPDetPacRec.Controls.Add(Me.Label6)
        Me.TPDetPacRec.Controls.Add(Me.TBSexoPac)
        Me.TPDetPacRec.Controls.Add(Me.Label5)
        Me.TPDetPacRec.Controls.Add(Me.Label3)
        Me.TPDetPacRec.Controls.Add(Me.Label17)
        Me.TPDetPacRec.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPacRec.Name = "TPDetPacRec"
        Me.TPDetPacRec.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetPacRec.Size = New System.Drawing.Size(835, 507)
        Me.TPDetPacRec.TabIndex = 1
        Me.TPDetPacRec.Text = "Detalles"
        '
        'TBIdPac
        '
        Me.TBIdPac.Location = New System.Drawing.Point(192, 129)
        Me.TBIdPac.Name = "TBIdPac"
        Me.TBIdPac.Size = New System.Drawing.Size(98, 20)
        Me.TBIdPac.TabIndex = 59
        '
        'CmbRazaPac
        '
        Me.CmbRazaPac.FormattingEnabled = True
        Me.CmbRazaPac.Location = New System.Drawing.Point(192, 234)
        Me.CmbRazaPac.Name = "CmbRazaPac"
        Me.CmbRazaPac.Size = New System.Drawing.Size(200, 21)
        Me.CmbRazaPac.TabIndex = 58
        '
        'CmbEspeciePac
        '
        Me.CmbEspeciePac.FormattingEnabled = True
        Me.CmbEspeciePac.Location = New System.Drawing.Point(192, 166)
        Me.CmbEspeciePac.Name = "CmbEspeciePac"
        Me.CmbEspeciePac.Size = New System.Drawing.Size(200, 21)
        Me.CmbEspeciePac.TabIndex = 57
        '
        'DtPac
        '
        Me.DtPac.Location = New System.Drawing.Point(610, 198)
        Me.DtPac.Name = "DtPac"
        Me.DtPac.Size = New System.Drawing.Size(200, 20)
        Me.DtPac.TabIndex = 56
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(296, 343)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 54
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(439, 343)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancelar.TabIndex = 55
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TBNombrePac
        '
        Me.TBNombrePac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBNombrePac.Location = New System.Drawing.Point(609, 163)
        Me.TBNombrePac.Name = "TBNombrePac"
        Me.TBNombrePac.Size = New System.Drawing.Size(201, 20)
        Me.TBNombrePac.TabIndex = 50
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(443, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 20)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Fecha Nacimiento:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(443, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Nombre:"
        '
        'TBSenPar
        '
        Me.TBSenPar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSenPar.Location = New System.Drawing.Point(610, 231)
        Me.TBSenPar.Multiline = True
        Me.TBSenPar.Name = "TBSenPar"
        Me.TBSenPar.Size = New System.Drawing.Size(200, 65)
        Me.TBSenPar.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(443, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Color:"
        '
        'TBColorPac
        '
        Me.TBColorPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBColorPac.Location = New System.Drawing.Point(610, 127)
        Me.TBColorPac.Name = "TBColorPac"
        Me.TBColorPac.Size = New System.Drawing.Size(200, 20)
        Me.TBColorPac.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 233)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Raza:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(443, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 20)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Señas particulares:"
        '
        'TBSexoPac
        '
        Me.TBSexoPac.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBSexoPac.FormattingEnabled = True
        Me.TBSexoPac.Location = New System.Drawing.Point(192, 197)
        Me.TBSexoPac.Name = "TBSexoPac"
        Me.TBSexoPac.Size = New System.Drawing.Size(200, 21)
        Me.TBSexoPac.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Sexo:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Especie:"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 129)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 20)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "ID del paciente:"
        '
        'FrmPacientesR
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 571)
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
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPacRec.ResumeLayout(False)
        Me.TPDetPacRec.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientesRec As TabControl
    Friend WithEvents TPPacienteRec As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarPac As Button
    Friend WithEvents BtnEditarPac As Button
    Friend WithEvents BtnNuevoPac As Button
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetPacRec As TabPage
    Friend WithEvents TBIdPac As TextBox
    Friend WithEvents CmbRazaPac As ComboBox
    Friend WithEvents CmbEspeciePac As ComboBox
    Friend WithEvents DtPac As DateTimePicker
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents TBNombrePac As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TBSenPar As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBColorPac As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBSexoPac As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
End Class
