Public Class MainForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frmProjects As New frmProjectsList()

        'frmProjects.MdiParent = Me
        frmProjects.Show()
    End Sub
End Class
