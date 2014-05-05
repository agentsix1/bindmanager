Imports System.IO
Public Class frmMain

    Dim AppPath = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sets the data for the Combo Boxes
        frmMainComboBoxes() ' Sets Combo Box Text
        frmMain_CheckFileLocation() ' Tests for file location label to be nothing if is sets default text
    End Sub

#Region "lstFile Buttons"

    Private Sub btnEditSelected_Click(sender As Object, e As EventArgs) Handles btnEditSelected.Click
        frmEdit.Main = True
        frmEdit.CBS = False
        frmEdit.Show()
        frmEdit.txtEdit.Text = lstFile.Items(lstFile.SelectedIndex)
    End Sub 'Edits Selected Lines

    Private Sub btnDeleteSelected_Click(sender As Object, e As EventArgs) Handles btnDeleteSelected.Click
        Try
            lstFile.Items.RemoveAt(lstFile.SelectedIndex)
            If lstFile.Items.Count = 0 Then
                btnSaveAs.Enabled = False
                btnSaveFile.Enabled = False
                clsFunctions.frmMain_CheckFileLocation()
            End If
        Catch ex As Exception
            MsgBox("No Items Selected", vbExclamation, "Item Not Found")
            clsFunctions.frmMain_CheckFileLocation()
        End Try
    End Sub 'Deletes Selected Lines

    Private Sub btnClearList_Click(sender As Object, e As EventArgs) Handles btnClearList.Click
        lstFile.Items.Clear()
        lstFile.Refresh()
        If lstFile.Items.Count = 0 Then
            btnSaveAs.Enabled = False
            btnSaveFile.Enabled = False
            clsFunctions.frmMain_CheckFileLocation()
        End If
    End Sub 'Clears the list box

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        ofdOpenFile.ShowDialog()
    End Sub 'Opens the file

    Private Sub ofdOpenFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFile.FileOk
        Dim i As Integer
        i = 0
        Dim file() As String = System.IO.File.ReadAllLines(ofdOpenFile.FileName)

        lstFile.Items.Clear()
        lstFile.Refresh()

        For Each item As Object In File
            lstFile.Items.Add(item.ToString)
        Next
        lblFileLocation.Text = ofdOpenFile.FileName
        MsgBox("Finished loading file!")
        btnSaveAs.Enabled = True
        btnSaveFile.Enabled = True
        mnuSave.Enabled = True
        mnuSaveAs.Enabled = True
    End Sub   'Manages when you go to select a file

    Private Sub btnSaveFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveFile.Click
        If ofdOpenFile.FileName = "" Then
            MsgBox("You have not selected a file to save to. Please use the ""Save As"" button.   File not saved", vbInformation, "Failed to save")
        Else

            Dim FileNumber As Integer = FreeFile()
            FileOpen(FileNumber, ofdOpenFile.FileName, OpenMode.Output)
            For Each Item As Object In lstFile.Items
                PrintLine(FileNumber, Item.ToString)
            Next
            FileClose(FileNumber)
            MsgBox("File has been saved!", , "Saved")
        End If

    End Sub 'Saves File

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click

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
                For Each Item As Object In lstFile.Items
                    PrintLine(FileNumber, Item.ToString)
                Next
                FileClose(FileNumber)
                MsgBox("File has been Overwritten!", , "Saved")
                ofdOpenFile.FileName = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg"
                lblFileLocation.Text = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg"
            ElseIf Result = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
            btnSaveFile.Enabled = True
        Else
            Dim FileNumber As Integer = FreeFile()
            FileOpen(FileNumber, "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg", OpenMode.Output)
            For Each Item As Object In lstFile.Items
                PrintLine(FileNumber, Item.ToString)
            Next
            FileClose(FileNumber)
            MsgBox("File has been saved!", , "Saved")
            ofdOpenFile.FileName = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg"
            lblFileLocation.Text = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\cfg\" & input & ".cfg"
            btnSaveFile.Enabled = True
        End If
    End Sub 'Allows you to Save the file as what ever you want

#End Region

#Region "Drop Down Boxes"
    Private Sub cbKeys1_TextUpdate(sender As Object, e As EventArgs) Handles cbKeys1.TextUpdate
        cbKeys1.Text = "Select Key"
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

#Region "Key Binds - Simple Bind Creation"

    Private Sub btnAddBind_Click(sender As Object, e As EventArgs) Handles btnAddBind.Click
        If cbCommands1.Text = "None" And cbCommands2.Text = "None" And cbCommands3.Text = "None" And cbCommands4.Text = "None" Then
            MsgBox("You must select a command for at least 1 output!")
            Exit Sub
        End If
        cbKey_Command_Test(cbKeys1.Text)
        If cont = False Then
            MsgBox("No key was entered. Bind creation aborted!")
            cbKeys1.BackColor = Color.Red
            Exit Sub
        Else
            cbKeys1.BackColor = Color.White
        End If
        cbKey_Command_Test(cbCommands1.Text)
        If cont = False Then
            MsgBox("No command in slot 1 was entered. Bind creation aborted!")
            cbCommands1.BackColor = Color.Red
            Exit Sub
        Else
            cbCommands1.BackColor = Color.White
        End If
        cbKey_Command_Test(cbCommands2.Text)
        If cont = False Then
            MsgBox("No command in slot 2 was entered. Bind creation aborted!")
            cbCommands2.BackColor = Color.Red
            Exit Sub
        Else
            cbCommands2.BackColor = Color.White
        End If
        cbKey_Command_Test(cbCommands3.Text)
        If cont = False Then
            MsgBox("No command in slot 3 was entered. Bind creation aborted!")
            cbCommands3.BackColor = Color.Red
            Exit Sub
        Else
            cbCommands3.BackColor = Color.White
        End If
        cbKey_Command_Test(cbCommands4.Text)
        If cont = False Then
            MsgBox("No command in slot 4 was entered. Bind creation aborted!")
            cbCommands4.BackColor = Color.Red
            Exit Sub
        Else
            cbCommands4.BackColor = Color.White
        End If
        cbKeys(cbKeys1.Text)
        cbCommand(cbCommands1.Text, "frmMain.cbCommands1")
        cbCommand(cbCommands2.Text, "frmMain.cbCommands2")
        cbCommand(cbCommands3.Text, "frmMain.cbCommands3")
        cbCommand(cbCommands4.Text, "frmMain.cbCommands4")
        frmMain_AddTo(frmMainCommand01, frmMainCommand02, frmMainCommand03, frmMainCommand04, cbKeys1.Text, cbCommands1.Text, _
                      cbCommands2.Text, cbCommands3.Text, cbCommands4.Text, False)

        btnSaveAs.Enabled = True
        mnuSaveAs.Enabled = True

    End Sub 'Out puts the data from the created bind
    Private Sub btnOutBindToText_Click(sender As Object, e As EventArgs) Handles btnOutBindToText.Click
        If cbCommands1.Text = "None" And cbCommands2.Text = "None" And cbCommands3.Text = "None" And cbCommands4.Text = "None" Then
            MsgBox("You must select a command for at least 1 output!")
            Exit Sub
        End If
        cbKey_Command_Test(cbKeys1.Text)
        If cont = False Then
            MsgBox("No key was entered. Bind creation aborted!")
            Exit Sub
        End If
        cbKey_Command_Test(cbCommands1.Text)
        If cont = False Then
            MsgBox("No command in slot 1 was entered. Bind creation aborted!")
            Exit Sub
        End If
        cbKey_Command_Test(cbCommands2.Text)
        If cont = False Then
            MsgBox("No command in slot 2 was entered. Bind creation aborted!")
            Exit Sub
        End If
        cbKey_Command_Test(cbCommands3.Text)
        If cont = False Then
            MsgBox("No command in slot 3 was entered. Bind creation aborted!")
            Exit Sub
        End If
        cbKey_Command_Test(cbCommands4.Text)
        If cont = False Then
            MsgBox("No command in slot 4 was entered. Bind creation aborted!")
            Exit Sub
        End If
        cbKeys(cbKeys1.Text)
        cbCommand(cbCommands1.Text, "frmMain.cbCommands1")
        cbCommand(cbCommands2.Text, "frmMain.cbCommands2")
        cbCommand(cbCommands3.Text, "frmMain.cbCommands3")
        cbCommand(cbCommands4.Text, "frmMain.cbCommands4")
        frmMain_AddTo(frmMainCommand01, frmMainCommand02, frmMainCommand03, frmMainCommand04, cbKeys1.Text, cbCommands1.Text, _
                      cbCommands2.Text, cbCommands3.Text, cbCommands4.Text, True)





    End Sub
#End Region

#Region "Non Key Binds - Simple Bind Creation"
    Private Sub NonKeyATBL_Click(sender As Object, e As EventArgs) Handles NonKeyATBL.Click
        frmMain_AddTo_NonKey(False)
        If TheBind = "" Then
            Exit Sub
        End If
        btnSaveAs.Enabled = True
        mnuSaveAs.Enabled = True
    End Sub

    Private Sub NonKeyOTT_Click(sender As Object, e As EventArgs) Handles NonKeyOTT.Click
        frmMain_AddTo_NonKey(True)
        If TheBind = "" Then
            Exit Sub
        End If
    End Sub
#End Region

#Region "Menu Buttons"
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        frmBSC.Close()
        frmCBS.Close()
        frmEdit.Close()
        frmSettings.Close()
        frmTextBox.Close()
        Me.Close()

    End Sub

    Private Sub mnuCHG_Click(sender As Object, e As EventArgs) Handles mnuCHG.Click
        clsFunctions.frmWeb_NewAddress(AppPath & "\files\web\commandguide.html", "Command Guide")
    End Sub

    Private Sub mnuUTP_Click(sender As Object, e As EventArgs) Handles mnuUTP.Click
        clsFunctions.frmWeb_NewAddress(AppPath & "\files\web\commandguide.html", "Using The Program")
    End Sub

    Private Sub mnuNGTB_Click(sender As Object, e As EventArgs) Handles mnuNGTB.Click
        clsFunctions.frmWeb_NewAddress(AppPath & "\files\web\commandguide.html", "Noobie Guide To Binds")
    End Sub

    Private Sub mnuUHTW_Click(sender As Object, e As EventArgs) Handles mnuUHTW.Click
        clsFunctions.frmWeb_NewAddress(AppPath & "\files\web\commandguide.html", "Understand How This Program Works")
    End Sub

    Private Sub mnuLPHome_Click(sender As Object, e As EventArgs) Handles mnuLPHome.Click
        System.Diagnostics.Process.Start("http://lifepunch.net")
    End Sub

    Private Sub mnuLPForums_Click(sender As Object, e As EventArgs) Handles mnuLPForums.Click
        System.Diagnostics.Process.Start("http://lifepunch.net/forums")
    End Sub

    Private Sub mnuLPRules_Click(sender As Object, e As EventArgs) Handles mnuLPRules.Click
        System.Diagnostics.Process.Start("http://lifepunch.net/rules")
    End Sub

    Private Sub mnuLPBT_Click(sender As Object, e As EventArgs) Handles mnuLPBT.Click
        System.Diagnostics.Process.Start("http://www.lifepunch.net/forums/showthread.php?tid=31494")
    End Sub

    Private Sub mnuCFU_Click(sender As Object, e As EventArgs) Handles mnuCFU.Click
        Dim wbCFU As New WebBrowser
        wbCFU.Url = New Uri("http://www.lifepunch.net/forums/showthread.php?tid=31494")
        While wbCFU.IsBusy
            pause(100)
        End While
        pause(2000)
        Try
            Dim LatestVer() = Split(wbCFU.DocumentText, "!!-=-!!")
            If LatestVer(1) = ver Then
                MsgBox("You are up to date!", , "Up To Date")
            Else
                Dim Result As DialogResult = MessageBox.Show("You are needing to update as you are currently out of date. Would you like to be redirect to the latest version?", "Needs Updating", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                If Result = Windows.Forms.DialogResult.Yes Then
                    System.Diagnostics.Process.Start(LatestVer(2))
                Else
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MsgBox("The update server may be offline try again later", , "Error")
        End Try
        
    End Sub

#End Region

    Private Sub btnRBSCP_Click(sender As Object, e As EventArgs) Handles btnRBSCP.Click
        frmBSC.Show()
        frmBSC.Focus()
    End Sub

    Private Sub llLifepunch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llLifepunch.LinkClicked
        System.Diagnostics.Process.Start("http://lifepunch.net")
    End Sub


    'Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    ListBox1.Items.Remove("two")
    'End Sub


End Class
