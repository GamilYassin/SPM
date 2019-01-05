

Imports System.Windows.Forms


Namespace SMPData
    Public Interface ITableHandler

        '' Select Procedures
        Function SelectAllRecords() As DataTable
        Function SelectById(Id As Integer) As DataTable
        Sub FillModel(Id As Integer)

        '' Agregate functions
        Function GetMaxId() As Integer
        Function GetRowsCount() As Integer

        '' Insert Procedures
        Sub InsertNewRow()

        '' Update Procedures     
        Sub UpdateOneRow(RowId As Integer)

        '' Delete Procedures     
        Sub DeleteOneRow(RowId As Integer)

        '' Mapping
        Sub ModelMapIn()
        Sub ModelMapOut()

        Sub FillDataGridView(ByRef myDataGrid As DataGridView, myTable As DataTable)
    End Interface
End Namespace