Imports System.Data.SqlClient
Public Class FuncHistorialCliente

    Inherits Conexion

    Public Function Insertar_HistorialCliente(ByVal TablaHistorialCliente As Tabla_HistorialCliente) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("insertar_HistorialCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID_Cliente", TablaHistorialCliente._ID_Cliente)
            cmd.Parameters.AddWithValue("@TipoPerdida", TablaHistorialCliente._TipoPerdida)
            cmd.Parameters.AddWithValue("@Observacion", TablaHistorialCliente._Observacion)
            cmd.Parameters.AddWithValue("@fecha_alta", TablaHistorialCliente._Fecha_alta)
            cmd.Parameters.AddWithValue("@fecha_modi", TablaHistorialCliente._Fecha_modi)

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

    Public Function Editar_HistorialCliente(ByVal TablaHistorialCliente As Tabla_HistorialCliente) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_HistorialCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaHistorialCliente._ID)
            cmd.Parameters.AddWithValue("@TipoPerdida", TablaHistorialCliente._TipoPerdida)
            cmd.Parameters.AddWithValue("@Observacion", TablaHistorialCliente._Observacion)
            cmd.Parameters.AddWithValue("@fecha_modi", TablaHistorialCliente._Fecha_modi)



            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function

    Public Function Eliminar_HistorialCliente(ByVal TablaHistorialCliente As Tabla_HistorialCliente) As Boolean


        Try
            Conectar()
            cmd = New SqlCommand("Eliminar_HistorialCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaHistorialCliente._ID)

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

    Public Sub Mostrar_HistorialCliente()

        Dim adapt As New SqlDataAdapter

        Dim id_cliente As Integer

        id_cliente = frm_Principal.lbl_id.Text

        Try
            Conectar()
            adapt = New SqlDataAdapter("Select ID, ID_Cliente, TipoPerdida, Observacion, fecha_alta, fecha_modi From HistorialCliente where id_cliente = '" & id_cliente & "' order by fecha_alta asc", Con)
            dat = New DataTable
            adapt.Fill(dat)
            frm_Principal.dgv_HistorialCliente.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Mostrar_HistorialClientexxx ")
            Desconectar()
        End Try

    End Sub




    Public Function Mostrar_cmb_HistorialCliente()
        Try
            frm_Principal.Cmb_Ciudad.Items.Clear()

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


End Class
