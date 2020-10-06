Imports System.Data.SqlClient
Public Class FuncNacionalidad

    Inherits Conexion

    Public Function Insertar_Nacionalidad(ByVal TablaNacionalidad As Tabla_Nacionalidad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_Nacionalidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaNacionalidad._Nombre)

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
    Public Function Editar_Nacionalidad(ByVal TablaNacionalidad As Tabla_Nacionalidad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_Nacionalidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaNacionalidad._ID)
            cmd.Parameters.AddWithValue("@Nombre", TablaNacionalidad._Nombre)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_Nacionalidad(ByVal TablaNacionalidad As Tabla_Nacionalidad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_Nacionalidad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaNacionalidad._ID)



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


    Public Function Mostrar_cmb_Nacionalidad()
        Try
            frm_Principal.cmb_nacionalidad.Items.Clear()

            Conectar()

            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from Nacionalidad ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.cmb_nacionalidad.Items.Add(Drd("Nombre").ToString)
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

    Public Sub Mostrar_Nacionalidad()

        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From Nacionalidad order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_Nacionalidad.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
