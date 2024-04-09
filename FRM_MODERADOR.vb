<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MODERADOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MODERADOR))
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.LBL_SELECCIONE = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BTN_VOLVER = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCIONA = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCIONB = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCIONC = New Guna.UI2.WinForms.Guna2Button()
        Me.BTN_OPCIOND = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(243, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(154, 129)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'LBL_SELECCIONE
        '
        Me.LBL_SELECCIONE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_SELECCIONE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_SELECCIONE.ForeColor = System.Drawing.Color.DarkGray
        Me.LBL_SELECCIONE.Location = New System.Drawing.Point(202, 147)
        Me.LBL_SELECCIONE.Name = "LBL_SELECCIONE"
        Me.LBL_SELECCIONE.Size = New System.Drawing.Size(227, 27)
        Me.LBL_SELECCIONE.TabIndex = 1
        Me.LBL_SELECCIONE.Text = "Seleccione una opción:"
        '
        'BTN_VOLVER
        '
        Me.BTN_VOLVER.BorderColor = System.Drawing.Color.BlanchedAlmond
        Me.BTN_VOLVER.BorderRadius = 15
        Me.BTN_VOLVER.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VOLVER.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_VOLVER.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_VOLVER.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_VOLVER.FillColor = System.Drawing.Color.Firebrick
        Me.BTN_VOLVER.FocusedColor = System.Drawing.Color.DarkGray
        Me.BTN_VOLVER.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_VOLVER.ForeColor = System.Drawing.Color.White
        Me.BTN_VOLVER.Location = New System.Drawing.Point(566, 21)
        Me.BTN_VOLVER.Name = "BTN_VOLVER"
        Me.BTN_VOLVER.Size = New System.Drawing.Size(61, 22)
        Me.BTN_VOLVER.TabIndex = 7
        Me.BTN_VOLVER.Tag = ""
        Me.BTN_VOLVER.Text = "Volver"
        '
        'BTN_OPCIONA
        '
        Me.BTN_OPCIONA.BorderRadius = 15
        Me.BTN_OPCIONA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCIONA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCIONA.FillColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_OPCIONA.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_OPCIONA.Location = New System.Drawing.Point(105, 191)
        Me.BTN_OPCIONA.Name = "BTN_OPCIONA"
        Me.BTN_OPCIONA.Size = New System.Drawing.Size(180, 45)
        Me.BTN_OPCIONA.TabIndex = 8
        Me.BTN_OPCIONA.Text = "Opción A"
        '
        'BTN_OPCIONB
        '
        Me.BTN_OPCIONB.BorderRadius = 15
        Me.BTN_OPCIONB.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONB.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCIONB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCIONB.FillColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONB.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_OPCIONB.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_OPCIONB.Location = New System.Drawing.Point(365, 191)
        Me.BTN_OPCIONB.Name = "BTN_OPCIONB"
        Me.BTN_OPCIONB.Size = New System.Drawing.Size(180, 45)
        Me.BTN_OPCIONB.TabIndex = 9
        Me.BTN_OPCIONB.Text = "Opción B"
        '
        'BTN_OPCIONC
        '
        Me.BTN_OPCIONC.BorderRadius = 15
        Me.BTN_OPCIONC.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCIONC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCIONC.FillColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIONC.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_OPCIONC.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_OPCIONC.Location = New System.Drawing.Point(105, 275)
        Me.BTN_OPCIONC.Name = "BTN_OPCIONC"
        Me.BTN_OPCIONC.Size = New System.Drawing.Size(180, 45)
        Me.BTN_OPCIONC.TabIndex = 10
        Me.BTN_OPCIONC.Text = "Opción C"
        '
        'BTN_OPCIOND
        '
        Me.BTN_OPCIOND.BorderRadius = 15
        Me.BTN_OPCIOND.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIOND.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIOND.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BTN_OPCIOND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BTN_OPCIOND.FillColor = System.Drawing.Color.DarkGray
        Me.BTN_OPCIOND.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BTN_OPCIOND.ForeColor = System.Drawing.Color.DimGray
        Me.BTN_OPCIOND.Location = New System.Drawing.Point(365, 275)
        Me.BTN_OPCIOND.Name = "BTN_OPCIOND"
        Me.BTN_OPCIOND.Size = New System.Drawing.Size(180, 45)
        Me.BTN_OPCIOND.TabIndex = 11
        Me.BTN_OPCIOND.Text = "Opción D"
        '
        'FRM_MODERADOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(653, 386)
        Me.Controls.Add(Me.BTN_OPCIOND)
        Me.Controls.Add(Me.BTN_OPCIONC)
        Me.Controls.Add(Me.BTN_OPCIONB)
        Me.Controls.Add(Me.BTN_OPCIONA)
        Me.Controls.Add(Me.BTN_VOLVER)
        Me.Controls.Add(Me.LBL_SELECCIONE)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Name = "FRM_MODERADOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents LBL_SELECCIONE As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents BTN_VOLVER As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_OPCIONA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_OPCIONB As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_OPCIONC As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_OPCIOND As Guna.UI2.WinForms.Guna2Button
End Class
