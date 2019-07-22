
Imports SMPData.DataBase_Operations

Public Class TestForm
    Private newProjTable As TxtProjectTable


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        newProjTable = New TxtProjectTable()
        AddLine("New Text Table Created: " & newProjTable.Name())


    End Sub

    Private Sub AddLine(NewLine As String)
        TextBox1.Text += NewLine & Environment.NewLine
    End Sub

    Private Sub ClearText()
        TextBox1.Text = ""
    End Sub
End Class