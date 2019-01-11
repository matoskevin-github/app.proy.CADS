Public Class PDMPisosBE
    Public Property idPisos As Integer
    Public Property idLogin As Integer
    Public Property NomPiso As String
    Public Property Estado As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idPisos = 0
        idLogin = 0
        NomPiso = String.Empty
        Estado = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub

End Class
