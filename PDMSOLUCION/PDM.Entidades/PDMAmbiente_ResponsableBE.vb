Public Class PDMAmbiente_ResponsableBE
    Public Property idAmbienteResponsable As Integer
    Public Property idAmbiente As Integer
    Public Property idResponsable As Integer
    Public Property idLogin As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idAmbienteResponsable = 0
        idAmbiente = 0
        idResponsable = 0
        idLogin = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub

End Class
