Public Class PDMAmbientesBE
    Public Property idAmbiente As Integer
    Public Property Detalle As String
    Public Property idPabellon As Integer
    Public Property idPisos As Integer
    Public Property idLogin As Integer
    Public Property Estado As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idAmbiente = 0
        Detalle = String.Empty
        idPabellon = 0
        idPisos = 0
        idLogin = 0
        Estado = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub
End Class
