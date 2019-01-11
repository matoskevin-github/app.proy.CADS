Public Class PDMPabellonBE
    Public Property idPabellon As Integer
    Public Property idLogin As Integer
    Public Property NomPabellon As String
    Public Property CantPisos As Integer
    Public Property CantAmbientes As Integer
    Public Property Estado As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idPabellon = 0
        idLogin = 0
        NomPabellon = String.Empty
        CantPisos = 0
        CantAmbientes = 0
        Estado = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub
End Class
