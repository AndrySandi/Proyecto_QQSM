<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_DOCENTE_SELECCIONA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_DOCENTE_SELECCIONA))
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTematica = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnEmpezarJuego = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.btnVolver = New Guna.UI2.WinForms.Guna2ImageButton()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(258, 35)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(220, 213)
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(171, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona una tematica para jugar"
        '
        'cmbTematica
        '
        Me.cmbTematica.BackColor = System.Drawing.Color.Transparent
        Me.cmbTematica.BorderRadius = 15
        Me.cmbTematica.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbTematica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTematica.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTematica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbTematica.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        Me.cmbTematica.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbTematica.ItemHeight = 30
        Me.cmbTematica.Items.AddRange(New Object() {"Fácil", "Medianamente difícil", "Difícil"})
        Me.cmbTematica.Location = New System.Drawing.Point(227, 332)
        Me.cmbTematica.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTematica.Name = "cmbTematica"
        Me.cmbTematica.Size = New System.Drawing.Size(313, 36)
        Me.cmbTematica.TabIndex = 12
        Me.cmbTematica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEmpezarJuego
        '
        Me.btnEmpezarJuego.BackColor = System.Drawing.Color.Transparent
        Me.btnEmpezarJuego.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnEmpezarJuego.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpezarJuego.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnEmpezarJuego.Image = CType(resources.GetObject("btnEmpezarJuego.Image"), System.Drawing.Image)
        Me.btnEmpezarJuego.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnEmpezarJuego.ImageRotate = 0!
        Me.btnEmpezarJuego.Location = New System.Drawing.Point(319, 386)
        Me.btnEmpezarJuego.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEmpezarJuego.Name = "btnEmpezarJuego"
        Me.btnEmpezarJuego.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnEmpezarJuego.Size = New System.Drawing.Size(105, 80)
        Me.btnEmpezarJuego.TabIndex = 14
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
        Me.btnVolver.Location = New System.Drawing.Point(0, -3)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnVolver.Size = New System.Drawing.Size(45, 33)
        Me.btnVolver.TabIndex = 15
        Me.btnVolver.UseTransparentBackground = True
        '
        'FRM_DOCENTE_SELECCIONA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 474)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEmpezarJuego)
        Me.Controls.Add(Me.cmbTematica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(100, 47)
        Me.Name = "FRM_DOCENTE_SELECCIONA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbTematica As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnEmpezarJuego As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnVolver As Guna.UI2.WinForms.Guna2ImageButton
End Class
