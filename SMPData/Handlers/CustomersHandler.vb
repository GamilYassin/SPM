
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class CustomersHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spCustomersTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spCustomersTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spCustomersTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spCustomersTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objCustomersModel As CustomersModel, Id As Integer)
            Dim DBDataReader As SqlDataReader

            Try
                Me.DBCommand.CommandText = "spCustomersTableSelectById"
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                CustomersModelMapperOut(objCustomersModel, DBDataReader)
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
        End Sub

        Public Sub InsertNewRow() Implements ITableHandler.InsertNewRow
            Throw New NotImplementedException()
        End Sub

        Public Sub InsertNewRow(objCustomersModel As CustomersModel)
            Try
                ModelMapIn(objCustomersModel)
                Me.DBCommand.CommandText = "spCustomersTableInsertRow"
                Me.OpenConnection()
                DBCommand.ExecuteNonQuery()
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
        End Sub

        Public Sub UpdateOneRow(RowId As Integer) Implements ITableHandler.UpdateOneRow
            Throw New NotImplementedException()
        End Sub

        Public Sub UpdateOneRow(RowId As Integer, obCustomersModel As CustomersModel)
            ModelMapIn(obCustomersModel)
            Me.DBCommand.CommandText = "spCustomersTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spCustomersTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub


        Public Sub ModelMapIn(ByRef objCustomersModel As CustomersModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objCustomersModel.Id
                .Add("@Name", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.Name
                .Add("@PlantId", SqlDbType.Int, ParameterDirection.Input).Value = objCustomersModel.PlantId
                .Add("@Position", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.Position
                .Add("@PositionFunction", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.PositionFunction
                .Add("@Mobile", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.Mobile
                .Add("@Phone", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.Phone
                .Add("@eMail", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objCustomersModel.eMail
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub CustomersModelMapperOut(ByRef objCustomersModel As CustomersModel)
            objCustomersModel.Id = Me.DBCommand.Parameters("@Id").Value
            objCustomersModel.Name = Me.DBCommand.Parameters("@Name").Value
            objCustomersModel.PlantId = Me.DBCommand.Parameters("@PlantId").Value
            objCustomersModel.Position = Me.DBCommand.Parameters("@Position").Value
            objCustomersModel.PositionFunction = Me.DBCommand.Parameters("@PositionFunction").Value
            objCustomersModel.Mobile = Me.DBCommand.Parameters("@Mobile").Value
            objCustomersModel.Phone = Me.DBCommand.Parameters("@Phone").Value
            objCustomersModel.eMail = Me.DBCommand.Parameters("@eMail").Value
        End Sub

        Public Sub CustomersModelMapperOut(ByRef objCustomersModel As CustomersModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objCustomersModel.Id = DBDataReader.Item(0)
                objCustomersModel.Name = DBDataReader.Item(1)
                objCustomersModel.PlantId = DBDataReader.Item(2)
                objCustomersModel.Position = DBDataReader.Item(3)
                objCustomersModel.PositionFunction = DBDataReader.Item(4)
                objCustomersModel.Mobile = DBDataReader.Item(5)
                objCustomersModel.Phone = DBDataReader.Item(6)
                objCustomersModel.eMail = DBDataReader.Item(7)
            End If
        End Sub


        Public Function SelectCustomerByPlantId(PlantId As Integer) As DataTable
            With Me.DBCommand
                .CommandText = "spCustomersTableSelectByPlantId"
                .Parameters.Clear()
                .Parameters.Add("@PlantId", SqlDbType.Int, ParameterDirection.Input).Value = PlantId
            End With
            Return MyBase.FilterData()
        End Function

        Private Overloads Sub ITableHandler_FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace

