



Namespace DataBase_Operations

    ''' <summary>
    ''' This class wraps database operations
    ''' later database can have different implementations (text, json, xml, mdf, etc..)
    ''' It contains main data base operations (Add row, get row, rows count, 
    ''' </summary>
    Public MustInherit Class dbWrapper
        Implements IdbWrapper

        Public Sub SaveRow(Country As String, dbTable As IDataTable, MyDataRow As String) Implements IdbWrapper.SaveRow
            Throw New NotImplementedException()
        End Sub

        Public Sub WriteHeader(Country As String, dbTable As IDataTable) Implements IdbWrapper.WriteHeader
            Throw New NotImplementedException()
        End Sub

        Public Function GetRow(Country As String, dbTable As IDataTable, RowIndex As Integer) As DataRow Implements IdbWrapper.GetRow
            Dim Result_row As DataRow

            'ToDo: Add logic to restore a row
            Return Result_row
        End Function


        Public Function RowsCount(Country As String, dbTable As IDataTable) As Integer Implements IdbWrapper.RowsCount
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace


