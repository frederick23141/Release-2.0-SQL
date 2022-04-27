#Disable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'System.Data.SqlServerCef' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
#Enable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'System.Data.SqlServerCef' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
#Disable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'System.Configurationcolim' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
#Enable Warning BC40056 ' El espacio de nombres o el tipo especificado en el 'System.Configurationcolim' Imports no contienen ningún miembro público o no se encuentran. Asegúrese de que el espacio de nombres o el tipo se hayan definido y de que contengan al menos un miembro público. Asegúrese de que el nombre del elemento importado no use ningún alias.
Imports logicaNegocios
Imports entidadNegocios

Public Class DassboardMaquinas

    Private obj_Ing_prodLn As New Ing_prodLn
    Private obj_Op_simpesLn As New Op_simpesLn
    Private objOpSimplesLn As New Op_simpesLn
    Public activas As Integer
    Public paros As Integer
    Public inactivas As Integer
    Dim fec_c, turno, fecha As String
    Dim maquina As Integer = 0
    Dim fechahoy As Date
    Dim cod_orden As Integer = 0
    Dim id_detalle As Integer = 0
    Dim dt_paros As DataTable



    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabelTimer.Text -= 1


        If (LabelTimer.Text = "0") Then
            activas = 0
            paros = 0
            inactivas = 0

            ValidarEstados()


            '' RESETEAMOS EL TIEMPO
            LabelTimer.Text = 2
        End If

    End Sub


    'Private Sub ValidarEstados()
    '    ''ACA ACTUALIZAMOS TODOS LAS IMAGENES SEGUN CONDICION EN LA BD          
    '    Dim sql As String = ""
    '    Dim estado As String = ""
    '    Dim paro As String = ""

    '    'verificar la maquina1
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2101)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT Paro FROM dbo.J_Maquinas WHERE (codigoM = 2101)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")

    '    If (estado.Contains("A")) Then
    '        PictureBoxTf1.Image = My.Resources.led_verde
    '        PictureBoxTf1.Refresh()
    '        activas += 1
    '        txtparo1.Visible = False

    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf1.Image = My.Resources.led_naranja
    '        PictureBoxTf1.Refresh()
    '        paros += 1
    '        txtparo1.Text = paro
    '        txtparo1.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo1.Text = "Aseo"
    '            Case 1
    '                txtparo1.Text = "Cambio de programa"
    '            Case 2
    '                txtparo1.Text = "Reviente"
    '            Case 3
    '                txtparo1.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo1.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo1.Text = "Enredos"
    '            Case 6
    '                txtparo1.Text = "Daño electrico"
    '            Case 7
    '                txtparo1.Text = "Daño mecanico"
    '            Case 8
    '                txtparo1.Text = "otros"
    '            Case 9
    '                txtparo1.Text = "Alimentacion"
    '            Case 10
    '                txtparo1.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo1.Text = "Abastecimiento"
    '            Case 12
    '                txtparo1.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo1.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo1.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo1.Text = "Ausencia de operario"
    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf1.Image = My.Resources.led_rojo
    '        PictureBoxTf1.Refresh()
    '        inactivas += 1
    '        txtparo1.Visible = False
    '    End If
    '    PictureBoxTf1.Refresh()

    '    'verificar la maquina2
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2102)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2102)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf2.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo2.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf2.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo2.Text = paro
    '        txtparo2.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo2.Text = "Aseo"
    '            Case 1
    '                txtparo2.Text = "Cambio de programa"
    '            Case 2
    '                txtparo2.Text = "Reviente"
    '            Case 3
    '                txtparo2.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo2.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo2.Text = "Enredos"
    '            Case 6
    '                txtparo2.Text = "Daño electrico"
    '            Case 7
    '                txtparo2.Text = "Daño mecanico"
    '            Case 8
    '                txtparo2.Text = "otros"
    '            Case 9
    '                txtparo2.Text = "Alimentacion"
    '            Case 10
    '                txtparo2.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo2.Text = "Abastecimiento"
    '            Case 12
    '                txtparo2.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo2.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo2.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo2.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf2.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo2.Visible = False
    '    End If

    '    'verificar la maquina3
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2103)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2103)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf3.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo3.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf3.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo3.Text = paro
    '        txtparo3.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo3.Text = "Aseo"
    '            Case 1
    '                txtparo3.Text = "Cambio de programa"
    '            Case 2
    '                txtparo3.Text = "Reviente"
    '            Case 3
    '                txtparo3.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo3.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo3.Text = "Enredos"
    '            Case 6
    '                txtparo3.Text = "Daño electrico"
    '            Case 7
    '                txtparo3.Text = "Daño mecanico"
    '            Case 8
    '                txtparo3.Text = "otros"
    '            Case 9
    '                txtparo3.Text = "Alimentacion"
    '            Case 10
    '                txtparo3.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo3.Text = "Abastecimiento"
    '            Case 12
    '                txtparo3.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo3.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo3.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo3.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf3.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo3.Visible = False
    '    End If

    '    'verificar la maquina4
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2104)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2104)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf4.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo4.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf4.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo4.Text = paro
    '        txtparo4.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo4.Text = "Aseo"
    '            Case 1
    '                txtparo4.Text = "Cambio de programa"
    '            Case 2
    '                txtparo4.Text = "Reviente"
    '            Case 3
    '                txtparo4.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo4.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo4.Text = "Enredos"
    '            Case 6
    '                txtparo4.Text = "Daño electrico"
    '            Case 7
    '                txtparo4.Text = "Daño mecanico"
    '            Case 8
    '                txtparo4.Text = "otros"
    '            Case 9
    '                txtparo4.Text = "Alimentacion"
    '            Case 10
    '                txtparo4.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo4.Text = "Abastecimiento"
    '            Case 12
    '                txtparo4.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo4.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo4.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo4.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf4.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo4.Visible = False
    '    End If

    '    'verificar la maquina5
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2105)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2105)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf5.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo5.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf5.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo5.Text = paro
    '        txtparo5.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo5.Text = "Aseo"
    '            Case 1
    '                txtparo5.Text = "Cambio de programa"
    '            Case 2
    '                txtparo5.Text = "Reviente"
    '            Case 3
    '                txtparo5.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo5.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo5.Text = "Enredos"
    '            Case 6
    '                txtparo5.Text = "Daño electrico"
    '            Case 7
    '                txtparo5.Text = "Daño mecanico"
    '            Case 8
    '                txtparo5.Text = "otros"
    '            Case 9
    '                txtparo5.Text = "Alimentacion"
    '            Case 10
    '                txtparo5.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo5.Text = "Abastecimiento"
    '            Case 12
    '                txtparo5.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo5.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo5.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo5.Text = "Ausencia de operario"

    '        End Select


    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf5.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo5.Visible = False
    '    End If

    '    'verificar la maquina6
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2116)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2116)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf6.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo6.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf6.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo6.Text = paro
    '        txtparo6.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo6.Text = "Aseo"
    '            Case 1
    '                txtparo6.Text = "Cambio de programa"
    '            Case 2
    '                txtparo6.Text = "Reviente"
    '            Case 3
    '                txtparo6.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo6.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo6.Text = "Enredos"
    '            Case 6
    '                txtparo6.Text = "Daño electrico"
    '            Case 7
    '                txtparo6.Text = "Daño mecanico"
    '            Case 8
    '                txtparo6.Text = "otros"
    '            Case 9
    '                txtparo6.Text = "Alimentacion"
    '            Case 10
    '                txtparo6.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo6.Text = "Abastecimiento"
    '            Case 12
    '                txtparo6.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo6.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo6.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo6.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf6.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo6.Visible = False
    '    End If

    '    'verificar la maquina7
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2118)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2118)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf7.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo7.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf7.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo7.Text = paro
    '        txtparo7.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo7.Text = "Aseo"
    '            Case 1
    '                txtparo7.Text = "Cambio de programa"
    '            Case 2
    '                txtparo7.Text = "Reviente"
    '            Case 3
    '                txtparo7.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo7.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo7.Text = "Enredos"
    '            Case 6
    '                txtparo7.Text = "Daño electrico"
    '            Case 7
    '                txtparo7.Text = "Daño mecanico"
    '            Case 8
    '                txtparo7.Text = "otros"
    '            Case 9
    '                txtparo7.Text = "Alimentacion"
    '            Case 10
    '                txtparo7.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo7.Text = "Abastecimiento"
    '            Case 12
    '                txtparo7.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo7.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo7.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo7.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf7.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo7.Visible = False
    '    End If

    '    'verificar la maquina8
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2119)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2119)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf8.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo8.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf8.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo8.Text = paro
    '        txtparo8.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo8.Text = "Aseo"
    '            Case 1
    '                txtparo8.Text = "Cambio de programa"
    '            Case 2
    '                txtparo8.Text = "Reviente"
    '            Case 3
    '                txtparo8.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo8.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo8.Text = "Enredos"
    '            Case 6
    '                txtparo8.Text = "Daño electrico"
    '            Case 7
    '                txtparo8.Text = "Daño mecanico"
    '            Case 8
    '                txtparo8.Text = "otros"
    '            Case 9
    '                txtparo8.Text = "Alimentacion"
    '            Case 10
    '                txtparo8.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo8.Text = "Abastecimiento"
    '            Case 12
    '                txtparo8.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo8.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo8.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo8.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf8.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo8.Visible = False
    '    End If

    '    'verificar la maquina9
    '    sql = "SELECT Estado FROM dbo.J_Maquinas WHERE (codigoM = 2121)"
    '    estado = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    sql = "SELECT paro FROM dbo.J_Maquinas WHERE (codigoM = 2121)"
    '    paro = obj_Ing_prodLn.listar_Estado(sql, "PRODUCCION")
    '    If (estado.Contains("A")) Then
    '        PictureBoxTf9.Image = My.Resources.led_verde
    '        activas += 1
    '        txtparo9.Visible = False
    '    End If
    '    If (estado.Contains("P")) Then
    '        PictureBoxTf9.Image = My.Resources.led_naranja
    '        paros += 1
    '        txtparo9.Text = paro
    '        txtparo9.Visible = True
    '        Select Case paro
    '            Case 0
    '                txtparo9.Text = "Aseo"
    '            Case 1
    '                txtparo9.Text = "Cambio de programa"
    '            Case 2
    '                txtparo9.Text = "Reviente"
    '            Case 3
    '                txtparo9.Text = "Cambio de hilera"
    '            Case 4
    '                txtparo9.Text = "Soldar materia prima"
    '            Case 5
    '                txtparo9.Text = "Enredos"
    '            Case 6
    '                txtparo9.Text = "Daño electrico"
    '            Case 7
    '                txtparo9.Text = "Daño mecanico"
    '            Case 8
    '                txtparo9.Text = "otros"
    '            Case 9
    '                txtparo9.Text = "Alimentacion"
    '            Case 10
    '                txtparo9.Text = "Probelmas materia prima"
    '            Case 11
    '                txtparo9.Text = "Abastecimiento"
    '            Case 12
    '                txtparo9.Text = "Capacitacion y/o reunion"
    '            Case 13
    '                txtparo9.Text = "Mantenimiento programado"
    '            Case 14
    '                txtparo9.Text = "Alistamiento inicio turno"
    '            Case 15
    '                txtparo9.Text = "Ausencia de operario"

    '        End Select
    '    End If
    '    If (estado.Contains("I")) Then
    '        PictureBoxTf9.Image = My.Resources.led_rojo
    '        inactivas += 1
    '        txtparo9.Visible = False
    '    End If

    '    LabelActivas.Text = (activas.ToString)
    '    LabelParos.Text = (paros.ToString)
    '    LabelInactivas.Text = (inactivas.ToString)
    'End Sub

    Private Sub cargarDetalle()

        Dim sin_prod As Boolean = False
        'fechahoy = objOpSimplesLn.cambiarFormatoFecha(Convert.ToDateTime(fechahoy))
        Dim dt_Detalle As DataTable
        Dim sql_detalle_maquinas As String = "SELECT        TOP (100) PERCENT dbo.J_orden_prod_tef.id_maquina, dbo.J_det_orden_prod.cod_orden, dbo.J_det_orden_prod.id_detalle, dbo.J_det_orden_prod.operario, CORSAN.dbo.V_nom_personal_Activo_con_maquila.nombres, 
                         dbo.J_det_orden_prod.id_turno, dbo.J_det_orden_prod.min_trab, dbo.J_det_orden_prod.velocidad, dbo.J_det_orden_prod.cerrado, dbo.J_det_orden_prod.fec_hora_ini, dbo.J_det_orden_prod.fec_hora_fin, 
                         dbo.J_det_orden_prod.notas, dbo.J_det_orden_prod.estadoMaq
FROM            dbo.J_det_orden_prod INNER JOIN
                         dbo.J_orden_prod_tef ON dbo.J_det_orden_prod.cod_orden = dbo.J_orden_prod_tef.consecutivo INNER JOIN
                         CORSAN.dbo.V_nom_personal_Activo_con_maquila ON dbo.J_det_orden_prod.operario = CORSAN.dbo.V_nom_personal_Activo_con_maquila.nit
WHERE        (dbo.J_det_orden_prod.cerrado IS NULL)  AND (dbo.J_orden_prod_tef.id_maquina = " & maquina & ") AND (dbo.J_det_orden_prod.fec_hora_ini >= '" & DateTime.Now.ToString("yyyy/MM/dd") & "')
ORDER BY dbo.J_orden_prod_tef.id_maquina"

        dt_Detalle = obj_Op_simpesLn.listar_datatable(sql_detalle_maquinas, "PRODUCCION")

        'dtg_detalle_maquina.DataSource = dt_Detalle

        If IsDBNull(dt_Detalle) Then
            txtnombre.Text = "Sin operario"
            txtturno.Text = "Sin turno"
            txtorden.Text = "Sin orden"
            txtdetalle.Text = "Sin detalle"
            txtinicio.Text = "Sin iniciar"
            txtfin.Text = "Turno en proceso"
        Else
            For i = 0 To dt_Detalle.Rows.Count - 1
                If Not IsDBNull(dt_Detalle.Rows(i).Item("nombres")) Then
                    txtnombre.Text = dt_Detalle.Rows(i).Item("nombres")
                Else
                    txtnombre.Text = "Sin operario"
                End If
                If Not IsDBNull(dt_Detalle.Rows(i).Item("id_turno")) Then
                    txtturno.Text = dt_Detalle.Rows(i).Item("id_turno")
                Else
                    txtturno.Text = "Sin turno"
                End If
                If Not IsDBNull(dt_Detalle.Rows(i).Item("cod_orden")) Then
                    txtorden.Text = dt_Detalle.Rows(i).Item("cod_orden")
                    cod_orden = dt_Detalle.Rows(i).Item("cod_orden")
                Else
                    txtorden.Text = "Sin orden"
                End If
                If Not IsDBNull(dt_Detalle.Rows(i).Item("id_detalle")) Then
                    txtdetalle.Text = dt_Detalle.Rows(i).Item("id_detalle")
                    id_detalle = dt_Detalle.Rows(i).Item("id_detalle")
                Else
                    txtdetalle.Text = "Sin detalle"
                End If
                If Not IsDBNull(dt_Detalle.Rows(i).Item("fec_hora_ini")) Then
                    txtinicio.Text = dt_Detalle.Rows(i).Item("fec_hora_ini")
                Else
                    txtinicio.Text = "Sin iniciar"
                    sin_prod = True
                End If
                If Not IsDBNull(dt_Detalle.Rows(i).Item("fec_hora_fin")) Then
                    txtfin.Text = dt_Detalle.Rows(i).Item("fec_hora_fin")
                Else
                    If sin_prod Then
                        txtfin.Text = "Sin iniciar"
                    Else
                        txtfin.Text = "Turno en proceso"
                    End If
                End If
            Next
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        maquina = 2101
        cargarDetalle()
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        maquina = 2102
        cargarDetalle()
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        maquina = 2103
        cargarDetalle()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        maquina = 2104
        cargarDetalle()
    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        maquina = 2105
        cargarDetalle()
    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        maquina = 2116
        cargarDetalle()
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        maquina = 2118
        cargarDetalle()
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        maquina = 2119
        cargarDetalle()
    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        maquina = 2121
        cargarDetalle()
    End Sub

    Private Sub checkparos_CheckedChanged(sender As Object, e As Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs) Handles checkparos.CheckedChanged
        If (checkparos.Checked) Then

            If (cod_orden > 0 And id_detalle > 0) Then
                'cargar paros asociados a la orden y al detalle
                Dim sql_paros As String = "SELECT  cod_orden, cod_det, num_paro, h_ini, h_fin, total FROM dbo.J_det_orden_paros WHERE (cod_orden = " & cod_orden & ") and (cod_det = " & id_detalle & " )"
                dt_paros = obj_Op_simpesLn.listar_datatable(sql_paros, "PRODUCCION")
                'se agrega el datagridview
                dtg_detalle_maquina.DataSource = dt_paros
            End If


            dtg_detalle_maquina.Visible = True
        Else
            dtg_detalle_maquina.Visible = False
        End If
    End Sub

    Private Sub ValidarEstados()
        ''ACA ACTUALIZAMOS TODOS LAS IMAGENES SEGUN CONDICION EN LA BD          
        Dim sql As String = ""
        Dim estado As String = ""
        Dim paro As String = ""
        Dim dt As DataTable


        Dim sql_estado_maquinas As String = "SELECT dbo.J_Maquinas.codigoM, dbo.J_Maquinas.Estado, dbo.J_Maquinas.Paro, dbo.D_paros_tipos_tref.descripcion
FROM            dbo.J_Maquinas INNER JOIN
                         dbo.D_paros_tipos_tref ON dbo.J_Maquinas.Paro = dbo.D_paros_tipos_tref.id
WHERE        (dbo.J_Maquinas.codigoM IN (2101, 2102, 2103, 2104, 2105, 2116, 2118, 2119, 2121))"

        dt = obj_Op_simpesLn.listar_datatable(sql_estado_maquinas, "PRODUCCION")

        ''recorremos para sacar los estados
        For i = 0 To dt.Rows.Count - 1
            Select Case dt.Rows(i).Item("codigoM")
                Case 2101
                    'trefiladora 1
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf1.Image = My.Resources.led_verde
                            PictureBoxTf1.Refresh()
                            activas += 1
                            txtparo1.Visible = False
                        Case "P"
                            PictureBoxTf1.Image = My.Resources.led_naranja
                            PictureBoxTf1.Refresh()
                            paros += 1
                            txtparo1.Text = paro
                            txtparo1.Visible = True
                            txtparo1.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf1.Image = My.Resources.led_rojo
                            PictureBoxTf1.Refresh()
                            inactivas += 1
                            txtparo1.Visible = False
                    End Select
                    PictureBoxTf1.Refresh()
                Case 2102
                    'trefiladora 2
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf2.Image = My.Resources.led_verde
                            activas += 1
                            txtparo2.Visible = False
                        Case "P"
                            PictureBoxTf2.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo2.Text = paro
                            txtparo2.Visible = True
                            txtparo2.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf2.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo2.Visible = False
                    End Select
                Case 2103
                    'trefiladora 3
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf3.Image = My.Resources.led_verde
                            activas += 1
                            txtparo3.Visible = False
                        Case "P"
                            PictureBoxTf3.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo3.Text = paro
                            txtparo3.Visible = True
                            txtparo3.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf3.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo3.Visible = False
                    End Select
                Case 2104
                    'trefiladora 4
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf4.Image = My.Resources.led_verde
                            activas += 1
                            txtparo4.Visible = False
                        Case "P"
                            PictureBoxTf4.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo4.Text = paro
                            txtparo4.Visible = True
                            txtparo4.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf4.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo4.Visible = False
                    End Select
                Case 2105
                    'trefiladora 5
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf5.Image = My.Resources.led_verde
                            activas += 1
                            txtparo5.Visible = False
                        Case "P"
                            PictureBoxTf5.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo5.Text = paro
                            txtparo5.Visible = True
                            txtparo5.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf5.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo5.Visible = False
                    End Select
                Case 2116
                    'trefiladora 6
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf6.Image = My.Resources.led_verde
                            activas += 1
                            txtparo6.Visible = False
                        Case "P"
                            PictureBoxTf6.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo6.Text = paro
                            txtparo6.Visible = True
                            txtparo6.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf6.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo6.Visible = False
                    End Select
                Case 2118
                    'trefiladora 7
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf7.Image = My.Resources.led_verde
                            activas += 1
                            txtparo7.Visible = False
                        Case "P"
                            PictureBoxTf7.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo7.Text = paro
                            txtparo7.Visible = True
                            txtparo7.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf7.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo7.Visible = False
                    End Select
                Case 2119
                    'trefiladora 8
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf8.Image = My.Resources.led_verde
                            activas += 1
                            txtparo8.Visible = False
                        Case "P"
                            PictureBoxTf8.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo8.Text = paro
                            txtparo8.Visible = True
                            txtparo8.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf8.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo8.Visible = False
                    End Select
                Case 2121
                    'trefiladora 9
                    Select Case dt.Rows(i).Item("Estado")
                        Case "A"
                            PictureBoxTf9.Image = My.Resources.led_verde
                            activas += 1
                            txtparo9.Visible = False
                        Case "P"
                            PictureBoxTf9.Image = My.Resources.led_naranja
                            paros += 1
                            txtparo9.Text = paro
                            txtparo9.Visible = True
                            txtparo9.Text = dt.Rows(i).Item("descripcion")
                        Case "I"
                            PictureBoxTf9.Image = My.Resources.led_rojo
                            inactivas += 1
                            txtparo9.Visible = False
                    End Select
            End Select
        Next
        LabelActivas.Text = (activas.ToString)
        LabelParos.Text = (paros.ToString)
        LabelInactivas.Text = (inactivas.ToString)
    End Sub


    Private Sub DassboardMaquinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        checkparos.Checked = False

        fec_c = "" & System.DateTime.Now.Hour & ":" & System.DateTime.Now.Minute & ""
        fecha = "" & System.DateTime.Now & ""
        fechahoy = Now
        txtfecha.Text = fecha
        If CDate(fec_c) >= "05:50" And CDate(fec_c) <= "13:49" Then
            turno = "1"
        ElseIf CDate(fec_c) >= "13:50" And CDate(fec_c) <= "21:49" Then
            turno = "2"
        ElseIf CDate(fec_c) >= "21:50" Or CDate(fec_c) <= "5:49" Then
            turno = "3"
        End If



    End Sub


End Class