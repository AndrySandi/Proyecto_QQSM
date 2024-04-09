Imports System.Data.OleDb

Public Class FRM_REGISTRO
    Dim UsuarioID As Integer
    Dim TipoUsuario As Integer
    Dim Correo As String
    Dim Clave As String
    Dim VERIFICAR As String
    Dim TipoCliente As Integer
    Dim SesionID As Integer
    Dim PartidaID As Integer

    Friend Sub VALIDAR_LLENO()
        If TXT_NOMBRE.Text <> "" And CMB_TIPO.Text <> "" Then
            BTN_REGISTRAR.Enabled = True
        Else
            BTN_REGISTRAR.Enabled = False
        End If
    End Sub

    Private Sub FRM_REGISTRO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TXT_CLAVE_TextChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        TXT_CLAVE.UseSystemPasswordChar = True
    End Sub

    Private Sub TXT_NOMBRE_TextChanged(sender As Object, e As EventArgs)
        VALIDAR_LLENO()
    End Sub

    Private Sub TXT_CORREO_TextChanged(sender As Object, e As EventArgs)
        VALIDAR_LLENO()
    End Sub

    Private Sub TXT_CLAVE_ValueChanged(sender As Object, e As EventArgs) Handles TXT_CLAVE.TextChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub MASK_TELEFONO_ValueChanged(sender As Object, e As EventArgs)
        VALIDAR_LLENO()
    End Sub

    Private Sub PCT_FOTO_Click(sender As Object, e As EventArgs) Handles PCT_FOTO.Click
        If ABRIR.ShowDialog = DialogResult.OK Then
            PCT_FOTO.Image = Image.FromFile(ABRIR.FileName)
            PCT_FOTO.Tag = ABRIR.FileName
        End If
        VALIDAR_LLENO()
    End Sub

    Private Sub BTN_SALIR_Click(sender As Object, e As EventArgs) Handles BTN_SALIR.Click, BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CMB_TIPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_TIPO.SelectedIndexChanged
        Select Case CMB_TIPO.Text
            Case "Moderador"
                TipoUsuario = 0
            Case "Jugador"
                TipoUsuario = 1
            Case Else
                TipoUsuario = 2
        End Select
    End Sub

    Private Sub BTN_REGISTRAR_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRAR.Click
        If UsuarioID = 0 Then
            SQL = "INSERT INTO Usuarios (UsuarioID, TipoUsuario, NombreCompleto, CorreoElectronico, Clave, Foto, NumeroTelefonico) VALUES(" & PK("Usuarios", "UsuarioID", True) & ", '" & CMB_TIPO.Text & "', '" & TXT_NOMBRE.Text & "', '" & TXT_CORREO.Text & "', '" & TXT_CLAVE.Text & "', '" & PCT_FOTO.Tag & "', '" & MASK_TELEFONO.Text & "')"
        End If
        EJECUTAR(SQL)
        MsgBox("El usuario ha sido registrado correctamente", vbInformation + vbOKOnly, "Guardado")
    End Sub

    Private Sub CHECK_CLAVE_CRED_CheckedChanged(sender As Object, e As EventArgs)
        TXT_CLAVE_CRED.UseSystemPasswordChar = False
    End Sub

    Private Sub BTN_REGISTRAR_CRED_Click(sender As Object, e As EventArgs) Handles BTN_REGISTRAR_CRED.Click
        Correo = TXT_USUARIO.Text
        Clave = TXT_CLAVE_CRED.Text

        If String.IsNullOrWhiteSpace(Correo) Then
            MsgBox("Debe ingresar un nombre de usuario o correo electrónico", vbObjectError + vbOKOnly, "Error")
            Exit Sub
        End If

        SQL = "SELECT Clave, TipoUsuario FROM Usuarios WHERE CorreoElectronico = '" & Correo & "' or NombreCompleto = '" & Correo & "'"
        CONEXIONES.T.Clear()

        CARGAR_TABLA(CONEXIONES.T, SQL)

        If CONEXIONES.T.Tables(0).Rows.Count > 0 Then
            Dim verificar As String = CONEXIONES.T.Tables(0).Rows(0).Item("Clave").ToString()

            If verificar = Clave Then

                Dim tipoUsuarioTexto As String = CONEXIONES.T.Tables(0).Rows(0).Item("TipoUsuario").ToString()

                If tipoUsuarioTexto = "Administrador" Then
                    TipoCliente = 1
                ElseIf tipoUsuarioTexto = "Jugador" Then
                    TipoCliente = 2
                ElseIf tipoUsuarioTexto = "Moderador" Then
                    TipoCliente = 3
                Else
                    MsgBox("Tipo de usuario no válido", vbObjectError + vbOKOnly, "Error")
                    Exit Sub
                End If

                Select Case TipoCliente
                    Case 1 ' Administrador / Profesor
                        RegistrarSesion(TXT_USUARIO.Text)
                        Dim FRM_DOCENTE As New FRM_DOCENTE()
                        FRM_DOCENTE.SesionID = SesionID
                        FRM_DOCENTE.Show()

                    Case 2 ' Jugador / Alumno
                        RegistrarSesion(TXT_USUARIO.Text)
                        CargarPartida()
                        Dim FRM_JUGAR_ALUMNO As New FRM_JUGAR_ALUMNO()
                        FRM_JUGAR_ALUMNO.SesionID = SesionID
                        FRM_JUGAR_ALUMNO.PartidaID = PartidaID
                        FRM_JUGAR_ALUMNO.Show()

                    Case 3 ' Moderador
                        RegistrarSesion(TXT_USUARIO.Text)
                        CargarPartida()
                        Dim FRM_MOD As New FRM_MOD()
                        FRM_MOD.SesionID = SesionID
                        FRM_MOD.PartidaID = PartidaID
                        FRM_MOD.Show()

                    Case Else
                        MsgBox("Tipo de usuario no válido", vbObjectError + vbOKOnly, "Error")

                End Select

            Else
                MsgBox("La contraseña es incorrecta", vbObjectError + vbOKOnly, "Error")
            End If
        Else
            MsgBox("Usuario no encontrado", vbObjectError + vbOKOnly, "Error")
        End If
    End Sub

    Public Sub CargarPartida()
        Dim columna As String

        Select Case TipoCliente
            Case 2 ' Jugador / Alumno
                columna = "SesionAlumnoID"

            Case 3 ' Moderador
                columna = "SesionModeradorID"
        End Select

        PartidaID = PK("Partida", "PartidaID", False)
        SQL = "SELECT PartidaID, SesionProfesorID, SesionAlumnoID, SesionModeradorID FROM Partida WHERE PartidaID = '" & PartidaID & "' AND SesionProfesorID IS NOT NULL AND " & columna & " IS NULL"
        CONEXIONES.T.Clear()
        CARGAR_TABLA(CONEXIONES.T, SQL)
        If CONEXIONES.T.Tables.Count And CONEXIONES.T.Tables(0).Rows.Count Then
            SQL = "UPDATE Partida SET " & columna & " = '" & SesionID & "' WHERE PartidaID = '" & PartidaID & "'"
        Else
            MsgBox("El administrador no ha iniciado una sesión, por favor espere.", vbObjectError + vbOKOnly, "Partida no iniciada")
        End If
        EJECUTAR(SQL)
        T.Tables.Clear()
    End Sub

    Private Sub RegistrarSesion(USUARIO As String)
        T.Tables.Clear()

        SQL = "Select UsuarioID from Usuarios WHERE NombreCompleto = '" & USUARIO & "' Or CorreoElectronico = '" & USUARIO & "'"
        CARGAR_TABLA(CONEXIONES.T, SQL)

        Dim UsuarioID As Integer
        UsuarioID = CONEXIONES.T.Tables(0).Rows(0).Item("UsuarioID")
        SesionID = PK("Sesiones", "SesionID", True)
        SQL = "INSERT INTO Sesiones (SesionID, UsuarioID, SesionActiva) VALUES ('" & SesionID & "', '" & UsuarioID & "', '1')"
        EJECUTAR(SQL)
    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblHora.Text = DateAndTime.Now.ToLongTimeString()
        lblFecha.Text = DateAndTime.Now.ToString("dddd MMM yyyy")
    End Sub
End Class