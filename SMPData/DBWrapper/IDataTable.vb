

Namespace DataBase_Operations
    Public Interface IDataTable

        Function Columns() As String()
        Function Name() As String

        Function Rows() As String()

        Sub AddColumn(ColumnName As String)
    End Interface

End Namespace


