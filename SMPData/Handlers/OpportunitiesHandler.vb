Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class OpportunitiesHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spOpportunitiesTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .CommandText = "spOpportunitiesTableSelectById"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spOpportunitiesTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spOpportunitiesTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objOpportunitiesModel As OpportunitiesModel, Id As Integer)
            Dim DBDataReader As SqlDataReader
            ClearCommand()
            Try
                Me.DBCommand.CommandText = "spOpportunitiesTableSelectById"
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                OpportunitiesModelMapperOut(objOpportunitiesModel, DBDataReader)
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

        Public Sub InsertNewRow(objOpportunitiesModel As OpportunitiesModel)
            Try
                ModelMapIn(objOpportunitiesModel)
                Me.DBCommand.CommandText = "spOpportunitiesTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obOpportunitiesModel As OpportunitiesModel)
            ModelMapIn(obOpportunitiesModel)
            Me.DBCommand.CommandText = "spOpportunitiesTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow

            With Me.DBCommand
                .CommandText = "spOpportunitiesTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub



        Public Sub ModelMapIn(ByRef objOpportunitiesModel As OpportunitiesModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objOpportunitiesModel.Id
                .Add("@ProductLine", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objOpportunitiesModel.ProductLine
                .Add("@OppName", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objOpportunitiesModel.OppName
                .Add("@SFDCNum", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objOpportunitiesModel.SFDCNum
                .Add("@SFDCLink", SqlDbType.NVarChar, 1000, ParameterDirection.Input).Value = objOpportunitiesModel.SFDCLink
                .Add("@PlantId", SqlDbType.Int, ParameterDirection.Input).Value = objOpportunitiesModel.PlantId
                .Add("@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objOpportunitiesModel.Status
                .Add("@SalesMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objOpportunitiesModel.SalesMgr
                .Add("@ComOpsMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objOpportunitiesModel.ComOpsMgr
                .Add("@CreatedDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objOpportunitiesModel.CreatedDate
                .Add("@ExpectedDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objOpportunitiesModel.ExpectedDate
                .Add("@TotalAmount", SqlDbType.Money, ParameterDirection.Input).Value = objOpportunitiesModel.TotalAmount
                .Add("@HardwareAmount", SqlDbType.Money, ParameterDirection.Input).Value = objOpportunitiesModel.HardwareAmount
                .Add("@ServicesAmount", SqlDbType.Money, ParameterDirection.Input).Value = objOpportunitiesModel.ServicesAmount
                .Add("@Convertability", SqlDbType.Money, ParameterDirection.Input).Value = objOpportunitiesModel.Convertability
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub OpportunitiesModelMapperOut(ByRef objOpportunitiesModel As OpportunitiesModel)
            objOpportunitiesModel.Id = Me.DBCommand.Parameters("@Id").Value
            objOpportunitiesModel.ProductLine = Me.DBCommand.Parameters("@ProductLine").Value
            objOpportunitiesModel.OppName = Me.DBCommand.Parameters("@OppName").Value
            objOpportunitiesModel.SFDCNum = Me.DBCommand.Parameters("@SFDCNum").Value
            objOpportunitiesModel.SFDCLink = Me.DBCommand.Parameters("@SFDCLink").Value
            objOpportunitiesModel.PlantId = Me.DBCommand.Parameters("@PlantId").Value
            objOpportunitiesModel.Status = Me.DBCommand.Parameters("@Status").Value
            objOpportunitiesModel.SalesMgr = Me.DBCommand.Parameters("@SalesMgr").Value
            objOpportunitiesModel.ComOpsMgr = Me.DBCommand.Parameters("@ComOpsMgr").Value
            objOpportunitiesModel.CreatedDate = Me.DBCommand.Parameters("@CreatedDate").Value
            objOpportunitiesModel.ExpectedDate = Me.DBCommand.Parameters("@ExpectedDate").Value
            objOpportunitiesModel.TotalAmount = Me.DBCommand.Parameters("@TotalAmount").Value
            objOpportunitiesModel.HardwareAmount = Me.DBCommand.Parameters("@HardwareAmount").Value
            objOpportunitiesModel.ServicesAmount = Me.DBCommand.Parameters("@ServicesAmount").Value
            objOpportunitiesModel.Convertability = Me.DBCommand.Parameters("@Convertability").Value
        End Sub

        Public Sub OpportunitiesModelMapperOut(ByRef objOpportunitiesModel As OpportunitiesModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objOpportunitiesModel.Id = DBDataReader.Item(0)
                objOpportunitiesModel.ProductLine = DBDataReader.Item(1)
                objOpportunitiesModel.OppName = DBDataReader.Item(2)
                objOpportunitiesModel.SFDCNum = DBDataReader.Item(3)
                objOpportunitiesModel.SFDCLink = DBDataReader.Item(4)
                objOpportunitiesModel.PlantId = DBDataReader.Item(5)
                objOpportunitiesModel.Status = DBDataReader.Item(6)
                objOpportunitiesModel.SalesMgr = DBDataReader.Item(7)
                objOpportunitiesModel.ComOpsMgr = DBDataReader.Item(8)
                objOpportunitiesModel.CreatedDate = DBDataReader.Item(9)
                objOpportunitiesModel.ExpectedDate = DBDataReader.Item(10)
                objOpportunitiesModel.TotalAmount = DBDataReader.Item(11)
                objOpportunitiesModel.HardwareAmount = DBDataReader.Item(12)
                objOpportunitiesModel.ServicesAmount = DBDataReader.Item(13)
                objOpportunitiesModel.Convertability = DBDataReader.Item(14)
            End If
        End Sub

        Public Function SelectOpportunitiesByCops(ComOpsMgr As String) As DataTable
            With Me.DBCommand
                .CommandText = "spOpportunitiesTableByCOps"
                .Parameters.Clear()
                .Parameters.Add("@ComOpsMgr", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = ComOpsMgr
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectOpportunitiesByPL(ProductLine As String) As DataTable
            With Me.DBCommand
                .CommandText = "spOpportunitiesTableByPL"
                .Parameters.Clear()
                .Parameters.Add("@ProductLine", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = ProductLine
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectOpportunitiesBySFDCNum(SFDCNum As String) As DataTable
            With Me.DBCommand
                .CommandText = "spOpportunitiesTableBySFDCNum"
                .Parameters.Clear()
                .Parameters.Add("@SFDCNum", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = SFDCNum
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectOpportunitiesBySM(Status As String) As DataTable
            With Me.DBCommand
                .CommandText = "spOpportunitiesTableByStatus"
                .Parameters.Clear()
                .Parameters.Add("@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = Status
            End With
            Return MyBase.FilterData()
        End Function

        Public Overloads Sub ITableHandler_FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace
