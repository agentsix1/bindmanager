<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lstFile = New System.Windows.Forms.ListBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.btnEditSelected = New System.Windows.Forms.Button()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCommands6 = New System.Windows.Forms.ComboBox()
        Me.llLifepunch = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRASCP = New System.Windows.Forms.Button()
        Me.cbCommands5 = New System.Windows.Forms.ComboBox()
        Me.btnRBSCP = New System.Windows.Forms.Button()
        Me.cbCommands4 = New System.Windows.Forms.ComboBox()
        Me.NonKeyOTT = New System.Windows.Forms.Button()
        Me.cbCommands3 = New System.Windows.Forms.ComboBox()
        Me.NonKeyATBL = New System.Windows.Forms.Button()
        Me.cbCommands2 = New System.Windows.Forms.ComboBox()
        Me.btnOutBindToText = New System.Windows.Forms.Button()
        Me.btnAddBind = New System.Windows.Forms.Button()
        Me.cbCommands1 = New System.Windows.Forms.ComboBox()
        Me.cbKeys1 = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCHG = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUTP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNGTB = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUHTW = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlank1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLP = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLPHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLPForums = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLPRules = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLPBT = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBlank2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCFS = New System.Windows.Forms.Label()
        Me.mnuCFU = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstFile
        '
        Me.lstFile.BackColor = System.Drawing.Color.Silver
        Me.lstFile.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFile.ForeColor = System.Drawing.Color.Blue
        Me.lstFile.FormattingEnabled = True
        Me.lstFile.ItemHeight = 16
        Me.lstFile.Location = New System.Drawing.Point(15, 52)
        Me.lstFile.Name = "lstFile"
        Me.lstFile.Size = New System.Drawing.Size(462, 228)
        Me.lstFile.TabIndex = 0
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenFile.BackColor = System.Drawing.Color.Firebrick
        Me.btnOpenFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenFile.ForeColor = System.Drawing.Color.White
        Me.btnOpenFile.Location = New System.Drawing.Point(486, 52)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(153, 33)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "Open File"
        Me.btnOpenFile.UseVisualStyleBackColor = False
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveFile.BackColor = System.Drawing.Color.Firebrick
        Me.btnSaveFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFile.Enabled = False
        Me.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFile.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFile.ForeColor = System.Drawing.Color.White
        Me.btnSaveFile.Location = New System.Drawing.Point(486, 91)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(153, 33)
        Me.btnSaveFile.TabIndex = 2
        Me.btnSaveFile.Text = "Save File"
        Me.btnSaveFile.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveAs.BackColor = System.Drawing.Color.Firebrick
        Me.btnSaveAs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveAs.Enabled = False
        Me.btnSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAs.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAs.ForeColor = System.Drawing.Color.White
        Me.btnSaveAs.Location = New System.Drawing.Point(486, 130)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(153, 33)
        Me.btnSaveAs.TabIndex = 3
        Me.btnSaveAs.Text = "Save As"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'btnEditSelected
        '
        Me.btnEditSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditSelected.BackColor = System.Drawing.Color.Firebrick
        Me.btnEditSelected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditSelected.ForeColor = System.Drawing.Color.White
        Me.btnEditSelected.Location = New System.Drawing.Point(486, 169)
        Me.btnEditSelected.Name = "btnEditSelected"
        Me.btnEditSelected.Size = New System.Drawing.Size(153, 33)
        Me.btnEditSelected.TabIndex = 4
        Me.btnEditSelected.Text = "Edit Selected"
        Me.btnEditSelected.UseVisualStyleBackColor = False
        '
        'lblFileLocation
        '
        Me.lblFileLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblFileLocation.ForeColor = System.Drawing.Color.White
        Me.lblFileLocation.Location = New System.Drawing.Point(128, 36)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(0, 13)
        Me.lblFileLocation.TabIndex = 11
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteSelected.BackColor = System.Drawing.Color.Firebrick
        Me.btnDeleteSelected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeleteSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelected.ForeColor = System.Drawing.Color.White
        Me.btnDeleteSelected.Location = New System.Drawing.Point(486, 208)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(153, 33)
        Me.btnDeleteSelected.TabIndex = 12
        Me.btnDeleteSelected.Text = "Delete Selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = False
        '
        'btnClearList
        '
        Me.btnClearList.BackColor = System.Drawing.Color.Firebrick
        Me.btnClearList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearList.ForeColor = System.Drawing.Color.White
        Me.btnClearList.Location = New System.Drawing.Point(486, 247)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(153, 33)
        Me.btnClearList.TabIndex = 13
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCommands6)
        Me.GroupBox1.Controls.Add(Me.llLifepunch)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnRASCP)
        Me.GroupBox1.Controls.Add(Me.cbCommands5)
        Me.GroupBox1.Controls.Add(Me.btnRBSCP)
        Me.GroupBox1.Controls.Add(Me.cbCommands4)
        Me.GroupBox1.Controls.Add(Me.NonKeyOTT)
        Me.GroupBox1.Controls.Add(Me.cbCommands3)
        Me.GroupBox1.Controls.Add(Me.NonKeyATBL)
        Me.GroupBox1.Controls.Add(Me.cbCommands2)
        Me.GroupBox1.Controls.Add(Me.btnOutBindToText)
        Me.GroupBox1.Controls.Add(Me.btnAddBind)
        Me.GroupBox1.Controls.Add(Me.cbCommands1)
        Me.GroupBox1.Controls.Add(Me.cbKeys1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 224)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Key Binds/Non Key Binds - Simple Bind Creation / Script Generator Programs"
        '
        'cbCommands6
        '
        Me.cbCommands6.DropDownHeight = 275
        Me.cbCommands6.DropDownWidth = 200
        Me.cbCommands6.FormattingEnabled = True
        Me.cbCommands6.IntegralHeight = False
        Me.cbCommands6.Items.AddRange(New Object() {"None", "exec", "echo", "connect", "password", "Custom..."})
        Me.cbCommands6.Location = New System.Drawing.Point(135, 128)
        Me.cbCommands6.Name = "cbCommands6"
        Me.cbCommands6.Size = New System.Drawing.Size(121, 21)
        Me.cbCommands6.TabIndex = 24
        Me.cbCommands6.Text = "Select Command"
        '
        'llLifepunch
        '
        Me.llLifepunch.ActiveLinkColor = System.Drawing.Color.Green
        Me.llLifepunch.AutoSize = True
        Me.llLifepunch.BackColor = System.Drawing.Color.Black
        Me.llLifepunch.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llLifepunch.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.llLifepunch.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.llLifepunch.Location = New System.Drawing.Point(497, 0)
        Me.llLifepunch.Name = "llLifepunch"
        Me.llLifepunch.Size = New System.Drawing.Size(127, 16)
        Me.llLifepunch.TabIndex = 20
        Me.llLifepunch.TabStop = True
        Me.llLifepunch.Text = "Link : Lifepunch - Website"
        Me.llLifepunch.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Non Key Binds"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Key Binds"
        '
        'btnRASCP
        '
        Me.btnRASCP.BackColor = System.Drawing.Color.Firebrick
        Me.btnRASCP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRASCP.Enabled = False
        Me.btnRASCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRASCP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRASCP.ForeColor = System.Drawing.Color.White
        Me.btnRASCP.Location = New System.Drawing.Point(313, 178)
        Me.btnRASCP.Name = "btnRASCP"
        Me.btnRASCP.Size = New System.Drawing.Size(303, 33)
        Me.btnRASCP.TabIndex = 19
        Me.btnRASCP.Text = "Run Advanced Script Creation Program"
        Me.btnRASCP.UseVisualStyleBackColor = False
        '
        'cbCommands5
        '
        Me.cbCommands5.DropDownHeight = 275
        Me.cbCommands5.DropDownWidth = 200
        Me.cbCommands5.FormattingEnabled = True
        Me.cbCommands5.IntegralHeight = False
        Me.cbCommands5.Items.AddRange(New Object() {"None", "exec", "echo", "connect", "password", "Custom..."})
        Me.cbCommands5.Location = New System.Drawing.Point(8, 128)
        Me.cbCommands5.Name = "cbCommands5"
        Me.cbCommands5.Size = New System.Drawing.Size(121, 21)
        Me.cbCommands5.TabIndex = 20
        Me.cbCommands5.Text = "Select Command"
        '
        'btnRBSCP
        '
        Me.btnRBSCP.BackColor = System.Drawing.Color.Firebrick
        Me.btnRBSCP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRBSCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRBSCP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRBSCP.ForeColor = System.Drawing.Color.White
        Me.btnRBSCP.Location = New System.Drawing.Point(8, 178)
        Me.btnRBSCP.Name = "btnRBSCP"
        Me.btnRBSCP.Size = New System.Drawing.Size(299, 33)
        Me.btnRBSCP.TabIndex = 18
        Me.btnRBSCP.Text = "Run Basic Script Creation Program"
        Me.btnRBSCP.UseVisualStyleBackColor = False
        '
        'cbCommands4
        '
        Me.cbCommands4.DropDownHeight = 275
        Me.cbCommands4.DropDownWidth = 200
        Me.cbCommands4.FormattingEnabled = True
        Me.cbCommands4.IntegralHeight = False
        Me.cbCommands4.Items.AddRange(New Object() {"None", "Custom...", "connect", "password", "+duck", "-duck", "+forward", "-forward", "+jump", "-jump", "+left", "-left", "+menu", "-menu", "+movedown", "-movedown", "+moveleft", "-moveleft", "+moveright", "-moveright", "+moveup", "-moveup", "+reload", "-reload", "+right", "-right", "+speed", "-speed", "+use", "+walk", "-walk", "cl_showfps ""0""", "cl_showfps ""1""", "cl_showfps ""2""", "demoui", "demoui2", "echo", "exec", "gm_showspare1", "gm_showspare2", "noclip", "kill", "record", "stop", "say", "say_team", "slot1", "slot10", "slot2", "slot3", "slot4", "slot5", "slot6", "slot7", "slot8", "slot9", "undo", "buy_buff Disguise", "buy_buff Health", "buy_buff Knife", "buy_buff Pistol", "buy_buff Silent Killer", "buy_buff Speed", "buy_buff Team Radar", "use_buff Disguise", "use_buff Health", "use_buff Knife", "use_buff Pistol", "use_buff Silent Killer", "use_buff Speed", "use_buff Team Radar", "equip_chat_tag 1337", "equip_chat_tag Awesome face", "equip_chat_tag Batman", "equip_chat_tag Boss", "equip_chat_tag Cool", "equip_chat_tag default", "equip_chat_tag Fab", "equip_chat_tag Gay", "equip_chat_tag Hot", "equip_chat_tag Love", "equip_chat_tag Music", "equip_chat_tag Ninja", "equip_chat_tag Pokeball", "equip_chat_tag Rebel", "equip_chat_tag Rich", "equip_chat_tag Rusher", "equip_chat_tag Sexy", "equip_chat_tag SWAG", "equip_chat_tag Triforce", "equip_chat_tag Trollface", "equip_chat_tag U MAD tag", "equip_chat_tag Weed", "equip_chat_tag Win", "equip_chat_tag Wub Wub", "equip_chat_tag Yolo", "equip_hat Astronaut Helmut", "equip_hat Baby Face Replacement", "equip_hat Belicopter Bomb", "equip_hat Blue Barrel", "equip_hat Box Head", "equip_hat Bucket Head", "equip_hat Cake hat", "equip_hat Cash register", "equip_hat Combine Moniter", "equip_hat Cone Head", "equip_hat Creeper Hat", "equip_hat Deadmau5 hat", "equip_hat Deal Eith It", "equip_hat Explosive Barrel", "equip_hat Fedora", "equip_hat Guy Fawkes Mask", "equip_hat Headcrab", "equip_hat KFC Bucket", "equip_hat Lamp shade", "equip_hat Penis statue", "equip_hat Pirate Hat", "equip_hat Planet globe", "equip_hat Pokeball Hat", "equip_hat Pot Head", "equip_hat Russian Hat", "equip_hat Santa Hat", "equip_hat Shoe Hat", "equip_hat Skull Head", "equip_hat Snowman Head", "equip_hat Stove", "equip_hat Television Head", "equip_hat Top hatte", "equip_hat Vaultboy Head", "equip_hat Viking Hat", "equip_hat Washing machine", "equip_hat Watermelon Head", "equip_hat Wizard hatte", "equip_model Altair", "equip_model Alyx", "equip_model Aower Armor Outcast", "equip_model Batman", "equip_model Billy", "equip_model Doctor breen", "equip_model Doctor Kleiner", "equip_model Eli", "equip_model Father grigori", "equip_model Female Citizen 1", "equip_model Female Citizen 2", "equip_model Female Citizen 3", "equip_model Female Citizen 4", "equip_model Female Citizen 5", "equip_model Female Citizen 6", "equip_model Female Rebel 1", "equip_model Female Rebel 2", "equip_model Female Rebel 3", "equip_model GMan", "equip_model Hitler", "equip_model HLFLF Armor", "equip_model Jack Sparrow", "equip_model Jason Brody", "equip_model Lara Croft", "equip_model Liberty Prime", "equip_model Male Citizen 1", "equip_model Male Citizen 2", "equip_model Male Citizen 4", "equip_model Male Citizen 5", "equip_model Male Citizen 6", "equip_model Male Rebel 1", "equip_model Male Rebel 2", "equip_model Male Rebel 3", "equip_model Mossman", "equip_model Osama Ben Laden", "equip_model Renamon", "equip_model Robocop", "equip_model Rorschach", "equip_model Skeleton Soldier", "equip_model T51B", "equip_model Tesla Power Armor", "equip_model Vaas", "equip_model Venom", "equip_model Zombie", "equip_trail 8bit One Up Shroom Trail", "equip_trail Australia", "equip_trail Awesome", "equip_trail Black Beam", "equip_trail Blue Beam", "equip_trail Canada", "equip_trail Dark Blue Beam", "equip_trail Default", "equip_trail Dollar", "equip_trail Electric", "equip_trail Evil Face", "equip_trail Footprints", "equip_trail GABEN", "equip_trail Germany", "equip_trail Green Beam", "equip_trail Happy face", "equip_trail Hearts", "equip_trail Italy", "equip_trail Lifepunch Logo", "equip_trail LOLOLO", "equip_trail Mario Hat Trail", "equip_trail Minecraf Dirt", "equip_trail Minecraft Brick", "equip_trail Minecraft Cobblestone", "equip_trail Minecraft Diamond", "equip_trail Minecraft Gold", "equip_trail Minecraft Grass", "equip_trail Minecraft TNT", "equip_trail Minecraft Track", "equip_trail Mnecraft Wood", "equip_trail Ninja", "equip_trail One Up Trail", "equip_trail Orange Beam", "equip_trail Pedobear", "equip_trail period-colored", "equip_trail Pikachu Trail", "equip_trail Pink Beam", "equip_trail Plasma", "equip_trail Pokeball Trail", "equip_trail Poland", "equip_trail Purple Beam", "equip_trail Rainbow", "equip_trail Scotland", "equip_trail Smoke", "equip_trail Speed", "equip_trail Trollfaec", "equip_trail Turd", "equip_trail UK", "equip_trail USA", "equip_trail Weed", "equip_trail White Beam", "equip_trail Yellow Beam", "equip_trail Ying Yang", "use gg_ak47", "use gg_aug", "use gg_awp", "use gg_deagle", "use gg_elite", "use gg_fiveseven", "use gg_galil", "use gg_glock", "use gg_knife", "use gg_m249", "use gg_m3", "use gg_m4a1", "use gg_mac10", "use gg_mp5", "use gg_p228", "use gg_p90", "use gg_scout", "use gg_sg552", "use gg_tmp", "use gg_ump45", "use gg-xm1014", "use jb_ak47", "use jb_aug", "use jb_awp", "use jb_deagle", "use jb_dodgeballcannon", "use jb_fiveseven", "use jb_galil", "use jb_glock", "use jb_hands", "use jb_knife", "use jb_m249", "use jb_m3", "use jb_m4a1", "use jb_mac10", "use jb_medkit", "use jb_p228", "use jb_p90", "use jb_scout", "use jb_sg552", "use jb_stunbaton", "use jb_tmp", "use jb_tranquilizer", "use jb_usp", "use jb_weaponfrisker", "use lp_weapon_baseballbat", "use lp_weapon_chainsaw", "use lp_weapon_crowbar", "use lp_weapon_diamondsword", "use lp_weapon_fryingpan", "use lp_weapon_katana", "use lp_weapon_pickaxe", "use lp_weapon_pot", "use lp_weapon_scythe"})
        Me.cbCommands4.Location = New System.Drawing.Point(513, 32)
        Me.cbCommands4.Name = "cbCommands4"
        Me.cbCommands4.Size = New System.Drawing.Size(103, 21)
        Me.cbCommands4.TabIndex = 19
        Me.cbCommands4.Text = "Select Command"
        '
        'NonKeyOTT
        '
        Me.NonKeyOTT.BackColor = System.Drawing.Color.Firebrick
        Me.NonKeyOTT.CausesValidation = False
        Me.NonKeyOTT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NonKeyOTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NonKeyOTT.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonKeyOTT.ForeColor = System.Drawing.Color.White
        Me.NonKeyOTT.Location = New System.Drawing.Point(440, 120)
        Me.NonKeyOTT.Name = "NonKeyOTT"
        Me.NonKeyOTT.Size = New System.Drawing.Size(176, 33)
        Me.NonKeyOTT.TabIndex = 16
        Me.NonKeyOTT.Text = "Output To Text"
        Me.NonKeyOTT.UseVisualStyleBackColor = False
        '
        'cbCommands3
        '
        Me.cbCommands3.DropDownHeight = 275
        Me.cbCommands3.DropDownWidth = 200
        Me.cbCommands3.FormattingEnabled = True
        Me.cbCommands3.IntegralHeight = False
        Me.cbCommands3.Items.AddRange(New Object() {"None", "Custom...", "connect", "password", "+duck", "-duck", "+forward", "-forward", "+jump", "-jump", "+left", "-left", "+menu", "-menu", "+movedown", "-movedown", "+moveleft", "-moveleft", "+moveright", "-moveright", "+moveup", "-moveup", "+reload", "-reload", "+right", "-right", "+speed", "-speed", "+use", "+walk", "-walk", "cl_showfps ""0""", "cl_showfps ""1""", "cl_showfps ""2""", "demoui", "demoui2", "echo", "exec", "gm_showspare1", "gm_showspare2", "noclip", "kill", "record", "stop", "say", "say_team", "slot1", "slot10", "slot2", "slot3", "slot4", "slot5", "slot6", "slot7", "slot8", "slot9", "undo", "buy_buff Disguise", "buy_buff Health", "buy_buff Knife", "buy_buff Pistol", "buy_buff Silent Killer", "buy_buff Speed", "buy_buff Team Radar", "use_buff Disguise", "use_buff Health", "use_buff Knife", "use_buff Pistol", "use_buff Silent Killer", "use_buff Speed", "use_buff Team Radar", "equip_chat_tag 1337", "equip_chat_tag Awesome face", "equip_chat_tag Batman", "equip_chat_tag Boss", "equip_chat_tag Cool", "equip_chat_tag default", "equip_chat_tag Fab", "equip_chat_tag Gay", "equip_chat_tag Hot", "equip_chat_tag Love", "equip_chat_tag Music", "equip_chat_tag Ninja", "equip_chat_tag Pokeball", "equip_chat_tag Rebel", "equip_chat_tag Rich", "equip_chat_tag Rusher", "equip_chat_tag Sexy", "equip_chat_tag SWAG", "equip_chat_tag Triforce", "equip_chat_tag Trollface", "equip_chat_tag U MAD tag", "equip_chat_tag Weed", "equip_chat_tag Win", "equip_chat_tag Wub Wub", "equip_chat_tag Yolo", "equip_hat Astronaut Helmut", "equip_hat Baby Face Replacement", "equip_hat Belicopter Bomb", "equip_hat Blue Barrel", "equip_hat Box Head", "equip_hat Bucket Head", "equip_hat Cake hat", "equip_hat Cash register", "equip_hat Combine Moniter", "equip_hat Cone Head", "equip_hat Creeper Hat", "equip_hat Deadmau5 hat", "equip_hat Deal Eith It", "equip_hat Explosive Barrel", "equip_hat Fedora", "equip_hat Guy Fawkes Mask", "equip_hat Headcrab", "equip_hat KFC Bucket", "equip_hat Lamp shade", "equip_hat Penis statue", "equip_hat Pirate Hat", "equip_hat Planet globe", "equip_hat Pokeball Hat", "equip_hat Pot Head", "equip_hat Russian Hat", "equip_hat Santa Hat", "equip_hat Shoe Hat", "equip_hat Skull Head", "equip_hat Snowman Head", "equip_hat Stove", "equip_hat Television Head", "equip_hat Top hatte", "equip_hat Vaultboy Head", "equip_hat Viking Hat", "equip_hat Washing machine", "equip_hat Watermelon Head", "equip_hat Wizard hatte", "equip_model Altair", "equip_model Alyx", "equip_model Aower Armor Outcast", "equip_model Batman", "equip_model Billy", "equip_model Doctor breen", "equip_model Doctor Kleiner", "equip_model Eli", "equip_model Father grigori", "equip_model Female Citizen 1", "equip_model Female Citizen 2", "equip_model Female Citizen 3", "equip_model Female Citizen 4", "equip_model Female Citizen 5", "equip_model Female Citizen 6", "equip_model Female Rebel 1", "equip_model Female Rebel 2", "equip_model Female Rebel 3", "equip_model GMan", "equip_model Hitler", "equip_model HLFLF Armor", "equip_model Jack Sparrow", "equip_model Jason Brody", "equip_model Lara Croft", "equip_model Liberty Prime", "equip_model Male Citizen 1", "equip_model Male Citizen 2", "equip_model Male Citizen 4", "equip_model Male Citizen 5", "equip_model Male Citizen 6", "equip_model Male Rebel 1", "equip_model Male Rebel 2", "equip_model Male Rebel 3", "equip_model Mossman", "equip_model Osama Ben Laden", "equip_model Renamon", "equip_model Robocop", "equip_model Rorschach", "equip_model Skeleton Soldier", "equip_model T51B", "equip_model Tesla Power Armor", "equip_model Vaas", "equip_model Venom", "equip_model Zombie", "equip_trail 8bit One Up Shroom Trail", "equip_trail Australia", "equip_trail Awesome", "equip_trail Black Beam", "equip_trail Blue Beam", "equip_trail Canada", "equip_trail Dark Blue Beam", "equip_trail Default", "equip_trail Dollar", "equip_trail Electric", "equip_trail Evil Face", "equip_trail Footprints", "equip_trail GABEN", "equip_trail Germany", "equip_trail Green Beam", "equip_trail Happy face", "equip_trail Hearts", "equip_trail Italy", "equip_trail Lifepunch Logo", "equip_trail LOLOLO", "equip_trail Mario Hat Trail", "equip_trail Minecraf Dirt", "equip_trail Minecraft Brick", "equip_trail Minecraft Cobblestone", "equip_trail Minecraft Diamond", "equip_trail Minecraft Gold", "equip_trail Minecraft Grass", "equip_trail Minecraft TNT", "equip_trail Minecraft Track", "equip_trail Mnecraft Wood", "equip_trail Ninja", "equip_trail One Up Trail", "equip_trail Orange Beam", "equip_trail Pedobear", "equip_trail period-colored", "equip_trail Pikachu Trail", "equip_trail Pink Beam", "equip_trail Plasma", "equip_trail Pokeball Trail", "equip_trail Poland", "equip_trail Purple Beam", "equip_trail Rainbow", "equip_trail Scotland", "equip_trail Smoke", "equip_trail Speed", "equip_trail Trollfaec", "equip_trail Turd", "equip_trail UK", "equip_trail USA", "equip_trail Weed", "equip_trail White Beam", "equip_trail Yellow Beam", "equip_trail Ying Yang", "use gg_ak47", "use gg_aug", "use gg_awp", "use gg_deagle", "use gg_elite", "use gg_fiveseven", "use gg_galil", "use gg_glock", "use gg_knife", "use gg_m249", "use gg_m3", "use gg_m4a1", "use gg_mac10", "use gg_mp5", "use gg_p228", "use gg_p90", "use gg_scout", "use gg_sg552", "use gg_tmp", "use gg_ump45", "use gg-xm1014", "use jb_ak47", "use jb_aug", "use jb_awp", "use jb_deagle", "use jb_dodgeballcannon", "use jb_fiveseven", "use jb_galil", "use jb_glock", "use jb_hands", "use jb_knife", "use jb_m249", "use jb_m3", "use jb_m4a1", "use jb_mac10", "use jb_medkit", "use jb_p228", "use jb_p90", "use jb_scout", "use jb_sg552", "use jb_stunbaton", "use jb_tmp", "use jb_tranquilizer", "use jb_usp", "use jb_weaponfrisker", "use lp_weapon_baseballbat", "use lp_weapon_chainsaw", "use lp_weapon_crowbar", "use lp_weapon_diamondsword", "use lp_weapon_fryingpan", "use lp_weapon_katana", "use lp_weapon_pickaxe", "use lp_weapon_pot", "use lp_weapon_scythe"})
        Me.cbCommands3.Location = New System.Drawing.Point(390, 32)
        Me.cbCommands3.Name = "cbCommands3"
        Me.cbCommands3.Size = New System.Drawing.Size(103, 21)
        Me.cbCommands3.TabIndex = 18
        Me.cbCommands3.Text = "Select Command"
        '
        'NonKeyATBL
        '
        Me.NonKeyATBL.BackColor = System.Drawing.Color.Firebrick
        Me.NonKeyATBL.CausesValidation = False
        Me.NonKeyATBL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NonKeyATBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NonKeyATBL.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NonKeyATBL.ForeColor = System.Drawing.Color.White
        Me.NonKeyATBL.Location = New System.Drawing.Point(264, 120)
        Me.NonKeyATBL.Name = "NonKeyATBL"
        Me.NonKeyATBL.Size = New System.Drawing.Size(170, 33)
        Me.NonKeyATBL.TabIndex = 15
        Me.NonKeyATBL.Text = "Add Bind To List"
        Me.NonKeyATBL.UseVisualStyleBackColor = False
        '
        'cbCommands2
        '
        Me.cbCommands2.DropDownHeight = 275
        Me.cbCommands2.DropDownWidth = 200
        Me.cbCommands2.FormattingEnabled = True
        Me.cbCommands2.IntegralHeight = False
        Me.cbCommands2.Items.AddRange(New Object() {"None", "Custom...", "connect", "password", "+duck", "-duck", "+forward", "-forward", "+jump", "-jump", "+left", "-left", "+menu", "-menu", "+movedown", "-movedown", "+moveleft", "-moveleft", "+moveright", "-moveright", "+moveup", "-moveup", "+reload", "-reload", "+right", "-right", "+speed", "-speed", "+use", "+walk", "-walk", "cl_showfps ""0""", "cl_showfps ""1""", "cl_showfps ""2""", "demoui", "demoui2", "echo", "exec", "gm_showspare1", "gm_showspare2", "noclip", "kill", "record", "stop", "say", "say_team", "slot1", "slot10", "slot2", "slot3", "slot4", "slot5", "slot6", "slot7", "slot8", "slot9", "undo", "buy_buff Disguise", "buy_buff Health", "buy_buff Knife", "buy_buff Pistol", "buy_buff Silent Killer", "buy_buff Speed", "buy_buff Team Radar", "use_buff Disguise", "use_buff Health", "use_buff Knife", "use_buff Pistol", "use_buff Silent Killer", "use_buff Speed", "use_buff Team Radar", "equip_chat_tag 1337", "equip_chat_tag Awesome face", "equip_chat_tag Batman", "equip_chat_tag Boss", "equip_chat_tag Cool", "equip_chat_tag default", "equip_chat_tag Fab", "equip_chat_tag Gay", "equip_chat_tag Hot", "equip_chat_tag Love", "equip_chat_tag Music", "equip_chat_tag Ninja", "equip_chat_tag Pokeball", "equip_chat_tag Rebel", "equip_chat_tag Rich", "equip_chat_tag Rusher", "equip_chat_tag Sexy", "equip_chat_tag SWAG", "equip_chat_tag Triforce", "equip_chat_tag Trollface", "equip_chat_tag U MAD tag", "equip_chat_tag Weed", "equip_chat_tag Win", "equip_chat_tag Wub Wub", "equip_chat_tag Yolo", "equip_hat Astronaut Helmut", "equip_hat Baby Face Replacement", "equip_hat Belicopter Bomb", "equip_hat Blue Barrel", "equip_hat Box Head", "equip_hat Bucket Head", "equip_hat Cake hat", "equip_hat Cash register", "equip_hat Combine Moniter", "equip_hat Cone Head", "equip_hat Creeper Hat", "equip_hat Deadmau5 hat", "equip_hat Deal Eith It", "equip_hat Explosive Barrel", "equip_hat Fedora", "equip_hat Guy Fawkes Mask", "equip_hat Headcrab", "equip_hat KFC Bucket", "equip_hat Lamp shade", "equip_hat Penis statue", "equip_hat Pirate Hat", "equip_hat Planet globe", "equip_hat Pokeball Hat", "equip_hat Pot Head", "equip_hat Russian Hat", "equip_hat Santa Hat", "equip_hat Shoe Hat", "equip_hat Skull Head", "equip_hat Snowman Head", "equip_hat Stove", "equip_hat Television Head", "equip_hat Top hatte", "equip_hat Vaultboy Head", "equip_hat Viking Hat", "equip_hat Washing machine", "equip_hat Watermelon Head", "equip_hat Wizard hatte", "equip_model Altair", "equip_model Alyx", "equip_model Aower Armor Outcast", "equip_model Batman", "equip_model Billy", "equip_model Doctor breen", "equip_model Doctor Kleiner", "equip_model Eli", "equip_model Father grigori", "equip_model Female Citizen 1", "equip_model Female Citizen 2", "equip_model Female Citizen 3", "equip_model Female Citizen 4", "equip_model Female Citizen 5", "equip_model Female Citizen 6", "equip_model Female Rebel 1", "equip_model Female Rebel 2", "equip_model Female Rebel 3", "equip_model GMan", "equip_model Hitler", "equip_model HLFLF Armor", "equip_model Jack Sparrow", "equip_model Jason Brody", "equip_model Lara Croft", "equip_model Liberty Prime", "equip_model Male Citizen 1", "equip_model Male Citizen 2", "equip_model Male Citizen 4", "equip_model Male Citizen 5", "equip_model Male Citizen 6", "equip_model Male Rebel 1", "equip_model Male Rebel 2", "equip_model Male Rebel 3", "equip_model Mossman", "equip_model Osama Ben Laden", "equip_model Renamon", "equip_model Robocop", "equip_model Rorschach", "equip_model Skeleton Soldier", "equip_model T51B", "equip_model Tesla Power Armor", "equip_model Vaas", "equip_model Venom", "equip_model Zombie", "equip_trail 8bit One Up Shroom Trail", "equip_trail Australia", "equip_trail Awesome", "equip_trail Black Beam", "equip_trail Blue Beam", "equip_trail Canada", "equip_trail Dark Blue Beam", "equip_trail Default", "equip_trail Dollar", "equip_trail Electric", "equip_trail Evil Face", "equip_trail Footprints", "equip_trail GABEN", "equip_trail Germany", "equip_trail Green Beam", "equip_trail Happy face", "equip_trail Hearts", "equip_trail Italy", "equip_trail Lifepunch Logo", "equip_trail LOLOLO", "equip_trail Mario Hat Trail", "equip_trail Minecraf Dirt", "equip_trail Minecraft Brick", "equip_trail Minecraft Cobblestone", "equip_trail Minecraft Diamond", "equip_trail Minecraft Gold", "equip_trail Minecraft Grass", "equip_trail Minecraft TNT", "equip_trail Minecraft Track", "equip_trail Mnecraft Wood", "equip_trail Ninja", "equip_trail One Up Trail", "equip_trail Orange Beam", "equip_trail Pedobear", "equip_trail period-colored", "equip_trail Pikachu Trail", "equip_trail Pink Beam", "equip_trail Plasma", "equip_trail Pokeball Trail", "equip_trail Poland", "equip_trail Purple Beam", "equip_trail Rainbow", "equip_trail Scotland", "equip_trail Smoke", "equip_trail Speed", "equip_trail Trollfaec", "equip_trail Turd", "equip_trail UK", "equip_trail USA", "equip_trail Weed", "equip_trail White Beam", "equip_trail Yellow Beam", "equip_trail Ying Yang", "use gg_ak47", "use gg_aug", "use gg_awp", "use gg_deagle", "use gg_elite", "use gg_fiveseven", "use gg_galil", "use gg_glock", "use gg_knife", "use gg_m249", "use gg_m3", "use gg_m4a1", "use gg_mac10", "use gg_mp5", "use gg_p228", "use gg_p90", "use gg_scout", "use gg_sg552", "use gg_tmp", "use gg_ump45", "use gg-xm1014", "use jb_ak47", "use jb_aug", "use jb_awp", "use jb_deagle", "use jb_dodgeballcannon", "use jb_fiveseven", "use jb_galil", "use jb_glock", "use jb_hands", "use jb_knife", "use jb_m249", "use jb_m3", "use jb_m4a1", "use jb_mac10", "use jb_medkit", "use jb_p228", "use jb_p90", "use jb_scout", "use jb_sg552", "use jb_stunbaton", "use jb_tmp", "use jb_tranquilizer", "use jb_usp", "use jb_weaponfrisker", "use lp_weapon_baseballbat", "use lp_weapon_chainsaw", "use lp_weapon_crowbar", "use lp_weapon_diamondsword", "use lp_weapon_fryingpan", "use lp_weapon_katana", "use lp_weapon_pickaxe", "use lp_weapon_pot", "use lp_weapon_scythe"})
        Me.cbCommands2.Location = New System.Drawing.Point(264, 32)
        Me.cbCommands2.Name = "cbCommands2"
        Me.cbCommands2.Size = New System.Drawing.Size(103, 21)
        Me.cbCommands2.TabIndex = 17
        Me.cbCommands2.Text = "Select Command"
        '
        'btnOutBindToText
        '
        Me.btnOutBindToText.BackColor = System.Drawing.Color.Firebrick
        Me.btnOutBindToText.CausesValidation = False
        Me.btnOutBindToText.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOutBindToText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOutBindToText.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOutBindToText.ForeColor = System.Drawing.Color.White
        Me.btnOutBindToText.Location = New System.Drawing.Point(313, 59)
        Me.btnOutBindToText.Name = "btnOutBindToText"
        Me.btnOutBindToText.Size = New System.Drawing.Size(303, 33)
        Me.btnOutBindToText.TabIndex = 16
        Me.btnOutBindToText.Text = "Output To Text"
        Me.btnOutBindToText.UseVisualStyleBackColor = False
        '
        'btnAddBind
        '
        Me.btnAddBind.BackColor = System.Drawing.Color.Firebrick
        Me.btnAddBind.CausesValidation = False
        Me.btnAddBind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddBind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddBind.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddBind.ForeColor = System.Drawing.Color.White
        Me.btnAddBind.Location = New System.Drawing.Point(8, 59)
        Me.btnAddBind.Name = "btnAddBind"
        Me.btnAddBind.Size = New System.Drawing.Size(299, 33)
        Me.btnAddBind.TabIndex = 15
        Me.btnAddBind.Text = "Add Bind To List"
        Me.btnAddBind.UseVisualStyleBackColor = False
        '
        'cbCommands1
        '
        Me.cbCommands1.DropDownHeight = 275
        Me.cbCommands1.DropDownWidth = 200
        Me.cbCommands1.FormattingEnabled = True
        Me.cbCommands1.IntegralHeight = False
        Me.cbCommands1.Items.AddRange(New Object() {"None", "Custom...", "connect", "password", "+duck", "-duck", "+forward", "-forward", "+jump", "-jump", "+left", "-left", "+menu", "-menu", "+movedown", "-movedown", "+moveleft", "-moveleft", "+moveright", "-moveright", "+moveup", "-moveup", "+reload", "-reload", "+right", "-right", "+speed", "-speed", "+use", "+walk", "-walk", "cl_showfps ""0""", "cl_showfps ""1""", "cl_showfps ""2""", "demoui", "demoui2", "echo", "exec", "gm_showspare1", "gm_showspare2", "noclip", "kill", "record", "stop", "say", "say_team", "slot1", "slot10", "slot2", "slot3", "slot4", "slot5", "slot6", "slot7", "slot8", "slot9", "undo", "buy_buff Disguise", "buy_buff Health", "buy_buff Knife", "buy_buff Pistol", "buy_buff Silent Killer", "buy_buff Speed", "buy_buff Team Radar", "use_buff Disguise", "use_buff Health", "use_buff Knife", "use_buff Pistol", "use_buff Silent Killer", "use_buff Speed", "use_buff Team Radar", "equip_chat_tag 1337", "equip_chat_tag Awesome face", "equip_chat_tag Batman", "equip_chat_tag Boss", "equip_chat_tag Cool", "equip_chat_tag default", "equip_chat_tag Fab", "equip_chat_tag Gay", "equip_chat_tag Hot", "equip_chat_tag Love", "equip_chat_tag Music", "equip_chat_tag Ninja", "equip_chat_tag Pokeball", "equip_chat_tag Rebel", "equip_chat_tag Rich", "equip_chat_tag Rusher", "equip_chat_tag Sexy", "equip_chat_tag SWAG", "equip_chat_tag Triforce", "equip_chat_tag Trollface", "equip_chat_tag U MAD tag", "equip_chat_tag Weed", "equip_chat_tag Win", "equip_chat_tag Wub Wub", "equip_chat_tag Yolo", "equip_hat Astronaut Helmut", "equip_hat Baby Face Replacement", "equip_hat Belicopter Bomb", "equip_hat Blue Barrel", "equip_hat Box Head", "equip_hat Bucket Head", "equip_hat Cake hat", "equip_hat Cash register", "equip_hat Combine Moniter", "equip_hat Cone Head", "equip_hat Creeper Hat", "equip_hat Deadmau5 hat", "equip_hat Deal Eith It", "equip_hat Explosive Barrel", "equip_hat Fedora", "equip_hat Guy Fawkes Mask", "equip_hat Headcrab", "equip_hat KFC Bucket", "equip_hat Lamp shade", "equip_hat Penis statue", "equip_hat Pirate Hat", "equip_hat Planet globe", "equip_hat Pokeball Hat", "equip_hat Pot Head", "equip_hat Russian Hat", "equip_hat Santa Hat", "equip_hat Shoe Hat", "equip_hat Skull Head", "equip_hat Snowman Head", "equip_hat Stove", "equip_hat Television Head", "equip_hat Top hatte", "equip_hat Vaultboy Head", "equip_hat Viking Hat", "equip_hat Washing machine", "equip_hat Watermelon Head", "equip_hat Wizard hatte", "equip_model Altair", "equip_model Alyx", "equip_model Aower Armor Outcast", "equip_model Batman", "equip_model Billy", "equip_model Doctor breen", "equip_model Doctor Kleiner", "equip_model Eli", "equip_model Father grigori", "equip_model Female Citizen 1", "equip_model Female Citizen 2", "equip_model Female Citizen 3", "equip_model Female Citizen 4", "equip_model Female Citizen 5", "equip_model Female Citizen 6", "equip_model Female Rebel 1", "equip_model Female Rebel 2", "equip_model Female Rebel 3", "equip_model GMan", "equip_model Hitler", "equip_model HLFLF Armor", "equip_model Jack Sparrow", "equip_model Jason Brody", "equip_model Lara Croft", "equip_model Liberty Prime", "equip_model Male Citizen 1", "equip_model Male Citizen 2", "equip_model Male Citizen 4", "equip_model Male Citizen 5", "equip_model Male Citizen 6", "equip_model Male Rebel 1", "equip_model Male Rebel 2", "equip_model Male Rebel 3", "equip_model Mossman", "equip_model Osama Ben Laden", "equip_model Renamon", "equip_model Robocop", "equip_model Rorschach", "equip_model Skeleton Soldier", "equip_model T51B", "equip_model Tesla Power Armor", "equip_model Vaas", "equip_model Venom", "equip_model Zombie", "equip_trail 8bit One Up Shroom Trail", "equip_trail Australia", "equip_trail Awesome", "equip_trail Black Beam", "equip_trail Blue Beam", "equip_trail Canada", "equip_trail Dark Blue Beam", "equip_trail Default", "equip_trail Dollar", "equip_trail Electric", "equip_trail Evil Face", "equip_trail Footprints", "equip_trail GABEN", "equip_trail Germany", "equip_trail Green Beam", "equip_trail Happy face", "equip_trail Hearts", "equip_trail Italy", "equip_trail Lifepunch Logo", "equip_trail LOLOLO", "equip_trail Mario Hat Trail", "equip_trail Minecraf Dirt", "equip_trail Minecraft Brick", "equip_trail Minecraft Cobblestone", "equip_trail Minecraft Diamond", "equip_trail Minecraft Gold", "equip_trail Minecraft Grass", "equip_trail Minecraft TNT", "equip_trail Minecraft Track", "equip_trail Mnecraft Wood", "equip_trail Ninja", "equip_trail One Up Trail", "equip_trail Orange Beam", "equip_trail Pedobear", "equip_trail period-colored", "equip_trail Pikachu Trail", "equip_trail Pink Beam", "equip_trail Plasma", "equip_trail Pokeball Trail", "equip_trail Poland", "equip_trail Purple Beam", "equip_trail Rainbow", "equip_trail Scotland", "equip_trail Smoke", "equip_trail Speed", "equip_trail Trollfaec", "equip_trail Turd", "equip_trail UK", "equip_trail USA", "equip_trail Weed", "equip_trail White Beam", "equip_trail Yellow Beam", "equip_trail Ying Yang", "use gg_ak47", "use gg_aug", "use gg_awp", "use gg_deagle", "use gg_elite", "use gg_fiveseven", "use gg_galil", "use gg_glock", "use gg_knife", "use gg_m249", "use gg_m3", "use gg_m4a1", "use gg_mac10", "use gg_mp5", "use gg_p228", "use gg_p90", "use gg_scout", "use gg_sg552", "use gg_tmp", "use gg_ump45", "use gg-xm1014", "use jb_ak47", "use jb_aug", "use jb_awp", "use jb_deagle", "use jb_dodgeballcannon", "use jb_fiveseven", "use jb_galil", "use jb_glock", "use jb_hands", "use jb_knife", "use jb_m249", "use jb_m3", "use jb_m4a1", "use jb_mac10", "use jb_medkit", "use jb_p228", "use jb_p90", "use jb_scout", "use jb_sg552", "use jb_stunbaton", "use jb_tmp", "use jb_tranquilizer", "use jb_usp", "use jb_weaponfrisker", "use lp_weapon_baseballbat", "use lp_weapon_chainsaw", "use lp_weapon_crowbar", "use lp_weapon_diamondsword", "use lp_weapon_fryingpan", "use lp_weapon_katana", "use lp_weapon_pickaxe", "use lp_weapon_pot", "use lp_weapon_scythe"})
        Me.cbCommands1.Location = New System.Drawing.Point(135, 32)
        Me.cbCommands1.Name = "cbCommands1"
        Me.cbCommands1.Size = New System.Drawing.Size(103, 21)
        Me.cbCommands1.TabIndex = 1
        Me.cbCommands1.Text = "Select Command"
        '
        'cbKeys1
        '
        Me.cbKeys1.DropDownHeight = 200
        Me.cbKeys1.DropDownWidth = 150
        Me.cbKeys1.FormattingEnabled = True
        Me.cbKeys1.IntegralHeight = False
        Me.cbKeys1.Items.AddRange(New Object() {"Custom...", "A", "B", "C", "D", "E", "F", "G", "H", "F", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "`", "-", "=", "[", "]", "\", ";", "'", "/", ",", ".", "ENTER", "BACKSPACE", "SPACE", "ALT", "CTRL", "CAPSLOCK", "TAB", "LEFTARROW", "RIGHTARROW", "UPARROW", "DOWNARROW", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "INS", "DEL", "HOME", "END", "PGUP", "PGDOWN", "MWHEELUP", "MWHEELDOWN", "MOUSE1", "MOUSE2", "MOUSE3", "MOUSE4", "MOUSE5", "MOUSE6", "MOUSE7", "MOUSE8", "MOUSE9", "MOUSE10", "KP_HOME", "KP_UPARROW", "KP_PGUP", "KP_LEFTARROW", "KP_5", "KP_RIGHTARROW", "KP_END", "DOWNARROW", "KP_PGDN", "KP_INS", "KP_DEL", "KP_SLASH", "KP_MINUS", "KP_PLUS", "*"})
        Me.cbKeys1.Location = New System.Drawing.Point(8, 32)
        Me.cbKeys1.Name = "cbKeys1"
        Me.cbKeys1.Size = New System.Drawing.Size(121, 21)
        Me.cbKeys1.TabIndex = 0
        Me.cbKeys1.Text = "Select Key"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(618, 205)
        Me.ShapeContainer1.TabIndex = 21
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.BorderWidth = 3
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -6
        Me.LineShape2.X2 = 623
        Me.LineShape2.Y1 = 149
        Me.LineShape2.Y2 = 150
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.BorderWidth = 3
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -3
        Me.LineShape1.X2 = 620
        Me.LineShape1.Y1 = 87
        Me.LineShape1.Y2 = 87
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.Filter = "Bind/Script Files (*.cfg)|*.cfg"
        Me.ofdOpenFile.InitialDirectory = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSettings, Me.mnuHelp, Me.mnuBlank1, Me.mnuLP, Me.mnuBlank2, Me.mnuCFU})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(649, 24)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.Black
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(114, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuSave
        '
        Me.mnuSave.Enabled = False
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(114, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Enabled = False
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(114, 22)
        Me.mnuSaveAs.Text = "Save As"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(114, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuSettings
        '
        Me.mnuSettings.ForeColor = System.Drawing.Color.Black
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCHG, Me.mnuUTP, Me.mnuNGTB, Me.mnuUHTW})
        Me.mnuHelp.ForeColor = System.Drawing.Color.Black
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "Help"
        '
        'mnuCHG
        '
        Me.mnuCHG.Name = "mnuCHG"
        Me.mnuCHG.Size = New System.Drawing.Size(224, 22)
        Me.mnuCHG.Text = "Command Help Guide"
        '
        'mnuUTP
        '
        Me.mnuUTP.Name = "mnuUTP"
        Me.mnuUTP.Size = New System.Drawing.Size(224, 22)
        Me.mnuUTP.Text = "Using The Program"
        '
        'mnuNGTB
        '
        Me.mnuNGTB.Name = "mnuNGTB"
        Me.mnuNGTB.Size = New System.Drawing.Size(224, 22)
        Me.mnuNGTB.Text = "Noobie Guide To Binds"
        '
        'mnuUHTW
        '
        Me.mnuUHTW.Name = "mnuUHTW"
        Me.mnuUHTW.Size = New System.Drawing.Size(224, 22)
        Me.mnuUHTW.Text = "Understand How This Works"
        '
        'mnuBlank1
        '
        Me.mnuBlank1.Enabled = False
        Me.mnuBlank1.Name = "mnuBlank1"
        Me.mnuBlank1.Size = New System.Drawing.Size(22, 20)
        Me.mnuBlank1.Text = "|"
        '
        'mnuLP
        '
        Me.mnuLP.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLPHome, Me.mnuLPForums, Me.mnuLPRules, Me.mnuLPBT})
        Me.mnuLP.ForeColor = System.Drawing.Color.Black
        Me.mnuLP.Name = "mnuLP"
        Me.mnuLP.Size = New System.Drawing.Size(75, 20)
        Me.mnuLP.Text = "Life Punch"
        '
        'mnuLPHome
        '
        Me.mnuLPHome.Name = "mnuLPHome"
        Me.mnuLPHome.Size = New System.Drawing.Size(142, 22)
        Me.mnuLPHome.Text = "Home"
        '
        'mnuLPForums
        '
        Me.mnuLPForums.Name = "mnuLPForums"
        Me.mnuLPForums.Size = New System.Drawing.Size(142, 22)
        Me.mnuLPForums.Text = "Forums"
        '
        'mnuLPRules
        '
        Me.mnuLPRules.Name = "mnuLPRules"
        Me.mnuLPRules.Size = New System.Drawing.Size(142, 22)
        Me.mnuLPRules.Text = "Rules"
        '
        'mnuLPBT
        '
        Me.mnuLPBT.Name = "mnuLPBT"
        Me.mnuLPBT.Size = New System.Drawing.Size(142, 22)
        Me.mnuLPBT.Text = "Bind Tutorial"
        '
        'mnuBlank2
        '
        Me.mnuBlank2.Enabled = False
        Me.mnuBlank2.Name = "mnuBlank2"
        Me.mnuBlank2.Size = New System.Drawing.Size(22, 20)
        Me.mnuBlank2.Text = "|"
        '
        'lblCFS
        '
        Me.lblCFS.AutoSize = True
        Me.lblCFS.BackColor = System.Drawing.Color.Transparent
        Me.lblCFS.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCFS.ForeColor = System.Drawing.Color.White
        Me.lblCFS.Location = New System.Drawing.Point(12, 33)
        Me.lblCFS.Name = "lblCFS"
        Me.lblCFS.Size = New System.Drawing.Size(116, 16)
        Me.lblCFS.TabIndex = 10
        Me.lblCFS.Text = "Current Selected File : "
        '
        'mnuCFU
        '
        Me.mnuCFU.ForeColor = System.Drawing.Color.Black
        Me.mnuCFU.Name = "mnuCFU"
        Me.mnuCFU.Size = New System.Drawing.Size(118, 20)
        Me.mnuCFU.Text = "Check For Updates"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(649, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClearList)
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.lblFileLocation)
        Me.Controls.Add(Me.lblCFS)
        Me.Controls.Add(Me.btnEditSelected)
        Me.Controls.Add(Me.btnSaveAs)
        Me.Controls.Add(Me.btnSaveFile)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.lstFile)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Bind Manager - vDev - By: Agentsix1 - http://lifepunch.net"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstFile As System.Windows.Forms.ListBox
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveFile As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
    Friend WithEvents btnEditSelected As System.Windows.Forms.Button
    Friend WithEvents lblFileLocation As System.Windows.Forms.Label
    Friend WithEvents btnDeleteSelected As System.Windows.Forms.Button
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnOutBindToText As System.Windows.Forms.Button
    Friend WithEvents btnAddBind As System.Windows.Forms.Button
    Friend WithEvents cbCommands1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbKeys1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCommands4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCommands3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCommands2 As System.Windows.Forms.ComboBox
    Friend WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblCFS As System.Windows.Forms.Label
    Friend WithEvents mnuOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCHG As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUTP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuUHTW As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNGTB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlank1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLP As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlank2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NonKeyOTT As System.Windows.Forms.Button
    Friend WithEvents NonKeyATBL As System.Windows.Forms.Button
    Friend WithEvents cbCommands5 As System.Windows.Forms.ComboBox
    Friend WithEvents btnRASCP As System.Windows.Forms.Button
    Friend WithEvents btnRBSCP As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents llLifepunch As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuLPHome As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLPForums As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLPRules As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLPBT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbCommands6 As System.Windows.Forms.ComboBox
    Friend WithEvents mnuCFU As System.Windows.Forms.ToolStripMenuItem

End Class
