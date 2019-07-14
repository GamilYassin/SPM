



Namespace DataBase_Operations
    Public Interface IdbWrapper
        Function GetRow(Country As String, dbTable As IDataTable, RowIndex As Integer) As DataRow
        Sub SaveRow(Country As String, dbTable As IDataTable, MyDataRow As String)
        Function RowsCount(Country As String, dbTable As IDataTable) As Integer

        Sub WriteHeader(Country As String, dbTable As IDataTable)
    End Interface

End Namespace

