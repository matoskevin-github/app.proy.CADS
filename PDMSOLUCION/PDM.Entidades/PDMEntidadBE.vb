Public Class PDMEntidadBE
    Public Property idEntidad As Integer
    Public Property idLogin As Integer
    Public Property Detalle As String
    Public Property estado As Integer
    Public Property fechaIngreso As DateTime
    Public Property fechaModificacion As DateTime

    Public Sub New()
        idEntidad = 0
        idLogin = 0
        Detalle = String.Empty
        estado = 0
        fechaIngreso = DateTime.Now
        fechaModificacion = DateTime.Now
    End Sub
End Class
