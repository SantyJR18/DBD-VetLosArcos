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
        Me.TBtelClt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBdireccionClt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TCClientes = New System.Windows.Forms.TabControl()
        Me.TPClt = New System.Windows.Forms.TabPage()
        Me.BtnEliminarRegClt = New System.Windows.Forms.Button()
        Me.BtnEditarClt = New System.Windows.Forms.Button()
        Me.BtnNuevoClt = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnBuscarClt = New System.Windows.Forms.Button()
        Me.TBBuscarClt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TPDetClt = New System.Windows.Forms.TabPage()
        Me.TBapellidoClt = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TBcorreoClt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBnombreClt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBcedulaClt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.TCClientes.SuspendLayout()
        Me.TPClt.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TPDetClt.SuspendLayout()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBtelClt
        '
        Me.TBtelClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBtelClt.Location = New System.Drawing.Point(683, 204)
        Me.TBtelClt.Name = "TBtelClt"
        Me.TBtelClt.Size = New System.Drawing.Size(166, 20)
        Me.TBtelClt.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(517, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Teléfono:"
        '
        'TBdireccionClt
        '
        Me.TBdireccionClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBdireccionClt.Location = New System.Drawing.Point(684, 237)
        Me.TBdireccionClt.Multiline = True
        Me.TBdireccionClt.Name = "TBdireccionClt"
        Me.TBdireccionClt.Size = New System.Drawing.Size(166, 65)
        Me.TBdireccionClt.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(517, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Correo:"
        '
        'TCClientes
        '
        Me.TCClientes.Controls.Add(Me.TPClt)
        Me.TCClientes.Controls.Add(Me.TPDetClt)
        Me.TCClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCClientes.Location = New System.Drawing.Point(0, 38)
        Me.TCClientes.Name = "TCClientes"
        Me.TCClientes.SelectedIndex = 0
        Me.TCClientes.Size = New System.Drawing.Size(1003, 496)
        Me.TCClientes.TabIndex = 5
        '
        'TPClt
        '
        Me.TPClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPClt.Controls.Add(Me.BtnEliminarRegClt)
        Me.TPClt.Controls.Add(Me.BtnEditarClt)
        Me.TPClt.Controls.Add(Me.BtnNuevoClt)
        Me.TPClt.Controls.Add(Me.DataGridView1)
        Me.TPClt.Controls.Add(Me.BtnBuscarClt)
        Me.TPClt.Controls.Add(Me.TBBuscarClt)
        Me.TPClt.Controls.Add(Me.Label2)
        Me.TPClt.Location = New System.Drawing.Point(4, 22)
        Me.TPClt.Name = "TPClt"
        Me.TPClt.Padding = New System.Windows.Forms.Padding(3)
        Me.TPClt.Size = New System.Drawing.Size(995, 470)
        Me.TPClt.TabIndex = 0
        Me.TPClt.Text = "Clientes"
        '
        'BtnEliminarRegClt
        '
        Me.BtnEliminarRegClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEliminarRegClt.Image = Global.ProyectoF.My.Resources.Resources.trash
        Me.BtnEliminarRegClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEliminarRegClt.Location = New System.Drawing.Point(795, 210)
        Me.BtnEliminarRegClt.Name = "BtnEliminarRegClt"
        Me.BtnEliminarRegClt.Size = New System.Drawing.Size(82, 36)
        Me.BtnEliminarRegClt.TabIndex = 6
        Me.BtnEliminarRegClt.Text = "Eliminar"
        Me.BtnEliminarRegClt.UseVisualStyleBackColor = True
        '
        'BtnEditarClt
        '
        Me.BtnEditarClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnEditarClt.Image = Global.ProyectoF.My.Resources.Resources.editar
        Me.BtnEditarClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditarClt.Location = New System.Drawing.Point(795, 154)
        Me.BtnEditarClt.Name = "BtnEditarClt"
        Me.BtnEditarClt.Size = New System.Drawing.Size(82, 37)
        Me.BtnEditarClt.TabIndex = 5
        Me.BtnEditarClt.Text = "Editar"
        Me.BtnEditarClt.UseVisualStyleBackColor = True
        '
        'BtnNuevoClt
        '
        Me.BtnNuevoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnNuevoClt.Image = Global.ProyectoF.My.Resources.Resources.addUser
        Me.BtnNuevoClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNuevoClt.Location = New System.Drawing.Point(795, 99)
        Me.BtnNuevoClt.Name = "BtnNuevoClt"
        Me.BtnNuevoClt.Size = New System.Drawing.Size(82, 37)
        Me.BtnNuevoClt.TabIndex = 4
        Me.BtnNuevoClt.Text = "Nuevo"
        Me.BtnNuevoClt.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(120, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(666, 326)
        Me.DataGridView1.TabIndex = 3
        '
        'BtnBuscarClt
        '
        Me.BtnBuscarClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnBuscarClt.Image = Global.ProyectoF.My.Resources.Resources.searchUser
        Me.BtnBuscarClt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarClt.Location = New System.Drawing.Point(711, 70)
        Me.BtnBuscarClt.Name = "BtnBuscarClt"
        Me.BtnBuscarClt.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarClt.TabIndex = 2
        Me.BtnBuscarClt.Text = "Buscar"
        Me.BtnBuscarClt.UseVisualStyleBackColor = True
        '
        'TBBuscarClt
        '
        Me.TBBuscarClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBBuscarClt.Location = New System.Drawing.Point(120, 70)
        Me.TBBuscarClt.Name = "TBBuscarClt"
        Me.TBBuscarClt.Size = New System.Drawing.Size(566, 20)
        Me.TBBuscarClt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(117, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Buscar cliente:"
        '
        'TPDetClt
        '
        Me.TPDetClt.BackColor = System.Drawing.Color.SeaShell
        Me.TPDetClt.Controls.Add(Me.TBapellidoClt)
        Me.TPDetClt.Controls.Add(Me.BtnGuardar)
        Me.TPDetClt.Controls.Add(Me.BtnCancelar)
        Me.TPDetClt.Controls.Add(Me.TBtelClt)
        Me.TPDetClt.Controls.Add(Me.Label9)
        Me.TPDetClt.Controls.Add(Me.TBdireccionClt)
        Me.TPDetClt.Controls.Add(Me.Label8)
        Me.TPDetClt.Controls.Add(Me.TBcorreoClt)
        Me.TPDetClt.Controls.Add(Me.Label6)
        Me.TPDetClt.Controls.Add(Me.Label5)
        Me.TPDetClt.Controls.Add(Me.TBnombreClt)
        Me.TPDetClt.Controls.Add(Me.Label3)
        Me.TPDetClt.Controls.Add(Me.TBcedulaClt)
        Me.TPDetClt.Controls.Add(Me.Label4)
        Me.TPDetClt.Location = New System.Drawing.Point(4, 22)
        Me.TPDetClt.Name = "TPDetClt"
        Me.TPDetClt.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDetClt.Size = New System.Drawing.Size(995, 470)
        Me.TPDetClt.TabIndex = 1
        Me.TPDetClt.Text = "Detalles"
        '
        'TBapellidoClt
        '
        Me.TBapellidoClt.Location = New System.Drawing.Point(311, 237)
        Me.TBapellidoClt.Name = "TBapellidoClt"
        Me.TBapellidoClt.Size = New System.Drawing.Size(166, 20)
        Me.TBapellidoClt.TabIndex = 21
        '
        'BtnGuardar
        '
        Me.BtnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.save
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(376, 320)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(100, 37)
        Me.BtnGuardar.TabIndex = 19
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(519, 320)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 37)
        Me.BtnCancelar.TabIndex = 20
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TBcorreoClt
        '
        Me.TBcorreoClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcorreoClt.Location = New System.Drawing.Point(684, 168)
        Me.TBcorreoClt.Name = "TBcorreoClt"
        Me.TBcorreoClt.Size = New System.Drawing.Size(166, 20)
        Me.TBcorreoClt.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(517, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Apellido:"
        '
        'TBnombreClt
        '
        Me.TBnombreClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBnombreClt.Location = New System.Drawing.Point(311, 202)
        Me.TBnombreClt.Name = "TBnombreClt"
        Me.TBnombreClt.Size = New System.Drawing.Size(166, 20)
        Me.TBnombreClt.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(144, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'TBcedulaClt
        '
        Me.TBcedulaClt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBcedulaClt.Location = New System.Drawing.Point(311, 168)
        Me.TBcedulaClt.Name = "TBcedulaClt"
        Me.TBcedulaClt.Size = New System.Drawing.Size(165, 20)
        Me.TBcedulaClt.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Cédula:"
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.Label1)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(1003, 38)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(959, 6)
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
        Me.ClientSize = New System.Drawing.Size(1003, 534)
        Me.Controls.Add(Me.TCClientes)
        Me.Controls.Add(Me.PnlTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        Me.TCClientes.ResumeLayout(False)
        Me.TPClt.ResumeLayout(False)
        Me.TPClt.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BtnBuscarClt As Button
    Friend WithEvents TBtelClt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TCClientes As TabControl
    Friend WithEvents TPClt As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TBBuscarClt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TPDetClt As TabPage
    Friend WithEvents TBcorreoClt As TextBox
    Friend WithEvents TBdireccionClt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBnombreClt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TBcedulaClt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TBapellidoClt As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
End Class
