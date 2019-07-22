

Namespace SMPLibrary.Models
    Public MustInherit Class TableHandler

        Public Name As String

        Protected xRowsCount As Integer
        Protected xColumnsCount As Integer
        Protected xColumnsHeaders As List(Of String)

        Public Sub New()
            Me.xRowsCount = 0
            Me.xColumnsCount = 0
            Me.xColumnsHeaders = New List(Of String)


        End Sub


        Protected Sub Insert()



        End Sub


        Protected Sub Delete()



        End Sub


        Protected Sub Update()


        End Sub


        Protected Sub Load()


        End Sub

    End Class





End Namespace


