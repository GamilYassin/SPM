

Imports System.IO

Namespace DataBase_Operations
    Public Class dbStorage

        Public Shared Function TableStorage_Location(Country As String, TableName As String, dbType As DbType) As String
            Dim Location As String = Directory.GetCurrentDirectory()

            Select Case dbType
                Case DbType.TEXT_DB
                    Location = Path.Combine(Location, "TextDb", Country.ToString)
                    Location = Path.Combine(Location, TableName)
                Case DbType.JSON_DB
                    Throw New NotImplementedException()
                Case DbType.MDF_DB
                    Throw New NotImplementedException()
                Case DbType.XML_DB
                    Throw New NotImplementedException()
            End Select

            Return Location

        End Function






    End Class

    Public Enum DbType As Integer
        TEXT_DB = 0
        XML_DB
        JSON_DB
        MDF_DB
    End Enum

    Public Enum CountryList As Integer
        SAUDI = 0
        EGYPT
        JORDON
        LEBANON
    End Enum
End Namespace


