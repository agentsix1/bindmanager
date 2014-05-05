Public Class frmBSC

#Region "Open Creator"
    Private Sub btnTrails_Click(sender As Object, e As EventArgs) Handles btnTrails.Click
        frmCBS.Show()
        frmCBS.StartGeneration = 0
        clsFunctions.frmCBS_Trails()
        Me.Hide()
    End Sub

    Private Sub btnModels_Click(sender As Object, e As EventArgs) Handles btnModels.Click
        frmCBS.Show()
        frmCBS.StartGeneration = 1
        clsFunctions.frmCBS_Models()
        Me.Hide()
    End Sub

    Private Sub btnHats_Click(sender As Object, e As EventArgs) Handles btnHats.Click
        frmCBS.Show()
        frmCBS.StartGeneration = 2
        clsFunctions.frmCBS_Hats()
        Me.Hide()
    End Sub

    Private Sub btnTags_Click(sender As Object, e As EventArgs) Handles btnTags.Click
        frmCBS.Show()
        frmCBS.StartGeneration = 3
        clsFunctions.frmCBS_Tags()
        Me.Hide()
    End Sub
#End Region

End Class