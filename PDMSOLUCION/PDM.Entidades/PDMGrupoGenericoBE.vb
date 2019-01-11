Public Class PDMGrupoGenericoBE
    Public Property idGrupoGenerico As Integer
    Public Property idLogin As Integer
    Public Property Codigo As String
    Public Property Detalle As String
    Public Property Estado As Integer
    Public Property FechaIngreso As DateTime
    Public Property FechaModificacion As DateTime

    Public Sub New()
        idGrupoGenerico = 0
        idLogin = 0
        Codigo = String.Empty
        Detalle = String.Empty
        Estado = 0
        FechaIngreso = DateTime.Now
        FechaModificacion = DateTime.Now
    End Sub
End Class
