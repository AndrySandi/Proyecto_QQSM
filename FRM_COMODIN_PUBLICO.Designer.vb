<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_COMODIN_PUBLICO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_COMODIN_PUBLICO))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnVolverJugar = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnPlay = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.MPVIDEO = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.MPVIDEO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 534)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(950, 57)
        Me.Guna2Panel1.TabIndex = 5
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.btnVolverJugar)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(950, 57)
        Me.Guna2Panel2.TabIndex = 6
        '
        'btnVolverJugar
        '
        Me.btnVolverJugar.BackColor = System.Drawing.Color.Transparent
        Me.btnVolverJugar.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnVolverJugar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolverJugar.HoverState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnVolverJugar.Image = CType(resources.GetObject("btnVolverJugar.Image"), System.Drawing.Image)
        Me.btnVolverJugar.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnVolverJugar.ImageRotate = 0!
        Me.btnVolverJugar.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnVolverJugar.Location = New System.Drawing.Point(27, 12)
        Me.btnVolverJugar.Name = "btnVolverJugar"
        Me.btnVolverJugar.PressedState.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnVolverJugar.Size = New System.Drawing.Size(34, 27)
        Me.btnVolverJugar.TabIndex = 6
        Me.btnVolverJugar.UseTransparentBackground = True
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2Panel4.Controls.Add(Me.btnPlay)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel4.Location = New System.Drawing.Point(0, 57)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(107, 477)
        Me.Guna2Panel4.TabIndex = 7
        '
        'btnPlay
        '
        Me.btnPlay.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPlay.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnPlay.Image = CType(resources.GetObject("btnPlay.Image"), System.Drawing.Image)
        Me.btnPlay.ImageOffset = New System.Drawing.Point(0, 0)
        Me.btnPlay.ImageRotate = 0!
        Me.btnPlay.Location = New System.Drawing.Point(27, 212)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.btnPlay.Size = New System.Drawing.Size(43, 45)
        Me.btnPlay.TabIndex = 7
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel3.Location = New System.Drawing.Point(843, 57)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(107, 477)
        Me.Guna2Panel3.TabIndex = 8
        '
        'MPVIDEO
        '
        Me.MPVIDEO.Enabled = True
        Me.MPVIDEO.Location = New System.Drawing.Point(27, 22)
        Me.MPVIDEO.Name = "MPVIDEO"
        Me.MPVIDEO.OcxState = CType(resources.GetObject("MPVIDEO.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MPVIDEO.Size = New System.Drawing.Size(892, 610)
        Me.MPVIDEO.TabIndex = 0
        '
        'FRM_COMODIN_PUBLICO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 591)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.MPVIDEO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(950, 591)
        Me.Name = "FRM_COMODIN_PUBLICO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.MPVIDEO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MPVIDEO As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnVolverJugar As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents btnPlay As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
End Class
