

Namespace SMPLibrary.Models
    Public Class ProjectModel
        Public Sequence_Id As Integer
        Public SAP_Def As String
        Public Plant_Id As Integer
        Public Team_Id As Integer
        Public Opportunity_Id As Integer
        Public Revenue_Id As Integer
        Public PO_Id As Integer
        Public Title As String
        Public Project_Type As String
        Public Status As String
        Public EPC As String
        Public SubCon As String
    End Class

    Public Class ProjectTable
        Inherits TableHandler

        Public Sub New()
            MyBase.New()
            MyBase.Name = "Projects_Table"
            MyBase.xColumnsCount = 12

            ' Table Columns Headers
            Me.xColumnsHeaders.Add("Sequence_Id")
            Me.xColumnsHeaders.Add("SAP_Def")
            Me.xColumnsHeaders.Add("Plant_Id")
            Me.xColumnsHeaders.Add("Team_Id")
            Me.xColumnsHeaders.Add("Opportunity_Id")
            Me.xColumnsHeaders.Add("Revenue_Id")
            Me.xColumnsHeaders.Add("PO_Id")
            Me.xColumnsHeaders.Add("Title")
            Me.xColumnsHeaders.Add("Project_Type")
            Me.xColumnsHeaders.Add("Status")
            Me.xColumnsHeaders.Add("EPC")
            Me.xColumnsHeaders.Add("SubCon")
        End Sub

        Public ReadOnly Property ProjectsCount()
            Get
                Return MyBase.xRowsCount
            End Get
        End Property





        Public Overloads Sub Insert()



            Me.xRowsCount += 1


        End Sub

        Public Overloads Sub Delete(xSequence_Id As Integer)



        End Sub


        Public Overloads Sub Update(xSequence_Id As Integer)



        End Sub


        Public Overloads Function Load(xSequence_Id As Integer) As ProjectModel



        End Function


        Public Overloads Function LoadAll() As List(Of ProjectModel)



        End Function


        Public Overloads Function NextId() As Integer


        End Function


        Public Function CustomersList() As List(Of String)



        End Function


        Public Function SubConList() As List(Of String)



        End Function

    End Class
End Namespace