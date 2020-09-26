Public Class Tabla_barrio

    Private ID As Integer
    Private Nombre As String


    Public Property _ID As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property


End Class
