﻿

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

End Interface