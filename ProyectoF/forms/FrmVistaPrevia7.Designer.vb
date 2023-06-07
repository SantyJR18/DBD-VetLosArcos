<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia7
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
        Me.ReportViewer7 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer7
        '
        Me.ReportViewer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer7.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer7.Name = "ReportViewer7"
        Me.ReportViewer7.ServerReport.BearerToken = Nothing
        Me.ReportViewer7.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer7.TabIndex = 0
        '
        'FrmVistaPrevia7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer7)
        Me.Name = "FrmVistaPrevia7"
        Me.Text = "FrmVistaPrevia7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer7 As Microsoft.Reporting.WinForms.ReportViewer
End Class
