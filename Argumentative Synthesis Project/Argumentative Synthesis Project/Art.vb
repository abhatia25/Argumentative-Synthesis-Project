﻿Public Class frmArt
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Me.Hide()
        frmAQWF.Show()
    End Sub

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class