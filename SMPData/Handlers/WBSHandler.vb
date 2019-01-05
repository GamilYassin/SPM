


Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class WBSHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spWBSTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spWBSTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spWBSTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spWBSTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objWBSModel As WBSModel, Id As Integer)
            Dim DBDataReader As SqlDataReader

            Try
                Me.DBCommand.CommandText = "spWBSTableSelectById"
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                WBSModelMapperOut(objWBSModel, DBDataReader)
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

        Public Sub InsertNewRow(objWBSModel As WBSModel)
            Try
                ModelMapIn(objWBSModel)
                Me.DBCommand.CommandText = "spWBSTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obWBSModel As WBSModel)
            ModelMapIn(obWBSModel)
            Me.DBCommand.CommandText = "spWBSTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spWBSTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub


        Public Sub ModelMapIn(ByRef objWBSModel As WBSModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objWBSModel.Id
                .Add("@ProjectId", SqlDbType.Int, ParameterDirection.Input).Value = objWBSModel.ProjectId
                .Add("@NetworkNumber", SqlDbType.NVarChar, 50, ParameterDirection.Input).Value = objWBSModel.NetworkNumber
                .Add("@Description", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objWBSModel.Description
                .Add("@SAPWBS", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objWBSModel.SAPWBS
                .Add("@WBSType", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objWBSModel.WBSType
                .Add("@Technology", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objWBSModel.Technology
                .Add("@SAPProductLine", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objWBSModel.SAPProductLine
                .Add("@TotalRev", SqlDbType.Money, ParameterDirection.Input).Value = objWBSModel.TotalRev
                .Add("@TotalPlannedCost", SqlDbType.Money, ParameterDirection.Input).Value = objWBSModel.TotalPlannedCost
                .Add("@TotalActualCost", SqlDbType.Money, ParameterDirection.Input).Value = objWBSModel.TotalActualCost
                .Add("@ExpectedRevRecDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objWBSModel.ExpectedRevRecDate
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub WBSModelMapperOut(ByRef objWBSModel As WBSModel)
            objWBSModel.Id = Me.DBCommand.Parameters("@Id").Value
            objWBSModel.ProjectId = Me.DBCommand.Parameters("@ProjectId").Value
            objWBSModel.NetworkNumber = Me.DBCommand.Parameters("@NetworkNumber").Value
            objWBSModel.Description = Me.DBCommand.Parameters("@Description").Value
            objWBSModel.SAPWBS = Me.DBCommand.Parameters("@SAPWBS").Value
            objWBSModel.WBSType = Me.DBCommand.Parameters("@WBSType").Value
            objWBSModel.Technology = Me.DBCommand.Parameters("@Technology").Value
            objWBSModel.SAPProductLine = Me.DBCommand.Parameters("@SAPProductLine").Value
            objWBSModel.TotalRev = Me.DBCommand.Parameters("@TotalRev").Value
            objWBSModel.TotalPlannedCost = Me.DBCommand.Parameters("@TotalPlannedCost").Value
            objWBSModel.TotalActualCost = Me.DBCommand.Parameters("@TotalActualCost").Value
            objWBSModel.ExpectedRevRecDate = Me.DBCommand.Parameters("@ExpectedRevRecDate").Value

        End Sub

        Public Sub WBSModelMapperOut(ByRef objWBSModel As WBSModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objWBSModel.Id = DBDataReader.Item(0)
                objWBSModel.ProjectId = DBDataReader.Item(1)
                objWBSModel.NetworkNumber = DBDataReader.Item(2)
                objWBSModel.Description = DBDataReader.Item(3)
                objWBSModel.SAPWBS = DBDataReader.Item(4)
                objWBSModel.WBSType = DBDataReader.Item(5)
                objWBSModel.Technology = DBDataReader.Item(6)
                objWBSModel.SAPProductLine = DBDataReader.Item(7)
                objWBSModel.TotalRev = DBDataReader.Item(8)
                objWBSModel.TotalPlannedCost = DBDataReader.Item(9)
                objWBSModel.TotalActualCost = DBDataReader.Item(10)
                objWBSModel.ExpectedRevRecDate = DBDataReader.Item(11)
            End If
        End Sub


        Public Function SelectWBSByByDescription(Description As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableByDescription"
                .Parameters.Clear()
                .Parameters.Add("@Description", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = Description
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectWBSByNetworkNumber(NetworkNumber As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableByNetworkNumber"
                .Parameters.Clear()
                .Parameters.Add("@NetworkNumber", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = NetworkNumber
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectWBSByProjectId(ProjectId As Integer) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableByProjectId"
                .Parameters.Clear()
                .Parameters.Add("@ProjectId", SqlDbType.Int, ParameterDirection.Input).Value = ProjectId
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectWBSBySAPProductLine(SAPProductLine As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableBySAPProductLine"
                .Parameters.Clear()
                .Parameters.Add("@SAPProductLine", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = SAPProductLine
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectWBSBySAPWBS(SAPWBS As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableBySAPWBS"
                .Parameters.Clear()
                .Parameters.Add("@SAPWBS", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = SAPWBS
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectWBSByTechnology(Technology As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableByTechnology"
                .Parameters.Clear()
                .Parameters.Add("@Technology", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = Technology
            End With
            Return MyBase.FilterData()
        End Function



        Public Function SelectWBSByWBSType(WBSType As String) As DataTable
            With Me.DBCommand
                .CommandText = "spWBSTableByWBSType"
                .Parameters.Clear()
                .Parameters.Add("@WBSType", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = WBSType
            End With
            Return MyBase.FilterData()
        End Function

        Public Overloads Sub ITableHandler_FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace

