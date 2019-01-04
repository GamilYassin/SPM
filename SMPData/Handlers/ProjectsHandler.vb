
Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models

Namespace SMPData
    Public Class ProjectsHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spProjectsTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spProjectsTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spProjectsTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spProjectsTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objProjectsModel As ProjectsModel, Id As Integer)
            Dim DBDataReader As SqlDataReader

            Try
                Me.DBCommand.CommandText = "spProjectsTableSelectById"
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                ProjectsModelMapperOut(objProjectsModel, DBDataReader)
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

        Public Sub InsertNewRow(objProjectsModel As ProjectsModel)
            Try
                ModelMapIn(objProjectsModel)
                Me.DBCommand.CommandText = "spProjectsTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obProjectsModel As ProjectsModel)
            ModelMapIn(obProjectsModel)
            Me.DBCommand.CommandText = "spProjectsTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spProjectsTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub

        Public Sub ModelMapIn(ByRef objProjectsModel As ProjectsModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objProjectsModel.Id
                .Add("@Title", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objProjectsModel.Title
                .Add("@SAPDef", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objProjectsModel.SAPDef
                .Add("@PlantId", SqlDbType.Int, ParameterDirection.Input).Value = objProjectsModel.PlantId
                .Add("@EPC", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = objProjectsModel.EPC
                .Add("@TeamId", SqlDbType.Int, ParameterDirection.Input).Value = objProjectsModel.TeamId
                .Add("@Status", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = objProjectsModel.Status
                .Add("@SubCon", SqlDbType.NVarChar, 1000, ParameterDirection.Input).Value = objProjectsModel.SubCon
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub ProjectsModelMapperOut(ByRef objProjectsModel As ProjectsModel)
            objProjectsModel.Id = Me.DBCommand.Parameters("@Id").Value
            objProjectsModel.Title = Me.DBCommand.Parameters("@Title").Value
            objProjectsModel.SAPDef = Me.DBCommand.Parameters("@SAPDef").Value
            objProjectsModel.PlantId = Me.DBCommand.Parameters("@PlantId").Value
            objProjectsModel.EPC = Me.DBCommand.Parameters("@EPC").Value
            objProjectsModel.TeamId = Me.DBCommand.Parameters("@TeamId").Value
            objProjectsModel.Status = Me.DBCommand.Parameters("@Status").Value
            objProjectsModel.SubCon = Me.DBCommand.Parameters("@SubCon").Value
        End Sub

        Public Sub ProjectsModelMapperOut(ByRef objProjectsModel As ProjectsModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objProjectsModel.Id = DBDataReader.Item(0)
                objProjectsModel.Title = DBDataReader.Item(1)
                objProjectsModel.SAPDef = DBDataReader.Item(2)
                objProjectsModel.PlantId = DBDataReader.Item(3)
                objProjectsModel.EPC = DBDataReader.Item(4)
                objProjectsModel.TeamId = DBDataReader.Item(5)
                objProjectsModel.Status = DBDataReader.Item(6)
                objProjectsModel.SubCon = DBDataReader.Item(7)
            End If
        End Sub


        Public Function SelectProjectsByTitle(Title As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableByTitle"
                .Parameters.Clear()
                .Parameters.Add("@Title", SqlDbType.NVarChar, 500, ParameterDirection.Input).Value = Title
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectProjectsBySAPDef(SAPDef As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableSelectBySAPDef"
                .Parameters.Clear()
                .Parameters.Add("@SAPDef", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = SAPDef
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectProjectsByEPC(EPC As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableByEPC"
                .Parameters.Clear()
                .Parameters.Add("@EPC", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = EPC
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectProjectsByPlantId(PlantId As Integer) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableByPlantId"
                .Parameters.Clear()
                .Parameters.Add("@PlantId", SqlDbType.Int, ParameterDirection.Input).Value = PlantId
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectProjectsByStatus(Status As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableByStatus"
                .Parameters.Clear()
                .Parameters.Add("@Status", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = Status
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectProjectsBySubcon(SubCon As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectsTableBySubCon"
                .Parameters.Clear()
                .Parameters.Add("@SubCon", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = SubCon
            End With
            Return MyBase.FilterData()
        End Function
    End Class
End Namespace



