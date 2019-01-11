Imports System.Configuration

Public Class DatabaseFactorySectionHandler
    Public Property DbCnxStr As String

    Public Sub New()
        DbCnxStr = ConnectionString()
    End Sub

    Private Function ConnectionString() As String
        Dim SqlServerConnectionString As String = String.Empty
        Dim stringSettings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("DbCnx")

        If stringSettings Is Nothing OrElse String.IsNullOrEmpty(stringSettings.ConnectionString) Then
            Throw New Exception("Error fatal: falta la cadena de conexión en el archivo web.config")
        Else
            SqlServerConnectionString = stringSettings.ConnectionString
        End If

        Return SqlServerConnectionString
    End Function
End Class
