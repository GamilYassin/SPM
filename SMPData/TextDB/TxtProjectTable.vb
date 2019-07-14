

Namespace DataBase_Operations
    Public Class TxtProjectTable
        Inherits TextDataTable

        Public Const _Name As String = "ProjectTable"

        Private _Columns As Integer
        Private _rows As Integer

        Public Sub New()
            Me._Columns = 0
            Me._rows = 0
        End Sub

        Public Overloads Function Name() As String
            Return _Name
        End Function

        Public Overloads Sub AddColumn(ColumnName As String)

        End Sub

    End Class



End Namespace


