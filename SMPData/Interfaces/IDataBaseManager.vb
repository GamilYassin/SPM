
Imports System.Data.SqlClient
Imports SMPLibrary.SMPLibrary


Namespace SMPData
    ''' <summary>
    ''' This interface contains all database operations
    ''' </summary>
    Public Interface IDataBaseManager
        ReadOnly Property GetConnectionString() As String
        ReadOnly Property GetConnection() As SqlConnection
        ReadOnly Property GetConnectionStatus() As DBConnectionStatus

        Function TestDBConnection() As FunRet
        Function OpenConnection() As FunRet
        Function CloseConnection() As FunRet

        Function Backup() As FunRet
        Function CopyTo(ByVal FolderLocation As String) As FunRet
    End Interface
End Namespace