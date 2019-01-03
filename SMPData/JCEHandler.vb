
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models

Namespace SMPData
    Public Class JCEHandler
        Inherits MDFManager

        Public Sub New()
            MyBase.New
        End Sub

        Public Function SelectAllData() As DataTable
            Return MyBase.SelectAllRecords("spJCETableSelectAll")
        End Function

        Public Function GetMaxJCEId() As Integer
            Return MyBase.GetMaxId("spJCETableMaxId")
        End Function

        Public Function SelectJCEById(JCEId As Integer) As DataTable
            Return MyBase.SelectById("spJCETableSelectById", JCEId)
        End Function

        Public Function SelectJCEByOppId(OppId As Integer) As DataTable
            Dim myTable As New DataTable()

            Try
                With Me.DBCommand
                    .CommandText = "spJCETableSelectByOppId"
                    .Parameters.Add("@OppId", SqlDbType.Int, ParameterDirection.Input).Value = OppId
                End With
                DBAdapter.SelectCommand = DBCommand
                Me.OpenConnection()
                DBAdapter.SelectCommand.ExecuteReader()
                Me.CloseConnection()
                DBAdapter.Fill(myTable)
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
            Return myTable
        End Function

        Public Sub JCEInserNewRow(objJCEModel As JCEModel)
            Try
                JCEModelMapperIn(objJCEModel)
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

        Public Sub FillJCEModel(ByRef objJCEModel As JCEModel, JCEId As Integer)
            ClearCommand()

            Try
                Me.DBCommand.CommandText = "spJCETableGetModelById"
                With DBCommand.Parameters
                    .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = JCEId
                    .Add("@OpportunityId", SqlDbType.Int, ParameterDirection.Output)
                    .Add("@JCETitleName", SqlDbType.NVarChar, 500, ParameterDirection.Output)
                    .Add("@RevesionNum", SqlDbType.Int, ParameterDirection.Output)
                    .Add("@CreatedDate", SqlDbType.DateTime2, ParameterDirection.Output)
                    .Add("@TotalCost", SqlDbType.Money, ParameterDirection.Output)
                    .Add("@Strategy", SqlDbType.NVarChar, ParameterDirection.Output)
                End With
                Me.OpenConnection()
                DBCommand.ExecuteNonQuery()
                JCEModelMapperOut(objJCEModel)
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
        End Sub

        Public Sub JCEModelMapperIn(ByRef objJCEModel As JCEModel)
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

        Public Sub JCEModelMapperOut(ByRef objJCEModel As JCEModel)
            objJCEModel.Id = Me.DBCommand.Parameters("@Id").Value
            objJCEModel.OpportunityId = Me.DBCommand.Parameters("@OpportunityId").Value
            objJCEModel.JCETitleName = Me.DBCommand.Parameters("@JCETitleName").Value
            objJCEModel.RevesionNum = Me.DBCommand.Parameters("@RevesionNum").Value
            objJCEModel.CreatedDate = Me.DBCommand.Parameters("@CreatedDate").Value
            objJCEModel.TotalCost = Me.DBCommand.Parameters("@TotalCost").Value
            objJCEModel.Strategy = Me.DBCommand.Parameters("@Strategy").Value
        End Sub

    End Class
End Namespace

