<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_Nuevo_Cliente = New System.Windows.Forms.Button()
        Me.Panel_Buscar = New TransControl_src.TransparentControl()
        Me.dgv_buscar = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bu_cnie = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_bu_nombre_madre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_bu_nombre_Padre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_bu_Apellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_bu_Nombre = New System.Windows.Forms.TextBox()
        Me.Panel_Formulario = New System.Windows.Forms.Panel()
        Me.dtp_fecha_nacimiento = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_Validar = New System.Windows.Forms.PictureBox()
        Me.lbl_Exist = New System.Windows.Forms.Label()
        Me.cmb_nacionalidad = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_viudo = New System.Windows.Forms.RadioButton()
        Me.rb_divorciado = New System.Windows.Forms.RadioButton()
        Me.rb_casado = New System.Windows.Forms.RadioButton()
        Me.rb_soltero = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmb_lugarNacimiento = New System.Windows.Forms.ComboBox()
        Me.Adresse = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Cmb_Ciudad = New System.Windows.Forms.ComboBox()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_nombre_calle = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_num_direccion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmb_Profession = New System.Windows.Forms.ComboBox()
        Me.rb_Genero_m = New System.Windows.Forms.RadioButton()
        Me.rb_Genero_h = New System.Windows.Forms.RadioButton()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_permis = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_passaporte = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cni = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombre_madre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre_padre = New System.Windows.Forms.TextBox()
        Me.txt_total_anios = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel_Buscar.SuspendLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Formulario.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_Validar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Adresse.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_buscar.Location = New System.Drawing.Point(393, 12)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(134, 33)
        Me.btn_buscar.TabIndex = 7
        Me.btn_buscar.Text = "Rechercher"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_Nuevo_Cliente
        '
        Me.btn_Nuevo_Cliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_Nuevo_Cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo_Cliente.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_Nuevo_Cliente.Location = New System.Drawing.Point(253, 12)
        Me.btn_Nuevo_Cliente.Name = "btn_Nuevo_Cliente"
        Me.btn_Nuevo_Cliente.Size = New System.Drawing.Size(134, 33)
        Me.btn_Nuevo_Cliente.TabIndex = 6
        Me.btn_Nuevo_Cliente.Text = "Nouvelle Fiche"
        Me.btn_Nuevo_Cliente.UseVisualStyleBackColor = False
        '
        'Panel_Buscar
        '
        Me.Panel_Buscar.Controls.Add(Me.dgv_buscar)
        Me.Panel_Buscar.Controls.Add(Me.Label5)
        Me.Panel_Buscar.Controls.Add(Me.txt_bu_cnie)
        Me.Panel_Buscar.Controls.Add(Me.Label3)
        Me.Panel_Buscar.Controls.Add(Me.txt_bu_nombre_madre)
        Me.Panel_Buscar.Controls.Add(Me.Label4)
        Me.Panel_Buscar.Controls.Add(Me.txt_bu_nombre_Padre)
        Me.Panel_Buscar.Controls.Add(Me.Label2)
        Me.Panel_Buscar.Controls.Add(Me.txt_bu_Apellido)
        Me.Panel_Buscar.Controls.Add(Me.Label1)
        Me.Panel_Buscar.Controls.Add(Me.txt_bu_Nombre)
        Me.Panel_Buscar.Location = New System.Drawing.Point(21, 266)
        Me.Panel_Buscar.MinimumSize = New System.Drawing.Size(100, 75)
        Me.Panel_Buscar.Name = "Panel_Buscar"
        Me.Panel_Buscar.Opacity = 0.5R
        Me.Panel_Buscar.Size = New System.Drawing.Size(598, 386)
        Me.Panel_Buscar.TabIndex = 9
        Me.Panel_Buscar.Text = "TransparentControl1"
        Me.Panel_Buscar.Transparent = True
        Me.Panel_Buscar.TransparentColor = System.Drawing.Color.White
        Me.Panel_Buscar.Visible = False
        '
        'dgv_buscar
        '
        Me.dgv_buscar.AllowUserToAddRows = False
        Me.dgv_buscar.AllowUserToDeleteRows = False
        Me.dgv_buscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_buscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_buscar.Location = New System.Drawing.Point(3, 149)
        Me.dgv_buscar.Name = "dgv_buscar"
        Me.dgv_buscar.ReadOnly = True
        Me.dgv_buscar.RowHeadersWidth = 51
        Me.dgv_buscar.Size = New System.Drawing.Size(592, 233)
        Me.dgv_buscar.TabIndex = 167
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(183, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 13)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "CIN"
        '
        'txt_bu_cnie
        '
        Me.txt_bu_cnie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_bu_cnie.Location = New System.Drawing.Point(214, 18)
        Me.txt_bu_cnie.Name = "txt_bu_cnie"
        Me.txt_bu_cnie.Size = New System.Drawing.Size(202, 20)
        Me.txt_bu_cnie.TabIndex = 165
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(137, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 164
        Me.Label3.Text = "Nom du Mere"
        '
        'txt_bu_nombre_madre
        '
        Me.txt_bu_nombre_madre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_bu_nombre_madre.Location = New System.Drawing.Point(214, 122)
        Me.txt_bu_nombre_madre.Name = "txt_bu_nombre_madre"
        Me.txt_bu_nombre_madre.Size = New System.Drawing.Size(202, 20)
        Me.txt_bu_nombre_madre.TabIndex = 163
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(140, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Nom du pere"
        '
        'txt_bu_nombre_Padre
        '
        Me.txt_bu_nombre_Padre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_bu_nombre_Padre.Location = New System.Drawing.Point(214, 96)
        Me.txt_bu_nombre_Padre.Name = "txt_bu_nombre_Padre"
        Me.txt_bu_nombre_Padre.Size = New System.Drawing.Size(202, 20)
        Me.txt_bu_nombre_Padre.TabIndex = 161
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(179, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 160
        Me.Label2.Text = "Nom"
        '
        'txt_bu_Apellido
        '
        Me.txt_bu_Apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_bu_Apellido.Location = New System.Drawing.Point(214, 70)
        Me.txt_bu_Apellido.Name = "txt_bu_Apellido"
        Me.txt_bu_Apellido.Size = New System.Drawing.Size(202, 20)
        Me.txt_bu_Apellido.TabIndex = 159
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(165, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Prenom"
        '
        'txt_bu_Nombre
        '
        Me.txt_bu_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txt_bu_Nombre.Location = New System.Drawing.Point(214, 44)
        Me.txt_bu_Nombre.Name = "txt_bu_Nombre"
        Me.txt_bu_Nombre.Size = New System.Drawing.Size(202, 20)
        Me.txt_bu_Nombre.TabIndex = 157
        '
        'Panel_Formulario
        '
        Me.Panel_Formulario.Controls.Add(Me.PictureBox6)
        Me.Panel_Formulario.Controls.Add(Me.dtp_fecha_nacimiento)
        Me.Panel_Formulario.Controls.Add(Me.PictureBox3)
        Me.Panel_Formulario.Controls.Add(Me.PictureBox2)
        Me.Panel_Formulario.Controls.Add(Me.pb_Validar)
        Me.Panel_Formulario.Controls.Add(Me.lbl_Exist)
        Me.Panel_Formulario.Controls.Add(Me.cmb_nacionalidad)
        Me.Panel_Formulario.Controls.Add(Me.GroupBox1)
        Me.Panel_Formulario.Controls.Add(Me.Label18)
        Me.Panel_Formulario.Controls.Add(Me.cmb_lugarNacimiento)
        Me.Panel_Formulario.Controls.Add(Me.Adresse)
        Me.Panel_Formulario.Controls.Add(Me.cmb_Profession)
        Me.Panel_Formulario.Controls.Add(Me.rb_Genero_m)
        Me.Panel_Formulario.Controls.Add(Me.rb_Genero_h)
        Me.Panel_Formulario.Controls.Add(Me.lbl_id)
        Me.Panel_Formulario.Controls.Add(Me.Label16)
        Me.Panel_Formulario.Controls.Add(Me.Label13)
        Me.Panel_Formulario.Controls.Add(Me.txt_permis)
        Me.Panel_Formulario.Controls.Add(Me.Label14)
        Me.Panel_Formulario.Controls.Add(Me.txt_passaporte)
        Me.Panel_Formulario.Controls.Add(Me.Label15)
        Me.Panel_Formulario.Controls.Add(Me.txt_cni)
        Me.Panel_Formulario.Controls.Add(Me.Label10)
        Me.Panel_Formulario.Controls.Add(Me.Label9)
        Me.Panel_Formulario.Controls.Add(Me.Label7)
        Me.Panel_Formulario.Controls.Add(Me.txt_nombre_madre)
        Me.Panel_Formulario.Controls.Add(Me.Label8)
        Me.Panel_Formulario.Controls.Add(Me.txt_nombre_padre)
        Me.Panel_Formulario.Controls.Add(Me.txt_total_anios)
        Me.Panel_Formulario.Controls.Add(Me.Label6)
        Me.Panel_Formulario.Controls.Add(Me.Label17)
        Me.Panel_Formulario.Controls.Add(Me.Label21)
        Me.Panel_Formulario.Controls.Add(Me.Label22)
        Me.Panel_Formulario.Controls.Add(Me.Label23)
        Me.Panel_Formulario.Controls.Add(Me.txt_nombre)
        Me.Panel_Formulario.Controls.Add(Me.Label24)
        Me.Panel_Formulario.Controls.Add(Me.txt_Apellido)
        Me.Panel_Formulario.Location = New System.Drawing.Point(355, 93)
        Me.Panel_Formulario.Name = "Panel_Formulario"
        Me.Panel_Formulario.Size = New System.Drawing.Size(767, 622)
        Me.Panel_Formulario.TabIndex = 11
        Me.Panel_Formulario.Visible = False
        '
        'dtp_fecha_nacimiento
        '
        Me.dtp_fecha_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha_nacimiento.Location = New System.Drawing.Point(200, 181)
        Me.dtp_fecha_nacimiento.Name = "dtp_fecha_nacimiento"
        Me.dtp_fecha_nacimiento.Size = New System.Drawing.Size(120, 20)
        Me.dtp_fecha_nacimiento.TabIndex = 213
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.sign_add_icon_34367___copia
        Me.PictureBox3.Location = New System.Drawing.Point(390, 152)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 212
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.sign_add_icon_34367___copia
        Me.PictureBox2.Location = New System.Drawing.Point(327, 289)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 211
        Me.PictureBox2.TabStop = False
        '
        'pb_Validar
        '
        Me.pb_Validar.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.solicit_accept_check_ok_theaction_6340
        Me.pb_Validar.Location = New System.Drawing.Point(335, 533)
        Me.pb_Validar.Name = "pb_Validar"
        Me.pb_Validar.Size = New System.Drawing.Size(49, 45)
        Me.pb_Validar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_Validar.TabIndex = 210
        Me.pb_Validar.TabStop = False
        '
        'lbl_Exist
        '
        Me.lbl_Exist.AutoSize = True
        Me.lbl_Exist.Location = New System.Drawing.Point(610, 445)
        Me.lbl_Exist.Name = "lbl_Exist"
        Me.lbl_Exist.Size = New System.Drawing.Size(25, 13)
        Me.lbl_Exist.TabIndex = 209
        Me.lbl_Exist.Text = "000"
        '
        'cmb_nacionalidad
        '
        Me.cmb_nacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_nacionalidad.FormattingEnabled = True
        Me.cmb_nacionalidad.Location = New System.Drawing.Point(200, 153)
        Me.cmb_nacionalidad.Name = "cmb_nacionalidad"
        Me.cmb_nacionalidad.Size = New System.Drawing.Size(184, 21)
        Me.cmb_nacionalidad.TabIndex = 178
        Me.cmb_nacionalidad.Tag = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_viudo)
        Me.GroupBox1.Controls.Add(Me.rb_divorciado)
        Me.GroupBox1.Controls.Add(Me.rb_casado)
        Me.GroupBox1.Controls.Add(Me.rb_soltero)
        Me.GroupBox1.Location = New System.Drawing.Point(199, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 31)
        Me.GroupBox1.TabIndex = 183
        Me.GroupBox1.TabStop = False
        '
        'rb_viudo
        '
        Me.rb_viudo.AutoSize = True
        Me.rb_viudo.Location = New System.Drawing.Point(293, 8)
        Me.rb_viudo.Name = "rb_viudo"
        Me.rb_viudo.Size = New System.Drawing.Size(63, 17)
        Me.rb_viudo.TabIndex = 79
        Me.rb_viudo.Text = "Viudo/a"
        Me.rb_viudo.UseVisualStyleBackColor = True
        '
        'rb_divorciado
        '
        Me.rb_divorciado.AutoSize = True
        Me.rb_divorciado.Location = New System.Drawing.Point(185, 8)
        Me.rb_divorciado.Name = "rb_divorciado"
        Me.rb_divorciado.Size = New System.Drawing.Size(87, 17)
        Me.rb_divorciado.TabIndex = 78
        Me.rb_divorciado.Text = "Divorciado/a"
        Me.rb_divorciado.UseVisualStyleBackColor = True
        '
        'rb_casado
        '
        Me.rb_casado.AutoSize = True
        Me.rb_casado.Location = New System.Drawing.Point(90, 8)
        Me.rb_casado.Name = "rb_casado"
        Me.rb_casado.Size = New System.Drawing.Size(72, 17)
        Me.rb_casado.TabIndex = 77
        Me.rb_casado.Text = "Casado/a"
        Me.rb_casado.UseVisualStyleBackColor = True
        '
        'rb_soltero
        '
        Me.rb_soltero.AutoSize = True
        Me.rb_soltero.Checked = True
        Me.rb_soltero.Location = New System.Drawing.Point(4, 8)
        Me.rb_soltero.Name = "rb_soltero"
        Me.rb_soltero.Size = New System.Drawing.Size(69, 17)
        Me.rb_soltero.TabIndex = 9
        Me.rb_soltero.TabStop = True
        Me.rb_soltero.Text = "Soltero/a"
        Me.rb_soltero.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(569, 185)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 13)
        Me.Label18.TabIndex = 207
        Me.Label18.Text = "Age:"
        '
        'cmb_lugarNacimiento
        '
        Me.cmb_lugarNacimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_lugarNacimiento.FormattingEnabled = True
        Me.cmb_lugarNacimiento.Items.AddRange(New Object() {"Alhoceima", "Tanger", "Ouajda", "Casa Blanca", "Rabat", "Tetuan", "Nador", "Agadir"})
        Me.cmb_lugarNacimiento.Location = New System.Drawing.Point(374, 181)
        Me.cmb_lugarNacimiento.Name = "cmb_lugarNacimiento"
        Me.cmb_lugarNacimiento.Size = New System.Drawing.Size(151, 21)
        Me.cmb_lugarNacimiento.TabIndex = 180
        Me.cmb_lugarNacimiento.Tag = ""
        '
        'Adresse
        '
        Me.Adresse.Controls.Add(Me.PictureBox5)
        Me.Adresse.Controls.Add(Me.PictureBox4)
        Me.Adresse.Controls.Add(Me.Cmb_Ciudad)
        Me.Adresse.Controls.Add(Me.cmb_barrio)
        Me.Adresse.Controls.Add(Me.Label12)
        Me.Adresse.Controls.Add(Me.Label11)
        Me.Adresse.Controls.Add(Me.txt_nombre_calle)
        Me.Adresse.Controls.Add(Me.Label20)
        Me.Adresse.Controls.Add(Me.txt_num_direccion)
        Me.Adresse.Controls.Add(Me.Label19)
        Me.Adresse.Location = New System.Drawing.Point(201, 314)
        Me.Adresse.Name = "Adresse"
        Me.Adresse.Size = New System.Drawing.Size(464, 122)
        Me.Adresse.TabIndex = 185
        Me.Adresse.TabStop = False
        Me.Adresse.Text = "Adresse"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.sign_add_icon_34367___copia
        Me.PictureBox5.Location = New System.Drawing.Point(435, 73)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 214
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.sign_add_icon_34367___copia
        Me.PictureBox4.Location = New System.Drawing.Point(199, 72)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 213
        Me.PictureBox4.TabStop = False
        '
        'Cmb_Ciudad
        '
        Me.Cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Ciudad.FormattingEnabled = True
        Me.Cmb_Ciudad.Location = New System.Drawing.Point(274, 73)
        Me.Cmb_Ciudad.Name = "Cmb_Ciudad"
        Me.Cmb_Ciudad.Size = New System.Drawing.Size(160, 21)
        Me.Cmb_Ciudad.TabIndex = 14
        Me.Cmb_Ciudad.Tag = ""
        '
        'cmb_barrio
        '
        Me.cmb_barrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(48, 73)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(150, 21)
        Me.cmb_barrio.TabIndex = 13
        Me.cmb_barrio.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "Barrio"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Nº"
        '
        'txt_nombre_calle
        '
        Me.txt_nombre_calle.Location = New System.Drawing.Point(146, 38)
        Me.txt_nombre_calle.Name = "txt_nombre_calle"
        Me.txt_nombre_calle.Size = New System.Drawing.Size(314, 20)
        Me.txt_nombre_calle.TabIndex = 12
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(228, 81)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(40, 13)
        Me.Label20.TabIndex = 146
        Me.Label20.Text = "Ciudad"
        '
        'txt_num_direccion
        '
        Me.txt_num_direccion.Location = New System.Drawing.Point(48, 37)
        Me.txt_num_direccion.Name = "txt_num_direccion"
        Me.txt_num_direccion.Size = New System.Drawing.Size(46, 20)
        Me.txt_num_direccion.TabIndex = 11
        Me.txt_num_direccion.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(113, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 13)
        Me.Label19.TabIndex = 143
        Me.Label19.Text = "Rue"
        '
        'cmb_Profession
        '
        Me.cmb_Profession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Profession.FormattingEnabled = True
        Me.cmb_Profession.Location = New System.Drawing.Point(200, 287)
        Me.cmb_Profession.Name = "cmb_Profession"
        Me.cmb_Profession.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Profession.TabIndex = 184
        Me.cmb_Profession.Tag = ""
        '
        'rb_Genero_m
        '
        Me.rb_Genero_m.AutoSize = True
        Me.rb_Genero_m.Location = New System.Drawing.Point(296, 130)
        Me.rb_Genero_m.Name = "rb_Genero_m"
        Me.rb_Genero_m.Size = New System.Drawing.Size(71, 17)
        Me.rb_Genero_m.TabIndex = 205
        Me.rb_Genero_m.TabStop = True
        Me.rb_Genero_m.Text = "Femenino"
        Me.rb_Genero_m.UseVisualStyleBackColor = True
        '
        'rb_Genero_h
        '
        Me.rb_Genero_h.AutoSize = True
        Me.rb_Genero_h.Checked = True
        Me.rb_Genero_h.Location = New System.Drawing.Point(200, 130)
        Me.rb_Genero_h.Name = "rb_Genero_h"
        Me.rb_Genero_h.Size = New System.Drawing.Size(73, 17)
        Me.rb_Genero_h.TabIndex = 177
        Me.rb_Genero_h.TabStop = True
        Me.rb_Genero_h.Text = "Masculino"
        Me.rb_Genero_h.UseVisualStyleBackColor = True
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(198, 50)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 13)
        Me.lbl_id.TabIndex = 204
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(123, 50)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 203
        Me.Label16.Text = "Fiche Nª :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(80, 497)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 13)
        Me.Label13.TabIndex = 202
        Me.Label13.Text = "Permis de conduire"
        '
        'txt_permis
        '
        Me.txt_permis.Location = New System.Drawing.Point(201, 494)
        Me.txt_permis.Name = "txt_permis"
        Me.txt_permis.Size = New System.Drawing.Size(403, 20)
        Me.txt_permis.TabIndex = 188
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(116, 471)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 201
        Me.Label14.Text = "Passport nª"
        '
        'txt_passaporte
        '
        Me.txt_passaporte.Location = New System.Drawing.Point(201, 468)
        Me.txt_passaporte.Name = "txt_passaporte"
        Me.txt_passaporte.Size = New System.Drawing.Size(403, 20)
        Me.txt_passaporte.TabIndex = 187
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(152, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(25, 13)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "CNI"
        '
        'txt_cni
        '
        Me.txt_cni.Location = New System.Drawing.Point(201, 442)
        Me.txt_cni.Name = "txt_cni"
        Me.txt_cni.Size = New System.Drawing.Size(403, 20)
        Me.txt_cni.TabIndex = 186
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(120, 290)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 199
        Me.Label10.Text = "Profession"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 264)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "Situation familiale"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Nom du Mére"
        '
        'txt_nombre_madre
        '
        Me.txt_nombre_madre.Location = New System.Drawing.Point(200, 233)
        Me.txt_nombre_madre.Name = "txt_nombre_madre"
        Me.txt_nombre_madre.Size = New System.Drawing.Size(460, 20)
        Me.txt_nombre_madre.TabIndex = 182
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(109, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 196
        Me.Label8.Text = "Nom du Pére"
        '
        'txt_nombre_padre
        '
        Me.txt_nombre_padre.Location = New System.Drawing.Point(200, 207)
        Me.txt_nombre_padre.Name = "txt_nombre_padre"
        Me.txt_nombre_padre.Size = New System.Drawing.Size(460, 20)
        Me.txt_nombre_padre.TabIndex = 181
        '
        'txt_total_anios
        '
        Me.txt_total_anios.Enabled = False
        Me.txt_total_anios.Location = New System.Drawing.Point(608, 181)
        Me.txt_total_anios.Name = "txt_total_anios"
        Me.txt_total_anios.Size = New System.Drawing.Size(51, 20)
        Me.txt_total_anios.TabIndex = 195
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 13)
        Me.Label6.TabIndex = 194
        Me.Label6.Text = "A"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(78, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 13)
        Me.Label17.TabIndex = 193
        Me.Label17.Text = "Date de Nassaince"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(119, 158)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 13)
        Me.Label21.TabIndex = 192
        Me.Label21.Text = "Nationalite"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(145, 132)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(31, 13)
        Me.Label22.TabIndex = 191
        Me.Label22.Text = "Sexe"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(148, 107)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 13)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "Nom"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(201, 78)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(460, 20)
        Me.txt_nombre.TabIndex = 175
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(133, 81)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(43, 13)
        Me.Label24.TabIndex = 189
        Me.Label24.Text = "Prenom"
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(201, 104)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(460, 20)
        Me.txt_Apellido.TabIndex = 176
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.main_bg1
        Me.PictureBox1.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.main_bg1
        Me.PictureBox1.InitialImage = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.main_bg1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1223, 819)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.SoftLahit_Cnie_V2._0.My.Resources.Resources.sign_add_icon_34367___copia
        Me.PictureBox6.Location = New System.Drawing.Point(530, 181)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 214
        Me.PictureBox6.TabStop = False
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 819)
        Me.Controls.Add(Me.Panel_Formulario)
        Me.Controls.Add(Me.Panel_Buscar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_Nuevo_Cliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frm_Principal"
        Me.Text = "الشرطة المغربية"
        Me.Panel_Buscar.ResumeLayout(False)
        Me.Panel_Buscar.PerformLayout()
        CType(Me.dgv_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Formulario.ResumeLayout(False)
        Me.Panel_Formulario.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_Validar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Adresse.ResumeLayout(False)
        Me.Adresse.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_Nuevo_Cliente As Button
    Friend WithEvents Panel_Buscar As TransControl_src.TransparentControl
    Friend WithEvents dgv_buscar As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bu_cnie As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_bu_nombre_madre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_bu_nombre_Padre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_bu_Apellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_bu_Nombre As TextBox
    Friend WithEvents Panel_Formulario As Panel
    Friend WithEvents lbl_Exist As Label
    Friend WithEvents cmb_nacionalidad As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_viudo As RadioButton
    Friend WithEvents rb_divorciado As RadioButton
    Friend WithEvents rb_casado As RadioButton
    Friend WithEvents rb_soltero As RadioButton
    Friend WithEvents Label18 As Label
    Friend WithEvents cmb_lugarNacimiento As ComboBox
    Friend WithEvents Adresse As GroupBox
    Friend WithEvents Cmb_Ciudad As ComboBox
    Friend WithEvents cmb_barrio As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_nombre_calle As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_num_direccion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cmb_Profession As ComboBox
    Friend WithEvents rb_Genero_m As RadioButton
    Friend WithEvents rb_Genero_h As RadioButton
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_permis As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_passaporte As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cni As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nombre_madre As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nombre_padre As TextBox
    Friend WithEvents txt_total_anios As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents pb_Validar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents dtp_fecha_nacimiento As DateTimePicker
    Friend WithEvents PictureBox6 As PictureBox
End Class
