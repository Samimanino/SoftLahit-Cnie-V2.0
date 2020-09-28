Imports System.Data.SqlClient
Public Class FuncBarrio

    Inherits Conexion

    Public Function Insertar_Barrio(ByVal TablaBarrio As Tabla_barrio) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_Barrio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaBarrio._Nombre)



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
    Public Function Editar_Barrio(ByVal TablaBarrio As Tabla_barrio) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_Barrio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaBarrio._ID)
            cmd.Parameters.AddWithValue("@Nombre", TablaBarrio._Nombre)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_Barrio(ByVal TablaBarrio As Tabla_barrio) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_Barrio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaBarrio._ID)



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

    Public Function Mostrar_cmb_Barrio()
        Try

            frm_Principal.cmb_barrio.Items.Clear()

            Conectar()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from Barrio ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.cmb_barrio.Items.Add(Drd("Nombre").ToString)
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

    Public Sub Mostrar_Barrio()
        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From Barrio order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_barrio.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar_Barrio ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
