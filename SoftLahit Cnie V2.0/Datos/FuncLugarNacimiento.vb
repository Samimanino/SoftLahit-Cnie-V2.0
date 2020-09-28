Imports System.Data.SqlClient
Public Class FuncLugarNacimiento

    Inherits Conexion

    Public Function Insertar_LugarNacimiento(ByVal TablaLugarNacimiento As Tabla_LugarNacimiento) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_LugarNacimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaLugarNacimiento._Nombre)



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
    Public Function Editar_LugarNacimiento(ByVal TablaLugarNacimiento As Tabla_LugarNacimiento) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_LugarNacimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaLugarNacimiento._ID)
            cmd.Parameters.AddWithValue("@Nombre", TablaLugarNacimiento._Nombre)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_LugarNacimiento(ByVal TablaLugarNacimiento As Tabla_LugarNacimiento) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_LugarNacimiento")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaLugarNacimiento._ID)



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

    Public Function Mostrar_cmb_LugarNacimiento()
        Try

            frm_Principal.cmb_lugarNacimiento.Items.Clear()

            Conectar()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from LugarNacimiento ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.cmb_lugarNacimiento.Items.Add(Drd("Nombre").ToString)
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

    Public Sub Mostrar_LugarNacimiento()
        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From LugarNacimiento order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_LugarNacimiento.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar_LugarNacimiento ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
