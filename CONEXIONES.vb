Module CONEXIONES
    Public Db As New OleDb.OleDbConnection
    Public SQL As String
    Public T As New DataSet
    Public CLAVE_CORREO As String

    Friend Sub CONECTAR()
        Dim Ruta As String
        Ruta = "File Name=" & Application.StartupPath & "\ruta.udl"
        Db.ConnectionString = Ruta
        Db.Open()
        Exit Sub
    End Sub

    Friend Sub DESCONECTAR()
        Db.Close()
    End Sub

    Friend Sub CARGAR_TABLA(ByRef Tabla_Temporal As DataSet, ByVal Sql As String)
        CONECTAR()
        Dim Consulta As New OleDb.OleDbDataAdapter(Sql, Db)
        Consulta.Fill(Tabla_Temporal)
        DESCONECTAR()
    End Sub

    Friend Function EJECUTAR(ByVal Sql As String)
        Dim blnResultado = False
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)

        If (Comando.ExecuteNonQuery() > 0) Then
            blnResultado = True
        End If
        DESCONECTAR()
        Return blnResultado
    End Function

    Friend Function PK(ByVal TABLA As String, ByVal ID As String, ByVal masUno As Boolean) As Integer
        T.Tables.Clear()
        SQL = "SELECT " & ID & " FROM " & TABLA
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            T.Tables.Clear()
            SQL = "SELECT MAX(" & ID & ") FROM " & TABLA
            CARGAR_TABLA(T, SQL)
            PK = T.Tables(0).Rows(0).ItemArray(0)
            If masUno = True Then
                PK = PK + 1
            End If
        Else
            PK = 1
        End If
    End Function

    Friend Function EjecutarConsultaScalar(ByVal Sql As String) As Object
        CONECTAR()
        Dim Comando As New OleDb.OleDbCommand(Sql, Db)
        Dim Resultado As Object = Comando.ExecuteScalar()
        DESCONECTAR()
        Return Resultado
    End Function

    Friend Function TematicaExistente(nombreTematica As String) As Boolean
        Dim sql As String = "SELECT COUNT(*) FROM Tematica WHERE NombreTematica = '" & nombreTematica & "'"
        Dim count As Integer = Convert.ToInt32(EjecutarConsultaScalar(sql))
        Return count > 0
    End Function


End Module
