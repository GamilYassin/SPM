

Imports System.Text
Imports System.Windows.Forms

Namespace SMPLibrary.DataLoger
    Public Class DataLoger

        Public Shared Function Log(Message As String, MessType As MessageType) As String
            Dim Result As String
            Dim Current As Date = Now()

            Result = Current.ToString
            Result += " : "
            Select Case MessType
                Case MessageType.CRITICAL_MESSAGE
                    Result += "[CRITICAL] "
                Case MessageType.ERROR_MESSAGE
                    Result += "[ERROR] "
                Case MessageType.EVENT_MESSAGE
                    Result += "[EVENT] "
                Case MessageType.EXCLAMATION_MESSAGE
                    Result += "[EXCLAMATION] "
                Case MessageType.INFORMATION_MESSAGE
                    Result += "[INFORMATION] "
                Case MessageType.QUESTION_MESSAGE
                    Result += "[QUESTION] "
                Case Else
                    Result += "[INFORMATION] "
            End Select
            Result += Message
            Return Result
        End Function

        Public Shared Sub LogTextFile(FileLocation As String, Message As String, MessType As MessageType)
            Dim Line As String = Log(Message, MessType)
            ' TODO - Add logic to log to text file
        End Sub

        Public Shared Sub LogListBox(ByRef lsbLogger As ListBox, Message As String, Optional MessType As MessageType = MessageType.INFORMATION_MESSAGE)
            lsbLogger.Items.Add(Log(Message, MessType))
        End Sub

    End Class
End Namespace
