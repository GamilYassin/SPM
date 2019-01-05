
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class JCEHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spJCETableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spJCETableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spJCETableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spJCETableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objJCEModel As JCEModel, Id As Integer)
            Dim DBDataReader As SqlDataReader
            ClearCommand()
            Try
                Me.DBCommand.CommandText = "spJCETableSelectById"
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                JCEModelMapperOut(objJCEModel, DBDataReader)
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

        Public Sub InsertNewRow(objJCEModel As JCEModel)
            Try
                ModelMapIn(objJCEModel)
                Me.DBCommand.CommandText = "spJCETableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obJceModel As JCEModel)
            ModelMapIn(obJceModel)
            Me.DBCommand.CommandText = "spJCETableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spJCETableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub

        Public Sub ModelMapIn(ByRef objJCEModel As JCEModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objJCEModel.Id
                .Add("@OpportunityId", SqlDbType.Int, ParameterDirection.Input).Value = objJCEModel.OpportunityId
                .Add("@JCETitleName", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objJCEModel.JCETitleName
                .Add("@RevesionNum", SqlDbType.Int, ParameterDirection.Input).Value = objJCEModel.RevesionNum
                .Add("@CreatedDate", SqlDbType.DateTime2, ParameterDirection.Input).Value = objJCEModel.CreatedDate
                .Add("@TotalCost", SqlDbType.Money, ParameterDirection.Input).Value = objJCEModel.TotalCost
                .Add("@Strategy", SqlDbType.NVarChar, ParameterDirection.Input).Value = objJCEModel.Strategy
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub JCEModelMapperOut(ByRef objJCEModel As JCEModel)
            objJCEModel.Id = Me.DBCommand.Parameters("@Id").Value
            objJCEModel.OpportunityId = Me.DBCommand.Parameters("@OpportunityId").Value
            objJCEModel.JCETitleName = Me.DBCommand.Parameters("@JCETitleName").Value
            objJCEModel.RevesionNum = Me.DBCommand.Parameters("@RevesionNum").Value
            objJCEModel.CreatedDate = Me.DBCommand.Parameters("@CreatedDate").Value
            objJCEModel.TotalCost = Me.DBCommand.Parameters("@TotalCost").Value
            objJCEModel.Strategy = Me.DBCommand.Parameters("@Strategy").Value
        End Sub

        Public Sub JCEModelMapperOut(ByRef objJCEModel As JCEModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objJCEModel.Id = DBDataReader.Item(0)
                objJCEModel.OpportunityId = DBDataReader.Item(1)
                objJCEModel.JCETitleName = DBDataReader.Item(2)
                objJCEModel.RevesionNum = DBDataReader.Item(3)
                objJCEModel.CreatedDate = DBDataReader.Item(4)
                objJCEModel.TotalCost = DBDataReader.Item(5)
                objJCEModel.Strategy = DBDataReader.Item(6)
            End If
        End Sub


        Public Function SelectJCEByOppId(OppId As Integer) As DataTable
            With Me.DBCommand
                .CommandText = "spJCETableSelectByOppId"
                .Parameters.Clear()
                .Parameters.Add("@OppId", SqlDbType.Int, ParameterDirection.Input).Value = OppId
            End With
            Return MyBase.FilterData()
        End Function

        Public Overloads Sub FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace

