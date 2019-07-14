


Namespace DataBase_Operations
    Public MustInherit Class TextDataTable
        Implements IDataTable

        Public Sub AddColumn(ColumnName As String) Implements IDataTable.AddColumn
            Throw New NotImplementedException()
        End Sub

        Public Function Columns() As String() Implements IDataTable.Columns
            Throw New NotImplementedException()
        End Function

        Public Function Name() As String Implements IDataTable.Name
            Throw New NotImplementedException()
        End Function

        Public Function Rows() As String() Implements IDataTable.Rows
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace


