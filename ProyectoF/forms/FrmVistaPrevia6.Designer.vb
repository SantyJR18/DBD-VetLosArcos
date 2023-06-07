<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia6
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
        Me.ReportViewer6 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer6
        '
        Me.ReportViewer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer6.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer6.Name = "ReportViewer6"
        Me.ReportViewer6.ServerReport.BearerToken = Nothing
        Me.ReportViewer6.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer6.TabIndex = 0
        '
        'FrmVistaPrevia6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer6)
        Me.Name = "FrmVistaPrevia6"
        Me.Text = "FrmVistaPrevia6"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer6 As Microsoft.Reporting.WinForms.ReportViewer
End Class
