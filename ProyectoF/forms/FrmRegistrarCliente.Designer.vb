<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistrarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistrarCliente))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtBxCedulaClient = New System.Windows.Forms.TextBox()
        Me.TxtBxNombreClient = New System.Windows.Forms.TextBox()
        Me.TxtBxApeClient = New System.Windows.Forms.TextBox()
        Me.TxtBxTelClient = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtBxDirClient = New System.Windows.Forms.TextBox()
        Me.TxtBxEmailClient = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlTitle = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTitle.SuspendLayout()
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registro de Clientes"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cédula:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Nombres:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(112, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Apellidos:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 395)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Dirección:"
        '
        'TxtBxCedulaClient
        '
        Me.TxtBxCedulaClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxCedulaClient.Location = New System.Drawing.Point(240, 237)
        Me.TxtBxCedulaClient.Name = "TxtBxCedulaClient"
        Me.TxtBxCedulaClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxCedulaClient.TabIndex = 2
        '
        'TxtBxNombreClient
        '
        Me.TxtBxNombreClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxNombreClient.Location = New System.Drawing.Point(240, 278)
        Me.TxtBxNombreClient.Name = "TxtBxNombreClient"
        Me.TxtBxNombreClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxNombreClient.TabIndex = 3
        '
        'TxtBxApeClient
        '
        Me.TxtBxApeClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxApeClient.Location = New System.Drawing.Point(240, 316)
        Me.TxtBxApeClient.Name = "TxtBxApeClient"
        Me.TxtBxApeClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxApeClient.TabIndex = 4
        '
        'TxtBxTelClient
        '
        Me.TxtBxTelClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxTelClient.Location = New System.Drawing.Point(240, 358)
        Me.TxtBxTelClient.Name = "TxtBxTelClient"
        Me.TxtBxTelClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxTelClient.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 353)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Número de Tel:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("High Tower Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(143, 440)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Email:"
        '
        'TxtBxDirClient
        '
        Me.TxtBxDirClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxDirClient.Location = New System.Drawing.Point(240, 400)
        Me.TxtBxDirClient.Name = "TxtBxDirClient"
        Me.TxtBxDirClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxDirClient.TabIndex = 6
        '
        'TxtBxEmailClient
        '
        Me.TxtBxEmailClient.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtBxEmailClient.Location = New System.Drawing.Point(240, 445)
        Me.TxtBxEmailClient.Name = "TxtBxEmailClient"
        Me.TxtBxEmailClient.Size = New System.Drawing.Size(306, 20)
        Me.TxtBxEmailClient.TabIndex = 7
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnCancel.Image = Global.ProyectoF.My.Resources.Resources.close
        Me.BtnCancel.Location = New System.Drawing.Point(323, 494)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(112, 39)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnGuardar.Image = Global.ProyectoF.My.Resources.Resources.customer
        Me.BtnGuardar.Location = New System.Drawing.Point(172, 494)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(112, 39)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(240, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PnlTitle
        '
        Me.PnlTitle.BackColor = System.Drawing.Color.DodgerBlue
        Me.PnlTitle.Controls.Add(Me.PictureBox2)
        Me.PnlTitle.Controls.Add(Me.BtnRestaurar)
        Me.PnlTitle.Controls.Add(Me.BtnMaximizar)
        Me.PnlTitle.Controls.Add(Me.BtnMinimizar)
        Me.PnlTitle.Controls.Add(Me.BtnCerrar)
        Me.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTitle.Location = New System.Drawing.Point(0, 0)
        Me.PnlTitle.Name = "PnlTitle"
        Me.PnlTitle.Size = New System.Drawing.Size(606, 38)
        Me.PnlTitle.TabIndex = 16
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.Image = Global.ProyectoF.My.Resources.Resources.miniIcon
        Me.BtnRestaurar.Location = New System.Drawing.Point(520, 6)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRestaurar.TabIndex = 1
        Me.BtnRestaurar.TabStop = False
        Me.BtnRestaurar.Visible = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Image = Global.ProyectoF.My.Resources.Resources.maxIcon
        Me.BtnMaximizar.Location = New System.Drawing.Point(520, 6)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMaximizar.TabIndex = 3
        Me.BtnMaximizar.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = Global.ProyectoF.My.Resources.Resources.minusIcon
        Me.BtnMinimizar.Location = New System.Drawing.Point(479, 6)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnMinimizar.TabIndex = 2
        Me.BtnMinimizar.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = Global.ProyectoF.My.Resources.Resources.reject
        Me.BtnCerrar.Location = New System.Drawing.Point(562, 6)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ProyectoF.My.Resources.Resources.logoVet
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 38)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'FrmRegistrarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(606, 557)
        Me.Controls.Add(Me.PnlTitle)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.TxtBxEmailClient)
        Me.Controls.Add(Me.TxtBxDirClient)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtBxTelClient)
        Me.Controls.Add(Me.TxtBxApeClient)
        Me.Controls.Add(Me.TxtBxNombreClient)
        Me.Controls.Add(Me.TxtBxCedulaClient)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRegistrarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTitle.ResumeLayout(False)
        CType(Me.BtnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtBxCedulaClient As TextBox
    Friend WithEvents TxtBxNombreClient As TextBox
    Friend WithEvents TxtBxApeClient As TextBox
    Friend WithEvents TxtBxTelClient As TextBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtBxDirClient As TextBox
    Friend WithEvents TxtBxEmailClient As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PnlTitle As Panel
    Friend WithEvents BtnRestaurar As PictureBox
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
