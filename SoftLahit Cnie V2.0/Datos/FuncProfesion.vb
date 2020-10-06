Imports System.Data.SqlClient
Public Class FuncProfesion

    Inherits Conexion

    Public Function Insertar_Profesion(ByVal Tablaprofesion As Tabla_Profesion) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_Profesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", Tablaprofesion._Nombre)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Editar_profesion(ByVal Tablaprofesion As Tabla_Profesion) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_profesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", Tablaprofesion._ID)
            cmd.Parameters.AddWithValue("@Nombre", Tablaprofesion._Nombre)

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_Profesion(ByVal Tablaprofesion As Tabla_Profesion) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_Profesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", Tablaprofesion._ID)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function

    Public Function Mostrar_cmb_Profesion()
        Try
            frm_Principal.cmb_Profesion.Items.Clear()
            If Con.State = ConnectionState.Closed Then
                Conectar()
            End If

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from Profesion ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.cmb_Profesion.Items.Add(Drd("Nombre").ToString)
                frm_Principal.cmb_bu_Profesion.Items.Add(Drd("Nombre").ToString)
            End While

            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False

        Finally
            Drd.Close()
            Drd = Nothing
            cmd = Nothing
            Desconectar()
        End Try

    End Function


    Public Sub Mostrar_profecion()
        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From Profesion order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_Profesion.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
