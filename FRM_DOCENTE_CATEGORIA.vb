Imports System.Data.OleDb
Public Class FRM_DOCENTE_CATEGORIA
    Dim CATEGORIAID As Integer

    Private Sub FRM_DOCENTE_CATEGORIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        CargarCategorias()
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
    End Sub

    Private Sub btnTematicas_Click(sender As Object, e As EventArgs) Handles btnTematicas.Click
        OcultarSubMenu()
        FRM_DOCENTE_TEMATICA.Show()
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
        lblHora.Text = DateAndTime.Now.ToLongTimeString()
        lblFecha.Text = DateAndTime.Now.ToString("dddd MMM yyyy")
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Dim SQLCATEGORIA As String
        Dim IDCategoria As Integer = 0

        If IDCategoria = 0 Then
            IDCategoria = PK("Categoria", "CategoriaID", True)
            SQLCATEGORIA = "INSERT INTO Categoria(CategoriaID, NombreCategoria)VALUES(" & IDCategoria & ", '" & txtNombreCategoria.Text & "')"
        Else
            SQLCATEGORIA = "UPDATE Categoria SET NombreCategoria = '" & txtNombreCategoria.Text & "' WHERE CategoriaID = " & IDCategoria & ""
        End If
        EJECUTAR(SQLCATEGORIA)
        MsgBox("Información registrada satisfactoriamente", vbInformation + vbOKOnly, "Guardado")
        CargarCategorias()
    End Sub

    Public Sub CargarCategorias()
        Dim tabla As New DataTable
        SQL = "SELECT CategoriaID, NombreCategoria FROM Categoria"
        Dim adp As New OleDbDataAdapter(SQL, Db)
        adp.Fill(tabla)

        dgvCategorias.DataSource = tabla
    End Sub

    Private Sub dgvCategorias_DoubleClick(sender As Object, e As EventArgs) Handles dgvCategorias.DoubleClick
        Dim i = dgvCategorias.CurrentRow.Index
        txtIDCategoria.Text = dgvCategorias.Item(0, i).Value
        txtNombreCategoria.Text = dgvCategorias.Item(1, i).Value
    End Sub


End Class