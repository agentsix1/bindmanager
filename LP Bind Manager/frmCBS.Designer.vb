<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCBS
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
        Me.lstBinds = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.btnESTF = New System.Windows.Forms.Button()
        Me.btnESTT = New System.Windows.Forms.Button()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnEditSelected = New System.Windows.Forms.Button()
        Me.btnGenerateScript = New System.Windows.Forms.Button()
        Me.cbCommands4 = New System.Windows.Forms.ComboBox()
        Me.cbCommands3 = New System.Windows.Forms.ComboBox()
        Me.cbCommands2 = New System.Windows.Forms.ComboBox()
        Me.btnABTL = New System.Windows.Forms.Button()
        Me.cbCommands1 = New System.Windows.Forms.ComboBox()
        Me.cbKey1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBinds
        '
        Me.lstBinds.BackColor = System.Drawing.Color.Silver
        Me.lstBinds.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBinds.ForeColor = System.Drawing.Color.Blue
        Me.lstBinds.FormattingEnabled = True
        Me.lstBinds.ItemHeight = 16
        Me.lstBinds.Location = New System.Drawing.Point(12, 12)
        Me.lstBinds.Name = "lstBinds"
        Me.lstBinds.Size = New System.Drawing.Size(616, 244)
        Me.lstBinds.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClearList)
        Me.GroupBox1.Controls.Add(Me.btnESTF)
        Me.GroupBox1.Controls.Add(Me.btnESTT)
        Me.GroupBox1.Controls.Add(Me.btnDeleteSelected)
        Me.GroupBox1.Controls.Add(Me.txtInstructions)
        Me.GroupBox1.Controls.Add(Me.lblInstructions)
        Me.GroupBox1.Controls.Add(Me.btnEditSelected)
        Me.GroupBox1.Controls.Add(Me.btnGenerateScript)
        Me.GroupBox1.Controls.Add(Me.cbCommands4)
        Me.GroupBox1.Controls.Add(Me.cbCommands3)
        Me.GroupBox1.Controls.Add(Me.cbCommands2)
        Me.GroupBox1.Controls.Add(Me.btnABTL)
        Me.GroupBox1.Controls.Add(Me.cbCommands1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 251)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control Panel"
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.Firebrick
        Me.btnClearList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearList.ForeColor = System.Drawing.Color.White
        Me.btnClearList.Location = New System.Drawing.Point(394, 51)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(211, 33)
        Me.btnClearList.TabIndex = 30
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'btnESTF
        '
        Me.btnESTF.BackColor = System.Drawing.Color.Firebrick
        Me.btnESTF.CausesValidation = False
        Me.btnESTF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnESTF.Enabled = False
        Me.btnESTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnESTF.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnESTF.ForeColor = System.Drawing.Color.White
        Me.btnESTF.Location = New System.Drawing.Point(312, 129)
        Me.btnESTF.Name = "btnESTF"
        Me.btnESTF.Size = New System.Drawing.Size(293, 33)
        Me.btnESTF.TabIndex = 24
        Me.btnESTF.Text = "Export Script To File"
        Me.btnESTF.UseVisualStyleBackColor = False
        '
        'btnESTT
        '
        Me.btnESTT.BackColor = System.Drawing.Color.Firebrick
        Me.btnESTT.CausesValidation = False
        Me.btnESTT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnESTT.Enabled = False
        Me.btnESTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnESTT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnESTT.ForeColor = System.Drawing.Color.White
        Me.btnESTT.Location = New System.Drawing.Point(8, 129)
        Me.btnESTT.Name = "btnESTT"
        Me.btnESTT.Size = New System.Drawing.Size(298, 33)
        Me.btnESTT.TabIndex = 23
        Me.btnESTT.Text = "Export Script To Text"
        Me.btnESTT.UseVisualStyleBackColor = False
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeleteSelected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelected.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSelected.Location = New System.Drawing.Point(197, 51)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(191, 33)
        Me.btnDeleteSelected.TabIndex = 29
        Me.btnDeleteSelected.Text = "Delete Selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = False
        '
        'txtInstructions
        '
        Me.txtInstructions.Location = New System.Drawing.Point(6, 184)
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.Size = New System.Drawing.Size(596, 57)
        Me.txtInstructions.TabIndex = 22
        Me.txtInstructions.Text = "1. Add a list of binds the to the list box above" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. After you have completed add" & _
    "ing everything you want to happen click 'Generate Script'" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3. Click 'Export Scri" & _
    "pt To Text' or 'Export Script To File'"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(3, 165)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(66, 16)
        Me.lblInstructions.TabIndex = 21
        Me.lblInstructions.Text = "Instructions :"
        '
        'btnEditSelected
        '
        Me.btnEditSelected.BackColor = System.Drawing.Color.Firebrick
        Me.btnEditSelected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSelected.ForeColor = System.Drawing.Color.White
        Me.btnEditSelected.Location = New System.Drawing.Point(6, 51)
        Me.btnEditSelected.Name = "btnEditSelected"
        Me.btnEditSelected.Size = New System.Drawing.Size(185, 33)
        Me.btnEditSelected.TabIndex = 28
        Me.btnEditSelected.Text = "Edit Selected"
        Me.btnEditSelected.UseVisualStyleBackColor = False
        '
        'btnGenerateScript
        '
        Me.btnGenerateScript.BackColor = System.Drawing.Color.Firebrick
        Me.btnGenerateScript.CausesValidation = False
        Me.btnGenerateScript.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGenerateScript.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateScript.ForeColor = System.Drawing.Color.White
        Me.btnGenerateScript.Location = New System.Drawing.Point(6, 90)
        Me.btnGenerateScript.Name = "btnGenerateScript"
        Me.btnGenerateScript.Size = New System.Drawing.Size(599, 33)
        Me.btnGenerateScript.TabIndex = 20
        Me.btnGenerateScript.Text = "Generate Script"
        Me.btnGenerateScript.UseVisualStyleBackColor = False
        '
        'cbCommands4
        '
        Me.cbCommands4.DropDownHeight = 275
        Me.cbCommands4.DropDownWidth = 200
        Me.cbCommands4.FormattingEnabled = True
        Me.cbCommands4.IntegralHeight = False
        Me.cbCommands4.Items.AddRange(New Object() {"None"})
        Me.cbCommands4.Location = New System.Drawing.Point(334, 21)
        Me.cbCommands4.Name = "cbCommands4"
        Me.cbCommands4.Size = New System.Drawing.Size(103, 24)
        Me.cbCommands4.TabIndex = 19
        Me.cbCommands4.Text = "Select Command"
        '
        'cbCommands3
        '
        Me.cbCommands3.DropDownHeight = 275
        Me.cbCommands3.DropDownWidth = 200
        Me.cbCommands3.FormattingEnabled = True
        Me.cbCommands3.IntegralHeight = False
        Me.cbCommands3.Items.AddRange(New Object() {"None"})
        Me.cbCommands3.Location = New System.Drawing.Point(224, 21)
        Me.cbCommands3.Name = "cbCommands3"
        Me.cbCommands3.Size = New System.Drawing.Size(103, 24)
        Me.cbCommands3.TabIndex = 18
        Me.cbCommands3.Text = "Select Command"
        '
        'cbCommands2
        '
        Me.cbCommands2.DropDownHeight = 275
        Me.cbCommands2.DropDownWidth = 200
        Me.cbCommands2.FormattingEnabled = True
        Me.cbCommands2.IntegralHeight = False
        Me.cbCommands2.Items.AddRange(New Object() {"None"})
        Me.cbCommands2.Location = New System.Drawing.Point(115, 21)
        Me.cbCommands2.Name = "cbCommands2"
        Me.cbCommands2.Size = New System.Drawing.Size(103, 24)
        Me.cbCommands2.TabIndex = 17
        Me.cbCommands2.Text = "Select Command"
        '
        'btnABTL
        '
        Me.btnABTL.BackColor = System.Drawing.Color.Firebrick
        Me.btnABTL.CausesValidation = False
        Me.btnABTL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnABTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnABTL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnABTL.ForeColor = System.Drawing.Color.White
        Me.btnABTL.Location = New System.Drawing.Point(443, 15)
        Me.btnABTL.Name = "btnABTL"
        Me.btnABTL.Size = New System.Drawing.Size(162, 33)
        Me.btnABTL.TabIndex = 15
        Me.btnABTL.Text = "Add Bind To List"
        Me.btnABTL.UseVisualStyleBackColor = False
        '
        'cbCommands1
        '
        Me.cbCommands1.DropDownHeight = 275
        Me.cbCommands1.DropDownWidth = 200
        Me.cbCommands1.FormattingEnabled = True
        Me.cbCommands1.IntegralHeight = False
        Me.cbCommands1.Location = New System.Drawing.Point(6, 21)
        Me.cbCommands1.Name = "cbCommands1"
        Me.cbCommands1.Size = New System.Drawing.Size(103, 24)
        Me.cbCommands1.TabIndex = 1
        Me.cbCommands1.Text = "Select Command"
        '
        'cbKey1
        '
        Me.cbKey1.DropDownHeight = 275
        Me.cbKey1.DropDownWidth = 200
        Me.cbKey1.FormattingEnabled = True
        Me.cbKey1.IntegralHeight = False
        Me.cbKey1.Location = New System.Drawing.Point(525, 12)
        Me.cbKey1.Name = "cbKey1"
        Me.cbKey1.Size = New System.Drawing.Size(103, 24)
        Me.cbKey1.TabIndex = 31
        Me.cbKey1.Text = "Select Key"
        '
        'frmCBS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(640, 517)
        Me.Controls.Add(Me.cbKey1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstBinds)
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmCBS"
        Me.Text = "Generate Script - Bind Manager - vDev - By: Agentsix1 - http://lifepunch.net"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstBinds As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbCommands4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCommands3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCommands2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnABTL As System.Windows.Forms.Button
    Friend WithEvents cbCommands1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtInstructions As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents btnGenerateScript As System.Windows.Forms.Button
    Friend WithEvents btnESTT As System.Windows.Forms.Button
    Friend WithEvents btnESTF As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSelected As System.Windows.Forms.Button
    Friend WithEvents btnEditSelected As System.Windows.Forms.Button
    Friend WithEvents cbKey1 As System.Windows.Forms.ComboBox
End Class
