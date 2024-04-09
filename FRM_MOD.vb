Public Class FRM_MOD
    Public PartidaID = 0
    Dim RespuestaID As Integer
    Private PreguntaActual As String
    Private preguntasDataSet As New DataSet()
    Public SesionID As Integer

    Private Sub BTN_VOLVER_Click(sender As Object, e As EventArgs)
        FRM_DOCENTE.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_MOD_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FRM_DOCENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BTN_OPCIONA_Click(sender As Object, e As EventArgs) Handles BTN_OPCIONA.Click
        EnviarRespuesta("A")
    End Sub

    Private Sub BTN_OPCIONB_Click(sender As Object, e As EventArgs) Handles BTN_OPCIONB.Click
        EnviarRespuesta("B")
    End Sub

    Private Sub BTN_OPCIONC_Click(sender As Object, e As EventArgs) Handles BTN_OPCIONC.Click
        EnviarRespuesta("C")
    End Sub

    Private Sub BTN_OPCIOND_Click(sender As Object, e As EventArgs) Handles BTN_OPCIOND.Click

        EnviarRespuesta("D")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CargarOpciones()
    End Sub

    Private Sub CargarOpciones()
        SQL = "Select PreguntaActual FROM Partida WHERE PartidaID = " & PartidaID
        CONEXIONES.T.Clear()
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables(0).Rows.Count Then
            If PreguntaActual IsNot CONEXIONES.T.Tables(0).Rows(0).Item("PreguntaActual").ToString() Then
                PreguntaActual = CONEXIONES.T.Tables(0).Rows(0).Item("PreguntaActual").ToString()
                SQL = "Select OpcionA, OpcionB, OpcionC, OpcionD, OpcionCorrecta FROM Preguntas WHERE PreguntaID = " & PreguntaActual
                preguntasDataSet.Clear()
                CARGAR_TABLA(preguntasDataSet, SQL)
                MostrarOpciones()
            End If
        End If
    End Sub

    Private Sub MostrarOpciones()
        If preguntasDataSet.Tables(0).Rows.Count > 0 AndAlso PreguntaActual Then
            BTN_OPCIONA.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionA").ToString()
            BTN_OPCIONB.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionB").ToString()
            BTN_OPCIONC.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionC").ToString()
            BTN_OPCIOND.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionD").ToString()
        End If
    End Sub

    Private Sub EnviarRespuesta(repuesta As String)
        SQL = "UPDATE PreguntasPartida SET Respuesta = '" & repuesta & "'  WHERE PartidaID = " & PartidaID & "AND PreguntaID = " & PreguntaActual
        If EJECUTAR(SQL) Then
            MsgBox("Respuesta Enviada. Opcion " & repuesta)
        End If
    End Sub

    Private Sub CerrarSesion()
        SQL = "UPDATE Sesiones SET SesionActiva = 0 WHERE SesionID =" & SesionID
        EJECUTAR(SQL)
    End Sub

    Private Sub FRM_MOD_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarSesion()
    End Sub
End Class