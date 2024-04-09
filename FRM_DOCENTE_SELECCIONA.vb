Imports System.Data.OleDb

Public Class FRM_DOCENTE_SELECCIONA
    Public SesionID

    Private Sub FRM_DOCENTE_SELECCIONA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTematicas()
    End Sub

    Private Sub FRM_DOCENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnEmpezarJuego_Click(sender As Object, e As EventArgs) Handles btnEmpezarJuego.Click
        Dim TematicaSeleccionada As String = cmbTematica.SelectedValue.ToString()
        Dim FRM_JUGAR As New FRM_JUGAR(TematicaSeleccionada)
        FRM_JUGAR.SesionID = SesionID
        FRM_JUGAR.Show()
        Me.Close()

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FRM_DOCENTE.Show()
        Me.Hide()
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