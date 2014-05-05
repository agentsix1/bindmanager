<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeb
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
        Me.wbAll = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wbAll
        '
        Me.wbAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbAll.Location = New System.Drawing.Point(0, 0)
        Me.wbAll.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbAll.Name = "wbAll"
        Me.wbAll.Size = New System.Drawing.Size(952, 609)
        Me.wbAll.TabIndex = 0
        '
        'frmWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 609)
        Me.Controls.Add(Me.wbAll)
        Me.Name = "frmWeb"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents wbAll As System.Windows.Forms.WebBrowser
End Class
