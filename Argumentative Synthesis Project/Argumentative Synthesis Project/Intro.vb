﻿Public Class frmIntro
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmSoldier_Backstory.Show()
    End Sub
End Class
