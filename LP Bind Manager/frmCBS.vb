Public Class frmCBS

    Public Shared StartGeneration As Integer
    Dim Script As String = ""
    Dim Generated As Boolean = False
    Private Sub frmCBS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmCBScbKey()
    End Sub

    Private Sub btnABTL_Click(sender As Object, e As EventArgs) Handles btnABTL.Click
        Dim cont As Boolean = True
        If cbCommands1.Text = "" Or cbCommands1.Text = "Select Command" Or cbCommands2.Text = "" Or cbCommands2.Text = "Select Command" Or cbCommands3.Text = "" Or cbCommands3.Text = "Select Command" Or cbCommands4.Text = "" Or cbCommands4.Text = "Select Command" Then
            MsgBox("No key/command was selected to create bind.", MsgBoxStyle.Information, "Failed to add bind")
            cont = False
        End If
        Dim thebind As String
        If cont = True Then
            Dim command1 As Boolean = True
            Select Case cbCommands1.Text
                Case "None"
                    command1 = False
                Case "+use"
                Case "noclip"
                Case "+duck"
                Case "-duck"
                Case "+forward"
                Case "-forward"
                Case "+jump"
                Case "-jump"
                Case "+left"
                Case "-left"
                Case "+menu"
                Case "-menu"
                Case "+movedown"
                Case "-movedown"
                Case "+moveleft"
                Case "-moveleft"
                Case "+moveright"
                Case "-moveright"
                Case "+moveup"
                Case "-moveup"
                Case "+reload"
                Case "-reload"
                Case "+right"
                Case "-right"
                Case "+speed"
                Case "-speed"
                Case "+walk"
                Case "-walk"
                Case "buy_buff Disguise"
                Case "buy_buff Health"
                Case "buy_buff Knife"
                Case "buy_buff Pistol"
                Case "buy_buff Silent Killer"
                Case "buy_buff Speed"
                Case "buy_buff Team Radar"
                Case "cl_showfps ""0"""
                Case "cl_showfps ""1"""
                Case "cl_showfps ""2"""
                Case "demoui"
                Case "demoui2"
                Case "echo"
                Case "equip_chat_tag 1337"
                Case "equip_chat_tag Awesome face"
                Case "equip_chat_tag Batman"
                Case "equip_chat_tag Boss"
                Case "equip_chat_tag Cool"
                Case "equip_chat_tag default"
                Case "equip_chat_tag Fab"
                Case "equip_chat_tag Gay"
                Case "equip_chat_tag Hot"
                Case "equip_chat_tag Love"
                Case "equip_chat_tag Music"
                Case "equip_chat_tag Ninja"
                Case "equip_chat_tag Pokeball"
                Case "equip_chat_tag Rebel"
                Case "equip_chat_tag Rich"
                Case "equip_chat_tag Rusher"
                Case "equip_chat_tag Sexy"
                Case "equip_chat_tag SWAG"
                Case "equip_chat_tag Triforce"
                Case "equip_chat_tag Trollface"
                Case "equip_chat_tag U MAD tag"
                Case "equip_chat_tag Weed"
                Case "equip_chat_tag Win"
                Case "equip_chat_tag Wub Wub"
                Case "equip_chat_tag Yolo"
                Case "equip_hat Astronaut Helmut"
                Case "equip_hat Baby Face Replacement"
                Case "equip_hat Belicopter Bomb"
                Case "equip_hat Blue Barrel"
                Case "equip_hat Box Head"
                Case "equip_hat Bucket Head"
                Case "equip_hat Cake hat"
                Case "equip_hat Cash register"
                Case "equip_hat Combine Moniter"
                Case "equip_hat Cone Head"
                Case "equip_hat Creeper Hat"
                Case "equip_hat Deadmau5 hat"
                Case "equip_hat Deal Eith It"
                Case "equip_hat Explosive Barrel"
                Case "equip_hat Fedora"
                Case "equip_hat Guy Fawkes Mask"
                Case "equip_hat Headcrab"
                Case "equip_hat KFC Bucket"
                Case "equip_hat Lamp shade"
                Case "equip_hat Penis statue"
                Case "equip_hat Pirate Hat"
                Case "equip_hat Planet globe"
                Case "equip_hat Pokeball Hat"
                Case "equip_hat Pot Head"
                Case "equip_hat Russian Hat"
                Case "equip_hat Santa Hat"
                Case "equip_hat Shoe Hat"
                Case "equip_hat Skull Head"
                Case "equip_hat Snowman Head"
                Case "equip_hat Stove"
                Case "equip_hat Television Head"
                Case "equip_hat Top hatte"
                Case "equip_hat Vaultboy Head"
                Case "equip_hat Viking Hat"
                Case "equip_hat Washing machine"
                Case "equip_hat Watermelon Head"
                Case "equip_hat Wizard hatte"
                Case "equip_model Altair"
                Case "equip_model Alyx"
                Case "equip_model Aower Armor Outcast"
                Case "equip_model Batman"
                Case "equip_model Billy"
                Case "equip_model Doctor breen"
                Case "equip_model Doctor Kleiner"
                Case "equip_model Eli"
                Case "equip_model Father grigori"
                Case "equip_model Female Citizen 1"
                Case "equip_model Female Citizen 2"
                Case "equip_model Female Citizen 3"
                Case "equip_model Female Citizen 4"
                Case "equip_model Female Citizen 5"
                Case "equip_model Female Citizen 6"
                Case "equip_model Female Rebel 1"
                Case "equip_model Female Rebel 2"
                Case "equip_model Female Rebel 3"
                Case "equip_model GMan"
                Case "equip_model Hitler"
                Case "equip_model HLFLF Armor"
                Case "equip_model Jack Sparrow"
                Case "equip_model Jason Brody"
                Case "equip_model Lara Croft"
                Case "equip_model Liberty Prime"
                Case "equip_model Male Citizen 1"
                Case "equip_model Male Citizen 2"
                Case "equip_model Male Citizen 4"
                Case "equip_model Male Citizen 5"
                Case "equip_model Male Citizen 6"
                Case "equip_model Male Rebel 1"
                Case "equip_model Male Rebel 2"
                Case "equip_model Male Rebel 3"
                Case "equip_model Mossman"
                Case "equip_model Osama Ben Laden"
                Case "equip_model Renamon"
                Case "equip_model Robocop"
                Case "equip_model Rorschach"
                Case "equip_model Skeleton Soldier"
                Case "equip_model T51B"
                Case "equip_model Tesla Power Armor"
                Case "equip_model Vaas"
                Case "equip_model Venom"
                Case "equip_model Zombie"
                Case "equip_trail 8bit One Up Shroom Trail"
                Case "equip_trail Australia"
                Case "equip_trail Awesome"
                Case "equip_trail Black Beam"
                Case "equip_trail Blue Beam"
                Case "equip_trail Canada"
                Case "equip_trail Dark Blue Beam"
                Case "equip_trail Default"
                Case "equip_trail Dollar"
                Case "equip_trail Electric"
                Case "equip_trail Evil Face"
                Case "equip_trail Footprints"
                Case "equip_trail GABEN"
                Case "equip_trail Germany"
                Case "equip_trail Green Beam"
                Case "equip_trail Happy face"
                Case "equip_trail Hearts"
                Case "equip_trail Italy"
                Case "equip_trail Lifepunch Logo"
                Case "equip_trail LOLOLO"
                Case "equip_trail Mario Hat Trail"
                Case "equip_trail Minecraf Dirt"
                Case "equip_trail Minecraft Brick"
                Case "equip_trail Minecraft Cobblestone"
                Case "equip_trail Minecraft Diamond"
                Case "equip_trail Minecraft Gold"
                Case "equip_trail Minecraft Grass"
                Case "equip_trail Minecraft TNT"
                Case "equip_trail Minecraft Track"
                Case "equip_trail Mnecraft Wood"
                Case "equip_trail Ninja"
                Case "equip_trail One Up Trail"
                Case "equip_trail Orange Beam"
                Case "equip_trail Pedobear"
                Case "equip_trail period-colored"
                Case "equip_trail Pikachu Trail"
                Case "equip_trail Pink Beam"
                Case "equip_trail Plasma"
                Case "equip_trail Pokeball Trail"
                Case "equip_trail Poland"
                Case "equip_trail Purple Beam"
                Case "equip_trail Rainbow"
                Case "equip_trail Scotland"
                Case "equip_trail Smoke"
                Case "equip_trail Speed"
                Case "equip_trail Trollfaec"
                Case "equip_trail Turd"
                Case "equip_trail UK"
                Case "equip_trail USA"
                Case "equip_trail Weed"
                Case "equip_trail White Beam"
                Case "equip_trail Yellow Beam"
                Case "equip_trail Ying Yang"
                Case "exec"
                Case "gm_showspare1"
                Case "gm_showspare2"
                Case "kill"
                Case "record"
                Case "stop"
                Case "say"
                Case "say_team"
                Case "slot1"
                Case "slot10"
                Case "slot2"
                Case "slot3"
                Case "slot4"
                Case "slot5"
                Case "slot6"
                Case "slot7"
                Case "slot8"
                Case "slot9"
                Case "undo"
                Case "use gg_ak47"
                Case "use gg_aug"
                Case "use gg_awp"
                Case "use gg_deagle"
                Case "use gg_elite"
                Case "use gg_fiveseven"
                Case "use gg_galil"
                Case "use gg_glock"
                Case "use gg_knife"
                Case "use gg_m249"
                Case "use gg_m3"
                Case "use gg_m4a1"
                Case "use gg_mac10"
                Case "use gg_mp5"
                Case "use gg_p228"
                Case "use gg_p90"
                Case "use gg_scout"
                Case "use gg_sg552"
                Case "use gg_tmp"
                Case "use gg_ump45"
                Case "use gg-xm1014"
                Case "use jb_ak47"
                Case "use jb_aug"
                Case "use jb_awp"
                Case "use jb_deagle"
                Case "use jb_dodgeballcannon"
                Case "use jb_fiveseven"
                Case "use jb_galil"
                Case "use jb_glock"
                Case "use jb_hands"
                Case "use jb_knife"
                Case "use jb_m249"
                Case "use jb_m3"
                Case "use jb_m4a1"
                Case "use jb_mac10"
                Case "use jb_medkit"
                Case "use jb_p228"
                Case "use jb_p90"
                Case "use jb_scout"
                Case "use jb_sg552"
                Case "use jb_stunbaton"
                Case "use jb_tmp"
                Case "use jb_tranquilizer"
                Case "use jb_usp"
                Case "use jb_weaponfrisker"
                Case "use lp_weapon_baseballbat"
                Case "use lp_weapon_chainsaw"
                Case "use lp_weapon_crowbar"
                Case "use lp_weapon_diamondsword"
                Case "use lp_weapon_fryingpan"
                Case "use lp_weapon_katana"
                Case "use lp_weapon_pickaxe"
                Case "use lp_weapon_pot"
                Case "use lp_weapon_scythe"
                Case "use_buff Disguise"
                Case "use_buff Health"
                Case "use_buff Knife"
                Case "use_buff Pistol"
                Case "use_buff Silent Killer"
                Case "use_buff Speed"
                Case "use_buff Team Radar"
                Case Else
                    command1 = False
            End Select

            Dim command2 As Boolean = True
            Select Case cbCommands2.Text
                Case "None"
                    command2 = False
                Case "+use"
                Case "noclip"
                Case "+duck"
                Case "-duck"
                Case "+forward"
                Case "-forward"
                Case "+jump"
                Case "-jump"
                Case "+left"
                Case "-left"
                Case "+menu"
                Case "-menu"
                Case "+movedown"
                Case "-movedown"
                Case "+moveleft"
                Case "-moveleft"
                Case "+moveright"
                Case "-moveright"
                Case "+moveup"
                Case "-moveup"
                Case "+reload"
                Case "-reload"
                Case "+right"
                Case "-right"
                Case "+speed"
                Case "-speed"
                Case "+walk"
                Case "-walk"
                Case "buy_buff Disguise"
                Case "buy_buff Health"
                Case "buy_buff Knife"
                Case "buy_buff Pistol"
                Case "buy_buff Silent Killer"
                Case "buy_buff Speed"
                Case "buy_buff Team Radar"
                Case "cl_showfps ""0"""
                Case "cl_showfps ""1"""
                Case "cl_showfps ""2"""
                Case "demoui"
                Case "demoui2"
                Case "echo"
                Case "equip_chat_tag 1337"
                Case "equip_chat_tag Awesome face"
                Case "equip_chat_tag Batman"
                Case "equip_chat_tag Boss"
                Case "equip_chat_tag Cool"
                Case "equip_chat_tag default"
                Case "equip_chat_tag Fab"
                Case "equip_chat_tag Gay"
                Case "equip_chat_tag Hot"
                Case "equip_chat_tag Love"
                Case "equip_chat_tag Music"
                Case "equip_chat_tag Ninja"
                Case "equip_chat_tag Pokeball"
                Case "equip_chat_tag Rebel"
                Case "equip_chat_tag Rich"
                Case "equip_chat_tag Rusher"
                Case "equip_chat_tag Sexy"
                Case "equip_chat_tag SWAG"
                Case "equip_chat_tag Triforce"
                Case "equip_chat_tag Trollface"
                Case "equip_chat_tag U MAD tag"
                Case "equip_chat_tag Weed"
                Case "equip_chat_tag Win"
                Case "equip_chat_tag Wub Wub"
                Case "equip_chat_tag Yolo"
                Case "equip_hat Astronaut Helmut"
                Case "equip_hat Baby Face Replacement"
                Case "equip_hat Belicopter Bomb"
                Case "equip_hat Blue Barrel"
                Case "equip_hat Box Head"
                Case "equip_hat Bucket Head"
                Case "equip_hat Cake hat"
                Case "equip_hat Cash register"
                Case "equip_hat Combine Moniter"
                Case "equip_hat Cone Head"
                Case "equip_hat Creeper Hat"
                Case "equip_hat Deadmau5 hat"
                Case "equip_hat Deal Eith It"
                Case "equip_hat Explosive Barrel"
                Case "equip_hat Fedora"
                Case "equip_hat Guy Fawkes Mask"
                Case "equip_hat Headcrab"
                Case "equip_hat KFC Bucket"
                Case "equip_hat Lamp shade"
                Case "equip_hat Penis statue"
                Case "equip_hat Pirate Hat"
                Case "equip_hat Planet globe"
                Case "equip_hat Pokeball Hat"
                Case "equip_hat Pot Head"
                Case "equip_hat Russian Hat"
                Case "equip_hat Santa Hat"
                Case "equip_hat Shoe Hat"
                Case "equip_hat Skull Head"
                Case "equip_hat Snowman Head"
                Case "equip_hat Stove"
                Case "equip_hat Television Head"
                Case "equip_hat Top hatte"
                Case "equip_hat Vaultboy Head"
                Case "equip_hat Viking Hat"
                Case "equip_hat Washing machine"
                Case "equip_hat Watermelon Head"
                Case "equip_hat Wizard hatte"
                Case "equip_model Altair"
                Case "equip_model Alyx"
                Case "equip_model Aower Armor Outcast"
                Case "equip_model Batman"
                Case "equip_model Billy"
                Case "equip_model Doctor breen"
                Case "equip_model Doctor Kleiner"
                Case "equip_model Eli"
                Case "equip_model Father grigori"
                Case "equip_model Female Citizen 1"
                Case "equip_model Female Citizen 2"
                Case "equip_model Female Citizen 3"
                Case "equip_model Female Citizen 4"
                Case "equip_model Female Citizen 5"
                Case "equip_model Female Citizen 6"
                Case "equip_model Female Rebel 1"
                Case "equip_model Female Rebel 2"
                Case "equip_model Female Rebel 3"
                Case "equip_model GMan"
                Case "equip_model Hitler"
                Case "equip_model HLFLF Armor"
                Case "equip_model Jack Sparrow"
                Case "equip_model Jason Brody"
                Case "equip_model Lara Croft"
                Case "equip_model Liberty Prime"
                Case "equip_model Male Citizen 1"
                Case "equip_model Male Citizen 2"
                Case "equip_model Male Citizen 4"
                Case "equip_model Male Citizen 5"
                Case "equip_model Male Citizen 6"
                Case "equip_model Male Rebel 1"
                Case "equip_model Male Rebel 2"
                Case "equip_model Male Rebel 3"
                Case "equip_model Mossman"
                Case "equip_model Osama Ben Laden"
                Case "equip_model Renamon"
                Case "equip_model Robocop"
                Case "equip_model Rorschach"
                Case "equip_model Skeleton Soldier"
                Case "equip_model T51B"
                Case "equip_model Tesla Power Armor"
                Case "equip_model Vaas"
                Case "equip_model Venom"
                Case "equip_model Zombie"
                Case "equip_trail 8bit One Up Shroom Trail"
                Case "equip_trail Australia"
                Case "equip_trail Awesome"
                Case "equip_trail Black Beam"
                Case "equip_trail Blue Beam"
                Case "equip_trail Canada"
                Case "equip_trail Dark Blue Beam"
                Case "equip_trail Default"
                Case "equip_trail Dollar"
                Case "equip_trail Electric"
                Case "equip_trail Evil Face"
                Case "equip_trail Footprints"
                Case "equip_trail GABEN"
                Case "equip_trail Germany"
                Case "equip_trail Green Beam"
                Case "equip_trail Happy face"
                Case "equip_trail Hearts"
                Case "equip_trail Italy"
                Case "equip_trail Lifepunch Logo"
                Case "equip_trail LOLOLO"
                Case "equip_trail Mario Hat Trail"
                Case "equip_trail Minecraf Dirt"
                Case "equip_trail Minecraft Brick"
                Case "equip_trail Minecraft Cobblestone"
                Case "equip_trail Minecraft Diamond"
                Case "equip_trail Minecraft Gold"
                Case "equip_trail Minecraft Grass"
                Case "equip_trail Minecraft TNT"
                Case "equip_trail Minecraft Track"
                Case "equip_trail Mnecraft Wood"
                Case "equip_trail Ninja"
                Case "equip_trail One Up Trail"
                Case "equip_trail Orange Beam"
                Case "equip_trail Pedobear"
                Case "equip_trail period-colored"
                Case "equip_trail Pikachu Trail"
                Case "equip_trail Pink Beam"
                Case "equip_trail Plasma"
                Case "equip_trail Pokeball Trail"
                Case "equip_trail Poland"
                Case "equip_trail Purple Beam"
                Case "equip_trail Rainbow"
                Case "equip_trail Scotland"
                Case "equip_trail Smoke"
                Case "equip_trail Speed"
                Case "equip_trail Trollfaec"
                Case "equip_trail Turd"
                Case "equip_trail UK"
                Case "equip_trail USA"
                Case "equip_trail Weed"
                Case "equip_trail White Beam"
                Case "equip_trail Yellow Beam"
                Case "equip_trail Ying Yang"
                Case "exec"
                Case "gm_showspare1"
                Case "gm_showspare2"
                Case "kill"
                Case "record"
                Case "stop"
                Case "say"
                Case "say_team"
                Case "slot1"
                Case "slot10"
                Case "slot2"
                Case "slot3"
                Case "slot4"
                Case "slot5"
                Case "slot6"
                Case "slot7"
                Case "slot8"
                Case "slot9"
                Case "undo"
                Case "use gg_ak47"
                Case "use gg_aug"
                Case "use gg_awp"
                Case "use gg_deagle"
                Case "use gg_elite"
                Case "use gg_fiveseven"
                Case "use gg_galil"
                Case "use gg_glock"
                Case "use gg_knife"
                Case "use gg_m249"
                Case "use gg_m3"
                Case "use gg_m4a1"
                Case "use gg_mac10"
                Case "use gg_mp5"
                Case "use gg_p228"
                Case "use gg_p90"
                Case "use gg_scout"
                Case "use gg_sg552"
                Case "use gg_tmp"
                Case "use gg_ump45"
                Case "use gg-xm1014"
                Case "use jb_ak47"
                Case "use jb_aug"
                Case "use jb_awp"
                Case "use jb_deagle"
                Case "use jb_dodgeballcannon"
                Case "use jb_fiveseven"
                Case "use jb_galil"
                Case "use jb_glock"
                Case "use jb_hands"
                Case "use jb_knife"
                Case "use jb_m249"
                Case "use jb_m3"
                Case "use jb_m4a1"
                Case "use jb_mac10"
                Case "use jb_medkit"
                Case "use jb_p228"
                Case "use jb_p90"
                Case "use jb_scout"
                Case "use jb_sg552"
                Case "use jb_stunbaton"
                Case "use jb_tmp"
                Case "use jb_tranquilizer"
                Case "use jb_usp"
                Case "use jb_weaponfrisker"
                Case "use lp_weapon_baseballbat"
                Case "use lp_weapon_chainsaw"
                Case "use lp_weapon_crowbar"
                Case "use lp_weapon_diamondsword"
                Case "use lp_weapon_fryingpan"
                Case "use lp_weapon_katana"
                Case "use lp_weapon_pickaxe"
                Case "use lp_weapon_pot"
                Case "use lp_weapon_scythe"
                Case "use_buff Disguise"
                Case "use_buff Health"
                Case "use_buff Knife"
                Case "use_buff Pistol"
                Case "use_buff Silent Killer"
                Case "use_buff Speed"
                Case "use_buff Team Radar"
                Case Else
                    command2 = False
            End Select

            Dim command3 As Boolean = True
            Select Case cbCommands3.Text
                Case "None"
                    command3 = False
                Case "+use"
                Case "noclip"
                Case "+duck"
                Case "-duck"
                Case "+forward"
                Case "-forward"
                Case "+jump"
                Case "-jump"
                Case "+left"
                Case "-left"
                Case "+menu"
                Case "-menu"
                Case "+movedown"
                Case "-movedown"
                Case "+moveleft"
                Case "-moveleft"
                Case "+moveright"
                Case "-moveright"
                Case "+moveup"
                Case "-moveup"
                Case "+reload"
                Case "-reload"
                Case "+right"
                Case "-right"
                Case "+speed"
                Case "-speed"
                Case "+walk"
                Case "-walk"
                Case "buy_buff Disguise"
                Case "buy_buff Health"
                Case "buy_buff Knife"
                Case "buy_buff Pistol"
                Case "buy_buff Silent Killer"
                Case "buy_buff Speed"
                Case "buy_buff Team Radar"
                Case "cl_showfps ""0"""
                Case "cl_showfps ""1"""
                Case "cl_showfps ""2"""
                Case "demoui"
                Case "demoui2"
                Case "echo"
                Case "equip_chat_tag 1337"
                Case "equip_chat_tag Awesome face"
                Case "equip_chat_tag Batman"
                Case "equip_chat_tag Boss"
                Case "equip_chat_tag Cool"
                Case "equip_chat_tag default"
                Case "equip_chat_tag Fab"
                Case "equip_chat_tag Gay"
                Case "equip_chat_tag Hot"
                Case "equip_chat_tag Love"
                Case "equip_chat_tag Music"
                Case "equip_chat_tag Ninja"
                Case "equip_chat_tag Pokeball"
                Case "equip_chat_tag Rebel"
                Case "equip_chat_tag Rich"
                Case "equip_chat_tag Rusher"
                Case "equip_chat_tag Sexy"
                Case "equip_chat_tag SWAG"
                Case "equip_chat_tag Triforce"
                Case "equip_chat_tag Trollface"
                Case "equip_chat_tag U MAD tag"
                Case "equip_chat_tag Weed"
                Case "equip_chat_tag Win"
                Case "equip_chat_tag Wub Wub"
                Case "equip_chat_tag Yolo"
                Case "equip_hat Astronaut Helmut"
                Case "equip_hat Baby Face Replacement"
                Case "equip_hat Belicopter Bomb"
                Case "equip_hat Blue Barrel"
                Case "equip_hat Box Head"
                Case "equip_hat Bucket Head"
                Case "equip_hat Cake hat"
                Case "equip_hat Cash register"
                Case "equip_hat Combine Moniter"
                Case "equip_hat Cone Head"
                Case "equip_hat Creeper Hat"
                Case "equip_hat Deadmau5 hat"
                Case "equip_hat Deal Eith It"
                Case "equip_hat Explosive Barrel"
                Case "equip_hat Fedora"
                Case "equip_hat Guy Fawkes Mask"
                Case "equip_hat Headcrab"
                Case "equip_hat KFC Bucket"
                Case "equip_hat Lamp shade"
                Case "equip_hat Penis statue"
                Case "equip_hat Pirate Hat"
                Case "equip_hat Planet globe"
                Case "equip_hat Pokeball Hat"
                Case "equip_hat Pot Head"
                Case "equip_hat Russian Hat"
                Case "equip_hat Santa Hat"
                Case "equip_hat Shoe Hat"
                Case "equip_hat Skull Head"
                Case "equip_hat Snowman Head"
                Case "equip_hat Stove"
                Case "equip_hat Television Head"
                Case "equip_hat Top hatte"
                Case "equip_hat Vaultboy Head"
                Case "equip_hat Viking Hat"
                Case "equip_hat Washing machine"
                Case "equip_hat Watermelon Head"
                Case "equip_hat Wizard hatte"
                Case "equip_model Altair"
                Case "equip_model Alyx"
                Case "equip_model Aower Armor Outcast"
                Case "equip_model Batman"
                Case "equip_model Billy"
                Case "equip_model Doctor breen"
                Case "equip_model Doctor Kleiner"
                Case "equip_model Eli"
                Case "equip_model Father grigori"
                Case "equip_model Female Citizen 1"
                Case "equip_model Female Citizen 2"
                Case "equip_model Female Citizen 3"
                Case "equip_model Female Citizen 4"
                Case "equip_model Female Citizen 5"
                Case "equip_model Female Citizen 6"
                Case "equip_model Female Rebel 1"
                Case "equip_model Female Rebel 2"
                Case "equip_model Female Rebel 3"
                Case "equip_model GMan"
                Case "equip_model Hitler"
                Case "equip_model HLFLF Armor"
                Case "equip_model Jack Sparrow"
                Case "equip_model Jason Brody"
                Case "equip_model Lara Croft"
                Case "equip_model Liberty Prime"
                Case "equip_model Male Citizen 1"
                Case "equip_model Male Citizen 2"
                Case "equip_model Male Citizen 4"
                Case "equip_model Male Citizen 5"
                Case "equip_model Male Citizen 6"
                Case "equip_model Male Rebel 1"
                Case "equip_model Male Rebel 2"
                Case "equip_model Male Rebel 3"
                Case "equip_model Mossman"
                Case "equip_model Osama Ben Laden"
                Case "equip_model Renamon"
                Case "equip_model Robocop"
                Case "equip_model Rorschach"
                Case "equip_model Skeleton Soldier"
                Case "equip_model T51B"
                Case "equip_model Tesla Power Armor"
                Case "equip_model Vaas"
                Case "equip_model Venom"
                Case "equip_model Zombie"
                Case "equip_trail 8bit One Up Shroom Trail"
                Case "equip_trail Australia"
                Case "equip_trail Awesome"
                Case "equip_trail Black Beam"
                Case "equip_trail Blue Beam"
                Case "equip_trail Canada"
                Case "equip_trail Dark Blue Beam"
                Case "equip_trail Default"
                Case "equip_trail Dollar"
                Case "equip_trail Electric"
                Case "equip_trail Evil Face"
                Case "equip_trail Footprints"
                Case "equip_trail GABEN"
                Case "equip_trail Germany"
                Case "equip_trail Green Beam"
                Case "equip_trail Happy face"
                Case "equip_trail Hearts"
                Case "equip_trail Italy"
                Case "equip_trail Lifepunch Logo"
                Case "equip_trail LOLOLO"
                Case "equip_trail Mario Hat Trail"
                Case "equip_trail Minecraf Dirt"
                Case "equip_trail Minecraft Brick"
                Case "equip_trail Minecraft Cobblestone"
                Case "equip_trail Minecraft Diamond"
                Case "equip_trail Minecraft Gold"
                Case "equip_trail Minecraft Grass"
                Case "equip_trail Minecraft TNT"
                Case "equip_trail Minecraft Track"
                Case "equip_trail Mnecraft Wood"
                Case "equip_trail Ninja"
                Case "equip_trail One Up Trail"
                Case "equip_trail Orange Beam"
                Case "equip_trail Pedobear"
                Case "equip_trail period-colored"
                Case "equip_trail Pikachu Trail"
                Case "equip_trail Pink Beam"
                Case "equip_trail Plasma"
                Case "equip_trail Pokeball Trail"
                Case "equip_trail Poland"
                Case "equip_trail Purple Beam"
                Case "equip_trail Rainbow"
                Case "equip_trail Scotland"
                Case "equip_trail Smoke"
                Case "equip_trail Speed"
                Case "equip_trail Trollfaec"
                Case "equip_trail Turd"
                Case "equip_trail UK"
                Case "equip_trail USA"
                Case "equip_trail Weed"
                Case "equip_trail White Beam"
                Case "equip_trail Yellow Beam"
                Case "equip_trail Ying Yang"
                Case "exec"
                Case "gm_showspare1"
                Case "gm_showspare2"
                Case "kill"
                Case "record"
                Case "stop"
                Case "say"
                Case "say_team"
                Case "slot1"
                Case "slot10"
                Case "slot2"
                Case "slot3"
                Case "slot4"
                Case "slot5"
                Case "slot6"
                Case "slot7"
                Case "slot8"
                Case "slot9"
                Case "undo"
                Case "use gg_ak47"
                Case "use gg_aug"
                Case "use gg_awp"
                Case "use gg_deagle"
                Case "use gg_elite"
                Case "use gg_fiveseven"
                Case "use gg_galil"
                Case "use gg_glock"
                Case "use gg_knife"
                Case "use gg_m249"
                Case "use gg_m3"
                Case "use gg_m4a1"
                Case "use gg_mac10"
                Case "use gg_mp5"
                Case "use gg_p228"
                Case "use gg_p90"
                Case "use gg_scout"
                Case "use gg_sg552"
                Case "use gg_tmp"
                Case "use gg_ump45"
                Case "use gg-xm1014"
                Case "use jb_ak47"
                Case "use jb_aug"
                Case "use jb_awp"
                Case "use jb_deagle"
                Case "use jb_dodgeballcannon"
                Case "use jb_fiveseven"
                Case "use jb_galil"
                Case "use jb_glock"
                Case "use jb_hands"
                Case "use jb_knife"
                Case "use jb_m249"
                Case "use jb_m3"
                Case "use jb_m4a1"
                Case "use jb_mac10"
                Case "use jb_medkit"
                Case "use jb_p228"
                Case "use jb_p90"
                Case "use jb_scout"
                Case "use jb_sg552"
                Case "use jb_stunbaton"
                Case "use jb_tmp"
                Case "use jb_tranquilizer"
                Case "use jb_usp"
                Case "use jb_weaponfrisker"
                Case "use lp_weapon_baseballbat"
                Case "use lp_weapon_chainsaw"
                Case "use lp_weapon_crowbar"
                Case "use lp_weapon_diamondsword"
                Case "use lp_weapon_fryingpan"
                Case "use lp_weapon_katana"
                Case "use lp_weapon_pickaxe"
                Case "use lp_weapon_pot"
                Case "use lp_weapon_scythe"
                Case "use_buff Disguise"
                Case "use_buff Health"
                Case "use_buff Knife"
                Case "use_buff Pistol"
                Case "use_buff Silent Killer"
                Case "use_buff Speed"
                Case "use_buff Team Radar"
                Case Else
                    command3 = False
            End Select

            Dim command4 As Boolean = True
            Select Case cbCommands4.Text
                Case "None"
                    command4 = False
                Case "+use"
                Case "noclip"
                Case "+duck"
                Case "-duck"
                Case "+forward"
                Case "-forward"
                Case "+jump"
                Case "-jump"
                Case "+left"
                Case "-left"
                Case "+menu"
                Case "-menu"
                Case "+movedown"
                Case "-movedown"
                Case "+moveleft"
                Case "-moveleft"
                Case "+moveright"
                Case "-moveright"
                Case "+moveup"
                Case "-moveup"
                Case "+reload"
                Case "-reload"
                Case "+right"
                Case "-right"
                Case "+speed"
                Case "-speed"
                Case "+walk"
                Case "-walk"
                Case "buy_buff Disguise"
                Case "buy_buff Health"
                Case "buy_buff Knife"
                Case "buy_buff Pistol"
                Case "buy_buff Silent Killer"
                Case "buy_buff Speed"
                Case "buy_buff Team Radar"
                Case "cl_showfps ""0"""
                Case "cl_showfps ""1"""
                Case "cl_showfps ""2"""
                Case "demoui"
                Case "demoui2"
                Case "echo"
                Case "equip_chat_tag 1337"
                Case "equip_chat_tag Awesome face"
                Case "equip_chat_tag Batman"
                Case "equip_chat_tag Boss"
                Case "equip_chat_tag Cool"
                Case "equip_chat_tag default"
                Case "equip_chat_tag Fab"
                Case "equip_chat_tag Gay"
                Case "equip_chat_tag Hot"
                Case "equip_chat_tag Love"
                Case "equip_chat_tag Music"
                Case "equip_chat_tag Ninja"
                Case "equip_chat_tag Pokeball"
                Case "equip_chat_tag Rebel"
                Case "equip_chat_tag Rich"
                Case "equip_chat_tag Rusher"
                Case "equip_chat_tag Sexy"
                Case "equip_chat_tag SWAG"
                Case "equip_chat_tag Triforce"
                Case "equip_chat_tag Trollface"
                Case "equip_chat_tag U MAD tag"
                Case "equip_chat_tag Weed"
                Case "equip_chat_tag Win"
                Case "equip_chat_tag Wub Wub"
                Case "equip_chat_tag Yolo"
                Case "equip_hat Astronaut Helmut"
                Case "equip_hat Baby Face Replacement"
                Case "equip_hat Belicopter Bomb"
                Case "equip_hat Blue Barrel"
                Case "equip_hat Box Head"
                Case "equip_hat Bucket Head"
                Case "equip_hat Cake hat"
                Case "equip_hat Cash register"
                Case "equip_hat Combine Moniter"
                Case "equip_hat Cone Head"
                Case "equip_hat Creeper Hat"
                Case "equip_hat Deadmau5 hat"
                Case "equip_hat Deal Eith It"
                Case "equip_hat Explosive Barrel"
                Case "equip_hat Fedora"
                Case "equip_hat Guy Fawkes Mask"
                Case "equip_hat Headcrab"
                Case "equip_hat KFC Bucket"
                Case "equip_hat Lamp shade"
                Case "equip_hat Penis statue"
                Case "equip_hat Pirate Hat"
                Case "equip_hat Planet globe"
                Case "equip_hat Pokeball Hat"
                Case "equip_hat Pot Head"
                Case "equip_hat Russian Hat"
                Case "equip_hat Santa Hat"
                Case "equip_hat Shoe Hat"
                Case "equip_hat Skull Head"
                Case "equip_hat Snowman Head"
                Case "equip_hat Stove"
                Case "equip_hat Television Head"
                Case "equip_hat Top hatte"
                Case "equip_hat Vaultboy Head"
                Case "equip_hat Viking Hat"
                Case "equip_hat Washing machine"
                Case "equip_hat Watermelon Head"
                Case "equip_hat Wizard hatte"
                Case "equip_model Altair"
                Case "equip_model Alyx"
                Case "equip_model Aower Armor Outcast"
                Case "equip_model Batman"
                Case "equip_model Billy"
                Case "equip_model Doctor breen"
                Case "equip_model Doctor Kleiner"
                Case "equip_model Eli"
                Case "equip_model Father grigori"
                Case "equip_model Female Citizen 1"
                Case "equip_model Female Citizen 2"
                Case "equip_model Female Citizen 3"
                Case "equip_model Female Citizen 4"
                Case "equip_model Female Citizen 5"
                Case "equip_model Female Citizen 6"
                Case "equip_model Female Rebel 1"
                Case "equip_model Female Rebel 2"
                Case "equip_model Female Rebel 3"
                Case "equip_model GMan"
                Case "equip_model Hitler"
                Case "equip_model HLFLF Armor"
                Case "equip_model Jack Sparrow"
                Case "equip_model Jason Brody"
                Case "equip_model Lara Croft"
                Case "equip_model Liberty Prime"
                Case "equip_model Male Citizen 1"
                Case "equip_model Male Citizen 2"
                Case "equip_model Male Citizen 4"
                Case "equip_model Male Citizen 5"
                Case "equip_model Male Citizen 6"
                Case "equip_model Male Rebel 1"
                Case "equip_model Male Rebel 2"
                Case "equip_model Male Rebel 3"
                Case "equip_model Mossman"
                Case "equip_model Osama Ben Laden"
                Case "equip_model Renamon"
                Case "equip_model Robocop"
                Case "equip_model Rorschach"
                Case "equip_model Skeleton Soldier"
                Case "equip_model T51B"
                Case "equip_model Tesla Power Armor"
                Case "equip_model Vaas"
                Case "equip_model Venom"
                Case "equip_model Zombie"
                Case "equip_trail 8bit One Up Shroom Trail"
                Case "equip_trail Australia"
                Case "equip_trail Awesome"
                Case "equip_trail Black Beam"
                Case "equip_trail Blue Beam"
                Case "equip_trail Canada"
                Case "equip_trail Dark Blue Beam"
                Case "equip_trail Default"
                Case "equip_trail Dollar"
                Case "equip_trail Electric"
                Case "equip_trail Evil Face"
                Case "equip_trail Footprints"
                Case "equip_trail GABEN"
                Case "equip_trail Germany"
                Case "equip_trail Green Beam"
                Case "equip_trail Happy face"
                Case "equip_trail Hearts"
                Case "equip_trail Italy"
                Case "equip_trail Lifepunch Logo"
                Case "equip_trail LOLOLO"
                Case "equip_trail Mario Hat Trail"
                Case "equip_trail Minecraf Dirt"
                Case "equip_trail Minecraft Brick"
                Case "equip_trail Minecraft Cobblestone"
                Case "equip_trail Minecraft Diamond"
                Case "equip_trail Minecraft Gold"
                Case "equip_trail Minecraft Grass"
                Case "equip_trail Minecraft TNT"
                Case "equip_trail Minecraft Track"
                Case "equip_trail Mnecraft Wood"
                Case "equip_trail Ninja"
                Case "equip_trail One Up Trail"
                Case "equip_trail Orange Beam"
                Case "equip_trail Pedobear"
                Case "equip_trail period-colored"
                Case "equip_trail Pikachu Trail"
                Case "equip_trail Pink Beam"
                Case "equip_trail Plasma"
                Case "equip_trail Pokeball Trail"
                Case "equip_trail Poland"
                Case "equip_trail Purple Beam"
                Case "equip_trail Rainbow"
                Case "equip_trail Scotland"
                Case "equip_trail Smoke"
                Case "equip_trail Speed"
                Case "equip_trail Trollfaec"
                Case "equip_trail Turd"
                Case "equip_trail UK"
                Case "equip_trail USA"
                Case "equip_trail Weed"
                Case "equip_trail White Beam"
                Case "equip_trail Yellow Beam"
                Case "equip_trail Ying Yang"
                Case "exec"
                Case "gm_showspare1"
                Case "gm_showspare2"
                Case "kill"
                Case "record"
                Case "stop"
                Case "say"
                Case "say_team"
                Case "slot1"
                Case "slot10"
                Case "slot2"
                Case "slot3"
                Case "slot4"
                Case "slot5"
                Case "slot6"
                Case "slot7"
                Case "slot8"
                Case "slot9"
                Case "undo"
                Case "use gg_ak47"
                Case "use gg_aug"
                Case "use gg_awp"
                Case "use gg_deagle"
                Case "use gg_elite"
                Case "use gg_fiveseven"
                Case "use gg_galil"
                Case "use gg_glock"
                Case "use gg_knife"
                Case "use gg_m249"
                Case "use gg_m3"
                Case "use gg_m4a1"
                Case "use gg_mac10"
                Case "use gg_mp5"
                Case "use gg_p228"
                Case "use gg_p90"
                Case "use gg_scout"
                Case "use gg_sg552"
                Case "use gg_tmp"
                Case "use gg_ump45"
                Case "use gg-xm1014"
                Case "use jb_ak47"
                Case "use jb_aug"
                Case "use jb_awp"
                Case "use jb_deagle"
                Case "use jb_dodgeballcannon"
                Case "use jb_fiveseven"
                Case "use jb_galil"
                Case "use jb_glock"
                Case "use jb_hands"
                Case "use jb_knife"
                Case "use jb_m249"
                Case "use jb_m3"
                Case "use jb_m4a1"
                Case "use jb_mac10"
                Case "use jb_medkit"
                Case "use jb_p228"
                Case "use jb_p90"
                Case "use jb_scout"
                Case "use jb_sg552"
                Case "use jb_stunbaton"
                Case "use jb_tmp"
                Case "use jb_tranquilizer"
                Case "use jb_usp"
                Case "use jb_weaponfrisker"
                Case "use lp_weapon_baseballbat"
                Case "use lp_weapon_chainsaw"
                Case "use lp_weapon_crowbar"
                Case "use lp_weapon_diamondsword"
                Case "use lp_weapon_fryingpan"
                Case "use lp_weapon_katana"
                Case "use lp_weapon_pickaxe"
                Case "use lp_weapon_pot"
                Case "use lp_weapon_scythe"
                Case "use_buff Disguise"
                Case "use_buff Health"
                Case "use_buff Knife"
                Case "use_buff Pistol"
                Case "use_buff Silent Killer"
                Case "use_buff Speed"
                Case "use_buff Team Radar"
                Case Else
                    command4 = False
            End Select
            Select Case command1
                Case True
                    Select Case cbCommands1.Text
                        Case "echo"
                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                        Case "say"
                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                        Case "say_team"
                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                        Case "exec"
                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                        Case "record"
                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                        Case Else
                            thebind = thebind & """" & cbCommands1.Text
                    End Select
                Case False
            End Select

            Select Case command2
                Case True
                    Select Case command1
                        Case True
                            Select Case cbCommands2.Text
                                Case "echo"
                                    Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands2.Text & " " & inputplease
                                Case "say"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands2.Text & " " & inputplease
                                Case "say_team"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands2.Text & " " & inputplease
                                Case "exec"
                                    Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                Case "record"
                                    Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                Case Else
                                    thebind = thebind & ";" & cbCommands2.Text
                            End Select
                        Case False
                            Select Case cbCommands2.Text
                                Case "echo"
                                    Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                    thebind = thebind & """" & cbCommands2.Text & " " & inputplease
                                Case "say"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                    thebind = thebind & """" & cbCommands2.Text & " " & inputplease
                                Case "say_team"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                    thebind = thebind & """" & cbCommands2.Text & " " & inputplease
                                Case "exec"
                                    Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                    thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                                Case "record"
                                    Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                    thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                                Case Else
                                    thebind = thebind & """" & cbCommands2.Text
                            End Select
                    End Select

            End Select

            Select Case command3
                Case True
                    Select Case command1
                        Case True
                            Select Case cbCommands3.Text
                                Case "echo"
                                    Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                Case "say"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                Case "say_team"
                                    Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                Case "exec"
                                    Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                Case "record"
                                    Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                Case Else
                                    thebind = thebind & ";" & cbCommands3.Text
                            End Select
                        Case False
                            Select Case command2
                                Case True
                                    Select Case cbCommands3.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands3.Text & " " & inputplease
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                        Case Else
                                            thebind = thebind & ";" & cbCommands3.Text
                                    End Select
                                Case False
                                    Select Case cbCommands3.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & """" & cbCommands3.Text & " " & inputplease
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & """" & cbCommands3.Text & " " & inputplease
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & """" & cbCommands3.Text & " " & inputplease
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & """" & cbCommands1.Text & " " & inputplease
                                        Case Else
                                            thebind = thebind & """" & cbCommands3.Text
                                    End Select
                            End Select
                    End Select
            End Select
            Select Case command4
                Case True
                    Select Case command3
                        Case True
                            Select Case command1
                                Case True
                                    Select Case cbCommands4.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease
                                        Case Else
                                            thebind = thebind & ";" & cbCommands4.Text & """"
                                    End Select
                                Case False
                                    Select Case command2
                                        Case True
                                            Select Case cbCommands4.Text
                                                Case "echo"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "say"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "say_team"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "exec"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                                Case "record"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                                Case Else
                                                    thebind = thebind & ";" & cbCommands4.Text & """"
                                            End Select
                                        Case False
                                            Select Case cbCommands4.Text
                                                Case "echo"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "say"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "say_team"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                                Case "exec"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                                Case "record"
                                                    Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                                    thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                                Case Else
                                                    thebind = thebind & ";" & cbCommands4.Text & """"
                                            End Select
                                    End Select
                                Case False
                                    Select Case cbCommands4.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case Else
                                            thebind = thebind & ";" & cbCommands4.Text & """"
                                    End Select
                            End Select
                        Case False

                            Select Case command2
                                Case True
                                    Select Case cbCommands4.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case Else
                                            thebind = thebind & ";" & cbCommands4.Text & """"
                                    End Select
                                Case False
                                    Select Case cbCommands4.Text
                                        Case "echo"
                                            Dim inputplease = InputBox("Please enter what you would like the 'echo' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "say_team"
                                            Dim inputplease = InputBox("Please enter what you would like the 'say_team' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands4.Text & " " & inputplease & """"
                                        Case "exec"
                                            Dim inputplease = InputBox("Please enter what you would like the 'exec' command should say", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case "record"
                                            Dim inputplease = InputBox("Please enter what you would like the 'record' command. !!!! ADD NO SPACES !!!!", "Getting text", "")
                                            thebind = thebind & ";" & cbCommands1.Text & " " & inputplease & """"
                                        Case Else
                                            thebind = thebind & ";" & cbCommands4.Text & """"
                                    End Select
                            End Select
                    End Select
                Case False
                    thebind = thebind & """"
            End Select

            lstBinds.Items.Add(thebind)
        End If
    End Sub

    Private Sub txtInstructions_TextChanged(sender As Object, e As EventArgs) Handles txtInstructions.TextChanged
        txtInstructions.Text = "1. Add a list of binds the to the list box above" & vbCrLf & "2. After you have completed adding everything you want to happen click 'Generate Script'" & vbCrLf & "3. Click 'Export Script To Text' or 'Export Script To File'"
    End Sub

    Private Sub btnGenerateScript_Click(sender As Object, e As EventArgs) Handles btnGenerateScript.Click
        If Generated = True Then
            MsgBox("Script has already been generating please export the current script before generated another. Generation Aborted!", vbInformation, "Generation Aborted")
            Exit Sub
        End If
        If cbKey1.Text = "" Or cbKey1.Text = "Select Key" Then
            MsgBox("No key was selected to be used for this script. Please add a key to be used then attempt to regerate the script. Generation Aborted", vbInformation, "Generation Aborted")
            Exit Sub
        End If
        If cbCommands1.Text = "" Or cbCommands1.Text = "Select Key" Or cbCommands2.Text = "" Or cbCommands2.Text = "Select Key" Or cbCommands3.Text = "" Or cbCommands3.Text = "Select Key" Or cbCommands4.Text = "" Or cbCommands4.Text = "Select Key" Then
            MsgBox("No command was selected to be used for this script. Please add a command to be used then attempt to regerate the script. Generation Aborted", vbInformation, "Generation Aborted")
            Exit Sub
        End If
        Dim nos
        Try
            If lstBinds.Items(0) = "" And lstBinds.Items(1) = "" Then
            End If
            Info_Grab_IB("Please select a name for your current script that you are generating. !!!! NO SPACES !!!!", _
                     "Create Script Name", "", True, "No name for the script was entered. Generation Aboted", "Generation Aborted")
            Dim prescript As String = ""
            Dim linenumber As Integer = 0
            For Each Item As Object In lstBinds.Items
                Script = Script & vbCrLf & prescript
                Dim splits() = Split(Item.ToString, """")
                nos = InputBoxOutput
                linenumber = linenumber + 1
                If linenumber = 1 Then
                    prescript = "alias " & nos & " """ & nos & linenumber & """" & vbCrLf & "alias " & nos & linenumber & " ""alias " & nos & " " & nos & linenumber + 1 & ";" & splits(1) & """" ' alias nos "alias nos#;command"' alias nos "nos1"
                Else
                    prescript = "alias " & nos & linenumber & " ""alias " & nos & " " & nos & linenumber + 1 & ";" & splits(1) & """" ' alias nos "alias nos#;command"
                End If
            Next
            Dim lastsplits() = Split(lstBinds.Items(linenumber - 1), """")
            prescript = "alias " & nos & linenumber & " ""alias " & nos & " " & nos & 1 & ";" & lastsplits(1) & """" ' alias nos "alias nos#;command"
            Script = Script & vbCrLf & prescript & vbCrLf & "bind " & cbKey1.Text & """" & nos & """"
            MsgBox("Script has been generated, you are welcome to export the script.", vbInformation, "Success")
            Generated = True
            btnESTF.Enabled = True
            btnESTT.Enabled = True
        Catch ex As Exception
            MsgBox("No binds were found to make script with. You are required to have at least 2 binds in the list box inorder to create a script.", vbExclamation, "Error")
        End Try

    End Sub

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        Try
            lstBinds.Items.RemoveAt(lstBinds.SelectedIndex)
        Catch ex As Exception
            MsgBox("No Items Selected", vbExclamation, "Item Not Found")
        End Try
    End Sub

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        lstBinds.Items.Clear()
        lstBinds.Refresh()
    End Sub

    Private Sub btnESTT_Click(sender As Object, e As EventArgs) Handles btnESTT.Click

    End Sub

    Private Sub btnESTF_Click(sender As Object, e As EventArgs) Handles btnESTF.Click
        Dim input = InputBox("Please type in the name of the file you would like to save this as. Example: autoexec", "Enter a file name", "filenamehere")
        If input.Length <> 0 Then
        Else
            Exit Sub
        End If


        If System.IO.File.Exists("C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg") Then
            Dim Result As DialogResult = MessageBox.Show("File already exists. Would you like top overwrite the current file?", "File already exsists", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
            If Result = Windows.Forms.DialogResult.Yes Then
                Dim FileNumber As Integer = FreeFile()
                FileOpen(FileNumber, "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg", OpenMode.Output)
                PrintLine(FileNumber, Script)
                FileClose(FileNumber)
                MsgBox("File has been Overwritten!", , "Saved")
            ElseIf Result = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Else
            Dim FileNumber As Integer = FreeFile()
            FileOpen(FileNumber, "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg", OpenMode.Output)
            PrintLine(FileNumber, Script)
            FileClose(FileNumber)
            MsgBox("File has been saved!", , "Saved")
        End If
    End Sub

#Region "Drop Down Boxes"
    Private Sub cbKeys1_TextUpdate(sender As Object, e As EventArgs) Handles cbKey1.TextUpdate
        cbKey1.Text = "Select Key"
    End Sub 'Disables typing in Drop Down boxes

    Private Sub cbCommand1_TextUpdate(sender As Object, e As EventArgs) Handles cbCommands1.TextUpdate
        cbCommands1.Text = "Select Command"
    End Sub 'Disables typing in Drop Down boxes

    Private Sub cbCommands2_TextUpdate(sender As Object, e As EventArgs) Handles cbCommands2.TextUpdate
        cbCommands2.Text = "Select Command"
    End Sub 'Disables typing in Drop Down boxes

    Private Sub cbCommands3_TextUpdate(sender As Object, e As EventArgs) Handles cbCommands3.TextUpdate
        cbCommands3.Text = "Select Command"
    End Sub 'Disables typing in Drop Down boxes

    Private Sub cbCommands4_TextUpdate(sender As Object, e As EventArgs) Handles cbCommands4.TextUpdate
        cbCommands4.Text = "Select Command"
    End Sub 'Disables typing in Drop Down boxes
#End Region
End Class