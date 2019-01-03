

Imports System.Configuration
Imports SMPData.SMPData
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary.Models

Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim testObj As New JCEHandler()
        Dim reader As New DataTable
        Dim objJCEmodel As New JCEModel()


        'With objJCEmodel
        '    .Id = testObj.GetMaxJCEId() + 1
        '    .OpportunityId = 5
        '    .JCETitleName = "Test JCE from form"
        '    .RevesionNum = 2
        '    .CreatedDate = Date.Now()
        '    .TotalCost = 125.12
        '    .Strategy = "Strategy 1 2 3"
        'End With
        'testObj.JCEInserNewRow(objJCEmodel)
        'Date
        testObj.FillJCEModel(objJCEmodel, 5)
        MsgBox(objJCEmodel.OpportunityId.ToString)



    End Sub
End Class