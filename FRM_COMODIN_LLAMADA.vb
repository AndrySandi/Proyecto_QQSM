Public Class FRM_COMODIN_LLAMADA

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        MPVIDEO.URL = "VIDEOS/Llamada.mp4"
    End Sub

    Private Sub btnVolverJugar_Click(sender As Object, e As EventArgs) Handles btnVolverJugar.Click
        'Dim frmJugar As New FRM_JUGAR
        'frmJugar.Show()
        'Me.Hide()
    End Sub

End Class