Public Class Tabla_HistorialCliente


    Private ID As Integer
    Private ID_Cliente As Integer
    Private TipoPerdida As String
    Private Observacion As String
    Private Fecha_alta As DateTime
    Private Fecha_modi As DateTime

    Public Property _ID As Integer
        Get
            Return ID
        End Get
        Set(value As Integer)
            ID = value
        End Set
    End Property

    Public Property _ID_Cliente As Integer
        Get
            Return ID_Cliente
        End Get
        Set(value As Integer)
            ID_Cliente = value
        End Set
    End Property

    Public Property _TipoPerdida As String
        Get
            Return TipoPerdida
        End Get
        Set(value As String)
            TipoPerdida = value
        End Set
    End Property

    Public Property _Observacion As String
        Get
            Return Observacion
        End Get
        Set(value As String)
            Observacion = value
        End Set
    End Property

    Public Property _Fecha_alta As Date
        Get
            Return Fecha_alta
        End Get
        Set(value As Date)
            Fecha_alta = value
        End Set
    End Property

    Public Property _Fecha_modi As Date
        Get
            Return Fecha_modi
        End Get
        Set(value As Date)
            Fecha_modi = value
        End Set
    End Property
End Class
