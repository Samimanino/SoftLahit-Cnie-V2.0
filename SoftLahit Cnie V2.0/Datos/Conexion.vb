Imports System.Data.SqlClient

Public Class Conexion

    Protected Con As New SqlConnection
    Protected cmd As New SqlCommand
    Protected dat As New DataTable
    Protected adap As New SqlDataAdapter
    Protected Drd As SqlDataReader

    Protected Function Conectar()
        Try
            Con = New SqlConnection(My.Settings.Con)
            Con.Open()
            Return True
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

    Protected Function Desconectar()
        Try
            If Con.State = ConnectionState.Open Then
                Con.Dispose()
                Return True
            Else
                Return False
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        End Try

    End Function

End Class
