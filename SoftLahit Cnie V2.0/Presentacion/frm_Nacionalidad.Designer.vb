﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Nacionalidad
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pb_Validar = New System.Windows.Forms.PictureBox()
        Me.dgv_Principal = New System.Windows.Forms.DataGridView()
        Me.lbl_ID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Validar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.delete_delete_exit_15771
        Me.PictureBox1.Location = New System.Drawing.Point(291, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 219
        Me.PictureBox1.TabStop = False
        '
        'pb_Validar
        '
        Me.pb_Validar.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.solicit_accept_check_ok_theaction_6340
        Me.pb_Validar.Location = New System.Drawing.Point(147, 254)
        Me.pb_Validar.Name = "pb_Validar"
        Me.pb_Validar.Size = New System.Drawing.Size(49, 45)
        Me.pb_Validar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Validar.TabIndex = 218
        Me.pb_Validar.TabStop = False
        '
        'dgv_Principal
        '
        Me.dgv_Principal.AllowUserToAddRows = False
        Me.dgv_Principal.AllowUserToDeleteRows = False
        Me.dgv_Principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Principal.Location = New System.Drawing.Point(30, 75)
        Me.dgv_Principal.Name = "dgv_Principal"
        Me.dgv_Principal.ReadOnly = True
        Me.dgv_Principal.RowHeadersWidth = 51
        Me.dgv_Principal.Size = New System.Drawing.Size(311, 173)
        Me.dgv_Principal.TabIndex = 217
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(108, 30)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ID.TabIndex = 216
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 215
        Me.Label4.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 214
        Me.Label1.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(77, 49)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(208, 20)
        Me.txt_nombre.TabIndex = 213
        '
        'frm_Nacionalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 329)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pb_Validar)
        Me.Controls.Add(Me.dgv_Principal)
        Me.Controls.Add(Me.lbl_ID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_nombre)
        Me.Name = "frm_Nacionalidad"
        Me.Text = "frm_Nacionalidad"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Validar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pb_Validar As PictureBox
    Friend WithEvents dgv_Principal As DataGridView
    Friend WithEvents lbl_ID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nombre As TextBox
End Class
