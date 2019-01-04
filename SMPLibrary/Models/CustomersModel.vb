

Namespace SMPLibrary.Models
    Public Class CustomersModel : Implements IModel

        Public Id As Integer
        Public Name As String
        Public PlantId As Integer
        Public Position As String
        Public PositionFunction As String
        Public Mobile As String
        Public Phone As String
        Public eMail As String

        Public ReadOnly Property GetId As Integer Implements IModel.GetId
            Get
                Return Me.Id
            End Get
        End Property
    End Class
End Namespace

