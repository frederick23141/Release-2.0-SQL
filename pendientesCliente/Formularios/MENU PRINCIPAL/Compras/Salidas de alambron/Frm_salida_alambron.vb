Imports entidadNegocios
Imports logicaNegocios
Public Class Frm_salida_alambron
    Private objOpSimplesLn As New Op_simpesLn
    Private objEnvCorreoLN As New EnvCorreoLN
    Public carga_comp As Boolean = False
    Dim objIngresoProdLn As New Ing_prodLn
    Dim permiso As String
    Dim filaSelect As Integer = 0
    Dim nomb_modulo As String
    Dim entregas_parciales As String = ""
    Public numeroExistente As Integer
    Private obj_traslado_bodLn As New traslado_bodLn
    Dim usuario As New UsuarioEn
    Dim objOrdenProdLn As New OrdenProdLn

    Public Sub Main(ByVal usuario As UsuarioEn, ByVal numeroExistente As Integer, ByVal nomb_modulo As String)
        permiso = usuario.permiso.Trim
        Me.nomb_modulo = nomb_modulo
        Me.usuario = usuario
        If (permiso.Trim <> "ADMIN" And permiso <> "COMPRAS" And permiso <> "ALMACEN") Then
            If (numeroExistente <> 0) Then
                btnGuardar.Enabled = False
                dtgSolicitud.Enabled = False
                groupDatosSol.Enabled = False
                txtObservaciones.ReadOnly = True
                colCant.ReadOnly = True
            End If
        Else
            If (numeroExistente <> 0) Then
                colDesc.ReadOnly = True
                groupDatosSol.Enabled = False
                txtObservaciones.ReadOnly = True
                colCant.ReadOnly = True
            End If
        End If
        Me.numeroExistente = numeroExistente
        carga_comp = True
    End Sub
    Private Sub Frm_salida_alambron_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargar_cbo()
        dtgSolicitud.Rows.Add()
        dtgSolicitud.Item(colCant.Name, 0).Value = 0
        dtgSolicitud.Item(ColNumDet.Name, 0).Value = 1
    End Sub
    Private Sub cargar_cbo()
        Dim sql As String
        Dim dt As New DataTable
        Dim dr As DataRow
        sql = "SELECT nit,nombres FROM V_nom_personal_Activo_con_maquila WHERE centro = 2100  order by nombres"
        dt = objOpSimplesLn.listar_datatable(sql, "CORSAN")
        dr = dt.NewRow
        dr("nit") = 0
        dr("nombres") = "Seleccione"
        dt.Rows.Add(dr)
        cboQuienSolicita.DataSource = dt
        cboQuienSolicita.ValueMember = "nit"
        cboQuienSolicita.DisplayMember = "nombres"
        cboQuienSolicita.Text = "Seleccione"

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If (validar()) Then
            guardar()
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        nuevo()
    End Sub
    Private Sub nuevo()
        entregas_parciales = ""
        txtObservaciones.ReadOnly = False
        btnGuardar.Enabled = True
        dtgSolicitud.Enabled = True
        groupDatosSol.Enabled = True
        cboQuienSolicita.Text = "Seleccione"
        dtgSolicitud.DataSource = Nothing
        colCant.ReadOnly = False
        txtObservaciones.Text = ""
        dtgSolicitud.Rows.Clear()
        dtgSolicitud.Rows.Add()
        dtgSolicitud.Item(colCant.Name, 0).Value = 0
        dtgSolicitud.Item(ColNumDet.Name, 0).Value = 1
        numeroExistente = 0
    End Sub
    Private Sub guardar()
        dtgSolicitud.CurrentCell = Nothing
        Dim insertoCorrecto As Boolean = False
        Dim listSql As New List(Of Object)
        Dim numero As Integer = 0
        Dim solicitante As String = cboQuienSolicita.SelectedValue
        Dim fecha_solicitud As String = objOpSimplesLn.cambiarFormatoFecha(cboFechaSol.Value)
        Dim observaciones As String = txtObservaciones.Text
        Dim sqlDet As String = ""
        Dim sqlEnc As String = ""
        Dim medida As String = ""
        Dim devolver As String = "N"
        If chk_devolver.Checked Then
            devolver = "S"
        End If
        If (numeroExistente = 0) Then
            numero = objIngresoProdLn.consultar_valor("SELECT MAX (numero)  FROM J_salida_alambron_enc ", "PRODUCCION") + 1
        Else
            numero = numeroExistente
        End If
        sqlDet = "DELETE FROM J_salida_alambron_det WHERE numero =" & numero
        listSql.Add(sqlDet)
        sqlEnc = "DELETE FROM J_salida_alambron_enc WHERE numero =" & numero
        listSql.Add(sqlEnc)
        sqlEnc = "INSERT INTO J_salida_alambron_enc (numero,fecha,solicita,observaciones , devolver) " & _
                            "VALUES (" & numero & ",GETDATE()," & solicitante & ",'" & observaciones & "','" & devolver & "')"
        listSql.Add(sqlEnc)


        For i = 0 To dtgSolicitud.RowCount - 1
            If (dtgSolicitud.Item(colDesc.Name, i).Value <> "") Then
                sqlDet = "INSERT INTO J_salida_alambron_det (numero,id_detalle,codigo,cantidad) VALUES " & _
                               "(" & numero & "," & i & ",'" & dtgSolicitud.Item(colCodigo.Name, i).Value & "'," & dtgSolicitud.Item(colCant.Name, i).Value & ")"
                listSql.Add(sqlDet)
            End If
        Next
        insertoCorrecto = objIngresoProdLn.ExecuteSqlTransaction(listSql, "PRODUCCION")
        If (insertoCorrecto) Then
            MessageBox.Show("La solicitud fue guardada en forma exitosa!,solicitud número " & numero, "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            nuevo()
        Else
            MessageBox.Show("Error al guardar la solicitud comuniquese con el administrador del sistema ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function validar() As Boolean
        Dim resp As Boolean = False
        Dim cantProductos As Integer = 0
        dtgSolicitud.CurrentCell = Nothing
        If (txtObservaciones.Text <> "") Then
            If (cboQuienSolicita.Text <> "Seleccione" And dtgSolicitud.RowCount >= 0) Then
                For i = 0 To dtgSolicitud.RowCount - 1
                    If (dtgSolicitud.Item(colCodigo.Name, i).Value <> "") Then
                        cantProductos += 1
                        If (dtgSolicitud.Item(colCant.Name, i).Value <> 0) Then
                            resp = True
                        Else
                            resp = False
                            MessageBox.Show("La cantidad del  producto de la fila " & i + 1 & " no puede ser ingresado en 0 ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            i = dtgSolicitud.RowCount - 1
                        End If

                    End If
                Next
                If (cantProductos = 0) Then
                    MessageBox.Show("Se debe ingresar al menos 1 producto para crear la solicitud ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    resp = False
                End If
            Else
                MessageBox.Show("Verifiqe que el campo quien solicita y los productos este llenos ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("El campo observaciones es obligatorio ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Return resp
    End Function

    Private Function existeNumDet(ByVal num_det As Integer, ByVal numero As Integer) As Boolean
        Dim sql As String = "SELECT num_det FROM J_salida_alambron_det WHERE num_det = " & num_det & " AND numero = " & numero
        If (objIngresoProdLn.consultValor(sql, "PRODUCCION") = "") Then
            Return False
        Else
            Return True
        End If
    End Function


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FrmPrincipal.Show()
        Me.Close()
        FrmPrincipal.Activate()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FrmLogin.Show()
        FrmPrincipal.Close()
        Me.Close()
    End Sub
    Private Sub dtgSolicitud_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitud.CellClick
        If (e.RowIndex >= 0) Then
            Dim col As String = dtgSolicitud.Columns(e.ColumnIndex).Name
            If (col = colCodigo.Name Or col = colDesc.Name) Then
                txtDesc.Text = ""
                txtCodigo.Text = ""
                groupCodigo.Visible = True
                txtDesc.Focus()
                filaSelect = e.RowIndex
            End If
        End If
    End Sub

    Private Sub dtgSolicitud_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgSolicitud.CellValueChanged
        If (carga_comp And e.RowIndex >= 0) Then
            Dim col As String = dtgSolicitud.Columns(e.ColumnIndex).Name
            Dim valor As String = dtgSolicitud.Item(col, e.RowIndex).Value
            If (col = colCant.Name) Then
                If (valor = "") Then
                    MessageBox.Show("El la cantidad del producto no puede ser ingresado vacio", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    carga_comp = False
                    dtgSolicitud.Item(col, e.RowIndex).Value = 0
                    carga_comp = True
                Else
                    If Not IsNumeric(valor) Then
                        MessageBox.Show("El valor ingresado debe ser númerico", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        carga_comp = False
                        dtgSolicitud.Item(col, e.RowIndex).Value = 0
                        carga_comp = True
                    End If
                End If
            End If
        End If
    End Sub


    Public Sub eliminarNoUsadas()
        For i = 0 To dtgSolicitud.RowCount - 1
            If IsNothing(dtgSolicitud.Item(colDesc.Name, i).Value) Then
                dtgSolicitud.Rows(i).Visible = False
            Else
                If (dtgSolicitud.Item(colDesc.Name, i).Value.ToString = "") Then
                    dtgSolicitud.Rows(i).Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub btnCerrarEditResp_Click(sender As Object, e As EventArgs) Handles btnCerrarEditResp.Click
        groupCodigo.Visible = False
        dtgCodigo.DataSource = Nothing
    End Sub

    Private Sub dtgCodigo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgCodigo.CellClick
        If (e.RowIndex >= 0) Then
            Dim codigo As String = dtgCodigo.Item("codigo", e.RowIndex).Value
            Dim descripcion As String = dtgCodigo.Item("descripcion", e.RowIndex).Value
            Dim costo_unitario As Double = 0
            Dim generico As String = ""
            If Not IsDBNull(dtgCodigo.Item("costo_unitario", e.RowIndex).Value) Then
                costo_unitario = dtgCodigo.Item("costo_unitario", e.RowIndex).Value
            End If
            If Not IsDBNull(dtgCodigo.Item("generico", e.RowIndex).Value) Then
                generico = dtgCodigo.Item("generico", e.RowIndex).Value
            End If

            Dim stock_b1 As String = objOpSimplesLn.consultarStock(codigo, 1)
            Dim stock_b2 As String = objOpSimplesLn.consultarStock(codigo, 2)
            dtgSolicitud.Item(colCodigo.Name, filaSelect).Value = codigo
            dtgSolicitud.Item(colDesc.Name, filaSelect).Value = descripcion
            dtgSolicitud.Item(colStock.Name, filaSelect).Value = stock_b1
            dtgSolicitud.Item(colStockB2.Name, filaSelect).Value = stock_b2
            btnCerrarEditResp.PerformClick()
        End If
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged
        If (txtDesc.Text.Length > 1) Then
            cargarCodigos("", txtDesc.Text)
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        If (txtCodigo.Text.Length > 1) Then
            cargarCodigos(txtCodigo.Text, "")
        End If
    End Sub
    Private Sub cargarCodigos(ByVal codigo As String, ByVal descripcion As String)
        Dim where_sql As String = ""
        If (codigo <> "") Then
            where_sql &= " codigo like '" & codigo & "%' "
        ElseIf (descripcion <> "") Then
            where_sql &= " descripcion like '%" & descripcion & "%'"
        End If
        Dim sql As String = "SELECT codigo,descripcion,costo_unitario,generico FROM referencias WHERE " & where_sql & " AND codigo like '1%'"
        dtgCodigo.DataSource = objOpSimplesLn.listar_datatable(sql, "CORSAN")
    End Sub

End Class