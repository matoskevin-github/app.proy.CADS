Public Class PDMResponsableBE

    Public Property idResponsable As Integer
    Public Property idUsuario As Integer
    Public Property Nombres As String
    Public Property Apellidos As String
    Public Property DNI As String
    Public Property Direccion As String
    Public Property Correo As String
    Public Property Celular As String
    Public Property EstadoCivil As String
    Public Property FechaNacimiento As DateTime
    Public Property idCargo As Integer
    Public Property Condicion As String
    Public Property FechaIngreso As DateTime
    Public Property Estado As Integer
    Public Property TipoUsuario As Integer
    Public Property FechaIngresoR As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idResponsable = 0
        Nombres = String.Empty
        Apellidos = String.Empty
        DNI = String.Empty
        Direccion = String.Empty
        Correo = String.Empty
        Celular = String.Empty
        EstadoCivil = String.Empty
        FechaNacimiento = DateTime.Now
        idCargo = 0
        Condicion = String.Empty
        FechaIngreso = DateTime.Now
        Estado = 0
        TipoUsuario = 0
        FechaIngresoR = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub
End Class
