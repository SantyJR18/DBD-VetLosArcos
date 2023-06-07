<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVistaPrevia8
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
        Me.ReportViewer8 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'ReportViewer8
        '
        Me.ReportViewer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer8.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer8.Name = "ReportViewer8"
        Me.ReportViewer8.ServerReport.BearerToken = Nothing
        Me.ReportViewer8.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer8.TabIndex = 0
        '
        'FrmVistaPrevia8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer8)
        Me.Name = "FrmVistaPrevia8"
        Me.Text = "FrmVistaPrevia8"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer8 As Microsoft.Reporting.WinForms.ReportViewer
End Class
