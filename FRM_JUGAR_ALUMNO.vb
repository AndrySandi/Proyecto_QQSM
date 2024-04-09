Public Class FRM_JUGAR_ALUMNO
    Public PartidaID = 0
    Private PreguntaActual As String = ""
    Private preguntasDataSet As New DataSet()
    Public SesionID As Integer

    Private Sub FRM_JUGAR_ALUMNO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPreguntas()
    End Sub

    Private Sub FRM_JUGAR_ALUMNO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtJuegoPregunta_TextChanged(sender As Object, e As EventArgs) Handles txtJuegoPregunta.TextChanged
        txtJuegoPregunta.ReadOnly = True
    End Sub

    Private Sub txtOpcionA_TextChanged(sender As Object, e As EventArgs) Handles txtOpcionA.TextChanged
        txtOpcionA.ReadOnly = True
    End Sub

    Private Sub txtOpcionB_TextChanged(sender As Object, e As EventArgs) Handles txtOpcionB.TextChanged
        txtOpcionB.ReadOnly = True
    End Sub

    Private Sub txtOpcionC_TextChanged(sender As Object, e As EventArgs) Handles txtOpcionC.TextChanged
        txtOpcionC.ReadOnly = True
    End Sub

    Private Sub txtOpcionD_TextChanged(sender As Object, e As EventArgs) Handles txtOpcionD.TextChanged
        txtOpcionD.ReadOnly = True
    End Sub

    Private Sub CargarPreguntas()
        SQL = "Select PreguntaActual FROM Partida WHERE PartidaID = " & PartidaID
        CONEXIONES.T.Clear()
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables(0).Rows.Count Then
            Dim NuevaPregunta As String = CONEXIONES.T.Tables(0).Rows(0).Item("PreguntaActual").ToString()
            If String.Equals(PreguntaActual, NuevaPregunta) = False Then
                PreguntaActual = CONEXIONES.T.Tables(0).Rows(0).Item("PreguntaActual").ToString()
                SQL = "Select Pregunta, OpcionA, OpcionB, OpcionC, OpcionD, OpcionCorrecta, DescripcionIntroductoria, Retroalimentacion FROM Preguntas WHERE PreguntaID = " & PreguntaActual
                preguntasDataSet.Clear()
                CARGAR_TABLA(preguntasDataSet, SQL)
                MostrarPregunta()
            End If
        End If
    End Sub

    Private Sub CargarRespuestas()
        SQL = "Select Respuesta, Mostrar FROM PreguntasPartida WHERE PartidaID = " & PartidaID & "AND PreguntaID = " & PreguntaActual
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables(0).Rows.Count Then
            Dim Respuesta = CONEXIONES.T.Tables(0).Rows(0).Item("Respuesta").ToString()
            Dim Mostrar = CONEXIONES.T.Tables(0).Rows(0).Item("Mostrar")
            Dim OpcionCorrecta = preguntasDataSet.Tables(0).Rows(0).Item("OpcionCorrecta").ToString()

            If Mostrar = 1 And Respuesta.Length Then
                If Respuesta = OpcionCorrecta Then
                    MsgBox("Respuesta Correcta. Opcion " & OpcionCorrecta)
                Else
                    MsgBox("Respuesta Incorrecta. Opcion Correcta es: " & OpcionCorrecta)
                End If
            End If
        End If

    End Sub

    Private Sub MostrarPregunta()
        If preguntasDataSet.Tables(0).Rows.Count > 0 AndAlso PreguntaActual Then
            txtJuegoPregunta.Text = preguntasDataSet.Tables(0).Rows(0).Item("Pregunta").ToString()
            txtOpcionA.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionA").ToString()
            txtOpcionB.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionB").ToString()
            txtOpcionC.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionC").ToString()
            txtOpcionD.Text = preguntasDataSet.Tables(0).Rows(0).Item("OpcionD").ToString()
        Else
            MsgBox("Se han mostrado todas las preguntas.", vbInformation + vbOK, "Preguntas")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        CargarPreguntas()
    End Sub

    Private Sub CerrarSesion()
        SQL = "UPDATE Sesiones SET SesionActiva = 0 WHERE SesionID =" & SesionID
        EJECUTAR(SQL)
    End Sub

    Private Sub FRM_JUGAR_ALUMNO_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarSesion()
    End Sub
End Class