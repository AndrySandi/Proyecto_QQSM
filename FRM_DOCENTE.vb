Public Class FRM_DOCENTE
    Public SesionID

    Private Sub FRM_DOCENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()

    End Sub

    Private Sub FRM_DOCENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub OcultarSubMenu()
        panelSub_docente.Visible = False

    End Sub

    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If

    End Sub

    Private Sub btnM_docente_Click(sender As Object, e As EventArgs) Handles btnM_docente.Click
        MostrarSubMenu(panelSub_docente)
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs) Handles btnCategorias.Click
        OcultarSubMenu()
        FRM_DOCENTE_CATEGORIA.Show()
        Me.Hide()

    End Sub

    Private Sub btnTematicas_Click(sender As Object, e As EventArgs) Handles btnTematicas.Click
        OcultarSubMenu()
        FRM_DOCENTE_TEMATICA.Show()
        Me.Hide()
    End Sub

    Private Sub btnPreguntas_Click(sender As Object, e As EventArgs) Handles btnPreguntas.Click
        OcultarSubMenu()
        FRM_DOCENTE_PREGUNTA.Show()
        Me.Hide()

    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        OcultarSubMenu()
        FRM_DOCENTE_OPCIONES.Show()
        Me.Hide()

    End Sub
    Private Sub btnJugar_Click(sender As Object, e As EventArgs) Handles btnJugar.Click
        OcultarSubMenu()
        Dim FRM_DOCENTE_SELECCIONA As New FRM_DOCENTE_SELECCIONA()
        FRM_DOCENTE_SELECCIONA.SesionID = SesionID
        FRM_DOCENTE_SELECCIONA.Show()
        Me.Hide()
    End Sub

    Private Sub btnReportes_busq_Click(sender As Object, e As EventArgs) Handles btnReportes_busq.Click
        OcultarSubMenu()
        FRM_BUSQUEDA_REPORTES.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs)
        OcultarSubMenu()
    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblHora.Text = DateAndTime.Now.ToLongTimeString()
        lblFecha.Text = DateAndTime.Now.ToString("dddd MMM yyyy")

    End Sub

End Class