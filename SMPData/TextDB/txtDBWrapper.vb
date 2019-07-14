


Namespace DataBase_Operations
    Public Class txtDBWrapper
        Implements IdbWrapper

        Public Const DELIMITER As String = "~"
        Public Sub SaveRow(Country As String, dbTable As IDataTable, MyDataRow As String) Implements IdbWrapper.SaveRow

            If dbTable.Columns().Count < 0 Then
                MsgBox("Error 1: Data Table " & dbTable.Name & " is empty (0 Columns or 0 Rows)", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim TableLocation As String = dbStorage.TableStorage_Location(Country, dbTable.Name, DbType.TEXT_DB)

            Using StreamWrtr As IO.StreamWriter = New IO.StreamWriter(TableLocation)
                StreamWrtr.Write(MyDataRow & Environment.NewLine)

                'For NextRow As Integer = 0 To dbTable.Rows().Count - 1
                '    For NextColumn As Integer = 0 To dbTable.Columns().Count - 1
                '        StreamWrtr.Write(dbTable.Rows()(NextRow).ToString & DELIMITER)
                '    Next
                '    StreamWrtr.Write(dbTable.Rows()(NextRow).ToString & Environment.NewLine)
                'Next

                'For col As Integer = 0 To table.Columns.Count - 2
                '    sw.Write(table.Rows(table.Rows.Count - 1).Item(col).ToString & DELIMITER)
                'Next
                'sw.Write(table.Rows(table.Rows.Count - 1).Item(table.Columns.Count - 1).ToString)
            End Using



        End Sub

        Public Sub WriteHeader(Country As String, dbTable As IDataTable) Implements IdbWrapper.WriteHeader

            If dbTable.Columns().Count < 0 Then
                MsgBox("Error 2: Data Table " & dbTable.Name & " is empty (0 Columns)", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim TableLocation As String = dbStorage.TableStorage_Location(Country, dbTable.Name, DbType.TEXT_DB)

            Using StreamWrtr As IO.StreamWriter = New IO.StreamWriter(TableLocation)
                For I As Integer = 0 To dbTable.Columns().Count - 1
                    StreamWrtr.Write(dbTable.Columns()(I).ToString & DELIMITER)
                Next
                StreamWrtr.Write(dbTable.Columns()(dbTable.Columns.Count - 1).ToString & Environment.NewLine)
            End Using
        End Sub

        Public Function GetRow(Country As String, dbTable As IDataTable, RowIndex As Integer) As DataRow Implements IdbWrapper.GetRow
            Throw New NotImplementedException()
        End Function

        Public Function RowsCount(Country As String, dbTable As IDataTable) As Integer Implements IdbWrapper.RowsCount
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace

