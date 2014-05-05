<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBSC
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
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnTrails = New System.Windows.Forms.Button()
        Me.btnModels = New System.Windows.Forms.Button()
        Me.btnHats = New System.Windows.Forms.Button()
        Me.btnTags = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.InitialDirectory = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.btnTags)
        Me.GroupBox1.Controls.Add(Me.btnHats)
        Me.GroupBox1.Controls.Add(Me.btnModels)
        Me.GroupBox1.Controls.Add(Me.btnTrails)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 66)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Script Creation Options"
        '
        'btnTrails
        '
        Me.btnTrails.BackColor = System.Drawing.Color.Firebrick
        Me.btnTrails.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTrails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrails.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrails.ForeColor = System.Drawing.Color.White
        Me.btnTrails.Location = New System.Drawing.Point(6, 19)
        Me.btnTrails.Name = "btnTrails"
        Me.btnTrails.Size = New System.Drawing.Size(122, 33)
        Me.btnTrails.TabIndex = 24
        Me.btnTrails.Text = "Trails"
        Me.btnTrails.UseVisualStyleBackColor = False
        '
        'btnModels
        '
        Me.btnModels.BackColor = System.Drawing.Color.Firebrick
        Me.btnModels.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModels.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModels.ForeColor = System.Drawing.Color.White
        Me.btnModels.Location = New System.Drawing.Point(134, 19)
        Me.btnModels.Name = "btnModels"
        Me.btnModels.Size = New System.Drawing.Size(122, 33)
        Me.btnModels.TabIndex = 25
        Me.btnModels.Text = "Models"
        Me.btnModels.UseVisualStyleBackColor = False
        '
        'btnHats
        '
        Me.btnHats.BackColor = System.Drawing.Color.Firebrick
        Me.btnHats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHats.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHats.ForeColor = System.Drawing.Color.White
        Me.btnHats.Location = New System.Drawing.Point(262, 19)
        Me.btnHats.Name = "btnHats"
        Me.btnHats.Size = New System.Drawing.Size(122, 33)
        Me.btnHats.TabIndex = 26
        Me.btnHats.Text = "Hats"
        Me.btnHats.UseVisualStyleBackColor = False
        '
        'btnTags
        '
        Me.btnTags.BackColor = System.Drawing.Color.Firebrick
        Me.btnTags.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTags.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTags.ForeColor = System.Drawing.Color.White
        Me.btnTags.Location = New System.Drawing.Point(390, 19)
        Me.btnTags.Name = "btnTags"
        Me.btnTags.Size = New System.Drawing.Size(122, 33)
        Me.btnTags.TabIndex = 27
        Me.btnTags.Text = "Tags"
        Me.btnTags.UseVisualStyleBackColor = False
        '
        'frmBSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(548, 92)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBSC"
        Me.Text = "Basic Script Creation - Bind Manager - vDev - By: Agentsix1 - http://lifepunch.ne" & _
    "t"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTags As System.Windows.Forms.Button
    Friend WithEvents btnHats As System.Windows.Forms.Button
    Friend WithEvents btnModels As System.Windows.Forms.Button
    Friend WithEvents btnTrails As System.Windows.Forms.Button
End Class
