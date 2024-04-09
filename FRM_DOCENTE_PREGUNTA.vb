Imports System.Data.OleDb
Public Class FRM_DOCENTE_PREGUNTA
    Dim PreguntaID As Integer

    Private Sub FRM_DOCENTE_PREGUNTA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        CargarCategorias()
        CargarTematicas()
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
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        OcultarSubMenu()
        Dim frmOpciones As New FRM_DOCENTE_OPCIONES
        frmOpciones.Show()
        Me.Hide()
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

    Private Sub btnPregunta_Click(sender As Object, e As EventArgs) Handles btnPregunta.Click
        Dim NuevoID As Integer = PK("Preguntas", "PreguntaID", True)

        If NuevoID > 0 Then
            PreguntaID = NuevoID
            SQL = "INSERT INTO Preguntas (PreguntaID, CategoriaID, TematicaID, Pregunta, Puntaje, Reto, DescripcionIntroductoria, Retroalimentacion) VALUES (" & PreguntaID & ", " & cmbCategoria.SelectedValue & ", " & cmbTematica.SelectedValue & ", '" & txtTitulo.Text & "', " & numPuntaje.Value & ", '" & txtReto.Text & "', '" & txtIntroductorio.Text & "', '" & txtRetroalimentacion.Text & "')"
        Else
            MsgBox("No se ha encontrado un nuevo ID para la pregunta", vbInformation + vbOKOnly, "Error")
        End If

        If EJECUTAR(SQL) Then
            MsgBox("La pregunta se ha registrado satisfactoriamente", vbInformation + vbOKOnly, "ERROR")
            txtTitulo.Clear()
            txtIntroductorio.Clear()
            txtRetroalimentacion.Clear()
        Else
            MsgBox("No se puede guardar la pregunta correctamente", vbInformation + vbOKOnly, "Guardada")
        End If
    End Sub

    Public Sub CargarCategorias()
        Dim tabla As New DataTable
        Dim SQL As String = "SELECT CategoriaID, NombreCategoria FROM Categoria"
        Dim adp As New OleDbDataAdapter(SQL, Db)
        adp.Fill(tabla)

        cmbCategoria.DataSource = tabla

        cmbCategoria.DisplayMember = "NombreCategoria"
        cmbCategoria.ValueMember = "CategoriaID"
    End Sub

    Public Sub CargarTematicas()
        Dim tabla As New DataTable
        Dim SQL As String = "SELECT TematicaID, NombreTematica FROM Tematica"
        Dim adp As New OleDbDataAdapter(SQL, Db)
        adp.Fill(tabla)

        cmbTematica.DataSource = tabla

        cmbTematica.DisplayMember = "NombreTematica"
        cmbTematica.ValueMember = "TematicaID"
    End Sub

End Class
