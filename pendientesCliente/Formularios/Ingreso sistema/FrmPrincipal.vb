Imports System.Threading.Tasks
Imports System.Windows.Media
Imports Bunifu.UI.WinForms.BunifuAnimatorNS
Imports entidadNegocios
Imports Guna.UI2.WinForms
Imports LiveCharts
Imports LiveCharts.Defaults
Imports LiveCharts.Wpf
Imports logicaNegocios

Public Class FrmPrincipal

    Dim cadena_busqueda_nodo As String
    Private objUsuario As UsuarioEn
    Private objOpSimplesLn As New Op_simpesLn
    Private listModulos As New List(Of Object)
    Private listNodosEliminar As New List(Of TreeNode)
    Private cerrar_desde_notificacion As Boolean = False
    Private obj_Op_simpesLn As New Op_simpesLn
    Private validar_nomina As Boolean
    Private obj_Ing_prodLn As New Ing_prodLn
    Dim frm As New Frm_alerta_bd
    Dim val_timer As String
    Dim time_autocierre As Integer = 0

    Dim persistencia_datos As Boolean = False

    Dim obj_ppto_produccionLn As New Ppto_produccionLn
    Private obj_op_simplesLn As New Op_simpesLn

    Dim centro As Integer = 0
    Dim centroCostos As Integer = 0


    Dim dias_habiles As Double = 0
    Dim dias_adic As Double = 0
    Dim cant_festivos As Integer = 0
    Dim dias_trbajados As Double = 0
    Dim Primer_ingreso As Boolean
    Dim Primer_ingreso_costos As Boolean = True

    Dim fila_select As Integer = 0
    Dim fila_detalle As Integer = 0

    Dim usuario As New UsuarioEn
    ''' PARA PRESUPUESTO DE PRODUCCION

    Dim pkenero As Double = 0
    Dim pkfebrero As Double = 0
    Dim pkmarzo As Double = 0
    Dim pkabril As Double = 0
    Dim pkmayo As Double = 0
    Dim pkjunio As Double = 0
    Dim pkjulio As Double = 0
    Dim pkagosto As Double = 0
    Dim pkseptiembre As Double = 0
    Dim pkoctubre As Double = 0
    Dim pknoviembre As Double = 0
    Dim pkdiciembre As Double = 0

    Dim ll2100 As Double = 0
    Dim ll2200 As Double = 0
    Dim ll2300 As Double = 0
    Dim ll2400 As Double = 0
    Dim ll2500 As Double = 0
    Dim ll2600 As Double = 0
    Dim ll5200 As Double = 0
    Dim ll5300 As Double = 0
    Dim ll5400 As Double = 0
    Dim ll6200 As Double = 0
    Dim ll6400 As Double = 0

    Dim llenero As Double = 0
    Dim llfebrero As Double = 0
    Dim llmarzo As Double = 0
    Dim llabril As Double = 0
    Dim llmayo As Double = 0
    Dim lljunio As Double = 0
    Dim lljulio As Double = 0
    Dim llagosto As Double = 0
    Dim llseptiembre As Double = 0
    Dim llocutbre As Double = 0
    Dim llnoviembre As Double = 0
    Dim lldiciembre As Double = 0


    Dim año As String
    Dim mes As String



    Dim dt_ppto_distribucion As DataTable
    Dim dt_consulta As DataTable
    Dim dt As DataTable
    Private bunifuDataViz1 As Object

    Private Sub FindRecursive(ByVal tNode As TreeNode)
        If (txtFilterToolIDs.Text = "") Then
            TreeView1.CollapseAll()
            TreeView1.Nodes(1).EnsureVisible()
        Else
            Dim tn As TreeNode
            For Each tn In tNode.Nodes
                If tn.Text.Contains(txtFilterToolIDs.Text) Then
                    tn.BackColor = System.Drawing.Color.Red
                    tn.EnsureVisible()
                End If

                FindRecursive(tn)


            Next
        End If

    End Sub



    Private Sub PrintRecursive(ByVal n As TreeNode, ByVal tipo As String)
        If (n.Nodes.Count = 0) Then
            If (tipo = "nodo") Then
                permisoModulo(n)
            ElseIf (tipo = "Raiz") Then
                If (n.Name(0) = "R") Then
                    listNodosEliminar.Add(n)
                End If
            End If
        End If
        Dim aNode As TreeNode
        For Each aNode In n.Nodes
            PrintRecursive(aNode, tipo)
        Next
    End Sub
    Private Sub eliminarNodos()
        For i = 0 To listNodosEliminar.Count - 1
            TreeView1.Nodes.Remove(listNodosEliminar(i))
        Next
        listNodosEliminar = New List(Of TreeNode)
    End Sub
    Private Sub permisoModulo(ByVal nodo As TreeNode)
        Dim sw As Boolean = False
        For i = 0 To listModulos.Count - 1
            If (listModulos(i).trim = nodo.Name) Then
                sw = True
            End If
        Next
        If (sw = False) Then
            listNodosEliminar.Add(nodo)
        End If
    End Sub
    Private Sub CallRecursive(ByVal aTreeView As TreeView, ByVal tipo As String)
        Dim n As TreeNode
        For Each n In aTreeView.Nodes
            PrintRecursive(n, tipo)
        Next
    End Sub

    Public Sub Main(ByVal permiso As String, ByVal objUsuarioEn As UsuarioEn, ByVal validar_nomina As Boolean)
        Primer_ingreso = True
        time_autocierre = 540
        Me.usuario = objUsuarioEn
        imgSlide1.Visible = False
        imgSlide2.Visible = False
        imgSlide3.Visible = False
        panelPPTO.Visible = False

        'autocierre.Enabled = True
        Me.validar_nomina = validar_nomina
        permiso = Trim(permiso)
        listModulos = objOpSimplesLn.lista("SELECT modulo FROM J_spic_per_mod WHERE permiso = '" & permiso & "'")
        CallRecursive(TreeView1, "nodo")
        eliminarNodos()
        CallRecursive(TreeView1, "Raiz")
        eliminarNodos()
        CallRecursive(TreeView1, "Raiz")
        eliminarNodos()
        objUsuario = objUsuarioEn
        ' lblNom.Text += " " & objUsuario.nombre.ToUpper & " " & objUsuario.permiso
        lblNom.Text = ""
        lblNom.Text += " " & objUsuario.Email

        nombres_db()
        If validar_nomina Then
            Dim nit As String = ""
            If IsNumeric(objUsuario.nit) Then
                Dim centros As String = objOpSimplesLn.consultValorTodo("SELECT centro FROM J_coordinador_centros_costos WHERE nit =" & objUsuario.nit, "PRODUCCION")
                If centros <> "" And permiso <> "ADMIN" And permiso <> "DIR_PRODUCCION" And permiso <> "NOMINA" And permiso <> "COOR_PROD" And permiso <> "LOGISTICA" And permiso <> "CALIDAD" Then
                    If Now.Hour > 6 Then
                        Dim frm As New Frm_liqui_reloj
                        frm.Show()
                        Me.Close()
                        frm.MAIN("nod_liqui_reloj", objUsuario, True)
                        frm.Activate()
                        frm.WindowState = FormWindowState.Normal
                    End If
                End If
            End If
        End If
        Me.validar_nomina = False


        If (permiso <> "ADMIN") Then
            guna2Button2.Visible = False
            guna2Button3.Visible = False
            guna2Button4.Visible = False
            imgSlide1.Visible = False
            imgSlide2.Visible = False
            imgSlide3.Visible = False
        End If

    End Sub
    Private Sub TreeView1_AfterSelect_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim vendedor As Integer = objUsuario.Vendedor
        Dim listColumnas As New List(Of String)
        Dim nodeName As String = TreeView1.SelectedNode.Name
        Dim permiso As String = objUsuario.permiso.Trim
        Select Case (nodeName)
            Case "nod_ppto_vtas"
                FrmAnalisisPres.Show()
                FrmAnalisisPres.Activate()
                FrmAnalisisPres.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_acum_vtas_vend"
                FrmAcumVtasVend.Show()
                FrmAcumVtasVend.Activate()
                FrmAcumVtasVend.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_acum_vtas"
                FrmAcumVenClien.Show()
                FrmAcumVenClien.Activate()
                FrmAcumVenClien.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_est_clien_vend"
                FrmEstClienVend.Show()
                FrmEstClienVend.Activate()
                FrmEstClienVend.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_seg_vend"
                FrmSegVendAct.Show()
                FrmSegVendAct.Activate()
                FrmSegVendAct.Main(nodeName, objUsuario)
                Me.WindowState = 1
            Case "nod_ppto_rec"
                FrmPpto_recaudo.Show()
                FrmPpto_recaudo.Activate()
                FrmPpto_recaudo.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_anali_vrKilo"
                FrmAnVrKilo.Show()
                FrmAnVrKilo.Activate()
                FrmAnVrKilo.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_info_clientes"
                frmPendientes.Show()
                frmPendientes.Activate()
                frmPendientes.Main(nodeName, permiso, objUsuario, objUsuario)
                Me.WindowState = 1

            Case "nod_vtas_clie_prod"
                FrmVtasClienProd.Show()
                FrmVtasClienProd.Activate()
                FrmVtasClienProd.Main(nodeName, permiso)
                Me.WindowState = 1

            Case "nod_an_pend"
                FrmAnalisisPedido.Show()
                FrmAnalisisPedido.Activate()
                FrmAnalisisPedido.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nodGestUsu"
                FrmRegUsuario.Show()
                FrmRegUsuario.Activate()
                Me.WindowState = 1

            Case "nod_ing_vtas"
                FrmIngVtas.Show()
                FrmIngVtas.Activate()
                FrmIngVtas.Main(nodeName, objUsuario)
                Me.WindowState = 1

            Case "nod_aud_inv"
                Frm_audit_inv.Show()
                Frm_audit_inv.Activate()
                Frm_audit_inv.Main(nodeName, permiso)
                Me.WindowState = 1

            Case "nod_pend_prod"
                Frm_pend_prod.Show()
                Frm_pend_prod.Activate()
                Frm_pend_prod.Main(nodeName, permiso)
                Me.WindowState = 1

            Case "nod_anticipos"
                Frm_anticipo.Show()
                Frm_anticipo.Main(vendedor, nodeName, permiso)
                Frm_anticipo.Activate()
                Me.WindowState = 1

            Case "nod_seg_ppto"
                Frm_dtalle_seg_ppto.Show()
                Frm_dtalle_seg_ppto.Main(vendedor, nodeName, permiso, objUsuario)
                Frm_dtalle_seg_ppto.Activate()
                Me.WindowState = 1

            Case "nod_pend_prob"
                Frm_ptes_problem.Show()
                Frm_ptes_problem.Main(vendedor, objUsuario.usuario)
                Frm_ptes_problem.Activate()
                Me.WindowState = 1
            Case "nod_cartera_ing_vtas"
                frmCarteraIngVtas.Show()
                frmCarteraIngVtas.Main(vendedor, objUsuario)
                frmCarteraIngVtas.Activate()
                Me.WindowState = 1

            Case "nod_pendientes_vend"
                Frm_info_pendientes.Show()
                Frm_info_pendientes.Main(vendedor, objUsuario.usuario)
                Frm_info_pendientes.Activate()
                Me.WindowState = 1

            Case "nod_consul_ppto_rec"
                FrmConsulPptoRec.Show()
                FrmConsulPptoRec.Activate()
                Me.WindowState = 1

            Case "nod_consult_ppto_vtas"
                FrmConsultarPptoRec.Show()
                FrmConsultarPptoRec.Activate()
                Me.WindowState = 1

            Case "nod_info_dane"
                Form_informe_dane.Show()
                Form_informe_dane.Activate()
                Form_informe_dane.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_despachos"
                frmDespacho.Show()
                frmDespacho.Main(0, vendedor)
                frmDespacho.Activate()
                Me.WindowState = 1
            Case "nod_traz_vtas_linea"
                Frm_traz_vtas_consol.Show()
                Frm_traz_vtas_consol.Activate()
                Frm_traz_vtas_consol.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_ing_trefilacion"
                Frm_ing_trefilacion.Show()
                Frm_ing_trefilacion.Activate()
                Frm_ing_trefilacion.Main(nodeName, permiso)
                Me.WindowState = 1
            Case ("nod_Vtas_lin_ciuid")
                Frm_vtas_vend_ciud.Show()
                Frm_vtas_vend_ciud.Activate()
                Frm_vtas_vend_ciud.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_ing_punt"
                Frm_Ing_puntilleria.Show()
                Frm_Ing_puntilleria.Activate()
                'Frm_Ing_puntilleria.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_ing_puas"
                Frm_Ing_puas.Show()
                Frm_Ing_puas.Activate()
                Frm_Ing_puas.Main(nodeName, objUsuario)
                Me.WindowState = 1
            Case "nod_vtas_client_idCor"
                Frm_vtas_clien_idCor.Show()
                Frm_vtas_clien_idCor.Activate()
                Frm_vtas_clien_idCor.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_ppal_clientes"
                Frm_ppal_clientes.Show()
                Frm_ppal_clientes.Activate()
                Frm_ppal_clientes.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_correrias"
                Frm_correria.Show()
                Frm_correria.Activate()
                Frm_correria.Main(nodeName, permiso, objUsuario)
                Me.WindowState = 1
            Case "nod_eficiencias"
                Frm_eficiencias.Show()
                Frm_eficiencias.Activate()
                Frm_eficiencias.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_ing_galv"
                Frm_consultar_galva.Show()
                Me.WindowState = 1
            Case "nodConsultVot"
                FrmConsulVotacion.Show()
                FrmConsulVotacion.Activate()
                FrmConsulVotacion.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodGesGrup"
                FrmGestGrupVot.Show()
                FrmGestGrupVot.Activate()
                FrmGestGrupVot.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodTref3"
                FrmConsTref3.Show()
                FrmConsTref3.Activate()
                Me.WindowState = 1
            Case "nod_tref_forma3"
                Frm_ing_emp_punt.Show()
                Frm_ing_emp_punt.Activate()
                Frm_ing_emp_punt.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodIngVot"
                FrmIngVotacion.Show()
                FrmIngVotacion.Activate()
                FrmIngVotacion.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodQuejasRec"
                FrmQuejaRec.Show()
                FrmQuejaRec.main(objUsuario, nodeName, permiso)
                FrmQuejaRec.Activate()
                Me.WindowState = 1
            Case "nodPrecProd"
                FrmVerificaPrecio.Show()
                FrmVerificaPrecio.Activate()
                FrmVerificaPrecio.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodGesRef"
                FrmGestRef.Show()
                FrmGestRef.Activate()
                Me.WindowState = 1
            Case "nodOrdenProd"
                FrmOrdenProdTef.Show()
                FrmOrdenProdTef.Activate()
                FrmOrdenProdTef.main(objUsuario.usuario, objUsuario.permiso, objUsuario.nit)
                Me.WindowState = 1
            Case "nodGestPermisos"
                FrmGestPermisos.Show()
                FrmGestPermisos.main(TreeView1)
                FrmGestPermisos.Activate()
                Me.WindowState = 1
            Case "nod_Acerca_de"
                acerca_de.Show()
                Me.WindowState = 1
            Case "nodMaestroModulo"
                listColumnas.Add("descripcion")
                listColumnas.Add("nom_modulo")
                listColumnas.Add("destinatarios_correo")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("J_spic_modulos", "modulos", "CORSAN", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nodMaestroPermiso"
                listColumnas.Add("descripcion")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("J_spic_permiso", "permisos", "CORSAN", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nod_cambio_bod"
                FrmCambioBod.Show()
                FrmCambioBod.Activate()
                FrmCambioBod.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodPulimiento"
                FrmIngProdPulimiento.Show()
                FrmIngProdPulimiento.Activate()
                FrmIngProdPulimiento.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodCorreccion"
                Frm_Solicitud_Correccion.Show()
                Frm_Solicitud_Correccion.Activate()
                Frm_Solicitud_Correccion.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodMaeRepuestos"
                listColumnas.Add("descripcion")
                listColumnas.Add("id_Repuesto")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("b_Repuestos", "Repuestos", "PRODUCCION", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nod_galv_baches"
                FRM_ing_galv_baches.Show()
                FRM_ing_galv_baches.LlenarInicial("180", "Galvanizado Planta 1")
                FRM_ing_galv_baches.Activate()
                FRM_ing_galv_baches.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_temple"
                FRM_ing_galv_baches.Show()
                FRM_ing_galv_baches.LlenarInicial("213", "Tratamientos Térmicos")
                FRM_ing_galv_baches.Main(nodeName, permiso)
                FRM_ing_galv_baches.Activate()
                Me.WindowState = 1
            Case "nod_recocido"
                Frm_ing_recocido.Show()
                Frm_ing_recocido.Activate()
                Frm_ing_recocido.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nod_tiquete_rec_manual"
                frm_tiquete_recocido_manual.Show()
                Me.WindowState = 1
            Case "nod_auditoria_tref_rec"
                frm_aud_mp_tref_rec.Show()
                frm_aud_mp_tref_rec.Activate()
                Me.WindowState = 1
            Case "nodTransDms"
                FrmConsultTransacDms.Show()
                FrmConsultTransacDms.Activate()
                FrmConsultTransacDms.Main(nodeName, permiso)
                Me.WindowState = 1
            Case "nodAuditCambios"
                FrmAuditCambios.Show()
                FrmAuditCambios.Activate()
                Me.WindowState = 1
            Case "nodMaeCoordVend"
                listColumnas.Add("usuario")
                listColumnas.Add("vendedor")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("J_spic_coord_vend", "Vendedores asociados a un coordinador", "CORSAN", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nodMaeIpCorreos"
                listColumnas.Add("descripcion")
                listColumnas.Add("ip")
                listColumnas.Add("puerto")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("J_spic_servidores_correo", "Direcciones entrada y salida (Correos)", "CORSAN", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nodTranManDmsSpic"
                FrmTransacManualDmsSpic.Show()
                FrmTransacManualDmsSpic.Activate()
                Me.WindowState = 1
            Case "nodGenFichasYcertf"
                FrmGenFichasYcertf.Show()
                FrmGenFichasYcertf.Activate()
                Me.WindowState = 1
            Case "nod_consultar_certificados"
                Frm_historico_certificados.Show()
                Frm_historico_certificados.Main(objUsuario)
                Frm_historico_certificados.Activate()
                Me.WindowState = 1
            Case "nod_info_empleados"
                Frm_info_empleados.Show()
                Frm_info_empleados.MAIN("nod_info_empleados", objUsuario)
                Frm_info_empleados.Activate()
                Me.WindowState = 1
            Case "nod_cambiar_centro"
                frm_cambiar_centro.Show()
                frm_cambiar_centro.main(objUsuario)
                frm_cambiar_centro.Activate()
                Me.WindowState = 1
            Case "nod_maestro_fichas"
                Dim frm As New frm_maestro_fichas2
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_audit_ped"
                FrmAuditPedidos.Show()
                FrmAuditPedidos.Activate()
                Me.WindowState = 1
            Case "nodOpTransaccion"
                FrmMaestroTransHandHeld.Show()
                FrmMaestroTransHandHeld.Activate()
                Me.WindowState = 1
            Case "nod_GestTransaSinStock"
                FrmGestTransaSinStock.Show()
                FrmGestTransaSinStock.MAIN(objUsuario, permiso)
                FrmGestTransaSinStock.Activate()
                Me.WindowState = 1
            Case "nod_tras_bod_hand"
                Frm_traslados_bodega.Show()
                Frm_traslados_bodega.Main(nodeName)
                Frm_traslados_bodega.Activate()
                Me.WindowState = 1
            Case "nod_MaestroTransHandHeld"
                FrmMaestroTransHandHeld.Show()
                FrmMaestroTransHandHeld.Activate()
                Me.WindowState = 1
            Case "nod_evaluacion_prov"
                Frm_evaluacion_proveedores.Show()
                Frm_evaluacion_proveedores.Activate()
                Me.WindowState = 1
            Case "nod_constar_eval_prov"
                Frm_consultar_eval.Show()
                Frm_consultar_eval.Activate()
                Me.WindowState = 1
            Case "nod_maestro_prov_cat"
                Frm_proveedor_categoria.Show()
                Frm_proveedor_categoria.Activate()
                Me.WindowState = 1
            Case "nod_graficar_evaluaciones"
                Dim frm As New Frm_graficar_evaluaciones
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nodo_consumir_tiquetes"
                Dim frm As New FrmConsumoTiquete
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_admin_sol_compra"
                Dim id_ventana As String
                id_ventana = "S"
                Dim frm As New Frm_consult_ordenes_compra
                frm.Show()
                frm.Main(objUsuario, id_ventana)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_admin_ord_compra"
                Dim id_ventana As String
                id_ventana = "O"
                Dim frm As New Frm_consult_ordenes_compra
                frm.Show()
                frm.Main(objUsuario, id_ventana)
                frm.Activate()
                Me.WindowState = 1
                'menu de estupefacientes agregado por david
            Case "nod_infor_estupe"
                Dim frm As New frm_estupefacientes
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_generar_sol_compra"
                Dim id_ventana As String
                id_ventana = "S"
                Dim frm As New Frm_orden_compra
                frm.Main(objUsuario, 0, "nod_generar_sol_compra", id_ventana)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_generar_ord_compra"
                Dim id_ventana As String
                id_ventana = "O"
                Dim frm As New Frm_orden_compra
                frm.Main(objUsuario, 0, "nod_generar_ord_compra", id_ventana)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_salida_materia_prima_G"
                Dim frm As New Frm_salida_materia_prima_G
                frm.Show()
                frm.Main(objUsuario, 0, "nod_salida_materia_prima_G")
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consulta_materia_prima_G"
                Dim frm As New Frm_consultar_salida_materia_prima
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Orden_produccion_Galvanizado"
                Dim frm As New FrmOrdenProdGalv
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Informe_produccion_Galvanizado"
                Dim frm As New Frm_informe_galvanizado
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Informe_estado_rollos"
                Dim frm As New Frm_Estado_de_rollo
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Informe_bobinas_paradas"
                Dim frm As New Frm_bobinas_paradas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Informe_tiempo_trabajo"
                Dim frm As New Frm_tiempo_trabajo_Galv
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Informe_resumen_galvanizado"
                Dim frm As New Frm_resumenes
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_per_activo"
                Dim frm As New Frm_personal_activo_corsan
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_orden_prod_puas"
                Dim frm As New frm_control_orden_puas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_crear_orden_puas"
                Dim frm As New frm_orden_prod_puas
                frm.main(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_infor_paros_puas"
                Dim frm As New Frm_informe_paros_puas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_gestionar_tendencias"
                Dim frm As New Frm_gestionar_tendencias
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_mae_cargos"
                listColumnas.Add("descripcion")
                FrmMaeGestMod.Show()
                FrmMaeGestMod.main("C_cargos_corsan", "Maestro cargos corsan", "PRODUCCION", listColumnas)
                FrmMaeGestMod.Activate()
                Me.WindowState = 1
            Case "nod_consultar_proc"
                Dim frm As New Frm_consultar_proc
                frm.Show()
                frm.Main(objUsuario, "nod_gest_proc")
                frm.Activate()
                Me.WindowState = 1
            Case "nod_gest_proc"
                Dim frm As New Frm_gestionar_procedimientos
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
                frm.Main(objUsuario, 0, "nod_gest_proc")
            Case "nod_IngTornilleria"
                Dim frm As New FrmIngTornilleria
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_vtas_zona"
                Dim frm As New Frm_vtas_zona
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_AnalisisVentas"
                Dim frm As New FrmAnalisisVentas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_pend_zona"
                Dim frm As New Frm_pend_zona
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_reglas_comisiones"
                Dim frm As New Frm_reglas_comisiones
                frm.Show()
                frm.main(objUsuario.usuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_liquidacion_com"
                Dim frm As New Frm_liquidacion
                frm.Show()
                frm.Main("nod_liquidacion_com", objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_seg_pendientes"
                Dim frm As New Frm_seg_pendientes
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_vtas_cliente_linea_mes"
                Dim frm As New Frm_vtas_cliente_linea_mes
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_fecha_entrega"
                Dim frm As New Frm_fecha_entrega
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_informe_ausentismos"
                Dim frm As New Frm_liquidar_reloj
                frm.Show()
                frm.MAIN("nod_informe_ausentismos", objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_trazabilidad_transacciones"
                Dim frm As New Frm_trazabilidad_transacciones
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Trazabilidad_clientes_atendidos"
                Dim frm As New Frm_Trazabilidad_clientes_atendidos
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_evaluacione_desempeno"
                Dim frm As New Frm_Evaluacion_corsan
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consultar_eval_desempeno"
                Dim frm As New Frm_consultar_eval_desempeno
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_permisos_evaluaciones"
                Dim frm As New Frm_permisos_evaluaciones
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_permisos_evaluaciones"
                Dim frm As New Frm_permisos_evaluaciones
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_cerrar_for"
                Dim frm As New Frm_cierre_forzado
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_super_modulo_consult_vtas"
                Dim frm As New Frm_super_modulo_consult_vtas
                frm.Main(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_dias_vacaciones"
                Dim frm As New Frm_dias_vacaciones
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_encu_clientes"
                Dim frm As New Frm_encuesta_clientes
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_encuesta_cliente"
                Dim frm As New Frm_consultar_encuesta_cli
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_seguimiento_ppto_mes"
                Dim frm As New Frm_seguimiento_ppto_mes
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_formato_stiker"
                Dim frm As New Frm_formato_stiker
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_maximos_minimos"
                Dim frm As New Frm_maximos_minimos
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_gest_desperdicios"
                Dim frm As New Frm_desperdicios
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nodIngVtasMovil"
                FrmIngVtasMovil.Show()
                FrmIngVtasMovil.Activate()
                FrmIngVtasMovil.Main(nodeName, objUsuario)
                Me.WindowState = 1
            Case "nod_super_modulo_consult_pendientes"
                Dim frm As New Frm_super_modulo_consult_pendientes
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_ppto_produccion"
                Dim frm As New Frm_ppto_produccion
                frm.Show()
                frm.MAIN(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_cod_vel"
                Dim frm As New frm_codigo_vel_tref
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "Nodo_pendientes"
                Dim frm As New MainForm
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_seg_ppto_produccion"
                Dim frm As New Frm_seg_ppto_produccion
                frm.Show()
                frm.MAIN(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_seg_grupos"
                Dim frm As New FrmSeguimientoGrupos
                frm.Show()
                frm.main("nod_seg_grupos", objUsuario.permiso, objUsuario.Vendedor)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_entradas_salidas_ref"
                Dim frm As New Frm_entradas_salidas_ref
                frm.Show()
                frm.MAIN(objUsuario.permiso)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_tiempos_laborados"
                Dim frm As New Frm_reloj
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_salida_almacen"
                Dim frm As New Frm_salida_almacen
                frm.Show()
                frm.Main(objUsuario, 0, "nod_salida_almacen")
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_salida_almacen"
                Dim frm As New Frm_consult_salida_almacen
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_entradas_salidas_diarias"
                Dim frm As New Frm_entradas_salidas_diarias
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_empaque_puntilleria"
                Dim frm As New Frm_empaque_puntilleria
                frm.Show()
                frm.Main("nod_empaque_puntilleria", objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_rotacion_personal"
                Dim frm As New Frm_rotacion_personal
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_informe_temporales"
                Dim frm As New Frm_informe_temporales
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_contrat_dias"
                Dim frm As New frm_registro_proveedores
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_liqui_reloj"
                Dim frm As New Frm_liqui_reloj
                frm.Show()
                frm.MAIN("nod_liqui_reloj", objUsuario, False)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_galv_f2"
                Dim frm As New Frm_ing_galv
                frm.Show()
                frm.Main("nod_galv_f2", objUsuario.permiso)
                Me.WindowState = 1
            Case "nod_programacion_turnos"
                Dim frm As New Frm_programacion_turnos
                frm.Show()
                frm.MAIN("nod_galv_f2", objUsuario)
                Me.WindowState = 1
            Case "nod_MaePeriodos"
                Dim frm As New FrmInvMetrologia
                frm.Show()
                Me.WindowState = 1
            Case "nod_inv_metrologia"
                Dim frm As New Frm_inv_metrologia
                frm.Show()
                Me.WindowState = 1
            Case "nod_super_modulo_consult_terceros"
                Dim frm As New Frm_super_modulo_consult_terceros
                frm.Main(objUsuario)
                frm.Show()
                Me.WindowState = 1
            Case "nod_informe_marcaciones"
                Dim frm As New Frm_informe_marcaciones
                frm.MAIN("nod_informe_marcaciones", objUsuario)
                frm.Show()
                Me.WindowState = 1
            Case "nod_salida_alambron"
                Dim frm As New Frm_salida_alambron
                frm.Main(objUsuario, 0, "nod_salida_alambron")
                frm.Show()
                Me.WindowState = 1
            Case "nod_fecha_venc_cartera"
                Dim frm As New frm_cartera_por_vencer
                frm.Show()
                Me.WindowState = 1
            Case "nod_mat_consumida"
                Dim frm As New frm_consumos_alambron
                frm.Show()
                Me.WindowState = 1
            Case "nod_mat_punt"
                Dim frm As New Frm_consumos_puntilleria
                frm.Show()
                Me.WindowState = 1
            Case "nod_mat_galv"
                Dim frm As New Frm_consumo_galva
                frm.Show()
                Me.WindowState = 1
            Case "nod_consultar_salida_alambron"
                Dim frm As New Frm_consult_salida_alambron
                frm.Main(objUsuario)
                frm.Show()
                Me.WindowState = 1
            Case "nod_tiquetes_alambron"
                Dim frm As New Frm_tiquetes_alambron
                frm.Show()
                Me.WindowState = 1
            Case "nod_gen_tiquet_tref"
                Dim frm As New frm_generar_tiquete
                frm.main(0, 0, objUsuario.nombre, objUsuario.nit)
                frm.Show()
                Me.WindowState = 1
            Case "nod_infor_cant_entre"
                Dim frm As New Frm_infor_cant_entre
                frm.Show()
                Me.WindowState = 1
            Case "nod_auditoria_tiquete"
                Dim frm As New Frm_auditoria_tiquetes
                frm.Show()
                frm.Main(0, objUsuario)
                Me.WindowState = 1
            Case "nod_planillas_cargue"
                Dim frm As New Frm_planillas_cargue
                frm.Show()
                frm.MAIN(0, objUsuario)
                Me.WindowState = 1
            Case "NodPrincipalHandHeld"
                Dim frm As New Frm_ppal_alambron
                frm.Show()
                Me.WindowState = 1
            Case "nod_super_modulo_consult_cartera"
                Dim frm As New Frm_super_modulo_consult_cartera
                frm.Main(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_super_modulo_consult_recaudos"
                Dim frm As New Frm_super_modulo_consult_recaudos
                frm.Main(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "Nod_consult_compromisos"
                Dim frm As New Frm_consult_compromisos
                frm.MAIN(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_informe_nov_pendientes"
                Dim frm As New Frm_informe_nov_pendientes
                frm.MAIN(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_ppto_gastos"
                Dim frm As New Frm_ppto_gastos()
                frm.MAIN(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_seg_ppto_gastos"
                Dim frm As New Frm_seg_ppto_gastos()
                frm.MAIN(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_generar_tiquetes_terminado"
                Dim frm As New Frm_generar_tiquetes_terminado
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_cerrar_por_ruta"
                groupRutaCerrar.Visible = True
            Case "nod_paros_galv"
                Dim frm As New Frm_informe_paros_galv
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_gestionar_no_conforme"
            Case "nod_super_modulo_consult_gastos_vendedor"
                Dim frm As New Frm_super_modulo_consult_gastos_vendedor()
                frm.Main(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_ppto_articulos"
                Dim frm As New Frm_ppto_articulos
                frm.MAIN(objUsuario)
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nodReg_personal_maquila"
                Dim frm As New FrmReg_personal_maquila
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_generar_tiquetes_terminado"
                Dim frm As New Frm_generar_tiquetes_terminado
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consultar_separe"
                Dim frm As New Frm_consultar_separe
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_inv_fisicos"
                Dim frm As New Frm_consultar_inventario_fisico
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_mp_puntilleria"
                Dim frm As New Frm_solicitud_mp_puntilleria
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_solicitud_mp_punt"
                Dim frm As New Frm_consult_solicitud_mp_punt
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_orden_prod_punt"
                Dim frm As New Frm_orden_prod_punt
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_cambio_cliente_vendedor"
                Dim frm As New Frm_cambio_cliente_vendedor
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_auditoria_puntilleria"
                Dim frm As New Frm_auditoria_puntilleria
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_mp_recocido"
                Dim frm As New Form_solicitud_mp_recocido
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_solicitud_mp_recocido"
                Dim frm As New Frm_consultar_solicitud_mp_recocido
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_orden_produccion_rec"
                Dim frm As New frm_ordne_prdo_rec2
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_auditoria_recocido"
                Dim frm As New frm_auditoria_recocido
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_proyectos"
                Dim frm As New Frm_proyectos
                frm.Show()
                frm.MAIN(objUsuario, 0, Now, Now)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consultar_proyecto"
                Dim frm As New Frm_consultar_proyectos
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_recocido_calidad"
                Dim frm As New frm_recocido_calidad
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_auditoria_inventario"
                Dim frm As New frm_control_inv_aud
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_auditoria_alambres"
                Dim frm As New frm_seguimiento_alambre
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_mp_puas"
                Dim frm As New frm_solicitud_mp_puas
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consult_solicitud_mp_puas"
                Dim frm As New Frm_consultar_solicitud_mp_puas
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_scal"
                Dim frm As New frm_solicitud_trefscal
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consulta_scal"
                Dim frm As New Frm_consultar_solicitud_mp_scal
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_scae"
                Dim frm As New frm_solicitud_trefscae
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consulta_scae"
                Dim frm As New Frm_consultar_solicitud_mp_scae
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_sar"
                Dim frm As New frm_solicitud_trefsar
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consulta_sar"
                Dim frm As New Frm_consultar_solicitud_mp_sar
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_solicitud_sav"
                Dim frm As New frm_solicitud_trefsav
                frm.Show()
                frm.Main(objUsuario, 0)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_consulta_sav"
                Dim frm As New Frm_consultar_solicitud_mp_sav
                frm.Show()
                frm.Main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_informe_pers_activo"
                Dim frm As New frm_vista_personal_activo
                frm.Show()
                frm.Activate()
                Me.WindowState = 1

            Case "nod_gest_doc"
                Dim frm As New frm_documentacion_pendiente
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_manual"
                Dim frm As New frm_manuales_spic
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_tiquete_nc"
                Dim frm As New frm_no_conforme_rec
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_tiquete_nc"
                Dim frm As New frm_no_conforme_rec
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_prod_puas"
                Dim frm As New Frm_informe_prod_puas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_limite_consumos"
                Dim frm As New Frm_limite_consumo_alambron
                frm.Show()
                frm.main(objUsuario.nombre)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_ppal_despachos"
                Dim frm As New frm_ppal_despachos
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_buzon_sugerencias_det"
                Dim frm As New frm_consulta_buzon
                frm.Show()
                frm.main(objUsuario)
                frm.Activate()
                Me.WindowState = 1
            Case "nod_buzon_cons_premios"
                Dim frm As New frm_buzon_info_premios
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_Ajus_Conts"
                Dim frm As New cboMes
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_sal_alam"
                Dim frm As New frm_Saldo_Alambron
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_act_alam"
                Dim frm As New frm_Saldo_Cambiar
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_tref_form3"
                Dim frm As New FrmConsTreForma3
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nodo_probar"
                '
                Dim frm As New FrmLogin
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "nod_reporte_inspeccion_calidad"
                '
                Dim frm As New FrmReporteInspeccionCalidad
                frm.Show()
                frm.Activate()
                Me.WindowState = 1

            Case "Nod_estado_maquinas"
                Dim frm As New DassboardMaquinas
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "NodoInhabilitarAlambron"
                Dim frm As New Frmbloquear_tiquetes_alambron
                frm.Show()
                frm.Activate()
                Me.WindowState = 1
            Case "Nododetalleparos"
                Dim frm As New Frm_detalle_paros
                frm.Show()
                frm.Activate()
                Me.WindowState = 1


        End Select
        TreeView1.SelectedNode = TreeView1.Nodes("raiz_ofic")
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLogin.Show()
        Me.Close()
    End Sub


    Private Sub FrmPrincipal_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If validar_nomina = False Then
            If Not cerrar_desde_notificacion Then
                Dim resp As Integer = MessageBox.Show("Esta seguro que desea salir de la aplicación? ", "Salir?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If (resp = 6) Then
                    cerrar_desde_notificacion = True
                    Application.Exit()
                Else
                    e.Cancel = True
                End If
            Else
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub timNotificarCerrarAplicacion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timNotificarCerrarAplicacion.Tick
        If My.Computer.Network.IsAvailable Then
            Dim ruta_actual As String = Environment.CurrentDirectory
            Dim sql As String = "SELECT estado FROM J_spic_cerrar_aplicacion_ruta WHERE ruta ='" & ruta_actual & "'"
            Dim resp As String = objOpSimplesLn.consultarVal(sql)
            Dim ruta_cerrar As String = ""
            If resp = "S" Then
                timCerrarApp.Enabled = True
                MessageBox.Show("La aplicación se cerrara en forma automatica en 1 minuto por motivo de actualización, podrá abrir la aplicación en el trascurso de los proximos 10 minutos,de antemano le ofrecemos disculpas por las molestias ocacionadas,estamos trabajando en la mejora de los procesos.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub timCerrarApp_Tick(sender As Object, e As EventArgs) Handles timCerrarApp.Tick
        cerrar_desde_notificacion = True
        Application.Exit()
    End Sub


    Private Sub btnEnviar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEnviar.Click
        gestionar_notificacion(txt_ruta.Text, True)
    End Sub
    Private Sub btn_cancelar_noti_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar_noti.Click
        gestionar_notificacion(txt_ruta.Text, False)
    End Sub
    Private Sub btnCerrarGroup_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCerrarGroup.Click
        groupRutaCerrar.Visible = False
    End Sub
    Private Sub gestionar_notificacion(ByVal ruta As String, ByVal crear As Boolean)
        If ruta <> "" Then
            Dim sql As String = ""
            Dim tipo As String = ""
            If crear Then
                tipo = "Creo"
                sql = "INSERT INTO J_spic_cerrar_aplicacion_ruta (ruta,estado) VALUES('" & ruta & "','S')"
            Else
                tipo = "Cancelo"
                sql = "DELETE FROM J_spic_cerrar_aplicacion_ruta"
            End If
            If obj_Op_simpesLn.ejecutar(sql, "CORSAN") > 0 Then
                If crear Then
                    Dim tiempo As Integer = timNotificarCerrarAplicacion.Interval
                    tiempo = tiempo / 60000
                    MessageBox.Show("La notificación se " & tipo & " en forma exitosa,la aplicación de cerrara en aproximadamente " & tiempo & " minutos", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("La notificación se " & tipo & " en forma exitosa", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Error al realizar la operación ", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese ruta para notificar", "Ingrese ruta!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Private Sub nombres_db()
        Dim db_corsan As String = objOpSimplesLn.get_nom_db("CORSAN")
        Dim db_produccion As String = objOpSimplesLn.get_nom_db("PRODUCCION")
        Dim db_control As String = objOpSimplesLn.get_nom_db("CONTROL")
        lbl_db_corsan.Text = db_corsan.ToUpper
        lbl_db_produccion.Text = db_produccion.ToUpper
        lbl_db_control.Text = db_control.ToUpper
    End Sub

    Private Sub autocierre_Tick(sender As Object, e As EventArgs) Handles autocierre.Tick
        time_autocierre = time_autocierre - 1

        If time_autocierre = 0 Then
            frmPrincipal_autocierre.main()
            frmPrincipal_autocierre.ShowDialog()
        End If
    End Sub

    Public Sub reiniciar_timer(ByVal numero As Integer)
        time_autocierre = numero
    End Sub



    Public Sub fin()
        End
    End Sub
    Private Sub btn_buzon_Click(sender As Object, e As EventArgs) Handles btn_buzon.Click
        frm_buzon.ShowDialog()
    End Sub
    Private Sub cierre_forzado_Tick(sender As Object, e As EventArgs) Handles cierre_forzado.Tick
        Dim sql As String
        sql = "select * from J_spic_cerrar_aplicacion"
        If obj_Ing_prodLn.consultar_valor(sql, "CORSAN") <> "0" Then
            Application.ExitThread()
        End If
    End Sub
    Private Sub tsAcercaDe_Click(sender As Object, e As EventArgs)
        acerca_de.Show()
        Me.WindowState = 1
    End Sub
    Private Sub tim_cumpleaños_Tick(sender As Object, e As EventArgs)
        FrmCorreosCumpleanos.Show()
    End Sub



    Private Sub timer_ping_bd_Tick(sender As Object, e As EventArgs) Handles timer_ping_bd.Tick
        If My.Computer.Network.IsAvailable() Then
            If val_timer = "1" Then
                cierre_forzado.Enabled = True
                timNotificarCerrarAplicacion.Enabled = True
                timCerrarApp.Enabled = True
                autocierre.Enabled = True
                val_timer = ""
                frm.Close()
            End If
            If My.Computer.Network.Ping("10.10.10.246", 5000) Then
                If val_timer = "1" Then
                    cierre_forzado.Enabled = True
                    timNotificarCerrarAplicacion.Enabled = True
                    timCerrarApp.Enabled = True
                    autocierre.Enabled = True
                    val_timer = ""
                    frm.Close()
                End If
            Else
                If val_timer <> "1" Then
                    If validar_formu() Then
                        val_timer = "1"
                        cierre_forzado.Enabled = False
                        timNotificarCerrarAplicacion.Enabled = False
                        timCerrarApp.Enabled = False
                        autocierre.Enabled = False
                        frm.ShowDialog()
                    End If
                End If
            End If
        Else
            If val_timer <> "1" Then
                If validar_formu() Then
                    val_timer = "1"
                    cierre_forzado.Enabled = False
                    timNotificarCerrarAplicacion.Enabled = False
                    timCerrarApp.Enabled = False
                    autocierre.Enabled = False
                    frm.ShowDialog()
                End If
            End If
        End If
    End Sub
    Private Function validar_formu()
        Dim resp As Boolean = True
        For Each f As Form In Application.OpenForms
            If f.Name = frm.Name Then
                resp = False
            End If
        Next
        Return resp
    End Function



    Private Sub moveImageBox(ByVal sender As Object)
        Dim b As Guna2Button = CType(sender, Guna2Button)
        imgSlideH.Location = New Point(b.Location.X + 24, b.Location.Y - 25)
        imgSlideH.SendToBack()

    End Sub


    Private Sub guna2Button1_Click(sender As Object, e As EventArgs) Handles guna2Button1.Click
        TabControl1.SelectedIndex = 0
        imgSlideH.Visible = True
        imgSlide1.Visible = False
        imgSlide2.Visible = False
        imgSlide3.Visible = False
        TabControl1.Visible = True
        tab_men_ppal.Select()
        txtFilterToolIDs.Select()
    End Sub

    Private Sub guna2Button2_Click(sender As Object, e As EventArgs) Handles guna2Button2.Click
        TabControl1.SelectedIndex = 1
        If (Primer_ingreso = True) Then
            ''carga la vista de manera inicial


            checkvariables.Visible = False
            lblvariables.Visible = False
            ''cargar meses al chart


            ''calcular ppto 

            imgSlide1.Visible = True
            imgSlide1.SendToBack()
            imgSlideH.Visible = False
            imgSlide2.Visible = False
            imgSlide3.Visible = False

            'ocultar menu desplegable
            TabControl1.Visible = True
            panelPPTO.Visible = True
            tab_men_prod.Select()



            '''cargar el ppto 
            '''
            cargarppto()



            Primer_ingreso = False

        Else
            imgSlide1.Visible = True
            imgSlide1.SendToBack()
            imgSlideH.Visible = False
            imgSlide2.Visible = False
            imgSlide3.Visible = False


        End If


    End Sub



    Sub cargarppto()

        If (cbo_ano_prod.Text = "Seleccione" Or cb_mes_prod.Text = "Seleccione") Then
            año = Year(Now).ToString
            mes = Month(Now).ToString
        Else
            año = cbo_ano_prod.Text
            mes = cb_mes_prod.SelectedIndex
        End If


        Dim dias_trabajados As String
        Dim dias_trabajados_otros As String
        Dim dias_habiles_otros As String
        Dim dias_adicionales_otros As String

        Dim dt_dias_habiles_general As DataTable = obj_ppto_produccionLn.cargar_dias_habiles_general(mes, año)
        For i = 0 To dt_dias_habiles_general.Rows.Count - 1
            dias_trabajados = dt_dias_habiles_general.Rows(i).Item("dias_trabajados").ToString
            dias_trabajados_otros = dt_dias_habiles_general.Rows(i).Item("dias_trabajados_otros").ToString
            dias_habiles_otros = dt_dias_habiles_general.Rows(i).Item("dias_habiles_otros").ToString
            dias_adicionales_otros = dt_dias_habiles_general.Rows(i).Item("dias_adic").ToString
        Next


        dt_consulta = obj_ppto_produccionLn.cargar_seguimiento_gral_area(dias_habiles_otros, dias_adicionales_otros, dias_trabajados_otros, mes, año)

        dtd.DataSource = dt_consulta
        bunitable.DataSource = dt_consulta


        ''formato de numeros
        bunitable.Columns.Item("dias_trab").DefaultCellStyle.Format = "N1"
        bunitable.Columns.Item("ppto_por_dia").DefaultCellStyle.Format = "N0"
        bunitable.Columns.Item("llevamos").DefaultCellStyle.Format = "N0"
        bunitable.Columns.Item("llevamos_cant").DefaultCellStyle.Format = "N0"
        bunitable.Columns.Item("prom_dia").DefaultCellStyle.Format = "N0"
        bunitable.Columns.Item("deb_llevar").DefaultCellStyle.Format = "N1"
        bunitable.Columns.Item("cump_hoy").DefaultCellStyle.Format = "N1"
        bunitable.Columns.Item("pxn_a_recup").DefaultCellStyle.Format = "N1"
        bunitable.Columns.Item("cump").DefaultCellStyle.Format = "N1"

        bunitable.Columns.Item("dias_adicionales").Visible = False
        bunitable.Columns.Item("dias_trab").Visible = False
        bunitable.Columns.Item("dias_habiles").Visible = False
        bunitable.Columns.Item("pxn_a_recup").Visible = False
        bunitable.Columns.Item("prom_dia").Visible = False
        bunitable.Columns.Item("cump_hoy").Visible = False
        bunitable.Columns.Item("cump").Visible = False



        dtd.Columns.Item("dias_trab").DefaultCellStyle.Format = "N1"
        dtd.Columns.Item("ppto_por_dia").DefaultCellStyle.Format = "N0"
        dtd.Columns.Item("llevamos").DefaultCellStyle.Format = "N0"
        dtd.Columns.Item("llevamos_cant").DefaultCellStyle.Format = "N0"
        dtd.Columns.Item("prom_dia").DefaultCellStyle.Format = "N0"
        dtd.Columns.Item("deb_llevar").DefaultCellStyle.Format = "N1"
        dtd.Columns.Item("cump_hoy").DefaultCellStyle.Format = "N1"
        dtd.Columns.Item("pxn_a_recup").DefaultCellStyle.Format = "N1"
        dtd.Columns.Item("cump").DefaultCellStyle.Format = "N1"

        dtd.Columns.Item("dias_adicionales").Visible = False
        dtd.Columns.Item("dias_trab").Visible = False
        dtd.Columns.Item("dias_habiles").Visible = False
        dtd.Columns.Item("pxn_a_recup").Visible = False
        dtd.Columns.Item("prom_dia").Visible = False
        dtd.Columns.Item("cump_hoy").Visible = False
        dtd.Columns.Item("cump").Visible = False


        consumo_alambron(mes, año, dias_trabajados, dias_habiles)


    End Sub

    Private Sub consumo_alambron(ByVal mes As Integer, ByVal ano As Integer, ByVal dias_trabajados As Double, ByVal dias_habiles As Double)
        Dim dt As New DataTable
        Dim ppto_por_dia As Double = 0
        Dim valor As String = ""
        Dim sum_brillantes_especiales As Double = 0
        Dim sum_smpp As Double = 0
        Dim sql_ppto_consumo_alambron As String = "SELECT SUM(kilos) FROM J_ppto_prod_consumo_alambron WHERE mes = " & mes & " AND ano = " & ano
        Dim ppto_consumo_alambron As String = obj_op_simplesLn.consultValorTodo(sql_ppto_consumo_alambron, "PRODUCCION")
        If ppto_consumo_alambron = "" Then
            ppto_consumo_alambron = 0
        End If
        Dim sql_ppto_reproceso As String = "SELECT SUM(kilos) FROM J_ppto_prod_reproceso WHERE mes = " & mes & " AND ano = " & ano
        Dim ppto_reproceso As String = obj_op_simplesLn.consultValorTodo(sql_ppto_reproceso, "PRODUCCION")
        If ppto_reproceso = "" Then
            ppto_reproceso = 0
        End If
        Dim sql_consumo As String = "SELECT SUM(lin.cantidad)As cantidad " &
               "FROM documentos_lin lin , documentos doc " &
                      "		WHERE doc.numero = lin.numero  AND YEAR(lin.fec)= " & ano & " AND MONTH(lin.fec )= " & mes & " AND lin.codigo like '11%' AND lin.bodega = 2 AND doc.tipo IN ('SMPP') AND lin.tipo = doc.tipo AND doc.bodega = lin.bodega  "
        valor = obj_op_simplesLn.consultarVal(sql_consumo)
        If valor <> "" Then
            sum_smpp = valor
        Else
            sum_smpp = 0
        End If
        valor = 0
        Dim sql_brillantes_especiales As String = "SELECT SUM(lin.cantidad)As cantidad " &
              "FROM documentos_lin lin , documentos doc " &
                     "WHERE doc.numero = lin.numero AND lin.tipo = doc.tipo AND doc.bodega = lin.bodega AND lin.tipo IN ('EPPP','EPPT') AND (lin.codigo like '22b%' or lin.codigo like '33b%' or lin.codigo like '22x%' or lin.codigo like '33x%' )  AND YEAR(lin.fec)= " & ano & " AND MONTH(lin.fec )= " & mes
        valor = obj_op_simplesLn.consultarVal(sql_brillantes_especiales)
        If valor <> "" Then
            sum_brillantes_especiales = valor
        Else
            sum_brillantes_especiales = 0
        End If

        dt.Columns.Add("descripcion")
        dt.Columns.Add("Presupuesto", GetType(Double))
        dt.Columns.Add("produccion", GetType(Double))
        dt.Columns.Add("ppto_a_hoy", GetType(Double))
        dt.Columns.Add("porc_cump", GetType(Double))
        dt.Columns.Add("porc_hoy", GetType(Double))

        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1).Item("descripcion") = "CONSUMO DE ALAMBRON"
        dt.Rows(dt.Rows.Count - 1).Item("Presupuesto") = ppto_consumo_alambron
        dt.Rows(dt.Rows.Count - 1).Item("produccion") = sum_smpp
        ppto_por_dia = ppto_consumo_alambron / dias_habiles
        dt.Rows(dt.Rows.Count - 1).Item("ppto_a_hoy") = ppto_por_dia * dias_trabajados

        dt.Rows.Add()
        dt.Rows(dt.Rows.Count - 1).Item("descripcion") = "PXN CON REPROCESO"
        dt.Rows(dt.Rows.Count - 1).Item("Presupuesto") = ppto_reproceso
        dt.Rows(dt.Rows.Count - 1).Item("produccion") = sum_brillantes_especiales
        ppto_por_dia = ppto_reproceso / dias_habiles
        dt.Rows(dt.Rows.Count - 1).Item("ppto_a_hoy") = ppto_por_dia * dias_trabajados

        calcular_cump_consumo(dt)
        dtg_consumo_alambron.DataSource = dt

    End Sub

    Private Sub calcular_cump_consumo(ByRef dt As DataTable)
        Dim sum_ppto As Double = 0
        Dim sum_ppto_dia As Double = 0
        Dim sum_entradas As Double = 0
        For i = 0 To dt.Rows.Count - 1
            If (dt.Rows(i).Item("Presupuesto") = 0 Or dt.Rows(i).Item("produccion") = 0) Then
                dt.Rows(i).Item("porc_cump") = 0
            Else
                dt.Rows(i).Item("porc_cump") = (dt.Rows(i).Item("produccion") / dt.Rows(i).Item("Presupuesto")) * 100
                sum_ppto += dt.Rows(i).Item("Presupuesto")
                sum_entradas += dt.Rows(i).Item("produccion")
            End If
            If (dt.Rows(i).Item("ppto_a_hoy") = 0 Or dt.Rows(i).Item("produccion") = 0) Then
                dt.Rows(i).Item("porc_cump") = 0
            Else
                dt.Rows(i).Item("porc_hoy") = (dt.Rows(i).Item("produccion") / dt.Rows(i).Item("ppto_a_hoy")) * 100
                sum_ppto_dia += dt.Rows(i).Item("ppto_a_hoy")
            End If
        Next
    End Sub

    Public Function cargar_seguimiento_gral_area(ByVal dias_habiles_otros As Double, ByVal dias_adic_otros As Double, ByVal dias_trabajados_otros As Double, ByVal mes As Integer, ByVal ano As Integer) As DataTable

        Dim dt As New DataTable
        Dim sql As String = "SELECT c.centro,c.descripcion,p.kilos As ppto_kilos,p.cantidad as ppto_cantidad,dias_habiles,dias_adicionales " &
                                            "FROM J_ppto_prod_area p , CORSAN.dbo.centros  c " &
                                                "WHERE p.centro = c.centro AND mes =" & mes & " AND ano = " & ano & " " &
                                                   "ORDER BY p.centro "

        dt = obj_op_simplesLn.listar_datatable(sql, "PRODUCCION")
        dt.Columns.Add("dias_trab", GetType(Double))
        dt.Columns.Add("ppto_por_dia", GetType(Double))
        dt.Columns.Add("llevamos", GetType(Double))
        dt.Columns.Add("llevamos_cant", GetType(Double))
        dt.Columns.Add("prom_dia", GetType(Double))
        dt.Columns.Add("deb_llevar", GetType(Double))
        dt.Columns.Add("cump_hoy", GetType(Double))
        dt.Columns.Add("pxn_a_recup", GetType(Double))
        dt.Columns.Add("cump", GetType(Double))




        If (dt.Rows.Count > 0) Then
            If Not IsDBNull(dt.Rows(0).Item("dias_habiles")) Then
                dias_habiles = dt.Rows(0).Item("dias_habiles")
            End If
            If Not IsDBNull(dt.Rows(0).Item("dias_adicionales")) Then
                dias_adic = dt.Rows(0).Item("dias_adicionales")
            End If
        End If
        dias_habiles += dias_adic
        If (mes <> Now.Month) Then
            dias_trbajados = dias_habiles
        Else
            dias_trbajados = obj_op_simplesLn.calcDiasHabilesProduccion(ano & "-" & mes & "-01", ano & "-" & mes & "-" & Now.Day)
            dias_trbajados -= obj_op_simplesLn.cant_festivos2(Now.Day, mes, ano)

            dias_trbajados += dias_adic
        End If
        If dias_trbajados > 1 And mes = Now.Month Then
            dias_trbajados -= 1
        End If

        Dim where_sql_inv As String = ""
        For i = 0 To dt.Rows.Count - 1
            Select Case dt.Rows(i).Item("centro")
                Case 2100 'trefilacion
                    where_sql_inv = " AND (codigo like '33X%' or codigo like '22X%' or codigo like '33B%' or codigo like '22B%') AND tipo IN ('EPPT','EPPP') "
                Case 2200 ' recocido
                    where_sql_inv = " AND (codigo like '22R%' or codigo like '33R%') AND tipo IN ('EPPT','EPPP') "
                Case 2300 ' puntilleria
                    where_sql_inv = " AND (codigo like '2CC%' or codigo like '2CA%' or codigo like '2CK%' or codigo like '2CM%') AND descripcion NOT like '%electrosoldado%' AND tipo IN ('EPPP') "
                Case 2400 'emp puntilleria
                    where_sql_inv = " AND (codigo like '3CC%' or codigo like '3CA%' or codigo like '3CK%' or codigo like '3CM%' or codigo like '3PT%') AND modelo in (01,02) AND descripcion NOT like '%electrosoldado%' AND tipo IN ('EDEP') "
                Case 2500 ' tornilleria
                    where_sql_inv = " AND (codigo like '3WW%' or codigo like '2T%') AND tipo IN ('ETV3','EAI2') AND descripcion NOT LIKE '%DRYWALL%' AND codigo not like '%GS' "
                Case 2600 'emp tornilleria
                    where_sql_inv = " AND tipo IN ('ETV3') "
                Case 2800 ' galv

                Case 5200 ' galv alambre
                    where_sql_inv = " AND (codigo like '33G%' or codigo like '22G%') AND tipo IN ('EPPT','EPPP') AND codigo not like '33G130125%' "
                Case 5300 ' Grapas
                    where_sql_inv = " AND codigo like '2GR%' AND tipo IN ('EPPP')  "
                Case 5400 ' empaque Grapas
                    where_sql_inv = " AND codigo like '3GR%' AND tipo IN ('EDEP')  "
                Case 6200 ' temple
                    where_sql_inv = ""
                Case 6400 ' puas 
                    where_sql_inv = " AND (codigo like '33P%') AND tipo IN ('EPPT','EPPP')"
            End Select

        Next

        Return dt
    End Function

    Public Sub add_inv_area(ByRef dt As DataTable, ByVal centro As Integer, ByVal where_codigo As String, ByVal mes As Integer, ByVal ano As Integer)
        Dim sql As String = ""
        Dim dt_datos As New DataTable
        Dim group As String = ""
        If centro <> 6200 And centro <> 2800 Then 'temple
            sql = "SELECT SUM(kilos)As kilos    " &
                        "FROM J_transacciones_kilos   " &
                               "WHERE  ano =" & ano & " AND mes =" & mes & " " & where_codigo
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
        ElseIf (centro = 6200) Then
            sql = "SELECT SUM( [Seguimiento tornillos].Cantidad ) AS kilos  " &
            "FROM [Seguimiento tornillos] " &
                "WHERE  [Seguimiento tornillos].Maquina = '213' and YEAR( Fecha) =  " & ano & " and MONTH( Fecha) = " & mes & " "
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "PRODUCCION")
        ElseIf (centro = 2800) Then
            sql = "SELECT SUM( [Seguimiento tornillos].Cantidad ) AS kilos  " &
            "FROM [Seguimiento tornillos] " &
                "WHERE  [Seguimiento tornillos].Maquina = '180' and YEAR( Fecha) =  " & ano & " and MONTH( Fecha) = " & mes & " "
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "PRODUCCION")
        End If

        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("centro") = centro Then
                For k = 0 To dt_datos.Rows.Count - 1
                    If IsNumeric(dt_datos.Rows(k).Item("kilos")) Then
                        dt.Rows(i).Item("llevamos") = dt_datos.Rows(k).Item("kilos")
                    End If
                Next
            End If
        Next
    End Sub

    Public Sub add_Cantidad_Inv(ByRef dt As DataTable, ByVal centro As Integer, ByVal where_codigo As String, ByVal mes As Integer, ByVal ano As Integer)
        Dim sql As String = ""
        Dim dt_datos As New DataTable
        Dim group As String = ""
        If centro <> 6200 And centro <> 2800 Then 'temple
            sql = "SELECT SUM(cantidad)As cantidad    " &
                        "FROM J_transacciones_kilos   " &
                               "WHERE  ano =" & ano & " AND mes =" & mes & " " & where_codigo
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
        ElseIf (centro = 6200) Then
            sql = "SELECT SUM( [Seguimiento tornillos].Cantidad ) AS Cantidad  " &
            "FROM [Seguimiento tornillos] " &
                "WHERE  [Seguimiento tornillos].Maquina = '213' and YEAR( Fecha) =  " & ano & " and MONTH( Fecha) = " & mes & " "
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "PRODUCCION")
        ElseIf (centro = 2800) Then
            sql = "SELECT SUM( [Seguimiento tornillos].Cantidad ) AS Cantidad  " &
            "FROM [Seguimiento tornillos] " &
                "WHERE  [Seguimiento tornillos].Maquina = '180' and YEAR( Fecha) =  " & ano & " and MONTH( Fecha) = " & mes & " "
            dt_datos = obj_op_simplesLn.listar_datatable(sql, "PRODUCCION")
        End If

        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("centro") = centro Then
                For k = 0 To dt_datos.Rows.Count - 1
                    If IsNumeric(dt_datos.Rows(k).Item("cantidad")) Then
                        dt.Rows(i).Item("llevamos_cant") = dt_datos.Rows(k).Item("cantidad")
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub calcular_cumplimiento_area(ByRef dt As DataTable, ByVal dias_habiles As Double, ByVal dias_trabajados As Double, ByVal dias_habiles_otros As Double, ByVal dias_adic_otros As Double, ByVal dias_trabajados_otros As Double)
        Dim sum_ppto As Double = 0
        Dim sum_ppto_dia As Double = 0
        Dim sum_kilos As Double = 0
        Dim sum_deb_llevar As Double = 0
        Dim ppto_por_dia As Double = 0
        Dim ppto As Double = 0
        Dim dias_habiles_finales As Double = 0
        For i = 0 To dt.Rows.Count - 1
            If IsNumeric(dt.Rows(i).Item("llevamos")) Then
                If Not IsDBNull(dt.Rows(i).Item("ppto_kilos")) Then
                    If Not IsDBNull(dt.Rows(i).Item("centro")) Then
                        ppto = dt.Rows(i).Item("ppto_kilos")
                        If dt.Rows(i).Item("centro") = 5200 Then
                            dias_habiles_finales = dias_habiles_otros + dias_adic_otros
                            ppto_por_dia = ppto / dias_habiles_finales
                            dt.Rows(i).Item("dias_habiles") = dias_habiles_otros
                            dt.Rows(i).Item("dias_adicionales") = dias_adic_otros
                            dt.Rows(i).Item("dias_trab") = dias_trabajados_otros
                            dt.Rows(i).Item("deb_llevar") = ppto_por_dia * dias_trabajados_otros
                        Else
                            dias_habiles_finales = dias_habiles
                            ppto_por_dia = ppto / dias_habiles_finales
                            dt.Rows(i).Item("dias_trab") = dias_trabajados
                            dt.Rows(i).Item("deb_llevar") = ppto_por_dia * dias_trabajados
                        End If
                        sum_deb_llevar += dt.Rows(i).Item("deb_llevar")
                        dt.Rows(i).Item("ppto_por_dia") = ppto_por_dia
                    End If
                End If
                If (dt.Rows(i).Item("ppto_kilos") = 0 Or dt.Rows(i).Item("llevamos") = 0) Then
                    dt.Rows(i).Item("cump") = 0
                Else
                    dt.Rows(i).Item("cump") = (dt.Rows(i).Item("llevamos") / dt.Rows(i).Item("ppto_kilos")) * 100
                    sum_ppto += dt.Rows(i).Item("ppto_kilos")
                    sum_kilos += dt.Rows(i).Item("llevamos")
                End If
                If (dt.Rows(i).Item("deb_llevar") = 0 Or dt.Rows(i).Item("llevamos") = 0) Then
                    dt.Rows(i).Item("cump") = 0
                Else
                    dt.Rows(i).Item("cump_hoy") = (dt.Rows(i).Item("llevamos") / dt.Rows(i).Item("deb_llevar")) * 100
                    sum_ppto_dia += dt.Rows(i).Item("deb_llevar")
                End If
                dt.Rows(i).Item("prom_dia") = dt.Rows(i).Item("llevamos") / dias_trabajados
                dt.Rows(i).Item("pxn_a_recup") = dt.Rows(i).Item("deb_llevar") - dt.Rows(i).Item("llevamos")
            End If
        Next
    End Sub


    Private Sub guna2Button3_Click(sender As Object, e As EventArgs) Handles guna2Button3.Click
        imgSlide2.Visible = True
        imgSlide2.SendToBack()
        imgSlideH.Visible = False
        imgSlide1.Visible = False
        imgSlide3.Visible = False
    End Sub


    Private Sub guna2Button4_Click(sender As Object, e As EventArgs) Handles guna2Button4.Click
        TabControl1.SelectedIndex = 2

        If (Primer_ingreso_costos = True) Then

            imgSlide3.Visible = True
            imgSlide3.SendToBack()
            imgSlideH.Visible = False
            imgSlide1.Visible = False
            imgSlide2.Visible = False

            panelPPTO.Visible = True
            TabControl1.Visible = True
            PanelGastos.Visible = True

            'cargarpaneleconomico()

            Primer_ingreso_costos = False
        Else

            imgSlide3.Visible = True
            imgSlide3.SendToBack()
            imgSlideH.Visible = False
            imgSlide1.Visible = False
            imgSlide2.Visible = False

            PanelGastos.Visible = True
            panelPPTO.Visible = True

        End If
    End Sub

    Private Sub cargarpaneleconomico()

        Dim año As String = Year(Now).ToString
        Dim mes As String = Month(Now).ToString
        Dim centros As String = ""

        txtpptocentro.Text = "$ 0.00"
        txtgastocentro.Text = "$ 0.00"
        txttotcentro.Text = "$ 0.00"
        BunifuCircleProgress4.Value = 0
        BunifuRadialGauge1.Value = 0

        If (BunifuDropdown2.Text = "Seleccione" Or BunifuDropdown1.Text = "Seleccione") Then
            año = Year(Now).ToString
            mes = Month(Now).ToString
        Else
            año = BunifuDropdown2.Text
            mes = BunifuDropdown1.SelectedIndex
        End If

        Dim where_centro As String = ""
        Dim nit As Double = usuario.nit
        Dim listCentros As DataTable = obj_op_simplesLn.listar_datatable("SELECT centro FROM J_coordinador_centros_costos WHERE nit =" & nit, "PRODUCCION")
        'Dim listCentros As DataTable = obj_op_simplesLn.listar_datatable("SELECT centro FROM F_V_centros_ppt ", "CORSAN")
        For i = 0 To listCentros.Rows.Count - 1
            centros &= listCentros.Rows(i).Item("centro")
            If (i <> listCentros.Rows.Count - 1) Then
                centros &= ","
            End If
        Next
        If centros <> "" Then
            where_centro = " AND centro IN( " & centros & ") "
            where_centro = " AND centro IN(1100, 1200, 3100, 3200, 3600, 4100, 4110, 2100, 2200, 2300, 2400, 2500, 2600, 5200, 5300, 5400, 6200, 6400 ) "
        End If


        ''cargar tabla de porcentaje de distribucion
        Dim sql_ppto_distribucion As String = "SELECT * from FTR_porcentaje_gastos"

        dt_ppto_distribucion = obj_op_simplesLn.listar_datatable(sql_ppto_distribucion, "CORSAN")


        'where_centro = " AND centro IN( " & centroCostos & ") "
        Dim where_centro_admin As String = ""
        where_centro_admin = " AND centro IN(1100, 1200, 3100, 3200, 3500, 3600, 4100, 4110) "
        Dim where_centro_prod As String = ""
        where_centro_prod = " AND centro IN(2100, 2200, 2300, 2400, 2500, 2600, 2700, 5200, 5300, 5400, 6200, 6400 ) "


        'Dim sql As String = "SELECT centro,p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano  " & where_centro & " ) As presupuesto,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes  " & where_centro & " ) As saldo " &
        '                         "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
        '                            "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta  and p.mes = " & mes & " And  p.ano = " & año & " " &
        '                                "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden,centro   " &
        '                                    "ORDER BY p.ano,p.mes,g.orden "

        Dim sql As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano " & where_centro & " ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes  ) As saldo,(select sum(cantidad * precio_unit) from PRGPRODUCCION.dbo.J_solicitud_compra_det m join PRGPRODUCCION.dbo.J_solicitud_compra_enc l on m.numero=l.numero  where m.cuenta=c.cuenta and l.terminado is null) as ordenes_debe ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND ano =  p.ano " & where_centro & " ) As acum_ppto, (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano  " & where_centro & "  ) As acum_saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta And p.mes = " & mes & " And p.ano = " & año & "" &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "

        Dim dt_pptos As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")

        dtg_consulta.DataSource = dt_pptos

        ''cargar pto de admin
        Dim sqladmin As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano " & where_centro_admin & " ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes " & where_centro_admin & " ) As saldo,(select sum(cantidad * precio_unit) from PRGPRODUCCION.dbo.J_solicitud_compra_det m join PRGPRODUCCION.dbo.J_solicitud_compra_enc l on m.numero=l.numero  where m.cuenta=c.cuenta and l.terminado is null) as ordenes_debe ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND ano =  p.ano " & where_centro_admin & " ) As acum_ppto, (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano  " & where_centro_admin & "  ) As acum_saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta And p.mes = " & mes & " And p.ano = " & año & "" &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "

        Dim dt_pptosadmin As DataTable = obj_op_simplesLn.listar_datatable(sqladmin, "CORSAN")

        ''cargar pto de prod
        Dim sqlprod As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano " & where_centro_prod & " ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes " & where_centro_prod & " ) As saldo,(select sum(cantidad * precio_unit) from PRGPRODUCCION.dbo.J_solicitud_compra_det m join PRGPRODUCCION.dbo.J_solicitud_compra_enc l on m.numero=l.numero  where m.cuenta=c.cuenta and l.terminado is null) as ordenes_debe ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND ano =  p.ano " & where_centro_prod & " ) As acum_ppto, (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano  " & where_centro_prod & "  ) As acum_saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta And p.mes = " & mes & " And p.ano = " & año & "" &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "

        Dim dt_pptosprod As DataTable = obj_op_simplesLn.listar_datatable(sqlprod, "CORSAN")




        Dim sqlaño = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes ) As saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta  And  p.ano = " & año & " " &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "
        Dim dtgrafica As DataTable = obj_op_simplesLn.listar_datatable(sqlaño, "CORSAN")


        Dim dt As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
        Dim dt_final As New DataTable
        Dim tipo_Ant As String = ""
        For j = 0 To dt.Columns.Count - 1
            If dt.Columns(j).ColumnName = "tipo" Or dt.Columns(j).ColumnName = "cuenta" Or dt.Columns(j).ColumnName = "desc_cuenta" Then
                dt_final.Columns.Add(dt.Columns(j).ColumnName)
            Else
                dt_final.Columns.Add(dt.Columns(j).ColumnName, GetType(Double))
            End If
        Next
        For i = 0 To dt.Rows.Count - 1
            If Not IsDBNull(dt.Rows(i).Item("tipo")) Then
                If tipo_Ant <> (dt.Rows(i).Item("tipo")) Then
                    If tipo_Ant <> "" Then
                        dt_final.Rows.Add()
                        dt_final.Rows(dt_final.Rows.Count - 1).Item("desc_cuenta") = "TOTAL " & tipo_Ant
                    End If
                    tipo_Ant = (dt.Rows(i).Item("tipo"))
                End If
                dt_final.Rows.Add()
                For j = 0 To dt.Columns.Count - 1
                    dt_final.Rows(dt_final.Rows.Count - 1).Item(dt.Columns(j).ColumnName) = dt.Rows(i).Item(j)
                Next
            End If
        Next
        If dt.Rows.Count > 0 Then
            dt_final.Rows.Add()
            dt_final.Rows(dt_final.Rows.Count - 1).Item("desc_cuenta") = "TOTAL " & tipo_Ant
        End If
        dtg_consulta.DataSource = dt_final
        dtg_consulta.Columns.Item("mes").Visible = False
        dtg_consulta.Columns.Item("ano").Visible = False
        dtg_consulta.Columns.Item("tipo").Visible = False

        Dim penero As Integer = 0
        Dim pfebrero As Integer = 0
        Dim pmarzo As Integer = 0
        Dim pabril As Integer = 0
        Dim pmayo As Integer = 0
        Dim pjunio As Integer = 0
        Dim pjulio As Integer = 0
        Dim pagosto As Integer = 0
        Dim pseptiembre As Integer = 0
        Dim poctubre As Integer = 0
        Dim pnoviembre As Integer = 0
        Dim pdiciembre As Integer = 0

        Dim genero As Integer = 0
        Dim gfebrero As Integer = 0
        Dim gmarzo As Integer = 0
        Dim gabril As Integer = 0
        Dim gmayo As Integer = 0
        Dim gjunio As Integer = 0
        Dim gjulio As Integer = 0
        Dim gagosto As Integer = 0
        Dim gseptiembre As Integer = 0
        Dim goctubre As Integer = 0
        Dim gnoviembre As Integer = 0
        Dim gdiciembre As Integer = 0


#Disable Warning BC42303 ' El comentario XML no puede aparecer en un método o una propiedad. Se omitirá el comentario XML.
        '''cargar datos
        '''
        Dim pptomes As Integer = 0
        Dim gastomes As Integer = 0
        Dim pptoadmin As Double = 0
        Dim gastoadmin As Double = 0
        Dim pptoprod As Double = 0
        Dim gastoprod As Double = 0


        For i = 0 To dt.Rows.Count - 1
            If IsDBNull(dt.Rows(i).Item("presupuesto")) Then
                pptomes += 0

            Else
                pptomes += dt.Rows(i).Item("presupuesto")
            End If
            If IsDBNull(dt.Rows(i).Item("saldo")) Then
                gastomes += 0

            Else
                gastomes += dt.Rows(i).Item("saldo")
            End If
        Next

        For i = 0 To dt_pptosadmin.Rows.Count - 1
            If IsDBNull(dt_pptosadmin.Rows(i).Item("presupuesto")) Then
                pptoadmin += 0

            Else
                pptoadmin += dt_pptosadmin.Rows(i).Item("presupuesto")
            End If
            If IsDBNull(dt_pptosadmin.Rows(i).Item("saldo")) Then
                gastoadmin += 0

            Else
                gastoadmin += dt_pptosadmin.Rows(i).Item("saldo")
            End If
        Next

        For i = 0 To dt_pptosprod.Rows.Count - 1
            If IsDBNull(dt_pptosprod.Rows(i).Item("presupuesto")) Then
                pptoprod += 0

            Else
                pptoprod += dt_pptosprod.Rows(i).Item("presupuesto")
            End If
            If IsDBNull(dt_pptosprod.Rows(i).Item("saldo")) Then
                gastoprod += 0

            Else
                gastoprod += dt_pptosprod.Rows(i).Item("saldo")
            End If
        Next



        For i = 0 To dtgrafica.Rows.Count - 1
            Select Case dtgrafica.Rows(i).Item("mes")
                Case "1"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        penero += 0

                    Else
                        penero += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        genero += 0

                    Else
                        genero += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "2"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pfebrero += 0
                    Else
                        pfebrero += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gfebrero += 0
                    Else
                        gfebrero += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "3"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pmarzo += 0
                    Else
                        pmarzo += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gmarzo += 0
                    Else
                        gmarzo += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "4"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pabril += 0
                    Else
                        pabril += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gabril += 0
                    Else
                        gabril += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "5"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pmayo += 0
                    Else
                        pmayo += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gmayo += 0
                    Else
                        gmayo += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "6"

                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pjunio += 0
                    Else
                        pjunio += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gjunio += 0
                    Else
                        gjunio += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "7"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pjulio += 0
                    Else
                        pjulio += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gjulio += 0
                    Else
                        gjulio += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "8"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pagosto += 0
                    Else
                        pagosto += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gagosto += 0
                    Else
                        gagosto += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "9"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pseptiembre += 0
                    Else
                        pseptiembre += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gseptiembre += 0
                    Else
                        gseptiembre += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "10"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        poctubre += 0
                    Else
                        poctubre += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        goctubre += 0
                    Else
                        goctubre += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "11"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pnoviembre += 0
                    Else
                        pnoviembre += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gnoviembre += 0
                    Else
                        gnoviembre += dtgrafica.Rows(i).Item("saldo")
                    End If
                Case "12"
                    If IsDBNull(dtgrafica.Rows(i).Item("presupuesto")) Then
                        pdiciembre += 0
                    Else
                        pdiciembre += dtgrafica.Rows(i).Item("presupuesto")
                    End If
                    '
                    If IsDBNull(dtgrafica.Rows(i).Item("saldo")) Then
                        gdiciembre += 0
                    Else
                        gdiciembre += dtgrafica.Rows(i).Item("saldo")
                    End If



            End Select


        Next

        txtpresupuesto.Text = Format(pptomes, "n")
        txtgasto.Text = Format(gastomes, "n")

        txtpresupuestoadmin.Text = Format(pptoadmin, "n")
        txtpresupuestoprod.Text = Format(pptoprod, "n")

        txtgastoadmin.Text = Format(gastoadmin, "n")
        txtgastoprod.Text = Format(gastoprod, "n")


        BunifuCircleProgress3.Value = (gastomes / pptomes) * 100
        BunifuRadialGauge1.Value = (gastomes / pptomes) * 100



        'cargar graficappto bunifu
        BunifuBarChartppto.Data = Nothing
        Dim data_p As List(Of Double) = New List(Of Double)()
        data_p.Add(Format(penero, "n"))
        data_p.Add(Format(pfebrero, "n"))
        data_p.Add(Format(pmarzo, "n"))
        data_p.Add(Format(pabril, "n"))
        data_p.Add(Format(pmayo, "n"))
        data_p.Add(Format(pjunio, "n"))
        data_p.Add(Format(pjulio, "n"))
        data_p.Add(Format(pagosto, "n"))
        data_p.Add(Format(pseptiembre, "n"))
        data_p.Add(Format(poctubre, "n"))
        data_p.Add(Format(pnoviembre, "n"))
        data_p.Add(Format(pdiciembre, "n"))
        BunifuBarChartppto.Data = data_p
        BunifuBarChartppto.TargetCanvas = BunifuChartCanvas3

        Dim data_g As List(Of Double) = New List(Of Double)()
        data_g.Add(genero)
        data_g.Add(gfebrero)
        data_g.Add(gmarzo)
        data_g.Add(gabril)
        data_g.Add(gmayo)
        data_g.Add(gjunio)
        data_g.Add(gjulio)
        data_g.Add(gagosto)
        data_g.Add(gseptiembre)
        data_g.Add(goctubre)
        data_g.Add(gnoviembre)
        data_g.Add(gdiciembre)
        BunifuBarChartgasto.Data = data_g
        BunifuBarChartgasto.TargetCanvas = BunifuChartCanvas3



    End Sub


    Private Function armar_dt() As DataTable
        Dim where_permiso As String = ""
        Dim where_centro As String = ""

        Dim año As String = Year(Now).ToString
        Dim mes As String = Month(Now).ToString
        Dim centros As String = "2100"

        If centros <> "" Then
            where_centro = " AND centro IN( " & centros & ") "
        End If


        Dim sql As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano " & where_centro & " ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes " & where_centro & " ) As saldo,(select sum(cantidad * precio_unit) from PRGPRODUCCION.dbo.J_solicitud_compra_det m join PRGPRODUCCION.dbo.J_solicitud_compra_enc l on m.numero=l.numero  where m.cuenta=c.cuenta and l.terminado is null) as ordenes_debe ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND ano =  p.ano " & where_centro & " ) As acum_ppto, (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano  " & where_centro & "  ) As acum_saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta And p.mes = " & mes & " And p.ano = " & año & "" &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "


        dt = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
        dtg_consulta.DataSource = dt

        Dim dt_final As New DataTable
        Dim tipo_Ant As String = ""
        For j = 0 To dt.Columns.Count - 1
            If dt.Columns(j).ColumnName = "tipo" Or dt.Columns(j).ColumnName = "cuenta" Or dt.Columns(j).ColumnName = "desc_cuenta" Then
                dt_final.Columns.Add(dt.Columns(j).ColumnName)
            Else
                dt_final.Columns.Add(dt.Columns(j).ColumnName, GetType(Double))
            End If
        Next
        For i = 0 To dt.Rows.Count - 1
            If Not IsDBNull(dt.Rows(i).Item("tipo")) Then
                If tipo_Ant <> (dt.Rows(i).Item("tipo")) Then
                    If tipo_Ant <> "" Then
                        dt_final.Rows.Add()
                        dt_final.Rows(dt_final.Rows.Count - 1).Item("desc_cuenta") = "TOTAL " & tipo_Ant
                    End If
                    tipo_Ant = (dt.Rows(i).Item("tipo"))
                End If
                dt_final.Rows.Add()
                For j = 0 To dt.Columns.Count - 1
                    dt_final.Rows(dt_final.Rows.Count - 1).Item(dt.Columns(j).ColumnName) = dt.Rows(i).Item(j)
                Next
            End If
        Next
        If dt.Rows.Count > 0 Then
            dt_final.Rows.Add()
            dt_final.Rows(dt_final.Rows.Count - 1).Item("desc_cuenta") = "TOTAL " & tipo_Ant
        End If
        Return dt_final
    End Function

    Private Sub GunaWinSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles GunaWinSwitch1.CheckedChanged
        If (GunaWinSwitch1.Checked) Then
            'mostrar tabla
            dtd.Visible = True
            dtg_consumo_alambron.Visible = True
            checkvariables.Visible = True
            lblvariables.Visible = True
        Else
            dtg_consumo_alambron.Visible = False
            dtd.Visible = False
            checkvariables.Visible = False
            lblvariables.Visible = False
        End If

    End Sub

    Private Sub checkvariables_CheckedChanged(sender As Object, e As EventArgs) Handles checkvariables.CheckedChanged

        If (checkvariables.Checked) Then
            dtd.Columns.Item("dias_adicionales").Visible = True
            dtd.Columns.Item("dias_trab").Visible = True
            dtd.Columns.Item("pxn_a_recup").Visible = True
            bunitable.Columns.Item("dias_adicionales").Visible = True
            bunitable.Columns.Item("dias_trab").Visible = True
            bunitable.Columns.Item("pxn_a_recup").Visible = True

        Else
            dtd.Columns.Item("dias_adicionales").Visible = False
            dtd.Columns.Item("dias_trab").Visible = False
            dtd.Columns.Item("pxn_a_recup").Visible = False
            bunitable.Columns.Item("dias_adicionales").Visible = False
            bunitable.Columns.Item("dias_trab").Visible = False
            bunitable.Columns.Item("pxn_a_recup").Visible = False
        End If

    End Sub

    Private Sub cargargrafica()


        CartesianChart1.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                .Values = New ChartValues(Of ObservablePoint) From {
                    New ObservablePoint(0, 10),
                    New ObservablePoint(4, 7),
                    New ObservablePoint(5, 3),
                    New ObservablePoint(7, 6),
                    New ObservablePoint(10, 8)
                },
                .PointGeometrySize = 15
            },
            New LineSeries With {
                .Values = New ChartValues(Of ObservablePoint) From {
                    New ObservablePoint(0, 2),
                    New ObservablePoint(2, 5),
                    New ObservablePoint(3, 6),
                    New ObservablePoint(6, 8),
                    New ObservablePoint(10, 5)
                },
                .PointGeometrySize = 15
            },
            New LineSeries With {
                .Values = New ChartValues(Of ObservablePoint) From {
                    New ObservablePoint(0, 4),
                    New ObservablePoint(5, 5),
                    New ObservablePoint(7, 7),
                    New ObservablePoint(9, 10),
                    New ObservablePoint(10, 9)
                },
                .PointGeometrySize = 15
            }
        }
    End Sub


    Private Sub cargarGraficaanoCOSTOS()



        Dim año As String = Year(Now).ToString
        Dim mes As String = Month(Now).ToString

        Dim dt_consultaG As DataTable = obj_ppto_produccionLn.cargar_areaGraficacostos(año, centroCostos)
        ''Dim dtdano.DataSource = dt_consultaGrafica

        Dim enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre As Double
        Dim genero, gfebrero, gmarzo, gabril, gmayo, gjunio, gjulio, gagosto, gseptiembre, goctubre, gnoviembre, gdiciembre As Double

        enero = 0
        febrero = 0
        marzo = 0
        abril = 0
        mayo = 0
        junio = 0
        julio = 0
        agosto = 0
        septiembre = 0
        octubre = 0
        noviembre = 0
        diciembre = 0
        ''
        genero = 0
        gfebrero = 0
        gmarzo = 0
        gabril = 0
        gmayo = 0
        gjunio = 0
        gjulio = 0
        gagosto = 0
        gseptiembre = 0
        goctubre = 0
        gnoviembre = 0
        gdiciembre = 0

        ''CARGAR PPTO
        For i = 0 To dt_consultaG.Rows.Count - 1

            If IsDBNull(dt_consultaG.Rows(i).Item("mes")) Then

            Else
                If (dt_consultaG.Rows(i).Item("mes") = 1) Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        enero += 0
                    Else
                        enero += dt_consultaG.Rows(i).Item("presupuesto")
                    End If


                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        genero += 0
                    Else
                        genero += dt_consultaG.Rows(i).Item("saldo")
                    End If
                End If
                If (dt_consultaG.Rows(i).Item("mes") = "2") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        febrero += 0
                    Else
                        febrero += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gfebrero += 0
                    Else
                        gfebrero += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "3") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        marzo += 0
                    Else
                        marzo += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gmarzo += 0
                    Else
                        gmarzo += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "4") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        abril += 0
                    Else
                        abril += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gabril += 0
                    Else
                        gabril += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "5") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        mayo += 0
                    Else
                        mayo += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gmayo += 0
                    Else
                        gmayo += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "6") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        junio += 0
                    Else
                        junio += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gjunio += 0
                    Else
                        gjunio += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "7") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        julio += 0
                    Else
                        julio += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gjulio += 0
                    Else
                        gjulio += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "8") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        agosto += 0
                    Else
                        agosto += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gagosto += 0
                    Else
                        gagosto += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "9") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        septiembre += 0
                    Else
                        septiembre += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gseptiembre += 0
                    Else
                        gseptiembre += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "10") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        octubre += 0
                    Else
                        octubre += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        goctubre += 0
                    Else
                        goctubre += dt_consultaG.Rows(i).Item("saldo")
                    End If

                End If
                If (dt_consultaG.Rows(i).Item("mes") = "11") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        noviembre += 0
                    Else
                        noviembre += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gnoviembre += 0
                    Else
                        gnoviembre += dt_consultaG.Rows(i).Item("saldo")
                    End If


                End If
                If (dt_consultaG.Rows(i).Item("mes") = "12") Then

                    If IsDBNull(dt_consultaG.Rows(i).Item("presupuesto")) Then
                        diciembre += 0
                    Else
                        diciembre += dt_consultaG.Rows(i).Item("presupuesto")
                    End If

                    If IsDBNull(dt_consultaG.Rows(i).Item("saldo")) Then
                        gdiciembre += 0
                    Else
                        gdiciembre += dt_consultaG.Rows(i).Item("saldo")
                    End If

                Else
                End If
            End If
        Next





        'cargar graficappto bunifu
        BunifuBarChartppto.Data = Nothing
        Dim data_p As List(Of Double) = New List(Of Double)()
        data_p.Add(Format(enero, "n"))
        data_p.Add(Format(febrero, "n"))
        data_p.Add(Format(marzo, "n"))
        data_p.Add(Format(abril, "n"))
        data_p.Add(Format(mayo, "n"))
        data_p.Add(Format(junio, "n"))
        data_p.Add(Format(julio, "n"))
        data_p.Add(Format(agosto, "n"))
        data_p.Add(Format(septiembre, "n"))
        data_p.Add(Format(octubre, "n"))
        data_p.Add(Format(noviembre, "n"))
        data_p.Add(Format(diciembre, "n"))

        BunifuBarChartppto.Data = data_p
        BunifuBarChartppto.TargetCanvas = BunifuChartCanvas3



        'cargar graficagasto bunifu
        BunifuBarChartgasto.Data = Nothing
        Dim data_g As List(Of Double) = New List(Of Double)()
        data_g.Add(genero)
        data_g.Add(gfebrero)
        data_g.Add(gmarzo)
        data_g.Add(gabril)
        data_g.Add(gmayo)
        data_g.Add(gjunio)
        data_g.Add(gjulio)
        data_g.Add(gagosto)
        data_g.Add(gseptiembre)
        data_g.Add(goctubre)
        data_g.Add(gnoviembre)
        data_g.Add(gdiciembre)
        BunifuBarChartgasto.Data = data_g
        BunifuBarChartgasto.TargetCanvas = BunifuChartCanvas3


    End Sub

    Private Sub cargarGraficaano()


        llenero = 0
        llfebrero = 0
        llmarzo = 0
        llabril = 0
        llmayo = 0
        lljunio = 0
        lljulio = 0
        llagosto = 0
        llseptiembre = 0
        llocutbre = 0
        llnoviembre = 0
        lldiciembre = 0

        Dim dt_consultaGrafica As DataTable = obj_ppto_produccionLn.cargar_areaGrafica(año, centro)

        ''Dim dtdano.DataSource = dt_consultaGrafica
        ''Dim dtdano.DataSource = dt_consultaGrafica

        For i = 0 To dt_consultaGrafica.Rows.Count - 1

            If (dt_consultaGrafica.Rows(i).Item("mes") = "1") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkenero = 0

                Else
                    pkenero = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "2") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkfebrero = 0
                Else
                    pkfebrero = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "3") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkmarzo = 0
                Else
                    pkmarzo = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "4") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkabril = 0
                Else
                    pkabril = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "5") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkmayo = 0
                Else
                    pkmayo = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "6") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkjunio = 0
                Else
                    pkjunio = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "7") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkjulio = 0
                Else
                    pkjulio = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "8") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkagosto = 0
                Else
                    pkagosto = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "9") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkseptiembre = 0
                Else
                    pkseptiembre = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "10") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkoctubre = 0
                Else
                    pkoctubre = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "11") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pknoviembre = 0
                Else
                    pknoviembre = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If
            If (dt_consultaGrafica.Rows(i).Item("mes") = "12") Then

                If IsDBNull(dt_consultaGrafica.Rows(i).Item("kilos")) Then
                    pkdiciembre = 0
                Else
                    pkdiciembre = dt_consultaGrafica.Rows(i).Item("kilos")
                End If

            End If

        Next

        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        CartesianChart1.Series = New LiveCharts.SeriesCollection From {
            New LineSeries With {
                .Values = New ChartValues(Of ObservablePoint) From {
                    New ObservablePoint(1, CInt(pkenero)),
        New ObservablePoint(2, CInt(pkfebrero)),
        New ObservablePoint(3, CInt(pkmarzo)),
        New ObservablePoint(4, CInt(pkabril)),
        New ObservablePoint(5, CInt(pkmayo)),
        New ObservablePoint(6, CInt(pkjunio)),
        New ObservablePoint(7, CInt(pkjulio)),
        New ObservablePoint(8, CInt(pkagosto)),
        New ObservablePoint(9, CInt(pkseptiembre)),
        New ObservablePoint(10, CInt(pkoctubre)),
        New ObservablePoint(11, CInt(pknoviembre)),
        New ObservablePoint(12, CInt(pkdiciembre))
                },
                .PointGeometrySize = 15,
                .Title = "llevamos",
                .DataLabels = True,
                .Foreground = New SolidColorBrush(Color.FromRgb(59, 195, 255)),
                .Stroke = New SolidColorBrush(Color.FromRgb(59, 195, 255))
            }
        }
        ' 
        Dim data As List(Of Double) = New List(Of Double)()

        data.Add(CInt(pkenero))
        data.Add(CInt(pkfebrero))
        data.Add(CInt(pkmarzo))
        data.Add(CInt(pkabril))
        data.Add(CInt(pkmayo))
        data.Add(CInt(pkjunio))
        data.Add(CInt(pkjulio))
        data.Add(CInt(pkagosto))
        data.Add(CInt(pkseptiembre))
        data.Add(CInt(pkoctubre))
        data.Add(CInt(pknoviembre))
        data.Add(CInt(pkdiciembre))
        ' 
        '  Set your data             
        ' 
        BunifuLineChart.Data = data
        BunifuLineChart.TargetCanvas = BunifuChartCanvas1
        BunifuLineChart.CubicInterpolationMode = BunifuLineChart.CubicInterpolationModes.Monotone
        BunifuLineChart.Fill = BunifuLineChart.FillOptions.Start
        BunifuLineChart.Label = True


    End Sub

    Private Sub renderPieChart()




    End Sub


    Private Sub r1_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2100
        cargarGraficaano()
    End Sub

    Private Sub r2_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2200
        cargarGraficaano()
    End Sub

    Private Sub r3_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2300
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2400
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2500
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        centro = 2600
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        centro = 5200
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton6_CheckedChanged(sender As Object, e As EventArgs)
        centro = 5300
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton5_CheckedChanged(sender As Object, e As EventArgs)
        centro = 5400
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton7_CheckedChanged(sender As Object, e As EventArgs)
        centro = 6200
        cargarGraficaano()
    End Sub

    Private Sub Guna2RadioButton8_CheckedChanged(sender As Object, e As EventArgs)
        centro = 6400
        cargarGraficaano()
    End Sub

    Private Sub txt_cuenta_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Filtro(TextBox1.Text).Rows.Count > 0 Then
            dtg_consulta.DataSource = Filtro(TextBox1.Text)
        End If
    End Sub

    Function Filtro(ByVal busqueda As String) As DataTable
        'con.Open()
        Dim dts As New DataTable

        Dim sql As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano  and centro in( " & centroCostos & " ) ) As presupuesto ,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes and centro in( " & centroCostos & " ) ) As saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta And p.cuenta LIKE '%" & busqueda & "%' and p.mes = 1 and p.ano = 2022  " &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "
        dt = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
        dtg_consulta.DataSource = dt

        'con.Close()
        Return dt
    End Function


    Sub recargartabla()


        If (BunifuDropdown2.Text = "Seleccione" Or BunifuDropdown1.Text = "Seleccione") Then
            año = Year(Now).ToString
            mes = Month(Now).ToString
        Else
            año = BunifuDropdown2.Text
            mes = BunifuDropdown1.SelectedIndex
        End If

        Dim where_centro As String = ""
        where_centro = " AND centro IN( " & centroCostos & ") "



        Dim sql As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano  " & where_centro & " ) As presupuesto,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes  " & where_centro & " ) As saldo " &
                             "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta  and p.mes = " & mes & " And  p.ano = " & año & "" &
                                    "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                        "ORDER BY p.ano,p.mes,g.orden "

        Dim dt_pptto As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")

        dtg_consulta.DataSource = dt_pptto
        Dim porcentajed As Double = 0
        Dim gasto_total_mes As Double = 0
        Dim distribucion As Double = 0
        Dim encontrado As Boolean = False
        gasto_total_mes = CInt(txtgasto.Text)

        ''cargar los datos del presupuesto de distribucion por centro
        For i = 0 To dt_ppto_distribucion.Rows.Count - 1
            Select Case dt_ppto_distribucion.Rows(i).Item("centro")
                Case centroCostos
                    encontrado = True
                    porcentajed = dt_ppto_distribucion.Rows(i).Item("porcentaje")
            End Select
        Next

        If (porcentajed > 0 And encontrado = True) Then
            txtporcentajeinherente.Text = (gasto_total_mes * porcentajed) / 100
            BunifuRadialGauge1.Value = porcentajed
            txttotcentro.Text = (gasto_total_mes * porcentajed) / 100
        Else
            txtporcentajeinherente.Text = "$ 0.00"
            BunifuRadialGauge1.Value = 0
            txttotcentro.Text = "$ 0.00"
        End If

        '''''prueba sacar solo las cuentas con saldo o ppto
        '''
        Dim listaux As New List(Of DataRow)

        For Each dr As DataRow In dt_pptto.Rows

            If IsDBNull(dr("presupuesto")) And IsDBNull(dr("saldo")) Then
                listaux.Add(dr)
            End If

        Next

        For Each dr As DataRow In listaux
            dt_pptto.Rows.Remove(dr)
        Next


        dtg_consulta.DataSource = dt_pptto
        '' FIN PRUEBA MOSTRAR SOLO LAS QUE TENGAN MOVIMIENTO


        Dim pptocentromes As Integer = 0
        Dim Gastocentromes As Integer = 0

        For i = 0 To dt_pptto.Rows.Count - 1
            'calcular ppto y mes
            If IsDBNull(dt_pptto.Rows(i).Item("presupuesto")) Then
                pptocentromes += 0

            Else
                pptocentromes += dt_pptto.Rows(i).Item("presupuesto")
            End If
            '
            If IsDBNull(dt_pptto.Rows(i).Item("saldo")) Then
                Gastocentromes += 0

            Else
                Gastocentromes += dt_pptto.Rows(i).Item("saldo")
            End If
        Next

        txtpptocentro.Text = Format(pptocentromes, "n")
        txtgastocentro.Text = Format(Gastocentromes, "n")

        Dim porcentaje As Double

        porcentaje = (Gastocentromes / pptocentromes) * 100

        If (porcentaje < 0 Or porcentaje > 130) Then
            BunifuCircleProgress4.Value = 0
        Else
            BunifuCircleProgress4.Value = porcentaje
        End If






    End Sub


    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)
        centroCostos = 1100
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "1100"
        'recargartabla()

    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        centroCostos = 1200
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "1200"
        recargartabla()
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)
        centroCostos = 2100
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2100"
        recargartabla()

    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs)
        centroCostos = 2200
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2200"
        recargartabla()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        centroCostos = 2300
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2300"
        recargartabla()
    End Sub

    Private Sub Guna2Button13_Click(sender As Object, e As EventArgs)
        centroCostos = 2400
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2400"
        recargartabla()
    End Sub

    Private Sub Guna2Button14_Click(sender As Object, e As EventArgs)
        centroCostos = 2500
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2500"
        recargartabla()
    End Sub

    Private Sub Guna2Button15_Click(sender As Object, e As EventArgs)
        centroCostos = 2600
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "2600"
        recargartabla()
    End Sub

    Private Sub Guna2Button23_Click(sender As Object, e As EventArgs)
        centroCostos = 3100
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "3100"
        recargartabla()
    End Sub

    Private Sub Guna2Button22_Click(sender As Object, e As EventArgs)
        centroCostos = 3200
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "3200"
        recargartabla()
    End Sub

    Private Sub Guna2Button21_Click(sender As Object, e As EventArgs)
        centroCostos = 3600
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "3600"
        recargartabla()
    End Sub

    Private Sub Guna2Button20_Click(sender As Object, e As EventArgs)
        centroCostos = 4100
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "4100"
        recargartabla()
    End Sub

    Private Sub Guna2Button19_Click(sender As Object, e As EventArgs)
        centroCostos = 4110
        cargarGraficaanoCOSTOS()
        ' txtcentro.Text = "4110"
        recargartabla()
    End Sub

    Private Sub Guna2Button18_Click(sender As Object, e As EventArgs)
        centroCostos = 4500
        cargarGraficaanoCOSTOS()
        ' txtcentro.Text = "4500"
        recargartabla()
    End Sub

    Private Sub Guna2Button17_Click(sender As Object, e As EventArgs)
        centroCostos = 5200
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "5200"
        recargartabla()
    End Sub

    Private Sub Guna2Button16_Click(sender As Object, e As EventArgs)
        centroCostos = 5300
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "5300"
        recargartabla()
    End Sub

    Private Sub Guna2Button26_Click(sender As Object, e As EventArgs)
        centroCostos = 5400
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "5400"
        recargartabla()
    End Sub

    Private Sub Guna2Button25_Click(sender As Object, e As EventArgs)
        centroCostos = 6200
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "6200"
        recargartabla()
    End Sub

    Private Sub Guna2Button24_Click(sender As Object, e As EventArgs)
        centroCostos = 6400
        cargarGraficaanoCOSTOS()
        'txtcentro.Text = "6400"
        recargartabla()
    End Sub

    Private Sub dtg_consulta_MouseDown(sender As Object, e As MouseEventArgs) Handles dtg_consulta.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            With (Me.dtg_consulta)
                Dim Hitest As DataGridView.HitTestInfo = .HitTest(e.X, e.Y)
                If Hitest.Type = DataGridViewHitTestType.Cell Then
                    .CurrentCell = .Rows(Hitest.RowIndex).Cells(Hitest.ColumnIndex)
                End If
            End With
        Else

        End If
        'fila_select = dtg_consulta.CurrentCell.RowIndex
    End Sub

    Private Sub itemDetalle_Click(sender As Object, e As EventArgs) Handles itemDetalle.Click
        If Not IsDBNull(dtg_consulta.Item("cuenta", fila_select).Value) Then
            dtg_detalle.DataSource = Nothing
            groupDetalle.Visible = True
            Dim tamano_letra As Single = 7.5!
            Dim mes_detalle As Integer = dtg_consulta.Item("mes", fila_select).Value
            Dim ano_detalle As Integer = dtg_consulta.Item("ano", fila_select).Value
            Dim cuenta As Integer = dtg_consulta.Item("cuenta", fila_select).Value
            Dim where_centro As String = ""
            Dim a As String

            'If centros <> "" Then
            '    If cbo_centro.SelectedValue <> 0 Then
            '        where_centro = " AND s.centro = " & cbo_centro.SelectedValue
            '    Else
            '        where_centro = " AND s.centro IN( " & centros & ") "
            '    End If

            'End If

            Dim sql As String = "SELECT c.cuenta,s.centro,s.descripcion As desc_centro,sum( m.valor) as saldo  " &
                      "FROM terceros ter,j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , movimiento m , centros s  " &
                                  "WHERE ter.nit = m.nit AND s.centro = SUBSTRING ( cast(m.centro As varchar (25)) ,0 , 3 ) + '00' And m.cuenta = c.cuenta And g.tipo = t.id And g.cuenta = c.cuenta  And Month(m.fec) = " & mes & " And YEAR(m.fec) = " & año & " And c.cuenta = " & cuenta & "  " & where_centro & " " &
                              "GROUP BY c.cuenta ,s.centro,s.descripcion "

            'Dim sql As String = "SELECT        c.cuenta, dbo.documentos.centro_doc AS centro, dbo.centros.descripcion, SUM(m.valor) AS saldo " &
            '        "FROM    dbo.J_ppto_gastos_cuentas AS g INNER JOIN " &
            '             "dbo.J_ppto_gastos_tipo As t On g.tipo = t.id INNER JOIN " &
            '             "dbo.terceros AS ter INNER JOIN " &
            '             "dbo.movimiento AS m ON ter.nit = m.nit INNER JOIN " &
            '             "dbo.documentos AS s ON SUBSTRING(CAST(m.centro AS varchar(25)), 0, 3) + '00' = s.centro_doc INNER JOIN " &
            '             "dbo.cuentas AS c ON m.cuenta = c.cuenta ON g.cuenta = c.cuenta INNER JOIN " &
            '             "dbo.documentos ON m.tipo = dbo.documentos.tipo AND m.numero = dbo.documentos.numero INNER JOIN " &
            '             "dbo.centros ON dbo.documentos.centro_doc = dbo.centros.centro " &
            '              "WHERE   Month(m.fec) = " & mes & " And YEAR(m.fec) = " & ano & " AND c.cuenta = " & cuenta & "" &
            '          "GROUP BY c.cuenta, dbo.documentos.centro_doc, dbo.centros.descripcion, dbo.centros.centro "


            Dim dt As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
            dt.Columns.Add("presupuesto", GetType(Double))
            dt.Columns.Add("porc_cump", GetType(Double))
            dt.Columns.Add("diferencia", GetType(Double))
            sql = "Select centro,SUM(ppto) As presupuesto " &
                        "FROM J_ppto_gastos " &
                                "WHERE centro Is Not null And mes = " & mes & " And ano = " & año & " And cuenta = " & cuenta & " " &
                                    "GROUP BY centro"
            Dim dt_ppto As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")
            If dt_ppto.Rows.Count = 0 And dt.Rows.Count = 1 Then
                dt.Rows(dt.Rows.Count - 1).Item("presupuesto") = dtg_consulta.Item("presupuesto", fila_select).Value
            Else
                For i = 0 To dt_ppto.Rows.Count - 1
                    For z = 0 To dt.Rows.Count - 1
                        If dt_ppto.Rows(i).Item("centro") = dt.Rows(z).Item("centro") Then
                            dt.Rows(z).Item("presupuesto") = dt_ppto.Rows(i).Item("presupuesto")
                            z = dt.Rows.Count - 1
                        End If
                    Next
                Next
            End If
            dt.Rows.Add()
            'calcular_cumplimiento(dt)
            'totalizarDt(dt)
            If dt_ppto.Rows.Count = 0 And dt.Rows.Count > 1 Then
                dt.Rows(dt.Rows.Count - 1).Item("presupuesto") = dtg_consulta.Item("presupuesto", fila_select).Value
            End If
            dtg_detalle.DataSource = dt
            For j = 0 To dt.Columns.Count - 1
                If (dt.Columns(j).ColumnName = "diferencia" Or dt.Columns(j).ColumnName = "presupuesto" Or dt.Columns(j).ColumnName = "saldo" Or dt.Columns(j).ColumnName = "cantidad") Then
                    dtg_detalle.Columns(j).DefaultCellStyle.Format = "N0"
                ElseIf (dt.Columns(j).ColumnName = "porc_cump") Then
                    dtg_detalle.Columns(j).DefaultCellStyle.Format = "N2"
                    dtg_detalle.Columns(j).DefaultCellStyle.Format = "N2"
                End If
            Next
            'dtg_detalle.Rows(dtg_detalle.Rows.Count - 1).DefaultCellStyle = objOperacionesForm.formatoNegrita(tamano_letra)
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        groupDetalle.Visible = False
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PRGPRODUCCIONDataSet2.F_V_anos_prod' Puede moverla o quitarla según sea necesario.
        Me.F_V_anos_prodTableAdapter.Fill(Me.PRGPRODUCCIONDataSet2.F_V_anos_prod)
        Dim Ancho_pantalla As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim Alto_pantalla As Integer = Screen.PrimaryScreen.Bounds.Height
        Dim ancho As Integer = Ancho_pantalla - Me.Width
        Dim alto As Integer = Alto_pantalla - Me.Height
        Me.Location = New Point(ancho \ 2, (alto \ 2) - 20)
    End Sub

    Sub mostrardetalle()
        Dim ppt As Integer = 0
        Dim llevamos As Integer = 0
        ''cargamos el view para ppto
        For i = 0 To dt_consulta.Rows.Count - 1
            If (dt_consulta.Rows(i).Item("centro") = centro) Then
                If IsDBNull(dt_consulta.Rows(i).Item("ppto_kilos")) Or IsDBNull(dt_consulta.Rows(i).Item("llevamos")) Then
                Else
                    lblcentro.Text = dt_consulta.Rows(i).Item("descripcion")
                    lblllevamos.Text = CInt(dt_consulta.Rows(i).Item("llevamos")).ToString
                    lblpptoprod.Text = dt_consulta.Rows(i).Item("ppto_kilos")
                    ppt = CInt(dt_consulta.Rows(i).Item("ppto_kilos"))
                    llevamos = CInt(dt_consulta.Rows(i).Item("llevamos"))

                    lblptocantidad.Text = CInt(dt_consulta.Rows(i).Item("ppto_cantidad")).ToString
                    lblllevamoscant.Text = CInt(dt_consulta.Rows(i).Item("llevamos_cant")).ToString

                    Dim Val As Integer = (dt_consulta.Rows(i).Item("llevamos") / dt_consulta.Rows(i).Item("ppto_kilos")) * 100
                    Dim Vall As Integer = (dt_consulta.Rows(i).Item("llevamos_cant") / dt_consulta.Rows(i).Item("ppto_cantidad")) * 100




                    If (Val > 200) Then
                        BunifuCircleProgress1.Value = Val
                    Else
                        BunifuCircleProgress1.Value = Val
                    End If

                    If (Vall > 200) Then

                    Else
                        BunifuCircleProgress2.Value = Vall
                    End If

                    lbldiashabiles.Text = dt_consulta.Rows(i).Item("dias_habiles").ToString
                    lbldiasadd.Text = dt_consulta.Rows(i).Item("dias_adicionales").ToString
                    lbldiastrab.Text = dt_consulta.Rows(i).Item("dias_trab").ToString


                    If (Val < 90) Then
                        BunifuCircleProgress1.ProgressColor = System.Drawing.Color.IndianRed
                        BunifuCircleProgress1.ForeColor = System.Drawing.Color.IndianRed
                        BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.IndianRed

                    ElseIf (Val >= 90) And (Val <= 99) Then
                        BunifuCircleProgress1.ProgressColor = System.Drawing.Color.Gold
                        BunifuCircleProgress1.ForeColor = System.Drawing.Color.Gold
                        BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.Gold

                    ElseIf (Val >= 100) Then
                        BunifuCircleProgress1.ProgressColor = System.Drawing.Color.Chartreuse
                        BunifuCircleProgress1.ForeColor = System.Drawing.Color.Chartreuse
                        BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.Chartreuse
                    End If
                    If (Vall < 90) Then
                        BunifuCircleProgress2.ProgressColor = System.Drawing.Color.IndianRed
                        BunifuCircleProgress2.ForeColor = System.Drawing.Color.IndianRed
                        BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.IndianRed

                    ElseIf (Vall >= 90) And (Vall <= 99) Then
                        BunifuCircleProgress2.ProgressColor = System.Drawing.Color.Gold
                        BunifuCircleProgress2.ForeColor = System.Drawing.Color.Gold
                        BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.Gold

                    ElseIf (Vall >= 100) Then
                        BunifuCircleProgress2.ProgressColor = System.Drawing.Color.Chartreuse
                        BunifuCircleProgress2.ForeColor = System.Drawing.Color.Chartreuse
                        BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.Chartreuse
                    End If





                End If
            End If
        Next

        ''cargamos el view para gastos y articulos
        If (centro = 2100 Or centro = 2200 Or centro = 2300 Or centro = 2400 Or
            centro = 2500 Or centro = 2600 Or centro = 5200 Or centro = 5300 Or
            centro = 5400 Or centro = 6200 Or centro = 6400) Then

            Dim where_centro As String = ""
            where_centro = " AND centro IN( " & centro & ") "


            Dim sql As String = "SELECT p.mes,p.ano,t.descripcion As tipo,c.cuenta ,c.descripcion As desc_cuenta ,(SELECT SUM (ppto) FROM J_ppto_gastos WHERE cuenta = c.cuenta  AND p.mes = mes AND ano =  p.ano  " & where_centro & " ) As presupuesto,  (SELECT SUM (valor) FROM movimiento WHERE cuenta = c.cuenta AND Year(fec) = p.ano AND MONTH(fec) = p.mes  " & where_centro & " ) As saldo " &
                                 "FROM j_ppto_gastos_tipo t, J_ppto_gastos_cuentas g , cuentas c , J_ppto_gastos p    " &
                                    "WHERE g.tipo = t.id And g.cuenta = c.cuenta And p.cuenta = g.cuenta  and p.mes = " & mes & " And  p.ano = " & año & " " &
                                        "GROUP BY p.mes,p.ano,t.descripcion, c.cuenta ,c.descripcion ,g.orden   " &
                                            "ORDER BY p.ano,p.mes,g.orden "

            Dim dt_ppto As DataTable = obj_op_simplesLn.listar_datatable(sql, "CORSAN")

            dtg_consulta.DataSource = dt_ppto

            Dim pptocentromes As Integer = 0
            Dim Gastocentromes As Integer = 0

            For i = 0 To dt_ppto.Rows.Count - 1
                'calcular ppto y mes
                If IsDBNull(dt_ppto.Rows(i).Item("presupuesto")) Then
                    pptocentromes += 0

                Else
                    pptocentromes += dt_ppto.Rows(i).Item("presupuesto")
                End If
                '
                If IsDBNull(dt_ppto.Rows(i).Item("saldo")) Then
                    Gastocentromes += 0

                Else
                    Gastocentromes += dt_ppto.Rows(i).Item("saldo")
                End If
            Next


            lblpptopkg.Text = pptocentromes / ppt
            lblpkg.Text = Gastocentromes / llevamos




        Else


        End If




    End Sub
    Private Async Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        Await Task.Delay(500)
        BunifuTransition1.ShowSync(BunifuCards1, False, Animation.Mosaic)
        BunifuTransition1.ShowSync(BunifuCards2, False, Animation.ScaleAndHorizSlide)
        BunifuTransition1.ShowSync(BunifuCards3, False, Animation.Mosaic)
    End Sub





    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click
        centro = 2100
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton2_Click(sender As Object, e As EventArgs) Handles BunifuButton2.Click
        centro = 2200
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton3_Click(sender As Object, e As EventArgs) Handles BunifuButton3.Click
        centro = 2300
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton4_Click(sender As Object, e As EventArgs) Handles BunifuButton4.Click
        centro = 2400
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton5_Click(sender As Object, e As EventArgs) Handles BunifuButton5.Click
        centro = 2500
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton6_Click(sender As Object, e As EventArgs) Handles BunifuButton6.Click
        centro = 2600
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton7_Click(sender As Object, e As EventArgs) Handles BunifuButton7.Click
        centro = 5200
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton8_Click(sender As Object, e As EventArgs) Handles BunifuButton8.Click
        centro = 5300
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton9_Click(sender As Object, e As EventArgs) Handles BunifuButton9.Click
        centro = 5400
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton10_Click(sender As Object, e As EventArgs) Handles BunifuButton10.Click
        centro = 6200
        mostrardetalle()
        cargarGraficaano()

    End Sub

    Private Sub BunifuButton11_Click(sender As Object, e As EventArgs) Handles BunifuButton11.Click
        centro = 6400
        mostrardetalle()
        cargarGraficaano()

    End Sub



    Private Sub lblNom_Click(sender As Object, e As EventArgs) Handles lblNom.Click
        renderPieChart()
    End Sub

    Private Sub lblcentro_Click(sender As Object, e As EventArgs) Handles lblcentro.Click

    End Sub

    Private Sub BunifuCircleProgress1_ProgressChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs) Handles BunifuCircleProgress1.ProgressChanged

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        cargarppto()
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        cargarppto()
    End Sub

    Private Sub BunifuButton13_Click(sender As Object, e As EventArgs) Handles BunifuButton13.Click
        centroCostos = 1100
        cargarGraficaanoCOSTOS()
        recargartabla()
        'txtcentro.Text = "1100"
    End Sub

    Private Sub BunifuButton12_Click(sender As Object, e As EventArgs) Handles BunifuButton12.Click
        centroCostos = 1200
        cargarGraficaanoCOSTOS()
        recargartabla()
        'txtcentro.Text = "1200"
        'recargartabla()
    End Sub

    Private Sub BunifuButton14_Click(sender As Object, e As EventArgs) Handles BunifuButton14.Click
        centroCostos = 2100
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton24_Click(sender As Object, e As EventArgs) Handles BunifuButton24.Click
        centroCostos = 2200
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton23_Click(sender As Object, e As EventArgs) Handles BunifuButton23.Click
        centroCostos = 2300
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton22_Click(sender As Object, e As EventArgs) Handles BunifuButton22.Click
        centroCostos = 2400
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton21_Click(sender As Object, e As EventArgs) Handles BunifuButton21.Click
        centroCostos = 2500
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton20_Click(sender As Object, e As EventArgs) Handles BunifuButton20.Click
        centroCostos = 2600
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton29_Click(sender As Object, e As EventArgs) Handles BunifuButton29.Click
        centroCostos = 3100
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton28_Click(sender As Object, e As EventArgs) Handles BunifuButton28.Click
        centroCostos = 3200
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton27_Click(sender As Object, e As EventArgs) Handles BunifuButton27.Click
        centroCostos = 3500
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton26_Click(sender As Object, e As EventArgs) Handles BunifuButton26.Click
        centroCostos = 3600
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton30_Click(sender As Object, e As EventArgs) Handles BunifuButton30.Click
        centroCostos = 4100
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton25_Click(sender As Object, e As EventArgs) Handles BunifuButton25.Click
        centroCostos = 4110
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton19_Click(sender As Object, e As EventArgs) Handles BunifuButton19.Click
        centroCostos = 5200
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton18_Click(sender As Object, e As EventArgs) Handles BunifuButton18.Click
        centroCostos = 5300
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton17_Click(sender As Object, e As EventArgs) Handles BunifuButton17.Click
        centroCostos = 5400
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton16_Click(sender As Object, e As EventArgs) Handles BunifuButton16.Click
        centroCostos = 6200
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuButton15_Click(sender As Object, e As EventArgs) Handles BunifuButton15.Click
        centroCostos = 6400
        cargarGraficaanoCOSTOS()
        recargartabla()
    End Sub

    Private Sub BunifuImageButton2_Click_1(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        cargarpaneleconomico()
    End Sub

    Private Sub txtFilterToolIDs_TextChanged(sender As Object, e As EventArgs) Handles txtFilterToolIDs.TextChanged

        If txtFilterToolIDs.Text.Length < 6 Then
            TreeView1.BeginUpdate()
            TreeView1.CollapseAll()
            ClearBackColor()
            FindByText()
            TreeView1.EndUpdate()
            TreeView1.Refresh()
        Else
            txtFilterToolIDs.Text = ""
            TreeView1.BeginUpdate()
            TreeView1.CollapseAll()
            ClearBackColor()
            FindByText()
            TreeView1.EndUpdate()
            TreeView1.Refresh()
        End If

        TreeView1.BeginUpdate()
        TreeView1.CollapseAll()
        ClearBackColor()
        FindByText()
        TreeView1.EndUpdate()
        TreeView1.Refresh()
    End Sub

    Private Sub ClearBackColor()
        Dim nodes As TreeNodeCollection
        nodes = TreeView1.Nodes
        Dim n As TreeNode
        For Each n In nodes
            ClearRecursive(n)
        Next
    End Sub

    Private Sub ClearRecursive(ByVal treeNode As TreeNode)
        Dim tn As TreeNode
        For Each tn In treeNode.Nodes
            tn.BackColor = Nothing
            ClearRecursive(tn)
        Next
    End Sub

    Private Sub FindByText()
        Dim nodes As TreeNodeCollection = TreeView1.Nodes
        Dim n As TreeNode
        For Each n In nodes
            FindRecursive(n)
        Next
    End Sub


    Private Sub TreeView1_KeyDown(sender As Object, e As KeyEventArgs) Handles TreeView1.KeyDown
        'txtFilterToolIDs.Select()
    End Sub

    Private Sub TreeView1_Click(sender As Object, e As EventArgs) Handles TreeView1.Click
        txtFilterToolIDs.Select()
    End Sub

    Private Sub TreeView1_Enter(sender As Object, e As EventArgs) Handles TreeView1.Enter
        txtFilterToolIDs.Select()
    End Sub

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        txtFilterToolIDs.Select()
    End Sub
End Class