Public Class frm_Principal

    Private funcCliente As New FuncCliente
    Private tablaCliente As New Tabla_Cliente

    Private TipoGenero As String
    Private Status_social As String

    Private Sub txt_cnie_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_cnie.TextChanged
        txt_bu_cnie.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
    End Sub
    Private Sub txt_Nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_Nombre.TextChanged
        txt_bu_Nombre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
    End Sub
    Private Sub txt_Apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_Apellido.TextChanged
        txt_bu_Apellido.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
    End Sub
    Private Sub txt_nombre_Padre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_nombre_Padre.TextChanged
        txt_bu_nombre_Padre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
    End Sub
    Private Sub txt_nombre_madre_TextChanged(sender As Object, e As EventArgs) Handles txt_bu_nombre_madre.TextChanged
        txt_bu_nombre_madre.CharacterCasing = CharacterCasing.Upper
        funcCliente.Buscar_Cliente_Avanzado()
    End Sub

    Private Sub dgv_buscar_DoubleClick(sender As Object, e As EventArgs) Handles dgv_buscar.DoubleClick
        Try
            Dim valor As Integer
            valor = Me.dgv_buscar.CurrentRow.Cells(0).Value()

            tablaCliente._ID = valor
            funcCliente.Mostrar_cliente_ID(tablaCliente)
            Panel_Formulario.Visible = True
            Panel_Buscar.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub btn_Nuevo_Cliente_Click(sender As Object, e As EventArgs) Handles btn_Nuevo_Cliente.Click
        Limpiar()

        Panel_Formulario.Visible = True
        Panel_Buscar.Visible = False
    End Sub
    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Limpiar()
        Panel_Formulario.Visible = False
        Panel_Buscar.Visible = True
    End Sub


    Private Sub Limpiar()
        lbl_id.Text = ""
        txt_nombre.Clear()
        txt_Apellido.Clear()

        rb_Genero_h.Checked = False
        rb_Genero_m.Checked = False

        cmb_nacionalidad.Items.Clear()
        dtp_fecha_nacimiento.Value = Today
        cmb_lugarNacimiento.Items.Clear()
        txt_nombre_padre.Clear()
        txt_nombre_madre.Clear()

        rb_soltero.Checked = True
        rb_casado.Checked = False
        rb_divorciado.Checked = False
        rb_viudo.Checked = False

        cmb_Profession.Items.Clear()
        txt_num_direccion.Clear()
        txt_nombre_calle.Clear()
        cmb_bario.Items.Clear()
        Cmb_Ciudad.Items.Clear()
        txt_cni.Clear()
        txt_passaporte.Clear()
        txt_permis.Clear()

    End Sub

    Private Sub pb_Validar_Click(sender As Object, e As EventArgs) Handles pb_Validar.Click

        If lbl_id.Text = "" Then

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

                Status_social = ""
                If rb_casado.Checked Then
                    Status_social = "C"
                ElseIf rb_divorciado.Checked Then
                    Status_social = "D"
                ElseIf rb_soltero.Checked Then
                    Status_social = "S"
                ElseIf rb_viudo.Checked Then
                    Status_social = "V"
                End If

                tablaCliente._Estado_civil = Status_social
                tablaCliente._Profession = cmb_Profession.Text
                tablaCliente._Numero_direccion = txt_num_direccion.Text
                tablaCliente._Nombre_calle = txt_nombre_calle.Text
                tablaCliente._Bario = cmb_bario.Text
                tablaCliente._Ciudad = Cmb_Ciudad.Text
                tablaCliente._Cnie = txt_cni.Text
                tablaCliente._Num_passaporte = txt_passaporte.Text
                tablaCliente._Num_permiso_conducir = txt_permis.Text
                tablaCliente._Fecha_ulti_modi = Today
                tablaCliente._IsDelete = False
                'Dim ms As New IO.MemoryStream()
                'If Not Imagen.Image Is Nothing Then
                '    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                'Else
                '    Imagen.Image = My.Resources.NoFoto
                '    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                'End If
                'tablaCliente._Imagen = ms.GetBuffer

                If funcCliente.Insertar_cliente(tablaCliente) Then
                    MessageBox.Show("Producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Limpiar()
                    Panel_Buscar.Visible = True
                    Panel_Formulario.Visible = False


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

                Status_social = ""
                If rb_casado.Checked Then
                    Status_social = "C"
                ElseIf rb_divorciado.Checked Then
                    Status_social = "D"
                ElseIf rb_soltero.Checked Then
                    Status_social = "S"
                ElseIf rb_viudo.Checked Then
                    Status_social = "V"
                End If
                tablaCliente._Estado_civil = Status_social
                tablaCliente._Profession = cmb_Profession.Text
                tablaCliente._Numero_direccion = txt_num_direccion.Text
                tablaCliente._Nombre_calle = txt_nombre_calle.Text
                tablaCliente._Bario = cmb_bario.Text
                tablaCliente._Ciudad = Cmb_Ciudad.Text
                tablaCliente._Cnie = txt_cni.Text
                tablaCliente._Num_passaporte = txt_passaporte.Text
                tablaCliente._Num_permiso_conducir = txt_permis.Text
                tablaCliente._Fecha_ulti_modi = Today

                'Dim ms As New IO.MemoryStream()
                'If Not Imagen.Image Is Nothing Then
                '    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                'Else
                '    Imagen.Image = My.Resources.NoFoto
                '    Imagen.Image.Save(ms, Imagen.Image.RawFormat)
                'End If
                'tablaCliente._Imagen = ms.GetBuffer


                If funcCliente.Editar_cliente(tablaCliente) Then
                    MessageBox.Show("Se ha modificado correctamnete", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    Panel_Buscar.Visible = True
                    Panel_Formulario.Visible = False
                Else
                    MessageBox.Show("No fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If



    End Sub
End Class
