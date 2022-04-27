Imports entidadNegocios
Imports logicaNegocios
Imports Microsoft.Office.Interop



Public Class Frm_detalle_paros
    Dim usuario As UsuarioEn
    Private objOpsimpesLn As New Op_simpesLn
    Private objOperacionesForm As OperacionesFormularios = New OperacionesFormularios
    Dim db_corsan As String = ""
    Private obj_Op_simpesLn As New Op_simpesLn
    Private obj_op_simplesLn As New Op_simpesLn
    Dim objOpSimplesLn As New Op_simpesLn
    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click


        Dim sql_ppto_distribucion As String = "SELECT  dbo.J_det_orden_paros.cod_orden, dbo.J_det_orden_paros.cod_det,dbo.D_paros_tipos_tref.id, dbo.D_paros_tipos_tref.descripcion, CONVERT(varchar,dbo.J_det_orden_paros.h_ini,8) As Inicio , convert(varchar, dbo.J_det_orden_paros.h_fin,8) As Final, 
                         dbo.J_det_orden_paros.total, dbo.J_prod_tref_completo.h_ini AS inicio_turno, dbo.J_prod_tref_completo.h_fin AS Fin_turno, dbo.J_Maquinas.Nombre, 
                         CORSAN.dbo.V_nom_personal_Activo_con_maquila.nombres, DATEDIFF(minute, dbo.J_prod_tref_completo.h_ini, dbo.J_prod_tref_completo.h_fin) AS minutos_turno,dbo.J_prod_tref_completo.alambron, dbo.J_prod_tref_completo.reproceso, dbo.J_prod_tref_completo.tran_prod
FROM            dbo.J_det_orden_paros INNER JOIN
                         dbo.J_prod_tref_completo ON dbo.J_det_orden_paros.cod_orden = dbo.J_prod_tref_completo.consecutivo AND dbo.J_det_orden_paros.cod_det = dbo.J_prod_tref_completo.id_detalle INNER JOIN
                         dbo.J_Maquinas ON dbo.J_prod_tref_completo.maquina = dbo.J_Maquinas.codigoM INNER JOIN
                         dbo.D_paros_tipos_tref ON dbo.J_det_orden_paros.num_paro = dbo.D_paros_tipos_tref.id FULL OUTER JOIN
                         CORSAN.dbo.V_nom_personal_Activo_con_maquila ON dbo.J_prod_tref_completo.nit = CORSAN.dbo.V_nom_personal_Activo_con_maquila.nit
WHERE        (dbo.J_det_orden_paros.cod_orden = " & txtcodigoorden.Text & ") AND (dbo.J_det_orden_paros.cod_det = " & txtiddetalle.Text & ")"
        Dim detalle As DataTable = obj_op_simplesLn.listar_datatable(sql_ppto_distribucion, "PRODUCCION")
        dtg_detalle_paros.DataSource = detalle
        'dtg_detalle_paros.Dock = DockStyle.Fill
        dtg_detalle_paros.Columns("inicio_turno").Visible = False
        dtg_detalle_paros.Columns("fin_turno").Visible = False
        dtg_detalle_paros.Columns("minutos_turno").Visible = False
        dtg_detalle_paros.Columns("alambron").Visible = False
        dtg_detalle_paros.Columns("reproceso").Visible = False
        dtg_detalle_paros.Columns("tran_prod").Visible = False


        ''declaramos variables para la grafica
        Dim paro0, paro1, paro2, paro3, paro4, paro5, paro6, paro7, paro8, paro9, paro10, paro11, paro12, paro13, paro14, paro15 As Integer
        Dim tparo1, tparo2, tparo3, tparo4, tparo5, tparo6, tparo7, tparo8, tparo9, tparo10, tparo11, tparo12, tparo13, tparo14, tparo15 As String
        paro0 = 0
        paro1 = 0
        paro2 = 0
        paro3 = 0
        paro4 = 0
        paro5 = 0
        paro6 = 0
        paro7 = 0
        paro8 = 0
        paro9 = 0
        paro10 = 0
        paro11 = 0
        paro12 = 0
        paro13 = 0
        paro14 = 0
        paro15 = 0

        Dim titulos As String
        Dim tiempototalparos As Integer = 0

        BunifuHorizontalBarChart1.Data = Nothing
        BunifuChartCanvas1.Labels = Nothing
        BunifuHorizontalBarChart1.BackgroundColor = Nothing

        If dtg_detalle_paros.Rows.Count > 1 Then

            For i = 0 To detalle.Rows.Count - 1
                txttiempoplanilla.Text = detalle.Rows(i).Item("minutos_turno").ToString
                txtinicio.Text = detalle.Rows(i).Item("inicio_turno").ToString
                txtfinal.Text = detalle.Rows(i).Item("fin_turno").ToString
                txtreproceso.Text = detalle.Rows(i).Item("reproceso").ToString
                txtalambron.Text = detalle.Rows(i).Item("alambron").ToString
                txttransacion.Text = detalle.Rows(i).Item("tran_prod").ToString
                Select Case detalle.Rows(i).Item("id")
                    Case 0
                        paro0 += detalle.Rows(i).Item("total")
                    Case 1
                        paro1 += detalle.Rows(i).Item("total")
                        tparo1 = detalle.Rows(i).Item("descripcion").ToString
                    Case 2
                        paro2 += detalle.Rows(i).Item("total")
                        tparo2 = detalle.Rows(i).Item("descripcion").ToString
                    Case 3
                        paro3 += detalle.Rows(i).Item("total")
                        tparo3 = detalle.Rows(i).Item("descripcion").ToString
                    Case 4
                        paro4 += detalle.Rows(i).Item("total")
                        tparo4 = detalle.Rows(i).Item("descripcion").ToString
                    Case 5
                        paro5 += detalle.Rows(i).Item("total")
                        tparo5 = detalle.Rows(i).Item("descripcion").ToString
                    Case 6
                        paro6 += detalle.Rows(i).Item("total")
                        tparo6 = detalle.Rows(i).Item("descripcion").ToString
                    Case 7
                        paro7 += detalle.Rows(i).Item("total")
                        tparo7 = detalle.Rows(i).Item("descripcion").ToString
                    Case 8
                        paro8 += detalle.Rows(i).Item("total")
                        tparo8 = detalle.Rows(i).Item("descripcion").ToString
                    Case 9
                        paro9 += detalle.Rows(i).Item("total")
                        tparo9 = detalle.Rows(i).Item("descripcion").ToString
                    Case 10
                        paro10 += detalle.Rows(i).Item("total")
                        tparo10 = detalle.Rows(i).Item("descripcion").ToString
                    Case 11
                        paro11 += detalle.Rows(i).Item("total")
                        tparo11 = detalle.Rows(i).Item("descripcion").ToString
                    Case 12
                        paro12 += detalle.Rows(i).Item("total")
                        tparo2 = detalle.Rows(i).Item("descripcion").ToString
                    Case 13
                        paro13 += detalle.Rows(i).Item("total")
                        tparo3 = detalle.Rows(i).Item("descripcion").ToString
                    Case 14
                        paro14 += detalle.Rows(i).Item("total")
                        tparo14 = detalle.Rows(i).Item("descripcion").ToString
                    Case 15
                        paro15 += detalle.Rows(i).Item("total")
                        tparo15 = detalle.Rows(i).Item("descripcion").ToString

                End Select
            Next

            tiempototalparos = (paro0 + paro1 + paro2 + paro3 + paro4 + paro5 + paro6 + paro7 + paro8 + paro9 + paro10 + paro11 + paro12 + paro13 + paro14 + paro15)
            BunifuRadialGaugetiempoparo.Maximum = CInt(txttiempoplanilla.Text)
            txttotparos.Text = tiempototalparos
            BunifuRadialGaugetiempoparo.Value = (tiempototalparos / CInt(txttiempoplanilla.Text)) * 100

            'creamos variable para almacenar los datos mayores a 0
            Dim data As List(Of Double) = New List(Of Double)()
            data.Add(paro0)
            data.Add(paro1)
            data.Add(paro2)
            data.Add(paro3)
            data.Add(paro4)
            data.Add(paro5)
            data.Add(paro6)
            data.Add(paro7)
            data.Add(paro8)
            data.Add(paro9)
            data.Add(paro10)
            data.Add(paro11)
            data.Add(paro12)
            data.Add(paro13)
            data.Add(paro14)
            data.Add(paro15)


            'Dim Values As String = String.Join(",", datalabel)
            ' asignamos la data al grafico
            BunifuHorizontalBarChart1.Data = data

            BunifuHorizontalBarChart1.TargetCanvas = BunifuChartCanvas1
            'BunifuChartCanvas1.Labels =  "," & String() {"hola"}
            'asignamos el canvas

            Dim r = New Random()
            Dim bgColors As List(Of Color) = New List(Of Color)()
            For i As Integer = 0 To 15
                'bgColors.Add(Color.FromArgb(r.[Next](256), r.[Next](256), r.[Next](256)))

                bgColors.Add(Color.FromArgb(213, 89, 25))
            Next
            BunifuHorizontalBarChart1.BackgroundColor = bgColors
        Else
            BunifuSnackbar1.Show(Me,
            "No se ha encontrado informacion para la orden ingresada.",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
             1000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopCenter,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner)

            ''resetear campos
            txttiempoplanilla.Text = "-"
            txttotparos.Text = "-"
            BunifuRadialGaugetiempoparo.Value = 0
            txtinicio.Text = "-"
            txtfinal.Text = "-"
            txtreproceso.Text = "-"
            txtalambron.Text = "-"
            txttransacion.Text = "-"

            BunifuHorizontalBarChart1.Data = Nothing

        End If



    End Sub




    'Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)
    '    Dim m_Excel As New Excel.Application
    '    m_Excel.Cursor = Excel.XlMousePointer.xlWait
    '    m_Excel.Visible = True
    '    Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
    '    Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
    '    With objHojaExcel
    '        .Visible = Excel.XlSheetVisibility.xlSheetVisible
    '        .Activate()
    '        'Encabezado  
    '        .Range("A1:L1").Merge()
    '        .Range("A1:L1").Value = "CORSAN PAROS TREFILADORAS"
    '        .Range("A1:L1").Font.Bold = True
    '        .Range("A1:L1").Font.Size = 15
    '        'Copete  
    '        .Range("A2:L2").Merge()
    '        .Range("A2:L2").Value = titulo
    '        .Range("A2:L2").Font.Bold = True
    '        .Range("A2:L2").Font.Size = 12

    '        Const primeraLetra As Char = "A"
    '        Const primerNumero As Short = 3
    '        Dim Letra As Char, UltimaLetra As Char
    '        Dim Numero As Integer, UltimoNumero As Integer
    '        Dim cod_letra As Byte = Asc(primeraLetra) - 1
    '        'Dim sepDec As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
    '        'Dim sepMil As String = Application.CurrentCulture.NumberFormat.NumberGroupSeparator
    '        Dim sepDec As String = ","
    '        Dim sepMil As String = "."
    '        'Establecer formatos de las columnas de la hija de cálculo  
    '        Dim strColumna As String = ""
    '        Dim LetraIzq As String = ""
    '        Dim cod_LetraIzq As Byte = Asc(primeraLetra) - 1
    '        Letra = primeraLetra
    '        Numero = primerNumero
    '        Dim objCelda As Excel.Range
    '        For Each c As DataGridViewColumn In DataGridView1.Columns
    '            If c.Visible Then
    '                If Letra = "Z" Then
    '                    Letra = primeraLetra
    '                    cod_letra = Asc(primeraLetra)
    '                    cod_LetraIzq += 1
    '                    LetraIzq = Chr(cod_LetraIzq)
    '                Else
    '                    cod_letra += 1
    '                    Letra = Chr(cod_letra)
    '                End If
    '                strColumna = LetraIzq + Letra + Numero.ToString
    '                objCelda = .Range(strColumna, Type.Missing)
    '                objCelda.Value = c.HeaderText
    '                objCelda.EntireColumn.Font.Size = 8
    '                'objCelda.EntireColumn.NumberFormat = c.DefaultCellStyle.Format  
    '                If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
    '                    objCelda.EntireColumn.NumberFormat = "#" + sepMil + "0" + sepDec + "00"
    '                End If
    '            End If
    '        Next

    '        Dim objRangoEncab As Excel.Range = .Range(primeraLetra + Numero.ToString, LetraIzq + Letra + Numero.ToString)
    '        objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
    '        UltimaLetra = Letra
    '        Dim UltimaLetraIzq As String = LetraIzq

    '        'CARGA DE DATOS  
    '        Dim i As Integer = Numero + 1

    '        For Each reg As DataGridViewRow In DataGridView1.Rows
    '            LetraIzq = ""
    '            cod_LetraIzq = Asc(primeraLetra) - 1
    '            Letra = primeraLetra
    '            cod_letra = Asc(primeraLetra) - 1
    '            For Each c As DataGridViewColumn In DataGridView1.Columns
    '                If c.Visible Then
    '                    If Letra = "Z" Then
    '                        Letra = primeraLetra
    '                        cod_letra = Asc(primeraLetra)
    '                        cod_LetraIzq += 1
    '                        LetraIzq = Chr(cod_LetraIzq)
    '                    Else
    '                        cod_letra += 1
    '                        Letra = Chr(cod_letra)
    '                    End If
    '                    strColumna = LetraIzq + Letra
    '                    ' acá debería realizarse la carga  
    '                    .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
    '                    '.Cells(i, strColumna) = IIf(IsDBNull(reg.(c.DataPropertyName)), c.DefaultCellStyle.NullValue, reg(c.DataPropertyName))  
    '                    '.Range(strColumna + i, strColumna + i).In()  

    '                End If
    '            Next
    '            Dim objRangoReg As Excel.Range = .Range(primeraLetra + i.ToString, strColumna + i.ToString)
    '            objRangoReg.Rows.BorderAround()
    '            objRangoReg.Select()
    '            i += 1
    '        Next
    '        UltimoNumero = i

    '        'Dibujar las líneas de las columnas  
    '        LetraIzq = ""
    '        cod_LetraIzq = Asc("A")
    '        cod_letra = Asc(primeraLetra)
    '        Letra = primeraLetra
    '        For Each c As DataGridViewColumn In DataGridView1.Columns
    '            If c.Visible Then
    '                objCelda = .Range(LetraIzq + Letra + primerNumero.ToString, LetraIzq + Letra + (UltimoNumero - 1).ToString)
    '                objCelda.BorderAround()
    '                If Letra = "Z" Then
    '                    Letra = primeraLetra
    '                    cod_letra = Asc(primeraLetra)
    '                    LetraIzq = Chr(cod_LetraIzq)
    '                    cod_LetraIzq += 1
    '                Else
    '                    cod_letra += 1
    '                    Letra = Chr(cod_letra)
    '                End If
    '            End If
    '        Next

    '        'Dibujar el border exterior grueso  
    '        Dim objRango As Excel.Range = .Range(primeraLetra + primerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
    '        objRango.Select()
    '        objRango.Columns.AutoFit()
    '        objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
    '    End With

    '    m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    'End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        'ExportarDatosExcel(dtg_detalle_paros, "DETALLE DE PAROS")

        Me.UseWaitCursor = True
        Application.DoEvents()
        objOperacionesForm.exportarExcel(dtg_detalle_paros)
        Me.UseWaitCursor = False
    End Sub


End Class