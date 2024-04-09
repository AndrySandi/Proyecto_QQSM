Public Class FRM_MODERADOR
    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs) Handles BTN_VOLVER.Click
        FRM_DOCENTE.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_DOCENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class