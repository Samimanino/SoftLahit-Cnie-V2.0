Public Class Tabla_Cliente

    Dim ID As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Genero As String
    Dim Nacionalidad As String
    Dim Fecha_nacimiento As Date
    Dim LugarNacimiento As String
    Dim Nombre_padre As String
    Dim Nombre_madre As String
    Dim Estado_civil As String
    Dim Profession As String
    Dim Numero_direccion As Integer
    Dim Nombre_calle As String
    Dim Bario As String
    Dim Ciudad As String
    Dim Cnie As String
    Dim num_passaporte As String
    Dim num_permiso_conducir As String
    Dim Imagen() As Byte
    Dim Fecha_ulti_modi As Date
    Dim isDelete As Boolean

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

    Public Property _Apellido As String
        Get
            Return Apellido
        End Get
        Set(value As String)
            Apellido = value
        End Set
    End Property

    Public Property _Genero As String
        Get
            Return Genero
        End Get
        Set(value As String)
            Genero = value
        End Set
    End Property

    Public Property _Nacionalidad As String
        Get
            Return Nacionalidad
        End Get
        Set(value As String)
            Nacionalidad = value
        End Set
    End Property

    Public Property _Fecha_nacimiento As Date
        Get
            Return Fecha_nacimiento
        End Get
        Set(value As Date)
            Fecha_nacimiento = value
        End Set
    End Property

    Public Property _LugarNacimiento As String
        Get
            Return LugarNacimiento
        End Get
        Set(value As String)
            LugarNacimiento = value
        End Set
    End Property

    Public Property _Nombre_padre As String
        Get
            Return Nombre_padre
        End Get
        Set(value As String)
            Nombre_padre = value
        End Set
    End Property

    Public Property _Nombre_madre As String
        Get
            Return Nombre_madre
        End Get
        Set(value As String)
            Nombre_madre = value
        End Set
    End Property

    Public Property _Estado_civil As String
        Get
            Return Estado_civil
        End Get
        Set(value As String)
            Estado_civil = value
        End Set
    End Property

    Public Property _Profession As String
        Get
            Return Profession
        End Get
        Set(value As String)
            Profession = value
        End Set
    End Property

    Public Property _Numero_direccion As Integer
        Get
            Return Numero_direccion
        End Get
        Set(value As Integer)
            Numero_direccion = value
        End Set
    End Property

    Public Property _Nombre_calle As String
        Get
            Return Nombre_calle
        End Get
        Set(value As String)
            Nombre_calle = value
        End Set
    End Property

    Public Property _Bario As String
        Get
            Return Bario
        End Get
        Set(value As String)
            Bario = value
        End Set
    End Property

    Public Property _Ciudad As String
        Get
            Return Ciudad
        End Get
        Set(value As String)
            Ciudad = value
        End Set
    End Property

    Public Property _Cnie As String
        Get
            Return Cnie
        End Get
        Set(value As String)
            Cnie = value
        End Set
    End Property

    Public Property _Num_passaporte As String
        Get
            Return num_passaporte
        End Get
        Set(value As String)
            num_passaporte = value
        End Set
    End Property

    Public Property _Num_permiso_conducir As String
        Get
            Return num_permiso_conducir
        End Get
        Set(value As String)
            num_permiso_conducir = value
        End Set
    End Property

    Public Property _Imagen As Byte()
        Get
            Return Imagen
        End Get
        Set(value As Byte())
            Imagen = value
        End Set
    End Property

    Public Property _Fecha_ulti_modi As Date
        Get
            Return Fecha_ulti_modi
        End Get
        Set(value As Date)
            Fecha_ulti_modi = value
        End Set
    End Property

    Public Property _IsDelete As Boolean
        Get
            Return isDelete
        End Get
        Set(value As Boolean)
            isDelete = value
        End Set
    End Property


End Class
