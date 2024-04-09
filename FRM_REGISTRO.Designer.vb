<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_REGISTRO
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_REGISTRO))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBL_REGISTRO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.TAlumno = New System.Windows.Forms.TabPage()
        Me.CHECK_CLAVE_CRED = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BTN_REGISTRAR_CRED = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_CLAVE_CRED = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TXT_USUARIO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_CLAVE_CRED = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_USUARIO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TabPage2 = New Guna.UI2.WinForms.Guna2TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.LBL_CLAVE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TXT_CORREO = New Guna.UI2.WinForms.Guna2TextBox()
        Me.MASK_TELEFONO = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.LBL_TIPO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_TELEFONO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_CORREO = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.LBL_NOMBRE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CHECK_CLAVE = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.PCT_FOTO = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.BTN_SALIR = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_REGISTRAR = New Guna.UI2.WinForms.Guna2Button()
        Me.TXT_CLAVE = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CMB_TIPO = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.titulo = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox8 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox7 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox6 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox4 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox5 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnSalir = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TAlumno.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PCT_FOTO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.titulo.SuspendLayout()
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 615)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1093, 25)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 555)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 8
        '
        'LBL_REGISTRO
        '
        Me.LBL_REGISTRO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_REGISTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_REGISTRO.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBL_REGISTRO.Location = New System.Drawing.Point(155, 98)
        Me.LBL_REGISTRO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_REGISTRO.Name = "LBL_REGISTRO"
        Me.LBL_REGISTRO.Size = New System.Drawing.Size(238, 32)
        Me.LBL_REGISTRO.TabIndex = 11
        Me.LBL_REGISTRO.Text = "Registro de usuarios"
        '
        'ABRIR
        '
        Me.ABRIR.Filter = "Imagenes | *.jpg; *.png; *.jpeg; *.bmp"
        Me.ABRIR.Title = "Imagenes disponibles"
        '
        'TAlumno
        '
        Me.TAlumno.Controls.Add(Me.CHECK_CLAVE_CRED)
        Me.TAlumno.Controls.Add(Me.BTN_REGISTRAR_CRED)
        Me.TAlumno.Controls.Add(Me.TXT_CLAVE_CRED)
        Me.TAlumno.Controls.Add(Me.TXT_USUARIO)
        Me.TAlumno.Controls.Add(Me.LBL_CLAVE_CRED)
        Me.TAlumno.Controls.Add(Me.LBL_USUARIO)
        Me.TAlumno.Location = New System.Drawing.Point(184, 4)
        Me.TAlumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TAlumno.Name = "TAlumno"
        Me.TAlumno.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TAlumno.Size = New System.Drawing.Size(843, 392)
        Me.TAlumno.TabIndex = 2
        Me.TAlumno.Text = "Credenciales"
        Me.TAlumno.UseVisualStyleBackColor = True
        '
        'CHECK_CLAVE_CRED
        '
        Me.CHECK_CLAVE_CRED.AutoSize = True
        Me.CHECK_CLAVE_CRED.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECK_CLAVE_CRED.CheckedState.BorderRadius = 0
        Me.CHECK_CLAVE_CRED.CheckedState.BorderThickness = 0
        Me.CHECK_CLAVE_CRED.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECK_CLAVE_CRED.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHECK_CLAVE_CRED.Location = New System.Drawing.Point(560, 176)
        Me.CHECK_CLAVE_CRED.Margin = New System.Windows.Forms.Padding(4)
        Me.CHECK_CLAVE_CRED.Name = "CHECK_CLAVE_CRED"
        Me.CHECK_CLAVE_CRED.Size = New System.Drawing.Size(96, 23)
        Me.CHECK_CLAVE_CRED.TabIndex = 20
        Me.CHECK_CLAVE_CRED.Text = "Ver clave"
        Me.CHECK_CLAVE_CRED.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CHECK_CLAVE_CRED.UncheckedState.BorderRadius = 0
        Me.CHECK_CLAVE_CRED.UncheckedState.BorderThickness = 0
        Me.CHECK_CLAVE_CRED.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'BTN_REGISTRAR_CRED
        '
        Me.BTN_REGISTRAR_CRED.BorderRadius = 10
        Me.BTN_REGISTRAR_CRED.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR_CRED.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR_CRED.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRAR_CRED.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRAR_CRED.FillColor = System.Drawing.Color.SteelBlue
        Me.BTN_REGISTRAR_CRED.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.BTN_REGISTRAR_CRED.ForeColor = System.Drawing.Color.White
        Me.BTN_REGISTRAR_CRED.Location = New System.Drawing.Point(277, 244)
        Me.BTN_REGISTRAR_CRED.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_REGISTRAR_CRED.Name = "BTN_REGISTRAR_CRED"
        Me.BTN_REGISTRAR_CRED.Size = New System.Drawing.Size(171, 34)
        Me.BTN_REGISTRAR_CRED.TabIndex = 19
        Me.BTN_REGISTRAR_CRED.Text = "Iniciar Sesion"
        '
        'TXT_CLAVE_CRED
        '
        Me.TXT_CLAVE_CRED.BorderColor = System.Drawing.Color.Gray
        Me.TXT_CLAVE_CRED.BorderRadius = 15
        Me.TXT_CLAVE_CRED.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CLAVE_CRED.DefaultText = ""
        Me.TXT_CLAVE_CRED.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CLAVE_CRED.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CLAVE_CRED.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE_CRED.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE_CRED.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE_CRED.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CLAVE_CRED.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_CLAVE_CRED.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE_CRED.Location = New System.Drawing.Point(195, 164)
        Me.TXT_CLAVE_CRED.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_CLAVE_CRED.Name = "TXT_CLAVE_CRED"
        Me.TXT_CLAVE_CRED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE_CRED.PlaceholderText = ""
        Me.TXT_CLAVE_CRED.SelectedText = ""
        Me.TXT_CLAVE_CRED.Size = New System.Drawing.Size(335, 44)
        Me.TXT_CLAVE_CRED.TabIndex = 18
        '
        'TXT_USUARIO
        '
        Me.TXT_USUARIO.BorderColor = System.Drawing.Color.Gray
        Me.TXT_USUARIO.BorderRadius = 15
        Me.TXT_USUARIO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_USUARIO.DefaultText = ""
        Me.TXT_USUARIO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_USUARIO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_USUARIO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_USUARIO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_USUARIO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_USUARIO.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.TXT_USUARIO.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_USUARIO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_USUARIO.Location = New System.Drawing.Point(195, 70)
        Me.TXT_USUARIO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_USUARIO.Name = "TXT_USUARIO"
        Me.TXT_USUARIO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_USUARIO.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TXT_USUARIO.PlaceholderText = "Digite el nombre de usuario"
        Me.TXT_USUARIO.SelectedText = ""
        Me.TXT_USUARIO.Size = New System.Drawing.Size(335, 44)
        Me.TXT_USUARIO.TabIndex = 17
        '
        'LBL_CLAVE_CRED
        '
        Me.LBL_CLAVE_CRED.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CLAVE_CRED.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CLAVE_CRED.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_CLAVE_CRED.Location = New System.Drawing.Point(89, 170)
        Me.LBL_CLAVE_CRED.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_CLAVE_CRED.Name = "LBL_CLAVE_CRED"
        Me.LBL_CLAVE_CRED.Size = New System.Drawing.Size(59, 24)
        Me.LBL_CLAVE_CRED.TabIndex = 16
        Me.LBL_CLAVE_CRED.Text = "Clave"
        '
        'LBL_USUARIO
        '
        Me.LBL_USUARIO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_USUARIO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_USUARIO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_USUARIO.Location = New System.Drawing.Point(89, 82)
        Me.LBL_USUARIO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_USUARIO.Name = "LBL_USUARIO"
        Me.LBL_USUARIO.Size = New System.Drawing.Size(68, 24)
        Me.LBL_USUARIO.TabIndex = 15
        Me.LBL_USUARIO.Text = "Usuario"
        '
        'TabPage2
        '
        Me.TabPage2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabPage2.Controls.Add(Me.TabPage1)
        Me.TabPage2.Controls.Add(Me.TAlumno)
        Me.TabPage2.ItemSize = New System.Drawing.Size(180, 40)
        Me.TabPage2.Location = New System.Drawing.Point(31, 172)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.SelectedIndex = 0
        Me.TabPage2.Size = New System.Drawing.Size(1031, 400)
        Me.TabPage2.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty
        Me.TabPage2.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabPage2.TabButtonHoverState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabPage2.TabButtonHoverState.ForeColor = System.Drawing.Color.White
        Me.TabPage2.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.TabPage2.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty
        Me.TabPage2.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabPage2.TabButtonIdleState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabPage2.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(156, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.TabPage2.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.TabPage2.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty
        Me.TabPage2.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabPage2.TabButtonSelectedState.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.TabPage2.TabButtonSelectedState.ForeColor = System.Drawing.Color.White
        Me.TabPage2.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabPage2.TabButtonSize = New System.Drawing.Size(180, 40)
        Me.TabPage2.TabIndex = 12
        Me.TabPage2.TabMenuBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(57, Byte), Integer))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LBL_CLAVE)
        Me.TabPage1.Controls.Add(Me.TXT_CORREO)
        Me.TabPage1.Controls.Add(Me.MASK_TELEFONO)
        Me.TabPage1.Controls.Add(Me.TXT_NOMBRE)
        Me.TabPage1.Controls.Add(Me.LBL_TIPO)
        Me.TabPage1.Controls.Add(Me.LBL_TELEFONO)
        Me.TabPage1.Controls.Add(Me.LBL_CORREO)
        Me.TabPage1.Controls.Add(Me.LBL_NOMBRE)
        Me.TabPage1.Controls.Add(Me.CHECK_CLAVE)
        Me.TabPage1.Controls.Add(Me.PCT_FOTO)
        Me.TabPage1.Controls.Add(Me.BTN_SALIR)
        Me.TabPage1.Controls.Add(Me.BTN_REGISTRAR)
        Me.TabPage1.Controls.Add(Me.TXT_CLAVE)
        Me.TabPage1.Controls.Add(Me.CMB_TIPO)
        Me.TabPage1.Location = New System.Drawing.Point(184, 4)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(843, 392)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'LBL_CLAVE
        '
        Me.LBL_CLAVE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CLAVE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CLAVE.Location = New System.Drawing.Point(27, 249)
        Me.LBL_CLAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_CLAVE.Name = "LBL_CLAVE"
        Me.LBL_CLAVE.Size = New System.Drawing.Size(59, 24)
        Me.LBL_CLAVE.TabIndex = 23
        Me.LBL_CLAVE.Text = "Clave"
        '
        'TXT_CORREO
        '
        Me.TXT_CORREO.BorderColor = System.Drawing.Color.Gray
        Me.TXT_CORREO.BorderRadius = 15
        Me.TXT_CORREO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CORREO.DefaultText = ""
        Me.TXT_CORREO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CORREO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CORREO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CORREO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.TXT_CORREO.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_CORREO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CORREO.Location = New System.Drawing.Point(169, 80)
        Me.TXT_CORREO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_CORREO.Name = "TXT_CORREO"
        Me.TXT_CORREO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_CORREO.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TXT_CORREO.PlaceholderText = "Digite el correo"
        Me.TXT_CORREO.SelectedText = ""
        Me.TXT_CORREO.Size = New System.Drawing.Size(312, 44)
        Me.TXT_CORREO.TabIndex = 22
        '
        'MASK_TELEFONO
        '
        Me.MASK_TELEFONO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MASK_TELEFONO.ForeColor = System.Drawing.Color.Gray
        Me.MASK_TELEFONO.Location = New System.Drawing.Point(169, 145)
        Me.MASK_TELEFONO.Margin = New System.Windows.Forms.Padding(4)
        Me.MASK_TELEFONO.Mask = "9999-9999"
        Me.MASK_TELEFONO.Name = "MASK_TELEFONO"
        Me.MASK_TELEFONO.Size = New System.Drawing.Size(132, 24)
        Me.MASK_TELEFONO.TabIndex = 21
        Me.MASK_TELEFONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NOMBRE
        '
        Me.TXT_NOMBRE.BorderColor = System.Drawing.Color.Gray
        Me.TXT_NOMBRE.BorderRadius = 15
        Me.TXT_NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_NOMBRE.DefaultText = ""
        Me.TXT_NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.TXT_NOMBRE.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_NOMBRE.Location = New System.Drawing.Point(169, 26)
        Me.TXT_NOMBRE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_NOMBRE.Name = "TXT_NOMBRE"
        Me.TXT_NOMBRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TXT_NOMBRE.PlaceholderForeColor = System.Drawing.Color.Gray
        Me.TXT_NOMBRE.PlaceholderText = "Digite el nombre completo"
        Me.TXT_NOMBRE.SelectedText = ""
        Me.TXT_NOMBRE.Size = New System.Drawing.Size(312, 44)
        Me.TXT_NOMBRE.TabIndex = 20
        '
        'LBL_TIPO
        '
        Me.LBL_TIPO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TIPO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TIPO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TIPO.Location = New System.Drawing.Point(28, 193)
        Me.LBL_TIPO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_TIPO.Name = "LBL_TIPO"
        Me.LBL_TIPO.Size = New System.Drawing.Size(39, 24)
        Me.LBL_TIPO.TabIndex = 19
        Me.LBL_TIPO.Text = "Tipo"
        '
        'LBL_TELEFONO
        '
        Me.LBL_TELEFONO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TELEFONO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TELEFONO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_TELEFONO.Location = New System.Drawing.Point(27, 138)
        Me.LBL_TELEFONO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_TELEFONO.Name = "LBL_TELEFONO"
        Me.LBL_TELEFONO.Size = New System.Drawing.Size(80, 24)
        Me.LBL_TELEFONO.TabIndex = 18
        Me.LBL_TELEFONO.Text = "Teléfono"
        '
        'LBL_CORREO
        '
        Me.LBL_CORREO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CORREO.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CORREO.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_CORREO.Location = New System.Drawing.Point(27, 82)
        Me.LBL_CORREO.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_CORREO.Name = "LBL_CORREO"
        Me.LBL_CORREO.Size = New System.Drawing.Size(66, 24)
        Me.LBL_CORREO.TabIndex = 17
        Me.LBL_CORREO.Text = "Correo"
        '
        'LBL_NOMBRE
        '
        Me.LBL_NOMBRE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_NOMBRE.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_NOMBRE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBL_NOMBRE.Location = New System.Drawing.Point(27, 27)
        Me.LBL_NOMBRE.Margin = New System.Windows.Forms.Padding(4)
        Me.LBL_NOMBRE.Name = "LBL_NOMBRE"
        Me.LBL_NOMBRE.Size = New System.Drawing.Size(77, 24)
        Me.LBL_NOMBRE.TabIndex = 16
        Me.LBL_NOMBRE.Text = "Nombre "
        '
        'CHECK_CLAVE
        '
        Me.CHECK_CLAVE.AutoSize = True
        Me.CHECK_CLAVE.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECK_CLAVE.CheckedState.BorderRadius = 0
        Me.CHECK_CLAVE.CheckedState.BorderThickness = 0
        Me.CHECK_CLAVE.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CHECK_CLAVE.Location = New System.Drawing.Point(507, 262)
        Me.CHECK_CLAVE.Margin = New System.Windows.Forms.Padding(4)
        Me.CHECK_CLAVE.Name = "CHECK_CLAVE"
        Me.CHECK_CLAVE.Size = New System.Drawing.Size(89, 21)
        Me.CHECK_CLAVE.TabIndex = 15
        Me.CHECK_CLAVE.Text = "Ver clave"
        Me.CHECK_CLAVE.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CHECK_CLAVE.UncheckedState.BorderRadius = 0
        Me.CHECK_CLAVE.UncheckedState.BorderThickness = 0
        Me.CHECK_CLAVE.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'PCT_FOTO
        '
        Me.PCT_FOTO.Image = CType(resources.GetObject("PCT_FOTO.Image"), System.Drawing.Image)
        Me.PCT_FOTO.ImageRotate = 0!
        Me.PCT_FOTO.Location = New System.Drawing.Point(569, 53)
        Me.PCT_FOTO.Margin = New System.Windows.Forms.Padding(4)
        Me.PCT_FOTO.Name = "PCT_FOTO"
        Me.PCT_FOTO.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.PCT_FOTO.Size = New System.Drawing.Size(187, 167)
        Me.PCT_FOTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCT_FOTO.TabIndex = 14
        Me.PCT_FOTO.TabStop = False
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BorderRadius = 10
        Me.BTN_SALIR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SALIR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_SALIR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_SALIR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_SALIR.FillColor = System.Drawing.Color.SteelBlue
        Me.BTN_SALIR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_SALIR.ForeColor = System.Drawing.Color.White
        Me.BTN_SALIR.Location = New System.Drawing.Point(375, 322)
        Me.BTN_SALIR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(133, 34)
        Me.BTN_SALIR.TabIndex = 13
        Me.BTN_SALIR.Text = "Salir"
        '
        'BTN_REGISTRAR
        '
        Me.BTN_REGISTRAR.BorderRadius = 10
        Me.BTN_REGISTRAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_REGISTRAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_REGISTRAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_REGISTRAR.FillColor = System.Drawing.Color.SteelBlue
        Me.BTN_REGISTRAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_REGISTRAR.ForeColor = System.Drawing.Color.White
        Me.BTN_REGISTRAR.Location = New System.Drawing.Point(169, 322)
        Me.BTN_REGISTRAR.Margin = New System.Windows.Forms.Padding(4)
        Me.BTN_REGISTRAR.Name = "BTN_REGISTRAR"
        Me.BTN_REGISTRAR.Size = New System.Drawing.Size(133, 34)
        Me.BTN_REGISTRAR.TabIndex = 12
        Me.BTN_REGISTRAR.Text = "Registrar"
        '
        'TXT_CLAVE
        '
        Me.TXT_CLAVE.BorderColor = System.Drawing.Color.Gray
        Me.TXT_CLAVE.BorderRadius = 15
        Me.TXT_CLAVE.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TXT_CLAVE.DefaultText = "Digite la clave"
        Me.TXT_CLAVE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TXT_CLAVE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TXT_CLAVE.ForeColor = System.Drawing.Color.DimGray
        Me.TXT_CLAVE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXT_CLAVE.Location = New System.Drawing.Point(169, 249)
        Me.TXT_CLAVE.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_CLAVE.Name = "TXT_CLAVE"
        Me.TXT_CLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_CLAVE.PlaceholderText = ""
        Me.TXT_CLAVE.SelectedText = ""
        Me.TXT_CLAVE.Size = New System.Drawing.Size(291, 44)
        Me.TXT_CLAVE.TabIndex = 11
        '
        'CMB_TIPO
        '
        Me.CMB_TIPO.BackColor = System.Drawing.Color.Transparent
        Me.CMB_TIPO.BorderColor = System.Drawing.Color.DimGray
        Me.CMB_TIPO.BorderRadius = 15
        Me.CMB_TIPO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CMB_TIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_TIPO.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMB_TIPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CMB_TIPO.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CMB_TIPO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CMB_TIPO.ItemHeight = 30
        Me.CMB_TIPO.Items.AddRange(New Object() {"Administrador", "Jugador", "Moderador"})
        Me.CMB_TIPO.Location = New System.Drawing.Point(169, 192)
        Me.CMB_TIPO.Margin = New System.Windows.Forms.Padding(4)
        Me.CMB_TIPO.Name = "CMB_TIPO"
        Me.CMB_TIPO.Size = New System.Drawing.Size(192, 36)
        Me.CMB_TIPO.TabIndex = 9
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(31, 69)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(105, 89)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 13
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.Transparent
        Me.lblFecha.Font = New System.Drawing.Font("Mongolian Baiti", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblFecha.Location = New System.Drawing.Point(885, 106)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(55, 18)
        Me.lblFecha.TabIndex = 25
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Mongolian Baiti", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.lblHora.Location = New System.Drawing.Point(904, 75)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(51, 20)
        Me.lblHora.TabIndex = 24
        Me.lblHora.Text = "Hora"
        '
        'horafecha
        '
        Me.horafecha.Enabled = True
        '
        'titulo
        '
        Me.titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.titulo.Controls.Add(Me.Guna2PictureBox8)
        Me.titulo.Controls.Add(Me.Guna2PictureBox7)
        Me.titulo.Controls.Add(Me.Guna2PictureBox6)
        Me.titulo.Controls.Add(Me.Guna2PictureBox4)
        Me.titulo.Controls.Add(Me.Guna2PictureBox3)
        Me.titulo.Controls.Add(Me.Guna2PictureBox2)
        Me.titulo.Controls.Add(Me.Guna2PictureBox1)
        Me.titulo.Controls.Add(Me.Guna2PictureBox5)
        Me.titulo.Controls.Add(Me.BtnSalir)
        Me.titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.titulo.Location = New System.Drawing.Point(0, 0)
        Me.titulo.Margin = New System.Windows.Forms.Padding(4)
        Me.titulo.Name = "titulo"
        Me.titulo.Size = New System.Drawing.Size(1093, 62)
        Me.titulo.TabIndex = 26
        '
        'Guna2PictureBox8
        '
        Me.Guna2PictureBox8.Image = CType(resources.GetObject("Guna2PictureBox8.Image"), System.Drawing.Image)
        Me.Guna2PictureBox8.ImageRotate = 0!
        Me.Guna2PictureBox8.Location = New System.Drawing.Point(808, 4)
        Me.Guna2PictureBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox8.Name = "Guna2PictureBox8"
        Me.Guna2PictureBox8.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox8.TabIndex = 13
        Me.Guna2PictureBox8.TabStop = False
        '
        'Guna2PictureBox7
        '
        Me.Guna2PictureBox7.Image = CType(resources.GetObject("Guna2PictureBox7.Image"), System.Drawing.Image)
        Me.Guna2PictureBox7.ImageRotate = 0!
        Me.Guna2PictureBox7.Location = New System.Drawing.Point(699, 4)
        Me.Guna2PictureBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox7.Name = "Guna2PictureBox7"
        Me.Guna2PictureBox7.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox7.TabIndex = 12
        Me.Guna2PictureBox7.TabStop = False
        '
        'Guna2PictureBox6
        '
        Me.Guna2PictureBox6.Image = CType(resources.GetObject("Guna2PictureBox6.Image"), System.Drawing.Image)
        Me.Guna2PictureBox6.ImageRotate = 0!
        Me.Guna2PictureBox6.Location = New System.Drawing.Point(588, 4)
        Me.Guna2PictureBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox6.Name = "Guna2PictureBox6"
        Me.Guna2PictureBox6.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox6.TabIndex = 11
        Me.Guna2PictureBox6.TabStop = False
        '
        'Guna2PictureBox4
        '
        Me.Guna2PictureBox4.Image = CType(resources.GetObject("Guna2PictureBox4.Image"), System.Drawing.Image)
        Me.Guna2PictureBox4.ImageRotate = 0!
        Me.Guna2PictureBox4.Location = New System.Drawing.Point(477, 4)
        Me.Guna2PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox4.Name = "Guna2PictureBox4"
        Me.Guna2PictureBox4.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox4.TabIndex = 10
        Me.Guna2PictureBox4.TabStop = False
        '
        'Guna2PictureBox3
        '
        Me.Guna2PictureBox3.Image = CType(resources.GetObject("Guna2PictureBox3.Image"), System.Drawing.Image)
        Me.Guna2PictureBox3.ImageRotate = 0!
        Me.Guna2PictureBox3.Location = New System.Drawing.Point(363, 4)
        Me.Guna2PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox3.Name = "Guna2PictureBox3"
        Me.Guna2PictureBox3.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox3.TabIndex = 9
        Me.Guna2PictureBox3.TabStop = False
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.ImageRotate = 0!
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(241, 4)
        Me.Guna2PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 8
        Me.Guna2PictureBox2.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(123, 4)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 7
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2PictureBox5
        '
        Me.Guna2PictureBox5.Image = CType(resources.GetObject("Guna2PictureBox5.Image"), System.Drawing.Image)
        Me.Guna2PictureBox5.ImageRotate = 0!
        Me.Guna2PictureBox5.Location = New System.Drawing.Point(4, 4)
        Me.Guna2PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2PictureBox5.Name = "Guna2PictureBox5"
        Me.Guna2PictureBox5.Size = New System.Drawing.Size(148, 44)
        Me.Guna2PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox5.TabIndex = 6
        Me.Guna2PictureBox5.TabStop = False
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageRotate = 0!
        Me.BtnSalir.Location = New System.Drawing.Point(1012, 15)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(37, 27)
        Me.BtnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.TabStop = False
        '
        'FRM_REGISTRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 640)
        Me.Controls.Add(Me.titulo)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.TabPage2)
        Me.Controls.Add(Me.LBL_REGISTRO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_REGISTRO"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_LOGIN"
        Me.TAlumno.ResumeLayout(False)
        Me.TAlumno.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PCT_FOTO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.titulo.ResumeLayout(False)
        CType(Me.Guna2PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_REGISTRO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents TAlumno As TabPage
    Friend WithEvents TabPage2 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LBL_CLAVE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TXT_CORREO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents MASK_TELEFONO As MaskedTextBox
    Friend WithEvents TXT_NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_TIPO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_TELEFONO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_CORREO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_NOMBRE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CHECK_CLAVE As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents PCT_FOTO As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents BTN_SALIR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_REGISTRAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CLAVE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMB_TIPO As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents horafecha As Timer
    Friend WithEvents CHECK_CLAVE_CRED As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BTN_REGISTRAR_CRED As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_CLAVE_CRED As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_USUARIO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents LBL_CLAVE_CRED As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LBL_USUARIO As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents titulo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox8 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox7 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox6 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox4 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2PictureBox5 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnSalir As Guna.UI2.WinForms.Guna2PictureBox
End Class
