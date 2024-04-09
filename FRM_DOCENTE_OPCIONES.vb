Imports System.Data.OleDb

Public Class FRM_DOCENTE_OPCIONES
    Dim PreguntaID As Integer

    Private Sub FRM_DOCENTE_OPCIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        CargarPregunta()
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

    Private Sub btnPreguntas_Click(sender As Object, e As EventArgs) Handles btnTematicas.Click, btnPreguntas.Click
        OcultarSubMenu()
        FRM_DOCENTE_PREGUNTA.Show()
        Me.Hide()

    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        OcultarSubMenu()
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        OcultarSubMenu()
        FRM_DOCENTE.Show()
        Me.Hide()

    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblHora.Text = DateAndTime.Now.ToLongTimeString()
        lblFecha.Text = DateAndTime.Now.ToString("dddd MMM yyyy")

    End Sub

    Private Sub btnOpcion_Click(sender As Object, e As EventArgs) Handles btnOpcion.Click
        Dim preguntaID As Integer = CInt(cmbPregunta.SelectedValue)
        SQL = "UPDATE Preguntas SET OpcionA = '" & txtOpcion_A.Text & "', OpcionB = '" & txtOpcion_B.Text & "', OpcionC = '" & txtOpcion_C.Text & "', OpcionD = '" & txtOpcion_D.Text & "', OpcionCorrecta = '" & cmbOpcionCorrecta.Text & "' WHERE PreguntaID = " & preguntaID

        EJECUTAR(SQL)
        MsgBox("Opciones registradas satisfactoriamente", vbInformation + vbOKOnly, "Guardado")
        txtOpcion_A.Clear()
        txtOpcion_B.Clear()
        txtOpcion_C.Clear()
        txtOpcion_D.Clear()
    End Sub

    Public Sub CargarPregunta()
        Dim tabla As New DataTable
        Dim SQL As String = "SELECT PreguntaID, Pregunta From Preguntas"
        Dim adp As New OleDbDataAdapter(SQL, Db)
        adp.Fill(tabla)

        cmbPregunta.DataSource = tabla

        cmbPregunta.DisplayMember = "Pregunta"
        cmbPregunta.ValueMember = "PreguntaID"
    End Sub

End Class