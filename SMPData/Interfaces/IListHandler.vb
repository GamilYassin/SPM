
Imports System.Windows.Forms


Namespace SMPData
    Public Interface IListHandler
        Function GetItemsCount(ListName As ListNames) As Integer
        Sub InsertNewItem(ListName As ListNames, NewItem As String)
        Sub DeleteOneItem(ListName As ListNames, Item As String)
        Sub UpdateOneItem(ListName As ListNames, oldName As String, NewName As String)
        Sub FillComboBox(ListName As ListNames, ByRef myComboBox As ComboBox)
        Function FillList(ListName As ListNames) As List(Of String)
        Function GetProecure(ListName As ListNames, OperationType As ListOperations) As String
    End Interface
End Namespace