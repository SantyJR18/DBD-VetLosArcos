<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia5
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
        Me.ReportViewer5 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer5
        '
        Me.ReportViewer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer5.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer5.Name = "ReportViewer5"
        Me.ReportViewer5.ServerReport.BearerToken = Nothing
        Me.ReportViewer5.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer5.TabIndex = 0
        '
        'FrmVistaPrevia5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer5)
        Me.Name = "FrmVistaPrevia5"
        Me.Text = "FrmVistaPrevia5"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer5 As Microsoft.Reporting.WinForms.ReportViewer
End Class
