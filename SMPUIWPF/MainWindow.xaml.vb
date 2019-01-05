Imports SMPData.SMPData

Class MainWindow
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim myJCE As New JCEHandler
        dataGrid.DataContext = myJCE.SelectAllRecords
        dataGrid.Items.Refresh()
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs) Handles button.Click
        Dim myJCE As New JCEHandler
        dataGrid.DataContext = myJCE.SelectAllRecords
        'myJCE.FillDataGridView(dataGrid, myJCE.SelectAllRecords)

    End Sub
End Class
