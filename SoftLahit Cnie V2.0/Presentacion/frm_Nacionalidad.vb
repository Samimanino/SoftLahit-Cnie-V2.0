Public Class frm_Nacionalidad


    Private tablaNacionalidad As New Tabla_Nacionalidad
    Private FuncNacionalidad As New FuncNacionalidad


    Private Sub pb_Validar_Click(sender As Object, e As EventArgs) Handles pb_Validar.Click

        If txt_nombre.Text = "" Then
            MsgBox("Nombre No Puede ser Null ")
            txt_nombre.Focus()
            txt_nombre.BackColor = Color.Red
            Exit Sub
        End If

        If lbl_ID.Text = "" Then

            Try
                tablaNacionalidad._Nombre = txt_nombre.Text

                If FuncNacionalidad.Insertar_Nacionalidad(tablaNacionalidad) Then
                    MessageBox.Show("producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                Else
                    MessageBox.Show("No se ha Registrado el PAgo", "Error registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If


                FuncNacionalidad.Mostrar_Nacionalidad()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        ElseIf lbl_ID.Text <> "" Then

            Try
                tablaNacionalidad._ID = lbl_ID.Text
                tablaNacionalidad._Nombre = txt_nombre.Text

                If FuncNacionalidad.Editar_Nacionalidad(tablaNacionalidad) Then
                    MessageBox.Show("Se ha modificado correctamnete", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                    FuncNacionalidad.Mostrar_Nacionalidad()

                Else
                    MessageBox.Show("No fue modifcado intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        If lbl_ID.Text = "" Then

            MsgBox("Debes Seleccionar al menos un registro ..")
        Else

            Try
                tablaNacionalidad._ID = lbl_ID.Text

                If FuncNacionalidad.Eliminar_Nacionalidad(tablaNacionalidad) Then
                    MessageBox.Show("producto registrado correctamente", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Limpiar()
                Else
                    MessageBox.Show("No se ha Registrado el PAgo", "Error registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                FuncNacionalidad.Mostrar_Nacionalidad()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub Limpiar()
        lbl_ID.Text = ""
        txt_nombre.Clear()

    End Sub

    Private Sub frm_Profesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FuncNacionalidad.Mostrar_Nacionalidad()
        ' dgv_Principal.Columns("ID").Visible = False

    End Sub

    Private Sub dgv_Principal_DoubleClick(sender As Object, e As EventArgs) Handles dgv_Principal.DoubleClick
        Me.lbl_ID.Text = Me.dgv_Principal.CurrentRow.Cells("ID").Value.ToString
        Me.txt_nombre.Text = Me.dgv_Principal.CurrentRow.Cells("Nombre").Value.ToString
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        txt_nombre.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub frm_Nacionalidad_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FuncNacionalidad.Mostrar_cmb_Nacionalidad()
        Me.Dispose()
    End Sub

End Class