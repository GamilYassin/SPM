Imports SMPData.SMPData

Public Class frmProjectsList
    Private myJCE As New JCEHandler

    Private Sub frmProjectsList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        myJCE.FillDataGridView(DataGridView1, myJCE.SelectAllRecords)
        Me.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please, select one project")
        Else
            MsgBox(DataGridView1.SelectedRows(0).Cells(0).Value.ToString)
        End If
    End Sub
End Class