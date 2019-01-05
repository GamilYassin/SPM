Imports System.Windows.Forms
Imports SMPData.SMPData


Namespace SMPData
    Public Class ListHandler
        Inherits MDFManager
        Implements IListHandler

        Public Sub InsertNewItem(ListName As ListNames, NewItem As String) Implements IListHandler.InsertNewItem
            Dim Count As Integer

            Me.DBCommand.CommandText = GetProcedure(ListName, ListOperations.CONTAINS)
            Me.DBCommand.Parameters.Clear()
            Count = MyBase.GetRecordsCount()

            If Count > 0 Then
                MsgBox("This item (" & NewItem & ") already exists in List " & GetProcedure(ListName, ListOperations.NAME))
            Else
                Try
                    Me.DBCommand.CommandText = GetProcedure(ListName, ListOperations.INSERT)
                    Me.DBCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = NewItem
                    Me.OpenConnection()
                    DBCommand.ExecuteNonQuery()
                    Me.CloseConnection()
                    ClearCommand()
                Catch ex As Exception
                    MsgBox(ex.Message)
                    CloseConnection()
                    ClearCommand()
                End Try
            End If
        End Sub

        Public Sub DeleteOneItem(ListName As ListNames, Item As String) Implements IListHandler.DeleteOneItem
            With Me.DBCommand
                .CommandText = GetProcedure(ListName, ListOperations.DELETE)
                .Parameters.Clear()
                .Parameters.Add("@Name", SqlDbType.NVarChar, 100, ParameterDirection.Input).Value = Item
            End With
            MyBase.DeleteRow()
        End Sub

        Public Sub UpdateOneItem(ListName As ListNames, oldName As String, NewName As String) Implements IListHandler.UpdateOneItem
            Me.DeleteOneItem(ListName, oldName)
            Me.InsertNewItem(ListName, NewName)
        End Sub

        Public Overloads Sub FillComboBox(ListName As ListNames, ByRef myComboBox As ComboBox) Implements IListHandler.FillComboBox
            With Me.DBCommand
                .CommandText = GetProcedure(ListName, ListOperations.SELECTALL)
                .Parameters.Clear()
            End With
            MyBase.FillComboBox(myComboBox)
        End Sub

        Public Function GetItemsCount(ListName As ListNames) As Integer Implements IListHandler.GetItemsCount
            Me.DBCommand.CommandText = GetProcedure(ListName, ListOperations.COUNT)
            Return MyBase.GetRecordsCount()
        End Function

        Public Function GetProcedure(ListName As ListNames, OperationType As ListOperations) As String Implements IListHandler.GetProecure
            If ListName = ListNames.PROJECT_STATUS Then
                Select Case OperationType
                    Case ListOperations.COUNT
                        Return "[spListProjectStatusCount]"
                    Case ListOperations.DELETE
                        Return "spListProjectStatusDelete"
                    Case ListOperations.INSERT
                        Return "spListProjectStatusAdd"
                    Case ListOperations.SELECTALL
                        Return "spListProjectStatusGetAll"
                    Case ListOperations.CONTAINS
                        Return "spListProjectStatusContains"
                    Case ListOperations.NAME
                        Return "Project_Status"
                End Select
            End If

        End Function

        Public Overloads Function FillList(ListName As ListNames) As List(Of String) Implements IListHandler.FillList
            With Me.DBCommand
                .CommandText = GetProcedure(ListName, ListOperations.SELECTALL)
                .Parameters.Clear()
            End With
            Return MyBase.FillList
        End Function
    End Class

    Public Enum ListNames As Integer
        PROJECT_STATUS
    End Enum

    Public Enum ListOperations As Integer
        CONTAINS
        COUNT
        DELETE
        INSERT
        SELECTALL
        NAME
    End Enum
End Namespace