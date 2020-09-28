<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_barrio
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
        Me.PictureBox1.Location = New System.Drawing.Point(288, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 226
        Me.PictureBox1.TabStop = False
        '
        'pb_Validar
        '
        Me.pb_Validar.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.solicit_accept_check_ok_theaction_6340
        Me.pb_Validar.Location = New System.Drawing.Point(144, 264)
        Me.pb_Validar.Name = "pb_Validar"
        Me.pb_Validar.Size = New System.Drawing.Size(49, 45)
        Me.pb_Validar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Validar.TabIndex = 225
        Me.pb_Validar.TabStop = False
        '
        'dgv_Principal
        '
        Me.dgv_Principal.AllowUserToAddRows = False
        Me.dgv_Principal.AllowUserToDeleteRows = False
        Me.dgv_Principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Principal.Location = New System.Drawing.Point(27, 85)
        Me.dgv_Principal.Name = "dgv_Principal"
        Me.dgv_Principal.ReadOnly = True
        Me.dgv_Principal.RowHeadersWidth = 51
        Me.dgv_Principal.Size = New System.Drawing.Size(311, 173)
        Me.dgv_Principal.TabIndex = 224
        '
        'lbl_ID
        '
        Me.lbl_ID.AutoSize = True
        Me.lbl_ID.Location = New System.Drawing.Point(105, 40)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ID.TabIndex = 223
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 222
        Me.Label4.Text = "ID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 221
        Me.Label1.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(74, 59)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(208, 20)
        Me.txt_nombre.TabIndex = 220
        '
        'frm_barrio
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
        Me.Name = "frm_barrio"
        Me.Text = "frm_barrio"
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
