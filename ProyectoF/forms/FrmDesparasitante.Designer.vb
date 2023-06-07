<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDesparasitante
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesparasitante))
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DtFechaApli = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmbDesparacitante = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TCPacientes.SuspendLayout()
        Me.TPPaciente.SuspendLayout()
        Me.GbRegistros.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetPac.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PnlTitle.Size = New System.Drawing.Size(1124, 47)
        Me.PnlTitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(4, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desparasitante"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(1065, 7)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPPaciente)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TCPacientes.Location = New System.Drawing.Point(0, 47)
        Me.TCPacientes.Margin = New System.Windows.Forms.Padding(4)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(1124, 656)
        Me.TCPacientes.TabIndex = 6
        '
        'TPPaciente
        '
        Me.TPPaciente.BackColor = System.Drawing.Color.SeaShell
        Me.TPPaciente.Controls.Add(Me.GbRegistros)
        Me.TPPaciente.Controls.Add(Me.PictureBox3)
        Me.TPPaciente.Controls.Add(Me.PictureBox2)
        Me.TPPaciente.Controls.Add(Me.Label17)
        Me.TPPaciente.Controls.Add(Me.txtBusqueda)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 25)
        Me.TPPaciente.Margin = New System.Windows.Forms.Padding(4)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(4)
        Me.TPPaciente.Size = New System.Drawing.Size(1116, 627)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Pacientes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(33, 158)
        Me.GbRegistros.Margin = New System.Windows.Forms.Padding(4)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Padding = New System.Windows.Forms.Padding(4)
        Me.GbRegistros.Size = New System.Drawing.Size(1047, 450)
        Me.GbRegistros.TabIndex = 3
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvRegistrosAlmacenados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistrosAlmacenados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(4, 19)
        Me.dgvRegistrosAlmacenados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(1039, 427)
        Me.dgvRegistrosAlmacenados.TabIndex = 4
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox3.Location = New System.Drawing.Point(297, 16)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox2.Location = New System.Drawing.Point(754, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label17.Location = New System.Drawing.Point(366, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(385, 32)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Registro de Desparasitante"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(33, 103)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(1045, 34)
        Me.txtBusqueda.TabIndex = 2
        Me.txtBusqueda.Text = "Buscar Registro de Desparasitantes por ID CLIENTE"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetPac
        '
        Me.TPDetPac.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetPac.Controls.Add(Me.PictureBox1)
        Me.TPDetPac.Controls.Add(Me.PictureBox4)
        Me.TPDetPac.Controls.Add(Me.Label3)
        Me.TPDetPac.Controls.Add(Me.ComboBox1)
        Me.TPDetPac.Controls.Add(Me.Button3)
        Me.TPDetPac.Controls.Add(Me.Button2)
        Me.TPDetPac.Controls.Add(Me.Button1)
        Me.TPDetPac.Controls.Add(Me.BtnGuardar)
        Me.TPDetPac.Controls.Add(Me.DtFechaApli)
        Me.TPDetPac.Controls.Add(Me.Label12)
        Me.TPDetPac.Controls.Add(Me.CmbDesparacitante)
        Me.TPDetPac.Controls.Add(Me.Label11)
        Me.TPDetPac.Controls.Add(Me.Label9)
        Me.TPDetPac.Location = New System.Drawing.Point(4, 25)
        Me.TPDetPac.Margin = New System.Windows.Forms.Padding(4)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(4)
        Me.TPDetPac.Size = New System.Drawing.Size(1116, 627)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox1.Location = New System.Drawing.Point(297, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.ProyectoF.My.Resources.Resources.deworming
        Me.PictureBox4.Location = New System.Drawing.Point(752, 59)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(64, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(367, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 32)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Detalles Desparasitantes "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(508, 201)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(265, 24)
        Me.ComboBox1.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(345, 462)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(188, 46)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Guardar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(569, 462)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 46)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Guardar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(783, 462)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(127, 462)
        Me.BtnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(188, 46)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DtFechaApli
        '
        Me.DtFechaApli.Location = New System.Drawing.Point(508, 320)
        Me.DtFechaApli.Margin = New System.Windows.Forms.Padding(4)
        Me.DtFechaApli.Name = "DtFechaApli"
        Me.DtFechaApli.Size = New System.Drawing.Size(265, 22)
        Me.DtFechaApli.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(295, 320)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(192, 25)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fecha de aplicación:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbDesparacitante
        '
        Me.CmbDesparacitante.FormattingEnabled = True
        Me.CmbDesparacitante.Location = New System.Drawing.Point(508, 260)
        Me.CmbDesparacitante.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbDesparacitante.Name = "CmbDesparacitante"
        Me.CmbDesparacitante.Size = New System.Drawing.Size(265, 24)
        Me.CmbDesparacitante.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(295, 261)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 25)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Desparasitante:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(295, 202)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 25)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID Expediente:"
        '
        'FrmDesparasitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 703)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDesparasitante"
        Me.Text = "FrmVacunas"
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TCPacientes.ResumeLayout(False)
        Me.TPPaciente.ResumeLayout(False)
        Me.TPPaciente.PerformLayout()
        Me.GbRegistros.ResumeLayout(False)
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents TPDetPac As TabPage
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DtFechaApli As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents CmbDesparacitante As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
