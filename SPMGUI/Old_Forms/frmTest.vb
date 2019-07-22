

Imports System.Configuration
Imports SMPData.SMPData
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary.Models
Imports SMPLibrary.SMPLibrary.DataLoger
Imports SMPLibrary.SMPLibrary
'Imports SMPLibrary.GlobalVars

Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myJCE As New JCEHandler
        DataLoger.LogListBox(ListBox1, "Start of the test", MessageType.EVENT_MESSAGE)
        DataLoger.LogListBox(ListBox1, "New JCE Handler object is created")
        DataLoger.LogListBox(ListBox1, "Testing Select All Operation")
        Dim myTable As DataTable = myJCE.SelectAllRecords()
        DataLoger.LogListBox(ListBox1, "Select All Result: " & myTable.Rows.Count & " Rows")
        DataLoger.LogListBox(ListBox1, "Testing Select by Id (6) Operation")
        myTable.Clear()
        myTable = myJCE.SelectById(6)
        DataLoger.LogListBox(ListBox1, "Select ny Id 6 Result: " & myTable.Rows.Count & " Rows")
        DataLoger.LogListBox(ListBox1, "Testing Get Max Id Operation")
        Dim Counter As Integer = myJCE.GetMaxId()
        DataLoger.LogListBox(ListBox1, "Max ID is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Get Rows Count Operation")
        Counter = myJCE.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Fill Model Operation")
        Dim myJCEModel As New JCEModel
        myJCE.FillModel(myJCEModel, 3)
        DataLoger.LogListBox(ListBox1, "Result of model fit (Opportunity Id):  " & myJCEModel.OpportunityId.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Insert New Row Model Operation")
        Counter = myJCE.GetMaxId()
        myJCEModel.Id = Counter + 1
        myJCE.InsertNewRow(myJCEModel)
        Counter = myJCE.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "New Rows count is : " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Update Row information Operation")
        DataLoger.LogListBox(ListBox1, "Revision Number before update is: " & myJCEModel.RevesionNum.ToString)
        myJCEModel.RevesionNum += 1
        myJCE.UpdateOneRow(myJCEModel.Id, myJCEModel)
        myTable.Clear()
        myTable = myJCE.SelectById(myJCEModel.Id)
        DataLoger.LogListBox(ListBox1, "Revision Number After update is: " & myTable.Rows(0).Item(3).ToString)
        DataLoger.LogListBox(ListBox1, "Testing Delete Row information Operation")
        Counter = myJCE.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count before delete is: " & Counter.ToString)
        myJCE.DeleteOneRow(0)
        Counter = myJCE.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count After delete is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Select by Opportunity Id Operation")
        myTable.Clear()
        myTable = myJCE.SelectJCEByOppId(5)
        DataLoger.LogListBox(ListBox1, "Return Rows Count is: " & myTable.Rows.Count.ToString)
        DataLoger.LogListBox(ListBox1, "End of the test", MessageType.EVENT_MESSAGE)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myCustomer As New CustomersHandler
        DataLoger.LogListBox(ListBox1, "Start of the Customers Table test", MessageType.EVENT_MESSAGE)
        DataLoger.LogListBox(ListBox1, "New Customer Handler object is created")
        DataLoger.LogListBox(ListBox1, "Testing Select All Operation")
        Dim myTable As DataTable = myCustomer.SelectAllRecords()
        DataLoger.LogListBox(ListBox1, "Select All Result: " & myTable.Rows.Count & " Rows")
        DataLoger.LogListBox(ListBox1, "Testing Select by Id (1) Operation")
        myTable.Clear()
        myTable = myCustomer.SelectById(2)
        DataLoger.LogListBox(ListBox1, "Select ny Id 2 Result: " & myTable.Rows.Count & " Rows")
        DataLoger.LogListBox(ListBox1, "Testing Get Max Id Operation")
        Dim Counter As Integer = myCustomer.GetMaxId()
        DataLoger.LogListBox(ListBox1, "Max ID is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Get Rows Count Operation")
        Counter = myCustomer.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Fill Model Operation")
        Dim myCustomerModel As New CustomersModel
        myCustomer.FillModel(myCustomerModel, 3)
        DataLoger.LogListBox(ListBox1, "Result of model fit (eMail Id):  " & myCustomerModel.eMail)
        DataLoger.LogListBox(ListBox1, "Testing Insert New Row Model Operation")
        Counter = myCustomer.GetMaxId()
        myCustomerModel.Id = Counter + 1
        myCustomer.InsertNewRow(myCustomerModel)
        Counter = myCustomer.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "New Rows count is : " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Update Row information Operation")
        DataLoger.LogListBox(ListBox1, "eMail before update is: " & myCustomerModel.eMail)
        myCustomerModel.eMail = "New_Mail1000@Doamin.com"
        myCustomer.UpdateOneRow(myCustomerModel.Id, myCustomerModel)
        myTable.Clear()
        myTable = myCustomer.SelectById(myCustomerModel.Id)
        DataLoger.LogListBox(ListBox1, "eMail After update is: " & myTable.Rows(0).Item(7))
        DataLoger.LogListBox(ListBox1, "Testing Delete Row information Operation")
        Counter = myCustomer.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count before delete is: " & Counter.ToString)
        myCustomer.DeleteOneRow(2)
        Counter = myCustomer.GetRowsCount()
        DataLoger.LogListBox(ListBox1, "Rows Count After delete is: " & Counter.ToString)
        DataLoger.LogListBox(ListBox1, "Testing Select by Opportunity Id Operation")
        myTable.Clear()
        myTable = myCustomer.SelectCustomerByPlantId(12)
        DataLoger.LogListBox(ListBox1, "Return Rows Count is: " & myTable.Rows.Count.ToString)
        DataLoger.LogListBox(ListBox1, "End of the test", MessageType.EVENT_MESSAGE)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'DataLoger.LogListBox(ListBox1, SMPLibrary.SMPLibrary.GlobalVars.GlobalVars.CustPosFunctions)
    End Sub
End Class