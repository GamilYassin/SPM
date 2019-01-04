
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models

Namespace SMPData
    Public Class MilestonesHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spMilestonesTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spMilestonesTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spMilestonesTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spMilestonesTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objMilestonesModel As MilestonesModel, Id As Integer)
            Dim DBDataReader As SqlDataReader
            ClearCommand()
            Try
                Me.DBCommand.CommandText = "spMilestonesTableSelectById"
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                MilestonesModelMapperOut(objMilestonesModel, DBDataReader)
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

        Public Sub InsertNewRow(objMilestonesModel As MilestonesModel)
            Try
                ModelMapIn(objMilestonesModel)
                Me.DBCommand.CommandText = "spMilestonesTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obMilestonesModel As MilestonesModel)
            ModelMapIn(obMilestonesModel)
            Me.DBCommand.CommandText = "spMilestonesTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spMilestonesTableDeleteRow"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub


        Public Sub ModelMapIn(ByRef objMilestonesModel As MilestonesModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objMilestonesModel.Id
                .Add("@WBSId", SqlDbType.Int, ParameterDirection.Input).Value = objMilestonesModel.WBSId
                .Add("@TotalRev", SqlDbType.Money, ParameterDirection.Input).Value = objMilestonesModel.TotalRev
                .Add("@PlannedRevRecDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objMilestonesModel.PlannedRevRecDate
                .Add("@ExpectedRevRecDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objMilestonesModel.ExpectedRevRecDate
                .Add("@ActualRevRecDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objMilestonesModel.ActualRevRecDate
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub MilestonesModelMapperOut(ByRef objMilestonesModel As MilestonesModel)
            objMilestonesModel.Id = Me.DBCommand.Parameters("@Id").Value
            objMilestonesModel.WBSId = Me.DBCommand.Parameters("@WBSId").Value
            objMilestonesModel.TotalRev = Me.DBCommand.Parameters("@TotalRev").Value
            objMilestonesModel.PlannedRevRecDate = Me.DBCommand.Parameters("@PlannedRevRecDate").Value
            objMilestonesModel.ExpectedRevRecDate = Me.DBCommand.Parameters("@ExpectedRevRecDate").Value
            objMilestonesModel.ActualRevRecDate = Me.DBCommand.Parameters("@ActualRevRecDate").Value
        End Sub

        Public Sub MilestonesModelMapperOut(ByRef objMilestonesModel As MilestonesModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objMilestonesModel.Id = DBDataReader.Item(0)
                objMilestonesModel.WBSId = DBDataReader.Item(1)
                objMilestonesModel.TotalRev = DBDataReader.Item(2)
                objMilestonesModel.PlannedRevRecDate = DBDataReader.Item(3)
                objMilestonesModel.ExpectedRevRecDate = DBDataReader.Item(4)
                objMilestonesModel.ActualRevRecDate = DBDataReader.Item(5)
            End If
        End Sub


        Public Function SelectMilestonesByWBSId(WBSId As Integer) As DataTable
            With Me.DBCommand
                .CommandText = "spMilestonesTableSelectByWBSId"
                .Parameters.Clear()
                .Parameters.Add("@WBSId", SqlDbType.Int, ParameterDirection.Input).Value = WBSId
            End With
            Return MyBase.FilterData()
        End Function

    End Class
End Namespace


