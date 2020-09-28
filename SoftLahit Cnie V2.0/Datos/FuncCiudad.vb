Imports System.Data.SqlClient
Public Class FuncCiudad

    Inherits Conexion

    Public Function Insertar_Ciudad(ByVal TablaCiudad As Tabla_ciudad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_Ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaCiudad._Nombre)



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
    Public Function Editar_Ciudad(ByVal TablaCiudad As Tabla_ciudad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_Ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaCiudad._ID)
            cmd.Parameters.AddWithValue("@Nombre", TablaCiudad._Nombre)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_Ciudad(ByVal TablaCiudad As Tabla_ciudad) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_Ciudad")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaCiudad._ID)



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

    Public Function Mostrar_cmb_Ciudad()
        Try
            frm_Principal.cmb_Profession.Items.Clear()

            Conectar()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from Ciudad ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.Cmb_Ciudad.Items.Add(Drd("Nombre").ToString)
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

    Public Sub Mostrar_Ciudad()
        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From Ciudad order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_Ciudad.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar_Ciudad ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
