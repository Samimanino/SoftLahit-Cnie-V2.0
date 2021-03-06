﻿Imports System.Data.SqlClient
Public Class frm_Principal

    Private funcCliente As New FuncCliente
    Private tablaCliente As New Tabla_Cliente
    Private tablaHistorialCliente As New Tabla_HistorialCliente



    Private FuncProfesion As New FuncProfesion
    Private FuncNacionalidad As New FuncNacionalidad
    Private FuncBarrio As New FuncBarrio
    Private FuncCiudad As New FuncCiudad
    Private FuncLugarNacimiento As New FuncLugarNacimiento
    Private FuncHistorialCliente As New FuncHistorialCliente

    Private TipoGenero As String
    Private Status_social As String

    Private BusApellido As String
    Private BusNombre As String

    Private ObjReporte As CrystalReport1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel_alta.BackColor = Color.FromArgb(10, 0, 0, 0)
        Panel_buscar.BackColor = Color.FromArgb(10, 0, 0, 0)

        FuncProfesion.Mostrar_cmb_Profesion()
        FuncBarrio.Mostrar_cmb_Barrio()
        FuncNacionalidad.Mostrar_cmb_Nacionalidad()
        FuncCiudad.Mostrar_cmb_Ciudad()
        FuncLugarNacimiento.Mostrar_cmb_LugarNacimiento()
        FuncHistorialCliente.Mostrar_cmb_HistorialCliente()

    End Sub

    Private Sub cmb_Situacion_civil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_Estado_Civil.SelectedIndexChanged
        If cmb_Estado_Civil.Text = "Casado/a" Then
            txt_casado_con.Visible = True
            Lbl_casado_com.Visible = True
        Else
            txt_casado_con.Visible = False
            Lbl_casado_com.Visible = False
        End If
    End Sub

    Private Sub Imagen_Click(sender As Object, e As EventArgs) Handles Imagen.Click
        If dlg.ShowDialog() = DialogResult.OK Then
            Imagen.BackgroundImage = Nothing
            Imagen.Image = New Bitmap(dlg.FileName)
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        txt_nombre.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_Apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_Apellido.TextChanged
        txt_Apellido.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_nombre_padre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_padre.TextChanged
        txt_nombre_padre.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_nombre_madre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_madre.TextChanged
        txt_nombre_madre.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_Estado_Civil_TextChanged(sender As Object, e As EventArgs) Handles txt_casado_con.TextChanged
        txt_casado_con.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_num_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_num_direccion.KeyPress

        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txt_nombre_calle_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre_calle.TextChanged
        txt_nombre_calle.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub txt_cni_TextChanged(sender As Object, e As EventArgs) Handles txt_cni.TextChanged
        txt_cni.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub txt_passaporte_TextChanged(sender As Object, e As EventArgs) Handles txt_passaporte.TextChanged
        txt_passaporte.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub txt_permis_TextChanged(sender As Object, e As EventArgs) Handles txt_permis.TextChanged
        txt_permis.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub dtp_fecha_nacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtp_fecha_nacimiento.ValueChanged
        Try
            Dim date1 As Date = CDate(Me.dtp_fecha_nacimiento.Value)
            Dim date2 As Date = Today

            Me.txt_total_anios.Text = CStr(date2.Year - date1.Year) & " ANS."

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try

    End Sub

    Private Sub pb_Validar_Click(sender As Object, e As EventArgs) Handles pb_Validar.Click

        If lbl_id.Text = "" Then
            Dim Con As New SqlConnection
            Dim cmd As New SqlCommand
            Dim dat As New DataTable
            Dim adap As New SqlDataAdapter

            BusNombre = Me.txt_nombre.Text
            BusApellido = Me.txt_Apellido.Text

            Try

                Con = New SqlConnection(My.Settings.Con)
                Con.Open()

                adap = New SqlDataAdapter("SELECT * FROM [CNIE_DDBB].[dbo].[Cliente] WHERE nombre like  '%" & BusNombre & "%'  and apellido like '%" & BusApellido & "%'  ", Con)
                dat = New DataTable
                adap.Fill(dat)
            Catch ex As Exception
                MsgBox(ex.Message, , " Buscar_Cliente_Avanzado ")

                If Con.State = ConnectionState.Open Then
                    Con.Dispose()
                End If

            End Try
            Dim NumeroRegostrosExistentes As Integer

            NumeroRegostrosExistentes = dat.Rows.Count
            '    5 enregistrements avec le même nom et prénom
            If dat.Rows.Count > 0 Then
                Dim result As DialogResult
                result = MessageBox.Show("Il y a ( " & NumeroRegostrosExistentes & " ) enregistrements avec le même nom et prénom. Vous souhaitez l'enregistrer ?", "Enregistrement existant", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.No Then
                    Exit Sub
                End If
            End If


            Try
                tablaCliente._Nombre = txt_nombre.Text
                tablaCliente._Apellido = txt_Apellido.Text

                TipoGenero = ""
                If rb_Genero_h.Checked Then
                    TipoGenero = "H"
                ElseIf rb_Genero_m.Checked Then
                    TipoGenero = "M"
                End If
                tablaCliente._Genero = TipoGenero

                tablaCliente._Nacionalidad = cmb_nacionalidad.Text
                tablaCliente._Fecha_nacimiento = dtp_fecha_nacimiento.Text
                tablaCliente._LugarNacimiento = cmb_lugarNacimiento.Text
                tablaCliente._Nombre_padre = txt_nombre_padre.Text
                tablaCliente._Nombre_madre = txt_nombre_madre.Text
                tablaCliente._Estado_civil = cmb_Estado_Civil.Text
                tablaCliente._Casado_con = txt_casado_con.Text
                tablaCliente._Profesion = cmb_Profesion.Text
                If txt_num_direccion.Text <> "" Then
                    tablaCliente._Numero_direccion = txt_num_direccion.Text
                End If
                tablaCliente._Nombre_calle = txt_nombre_calle.Text
                tablaCliente._Barrio = cmb_barrio.Text
                tablaCliente._Ciudad = Cmb_Ciudad.Text
                tablaCliente._Cnie = txt_cni.Text
                tablaCliente._Num_passaporte = txt_passaporte.Text
                tablaCliente._Num_permiso_conducir = txt_permis.Text
                tablaCliente._Fecha_ulti_modi = DateTime.Now


                Dim ms As New IO.MemoryStream()
                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.No_Foto
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                tablaCliente._Imagen = ms.GetBuffer

                If funcCliente.Insertar_cliente(tablaCliente) Then
                    'MessageBox.Show("Producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '  Limpiar()


                    Button1.Visible = True
                    Button2.Visible = True
                    Button3.Visible = True
                    Button4.Visible = True
                    btn_eliminar.Visible = True


                Else
                    MessageBox.Show("Producto no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        ElseIf lbl_id.Text <> "" Then


            Try
                tablaCliente._Nombre = txt_nombre.Text
                tablaCliente._Apellido = txt_Apellido.Text

                TipoGenero = ""
                If rb_Genero_h.Checked Then
                    TipoGenero = "H"
                ElseIf rb_Genero_m.Checked Then
                    TipoGenero = "M"
                End If
                tablaCliente._Genero = TipoGenero

                tablaCliente._Nacionalidad = cmb_nacionalidad.Text
                tablaCliente._Fecha_nacimiento = dtp_fecha_nacimiento.Text
                tablaCliente._LugarNacimiento = cmb_lugarNacimiento.Text
                tablaCliente._Nombre_padre = txt_nombre_padre.Text
                tablaCliente._Nombre_madre = txt_nombre_madre.Text
                tablaCliente._Estado_civil = cmb_Estado_Civil.Text
                tablaCliente._Casado_con = txt_casado_con.Text
                tablaCliente._Profesion = cmb_Profesion.Text

                tablaCliente._Numero_direccion = txt_num_direccion.Text

                tablaCliente._Nombre_calle = txt_nombre_calle.Text

                tablaCliente._Barrio = cmb_barrio.Text
                tablaCliente._Ciudad = Cmb_Ciudad.Text
                tablaCliente._Cnie = txt_cni.Text
                tablaCliente._Num_passaporte = txt_passaporte.Text
                tablaCliente._Num_permiso_conducir = txt_permis.Text
                tablaCliente._Fecha_ulti_modi = DateTime.Now


                Dim ms As New IO.MemoryStream()
                If Not Imagen.Image Is Nothing Then
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                Else
                    Imagen.Image = My.Resources.No_Foto
                    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                End If
                tablaCliente._Imagen = ms.GetBuffer

                If funcCliente.Editar_cliente(tablaCliente) Then
                    MessageBox.Show("Se ha modificado correctamnete", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frm_Nacionalidad.ShowDialog()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        frm_LugarNacimiento.ShowDialog()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frm_Profesion.ShowDialog()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        frm_barrio.ShowDialog()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        frm_Ciudad.ShowDialog()
    End Sub

    Private Sub btn_Nuevo_Cliente_Click(sender As Object, e As EventArgs) Handles btn_Nuevo_Cliente.Click
        Limpiar()
        Panel_buscar.Visible = False
        Panel_alta.Visible = True
        Imagen.Visible = True

        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        btn_eliminar.Visible = False


    End Sub

    Private Sub Limpiar()

        lbl_id.Text = ""
        lbl_ultima_modi.Text = ""
        txt_nombre.Clear()
        txt_Apellido.Clear()

        rb_Genero_h.Checked = False
        rb_Genero_m.Checked = False

        cmb_Profesion.Text = Nothing
        cmb_nacionalidad.Text = Nothing
        cmb_Estado_Civil.Text = Nothing
        cmb_barrio.Text = Nothing
        cmb_lugarNacimiento.Text = Nothing
        Cmb_Ciudad.Text = Nothing

        dtp_fecha_nacimiento.Value = Today
        txt_nombre_padre.Clear()
        txt_nombre_madre.Clear()

        txt_num_direccion.Clear()
        txt_nombre_calle.Clear()

        txt_cni.Clear()
        txt_passaporte.Clear()
        txt_permis.Clear()

        Imagen.Image = My.Resources.No_Foto

    End Sub

    Private Sub txt_bu_cnie_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_cnie.TextChanged
        txt_bu_cnie.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()
    End Sub

    Private Sub txt_bu_Nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_Nombre.TextChanged
        txt_bu_Nombre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()
    End Sub

    Private Sub txt_bu_Apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_Apellido.TextChanged
        txt_bu_Apellido.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()
    End Sub

    Private Sub txt_bu_nombre_Padre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_nombre_Padre.TextChanged
        txt_bu_nombre_Padre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()
    End Sub

    Private Sub txt_bu_nombre_madre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_nombre_madre.TextChanged
        txt_bu_nombre_madre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()
    End Sub

    Private Sub cmb_bu_Profesion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bu_Profesion.SelectedIndexChanged
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()

    End Sub

    Private Sub cmb_bu_Barrio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_bu_Barrio.SelectedIndexChanged
        funcCliente.Buscar_Cliente_Avanzado()
        Limpiar_DGV()

    End Sub

    Private Sub Limpiar_DGV()

        If txt_bu_cnie.Text = "" And txt_bu_Nombre.Text = "" And txt_bu_Apellido.Text = "" And txt_bu_nombre_Padre.Text = "" And txt_bu_nombre_madre.Text = "" And cmb_bu_Profesion.Text = "" And cmb_bu_Barrio.Text = "" Then
            Me.dgv_buscar.DataSource = Nothing
        End If

    End Sub

    Private Sub dgv_buscar_DoubleClick(sender As Object, e As EventArgs) Handles dgv_buscar.DoubleClick
        Try
            Dim valor As Integer
            valor = Me.dgv_buscar.CurrentRow.Cells(0).Value()

            tablaCliente._ID = valor
            funcCliente.Mostrar_cliente_ID(tablaCliente)
            FuncHistorialCliente.Mostrar_HistorialCliente()

            Panel_buscar.Visible = False
            Panel_alta.Visible = True
            Imagen.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Button3.Visible = True
            Button4.Visible = True
            btn_eliminar.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        cmb_bu_Profesion.Text = Nothing
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        cmb_bu_Barrio.Text = Nothing
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If lbl_id.Text <> "" Then
            Try
                tablaCliente._ID = lbl_id.Text

                If funcCliente.Eliminar_Cliente(tablaCliente) Then
                    MessageBox.Show("Registro se ha eliminado correctamente", "Eliminacion registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()

                Else
                    MessageBox.Show("cliente no fue Eliminado intente de nuevo", "Eliminacion registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        Panel_buscar.Visible = True
        Panel_alta.Visible = False
        Imagen.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Button3.Visible = False
        Button4.Visible = False
        btn_eliminar.Visible = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim objReport As New CrystalReport1
        Dim Valor As Integer
        Valor = lbl_id.Text
        frm_report.ShowDialog()

        objReport.SetParameterValue("@ID", Valor)
        frm_report.CrystalReportViewer1.ReportSource = objReport

    End Sub

    Private Sub txt_cni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cni.KeyPress
        If Len(Me.txt_cni.Text) > 10 Then
            MsgBox("No Se Admiten mas de 10 Caracteres")
            txt_cni.Text = txt_cni.Text.Substring(0, 10)
            txt_cni.Select(txt_cni.Text.Length, 0)
        End If

    End Sub

    Private Sub txt_passaporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_passaporte.KeyPress
        If Len(Me.txt_passaporte.Text) > 10 Then
            MsgBox("No Se Admiten mas de 10 Caracteres")
            txt_passaporte.Text = txt_passaporte.Text.Substring(0, 10)
            txt_passaporte.Select(txt_passaporte.Text.Length, 0)
        End If
    End Sub

    Private Sub txt_permis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_permis.KeyPress
        If Len(Me.txt_permis.Text) > 10 Then
            MsgBox("No Se Admiten mas de 10 Caracteres")
            txt_permis.Text = txt_permis.Text.Substring(0, 10)
            txt_permis.Select(txt_permis.Text.Length, 0)
        End If
    End Sub

    Private Sub btn_IngresarHistorialCliente_Click(sender As Object, e As EventArgs) Handles btn_IngresarHistorialCliente.Click

        Try
            tablaHistorialCliente._ID_Cliente = lbl_id.Text
            tablaHistorialCliente._TipoPerdida = cmb_TipoPerdida.Text
            tablaHistorialCliente._Observacion = Txt_HistorialCliente.Text
            tablaHistorialCliente._Fecha_alta = DateTime.Now
            tablaHistorialCliente._Fecha_modi = DateTime.Now

            If FuncHistorialCliente.Insertar_HistorialCliente(tablaHistorialCliente) Then
                MessageBox.Show("Producto OK ", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                FuncHistorialCliente.Mostrar_HistorialCliente()
            Else
                MessageBox.Show("Producto no fue registrado intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        frm_TipoPerdida.ShowDialog()
    End Sub

End Class