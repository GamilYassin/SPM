

Namespace SMPLibrary.GlobalVars
    Public Class GlobalVars
        'Public Shared CustPosFunctions As List(Of String) = ["A1", "A2"]
    End Class

    Public Structure PosFuns
        Shared PosFunsList As New List(Of String)

        Shared Sub New()
            With PosFunsList
                .Add("Operations")
                .Add("Maintenance")
                .Add("Reliability")
                .Add("Managment")
                .Add("Procrement")
            End With
            SortPosFun()
        End Sub

        Shared Function GetPosFunction(Index As Integer) As String
            If Index < 0 Or Index > PosFunsList.Count - 1 Then
                Return ""
            End If
            Return PosFunsList(Index)
        End Function

        Shared Sub AddPosFun(NewPosFun As String)
            If Not PosFunsList.Contains(NewPosFun) Then
                PosFunsList.Add(NewPosFun)
            End If
            SortPosFun()
        End Sub

        Shared Sub SortPosFun()
            PosFunsList.Sort()
        End Sub
    End Structure

    Public Structure ProductLine
        Shared ProductLineList As New List(Of String)

        Shared Sub New()
            With ProductLineList
                .Add("Operations")
                .Add("Maintenance")
                .Add("Reliability")
                .Add("Managment")
                .Add("Procrement")
            End With
            SortPosFun()
        End Sub

        Shared Function GetPosFunction(Index As Integer) As String
            If Index < 0 Or Index > ProductLineList.Count - 1 Then
                Return ""
            End If
            Return ProductLineList(Index)
        End Function

        Shared Sub AddPosFun(NewPosFun As String)
            If Not ProductLineList.Contains(NewPosFun) Then
                ProductLineList.Add(NewPosFun)
            End If
            SortPosFun()
        End Sub

        Shared Sub SortPosFun()
            ProductLineList.Sort()
        End Sub
    End Structure
End Namespace