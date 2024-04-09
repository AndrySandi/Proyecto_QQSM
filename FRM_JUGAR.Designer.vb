<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_JUGAR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_JUGAR))
        Me.pctJuego = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.btnVolver = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnLlamada = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnPublico = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtOpcionC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtOpcionA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtOpcionB = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtOpcionD = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel5 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtJuegoPregunta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRetroalimentacion = New Guna.UI2.WinForms.Guna2Button()
        Me.btnIntroduccion = New Guna.UI2.WinForms.Guna2Button()
        Me.btnReto = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        CType(Me.pctJuego, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pctJuego
        '
        Me.pctJuego.Image = CType(resources.GetObject("pctJuego.Image"), System.Drawing.Image)
        Me.pctJuego.ImageRotate = 0!
        Me.pctJuego.Location = New System.Drawing.Point(-1, -1)
        Me.pctJuego.Margin = New System.Windows.Forms.Padding(4)
        Me.pctJuego.Name = "pctJuego"
        Me.pctJuego.Size = New System.Drawing.Size(1248, 694)
        Me.pctJuego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctJuego.TabIndex = 0
        Me.pctJuego.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.Transparent
        Me.btnVolver.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolver.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnVolver.Image = CType(resources.GetObject("btnVolver.Image"), System.Drawing.Image)
        Me.btnVolver.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnVolver.ImageRotate = 0!
        Me.btnVolver.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnVolver.Location = New System.Drawing.Point(13, 15)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnVolver.Size = New System.Drawing.Size(45, 33)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.UseTransparentBackground = True
        '
        'btnLlamada
        '
        Me.btnLlamada.BackColor = System.Drawing.Color.Transparent
        Me.btnLlamada.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnLlamada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLlamada.HoverState.ImageSize = New System.Drawing.Size(37, 37)
        Me.btnLlamada.Image = CType(resources.GetObject("btnLlamada.Image"), System.Drawing.Image)
        Me.btnLlamada.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnLlamada.ImageRotate = 0!
        Me.btnLlamada.ImageSize = New System.Drawing.Size(32, 32)
        Me.btnLlamada.Location = New System.Drawing.Point(1169, 36)
        Me.btnLlamada.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLlamada.Name = "btnLlamada"
        Me.btnLlamada.PressedState.ImageSize = New System.Drawing.Size(37, 37)
        Me.btnLlamada.Size = New System.Drawing.Size(65, 33)
        Me.btnLlamada.TabIndex = 2
        Me.btnLlamada.UseTransparentBackground = True
        '
        'btnPublico
        '
        Me.btnPublico.BackColor = System.Drawing.Color.Transparent
        Me.btnPublico.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnPublico.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublico.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnPublico.Image = CType(resources.GetObject("btnPublico.Image"), System.Drawing.Image)
        Me.btnPublico.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPublico.ImageRotate = 0!
        Me.btnPublico.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnPublico.Location = New System.Drawing.Point(1164, 94)
        Me.btnPublico.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPublico.Name = "btnPublico"
        Me.btnPublico.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnPublico.Size = New System.Drawing.Size(65, 33)
        Me.btnPublico.TabIndex = 3
        Me.btnPublico.UseTransparentBackground = True
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Controls.Add(Me.txtOpcionC)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel3.Location = New System.Drawing.Point(281, 599)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(299, 44)
        Me.Guna2Panel3.TabIndex = 7
        '
        'txtOpcionC
        '
        Me.txtOpcionC.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionC.BorderRadius = 10
        Me.txtOpcionC.BorderThickness = 0
        Me.txtOpcionC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpcionC.DefaultText = ""
        Me.txtOpcionC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOpcionC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOpcionC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpcionC.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionC.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtOpcionC.ForeColor = System.Drawing.Color.White
        Me.txtOpcionC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionC.Location = New System.Drawing.Point(0, 0)
        Me.txtOpcionC.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOpcionC.Name = "txtOpcionC"
        Me.txtOpcionC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOpcionC.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtOpcionC.PlaceholderText = "Opción C"
        Me.txtOpcionC.SelectedText = ""
        Me.txtOpcionC.Size = New System.Drawing.Size(299, 44)
        Me.txtOpcionC.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.txtOpcionA)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(281, 517)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(299, 46)
        Me.Guna2Panel1.TabIndex = 8
        '
        'txtOpcionA
        '
        Me.txtOpcionA.BackColor = System.Drawing.Color.Transparent
        Me.txtOpcionA.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionA.BorderRadius = 10
        Me.txtOpcionA.BorderThickness = 0
        Me.txtOpcionA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpcionA.DefaultText = ""
        Me.txtOpcionA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOpcionA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOpcionA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpcionA.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionA.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtOpcionA.ForeColor = System.Drawing.Color.White
        Me.txtOpcionA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionA.Location = New System.Drawing.Point(0, 0)
        Me.txtOpcionA.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOpcionA.Name = "txtOpcionA"
        Me.txtOpcionA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOpcionA.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtOpcionA.PlaceholderText = "Opción A"
        Me.txtOpcionA.SelectedText = ""
        Me.txtOpcionA.Size = New System.Drawing.Size(299, 46)
        Me.txtOpcionA.TabIndex = 0
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.txtOpcionB)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(711, 517)
        Me.Guna2Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(292, 46)
        Me.Guna2Panel2.TabIndex = 9
        '
        'txtOpcionB
        '
        Me.txtOpcionB.BackColor = System.Drawing.Color.Transparent
        Me.txtOpcionB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionB.BorderRadius = 10
        Me.txtOpcionB.BorderThickness = 0
        Me.txtOpcionB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpcionB.DefaultText = ""
        Me.txtOpcionB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOpcionB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOpcionB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpcionB.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionB.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtOpcionB.ForeColor = System.Drawing.Color.White
        Me.txtOpcionB.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionB.Location = New System.Drawing.Point(0, 0)
        Me.txtOpcionB.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOpcionB.Name = "txtOpcionB"
        Me.txtOpcionB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOpcionB.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtOpcionB.PlaceholderText = "Opción B"
        Me.txtOpcionB.SelectedText = ""
        Me.txtOpcionB.Size = New System.Drawing.Size(292, 46)
        Me.txtOpcionB.TabIndex = 0
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.txtOpcionD)
        Me.Guna2Panel4.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel4.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel4.Location = New System.Drawing.Point(711, 599)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(292, 44)
        Me.Guna2Panel4.TabIndex = 10
        '
        'txtOpcionD
        '
        Me.txtOpcionD.BackColor = System.Drawing.Color.Transparent
        Me.txtOpcionD.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionD.BorderRadius = 10
        Me.txtOpcionD.BorderThickness = 0
        Me.txtOpcionD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOpcionD.DefaultText = ""
        Me.txtOpcionD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOpcionD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOpcionD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOpcionD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpcionD.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.txtOpcionD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionD.Font = New System.Drawing.Font("Century Gothic", 11.0!)
        Me.txtOpcionD.ForeColor = System.Drawing.Color.White
        Me.txtOpcionD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOpcionD.Location = New System.Drawing.Point(0, 0)
        Me.txtOpcionD.Margin = New System.Windows.Forms.Padding(5)
        Me.txtOpcionD.Name = "txtOpcionD"
        Me.txtOpcionD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOpcionD.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtOpcionD.PlaceholderText = "Opción D"
        Me.txtOpcionD.SelectedText = ""
        Me.txtOpcionD.Size = New System.Drawing.Size(292, 44)
        Me.txtOpcionD.TabIndex = 0
        '
        'Guna2Panel5
        '
        Me.Guna2Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2Panel5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2Panel5.BorderRadius = 20
        Me.Guna2Panel5.Controls.Add(Me.txtJuegoPregunta)
        Me.Guna2Panel5.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2Panel5.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2Panel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.Guna2Panel5.Location = New System.Drawing.Point(300, 385)
        Me.Guna2Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel5.Name = "Guna2Panel5"
        Me.Guna2Panel5.Size = New System.Drawing.Size(647, 85)
        Me.Guna2Panel5.TabIndex = 11
        '
        'txtJuegoPregunta
        '
        Me.txtJuegoPregunta.AutoSize = True
        Me.txtJuegoPregunta.BackColor = System.Drawing.Color.Transparent
        Me.txtJuegoPregunta.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.txtJuegoPregunta.BorderRadius = 20
        Me.txtJuegoPregunta.BorderThickness = 0
        Me.txtJuegoPregunta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJuegoPregunta.DefaultText = ""
        Me.txtJuegoPregunta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtJuegoPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtJuegoPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJuegoPregunta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtJuegoPregunta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtJuegoPregunta.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.txtJuegoPregunta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJuegoPregunta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtJuegoPregunta.ForeColor = System.Drawing.Color.White
        Me.txtJuegoPregunta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtJuegoPregunta.IconLeft = CType(resources.GetObject("txtJuegoPregunta.IconLeft"), System.Drawing.Image)
        Me.txtJuegoPregunta.IconLeftOffset = New System.Drawing.Point(5, 0)
        Me.txtJuegoPregunta.IconLeftSize = New System.Drawing.Size(25, 25)
        Me.txtJuegoPregunta.Location = New System.Drawing.Point(0, 0)
        Me.txtJuegoPregunta.Margin = New System.Windows.Forms.Padding(5)
        Me.txtJuegoPregunta.Name = "txtJuegoPregunta"
        Me.txtJuegoPregunta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtJuegoPregunta.PlaceholderForeColor = System.Drawing.Color.White
        Me.txtJuegoPregunta.PlaceholderText = "Pregunta"
        Me.txtJuegoPregunta.SelectedText = ""
        Me.txtJuegoPregunta.Size = New System.Drawing.Size(647, 85)
        Me.txtJuegoPregunta.TabIndex = 0
        Me.txtJuegoPregunta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRetroalimentacion
        '
        Me.btnRetroalimentacion.BackColor = System.Drawing.Color.Transparent
        Me.btnRetroalimentacion.BorderColor = System.Drawing.Color.White
        Me.btnRetroalimentacion.BorderRadius = 20
        Me.btnRetroalimentacion.BorderThickness = 2
        Me.btnRetroalimentacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetroalimentacion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRetroalimentacion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRetroalimentacion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRetroalimentacion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRetroalimentacion.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnRetroalimentacion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnRetroalimentacion.ForeColor = System.Drawing.Color.White
        Me.btnRetroalimentacion.Image = CType(resources.GetObject("btnRetroalimentacion.Image"), System.Drawing.Image)
        Me.btnRetroalimentacion.Location = New System.Drawing.Point(897, 266)
        Me.btnRetroalimentacion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRetroalimentacion.Name = "btnRetroalimentacion"
        Me.btnRetroalimentacion.Size = New System.Drawing.Size(243, 62)
        Me.btnRetroalimentacion.TabIndex = 12
        Me.btnRetroalimentacion.Text = "Retroalimentación"
        Me.btnRetroalimentacion.UseTransparentBackground = True
        '
        'btnIntroduccion
        '
        Me.btnIntroduccion.BackColor = System.Drawing.Color.Transparent
        Me.btnIntroduccion.BorderColor = System.Drawing.Color.White
        Me.btnIntroduccion.BorderRadius = 20
        Me.btnIntroduccion.BorderThickness = 2
        Me.btnIntroduccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIntroduccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIntroduccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIntroduccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIntroduccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIntroduccion.FillColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnIntroduccion.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.btnIntroduccion.ForeColor = System.Drawing.Color.White
        Me.btnIntroduccion.Image = CType(resources.GetObject("btnIntroduccion.Image"), System.Drawing.Image)
        Me.btnIntroduccion.Location = New System.Drawing.Point(107, 266)
        Me.btnIntroduccion.Margin = New System.Windows.Forms.Padding(4)
        Me.btnIntroduccion.Name = "btnIntroduccion"
        Me.btnIntroduccion.Size = New System.Drawing.Size(243, 62)
        Me.btnIntroduccion.TabIndex = 13
        Me.btnIntroduccion.Text = "Introducción"
        Me.btnIntroduccion.UseTransparentBackground = True
        '
        'btnReto
        '
        Me.btnReto.BackColor = System.Drawing.Color.Transparent
        Me.btnReto.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnReto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReto.HoverState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnReto.Image = CType(resources.GetObject("btnReto.Image"), System.Drawing.Image)
        Me.btnReto.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnReto.ImageRotate = 0!
        Me.btnReto.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnReto.Location = New System.Drawing.Point(1169, 157)
        Me.btnReto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReto.Name = "btnReto"
        Me.btnReto.PressedState.ImageSize = New System.Drawing.Size(40, 40)
        Me.btnReto.Size = New System.Drawing.Size(65, 55)
        Me.btnReto.TabIndex = 15
        Me.btnReto.UseTransparentBackground = True
        '
        'FRM_JUGAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1245, 690)
        Me.Controls.Add(Me.btnReto)
        Me.Controls.Add(Me.btnIntroduccion)
        Me.Controls.Add(Me.btnRetroalimentacion)
        Me.Controls.Add(Me.Guna2Panel5)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.btnPublico)
        Me.Controls.Add(Me.btnLlamada)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.pctJuego)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1261, 717)
        Me.Name = "FRM_JUGAR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pctJuego, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel5.ResumeLayout(False)
        Me.Guna2Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pctJuego As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnVolver As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnLlamada As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnPublico As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtOpcionC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtOpcionA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtOpcionB As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtOpcionD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel5 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtJuegoPregunta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRetroalimentacion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnIntroduccion As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnReto As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
