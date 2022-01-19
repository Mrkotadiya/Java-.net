Public Class Form1

    Private Sub TreeViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreeViewToolStripMenuItem.Click
        ListSwift.MdiParent = Me
        ListSwift.Show()


    End Sub

    Private Sub TreeViewControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreeViewControlToolStripMenuItem.Click
        TreeViewControl.MdiParent = Me
        TreeViewControl.Show()
    End Sub
End Class
