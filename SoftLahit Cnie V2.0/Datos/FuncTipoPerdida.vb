Imports System.Data.SqlClient
Public Class FuncTipoPerdida

    Inherits Conexion

    Public Function Insertar_TipoPerdida(ByVal TablaTipoPerdida As Tabla_TipoPerdida) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Insertar_TipoPerdida")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaTipoPerdida._Nombre)



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

    Public Function Editar_TipoPerdida(ByVal TablaTipoPerdida As Tabla_TipoPerdida) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_TipoPerdida")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaTipoPerdida._ID)
            cmd.Parameters.AddWithValue("@Nombre", TablaTipoPerdida._Nombre)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
    Public Function Eliminar_TipoPerdida(ByVal TablaTipoPerdida As Tabla_TipoPerdida) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_TipoPerdida")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaTipoPerdida._ID)



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

    Public Function Mostrar_cmb_TipoPerdida()
        Try

            frm_Principal.cmb_TipoPerdida.Items.Clear()

            Conectar()
            With cmd
                .CommandType = CommandType.Text
                .CommandText = "select Nombre from TipoPerdida ORDER BY Nombre asc"
                .Connection = Con
            End With

            Drd = cmd.ExecuteReader()

            While Drd.Read()
                frm_Principal.cmb_TipoPerdida.Items.Add(Drd("Nombre").ToString)
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

    Public Sub Mostrar_TipoPerdida()
        Dim adapt As New SqlDataAdapter
        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, Nombre From TipoPerdida order by nombre asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_TipoPerdida.dgv_Principal.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar_TipoPerdida ")
            Desconectar()
            Con.Dispose()
        End Try

    End Sub

End Class
