<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Me.TCClientes = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.dgvRegistrosAlmacenados = New System.Windows.Forms.DataGridView()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminarRegClt = New System.Windows.Forms.Button()
        Me.BtnEditarClt = New System.Windows.Forms.Button()
        Me.BtnNuevoClt = New System.Windows.Forms.Button()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
        Me.TBapellidoClt = New System.Windows.Forms.TextBox()
        Me.TBtelClt = New System.Windows.Forms.TextBox()
        Me.TBdireccionClt = New System.Windows.Forms.TextBox()
        Me.TBcorreoClt = New System.Windows.Forms.TextBox()
        Me.TBnombreClt = New System.Windows.Forms.TextBox()
        Me.TBcedulaClt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCClientes.SuspendLayout()
        Me.TPClt.SuspendLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetClt.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCClientes
        '
        Me.TCClientes.Controls.Add(Me.TPClt)
        Me.TCClientes.Controls.Add(Me.TPDetClt)
        Me.TCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCClientes.Location = New System.Drawing.Point(0, 38)
        Me.TCClientes.Name = "TCClientes"
        Me.TCClientes.SelectedIndex = 0
        Me.TCClientes.Size = New System.Drawing.Size(843, 533)
        Me.TCClientes.TabIndex = 5
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.dgvRegistrosAlmacenados)
        Me.TPClt.Controls.Add(Me.txtBusqueda)
        Me.TPClt.Controls.Add(Me.Label2)
        Me.TPClt.Controls.Add(Me.BtnEliminarRegClt)
        Me.TPClt.Controls.Add(Me.BtnEditarClt)
        Me.TPClt.Controls.Add(Me.BtnNuevoClt)
        Me.TPClt.Location = New System.Drawing.Point(4, 22)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(3)
        Me.TPClt.Size = New System.Drawing.Size(835, 507)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Clientes"
        '
        'dgvRegistrosAlmacenados
        '
        Me.dgvRegistrosAlmacenados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvRegistrosAlmacenados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrosAlmacenados.Location = New System.Drawing.Point(27, 122)
        Me.dgvRegistrosAlmacenados.Name = "dgvRegistrosAlmacenados"
        Me.dgvRegistrosAlmacenados.RowHeadersWidth = 51
        Me.dgvRegistrosAlmacenados.Size = New System.Drawing.Size(666, 326)
        Me.dgvRegistrosAlmacenados.TabIndex = 9
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBusqueda.Location = New System.Drawing.Point(27, 92)
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
        Me.Label2.Location = New System.Drawing.Point(24, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar cliente:"
        '
        'BtnEliminarRegClt
        '
        Me.BtnEliminarRegClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminarRegClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarRegClt.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegClt.Location = New System.Drawing.Point(699, 230)
        Me.BtnEliminarRegClt.Name = "BtnEliminarRegClt"
        Me.BtnEliminarRegClt.Size = New System.Drawing.Size(108, 36)
        Me.BtnEliminarRegClt.TabIndex = 6
        Me.BtnEliminarRegClt.Text = "Eliminar"
        Me.BtnEliminarRegClt.UseVisualStyleBackColor = True
        '
        'BtnEditarClt
        '
        Me.BtnEditarClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditarClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditarClt.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarClt.Location = New System.Drawing.Point(699, 176)
        Me.BtnEditarClt.Name = "BtnEditarClt"
        Me.BtnEditarClt.Size = New System.Drawing.Size(111, 37)
        Me.BtnEditarClt.TabIndex = 5
        Me.BtnEditarClt.Text = "Editar"
        Me.BtnEditarClt.UseVisualStyleBackColor = True
        '
        'BtnNuevoClt
        '
        Me.BtnNuevoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNuevoClt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoClt.Image = Global.ProyectoF.My.Resources.Resources.addUser
        Me.BtnNuevoClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoClt.Location = New System.Drawing.Point(699, 122)
        Me.BtnNuevoClt.Name = "BtnNuevoClt"
        Me.BtnNuevoClt.Size = New System.Drawing.Size(111, 37)
        Me.BtnNuevoClt.TabIndex = 4
        Me.BtnNuevoClt.Text = "Nuevo"
        Me.BtnNuevoClt.UseVisualStyleBackColor = True
        '
        'TPDetClt
        '
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetClt.Controls.Add(Me.TBapellidoClt)
        Me.TPDetClt.Controls.Add(Me.TBtelClt)
        Me.TPDetClt.Controls.Add(Me.TBdireccionClt)
        Me.TPDetClt.Controls.Add(Me.TBcorreoClt)
        Me.TPDetClt.Controls.Add(Me.TBnombreClt)
        Me.TPDetClt.Controls.Add(Me.TBcedulaClt)
        Me.TPDetClt.Controls.Add(Me.Label11)
        Me.TPDetClt.Controls.Add(Me.Label12)
        Me.TPDetClt.Controls.Add(Me.Label13)
        Me.TPDetClt.Controls.Add(Me.Label14)
        Me.TPDetClt.Controls.Add(Me.Label15)
        Me.TPDetClt.Controls.Add(Me.Label16)
        Me.TPDetClt.Controls.Add(Me.BtnGuardar)
        Me.TPDetClt.Controls.Add(Me.BtnCancelar)
        Me.TPDetClt.Location = New System.Drawing.Point(4, 22)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetClt.Size = New System.Drawing.Size(835, 507)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Detalles"
        '
        'TBapellidoClt
        '
        Me.TBapellidoClt.Location = New System.Drawing.Point(186, 252)
        Me.TBapellidoClt.Name = "TBapellidoClt"
        Me.TBapellidoClt.Size = New System.Drawing.Size(200, 20)
        Me.TBapellidoClt.TabIndex = 39
        '
        'TBtelClt
        '
        Me.TBtelClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBtelClt.Location = New System.Drawing.Point(615, 218)
        Me.TBtelClt.Name = "TBtelClt"
        Me.TBtelClt.Size = New System.Drawing.Size(200, 20)
        Me.TBtelClt.TabIndex = 36
        '
        'TBdireccionClt
        '
        Me.TBdireccionClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBdireccionClt.Location = New System.Drawing.Point(616, 257)
        Me.TBdireccionClt.Multiline = True
        Me.TBdireccionClt.Name = "TBdireccionClt"
        Me.TBdireccionClt.Size = New System.Drawing.Size(199, 65)
        Me.TBdireccionClt.TabIndex = 38
        '
        'TBcorreoClt
        '
        Me.TBcorreoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcorreoClt.Location = New System.Drawing.Point(615, 185)
        Me.TBcorreoClt.Name = "TBcorreoClt"
        Me.TBcorreoClt.Size = New System.Drawing.Size(200, 20)
        Me.TBcorreoClt.TabIndex = 34
        '
        'TBnombreClt
        '
        Me.TBnombreClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBnombreClt.Location = New System.Drawing.Point(186, 217)
        Me.TBnombreClt.Name = "TBnombreClt"
        Me.TBnombreClt.Size = New System.Drawing.Size(200, 20)
        Me.TBnombreClt.TabIndex = 31
        '
        'TBcedulaClt
        '
        Me.TBcedulaClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcedulaClt.Location = New System.Drawing.Point(186, 184)
        Me.TBcedulaClt.Name = "TBcedulaClt"
        Me.TBcedulaClt.Size = New System.Drawing.Size(200, 20)
        Me.TBcedulaClt.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(449, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 20)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Teléfono:"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(449, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(449, 255)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 20)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Dirección:"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 20)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Apellido:"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 218)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Nombre:"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(19, 185)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Cédula:"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(296, 363)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(439, 363)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
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
        Me.PnlTitle.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clientes"
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
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 571)
        Me.Controls.Add(Me.TCClientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.TCClientes.ResumeLayout(False)
        Me.TPClt.ResumeLayout(False)
        Me.TPClt.PerformLayout()
        CType(Me.dgvRegistrosAlmacenados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TPDetClt.ResumeLayout(False)
        Me.TPDetClt.PerformLayout()
        Me.PnlTitle.ResumeLayout(False)
        Me.PnlTitle.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnEliminarRegClt As Button
    Friend WithEvents BtnEditarClt As Button
    Friend WithEvents BtnNuevoClt As Button
    Friend WithEvents TCClientes As TabControl
    Friend WithEvents TPClt As TabPage
    Friend WithEvents TPDetClt As TabPage
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents dgvRegistrosAlmacenados As DataGridView
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBapellidoClt As TextBox
    Friend WithEvents TBtelClt As TextBox
    Friend WithEvents TBdireccionClt As TextBox
    Friend WithEvents TBcorreoClt As TextBox
    Friend WithEvents TBnombreClt As TextBox
    Friend WithEvents TBcedulaClt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
