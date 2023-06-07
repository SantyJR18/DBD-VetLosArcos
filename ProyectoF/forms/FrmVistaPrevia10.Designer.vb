<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia10
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
        Me.ReportViewer10 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer10
        '
        Me.ReportViewer10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer10.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer10.Name = "ReportViewer10"
        Me.ReportViewer10.ServerReport.BearerToken = Nothing
        Me.ReportViewer10.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer10.TabIndex = 0
        '
        'FrmVistaPrevia10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer10)
        Me.Name = "FrmVistaPrevia10"
        Me.Text = "FrmVistaPrevia10"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer10 As Microsoft.Reporting.WinForms.ReportViewer
End Class
