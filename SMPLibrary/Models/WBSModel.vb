

Namespace SMPLibrary.Models
    Public Class WBSModel
        Public Id As Integer
        Public ProjectId As Integer
        Public NetworkNumber As String
        Public Description As String
        Public SAPWBS As String
        Public WBSType As String
        Public Technology As String
        Public SAPProductLine As String
        Public TotalRev As Decimal
        Public TotalPlannedCost As Decimal
        Public TotalActualCost As Decimal
        Public ExpectedRevRecDate As DateTime
    End Class
End Namespace