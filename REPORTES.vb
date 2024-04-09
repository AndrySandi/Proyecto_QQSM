Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO


Module REPORTES
    Dim DIRECTORIO As String
    Public REPORTE_DIRECCION_PDF As String = ""
    Dim REPORTE_DIRECCION_WORD As String = ""


    Friend Sub INSERTAR_REGLON(ByRef DOCUMENTO As Word.Document, ByVal ES_EL_PRIMER_PARRAFO As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal TEXTO As String, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal TAMANO As Byte, ByVal NOMBRE_FUENTE As String, ByVal ALINEACION As Char)

        If ES_EL_PRIMER_PARRAFO = True Then
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add
        Else
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range)
        End If

        PARRAFO.Range.Text = TEXTO

        If NEGRITA = True Then
            PARRAFO.Range.Font.Bold = True
        Else
            PARRAFO.Range.Font.Bold = False
        End If

        If CURSIVA = True Then
            PARRAFO.Range.Font.Italic = True
        Else
            PARRAFO.Range.Font.Italic = False
        End If

        PARRAFO.Range.Font.Size = TAMANO
        PARRAFO.Range.Font.Name = NOMBRE_FUENTE

        Select Case ALINEACION
            Case "I" 'IZQUIERDA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            Case "D" 'DERECHA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
            Case "J" 'JUSTIFICADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
            Case "C" 'CENTRADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        End Select

        PARRAFO.Range.InsertParagraphAfter()
    End Sub


    Friend Sub INSERTAR_LINEA_BLANCO(ByRef PARRAFO_ANTERIOR As Word.Paragraph, ByVal CANTIDAD_LINEAS_EN_BLANCO As Byte)
        Dim I As Byte
        For I = 1 To CANTIDAD_LINEAS_EN_BLANCO
            PARRAFO_ANTERIOR.Range.InsertParagraphBefore()
        Next
    End Sub


    Friend Sub INSERTAR_TABLA(ByRef OTABLA As Word.Table, ByRef DOCUMENTO As Word.Document, ByVal TABLA(,) As String, ByVal FILAS As Byte, ByVal COLUMNAS As Byte, ByVal TAMANO As Byte, ByVal FUENTE As String, ByVal ALINEACION As Char, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal INDICE_COLUMNA_NEGRITA As Byte, ByVal REQUIERE_COLUMNA_NEGRITA As Boolean, ByVal INDICE_COLUMNA_CURSIVA As Byte, ByVal REQUIERE_COLUMNA_CURSIVA As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal INDICE_COLUMNA_CENTRAR As Byte, ByVal REQUIERE_COLUMNA_CENTRAR As Boolean, ByVal INDICE_FILA_NEGRITA As Byte, ByVal REQUIERE_FILA_NEGRITA As Boolean, ByVal COLUMNA_SOMBREADA As Boolean, ByVal INDICE_COLUMNA_SOMBREADA As Byte, ByVal FILA_SOMBREADA As Boolean, ByVal INDICE_FILA_SOMBREADA As Byte)

        Dim FILA As Byte, COLUMNA As Byte
        OTABLA = DOCUMENTO.Tables.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range, FILAS, COLUMNAS)

        For FILA = 1 To FILAS
            For COLUMNA = 1 To COLUMNAS
                OTABLA.Cell(FILA, COLUMNA).Range.Text = TABLA(FILA - 1, COLUMNA - 1)

                Select Case ALINEACION
                    Case "I" 'IZQUIERDA
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    Case "D" 'DERECHA
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    Case "J" 'JUSTIFICADO
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
                    Case "C" 'CENTRADO
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                End Select

                OTABLA.Cell(FILA, COLUMNA).Range.Font.Size = TAMANO
                OTABLA.Cell(FILA, COLUMNA).Range.Font.Name = FUENTE


                If NEGRITA = True Then
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                Else
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                End If

                If CURSIVA = True Then
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True
                Else
                    OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False
                End If


                If REQUIERE_COLUMNA_NEGRITA = True Then
                    If COLUMNA = INDICE_COLUMNA_NEGRITA Then
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                        'OTABLA.Cell(FILA, COLUMNA).Range.Font.Color = WdColor.wdColorRed
                    Else
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                        'OTABLA.Cell(FILA, COLUMNA).Range.Font.Color = WdColor.wdColorBlack
                    End If
                End If

                If REQUIERE_FILA_NEGRITA = True Then
                    If FILA = INDICE_FILA_NEGRITA Then
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = True
                    Else
                        If OTABLA.Cell(FILA, COLUMNA).Range.Bold = False Then 'No esta en negrita
                            OTABLA.Cell(FILA, COLUMNA).Range.Font.Bold = False
                        End If
                    End If
                End If


                If REQUIERE_COLUMNA_CURSIVA = True Then
                    If COLUMNA = INDICE_COLUMNA_CURSIVA Then
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = True
                    Else
                        OTABLA.Cell(FILA, COLUMNA).Range.Font.Italic = False
                    End If
                End If

                If REQUIERE_COLUMNA_CENTRAR = True Then
                    If COLUMNA = INDICE_COLUMNA_CENTRAR Then
                        OTABLA.Cell(FILA, COLUMNA).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
                    End If
                End If


                If COLUMNA_SOMBREADA = True Then
                    If COLUMNA = INDICE_COLUMNA_SOMBREADA Then
                        SOMBREAR_CELDA(OTABLA, FILA, COLUMNA, Word.WdColor.wdColorGray20)
                    End If
                End If

                If FILA_SOMBREADA = True Then
                    If FILA = INDICE_FILA_SOMBREADA Then
                        SOMBREAR_CELDA(OTABLA, FILA, COLUMNA, Word.WdColor.wdColorGray05)
                    End If
                End If

                AJUSTAR_TABLA(OTABLA, COLUMNA)
            Next
        Next
        CENTRAR_TABLA(OTABLA)
        OTABLA.Borders.OutsideColor = WdColor.wdColorWhite 'COLOCA COLOR DE BORDE A LA TABLA EN BLANCO

        PARRAFO = DOCUMENTO.Content.Paragraphs.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range)
    End Sub

    Friend Sub AJUSTAR_TABLA(ByRef OTABLA As Word.Table, ByVal COLUMNA As Integer)
        OTABLA.Columns(COLUMNA).AutoFit()
    End Sub

    Friend Sub CENTRAR_TABLA(ByRef OTABLA As Word.Table)
        OTABLA.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter
    End Sub

    Friend Sub SOMBREAR_CELDA(ByRef OTABLA As Word.Table, ByVal FILA As Integer, ByVal COLUMNA As Integer, ByVal COLOR As Word.WdColor)
        Dim CELDA As Word.Cell
        CELDA = OTABLA.Cell(FILA, COLUMNA)
        CELDA.Range.Shading.BackgroundPatternColor = COLOR
    End Sub

    Friend Sub CREAR_DIRECTORIO(ByVal UNIDAD As String, ByVal CARPETA As String)
        DIRECTORIO = UNIDAD & ":\" & CARPETA
        Directory.CreateDirectory(DIRECTORIO)
    End Sub

    Friend Sub GUARDAR_DOCUMENTO_PDF(ByVal NOMBRE_REPORTE As String, ByRef DOCUMENTO As Word.Document)
        Dim DIRECCION As String = DIRECTORIO & "\" & NOMBRE_REPORTE
        DOCUMENTO.SaveAs2(DIRECCION & ".DOCX")
        REPORTE_DIRECCION_WORD = DIRECCION & ".DOCX"
        DOCUMENTO.ExportAsFixedFormat(DIRECCION, WdExportFormat.wdExportFormatPDF, False)
        REPORTE_DIRECCION_PDF = DIRECCION & ".pdf"

        If MsgBox("¿Desea enviar el documento a la impresora?", vbQuestion + vbYesNo, "Impresora") = vbYes Then
            DOCUMENTO.PrintOut()
        End If
    End Sub

    Friend Sub CERRAR_DOCUMENTO_WORD(ByRef OWORD As Word.Application, ByRef DOCUMENTO As Word.Document)
        OWORD.Documents.Close()
        OWORD.Application.Quit()
        OWORD = Nothing
        DOCUMENTO = Nothing
    End Sub

    Friend Sub LIBERAR_RECURSOS_WORD(ByRef OWORD As Word.Application, ByRef DOCUMENTO As Word.Document)
        ' Liberar recursos.
        If DOCUMENTO IsNot Nothing Then
            System.Runtime.InteropServices.Marshal.ReleaseComObject(DOCUMENTO)
        End If
        If OWORD IsNot Nothing Then
            System.Runtime.InteropServices.Marshal.ReleaseComObject(OWORD)
        End If
        DOCUMENTO = Nothing
        OWORD = Nothing

        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub

    Friend Sub IMPRIMIR(ByVal F As Byte, ByVal C As Byte, OCUPA_TABLA As Boolean, ByRef L As ListView,
                        ByVal NombreCompleto As String, ByVal PuntajeTotal As String, ByVal TotalAciertos As String,
                        ByVal TotalDesaciertos As String, ByVal Calificacion As String)
        Dim OWORD As New Word.Application
        Dim DOCUMENTO As New Word.Document
        Dim OTABLA As Word.Table

        Dim P0, P1, P2, P3, P4, P5 As Word.Paragraph
        Dim TABLA(F + 1, C) As String

        OWORD.Visible = True 'PERMITE ABRIR EL DOCUMENTO DE WORD MIENTRAS SE ESTA CONSTRUYENDO

        'CREA EL DOCUMENTO DE WORD HAY QUE HACERLO POR CADA DOCUMENTO QUE CREE EN CASO QUE SEA DE MODO SERIAL.
        DOCUMENTO = OWORD.Documents.Add

        INSERTAR_REGLON(DOCUMENTO, True, P0, "Reporte de Partida", True, False, 20, "Arial", "C")
        INSERTAR_REGLON(DOCUMENTO, False, P1, "Estudiante: " + NombreCompleto, False, False, 18, "Arial", "C")

        If OCUPA_TABLA = True Then
            For i = 0 To C
                TABLA(0, i) = L.Columns(i).Text 'aqui se obtiene el contenido del encabezado
            Next

            For i = 0 To F 'filas
                For j = 0 To C 'columnas
                    TABLA(i + 1, j) = L.Items(i).SubItems(j).Text
                Next
            Next
            INSERTAR_TABLA(OTABLA, DOCUMENTO, TABLA, 6, 8, 11, "Century Gothic", "C", False, False, 0, False, 0, False, P1, 0, False, 0, False, False, 0, False, 0)
        End If

        INSERTAR_LINEA_BLANCO(P1, 1)

        INSERTAR_REGLON(DOCUMENTO, False, P2, "Puntaje total: " + PuntajeTotal, False, False, 12, "Arial", "C")
        INSERTAR_REGLON(DOCUMENTO, False, P3, "Total aciertos: " + TotalAciertos, False, False, 12, "Arial", "C")
        INSERTAR_REGLON(DOCUMENTO, False, P4, "Total desaciertos: " + TotalDesaciertos, False, False, 12, "Arial", "C")
        INSERTAR_REGLON(DOCUMENTO, False, P5, "Calificación: " + Calificacion, False, False, 12, "Arial", "C")

        CREAR_DIRECTORIO("C", "ReportesPartida")
        GUARDAR_DOCUMENTO_PDF(NombreCompleto, DOCUMENTO)
        CERRAR_DOCUMENTO_WORD(OWORD, DOCUMENTO)
        MsgBox("Reporte satisfactorio", vbInformation + vbOKOnly, "Finalizado")
    End Sub



End Module