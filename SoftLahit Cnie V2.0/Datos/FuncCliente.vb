Imports System.Data.SqlClient
Public Class FuncCliente
    Inherits Conexion


    Private QuerryNombre_madre As String
    Private QuerryNombre_padre As String
    Private QuerryCNIE As String
    Private QuerryApellido As String
    Private QuerryNombre As String

    Private Val_Nombre As String
    Private Val_Apellido As String
    Private Val_CNIE As String
    Private Val_Nombre_padre As String
    Private Val_Nombre_Madre As String

    Public Sub Buscar_Cliente_Avanzado()

        QuerryNombre = ""
        QuerryApellido = ""
        QuerryCNIE = ""
        QuerryNombre_padre = ""
        QuerryNombre_madre = ""


        Val_Nombre = ""
        Val_Apellido = ""
        Val_CNIE = ""
        Val_Nombre_padre = ""
        Val_Nombre_Madre = ""


        Val_Nombre = frm_Principal.txt_bu_Nombre.Text
        Val_Apellido = frm_Principal.txt_bu_Apellido.Text
        Val_CNIE = frm_Principal.txt_bu_cnie.Text
        Val_Nombre_padre = frm_Principal.txt_bu_nombre_Padre.Text
        Val_Nombre_Madre = frm_Principal.txt_bu_nombre_madre.Text


        If frm_Principal.txt_bu_Nombre.Text <> "" Then
            QuerryNombre = "And Nombre like '%" & Val_Nombre & "%' "
        End If

        If frm_Principal.txt_bu_Apellido.Text <> "" Then
            QuerryApellido = "And apellido like '%" & Val_Apellido & "%' "
        End If

        If frm_Principal.txt_bu_cnie.Text <> "" Then
            QuerryCNIE = "And Cnie like '%" & Val_CNIE & "%' "
        End If

        If frm_Principal.txt_bu_nombre_Padre.Text <> "" Then
            QuerryNombre_padre = "And nombre_padre like '%" & Val_Nombre_padre & "%' "
        End If

        If frm_Principal.txt_bu_nombre_madre.Text <> "" Then
            QuerryNombre_madre = "And nombre_madre like '%" & Val_Nombre_Madre & "%' "
        End If

        Try
            Conectar()
            adap = New SqlDataAdapter("SELECT id, Cnie, nombre as 'Prenom', apellido as 'Nom', nombre_padre as 'Nom du pere', nombre_madre as 'nom du mere' FROM [CNIE_DDBB].[dbo].[Cliente] WHERE  1=1  " & QuerryNombre & "   " & QuerryApellido & "  " & QuerryCNIE & " " & QuerryNombre_padre & " " & QuerryNombre_madre & " ORDER BY ID asc", Con)
            dat = New DataTable
            adap.Fill(dat)
            frm_Principal.dgv_buscar.DataSource = dat
        Catch ex As Exception
            MsgBox(ex.Message, , " Buscar_Cliente_Avanzado ")
            Desconectar()

        End Try
    End Sub

    Public Function Mostrar_cliente_ID(ByVal tablaCliente As Tabla_Cliente) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("Mostrar_cliente_ID")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", tablaCliente._ID)

            Drd = cmd.ExecuteReader()

            While Drd.Read()

                'frm_Principal.lbl_id.Text = Drd("ID")

                Dim ID As String
                Dim Fecha As String = DateTime.Now.ToString("yyyy-MM-dd" & " A " & "hh:mm:ss")
                ID = Drd("ID") & " (" & Fecha & ")"
                frm_Principal.lbl_id.Text = ID


                frm_Principal.txt_nombre.Text = Drd("Nombre")
                frm_Principal.txt_Apellido.Text = Drd("Apellido")
                If Drd("Genero") = "H" Then
                    frm_Principal.rb_Genero_h.Checked = True
                ElseIf Drd("Genero") = "M" Then
                    frm_Principal.rb_Genero_m.Checked = True
                End If

                frm_Principal.cmb_nacionalidad.Text = Drd("Nacionalidad")
                frm_Principal.dtp_fecha_nacimiento.Text = Drd("Fecha_nacimiento")
                frm_Principal.cmb_lugarNacimiento.Text = Drd("LugarNacimiento")
                frm_Principal.txt_nombre_padre.Text = Drd("Nombre_padre")
                frm_Principal.txt_nombre_madre.Text = Drd("Nombre_madre")

                If Drd("Estado_civil") = "C" Then
                    frm_Principal.rb_casado.Checked = True
                ElseIf Drd("Estado_civil") = "D" Then
                    frm_Principal.rb_divorciado.Checked = True
                ElseIf Drd("Estado_civil") = "S" Then
                    frm_Principal.rb_soltero.Checked = True
                ElseIf Drd("Estado_civil") = "V" Then
                    frm_Principal.rb_viudo.Checked = True
                End If

                frm_Principal.cmb_Profession.Text = Drd("Profession")
                frm_Principal.txt_num_direccion.Text = Drd("Numero_direccion")
                frm_Principal.txt_nombre_calle.Text = Drd("Nombre_calle")
                frm_Principal.cmb_barrio.Text = Drd("Bario")
                frm_Principal.Cmb_Ciudad.Text = Drd("Ciudad")
                frm_Principal.txt_cni.Text = Drd("Cnie")
                frm_Principal.txt_passaporte.Text = Drd("num_passaporte")
                frm_Principal.txt_permis.Text = Drd("num_permiso_conducir")
                'frm_Principal.Imagen.BackgroundImage = Nothing
                'Dim b() As Byte = Drd("imagen")
                'Dim ms As New IO.MemoryStream(b)
                'frm_Principal.Imagen.Image = Image.FromStream(ms)
                'frm_Principal.Imagen.SizeMode = PictureBoxSizeMode.StretchImage

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

    Public Function Insertar_cliente(ByVal TablaCliente As Tabla_Cliente) As Boolean
        Try
            Conectar()
            cmd = New SqlCommand("insertar_Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Nombre", TablaCliente._Nombre)
            cmd.Parameters.AddWithValue("@Apellido", TablaCliente._Apellido)
            cmd.Parameters.AddWithValue("@Genero", TablaCliente._Genero)
            cmd.Parameters.AddWithValue("@Nacionalidad", TablaCliente._Nacionalidad)
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", TablaCliente._Fecha_nacimiento)
            cmd.Parameters.AddWithValue("@LugarNacimiento", TablaCliente._LugarNacimiento)
            cmd.Parameters.AddWithValue("@Nombre_padre", TablaCliente._Nombre_padre)
            cmd.Parameters.AddWithValue("@Nombre_madre", TablaCliente._Nombre_madre)
            cmd.Parameters.AddWithValue("@Estado_civil", TablaCliente._Estado_civil)
            cmd.Parameters.AddWithValue("@Profession", TablaCliente._Profession)
            cmd.Parameters.AddWithValue("@Numero_direccion", TablaCliente._Numero_direccion)
            cmd.Parameters.AddWithValue("@Nombre_calle", TablaCliente._Nombre_calle)
            cmd.Parameters.AddWithValue("@Bario", TablaCliente._Bario)
            cmd.Parameters.AddWithValue("@Ciudad", TablaCliente._Ciudad)
            cmd.Parameters.AddWithValue("@Cnie", TablaCliente._Cnie)
            cmd.Parameters.AddWithValue("@num_passaporte", TablaCliente._Num_passaporte)
            cmd.Parameters.AddWithValue("@num_permiso_conducir", TablaCliente._Num_permiso_conducir)
            '   cmd.Parameters.AddWithValue("@Imagen", TablaCliente._Imagen)
            cmd.Parameters.AddWithValue("@Fecha_ulti_modi", TablaCliente._Fecha_ulti_modi)
            cmd.Parameters.AddWithValue("@isDelete", TablaCliente._IsDelete)

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

    Public Function Editar_cliente(ByVal TablaCliente As Tabla_Cliente) As Boolean

        Try
            Conectar()
            cmd = New SqlCommand("Editar_Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@ID", TablaCliente._ID)
            cmd.Parameters.AddWithValue("@nombre", TablaCliente._Nombre)
            cmd.Parameters.AddWithValue("@Apellido", TablaCliente._Apellido)
            cmd.Parameters.AddWithValue("@Genero", TablaCliente._Genero)
            cmd.Parameters.AddWithValue("@Nacionalidad", TablaCliente._Nacionalidad)
            cmd.Parameters.AddWithValue("@Fecha_nacimiento", TablaCliente._Fecha_nacimiento)
            cmd.Parameters.AddWithValue("@LugarNacimiento", TablaCliente._LugarNacimiento)
            cmd.Parameters.AddWithValue("@Nombre_padre", TablaCliente._Nombre_padre)
            cmd.Parameters.AddWithValue("@Nombre_madre", TablaCliente._Nombre_madre)
            cmd.Parameters.AddWithValue("@Estado_civil", TablaCliente._Estado_civil)
            cmd.Parameters.AddWithValue("@Profession", TablaCliente._Profession)
            cmd.Parameters.AddWithValue("@Numero_direccion", TablaCliente._Numero_direccion)
            cmd.Parameters.AddWithValue("@Nombre_calle", TablaCliente._Nombre_calle)
            cmd.Parameters.AddWithValue("@Bario", TablaCliente._Bario)
            cmd.Parameters.AddWithValue("@Ciudad", TablaCliente._Ciudad)
            cmd.Parameters.AddWithValue("@Cnie", TablaCliente._Cnie)
            cmd.Parameters.AddWithValue("@num_passaporte", TablaCliente._Num_passaporte)
            cmd.Parameters.AddWithValue("@num_permiso_conducir", TablaCliente._Num_permiso_conducir)
            'cmd.Parameters.AddWithValue("@Imagen", TablaCliente._Imagen)
            cmd.Parameters.AddWithValue("@Fecha_ulti_modi", TablaCliente._Fecha_ulti_modi)

            cmd.ExecuteNonQuery()
            Return True

        Catch ex As SqlException
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function

End Class
