﻿Imports accesoDatos
Imports logicaNegocios
Public Class Frm_transacion_mp_tsar
    Dim bod_origen As Integer = 0
    Dim bod_destino As Integer = 0
    Dim modelo As String = ""
    Dim nit_usuario As String
    Dim codigo_aut As String = ""
    Dim num_solicitud As Double = 0
    Dim num_sol_detalle As Double = 0
    Dim cargaComp As Boolean = False
    Dim dtTransacciones As New DataTable
    Dim objTraslado_bodLn As New traslado_bodLn
    Dim obj_gestion_materia_primaLn As New Gestion_materia_primaLn
    Dim obj_gestion_alambronLn As New Gestion_alambronLn
    Private objEnvCorreoLN As New EnvCorreoLN
    Private objOrdenProdLn As New OrdenProdLn
    Private obj_Ing_prodLn As New Ing_prodLn
    Private objOpSimplesLn As New Op_simpesLn
    Private numero_transaccion As Double
    Private objOperacionesDb As New OperacionesDb
    Dim db_produccion As String = ""
    Public Sub Main(ByVal nit As Double, ByVal bod_origen As Integer, ByVal bod_destino As Integer, ByVal modelo As String)
        Me.nit_usuario = nit
        Me.bod_origen = bod_origen
        Me.bod_destino = bod_destino
        Me.modelo = modelo
        habilitarCampos(True)
        cargar_solicitudes()
        bloquear_frm_transaccion(False)
        Me.Text = "movimiento: bodega " & bod_origen & " - " & bod_destino
    End Sub
    Private Sub Frm_transacion_mp_puntilleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT T.tipo,T.sw " & _
                              "FROM  tipo_transacciones T " & _
                                    "WHERE T.tipo = 'SAR' "
        dtTransacciones = obj_Ing_prodLn.listar_datatable(sql, "CORSAN")
        cboTipo.DataSource = dtTransacciones
        cboTipo.ValueMember = "sw"
        cboTipo.DisplayMember = "tipo"
        cboTipo.Text = "Seleccione"
        Me.Location.X.Equals(10)
        Me.Location.Y.Equals(10)
        habilitarCampos(False)
        txtCodigoLector.Focus()
        cargaComp = True
        db_produccion = objOpSimplesLn.get_nom_db("PRODUCCION") & ".dbo."
    End Sub
    Private Sub habilitarCampos(ByVal estado As Boolean)
        txtCodigoLector.Enabled = estado
        cboTipo.Enabled = estado
        btnGuardar.Enabled = estado
        dtgConsulta.Enabled = estado
    End Sub

    Private Sub bloquear_frm_transaccion(ByVal estado As Boolean)
        txtCodigoLector.Enabled = estado
        btnGuardar.Enabled = estado
        cboTipo.Enabled = estado
    End Sub
    Private Sub cargar_solicitudes()
        Dim whereSql As String = ""
        whereSql &= " AND (e.devolver = 'N' OR e.devolver IS NULL ) "

        Dim sql As String = "SELECT E.numero,D.id_detalle,E.fecha,D.codigo,(SELECT CASE WHEN (SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle ) is null THEN D.cantidad  ELSE (D.cantidad -(SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle )) END )As pendiente  ,R.descripcion FROM J_salida_materia_prima_Tsar_enc E ,J_salida_materia_prima_Tsar_det D, CORSAN.dbo.referencias R " & _
        " WHERE year(E.fecha)=" & Now.Year & " AND E.anulado is null  AND  R.codigo = D.codigo AND D.numero = E.numero " & whereSql & _
        "AND (D.cantidad - (SELECT CASE WHEN ((SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle )) is null THEN 0 ELSE ((SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle ))END) > 0 ) ORDER BY E.fecha "

        dtg_pedido.DataSource = objOpSimplesLn.listar_datatable(sql, "PRODUCCION")
        dtg_pedido.Columns("id_detalle").Visible = False
        dtg_pedido.Columns("fecha").DefaultCellStyle.Format = "d"
        dtg_pedido.Columns("numero").HeaderText = "#"
    End Sub

    Private Sub btn_actulizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_actulizar.Click
        cargar_solicitudes()
    End Sub

    Private Sub dtg_pedido_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtg_pedido.CellContentClick
        If (e.RowIndex >= 0) Then
            Dim col As String = dtg_pedido.Columns(e.ColumnIndex).Name
            If (col = colVer.Name) Then
                tab_ppal.SelectedTab = tab_transaccion
                txtCodigoLector.Focus()
                codigo_aut = dtg_pedido.Item("codigo", e.RowIndex).Value
                num_solicitud = dtg_pedido.Item("numero", e.RowIndex).Value
                num_sol_detalle = dtg_pedido.Item("id_detalle", e.RowIndex).Value
                Me.Text = codigo_aut & " - movimiento: bodega " & bod_origen & " - " & bod_destino
                bloquear_frm_transaccion(True)
                txtCodigoLector.Focus()
            End If
        End If
    End Sub

    Private Sub guardar()
        Using New Centered_MessageBox(Me)
            Dim resp_transaccion As Boolean = False
            Dim tipo As String = cboTipo.Text
            Dim notas As String = "SPIC traslado(HandHeld) " & Now & " usuario: " & nit_usuario
            Dim peso As Double = Convert.ToDouble(txtKilos.Text)
            Dim codigo As String = Trim(lblCodigo.Text)
            Dim bodega As String = Me.bod_origen
            Dim dFec As Date = Now
            Dim usuario As String = nit_usuario
            Dim stock As Double = objOpSimplesLn.consultarStock(codigo, bodega)
            Dim consecutivo As String = txtCodigoLector.Text
            Dim listSql As New List(Of Object)
            Dim sql_solicitud As String = ""
            Dim costo_unit As Double

            Dim consecutivo_materia_prima As String
            Dim id_detalle As String
            Dim id_rollo As String

            Dim dt As New DataTable
            dt.Columns.Add("codigo")
            dt.Columns.Add("cantidad")
            dt.Rows.Add()
            dt.Rows(dt.Rows.Count - 1).Item("codigo") = codigo
            dt.Rows(dt.Rows.Count - 1).Item("cantidad") = peso
            For i = 0 To dt.Rows.Count - 1
                costo_unit = objOrdenProdLn.consultCostoUnit(dt.Rows(i).Item("codigo"))
            Next
            If peso <= stock Then
                listSql.AddRange(traslado_sar(codigo, peso, tipo, costo_unit))

                consecutivo_materia_prima = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("num_consecutivo", consecutivo)
                id_detalle = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("detalle", consecutivo)
                id_rollo = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("id_rollo", consecutivo)

                Dim sql As String = "update " & db_produccion & "J_rollos_tref set sar=" & numero_transaccion & " where  id_detalle =" & id_detalle & "  AND id_rollo =" & id_rollo & "and cod_orden=" & consecutivo_materia_prima & ""
                listSql.Add(sql)

                sql_solicitud = "INSERT INTO " & db_produccion & "J_salida_materia_prima_Tsar_transaccion" &
                                       "(numero,id_detalle,tipo,num_transaccion,peso) " &
                                               "VALUES (" & num_solicitud & "," & num_sol_detalle & ",'" & tipo & "'," & numero_transaccion & "," & peso & ") "
                listSql.Add(sql_solicitud)
                If obj_Ing_prodLn.ExecuteSqlTransaction(listSql, "CORSAN") Then
                    addRollo(consecutivo_materia_prima, id_detalle, id_rollo, tipo, peso, costo_unit, codigo, lblDescipcion.Text)
                    contar_movimientos()
                    leer_nuevo()
                    MessageBox.Show("Transacción realizada con exito! ", tipo & ": " & Convert.ToString(numero_transaccion), MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Problemas al realizar la transacción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("El pedido es mas grande que el stock! ", tipo & ": " & Convert.ToString(numero_transaccion), MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using
    End Sub
    Public Sub addRollo(ByVal consecutivo As String, ByVal id_detalle As String, ByVal num_rollo As String, ByVal tipo As String, ByVal peso As Double, ByVal cost_unitario As Double, ByVal codigo As String, ByVal descripcion As String)
        Using New Centered_MessageBox(Me)
            dtgConsulta.Rows.Add()
            Dim i As Integer = dtgConsulta.RowCount - 1
            While (i >= 1)
                dtgConsulta.Item(colConsecutivo.Name, i).Value = dtgConsulta.Item(colConsecutivo.Name, i - 1).Value
                dtgConsulta.Item(colNumRollo.Name, i).Value = dtgConsulta.Item(colNumRollo.Name, i - 1).Value
                dtgConsulta.Item(col_id_det.Name, i).Value = dtgConsulta.Item(col_id_det.Name, i - 1).Value
                dtgConsulta.Item(colPeso.Name, i).Value = dtgConsulta.Item(colPeso.Name, i - 1).Value
                dtgConsulta.Item(col_num_transaccion.Name, i).Value = dtgConsulta.Item(col_num_transaccion.Name, i - 1).Value
                dtgConsulta.Item(colCodigo.Name, i).Value = dtgConsulta.Item(colCodigo.Name, i - 1).Value
                dtgConsulta.Item(col_tipo.Name, i).Value = dtgConsulta.Item(col_tipo.Name, i - 1).Value
                i -= 1
            End While
            dtgConsulta.Item(colConsecutivo.Name, 0).Value = consecutivo
            dtgConsulta.Item(col_tipo.Name, 0).Value = tipo
            dtgConsulta.Item(col_num_transaccion.Name, 0).Value = numero_transaccion
            dtgConsulta.Item(colPeso.Name, 0).Value = peso
            dtgConsulta.Item(colCodigo.Name, 0).Value = Convert.ToString(codigo)
            dtgConsulta.Item(colNumRollo.Name, 0).Value = num_rollo
            dtgConsulta.Item(col_id_det.Name, 0).Value = id_detalle
            leer_nuevo()
        End Using
    End Sub
    Private Function traslado_sar(ByVal codigo As String, ByVal cantidad As Double, ByVal tipo As String, ByVal costo_unit As Double) As List(Of Object)
        Dim listSql As New List(Of Object)
        Dim dFec As Date = Now
        Dim usuario As String = nit_usuario
        Dim notas As String = "SPIC fecha:" & Now & " usuario:" & usuario
        numero_transaccion = objOrdenProdLn.mover_consecutivo(tipo)
        listSql = objTraslado_bodLn.transaccion_Scal_Brillante(cantidad, codigo, bod_origen, dFec, notas, usuario, tipo, costo_unit, numero_transaccion)
        Return listSql
    End Function
    Private Function validarFrm() As Boolean
        Using New Centered_MessageBox(Me)
            If (lblCodigo.Text <> "") Then
                If (txtKilos.Text <> "") Then
                    If (cboTipo.Text <> "Seleccione") Then
                        If (obj_Ing_prodLn.existeCodigo(lblCodigo.Text)) Then
                            If IsNumeric(txtKilos.Text) Then
                                If (Convert.ToDouble(txtKilos.Text) > 0) Then
                                    If (cboTipo.Text <> "Seleccione") Then
                                        If (obj_Ing_prodLn.existeTipoTransaccion(cboTipo.Text)) Then
                                            If txtCodigoLector.Text <> "" Then
                                                If validarCodigoBarrasTref(txtCodigoLector.Text) Then
                                                    Return True
                                                Else
                                                    MessageBox.Show("El código de barras no se encuentra asignado", "Código de barras no asignado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                End If
                                            Else
                                                MessageBox.Show("No se leyo ningun código de barras", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            End If
                                        Else
                                            MessageBox.Show("No existe el tipo de transacción! ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        End If
                                    Else
                                        MessageBox.Show("Seleccione un tipo de transacción! ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    End If
                                Else
                                    MessageBox.Show("Los kilos no pueden ser negativos ó iguales a (0) ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            Else
                                MessageBox.Show("Verifique que el campo 'KILOS' sea un número y no contenga letras! ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        Else
                            MessageBox.Show("El código ingresado no existe,verifique! ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("Falta el TIPO de transacción", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Faltan los kilos ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Falta el CÓDIGO ", "verifique", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End Using
        Return False
    End Function
    Private Function validarCodigoBarrasTref(ByVal consecutivo As String) As Boolean
        Dim resp As Boolean = False
        Dim consecutivo_materia_prima As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("num_consecutivo", consecutivo)
        Dim id_detalle As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("detalle", consecutivo)
        Dim id_rollo As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("id_rollo", consecutivo)
        If consecutivo_materia_prima <> "" And id_detalle <> "" And id_rollo <> "" Then
            Dim sql As String = "select cod_orden from J_rollos_tref where  id_detalle =" & id_detalle & "  AND id_rollo =" & id_rollo & "and cod_orden=" & consecutivo_materia_prima & ""
            Dim id As String = objOpSimplesLn.consultValorTodo(sql, "PRODUCCION")
            If id <> "" Then
                resp = True
            End If
        End If
        If resp = False Then
            Using New Centered_MessageBox(Me)
                MessageBox.Show("Intente leerlo nuevamente", "Problemas con el tiquete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Using
        End If
        Return resp
    End Function
    Private Function validar_guardado_rollo(ByVal peso As String)
        Dim resp As Boolean = False
        Dim peso_conver As Integer
        Dim peso_solicitud As Integer
        Dim sql_rollo As String = "SELECT (SELECT CASE WHEN (SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle ) is null THEN D.cantidad  ELSE (D.cantidad -(SELECT sum(peso) FROM J_salida_materia_prima_Tsar_transaccion  WHERE numero = D.numero AND id_detalle = D.id_detalle )) END )As pendiente FROM J_salida_materia_prima_Tsar_enc E ,J_salida_materia_prima_Tsar_det D, CORSAN.dbo.referencias R where E.numero=" & num_solicitud & " AND E.anulado is null AND  R.codigo = D.codigo AND (e.devolver = 'N' OR e.devolver IS NULL ) AND E.numero = D.numero AND id_detalle = D.id_detalle"
        peso_solicitud = CInt(objOperacionesDb.consultValor(sql_rollo, "PRODUCCION"))
        peso_conver = CInt(peso)
        If (peso_solicitud >= peso_conver) Then
            resp = True
        End If
        Return resp
    End Function
    Private Function validarTrasladoTref(ByVal consecutivo As String) As Boolean
        Dim resp As Boolean = False
        Dim consecutivo_materia_prima As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("num_consecutivo", consecutivo)
        Dim id_detalle As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("detalle", consecutivo)
        Dim id_rollo As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("id_rollo", consecutivo)
        Dim sqlTraslado = "SELECT sar,sav,scal,anulado,traslado FROM j_rollos_tref  WHERE id_detalle =" & id_detalle & "  AND id_rollo =" & id_rollo & "and cod_orden=" & consecutivo_materia_prima & ""
        Dim dt_validacion As DataTable = objOpSimplesLn.listar_datatable(sqlTraslado, "PRODUCCION")
        For i = 0 To dt_validacion.Rows.Count - 1
            If IsNumeric(dt_validacion.Rows(i).Item("sar")) Or IsNumeric(dt_validacion.Rows(i).Item("sav")) Or IsNumeric(dt_validacion.Rows(i).Item("scal")) Then
                MessageBox.Show("El rollo ya a sido consumido ", "Rollo anulado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If IsNumeric(dt_validacion.Rows(i).Item("anulado")) Then
                    Using New Centered_MessageBox(Me)
                        MessageBox.Show("El rollo esta anulado ", "Rollo anulado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Using
                Else
                    If IsNumeric(dt_validacion.Rows(i).Item("traslado")) Then
                        Using New Centered_MessageBox(Me)
                            MessageBox.Show("El rollo pertenece a otra bodega", "Rollo de otra bodega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Using
                    Else
                        resp = True
                    End If
                End If
            End If
        Next
        Return resp
    End Function
    Private Sub leer_nuevo()
        cargaComp = False
        txtKilos.Text = 0
        lblCodigo.Text = "LEA CÓDIGO"
        lblDescipcion.Text = "LEA CÓDIGO"
        txtCodigoLector.Text = ""
        txtCodigoLector.ForeColor = Color.DarkGray
        txtCodigoLector.Focus()
        cargaComp = True
    End Sub
    Private Sub soloNumero(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub contar_movimientos()
        Dim cant As Integer = 0
        For i = 0 To dtgConsulta.RowCount - 1
            cant += 1
        Next
        lbl_movimientos.Text = cant
    End Sub

    Private Sub txtCodigoLector_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoLector.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtCodigoLector.Text = Replace(txtCodigoLector.Text, "'", "-")
            Dim consecutivo As String = txtCodigoLector.Text

            If validarCodigoBarrasTref(consecutivo) Then
                Dim consecutivo_materia_prima As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("num_consecutivo", consecutivo)
                Dim id_detalle As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("detalle", consecutivo)
                Dim id_rollo As String = obj_gestion_materia_primaLn.extraerDatoCodigoBarras("id_rollo", consecutivo)
                If validarTrasladoTref(consecutivo) Then
                    Dim sql_codigo As String = "select e.prod_final " &
                                                 "FROM j_rollos_tref r , J_orden_prod_tef e " &
                                                        "WHERE e.consecutivo = r.cod_orden AND r.id_detalle =" & id_detalle & "  AND r.id_rollo =" & id_rollo & "and r.cod_orden=" & consecutivo_materia_prima & ""
                    Dim sql_peso As String = "select peso " &
                                                 "FROM j_rollos_tref " &
                                                        "WHERE id_detalle =" & id_detalle & "  AND id_rollo =" & id_rollo & "and cod_orden=" & consecutivo_materia_prima & ""
                    Dim peso As String = objOpSimplesLn.consultValorTodo(sql_peso, "PRODUCCION")
                    Dim codigo As String = objOpSimplesLn.consultValorTodo(sql_codigo, "PRODUCCION")
                    codigo = codigo.ToUpper
                    codigo_aut = codigo_aut.ToUpper
                    If validar_guardado_rollo(peso) Then
                        If codigo = codigo_aut Then
                            lblCodigo.Text = codigo
                            lblDescipcion.Text = objOpSimplesLn.getDescripcionCodigo(codigo)
                            txtKilos.Text = peso
                            txtCodigoLector.ForeColor = Color.Black
                            btnGuardar.Focus()
                        Else
                            Using New Centered_MessageBox(Me)
                                MessageBox.Show("El código de alambre no pertenece al pedido", "Código no pertenece al pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Using
                            leer_nuevo()
                        End If
                    Else
                        Using New Centered_MessageBox(Me)
                            MessageBox.Show("El alambre excede el peso del pedido", "Alambre excede el peso del pedido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Using
                    End If
                Else
                    leer_nuevo()
                End If
            End If
        ElseIf e.KeyChar = "." Then
            e.KeyChar = "-"
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (validarFrm()) Then
            Application.DoEvents()
            guardar()
            Application.DoEvents()
        End If
    End Sub
    Private Sub btn_salir_pedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir_pedido.Click
        Dim frm As New Frm_ppal_alambron
        frm.Show()
        frm.Activate()
        Me.Close()
    End Sub
    Private Sub btnGuardar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnGuardar.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar.PerformClick()
        End If
    End Sub

    Private Sub txtKilos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKilos.KeyPress
        soloNumero(e)
    End Sub

    Private Sub cboTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboTipo.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        If (cargaComp) Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub cboTipo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.TextChanged
        If (cargaComp And Trim(cboTipo.Text).Length > 2) Then
            If (obj_Ing_prodLn.existeTipoTransaccion(cboTipo.Text)) Then
                imgTipo.Image = Spic.My.Resources.ok3
            Else
                imgTipo.Image = Spic.My.Resources._1371750041_14125
            End If
        End If
    End Sub
    Private Sub txtCodigoLector_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoLector.Leave
        txtCodigoLector.BackColor = Color.Red
    End Sub

    Private Sub txtCodigoLector_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoLector.Enter
        txtCodigoLector.BackColor = Color.Green
        txtCodigoLector.Text = ""
    End Sub
    Private Sub btn_salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_salir.Click
        Dim frm As New Frm_ppal_alambron
        frm.Show()
        frm.Activate()
        Me.Close()
    End Sub
End Class