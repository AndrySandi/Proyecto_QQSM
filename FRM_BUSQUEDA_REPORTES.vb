Public Class FRM_BUSQUEDA_REPORTES
    Dim UsuarioID As Integer
    Dim NombreCompleto As String
    Dim CorreoElectronico As String
    Dim PuntajeTotal As Integer
    Dim TotalAciertos As Integer
    Dim TotalDesaciertos As Integer
    Dim Calificacion As Double

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXT_NOMBRE.TextChanged
        L_Reportes.Items.Clear()
        T.Tables.Clear()

        SQL = "SELECT S.SesionID, U.NombreCompleto, U.CorreoElectronico, AR.PuntajeTotal, AR.TotalAciertos, AR.TotalDesaciertos, AR.Calificacion FROM Sesiones AS S INNER JOIN Usuarios AS U ON S.UsuarioID = U.UsuarioID INNER JOIN ActividadesRealizadas AS AR ON S.SesionID = AR.SesionAlumnoID AND U.TipoUsuario = 'Jugador' WHERE NombreCompleto LIKE '" & TXT_NOMBRE.Text & "%' Or CorreoElectronico LIKE '" & TXT_NOMBRE.Text & "%'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                L_Reportes.Items.Add(T.Tables(0).Rows(I).ItemArray(0))
                For J = 1 To 6
                    L_Reportes.Items(L_Reportes.Items.Count - 1).SubItems.Add(T.Tables(0).Rows(I).ItemArray(J))
                Next
            Next
        End If
    End Sub

    Private Sub L_Reportes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L_Reportes.SelectedIndexChanged
        If L_Reportes.SelectedItems.Count > 0 Then
            T.Tables.Clear()
            UsuarioID = L_Reportes.SelectedItems(0).SubItems(0).Text
            SQL = "SELECT U.UsuarioID, U.NombreCompleto, U.CorreoElectronico, AR.PuntajeTotal, AR.TotalAciertos, AR.TotalDesaciertos, AR.Calificacion FROM Usuarios U INNER JOIN ActividadesRealizadas AR ON U.UsuarioID = AR.UsuarioID and U.UsuarioID = " & UsuarioID & ""
            CARGAR_TABLA(T, SQL)

            NombreCompleto = T.Tables(0).Rows(0).ItemArray(1)
            CorreoElectronico = T.Tables(0).Rows(0).ItemArray(2)
            PuntajeTotal = T.Tables(0).Rows(0).ItemArray(3)
            TotalAciertos = T.Tables(0).Rows(0).ItemArray(4)
            TotalDesaciertos = T.Tables(0).Rows(0).ItemArray(5)
            Calificacion = T.Tables(0).Rows(0).ItemArray(6)

        End If
    End Sub

    Private Sub BTN_GENERAR_Click(sender As Object, e As EventArgs) Handles BTN_GENERAR.Click

        IMPRIMIR(0, 0, False, L_Reportes, "Nombre-" & NombreCompleto, PuntajeTotal, TotalAciertos, TotalDesaciertos, Calificacion)

        ENVIAR_CORREO_OUTLOOK_ADJUNTO("Reporte QQSM", "En el documento adjunto encuentra su Información la cual es el resumen de su juego",
                                             CorreoElectronico, REPORTE_DIRECCION_PDF, TXT_CORREO.Text, TXT_Clave.Text)


    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim FRM_DOCENTE As New FRM_DOCENTE
        FRM_DOCENTE.Show()
        Me.Close()
    End Sub
End Class