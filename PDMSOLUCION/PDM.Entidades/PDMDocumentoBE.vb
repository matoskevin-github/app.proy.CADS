Public Class PDMDocumentoBE
    Public Property idDocumento As Integer
    Public Property idLogin As Integer
    Public Property Detalle As String
    Public Property Estado As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idDocumento = 0
        idLogin = 0
        Detalle = String.Empty
        Estado = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub

End Class
