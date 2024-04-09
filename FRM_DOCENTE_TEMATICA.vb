Imports System.Data.OleDb

Public Class FRM_DOCENTE_TEMATICA
    Dim IDTematica As Integer 'LLAVE PRIMARIA EN CASO DE SELECCION DE DATOS
    Dim TEMATICAID As Integer
    Private Sub FRM_DOCENTE_CATEGORIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        CargarTematicas()
    End Sub

    Private Sub FRM_DOCENTE_CATEGORIA_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
    End Sub

    Private Sub btnPreguntas_Click(sender As Object, e As EventArgs) Handles btnTematicas.Click, btnPreguntas.Click
        OcultarSubMenu()
        FRM_DOCENTE_PREGUNTA.Show()
        Me.Hide()
    End Sub

    Private Sub btnOpciones_Click(sender As Object, e As EventArgs) Handles btnOpciones.Click
        OcultarSubMenu()
        FRM_DOCENTE_OPCIONES.Show()
        Me.Hide()
    End Sub

    Private Sub btnPrincipal_Click(sender As Object, e As EventArgs) Handles btnPrincipal.Click
        OcultarSubMenu()
        FRM_DOCENTE.Show()
        Me.Hide()
    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lbl_Hora.Text = DateAndTime.Now.ToLongTimeString()
        lbl_Fecha.Text = DateAndTime.Now.ToString("dddd MMM yyyy")
    End Sub

    Private Sub btnTematica_Click(sender As Object, e As EventArgs) Handles btnTematica.Click
        Dim SQLTEMATICA As String
        If IDTematica = 0 Then
            IDTematica = PK("Tematica", "TematicaID", True)
            SQLTEMATICA = "INSERT INTO Tematica(TematicaID, NombreTematica)VALUES(" & IDTematica & ", '" & txtNombreTematica.Text & "')"
        Else
            SQLTEMATICA = "UPDATE Tematica SET NombreTematica = '" & txtNombreTematica.Text & "' WHERE TematicaID = " & txtIDTematica.Text & ""
        End If
        EJECUTAR(SQLTEMATICA)
        MsgBox("Información registrada satisfactoriamente", vbInformation + vbOKOnly, "Guardado")
        CargarTematicas()
    End Sub

    Public Sub CargarTematicas()
        Dim tabla As New DataTable
        SQL = "SELECT TematicaID, NombreTematica FROM Tematica"
        Dim adp As New OleDbDataAdapter(SQL, Db)
        adp.Fill(tabla)

        dgvTematicas.DataSource = tabla
    End Sub

    Private Sub dgvTematicas_DoubleClick(sender As Object, e As EventArgs) Handles dgvTematicas.DoubleClick
        Dim i = dgvTematicas.CurrentRow.Index
        txtIDTematica.Text = dgvTematicas.Item(0, i).Value
        txtNombreTematica.Text = dgvTematicas.Item(1, i).Value
    End Sub

End Class