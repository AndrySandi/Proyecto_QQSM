Public Class FRM_JUGAR
    Private TematicaSeleccionada As String
    Private preguntasDataSet As New DataSet()
    Private PreguntaActual As Integer = 1
    Private contador As Integer = 0
    Public SesionID As Integer
    Dim PartidaID As Integer

    Private Sub FRM_DOCENTE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearPartida()
        CargarPreguntas()
        PasarPregunta()
    End Sub

    Private Sub FRM_DOCENTE_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            PasarPregunta()
        ElseIf e.KeyCode = Keys.Space Then
            MostrarCorrecta()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim FRM_DOCENTE_SELECCIONA As New FRM_DOCENTE_SELECCIONA()
        FRM_DOCENTE_SELECCIONA.SesionID = SesionID
        FRM_DOCENTE_SELECCIONA.Show()
        Me.Close()
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

    Public Sub New(ByVal tematica As String)
        InitializeComponent()
        TematicaSeleccionada = tematica
    End Sub

    Private Sub CargarPreguntas()
        Dim TotalPreguntas As Integer = 0
        For cat As Integer = 1 To 3
            SQL = "Select TOP 5 PreguntaID, Pregunta, OpcionA, OpcionB, OpcionC, OpcionD, OpcionCorrecta, DescripcionIntroductoria, Retroalimentacion, Reto FROM Preguntas WHERE CategoriaID = " & cat.ToString() & " AND TematicaID = " & TematicaSeleccionada.ToString() & " ORDER BY NEWID()"
            CONEXIONES.T.Clear()
            CARGAR_TABLA(CONEXIONES.T, SQL)

            If CONEXIONES.T.Tables.Count > 0 AndAlso CONEXIONES.T.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In CONEXIONES.T.Tables(0).Rows
                    If TotalPreguntas >= 15 Then
                        Exit For
                    End If

                    Dim PreguntaID As String = row("PreguntaID").ToString()
                    SQL = "INSERT INTO PreguntasPartida (PreguntaID, PartidaID) VALUES (" & PreguntaID & ", " & PartidaID & ")"
                    EJECUTAR(SQL)
                    TotalPreguntas += 1
                Next
            End If
            If TotalPreguntas >= 15 Then
                Exit For
            End If
        Next
        SQL = "Select PreguntasPartida.PreguntaID, Preguntas.Pregunta, Preguntas.OpcionA, Preguntas.OpcionB, Preguntas.OpcionC, Preguntas.OpcionD, Preguntas.OpcionCorrecta, Preguntas.DescripcionIntroductoria, Preguntas.Retroalimentacion, Preguntas.Reto FROM PreguntasPartida, Preguntas WHERE PreguntasPartida.PreguntaID = Preguntas.PreguntaID AND PreguntasPartida.PartidaID = " & PartidaID.ToString()
        preguntasDataSet.Clear()
        CARGAR_TABLA(preguntasDataSet, SQL)
    End Sub

    Private Sub MostrarPregunta()


        If preguntasDataSet.Tables(0).Rows.Count > 0 AndAlso contador < preguntasDataSet.Tables(0).Rows.Count Then
            PreguntaActual = preguntasDataSet.Tables(0).Rows(contador).Item("PreguntaID").ToString()
            SQL = "UPDATE Partida SET PreguntaActual = '" & PreguntaActual & "' WHERE PartidaID = '" & PartidaID & "'"
            EJECUTAR(SQL)

            txtJuegoPregunta.Text = preguntasDataSet.Tables(0).Rows(contador).Item("Pregunta").ToString()
            txtOpcionA.Text = preguntasDataSet.Tables(0).Rows(contador).Item("OpcionA").ToString()
            txtOpcionB.Text = preguntasDataSet.Tables(0).Rows(contador).Item("OpcionB").ToString()
            txtOpcionC.Text = preguntasDataSet.Tables(0).Rows(contador).Item("OpcionC").ToString()
            txtOpcionD.Text = preguntasDataSet.Tables(0).Rows(contador).Item("OpcionD").ToString()
        Else
            If contador >= preguntasDataSet.Tables(0).Rows.Count Then
                MsgBox("Se han mostrado todas las preguntas.", vbInformation + vbOK, "Preguntas")
            End If

        End If
    End Sub

    Private Sub btnIntroduccion_Click(sender As Object, e As EventArgs) Handles btnIntroduccion.Click
        If preguntasDataSet.Tables(0).Rows.Count > 0 Then
            Dim introduccion = preguntasDataSet.Tables(0).Rows(PreguntaActual - 1).Item("DescripcionIntroductoria").ToString()
            MessageBox.Show(introduccion, "DescripcionIntroductoria")
        End If
    End Sub

    Private Sub btnRetroalimentacion_Click(sender As Object, e As EventArgs) Handles btnRetroalimentacion.Click
        If preguntasDataSet.Tables(0).Rows.Count > 0 Then
            Dim retroalimentacion = preguntasDataSet.Tables(0).Rows(PreguntaActual - 1).Item("Retroalimentacion").ToString()
            MessageBox.Show(retroalimentacion, "Retroalimentacion")
        End If
    End Sub

    Private Sub PasarPregunta()
        Dim aciertos As String = "0"
        Dim desaciertos As String = "0"
        If contador < preguntasDataSet.Tables(0).Rows.Count Then
            MostrarPregunta()
            contador += 1
        Else
            'Agregar informacion a la tabla Actividades realizadas
            SQL = "SELECT COUNT(*) FROM PreguntasPartida,Preguntas WHERE PreguntasPartida.PreguntaID = Preguntas.PreguntaID And PreguntasPartida.Respuesta = Preguntas.OpcionCorrecta And PreguntasPartida.PartidaID = " & PartidaID
            CONEXIONES.T.Clear()
            CARGAR_TABLA(CONEXIONES.T, SQL)
            aciertos = CONEXIONES.T.Tables(0).Rows(0).Item(3).ToString()
            If String.IsNullOrEmpty(aciertos) Then
                aciertos = "0"
            End If



            SQL = "SELECT COUNT(*) FROM PreguntasPartida,Preguntas WHERE PreguntasPartida.PreguntaID = Preguntas.PreguntaID And PreguntasPartida.Respuesta != Preguntas.OpcionCorrecta And PreguntasPartida.PartidaID = " & PartidaID
            CONEXIONES.T.Clear()
            CARGAR_TABLA(CONEXIONES.T, SQL)
            desaciertos = CONEXIONES.T.Tables(0).Rows(0).Item(3).ToString()

            If String.IsNullOrEmpty(desaciertos) Then
                desaciertos = "0"
            End If

            Dim Calificacion As Double = (Double.Parse(aciertos) / 15) * 100

            SQL = "INSERT INTO ActividadesRealizadas (ActividadID, SesionAlumnoID, PuntajeTotal, Calificacion, TotalAciertos, TotalDesaciertos) VALUES (" & PartidaID & ", " & CargarPartida() & ", " & aciertos & ", '" & Calificacion & "', " & aciertos & ", " & desaciertos & ")"
            EJECUTAR(SQL)

            MsgBox("Se han mostrado todas las preguntas. Aciertos: " & aciertos & " Desaciertos: " & desaciertos, vbInformation + vbOK, "Preguntas")

        End If
    End Sub

    Public Sub CrearPartida()
        PartidaID = PK("Partida", "PartidaID", True)
        SQL = "INSERT INTO Partida (PartidaID, PreguntaActual, SesionProfesorID) VALUES ('" & PartidaID & "', '" & PreguntaActual & "', '" & SesionID & "')"
        EJECUTAR(SQL)
    End Sub

    Public Function CargarPartida()
        SQL = "SELECT SesionAlumnoID FROM Partida WHERE PartidaID = " & PartidaID
        CONEXIONES.T.Clear()
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables.Count And CONEXIONES.T.Tables(0).Rows.Count Then
            Return CONEXIONES.T.Tables(0).Rows(0).Item("SesionAlumnoID").ToString()
        End If
        Return ""
    End Function


    Public Sub MostrarCorrecta()


        SQL = "SELECT PreguntasPartida.Respuesta, Preguntas.OpcionCorrecta FROM PreguntasPartida,Preguntas WHERE PreguntasPartida.PreguntaID = Preguntas.PreguntaID AND PreguntasPartida.PartidaID = " & PartidaID & " AND PreguntasPartida.PreguntaID = " & PreguntaActual
        CONEXIONES.T.Clear()
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables.Count And CONEXIONES.T.Tables(0).Rows.Count Then
            Dim Respuesta As String = CONEXIONES.T.Tables(0).Rows(0).Item("Respuesta").ToString()
            Dim OpcionCorrecta As String = CONEXIONES.T.Tables(0).Rows(0).Item("OpcionCorrecta").ToString()


            If String.Equals(Respuesta, OpcionCorrecta) Then
                MsgBox("Respuesta Correcta: " & OpcionCorrecta)

            Else
                MsgBox("Respuesta Incorrecta, la opcion es: " & OpcionCorrecta)

            End If
        End If
    End Sub

    Private Sub CerrarSesion()
        SQL = "UPDATE Sesiones SET SesionActiva = 0 WHERE SesionID =" & SesionID
        EJECUTAR(SQL)
    End Sub


    Private Sub btnReto_Click(sender As Object, e As EventArgs) Handles btnReto.Click
        If preguntasDataSet.Tables(0).Rows.Count > 0 Then
            Dim Reto = preguntasDataSet.Tables(0).Rows(PreguntaActual - 1).Item("Reto").ToString()
            MessageBox.Show(Reto, "Reto")
        End If
    End Sub

    Private Sub btnLlamada_Click(sender As Object, e As EventArgs) Handles btnLlamada.Click
        FRM_COMODIN_LLAMADA.Show()
        Me.Hide()
    End Sub

    Private Sub btnPublico_Click(sender As Object, e As EventArgs) Handles btnPublico.Click
        FRM_COMODIN_PUBLICO.Show()
        Me.Hide()
    End Sub

    Private Sub FRM_JUGAR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CerrarSesion()
    End Sub
End Class