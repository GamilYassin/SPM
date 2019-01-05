

Imports System.Data
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports SMPLibrary.SMPLibrary.Models
Imports System.Windows.Forms

Namespace SMPData
    Public Class ProjectTeamHandler
        Inherits MDFManager
        Implements ITableHandler

        Public Sub New()
            MyBase.New
        End Sub


        Public Function SelectAllRecords() As DataTable Implements ITableHandler.SelectAllRecords
            Me.DBCommand.CommandText = "spProjectTeamTableSelectAll"
            Return MyBase.GetAllRecords()
        End Function

        Public Function SelectById(Id As Integer) As DataTable Implements ITableHandler.SelectById
            With Me.DBCommand
                .Parameters.Clear()
                .CommandText = "spProjectTeamTableSelectById"
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
            End With
            Return MyBase.FilterData()
        End Function

        Public Function GetMaxId() As Integer Implements ITableHandler.GetMaxId
            Me.DBCommand.CommandText = "spProjectTeamTableMaxId"
            Return MyBase.GetMaxIdNumber()
        End Function

        Public Function GetRowsCount() As Integer Implements ITableHandler.GetRowsCount
            Me.DBCommand.CommandText = "[spProjectTeamTableRowsCount]"
            Return MyBase.GetRecordsCount()
        End Function

        Public Sub FillModel(Id As Integer) Implements ITableHandler.FillModel
            Throw New NotImplementedException()
        End Sub

        Public Sub FillModel(ByRef objProjectTeamModel As ProjectTeamModel, Id As Integer)
            Dim DBDataReader As SqlDataReader

            Try
                Me.DBCommand.CommandText = "spProjectTeamTableSelectById"
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = Id
                Me.OpenConnection()
                DBDataReader = DBCommand.ExecuteReader()
                ProjectTeamModelMapperOut(objProjectTeamModel, DBDataReader)
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

        Public Sub InsertNewRow(objProjectTeamModel As ProjectTeamModel)
            Try
                ModelMapIn(objProjectTeamModel)
                Me.DBCommand.CommandText = "spProjectTeamTableInsertRow"
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

        Public Sub UpdateOneRow(RowId As Integer, obProjectTeamModel As ProjectTeamModel)
            ModelMapIn(obProjectTeamModel)
            Me.DBCommand.CommandText = "spProjectTeamTableUpdateRow"
            MyBase.UpdateRow()
        End Sub

        Public Sub DeleteOneRow(RowId As Integer) Implements ITableHandler.DeleteOneRow
            With Me.DBCommand
                .CommandText = "spProjectTeamTableDeleteRow"
                .Parameters.Clear()
                .Parameters.Add("@id", SqlDbType.Int, ParameterDirection.Input).Value = RowId
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub ModelMapIn() Implements ITableHandler.ModelMapIn
            Throw New NotImplementedException()
        End Sub


        Public Sub ModelMapIn(ByRef objProjectTeamModel As ProjectTeamModel)
            ClearCommand()

            With Me.DBCommand.Parameters
                .Add("@Id", SqlDbType.Int, ParameterDirection.Input).Value = objProjectTeamModel.Id
                .Add("@SalesMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.SalesMgr
                .Add("@ComOpsMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.ComOpsMgr
                .Add("@ProjectMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.ProjectMgr
                .Add("@ProjectEng", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.ProjectEng
                .Add("@HMIEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.HMIEngr
                .Add("@ControlsEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.ControlsEngr
                .Add("@ElectricalEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.ElectricalEngr
                .Add("@MechanicalEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.MechanicalEngr
                .Add("@DCSEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = objProjectTeamModel.DCSEngr
            End With
        End Sub


        Public Sub ModelMapOut() Implements ITableHandler.ModelMapOut
            Throw New NotImplementedException()
        End Sub

        Public Sub ProjectTeamModelMapperOut(ByRef objProjectTeamModel As ProjectTeamModel)
            objProjectTeamModel.Id = Me.DBCommand.Parameters("@Id").Value
            objProjectTeamModel.SalesMgr = Me.DBCommand.Parameters("@SalesMgr").Value
            objProjectTeamModel.ComOpsMgr = Me.DBCommand.Parameters("@ComOpsMgr").Value
            objProjectTeamModel.ProjectMgr = Me.DBCommand.Parameters("@ProjectMgr").Value
            objProjectTeamModel.ProjectEng = Me.DBCommand.Parameters("@ProjectEng").Value
            objProjectTeamModel.HMIEngr = Me.DBCommand.Parameters("@HMIEngr").Value
            objProjectTeamModel.ControlsEngr = Me.DBCommand.Parameters("@ControlsEngr").Value
            objProjectTeamModel.ElectricalEngr = Me.DBCommand.Parameters("@ElectricalEngr").Value
            objProjectTeamModel.MechanicalEngr = Me.DBCommand.Parameters("@MechanicalEngr").Value
            objProjectTeamModel.DCSEngr = Me.DBCommand.Parameters("@DCSEngr").Value
        End Sub

        Public Sub ProjectTeamModelMapperOut(ByRef objProjectTeamModel As ProjectTeamModel, ByRef DBDataReader As SqlDataReader)
            If DBDataReader.Read() Then
                objProjectTeamModel.Id = DBDataReader.Item(0)
                objProjectTeamModel.SalesMgr = DBDataReader.Item(1)
                objProjectTeamModel.ComOpsMgr = DBDataReader.Item(2)
                objProjectTeamModel.ProjectMgr = DBDataReader.Item(3)
                objProjectTeamModel.ProjectEng = DBDataReader.Item(4)
                objProjectTeamModel.HMIEngr = DBDataReader.Item(5)
                objProjectTeamModel.ControlsEngr = DBDataReader.Item(6)
                objProjectTeamModel.ElectricalEngr = DBDataReader.Item(7)
                objProjectTeamModel.MechanicalEngr = DBDataReader.Item(8)
                objProjectTeamModel.DCSEngr = DBDataReader.Item(9)
            End If
        End Sub


        Public Function SelectProjectTeamByComOpsMgr(ComOpsMgr As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectTeamTableSelectByComOpsMgr"
                .Parameters.Clear()
                .Parameters.Add("@ComOpsMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = ComOpsMgr
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectProjectTeamByControlsEngr(ControlsEngr As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectTeamTableByControlsEngr"
                .Parameters.Clear()
                .Parameters.Add("@ControlsEngr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = ControlsEngr
            End With
            Return MyBase.FilterData()
        End Function


        Public Function SelectProjectTeamByProjectMgr(ProjectMgr As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectTeamTableByProjectMgr"
                .Parameters.Clear()
                .Parameters.Add("@ProjectMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = ProjectMgr
            End With
            Return MyBase.FilterData()
        End Function

        Public Function SelectProjectTeamBySalesMgr(SalesMgr As String) As DataTable
            With Me.DBCommand
                .CommandText = "spProjectTeamTableBySM"
                .Parameters.Clear()
                .Parameters.Add("@SalesMgr", SqlDbType.NVarChar, 200, ParameterDirection.Input).Value = SalesMgr
            End With
            Return MyBase.FilterData()
        End Function

        Public Overloads Sub ITableHandler_FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable) Implements ITableHandler.FillDataGridView
            MyBase.FillDataGridView(myDataGrid, myTable)
        End Sub
    End Class
End Namespace


