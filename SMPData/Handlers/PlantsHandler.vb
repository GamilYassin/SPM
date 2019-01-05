
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class PlantsHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spPlantsTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spPlantsTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spPlantsTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spPlantsTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objPlantsModel As PlantsModel, Id As Integer)
            Dim DBDataReader As SqlDataReader

            Try
                Me.DBCommand.CommandText = "spPlantsTableSelectById"
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                PlantsModelMapperOut(objPlantsModel, DBDataReader)
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

        Public Sub InsertNewRow(objPlantsModel As PlantsModel)
            Try
                ModelMapIn(objPlantsModel)
                Me.DBCommand.CommandText = "spPlantsTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obPlantsModel As PlantsModel)
            ModelMapIn(obPlantsModel)
            Me.DBCommand.CommandText = "spPlantsTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spPlantsTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub


        Public Sub ModelMapIn(ByRef objPlantsModel As PlantsModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objPlantsModel.Id
                .Add("@Country", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.Country
                .Add("@EndCustomer", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.EndCustomer
                .Add("@PlantName", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.PlantName
                .Add("@Industry", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.Industry
                .Add("@GPSLong", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.GPSLong
                .Add("@GPSLat", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objPlantsModel.GPSLat
                .Add("@Comments", SqlDbType.NVarChar, 1000, ParameterDirection.Input).Value = objPlantsModel.Comments
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub PlantsModelMapperOut(ByRef objPlantsModel As PlantsModel)
            objPlantsModel.Id = Me.DBCommand.Parameters("@Id").Value
            objPlantsModel.Country = Me.DBCommand.Parameters("@Country").Value
            objPlantsModel.EndCustomer = Me.DBCommand.Parameters("@EndCustomer").Value
            objPlantsModel.PlantName = Me.DBCommand.Parameters("@PlantName").Value
            objPlantsModel.Industry = Me.DBCommand.Parameters("@Industry").Value
            objPlantsModel.GPSLong = Me.DBCommand.Parameters("@GPSLong").Value
            objPlantsModel.GPSLat = Me.DBCommand.Parameters("@GPSLat").Value
            objPlantsModel.Comments = Me.DBCommand.Parameters("@Comments").Value
        End Sub

        Public Sub PlantsModelMapperOut(ByRef objPlantsModel As PlantsModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objPlantsModel.Id = DBDataReader.Item(0)
                objPlantsModel.PlantName = DBDataReader.Item(1)
                objPlantsModel.EndCustomer = DBDataReader.Item(2)
                objPlantsModel.PlantName = DBDataReader.Item(3)
                objPlantsModel.Industry = DBDataReader.Item(4)
                objPlantsModel.GPSLong = DBDataReader.Item(5)
                objPlantsModel.GPSLat = DBDataReader.Item(6)
                objPlantsModel.Comments = DBDataReader.Item(7)
            End If
        End Sub


        Public Function SelectPlantsByCountry(Country As String) As DataTable
            With Me.DBCommand
                .CommandText = "spPlantsTableByCountry"
                .Parameters.Clear()
                .Parameters.Add("@Country", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = Country
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectCustomerByEndCustomer(EndCustomer As String) As DataTable
            With Me.DBCommand
                .CommandText = "spPlantsTableSelectByEndCustomer"
                .Parameters.Clear()
                .Parameters.Add("@EndCustomer", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = EndCustomer
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectPlantsByIndustry(Industry As String) As DataTable
            With Me.DBCommand
                .CommandText = "spPlantsTableByIndustry"
                .Parameters.Clear()
                .Parameters.Add("@Industry", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = Industry
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectPlantsByPlantName(PlantName As String) As DataTable
            With Me.DBCommand
                .CommandText = "spPlantsTableByPlantName"
                .Parameters.Clear()
                .Parameters.Add("@PlantName", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = PlantName
            End With
            Return MyBase.FilterData()
        End Function

        Public Overloads Sub ITableHandler_FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace


