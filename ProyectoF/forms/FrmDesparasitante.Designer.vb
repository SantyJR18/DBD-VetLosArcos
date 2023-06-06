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
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCPacientes = New System.Windows.Forms.TabControl()
        Me.TPPaciente = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GbRegistros = New System.Windows.Forms.GroupBox()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.TPDetPac = New System.Windows.Forms.TabPage()
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
        Me.PnlTitle.Size = New System.Drawing.Size(843, 38)
        Me.PnlTitle.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desparasitante"
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
        'TCPacientes
        '
        Me.TCPacientes.Controls.Add(Me.TPPaciente)
        Me.TCPacientes.Controls.Add(Me.TPDetPac)
        Me.TCPacientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCPacientes.Location = New System.Drawing.Point(0, 38)
        Me.TCPacientes.Name = "TCPacientes"
        Me.TCPacientes.SelectedIndex = 0
        Me.TCPacientes.Size = New System.Drawing.Size(843, 533)
        Me.TCPacientes.TabIndex = 6
        '
        'TPPaciente
        '
        Me.TPPaciente.BackColor = System.Drawing.Color.SeaShell
        Me.TPPaciente.Controls.Add(Me.Label2)
        Me.TPPaciente.Controls.Add(Me.GbRegistros)
        Me.TPPaciente.Controls.Add(Me.txtBusqueda)
        Me.TPPaciente.Location = New System.Drawing.Point(4, 22)
        Me.TPPaciente.Name = "TPPaciente"
        Me.TPPaciente.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPPaciente.Size = New System.Drawing.Size(835, 507)
        Me.TPPaciente.TabIndex = 0
        Me.TPPaciente.Text = "Pacientes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(269, 13)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(325, 26)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Registros de Desparasitantes"
        '
        'GbRegistros
        '
        Me.GbRegistros.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.GbRegistros.Location = New System.Drawing.Point(27, 121)
        Me.GbRegistros.Name = "GbRegistros"
        Me.GbRegistros.Size = New System.Drawing.Size(794, 366)
        Me.GbRegistros.TabIndex = 8
        Me.GbRegistros.TabStop = False
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(3, 16)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(788, 347)
        Me.dgvRegistrosAlmacenados.TabIndex = 6
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.DimGray
        Me.txtBusqueda.Location = New System.Drawing.Point(27, 72)
        Me.txtBusqueda.Multiline = True
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(792, 28)
        Me.txtBusqueda.TabIndex = 7
        Me.txtBusqueda.Text = "Buscar Desparasitante por Nombre"
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TPDetPac
        '
        Me.TPDetPac.BackColor = System.Drawing.Color.SeaShell
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
        Me.TPDetPac.Location = New System.Drawing.Point(4, 22)
        Me.TPDetPac.Name = "TPDetPac"
        Me.TPDetPac.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TPDetPac.Size = New System.Drawing.Size(835, 507)
        Me.TPDetPac.TabIndex = 1
        Me.TPDetPac.Text = "Detalles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(275, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 26)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Detalles Desparasitantes "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(381, 163)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'Button3
        '
        Me.Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(259, 375)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 37)
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
        Me.Button2.Location = New System.Drawing.Point(427, 375)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 37)
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
        Me.Button1.Location = New System.Drawing.Point(587, 375)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 37)
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
        Me.BtnGuardar.Location = New System.Drawing.Point(95, 375)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(141, 37)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DtFechaApli
        '
        Me.DtFechaApli.Location = New System.Drawing.Point(381, 260)
        Me.DtFechaApli.Name = "DtFechaApli"
        Me.DtFechaApli.Size = New System.Drawing.Size(200, 20)
        Me.DtFechaApli.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(221, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(154, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Fecha de aplicación:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CmbDesparacitante
        '
        Me.CmbDesparacitante.FormattingEnabled = True
        Me.CmbDesparacitante.Location = New System.Drawing.Point(381, 211)
        Me.CmbDesparacitante.Name = "CmbDesparacitante"
        Me.CmbDesparacitante.Size = New System.Drawing.Size(200, 21)
        Me.CmbDesparacitante.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 20)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Desparasitante:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(221, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID Expediente:"
        '
        'FrmDesparasitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 571)
        Me.Controls.Add(Me.TCPacientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
        Me.TPDetPac.ResumeLayout(False)
        Me.TPDetPac.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents TCPacientes As TabControl
    Friend WithEvents TPPaciente As TabPage
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents GbRegistros As GroupBox
    Friend WithEvents Label2 As Label
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
End Class
