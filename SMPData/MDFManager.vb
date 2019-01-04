
Imports SMPLibrary.SMPLibrary
Imports SMPData
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary.Models

Namespace SMPData
    Public Class MDFManager
        Implements IDataBaseManager

        Protected dbConnectionStringText As String

        Protected DBConnection As SqlConnection
        Protected DBCommand As SqlCommand
        Protected DBAdapter As SqlDataAdapter

        Public Sub New()
            Me.dbConnectionStringText = ConfigurationManager.AppSettings("ConnectionString")
            Me.DBConnection = New SqlConnection(dbConnectionStringText)
            Me.DBCommand = New SqlCommand()
            Me.DBCommand.Connection = Me.DBConnection
            Me.DBCommand.CommandType = CommandType.StoredProcedure
            DBAdapter = New SqlDataAdapter
        End Sub

        Public ReadOnly Property GetConnectionString As String Implements IDataBaseManager.GetConnectionString
            Get
                Return Me.dbConnectionStringText
            End Get
        End Property


        Public ReadOnly Property GetConnectionStatus As DBConnectionStatus Implements IDataBaseManager.GetConnectionStatus
            Get
                Select Case Me.DBConnection.State
                    Case ConnectionState.Closed
                        Return DBConnectionStatus.Closed
                    Case ConnectionState.Open
                        Return DBConnectionStatus.Open
                    Case ConnectionState.Connecting
                        Return DBConnectionStatus.Open
                    Case ConnectionState.Executing
                        Return DBConnectionStatus.Open
                    Case ConnectionState.Fetching
                        Return DBConnectionStatus.Open
                    Case ConnectionState.Broken
                        Return DBConnectionStatus.Open
                    Case Else
                        Return DBConnectionStatus.Closed
                End Select
            End Get
        End Property


        Public ReadOnly Property GetConnectionRawStatus As ConnectionState
            Get
                Return Me.DBConnection.State
            End Get
        End Property


        Public ReadOnly Property GetConnection() As SqlConnection Implements IDataBaseManager.GetConnection
            Get
                Return Me.DBConnection
            End Get
        End Property


        Public Function OpenConnection() As FunRet Implements IDataBaseManager.OpenConnection
            Try
                DBConnection.Open()
                If DBConnection.State = ConnectionState.Open Then
                    Return FunRet.Succeded
                Else
                    Return FunRet.Failed
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return FunRet.Exception
            End Try
        End Function


        Public Function CloseConnection() As FunRet Implements IDataBaseManager.CloseConnection
            Try
                DBConnection.Close()
                If DBConnection.State = ConnectionState.Closed Then
                    Return FunRet.Succeded
                Else
                    Return FunRet.Failed
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return FunRet.Exception
            End Try
        End Function


        Public Function TestDBConnection() As FunRet Implements IDataBaseManager.TestDBConnection
            Dim Result As FunRet

            Result = Me.OpenConnection()
            If Me.GetConnectionRawStatus <> ConnectionState.Closed Then Me.CloseConnection()
            Return Result
        End Function

        Public Function Backup() As FunRet Implements IDataBaseManager.Backup
            Throw New NotImplementedException()
        End Function

        Public Function CopyTo(ByVal FolderLocation As String) As FunRet Implements IDataBaseManager.CopyTo
            Throw New NotImplementedException()
        End Function

        Protected Sub ClearCommand()
            With Me.DBCommand
                '.CommandText = ""
                .Parameters.Clear()
            End With
        End Sub

        Protected Function FilterData() As DataTable
            Dim myTable As New DataTable()

            Try
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

        Protected Function GetAllRecords() As DataTable
            Dim myTable As New DataTable()

            Try
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

        Protected Function GetMaxIdNumber() As Integer
            Dim maxId As Integer = 0

            Try
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@maxID", SqlDbType.Int)
                Me.DBCommand.Parameters("@maxID").Direction = ParameterDirection.Output
                Me.OpenConnection()
                Me.DBCommand.ExecuteNonQuery()
                maxId = Me.DBCommand.Parameters("@maxID").Value
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
            Return maxId
        End Function

        Protected Function GetRecordsCount() As Integer
            Dim RowsCount As Integer = 0

            Try
                Me.DBCommand.Parameters.Clear()
                Me.DBCommand.Parameters.Add("@RowsCount", SqlDbType.Int)
                Me.DBCommand.Parameters("@RowsCount").Direction = ParameterDirection.Output
                Me.OpenConnection()
                Me.DBCommand.ExecuteNonQuery()
                RowsCount = Me.DBCommand.Parameters("@RowsCount").Value
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
            Return RowsCount
        End Function

        Protected Sub UpdateRow()
            Try
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

        Protected Sub DeleteRow()
            Try
                Me.OpenConnection()
                Me.DBCommand.ExecuteNonQuery()
                Me.CloseConnection()
                ClearCommand()
            Catch ex As Exception
                MsgBox(ex.Message)
                CloseConnection()
                ClearCommand()
            End Try
        End Sub
    End Class
End Namespace

