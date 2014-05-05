Public Class frmEdit
    Public Shared Main, CBS As Boolean
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Main = True Then
            Try
                Dim az As Integer = frmMain.lstFile.Items.IndexOf(frmMain.lstFile.SelectedItem)
                Dim strinput As String
                Dim Item As Object = frmMain.lstFile.Items.Item(az)
                Dim index As Integer = frmMain.lstFile.Items.IndexOf(Item)
                strinput = txtEdit.Text
                frmMain.lstFile.Items.Remove(frmMain.lstFile.SelectedItem)
                frmMain.lstFile.Items.Insert(index, strinput)
                Me.Close()
            Catch ex As Exception
                MsgBox("Failed to edit.", vbCritical, "Error")
            End Try
        ElseIf CBS = True Then
            Try
                Dim az As Integer = frmCBS.lstBinds.Items.IndexOf(frmCBS.lstBinds.SelectedItem)
                Dim strinput As String
                Dim Item As Object = frmCBS.lstBinds.Items.Item(az)
                Dim index As Integer = frmCBS.lstBinds.Items.IndexOf(Item)
                strinput = txtEdit.Text
                frmCBS.lstBinds.Items.Remove(frmCBS.lstBinds.SelectedItem)
                frmCBS.lstBinds.Items.Insert(index, strinput)
                Me.Close()
            Catch ex As Exception
                MsgBox("Failed to edit.", vbCritical, "Error")
            End Try
        End If


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtEditKeyDown(ByVal Sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEdit.KeyDown, MyBase.KeyDown
        If e.KeyValue = Keys.Enter Then
            If Main = True Then
                Try
                    Dim az As Integer = frmMain.lstFile.Items.IndexOf(frmMain.lstFile.SelectedItem)
                    Dim strinput As String
                    Dim Item As Object = frmMain.lstFile.Items.Item(az)
                    Dim index As Integer = frmMain.lstFile.Items.IndexOf(Item)
                    strinput = txtEdit.Text
                    frmMain.lstFile.Items.Remove(frmMain.lstFile.SelectedItem)
                    frmMain.lstFile.Items.Insert(index, strinput)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Failed to edit.", vbCritical, "Error")
                End Try
            ElseIf CBS = True Then
                Try
                    Dim az As Integer = frmCBS.lstBinds.Items.IndexOf(frmCBS.lstBinds.SelectedItem)
                    Dim strinput As String
                    Dim Item As Object = frmCBS.lstBinds.Items.Item(az)
                    Dim index As Integer = frmCBS.lstBinds.Items.IndexOf(Item)
                    strinput = txtEdit.Text
                    frmCBS.lstBinds.Items.Remove(frmCBS.lstBinds.SelectedItem)
                    frmCBS.lstBinds.Items.Insert(index, strinput)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Failed to edit.", vbCritical, "Error")
                End Try
            End If

        End If
    End Sub

End Class