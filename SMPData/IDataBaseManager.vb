
Imports SMPLibrary.SMPLibrary

''' <summary>
''' This interface contains all database operations
''' </summary>
Public Interface IDataBaseManager
    ReadOnly Property GetConnectionString() As String
    ReadOnly Property GetConnectionStatus() As DBConnectionStatus

    Function TestDBConnection() As FunRet
    Function SelectAllRecords(spName As String) As DataTable
    Function SelectById(spName As String, Id As Integer) As DataTable

    Function SaveProject() As FunRet

    Function Backup() As FunRet
    Function CoptO(ByVal FolderLocation As String) As FunRet
End Interface
