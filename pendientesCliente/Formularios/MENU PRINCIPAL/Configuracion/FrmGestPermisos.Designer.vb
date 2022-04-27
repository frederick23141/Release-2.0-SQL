<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestPermisos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGestPermisos))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro permisos", 31, 31)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro módulos", 32, 32)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro operaciones transacción", 33, 33)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestros", 30, 30, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar permisos", 34, 34)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar correo entrate y saliente", 35, 35)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria de cambios", 36, 36)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar usuarios", 37, 37)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vendedores asociados a un coordinador", 38, 38)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cerrar aplicaciones en una ruta", 39, 39)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cerrar forzado", 40, 40)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manuales", 41, 41)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acerca de", 42, 42)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nodo0")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Configuración", 15, 15, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estado client vend", 45, 45)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Información clientes", 46, 46)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trazabilidad clientes atendidos", 47, 47)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo de consulta de terceros", 48, 48)
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Clientes", 44, 44, New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Análisis pendientes", 51, 51)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria de pedidos", 52, 52)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pendientes por ruta", 53, 53)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento de pendientes", 54, 54)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo de consulta(PENDIENTES)", 48, 48)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe pendientes")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pendientes", 50, 50, New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Análisis de ventas por linea de producción", 56, 56)
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Análisis valor kilo", 57, 57)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acumulado ventas", 58, 58)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Acum vtas vend", 59, 59)
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Principales clientes", 60, 60)
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Precios por debajo de", 61, 61)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Programacion correrias", 62, 62)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas cliente linea prod", 63, 63)
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas cliente por ciudad", 64, 64)
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas client prod", 65, 65)
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas por zona", 66, 66)
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas cliente linea de producción (por mes)", 47, 47)
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo  de consultas(Ventas)", 48, 48)
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ventas", 55, 55, New System.Windows.Forms.TreeNode() {TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39, TreeNode40})
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo  de consultas(Cartera)", 48, 48)
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Fecha vencimiento cartera", 68, 68)
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cartera", 67, 67, New System.Windows.Forms.TreeNode() {TreeNode42, TreeNode43})
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo  de consultas(Recaudos)", 48, 48)
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recaudos", 69, 69, New System.Windows.Forms.TreeNode() {TreeNode45})
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Super módulo de consulta Costos por zona", 48, 48)
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gastos por zona", 70, 70, New System.Windows.Forms.TreeNode() {TreeNode47})
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ajuste contabilidad", 72, 72)
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contabilidad", 71, 71, New System.Windows.Forms.TreeNode() {TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes", 49, 49, New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode27, TreeNode41, TreeNode44, TreeNode46, TreeNode48, TreeNode50})
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingreso ventas", 73, 73)
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pendientes problema", 74, 74)
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seg vendedor", 75, 75)
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cartera", 76, 76)
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pendientes", 77, 77)
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Despachos", 78, 78)
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movil")
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingreso ventas", 73, 73, New System.Windows.Forms.TreeNode() {TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57, TreeNode58})
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar", 80, 80)
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto ventas", 79, 79)
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto ventas", 79, 79, New System.Windows.Forms.TreeNode() {TreeNode60, TreeNode61})
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar ppto rec", 80, 80)
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de recaudo", 81, 81)
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto recaudo", 81, 81, New System.Windows.Forms.TreeNode() {TreeNode63, TreeNode64})
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seg vendedores", 47, 47)
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seg presupuesto", 75, 75)
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seg Lineas", 75, 75)
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Anticipos", 36, 36)
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento de presupuestos (MES)", 48, 48)
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento vendedores", 47, 47, New System.Windows.Forms.TreeNode() {TreeNode66, TreeNode67, TreeNode68, TreeNode69, TreeNode70})
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Quejas y reclamos", 83, 83)
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Encuesta clientes nacionales", 84, 84)
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar encuestas", 80, 80)
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SAC", 82, 82, New System.Windows.Forms.TreeNode() {TreeNode72, TreeNode73, TreeNode74})
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reglas", 86, 86)
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Liquidar comisiones (informe)", 87, 87)
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comisiones", 85, 85, New System.Windows.Forms.TreeNode() {TreeNode76, TreeNode77})
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cambiar Cart-Pend-Terceros de vendedor", 36, 36)
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Admisnistrar cambios", 15, 15, New System.Windows.Forms.TreeNode() {TreeNode79})
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestion de Documentación", 88, 88)
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Oficinas", 43, 43, New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode59, TreeNode62, TreeNode65, TreeNode71, TreeNode75, TreeNode78, TreeNode80, TreeNode81})
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar desperdicios", 123, 123)
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventarios de metrología", 124, 124)
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ambiental", 122, 122, New System.Windows.Forms.TreeNode() {TreeNode83, TreeNode84})
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recocido", 96, 96)
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte Inspeccion calidad", 149, 149)
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Calidad", 95, 95, New System.Windows.Forms.TreeNode() {TreeNode86, TreeNode87})
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Puntilleria", 97, 97)
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Púas", 97, 97)
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Galvanizado(forma1)solo consultas", 97, 97)
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Galvanizado (forma2)", 97, 97)
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trefilación (Forma 2)", 97, 97)
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trefilación (Forma 3)", 97, 97)
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pulimiento(tambores)", 97, 97)
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Galvanizado por baches", 97, 97)
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recocido", 97, 97)
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tornilleria", 97, 97)
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tratamientos termicos (Temple)", 97, 97)
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Empaque de puntilleria", 126, 126)
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Transacción manual DMS-SPIC", 125, 125)
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingreso de producción", 97, 97, New System.Windows.Forms.TreeNode() {TreeNode89, TreeNode90, TreeNode91, TreeNode92, TreeNode93, TreeNode94, TreeNode95, TreeNode96, TreeNode97, TreeNode98, TreeNode99, TreeNode100, TreeNode101})
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar certificados historicos", 5, 5)
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar certificado de calidad", 98, 98)
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro fichas técnicas", 99, 99)
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Certificados de calidad", 98, 98, New System.Windows.Forms.TreeNode() {TreeNode103, TreeNode104, TreeNode105})
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Pendientes producción", 100, 100)
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Historico ventas", 101, 101)
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Movimiento inventario", 102, 102)
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Eficiencias")
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar transacciones Dms", 5, 5)
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trazabilidad de transacciones", 127, 127)
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de máximos y minimos", 127, 127)
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entradas-salidas-inventarios", 127, 127)
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Entradas_salidas_DIARIO", 128, 128)
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informes", 49, 49, New System.Windows.Forms.TreeNode() {TreeNode106, TreeNode107, TreeNode108, TreeNode109, TreeNode110, TreeNode111, TreeNode112, TreeNode113, TreeNode114, TreeNode115})
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar transacciones sin stock", 104, 104)
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Traslado de bodega (handheld)", 105, 105)
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro Transaccion HandHeld", 106, 106)
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Módulo traslados de bodega", 103, 103, New System.Windows.Forms.TreeNode() {TreeNode117, TreeNode118, TreeNode119})
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Nuevos repuestos", 108, 108)
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud de correción", 109, 109)
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mantenimiento", 107, 107, New System.Windows.Forms.TreeNode() {TreeNode121, TreeNode122})
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de producción", 110, 110)
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento de presupuesto de producción", 127, 127)
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Diferencia Trefilacion", 111, 111)
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de producción", 110, 110, New System.Windows.Forms.TreeNode() {TreeNode124, TreeNode125, TreeNode126})
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de articulos", 113, 113)
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de articulos", 113, 113, New System.Windows.Forms.TreeNode() {TreeNode128})
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto", 114, 114)
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento presupuesto de gastos y articulos", 127, 127)
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Presupuesto de gastos y articulos", 112, 112, New System.Windows.Forms.TreeNode() {TreeNode129, TreeNode130, TreeNode131})
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar tiquetes terminado", 116, 116)
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar planilla separe", 117, 117)
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar tornilleria", 115, 115, New System.Windows.Forms.TreeNode() {TreeNode133, TreeNode134})
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salida materia de prima (2-11 y 11-2)", 129, 129)
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta materia prima (2-11 y 11-2)", 136, 136)
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de produción galv", 130, 130)
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe producción galvanizado", 49, 49)
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe estado de rollos", 135, 135)
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bobinas detenidas", 131, 131)
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiempo trabajo", 132, 132)
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Resumen galvanizado", 133, 133)
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de paros", 134, 134)
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Galvanizado", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode136, TreeNode137, TreeNode138, TreeNode139, TreeNode140, TreeNode141, TreeNode142, TreeNode143, TreeNode144})
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar inventarios fisicos", 119, 119)
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria Inventario", 127, 127)
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inventarios fisicos", 119, 119, New System.Windows.Forms.TreeNode() {TreeNode146, TreeNode147})
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitar materia prima", 35, 35)
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar solicitudes", 5, 5)
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de producción", 130, 130)
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria Puntilleria", 127, 127)
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Puntilleria", 121, 121, New System.Windows.Forms.TreeNode() {TreeNode149, TreeNode150, TreeNode151, TreeNode152})
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitar materia prima", 35, 35)
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar solicitudes", 5, 5)
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de produccion Recocido", 130, 130)
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria Recocido", 127, 127)
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria Tref-Rec", 127, 127)
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Copia tiquete recocido", 137, 137)
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiquete no conforme", 92, 92)
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recocido", 96, 96, New System.Windows.Forms.TreeNode() {TreeNode154, TreeNode155, TreeNode156, TreeNode157, TreeNode158, TreeNode159, TreeNode160})
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitar materia prima", 35, 35)
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar solicitudes", 5, 5)
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Orden de producción operario", 130, 130)
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crear orden puas", 120, 120)
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Producción de puas", 71, 71)
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de paros púas", 134, 134)
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alambre de Puas", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode162, TreeNode163, TreeNode164, TreeNode165, TreeNode166, TreeNode167})
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Crear proyecto", 69, 69)
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar proyectos", 136, 136)
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar proyectos", 127, 127, New System.Windows.Forms.TreeNode() {TreeNode169, TreeNode170})
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud scal", 138, 138)
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud scae", 138, 138)
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud sar", 138, 138)
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitud sav", 138, 138)
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta de pedidos scal", 136, 136)
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta de pedidos scae", 136, 136)
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta de pedidos sar", 136, 136)
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta de pedidos sav", 136, 136)
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consumos scal,scae,sar y sav", 138, 138, New System.Windows.Forms.TreeNode() {TreeNode172, TreeNode173, TreeNode174, TreeNode175, TreeNode176, TreeNode177, TreeNode178, TreeNode179})
        Dim TreeNode181 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ordenes de producción", 130, 130)
        Dim TreeNode182 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria de alambres", 127, 127)
        Dim TreeNode183 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar tiquete tref NC", 139, 139)
        Dim TreeNode184 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar linea de producción", 94, 94)
        Dim TreeNode185 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Limite consumos alambron", 125, 125)
        Dim TreeNode186 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Velocidades de codigos", 141, 141)
        Dim TreeNode187 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Saldo alambron", 114, 114)
        Dim TreeNode188 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Actualizar alambron", 142, 142)
        Dim TreeNode189 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta tref forma 3", 136, 136)
        Dim TreeNode190 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consumir Tiquetes Trefilacion", 139, 139)
        Dim TreeNode191 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Detalle paros tref", 153, 153)
        Dim TreeNode192 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Trefilación", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode181, TreeNode182, TreeNode183, TreeNode184, TreeNode185, TreeNode186, TreeNode187, TreeNode188, TreeNode189, TreeNode190, TreeNode191})
        Dim TreeNode193 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consumo de tornileria", 115, 115)
        Dim TreeNode194 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tornilleria", 115, 115, New System.Windows.Forms.TreeNode() {TreeNode193})
        Dim TreeNode195 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("consumo y producción de tref", 138, 138)
        Dim TreeNode196 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("consumo y producción de punt", 138, 138)
        Dim TreeNode197 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("consumo y produccion galv", 138, 138)
        Dim TreeNode198 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seguimiento de consumos", 138, 138, New System.Windows.Forms.TreeNode() {TreeNode195, TreeNode196, TreeNode197})
        Dim TreeNode199 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cambiar centro (Planta)", 142, 142)
        Dim TreeNode200 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria", 127, 127)
        Dim TreeNode201 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Producción", 94, 94, New System.Windows.Forms.TreeNode() {TreeNode85, TreeNode88, TreeNode102, TreeNode116, TreeNode120, TreeNode123, TreeNode127, TreeNode132, TreeNode135, TreeNode145, TreeNode148, TreeNode153, TreeNode161, TreeNode168, TreeNode171, TreeNode180, TreeNode192, TreeNode194, TreeNode198, TreeNode199, TreeNode200})
        Dim TreeNode202 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe personal Dane", 138, 138)
        Dim TreeNode203 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe Personal Activo", 138, 138)
        Dim TreeNode204 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Información de empleados", 138, 138)
        Dim TreeNode205 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de incapacidades y ausentismos", 137, 137)
        Dim TreeNode206 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Días de vacaciones", 143, 143)
        Dim TreeNode207 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiempos laborados", 132, 132)
        Dim TreeNode208 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Rotación del personal", 142, 142)
        Dim TreeNode209 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registrar personal maquilas", 45, 45)
        Dim TreeNode210 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe temporales", 137, 137)
        Dim TreeNode211 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal maquilas", 45, 45, New System.Windows.Forms.TreeNode() {TreeNode209, TreeNode210})
        Dim TreeNode212 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Procesar marcaciones", 141, 141)
        Dim TreeNode213 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Programación de turnos", 71, 71)
        Dim TreeNode214 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar periodos de corte de novedades", 107, 107)
        Dim TreeNode215 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de inconsistencia en marcaciones", 127, 127)
        Dim TreeNode216 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar compromisos", 71, 71)
        Dim TreeNode217 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Informe de novedades pendientes", 71, 71)
        Dim TreeNode218 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal en Corsan", 138, 138)
        Dim TreeNode219 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reloj", 132, 132, New System.Windows.Forms.TreeNode() {TreeNode211, TreeNode212, TreeNode213, TreeNode214, TreeNode215, TreeNode216, TreeNode217, TreeNode218})
        Dim TreeNode220 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluacion de desempeño", 125, 125)
        Dim TreeNode221 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar evaluaciónes de desempeño", 136, 136)
        Dim TreeNode222 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Permisos evaluaciones", 52, 52)
        Dim TreeNode223 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluaciones de desempeño", 125, 125, New System.Windows.Forms.TreeNode() {TreeNode220, TreeNode221, TreeNode222})
        Dim TreeNode224 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Buzon de Sugerencias", 34, 34)
        Dim TreeNode225 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consulta Solicitud de Premios", 52, 52)
        Dim TreeNode226 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar contratistas", 37, 37)
        Dim TreeNode227 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Contratistas", 37, 37, New System.Windows.Forms.TreeNode() {TreeNode226})
        Dim TreeNode228 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Recursos humanos", 44, 44, New System.Windows.Forms.TreeNode() {TreeNode202, TreeNode203, TreeNode204, TreeNode205, TreeNode206, TreeNode207, TreeNode208, TreeNode219, TreeNode223, TreeNode224, TreeNode225, TreeNode227})
        Dim TreeNode229 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar votaciónes", 136, 136)
        Dim TreeNode230 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar grupos votación", 83, 83)
        Dim TreeNode231 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ingresar votación", 140, 140)
        Dim TreeNode232 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administrar votación", 83, 83, New System.Windows.Forms.TreeNode() {TreeNode229, TreeNode230, TreeNode231})
        Dim TreeNode233 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar", 5, 5)
        Dim TreeNode234 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluación", 145, 145)
        Dim TreeNode235 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Graficar evaluaciones", 127, 127)
        Dim TreeNode236 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro proveedor-categoria", 99, 99)
        Dim TreeNode237 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar_tendencias", 86, 86)
        Dim TreeNode238 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Evaluación de proveedores", 145, 145, New System.Windows.Forms.TreeNode() {TreeNode233, TreeNode234, TreeNode235, TreeNode236, TreeNode237})
        Dim TreeNode239 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar solicitud de servicio", 69, 69)
        Dim TreeNode240 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administrar solicitudes de servicios", 120, 120)
        Dim TreeNode241 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar material aut vs reg", 136, 136)
        Dim TreeNode242 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Solicitudes de servicio", 109, 109, New System.Windows.Forms.TreeNode() {TreeNode239, TreeNode240, TreeNode241})
        Dim TreeNode243 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Administrar ordenes de compra", 144, 144)
        Dim TreeNode244 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar orden de compra", 69, 69)
        Dim TreeNode245 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ordenes de compra", 144, 144, New System.Windows.Forms.TreeNode() {TreeNode243, TreeNode244})
        Dim TreeNode246 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar salida de almacen", 147, 147)
        Dim TreeNode247 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar salidas de almacen", 136, 136)
        Dim TreeNode248 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salidas de almacen", 147, 147, New System.Windows.Forms.TreeNode() {TreeNode246, TreeNode247})
        Dim TreeNode249 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salida de alambrón", 118, 118)
        Dim TreeNode250 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar salida de alambrón", 136, 136)
        Dim TreeNode251 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Salidas de alambrón", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode249, TreeNode250})
        Dim TreeNode252 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiquetes de alambrón", 116, 116)
        Dim TreeNode253 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria de ingreso de materia prima", 127, 127)
        Dim TreeNode254 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Planillas de descargue de alambrón", 78, 78)
        Dim TreeNode255 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Menú principal Hand-Held", 105, 105)
        Dim TreeNode256 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inhabilitar tiquetes alambrón", 152, 152)
        Dim TreeNode257 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestión de alambrón", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode252, TreeNode253, TreeNode254, TreeNode255, TreeNode256})
        Dim TreeNode258 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Información estupefacientes", 148, 148)
        Dim TreeNode259 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Estupefacientes", 148, 148, New System.Windows.Forms.TreeNode() {TreeNode258})
        Dim TreeNode260 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Generar tiquetes producto temrinado", 116, 116)
        Dim TreeNode261 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Tiquetes producto terminado", 116, 116, New System.Windows.Forms.TreeNode() {TreeNode260})
        Dim TreeNode262 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Compras", 144, 144, New System.Windows.Forms.TreeNode() {TreeNode238, TreeNode242, TreeNode245, TreeNode248, TreeNode251, TreeNode257, TreeNode259, TreeNode261})
        Dim TreeNode263 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar procedimientos", 136, 136)
        Dim TreeNode264 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar procedimientos", 69, 69)
        Dim TreeNode265 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Maestro cargos", 99, 99)
        Dim TreeNode266 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Auditoria", 127, 127, New System.Windows.Forms.TreeNode() {TreeNode263, TreeNode264, TreeNode265})
        Dim TreeNode267 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cambiar pedido bodega", 36, 36)
        Dim TreeNode268 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Relación factura-pedido-entrega", 90, 90)
        Dim TreeNode269 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Formato impresión etiquetas", 27, 27)
        Dim TreeNode270 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestionar producto no conforme", 10, 10)
        Dim TreeNode271 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Traslado de la  B 2 a la 3", 150, 150)
        Dim TreeNode272 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Control Esatado maquinas", 151, 151)
        Dim TreeNode273 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logistica", 89, 89, New System.Windows.Forms.TreeNode() {TreeNode267, TreeNode268, TreeNode269, TreeNode270, TreeNode271, TreeNode272})
        Me.listaTipoUsu = New System.Windows.Forms.ListBox()
        Me.listPermisosUsuario = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddmodulo = New System.Windows.Forms.Button()
        Me.btnQuitarMod = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'listaTipoUsu
        '
        Me.listaTipoUsu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listaTipoUsu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaTipoUsu.FormattingEnabled = True
        Me.listaTipoUsu.ItemHeight = 16
        Me.listaTipoUsu.Location = New System.Drawing.Point(12, 28)
        Me.listaTipoUsu.Name = "listaTipoUsu"
        Me.listaTipoUsu.Size = New System.Drawing.Size(187, 404)
        Me.listaTipoUsu.TabIndex = 1
        '
        'listPermisosUsuario
        '
        Me.listPermisosUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.listPermisosUsuario.FormattingEnabled = True
        Me.listPermisosUsuario.Items.AddRange(New Object() {""})
        Me.listPermisosUsuario.Location = New System.Drawing.Point(210, 28)
        Me.listPermisosUsuario.Name = "listPermisosUsuario"
        Me.listPermisosUsuario.Size = New System.Drawing.Size(187, 407)
        Me.listPermisosUsuario.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo de usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Permisos del usuario"
        '
        'btnAddmodulo
        '
        Me.btnAddmodulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddmodulo.Location = New System.Drawing.Point(403, 166)
        Me.btnAddmodulo.Name = "btnAddmodulo"
        Me.btnAddmodulo.Size = New System.Drawing.Size(37, 26)
        Me.btnAddmodulo.TabIndex = 39
        Me.btnAddmodulo.Text = "<<"
        Me.btnAddmodulo.UseVisualStyleBackColor = True
        '
        'btnQuitarMod
        '
        Me.btnQuitarMod.Image = CType(resources.GetObject("btnQuitarMod.Image"), System.Drawing.Image)
        Me.btnQuitarMod.Location = New System.Drawing.Point(402, 198)
        Me.btnQuitarMod.Name = "btnQuitarMod"
        Me.btnQuitarMod.Size = New System.Drawing.Size(37, 26)
        Me.btnQuitarMod.TabIndex = 40
        Me.btnQuitarMod.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(443, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Módulos"
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "icoProg.png")
        Me.ImageList2.Images.SetKeyName(1, "1349366316_users.ico")
        Me.ImageList2.Images.SetKeyName(2, "dinero.jpg")
        Me.ImageList2.Images.SetKeyName(3, "est.jpg")
        Me.ImageList2.Images.SetKeyName(4, "usuario1.gif")
        Me.ImageList2.Images.SetKeyName(5, "buscar7.gif")
        Me.ImageList2.Images.SetKeyName(6, "mas1.png")
        Me.ImageList2.Images.SetKeyName(7, "casco.jpg")
        Me.ImageList2.Images.SetKeyName(8, "casco1.jpg")
        Me.ImageList2.Images.SetKeyName(9, "despacho.png")
        Me.ImageList2.Images.SetKeyName(10, "planilla.gif")
        Me.ImageList2.Images.SetKeyName(11, "informe.png")
        Me.ImageList2.Images.SetKeyName(12, "actualizar.png")
        Me.ImageList2.Images.SetKeyName(13, "tool.png")
        Me.ImageList2.Images.SetKeyName(14, "Black_Tools.png")
        Me.ImageList2.Images.SetKeyName(15, "configuracion.png")
        Me.ImageList2.Images.SetKeyName(16, "ficha.png")
        Me.ImageList2.Images.SetKeyName(17, "mobil.ico")
        Me.ImageList2.Images.SetKeyName(18, "ok.png")
        Me.ImageList2.Images.SetKeyName(19, "compras.png")
        Me.ImageList2.Images.SetKeyName(20, "compras1.png")
        Me.ImageList2.Images.SetKeyName(21, "compras2.png")
        Me.ImageList2.Images.SetKeyName(22, "compras4.png")
        Me.ImageList2.Images.SetKeyName(23, "compras5.png")
        Me.ImageList2.Images.SetKeyName(24, "Time_management.png")
        Me.ImageList2.Images.SetKeyName(25, "grafico10.png")
        Me.ImageList2.Images.SetKeyName(26, "ok3.gif")
        Me.ImageList2.Images.SetKeyName(27, "imp.ico")
        Me.ImageList2.Images.SetKeyName(28, "imp.ico")
        Me.ImageList2.Images.SetKeyName(29, "natural.png")
        Me.ImageList2.Images.SetKeyName(30, "maestros.png")
        Me.ImageList2.Images.SetKeyName(31, "maestro_permisos.png")
        Me.ImageList2.Images.SetKeyName(32, "maestro_modulos.png")
        Me.ImageList2.Images.SetKeyName(33, "maestro_operaciones_transaccion.png")
        Me.ImageList2.Images.SetKeyName(34, "gestionar_permisos.png")
        Me.ImageList2.Images.SetKeyName(35, "gestionar_correo_entrante_y_saliente.png")
        Me.ImageList2.Images.SetKeyName(36, "auditoria_de_cambios.png")
        Me.ImageList2.Images.SetKeyName(37, "gestionar_usuarios.png")
        Me.ImageList2.Images.SetKeyName(38, "vendedores_asociados_a_un_coordinador.png")
        Me.ImageList2.Images.SetKeyName(39, "cerrar_aplicaciones_en_una_ruta.png")
        Me.ImageList2.Images.SetKeyName(40, "cerrar_forzado.png")
        Me.ImageList2.Images.SetKeyName(41, "manuales.png")
        Me.ImageList2.Images.SetKeyName(42, "acerca_de.png")
        Me.ImageList2.Images.SetKeyName(43, "oficinas.png")
        Me.ImageList2.Images.SetKeyName(44, "clientes.png")
        Me.ImageList2.Images.SetKeyName(45, "estado_cliente_vend.png")
        Me.ImageList2.Images.SetKeyName(46, "informacion_clientes.png")
        Me.ImageList2.Images.SetKeyName(47, "trazabilidad_clientes_atentidos.png")
        Me.ImageList2.Images.SetKeyName(48, "super_modulo_de_consultas_de_terceros.png")
        Me.ImageList2.Images.SetKeyName(49, "informes.png")
        Me.ImageList2.Images.SetKeyName(50, "pendientes.png")
        Me.ImageList2.Images.SetKeyName(51, "analisis_pendientes.png")
        Me.ImageList2.Images.SetKeyName(52, "auditoria_de_pedidos.png")
        Me.ImageList2.Images.SetKeyName(53, "pendientes_por_ruta.png")
        Me.ImageList2.Images.SetKeyName(54, "seguimiento_pendientes.png")
        Me.ImageList2.Images.SetKeyName(55, "ventas.png")
        Me.ImageList2.Images.SetKeyName(56, "analisis_de_ventas_por_linea_de_produccion.png")
        Me.ImageList2.Images.SetKeyName(57, "analisis_valor_kilo.png")
        Me.ImageList2.Images.SetKeyName(58, "acomulado ventas.png")
        Me.ImageList2.Images.SetKeyName(59, "acum_vtas_vend.png")
        Me.ImageList2.Images.SetKeyName(60, "principales_clientes.png")
        Me.ImageList2.Images.SetKeyName(61, "precios_por_debajo_de.png")
        Me.ImageList2.Images.SetKeyName(62, "programacion_correrias.png")
        Me.ImageList2.Images.SetKeyName(63, "ventas_cliente_linea_prod.png")
        Me.ImageList2.Images.SetKeyName(64, "ventas_cliente_por_ciudad.png")
        Me.ImageList2.Images.SetKeyName(65, "ventas_client_prod.png")
        Me.ImageList2.Images.SetKeyName(66, "ventas_por_zona.png")
        Me.ImageList2.Images.SetKeyName(67, "cartera.png")
        Me.ImageList2.Images.SetKeyName(68, "fecha_vencimiento_cartera.png")
        Me.ImageList2.Images.SetKeyName(69, "recaudos.png")
        Me.ImageList2.Images.SetKeyName(70, "gastos_por_zona.png")
        Me.ImageList2.Images.SetKeyName(71, "contabilidad.png")
        Me.ImageList2.Images.SetKeyName(72, "ajuste_de_contabilidad.png")
        Me.ImageList2.Images.SetKeyName(73, "ingreso_ventas.png")
        Me.ImageList2.Images.SetKeyName(74, "pendientes_problema.png")
        Me.ImageList2.Images.SetKeyName(75, "seguimiento_vendedor.png")
        Me.ImageList2.Images.SetKeyName(76, "cartera.png")
        Me.ImageList2.Images.SetKeyName(77, "pendientes.png")
        Me.ImageList2.Images.SetKeyName(78, "despachos.png")
        Me.ImageList2.Images.SetKeyName(79, "presupuesto_ventas.png")
        Me.ImageList2.Images.SetKeyName(80, "consultarp.png")
        Me.ImageList2.Images.SetKeyName(81, "presupuesto_recaudo.png")
        Me.ImageList2.Images.SetKeyName(82, "sac.png")
        Me.ImageList2.Images.SetKeyName(83, "quejas_y_reclamos.png")
        Me.ImageList2.Images.SetKeyName(84, "encuestas_clientes_nacionales.png")
        Me.ImageList2.Images.SetKeyName(85, "comisiones.png")
        Me.ImageList2.Images.SetKeyName(86, "reglas.png")
        Me.ImageList2.Images.SetKeyName(87, "liquidar_comisiones.png")
        Me.ImageList2.Images.SetKeyName(88, "gestion_de_documentacionp.png")
        Me.ImageList2.Images.SetKeyName(89, "logistica.png")
        Me.ImageList2.Images.SetKeyName(90, "relacion_factura_pedido_entrega.png")
        Me.ImageList2.Images.SetKeyName(91, "formato_impresion_etiquetas.png")
        Me.ImageList2.Images.SetKeyName(92, "gestionar_producto_no_conforme.png")
        Me.ImageList2.Images.SetKeyName(93, "traslado_de_la_B_2_a_la_3.png")
        Me.ImageList2.Images.SetKeyName(94, "produccion.png")
        Me.ImageList2.Images.SetKeyName(95, "calidad.png")
        Me.ImageList2.Images.SetKeyName(96, "recocido.png")
        Me.ImageList2.Images.SetKeyName(97, "ingreso_produccion.png")
        Me.ImageList2.Images.SetKeyName(98, "certificados_de_calidad.png")
        Me.ImageList2.Images.SetKeyName(99, "maestro_fichas_tecnicas.png")
        Me.ImageList2.Images.SetKeyName(100, "pendientes_produccion.png")
        Me.ImageList2.Images.SetKeyName(101, "historico_ventas.png")
        Me.ImageList2.Images.SetKeyName(102, "movimientos_inventario.png")
        Me.ImageList2.Images.SetKeyName(103, "modulo_traslados_de_bodega.png")
        Me.ImageList2.Images.SetKeyName(104, "gestionar_transacciones_sin_stock.png")
        Me.ImageList2.Images.SetKeyName(105, "traslados_de_bodega(handheld).png")
        Me.ImageList2.Images.SetKeyName(106, "maestro_transacion_handheld.png")
        Me.ImageList2.Images.SetKeyName(107, "mantenimiento.png")
        Me.ImageList2.Images.SetKeyName(108, "nuevos_repuestos.png")
        Me.ImageList2.Images.SetKeyName(109, "solicitud_de_correcion.png")
        Me.ImageList2.Images.SetKeyName(110, "presupuesto_de_produccion.png")
        Me.ImageList2.Images.SetKeyName(111, "informe_diferencia_trefilacion.png")
        Me.ImageList2.Images.SetKeyName(112, "presupuesto_de_gastos_y_articulos.png")
        Me.ImageList2.Images.SetKeyName(113, "presupuesto_de_articulos.png")
        Me.ImageList2.Images.SetKeyName(114, "presupuesto.png")
        Me.ImageList2.Images.SetKeyName(115, "gestionar_tornilleria.png")
        Me.ImageList2.Images.SetKeyName(116, "generar_tiquetes_terminado.png")
        Me.ImageList2.Images.SetKeyName(117, "consulta_planilla_separe.png")
        Me.ImageList2.Images.SetKeyName(118, "galvanizado.png")
        Me.ImageList2.Images.SetKeyName(119, "inventaios_fisicos.png")
        Me.ImageList2.Images.SetKeyName(120, "consulta_inventarios_fisicos.png")
        Me.ImageList2.Images.SetKeyName(121, "puntillerias.png")
        Me.ImageList2.Images.SetKeyName(122, "ambiental.png")
        Me.ImageList2.Images.SetKeyName(123, "gestionar_desperdicios.png")
        Me.ImageList2.Images.SetKeyName(124, "inventarios de metereologia.png")
        Me.ImageList2.Images.SetKeyName(125, "transacion_manual_DMS_SPIC.png")
        Me.ImageList2.Images.SetKeyName(126, "empaque_puntilleria.png")
        Me.ImageList2.Images.SetKeyName(127, "trazabilidad_de_transaciones.png")
        Me.ImageList2.Images.SetKeyName(128, "entradas_salidas_diarias.png")
        Me.ImageList2.Images.SetKeyName(129, "salida_materia_prima(2-11 y 11-2).png")
        Me.ImageList2.Images.SetKeyName(130, "orden_de_producion_galv.png")
        Me.ImageList2.Images.SetKeyName(131, "bobinas_detenidas.png")
        Me.ImageList2.Images.SetKeyName(132, "tiempo_trabajo.png")
        Me.ImageList2.Images.SetKeyName(133, "resumen_galvanizado.png")
        Me.ImageList2.Images.SetKeyName(134, "informe_de_paros.png")
        Me.ImageList2.Images.SetKeyName(135, "informe_estado_de_rollos.png")
        Me.ImageList2.Images.SetKeyName(136, "consulta.png")
        Me.ImageList2.Images.SetKeyName(137, "copia_tiquete_recocido.png")
        Me.ImageList2.Images.SetKeyName(138, "person.png")
        Me.ImageList2.Images.SetKeyName(139, "generar_tiquete_nc.png")
        Me.ImageList2.Images.SetKeyName(140, "limite_consumos_alambron.png")
        Me.ImageList2.Images.SetKeyName(141, "velocidades_de_codigos.png")
        Me.ImageList2.Images.SetKeyName(142, "actualizar_saldo_alambron.png")
        Me.ImageList2.Images.SetKeyName(143, "dias_de_vacaciones.png")
        Me.ImageList2.Images.SetKeyName(144, "compras.png")
        Me.ImageList2.Images.SetKeyName(145, "evaluaciones_de_proveedores.png")
        Me.ImageList2.Images.SetKeyName(146, "ordenes_de_compra.png")
        Me.ImageList2.Images.SetKeyName(147, "salidas_de_almacen.png")
        Me.ImageList2.Images.SetKeyName(148, "estupefacientes.png")
        Me.ImageList2.Images.SetKeyName(149, "reporte_inspeccion_calidad.png")
        Me.ImageList2.Images.SetKeyName(150, "traslado_de_la_B_2_a_la_3.png")
        Me.ImageList2.Images.SetKeyName(151, "control_estados_maquinas.png")
        Me.ImageList2.Images.SetKeyName(152, "icons8-eliminar-boleto-48.png")
        Me.ImageList2.Images.SetKeyName(153, "icons8-señal-de-stop-48.png")
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.ItemHeight = 30
        Me.TreeView1.Location = New System.Drawing.Point(449, 28)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 31
        TreeNode1.Name = "nodMaestroPermiso"
        TreeNode1.SelectedImageIndex = 31
        TreeNode1.Text = "Maestro permisos"
        TreeNode2.ImageIndex = 32
        TreeNode2.Name = "nodMaestroModulo"
        TreeNode2.SelectedImageIndex = 32
        TreeNode2.Text = "Maestro módulos"
        TreeNode3.ImageIndex = 33
        TreeNode3.Name = "nodOpTransaccion"
        TreeNode3.SelectedImageIndex = 33
        TreeNode3.Text = "Maestro operaciones transacción"
        TreeNode4.ImageIndex = 30
        TreeNode4.Name = "Raiz_maestros"
        TreeNode4.SelectedImageIndex = 30
        TreeNode4.Text = "Maestros"
        TreeNode5.ImageIndex = 34
        TreeNode5.Name = "nodGestPermisos"
        TreeNode5.SelectedImageIndex = 34
        TreeNode5.Text = "Gestionar permisos"
        TreeNode6.ImageIndex = 35
        TreeNode6.Name = "nodMaeIpCorreos"
        TreeNode6.SelectedImageIndex = 35
        TreeNode6.Text = "Gestionar correo entrate y saliente"
        TreeNode7.ImageIndex = 36
        TreeNode7.Name = "nodAuditCambios"
        TreeNode7.SelectedImageIndex = 36
        TreeNode7.Text = "Auditoria de cambios"
        TreeNode8.ImageIndex = 37
        TreeNode8.Name = "nodGestUsu"
        TreeNode8.SelectedImageIndex = 37
        TreeNode8.Text = "Gestionar usuarios"
        TreeNode9.ImageIndex = 38
        TreeNode9.Name = "nodMaeCoordVend"
        TreeNode9.SelectedImageIndex = 38
        TreeNode9.Text = "Vendedores asociados a un coordinador"
        TreeNode10.ImageIndex = 39
        TreeNode10.Name = "nod_cerrar_por_ruta"
        TreeNode10.SelectedImageIndex = 39
        TreeNode10.Text = "Cerrar aplicaciones en una ruta"
        TreeNode11.ImageIndex = 40
        TreeNode11.Name = "nod_cerrar_for"
        TreeNode11.SelectedImageIndex = 40
        TreeNode11.Text = "Cerrar forzado"
        TreeNode12.ImageIndex = 41
        TreeNode12.Name = "nod_manual"
        TreeNode12.SelectedImageIndex = 41
        TreeNode12.Text = "Manuales"
        TreeNode13.ImageIndex = 42
        TreeNode13.Name = "nod_Acerca_de"
        TreeNode13.SelectedImageIndex = 42
        TreeNode13.Text = "Acerca de"
        TreeNode14.Name = "Nodo0"
        TreeNode14.Text = "Nodo0"
        TreeNode15.ImageIndex = 15
        TreeNode15.Name = "Raiz_config"
        TreeNode15.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode15.SelectedImageIndex = 15
        TreeNode15.Text = "Configuración"
        TreeNode16.ImageIndex = 45
        TreeNode16.Name = "nod_est_clien_vend"
        TreeNode16.SelectedImageIndex = 45
        TreeNode16.Text = "Estado client vend"
        TreeNode17.ImageIndex = 46
        TreeNode17.Name = "nod_info_clientes"
        TreeNode17.SelectedImageIndex = 46
        TreeNode17.Text = "Información clientes"
        TreeNode18.ImageIndex = 47
        TreeNode18.Name = "nod_Trazabilidad_clientes_atendidos"
        TreeNode18.SelectedImageIndex = 47
        TreeNode18.Text = "Trazabilidad clientes atendidos"
        TreeNode19.ImageIndex = 48
        TreeNode19.Name = "nod_super_modulo_consult_terceros"
        TreeNode19.SelectedImageIndex = 48
        TreeNode19.Text = "Super módulo de consulta de terceros"
        TreeNode20.ImageIndex = 44
        TreeNode20.Name = "Raiz_clientes"
        TreeNode20.SelectedImageIndex = 44
        TreeNode20.Text = "Clientes"
        TreeNode21.ImageIndex = 51
        TreeNode21.Name = "nod_an_pend"
        TreeNode21.SelectedImageIndex = 51
        TreeNode21.Text = "Análisis pendientes"
        TreeNode22.ImageIndex = 52
        TreeNode22.Name = "nod_audit_ped"
        TreeNode22.SelectedImageIndex = 52
        TreeNode22.Text = "Auditoria de pedidos"
        TreeNode23.ImageIndex = 53
        TreeNode23.Name = "nod_pend_zona"
        TreeNode23.SelectedImageIndex = 53
        TreeNode23.Text = "Pendientes por ruta"
        TreeNode24.ImageIndex = 54
        TreeNode24.Name = "nod_seg_pendientes"
        TreeNode24.SelectedImageIndex = 54
        TreeNode24.Text = "Seguimiento de pendientes"
        TreeNode25.ImageIndex = 48
        TreeNode25.Name = "nod_super_modulo_consult_pendientes"
        TreeNode25.SelectedImageIndex = 48
        TreeNode25.Text = "Super módulo de consulta(PENDIENTES)"
        TreeNode26.Name = "Nodo_pendientes"
        TreeNode26.Text = "Informe pendientes"
        TreeNode27.ImageIndex = 50
        TreeNode27.Name = "Raiz_pendientes"
        TreeNode27.SelectedImageIndex = 50
        TreeNode27.Text = "Pendientes"
        TreeNode28.ImageIndex = 56
        TreeNode28.Name = "nod_AnalisisVentas"
        TreeNode28.SelectedImageIndex = 56
        TreeNode28.Text = "Análisis de ventas por linea de producción"
        TreeNode29.ImageIndex = 57
        TreeNode29.Name = "nod_anali_vrKilo"
        TreeNode29.SelectedImageIndex = 57
        TreeNode29.Text = "Análisis valor kilo"
        TreeNode30.ImageIndex = 58
        TreeNode30.Name = "nod_acum_vtas"
        TreeNode30.SelectedImageIndex = 58
        TreeNode30.Text = "Acumulado ventas"
        TreeNode31.ImageIndex = 59
        TreeNode31.Name = "nod_acum_vtas_vend"
        TreeNode31.SelectedImageIndex = 59
        TreeNode31.Text = "Acum vtas vend"
        TreeNode32.ImageIndex = 60
        TreeNode32.Name = "nod_ppal_clientes"
        TreeNode32.SelectedImageIndex = 60
        TreeNode32.Text = "Principales clientes"
        TreeNode33.ImageIndex = 61
        TreeNode33.Name = "nodPrecProd"
        TreeNode33.SelectedImageIndex = 61
        TreeNode33.Text = "Precios por debajo de"
        TreeNode34.ImageIndex = 62
        TreeNode34.Name = "nod_correrias"
        TreeNode34.SelectedImageIndex = 62
        TreeNode34.Text = "Programacion correrias"
        TreeNode35.ImageIndex = 63
        TreeNode35.Name = "nod_vtas_client_idCor"
        TreeNode35.SelectedImageIndex = 63
        TreeNode35.Text = "Ventas cliente linea prod"
        TreeNode36.ImageIndex = 64
        TreeNode36.Name = "nod_Vtas_lin_ciuid"
        TreeNode36.SelectedImageIndex = 64
        TreeNode36.Text = "Ventas cliente por ciudad"
        TreeNode37.ImageIndex = 65
        TreeNode37.Name = "nod_vtas_clie_prod"
        TreeNode37.SelectedImageIndex = 65
        TreeNode37.Text = "Ventas client prod"
        TreeNode38.ImageIndex = 66
        TreeNode38.Name = "nod_vtas_zona"
        TreeNode38.SelectedImageIndex = 66
        TreeNode38.Text = "Ventas por zona"
        TreeNode39.ImageIndex = 47
        TreeNode39.Name = "nod_vtas_cliente_linea_mes"
        TreeNode39.SelectedImageIndex = 47
        TreeNode39.Text = "Ventas cliente linea de producción (por mes)"
        TreeNode40.ImageIndex = 48
        TreeNode40.Name = "nod_super_modulo_consult_vtas"
        TreeNode40.SelectedImageIndex = 48
        TreeNode40.Text = "Super módulo  de consultas(Ventas)"
        TreeNode41.ImageIndex = 55
        TreeNode41.Name = "Raiz_ventas"
        TreeNode41.SelectedImageIndex = 55
        TreeNode41.Text = "Ventas"
        TreeNode42.ImageIndex = 48
        TreeNode42.Name = "nod_super_modulo_consult_cartera"
        TreeNode42.SelectedImageIndex = 48
        TreeNode42.Text = "Super módulo  de consultas(Cartera)"
        TreeNode43.ImageIndex = 68
        TreeNode43.Name = "nod_fecha_venc_cartera"
        TreeNode43.SelectedImageIndex = 68
        TreeNode43.Text = "Fecha vencimiento cartera"
        TreeNode44.ImageIndex = 67
        TreeNode44.Name = "Raiz_cartera"
        TreeNode44.SelectedImageIndex = 67
        TreeNode44.Text = "Cartera"
        TreeNode45.ImageIndex = 48
        TreeNode45.Name = "nod_super_modulo_consult_recaudos"
        TreeNode45.SelectedImageIndex = 48
        TreeNode45.Text = "Super módulo  de consultas(Recaudos)"
        TreeNode46.ImageIndex = 69
        TreeNode46.Name = "Raiz_recaudos"
        TreeNode46.SelectedImageIndex = 69
        TreeNode46.Text = "Recaudos"
        TreeNode47.ImageIndex = 48
        TreeNode47.Name = "nod_super_modulo_consult_gastos_vendedor"
        TreeNode47.SelectedImageIndex = 48
        TreeNode47.Text = "Super módulo de consulta Costos por zona"
        TreeNode48.ImageIndex = 70
        TreeNode48.Name = "nod_gastos_zona_ventas"
        TreeNode48.SelectedImageIndex = 70
        TreeNode48.Text = "Gastos por zona"
        TreeNode49.ImageIndex = 72
        TreeNode49.Name = "nod_Ajus_Conts"
        TreeNode49.SelectedImageIndex = 72
        TreeNode49.Text = "Ajuste contabilidad"
        TreeNode50.ImageIndex = 71
        TreeNode50.Name = "nod_Conta_Menu"
        TreeNode50.SelectedImageIndex = 71
        TreeNode50.Text = "Contabilidad"
        TreeNode51.BackColor = System.Drawing.Color.Transparent
        TreeNode51.ForeColor = System.Drawing.Color.Black
        TreeNode51.ImageIndex = 49
        TreeNode51.Name = "Raiz_informes"
        TreeNode51.SelectedImageIndex = 49
        TreeNode51.Text = "Informes"
        TreeNode52.ImageIndex = 73
        TreeNode52.Name = "nod_ing_vtas"
        TreeNode52.SelectedImageIndex = 73
        TreeNode52.Text = "Ingreso ventas"
        TreeNode53.ImageIndex = 74
        TreeNode53.Name = "nod_pend_prob"
        TreeNode53.SelectedImageIndex = 74
        TreeNode53.Text = "Pendientes problema"
        TreeNode54.ImageIndex = 75
        TreeNode54.Name = "nod_seg_vend"
        TreeNode54.SelectedImageIndex = 75
        TreeNode54.Text = "Seg vendedor"
        TreeNode55.ImageIndex = 76
        TreeNode55.Name = "nod_cartera_ing_vtas"
        TreeNode55.SelectedImageIndex = 76
        TreeNode55.Text = "Cartera"
        TreeNode56.ImageIndex = 77
        TreeNode56.Name = "nod_pendientes_vend"
        TreeNode56.SelectedImageIndex = 77
        TreeNode56.Text = "Pendientes"
        TreeNode57.ImageIndex = 78
        TreeNode57.Name = "nod_despachos"
        TreeNode57.SelectedImageIndex = 78
        TreeNode57.Text = "Despachos"
        TreeNode58.Name = "nodIngVtasMovil"
        TreeNode58.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode58.Text = "Movil"
        TreeNode59.ImageIndex = 73
        TreeNode59.Name = "Raiz_ing_vtas"
        TreeNode59.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode59.SelectedImageIndex = 73
        TreeNode59.Text = "Ingreso ventas"
        TreeNode60.ImageIndex = 80
        TreeNode60.Name = "nod_consult_ppto_vtas"
        TreeNode60.SelectedImageIndex = 80
        TreeNode60.Text = "Consultar"
        TreeNode61.ImageIndex = 79
        TreeNode61.Name = "nod_ppto_vtas"
        TreeNode61.SelectedImageIndex = 79
        TreeNode61.Text = "Presupuesto ventas"
        TreeNode62.ImageIndex = 79
        TreeNode62.Name = "Raiz_ppto_vtas"
        TreeNode62.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode62.SelectedImageIndex = 79
        TreeNode62.Text = "Presupuesto ventas"
        TreeNode63.ImageIndex = 80
        TreeNode63.Name = "nod_consul_ppto_rec"
        TreeNode63.SelectedImageIndex = 80
        TreeNode63.Text = "Consultar ppto rec"
        TreeNode64.ImageIndex = 81
        TreeNode64.Name = "nod_ppto_rec"
        TreeNode64.SelectedImageIndex = 81
        TreeNode64.Text = "Presupuesto de recaudo"
        TreeNode65.ImageIndex = 81
        TreeNode65.Name = "Raiz_ppto_rec"
        TreeNode65.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode65.SelectedImageIndex = 81
        TreeNode65.Text = "Presupuesto recaudo"
        TreeNode66.ImageIndex = 47
        TreeNode66.Name = "nod_seg_vend"
        TreeNode66.SelectedImageIndex = 47
        TreeNode66.Text = "Seg vendedores"
        TreeNode67.ImageIndex = 75
        TreeNode67.Name = "nod_seg_ppto"
        TreeNode67.SelectedImageIndex = 75
        TreeNode67.Text = "Seg presupuesto"
        TreeNode68.ImageIndex = 75
        TreeNode68.Name = "nod_seg_grupos"
        TreeNode68.SelectedImageIndex = 75
        TreeNode68.Text = "Seg Lineas"
        TreeNode69.ImageIndex = 36
        TreeNode69.Name = "nod_anticipos"
        TreeNode69.SelectedImageIndex = 36
        TreeNode69.Text = "Anticipos"
        TreeNode70.ImageIndex = 48
        TreeNode70.Name = "nod_seguimiento_ppto_mes"
        TreeNode70.SelectedImageIndex = 48
        TreeNode70.Text = "Seguimiento de presupuestos (MES)"
        TreeNode71.ImageIndex = 47
        TreeNode71.Name = "Raiz_nod_seg_vend"
        TreeNode71.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode71.SelectedImageIndex = 47
        TreeNode71.Text = "Seguimiento vendedores"
        TreeNode72.ImageIndex = 83
        TreeNode72.Name = "nodQuejasRec"
        TreeNode72.SelectedImageIndex = 83
        TreeNode72.Text = "Quejas y reclamos"
        TreeNode73.ImageIndex = 84
        TreeNode73.Name = "nod_encu_clientes"
        TreeNode73.SelectedImageIndex = 84
        TreeNode73.Text = "Encuesta clientes nacionales"
        TreeNode74.ImageIndex = 80
        TreeNode74.Name = "nod_consult_encuesta_cliente"
        TreeNode74.SelectedImageIndex = 80
        TreeNode74.Text = "Consultar encuestas"
        TreeNode74.ToolTipText = "Consultar encuestas"
        TreeNode75.ImageIndex = 82
        TreeNode75.Name = "RaizSac"
        TreeNode75.SelectedImageIndex = 82
        TreeNode75.Text = "SAC"
        TreeNode76.ImageIndex = 86
        TreeNode76.Name = "nod_reglas_comisiones"
        TreeNode76.SelectedImageIndex = 86
        TreeNode76.Text = "Reglas"
        TreeNode77.ImageIndex = 87
        TreeNode77.Name = "nod_liquidacion_com"
        TreeNode77.SelectedImageIndex = 87
        TreeNode77.Text = "Liquidar comisiones (informe)"
        TreeNode78.ImageIndex = 85
        TreeNode78.Name = "Raiz_comisiones"
        TreeNode78.SelectedImageIndex = 85
        TreeNode78.Text = "Comisiones"
        TreeNode79.ImageIndex = 36
        TreeNode79.Name = "nod_cambio_cliente_vendedor"
        TreeNode79.SelectedImageIndex = 36
        TreeNode79.Text = "Cambiar Cart-Pend-Terceros de vendedor"
        TreeNode80.ImageIndex = 15
        TreeNode80.Name = "Raiz_administrar_cambios"
        TreeNode80.SelectedImageIndex = 15
        TreeNode80.Text = "Admisnistrar cambios"
        TreeNode81.ImageIndex = 88
        TreeNode81.Name = "nod_gest_doc"
        TreeNode81.SelectedImageIndex = 88
        TreeNode81.Text = "Gestion de Documentación"
        TreeNode82.ImageIndex = 43
        TreeNode82.Name = "Raiz_ofic"
        TreeNode82.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode82.SelectedImageIndex = 43
        TreeNode82.Text = "Oficinas"
        TreeNode83.ImageIndex = 123
        TreeNode83.Name = "nod_gest_desperdicios"
        TreeNode83.SelectedImageIndex = 123
        TreeNode83.Text = "Gestionar desperdicios"
        TreeNode84.ImageIndex = 124
        TreeNode84.Name = "nod_inv_metrologia"
        TreeNode84.SelectedImageIndex = 124
        TreeNode84.Text = "Inventarios de metrología"
        TreeNode85.ImageIndex = 122
        TreeNode85.Name = "Raiz_ambiental"
        TreeNode85.SelectedImageIndex = 122
        TreeNode85.Text = "Ambiental"
        TreeNode86.ImageIndex = 96
        TreeNode86.Name = "nod_recocido_calidad"
        TreeNode86.SelectedImageIndex = 96
        TreeNode86.Text = "Recocido"
        TreeNode87.ImageIndex = 149
        TreeNode87.Name = "nod_reporte_inspeccion_calidad"
        TreeNode87.SelectedImageIndex = 149
        TreeNode87.Text = "Reporte Inspeccion calidad"
        TreeNode88.ImageIndex = 95
        TreeNode88.Name = "Raiz_calidad"
        TreeNode88.SelectedImageIndex = 95
        TreeNode88.Text = "Calidad"
        TreeNode89.ImageIndex = 97
        TreeNode89.Name = "nod_ing_punt"
        TreeNode89.SelectedImageIndex = 97
        TreeNode89.Text = "Puntilleria"
        TreeNode90.ImageIndex = 97
        TreeNode90.Name = "nod_ing_puas"
        TreeNode90.SelectedImageIndex = 97
        TreeNode90.Text = "Púas"
        TreeNode91.ImageIndex = 97
        TreeNode91.Name = "nod_ing_galv"
        TreeNode91.SelectedImageIndex = 97
        TreeNode91.Text = "Galvanizado(forma1)solo consultas"
        TreeNode92.ImageIndex = 97
        TreeNode92.Name = "nod_galv_f2"
        TreeNode92.SelectedImageIndex = 97
        TreeNode92.Text = "Galvanizado (forma2)"
        TreeNode93.ImageIndex = 97
        TreeNode93.Name = "nodTref3"
        TreeNode93.SelectedImageIndex = 97
        TreeNode93.Text = "Trefilación (Forma 2)"
        TreeNode94.ImageIndex = 97
        TreeNode94.Name = "nod_tref_forma3"
        TreeNode94.SelectedImageIndex = 97
        TreeNode94.Text = "Trefilación (Forma 3)"
        TreeNode95.ImageIndex = 97
        TreeNode95.Name = "nodPulimiento"
        TreeNode95.SelectedImageIndex = 97
        TreeNode95.Text = "Pulimiento(tambores)"
        TreeNode96.ImageIndex = 97
        TreeNode96.Name = "nod_galv_baches"
        TreeNode96.SelectedImageIndex = 97
        TreeNode96.Text = "Galvanizado por baches"
        TreeNode97.ImageIndex = 97
        TreeNode97.Name = "nod_recocido"
        TreeNode97.SelectedImageIndex = 97
        TreeNode97.Text = "Recocido"
        TreeNode98.ImageIndex = 97
        TreeNode98.Name = "nod_IngTornilleria"
        TreeNode98.SelectedImageIndex = 97
        TreeNode98.Text = "Tornilleria"
        TreeNode99.ImageIndex = 97
        TreeNode99.Name = "nod_temple"
        TreeNode99.SelectedImageIndex = 97
        TreeNode99.Text = "Tratamientos termicos (Temple)"
        TreeNode100.ImageIndex = 126
        TreeNode100.Name = "nod_empaque_puntilleria"
        TreeNode100.SelectedImageIndex = 126
        TreeNode100.Text = "Empaque de puntilleria"
        TreeNode101.ImageIndex = 125
        TreeNode101.Name = "nodTranManDmsSpic"
        TreeNode101.SelectedImageIndex = 125
        TreeNode101.Text = "Transacción manual DMS-SPIC"
        TreeNode102.ImageIndex = 97
        TreeNode102.Name = "Raiz_ing_prod"
        TreeNode102.SelectedImageIndex = 97
        TreeNode102.Text = "Ingreso de producción"
        TreeNode103.ImageIndex = 5
        TreeNode103.Name = "nod_consultar_certificados"
        TreeNode103.SelectedImageIndex = 5
        TreeNode103.Text = "Consultar certificados historicos"
        TreeNode104.ImageIndex = 98
        TreeNode104.Name = "nodGenFichasYcertf"
        TreeNode104.SelectedImageIndex = 98
        TreeNode104.Text = "Generar certificado de calidad"
        TreeNode105.ImageIndex = 99
        TreeNode105.Name = "nod_maestro_fichas"
        TreeNode105.SelectedImageIndex = 99
        TreeNode105.Text = "Maestro fichas técnicas"
        TreeNode106.ImageIndex = 98
        TreeNode106.Name = "Raiz_certf_calidad"
        TreeNode106.SelectedImageIndex = 98
        TreeNode106.Text = "Certificados de calidad"
        TreeNode107.ImageIndex = 100
        TreeNode107.Name = "nod_pend_prod"
        TreeNode107.SelectedImageIndex = 100
        TreeNode107.Text = "Pendientes producción"
        TreeNode108.ImageIndex = 101
        TreeNode108.Name = "nod_traz_vtas_linea"
        TreeNode108.SelectedImageIndex = 101
        TreeNode108.Text = "Historico ventas"
        TreeNode109.ImageIndex = 102
        TreeNode109.Name = "nod_aud_inv"
        TreeNode109.SelectedImageIndex = 102
        TreeNode109.Text = "Movimiento inventario"
        TreeNode110.Name = "nod_eficiencias"
        TreeNode110.Text = "Eficiencias"
        TreeNode111.ImageIndex = 5
        TreeNode111.Name = "nodTransDms"
        TreeNode111.SelectedImageIndex = 5
        TreeNode111.Text = "Consultar transacciones Dms"
        TreeNode112.ImageIndex = 127
        TreeNode112.Name = "nod_trazabilidad_transacciones"
        TreeNode112.SelectedImageIndex = 127
        TreeNode112.Text = "Trazabilidad de transacciones"
        TreeNode113.ImageIndex = 127
        TreeNode113.Name = "nod_maximos_minimos"
        TreeNode113.SelectedImageIndex = 127
        TreeNode113.Text = "Informe de máximos y minimos"
        TreeNode114.ImageIndex = 127
        TreeNode114.Name = "nod_entradas_salidas_ref"
        TreeNode114.SelectedImageIndex = 127
        TreeNode114.Text = "Entradas-salidas-inventarios"
        TreeNode115.ImageIndex = 128
        TreeNode115.Name = "nod_entradas_salidas_diarias"
        TreeNode115.SelectedImageIndex = 128
        TreeNode115.Text = "Entradas_salidas_DIARIO"
        TreeNode116.ImageIndex = 49
        TreeNode116.Name = "Raiz_informes_prod"
        TreeNode116.SelectedImageIndex = 49
        TreeNode116.Text = "Informes"
        TreeNode117.ImageIndex = 104
        TreeNode117.Name = "nod_GestTransaSinStock"
        TreeNode117.SelectedImageIndex = 104
        TreeNode117.Text = "Gestionar transacciones sin stock"
        TreeNode118.ImageIndex = 105
        TreeNode118.Name = "nod_tras_bod_hand"
        TreeNode118.SelectedImageIndex = 105
        TreeNode118.Text = "Traslado de bodega (handheld)"
        TreeNode119.ImageIndex = 106
        TreeNode119.Name = "nod_MaestroTransHandHeld"
        TreeNode119.SelectedImageIndex = 106
        TreeNode119.Text = "Maestro Transaccion HandHeld"
        TreeNode120.ImageIndex = 103
        TreeNode120.Name = "Raiz_traslado_bodega"
        TreeNode120.SelectedImageIndex = 103
        TreeNode120.Text = "Módulo traslados de bodega"
        TreeNode121.ImageIndex = 108
        TreeNode121.Name = "nodMaeRepuestos"
        TreeNode121.SelectedImageIndex = 108
        TreeNode121.Text = "Nuevos repuestos"
        TreeNode122.ImageIndex = 109
        TreeNode122.Name = "nodCorreccion"
        TreeNode122.SelectedImageIndex = 109
        TreeNode122.Text = "Solicitud de correción"
        TreeNode123.ImageIndex = 107
        TreeNode123.Name = "RaizMantenimiento"
        TreeNode123.SelectedImageIndex = 107
        TreeNode123.Text = "Mantenimiento"
        TreeNode124.ImageIndex = 110
        TreeNode124.Name = "nod_ppto_produccion"
        TreeNode124.SelectedImageIndex = 110
        TreeNode124.Text = "Presupuesto de producción"
        TreeNode125.ImageIndex = 127
        TreeNode125.Name = "nod_seg_ppto_produccion"
        TreeNode125.SelectedImageIndex = 127
        TreeNode125.Text = "Seguimiento de presupuesto de producción"
        TreeNode126.ImageIndex = 111
        TreeNode126.Name = "nod_dif_pes_tref"
        TreeNode126.SelectedImageIndex = 111
        TreeNode126.Text = "Informe Diferencia Trefilacion"
        TreeNode127.ImageIndex = 110
        TreeNode127.Name = "Raiz_ppto_produccion"
        TreeNode127.SelectedImageIndex = 110
        TreeNode127.Text = "Presupuesto de producción"
        TreeNode128.ImageIndex = 113
        TreeNode128.Name = "nod_ppto_articulos"
        TreeNode128.SelectedImageIndex = 113
        TreeNode128.Text = "Presupuesto de articulos"
        TreeNode129.ImageIndex = 113
        TreeNode129.Name = "Raiz_ppto_articulos"
        TreeNode129.SelectedImageIndex = 113
        TreeNode129.Text = "Presupuesto de articulos"
        TreeNode130.ImageIndex = 114
        TreeNode130.Name = "nod_ppto_gastos"
        TreeNode130.SelectedImageIndex = 114
        TreeNode130.Text = "Presupuesto"
        TreeNode131.ImageIndex = 127
        TreeNode131.Name = "nod_seg_ppto_gastos"
        TreeNode131.SelectedImageIndex = 127
        TreeNode131.Text = "Seguimiento presupuesto de gastos y articulos"
        TreeNode132.ImageIndex = 112
        TreeNode132.Name = "Raiz_ppto_gastos"
        TreeNode132.SelectedImageIndex = 112
        TreeNode132.Text = "Presupuesto de gastos y articulos"
        TreeNode133.ImageIndex = 116
        TreeNode133.Name = "nod_generar_tiquetes_terminado"
        TreeNode133.SelectedImageIndex = 116
        TreeNode133.Text = "Generar tiquetes terminado"
        TreeNode134.ImageIndex = 117
        TreeNode134.Name = "nod_consultar_separe"
        TreeNode134.SelectedImageIndex = 117
        TreeNode134.Text = "Consultar planilla separe"
        TreeNode135.ImageIndex = 115
        TreeNode135.Name = "Raiz_gestionar_tornilleria"
        TreeNode135.SelectedImageIndex = 115
        TreeNode135.Text = "Gestionar tornilleria"
        TreeNode136.ImageIndex = 129
        TreeNode136.Name = "nod_salida_materia_prima_G"
        TreeNode136.SelectedImageIndex = 129
        TreeNode136.Text = "Salida materia de prima (2-11 y 11-2)"
        TreeNode137.ImageIndex = 136
        TreeNode137.Name = "nod_consulta_materia_prima_G"
        TreeNode137.SelectedImageIndex = 136
        TreeNode137.Text = "Consulta materia prima (2-11 y 11-2)"
        TreeNode138.ImageIndex = 130
        TreeNode138.Name = "nod_Orden_produccion_Galvanizado"
        TreeNode138.SelectedImageIndex = 130
        TreeNode138.Text = "Orden de produción galv"
        TreeNode139.ImageIndex = 49
        TreeNode139.Name = "nod_Informe_produccion_Galvanizado"
        TreeNode139.SelectedImageIndex = 49
        TreeNode139.Text = "Informe producción galvanizado"
        TreeNode140.ImageIndex = 135
        TreeNode140.Name = "nod_Informe_estado_rollos"
        TreeNode140.SelectedImageIndex = 135
        TreeNode140.Text = "Informe estado de rollos"
        TreeNode141.ImageIndex = 131
        TreeNode141.Name = "nod_Informe_bobinas_paradas"
        TreeNode141.SelectedImageIndex = 131
        TreeNode141.Text = "Bobinas detenidas"
        TreeNode142.ImageIndex = 132
        TreeNode142.Name = "nod_Informe_tiempo_trabajo"
        TreeNode142.SelectedImageIndex = 132
        TreeNode142.Text = "Tiempo trabajo"
        TreeNode143.ImageIndex = 133
        TreeNode143.Name = "nod_Informe_resumen_galvanizado"
        TreeNode143.SelectedImageIndex = 133
        TreeNode143.Text = "Resumen galvanizado"
        TreeNode144.ImageIndex = 134
        TreeNode144.Name = "nod_paros_galv"
        TreeNode144.SelectedImageIndex = 134
        TreeNode144.Text = "Informe de paros"
        TreeNode145.ImageIndex = 118
        TreeNode145.Name = "nodGalvanizado"
        TreeNode145.SelectedImageIndex = 118
        TreeNode145.Text = "Galvanizado"
        TreeNode146.ImageIndex = 119
        TreeNode146.Name = "nod_consult_inv_fisicos"
        TreeNode146.SelectedImageIndex = 119
        TreeNode146.Text = "Consultar inventarios fisicos"
        TreeNode147.ImageIndex = 127
        TreeNode147.Name = "nod_auditoria_inventario"
        TreeNode147.SelectedImageIndex = 127
        TreeNode147.Text = "Auditoria Inventario"
        TreeNode148.ImageIndex = 119
        TreeNode148.Name = "Raiz_nventarios_fisicos"
        TreeNode148.SelectedImageIndex = 119
        TreeNode148.Text = "Inventarios fisicos"
        TreeNode149.ImageIndex = 35
        TreeNode149.Name = "nod_solicitud_mp_puntilleria"
        TreeNode149.SelectedImageIndex = 35
        TreeNode149.Text = "Solicitar materia prima"
        TreeNode150.ImageIndex = 5
        TreeNode150.Name = "nod_consult_solicitud_mp_punt"
        TreeNode150.SelectedImageIndex = 5
        TreeNode150.Text = "Consultar solicitudes"
        TreeNode151.ImageIndex = 130
        TreeNode151.Name = "nod_orden_prod_punt"
        TreeNode151.SelectedImageIndex = 130
        TreeNode151.Text = "Orden de producción"
        TreeNode152.ImageIndex = 127
        TreeNode152.Name = "nod_auditoria_puntilleria"
        TreeNode152.SelectedImageIndex = 127
        TreeNode152.Text = "Auditoria Puntilleria"
        TreeNode153.ImageIndex = 121
        TreeNode153.Name = "Raiz_puntilleria"
        TreeNode153.SelectedImageIndex = 121
        TreeNode153.Text = "Puntilleria"
        TreeNode154.ImageIndex = 35
        TreeNode154.Name = "nod_solicitud_mp_recocido"
        TreeNode154.SelectedImageIndex = 35
        TreeNode154.Text = "Solicitar materia prima"
        TreeNode155.ImageIndex = 5
        TreeNode155.Name = "nod_consult_solicitud_mp_recocido"
        TreeNode155.SelectedImageIndex = 5
        TreeNode155.Text = "Consultar solicitudes"
        TreeNode156.ImageIndex = 130
        TreeNode156.Name = "nod_orden_produccion_rec"
        TreeNode156.SelectedImageIndex = 130
        TreeNode156.Text = "Orden de produccion Recocido"
        TreeNode157.ImageIndex = 127
        TreeNode157.Name = "nod_auditoria_recocido"
        TreeNode157.SelectedImageIndex = 127
        TreeNode157.Text = "Auditoria Recocido"
        TreeNode158.ImageIndex = 127
        TreeNode158.Name = "nod_auditoria_tref_rec"
        TreeNode158.SelectedImageIndex = 127
        TreeNode158.Text = "Auditoria Tref-Rec"
        TreeNode159.ImageIndex = 137
        TreeNode159.Name = "nod_tiquete_rec_manual"
        TreeNode159.SelectedImageIndex = 137
        TreeNode159.Text = "Copia tiquete recocido"
        TreeNode160.ImageIndex = 92
        TreeNode160.Name = "nod_tiquete_nc"
        TreeNode160.SelectedImageIndex = 92
        TreeNode160.Text = "Tiquete no conforme"
        TreeNode161.ImageIndex = 96
        TreeNode161.Name = "Raiz_Recocido"
        TreeNode161.SelectedImageIndex = 96
        TreeNode161.Text = "Recocido"
        TreeNode162.ImageIndex = 35
        TreeNode162.Name = "nod_solicitud_mp_puas"
        TreeNode162.SelectedImageIndex = 35
        TreeNode162.Text = "Solicitar materia prima"
        TreeNode163.ImageIndex = 5
        TreeNode163.Name = "nod_consult_solicitud_mp_puas"
        TreeNode163.SelectedImageIndex = 5
        TreeNode163.Text = "Consultar solicitudes"
        TreeNode164.ImageIndex = 130
        TreeNode164.Name = "nod_orden_prod_puas"
        TreeNode164.SelectedImageIndex = 130
        TreeNode164.Text = "Orden de producción operario"
        TreeNode165.ImageIndex = 120
        TreeNode165.Name = "nod_crear_orden_puas"
        TreeNode165.SelectedImageIndex = 120
        TreeNode165.Text = "Crear orden puas"
        TreeNode166.ImageIndex = 71
        TreeNode166.Name = "nod_prod_puas"
        TreeNode166.SelectedImageIndex = 71
        TreeNode166.Text = "Producción de puas"
        TreeNode167.ImageIndex = 134
        TreeNode167.Name = "nod_infor_paros_puas"
        TreeNode167.SelectedImageIndex = 134
        TreeNode167.Text = "Informe de paros púas"
        TreeNode168.ImageIndex = 118
        TreeNode168.Name = "raiz_puas"
        TreeNode168.SelectedImageIndex = 118
        TreeNode168.Text = "Alambre de Puas"
        TreeNode169.ImageIndex = 69
        TreeNode169.Name = "nod_proyectos"
        TreeNode169.SelectedImageIndex = 69
        TreeNode169.Text = "Crear proyecto"
        TreeNode170.ImageIndex = 136
        TreeNode170.Name = "nod_consultar_proyecto"
        TreeNode170.SelectedImageIndex = 136
        TreeNode170.Text = "Consultar proyectos"
        TreeNode171.ImageIndex = 127
        TreeNode171.Name = "Raiz_proyectos"
        TreeNode171.SelectedImageIndex = 127
        TreeNode171.Text = "Gestionar proyectos"
        TreeNode172.ImageIndex = 138
        TreeNode172.Name = "nod_solicitud_scal"
        TreeNode172.SelectedImageIndex = 138
        TreeNode172.Text = "Solicitud scal"
        TreeNode173.ImageIndex = 138
        TreeNode173.Name = "nod_solicitud_scae"
        TreeNode173.SelectedImageIndex = 138
        TreeNode173.Text = "Solicitud scae"
        TreeNode174.ImageIndex = 138
        TreeNode174.Name = "nod_solicitud_sar"
        TreeNode174.SelectedImageIndex = 138
        TreeNode174.Text = "Solicitud sar"
        TreeNode175.ImageIndex = 138
        TreeNode175.Name = "nod_solicitud_sav"
        TreeNode175.SelectedImageIndex = 138
        TreeNode175.Text = "Solicitud sav"
        TreeNode176.ImageIndex = 136
        TreeNode176.Name = "nod_consulta_scal"
        TreeNode176.SelectedImageIndex = 136
        TreeNode176.Text = "Consulta de pedidos scal"
        TreeNode177.ImageIndex = 136
        TreeNode177.Name = "nod_consulta_scae"
        TreeNode177.SelectedImageIndex = 136
        TreeNode177.Text = "Consulta de pedidos scae"
        TreeNode178.ImageIndex = 136
        TreeNode178.Name = "nod_consulta_sar"
        TreeNode178.SelectedImageIndex = 136
        TreeNode178.Text = "Consulta de pedidos sar"
        TreeNode179.ImageIndex = 136
        TreeNode179.Name = "nod_consulta_sav"
        TreeNode179.SelectedImageIndex = 136
        TreeNode179.Text = "Consulta de pedidos sav"
        TreeNode180.ImageIndex = 138
        TreeNode180.Name = "nod_scal_scae_sav"
        TreeNode180.SelectedImageIndex = 138
        TreeNode180.Text = "Consumos scal,scae,sar y sav"
        TreeNode181.ImageIndex = 130
        TreeNode181.Name = "nodOrdenProd"
        TreeNode181.SelectedImageIndex = 130
        TreeNode181.Text = "Ordenes de producción"
        TreeNode182.ImageIndex = 127
        TreeNode182.Name = "nod_auditoria_alambres"
        TreeNode182.SelectedImageIndex = 127
        TreeNode182.Text = "Auditoria de alambres"
        TreeNode183.ImageIndex = 139
        TreeNode183.Name = "nod_gen_tiquet_tref"
        TreeNode183.SelectedImageIndex = 139
        TreeNode183.Text = "Generar tiquete tref NC"
        TreeNode184.ImageIndex = 94
        TreeNode184.Name = "nodGesRef"
        TreeNode184.SelectedImageIndex = 94
        TreeNode184.Text = "Gestionar linea de producción"
        TreeNode185.ImageIndex = 125
        TreeNode185.Name = "nod_limite_consumos"
        TreeNode185.SelectedImageIndex = 125
        TreeNode185.Text = "Limite consumos alambron"
        TreeNode186.ImageIndex = 141
        TreeNode186.Name = "nod_cod_vel"
        TreeNode186.SelectedImageIndex = 141
        TreeNode186.Text = "Velocidades de codigos"
        TreeNode187.ImageIndex = 114
        TreeNode187.Name = "nod_sal_alam"
        TreeNode187.SelectedImageIndex = 114
        TreeNode187.Text = "Saldo alambron"
        TreeNode188.ImageIndex = 142
        TreeNode188.Name = "nod_act_alam"
        TreeNode188.SelectedImageIndex = 142
        TreeNode188.Text = "Actualizar alambron"
        TreeNode189.ImageIndex = 136
        TreeNode189.Name = "nod_tref_form3"
        TreeNode189.SelectedImageIndex = 136
        TreeNode189.Text = "Consulta tref forma 3"
        TreeNode190.ImageIndex = 139
        TreeNode190.Name = "nodo_consumir_tiquetes"
        TreeNode190.SelectedImageIndex = 139
        TreeNode190.Text = "Consumir Tiquetes Trefilacion"
        TreeNode191.ImageIndex = 153
        TreeNode191.Name = "Nododetalleparos"
        TreeNode191.SelectedImageIndex = 153
        TreeNode191.Text = "Detalle paros tref"
        TreeNode192.ImageIndex = 118
        TreeNode192.Name = "nod_tref_com"
        TreeNode192.SelectedImageIndex = 118
        TreeNode192.Text = "Trefilación"
        TreeNode193.ImageIndex = 115
        TreeNode193.Name = "nod_cosnu_tornilleria"
        TreeNode193.SelectedImageIndex = 115
        TreeNode193.Text = "Consumo de tornileria"
        TreeNode194.ImageIndex = 115
        TreeNode194.Name = "nod_Mod_Tornilleria"
        TreeNode194.SelectedImageIndex = 115
        TreeNode194.Text = "Tornilleria"
        TreeNode195.ImageIndex = 138
        TreeNode195.Name = "nod_mat_consumida"
        TreeNode195.SelectedImageIndex = 138
        TreeNode195.Text = "consumo y producción de tref"
        TreeNode196.ImageIndex = 138
        TreeNode196.Name = "nod_mat_punt"
        TreeNode196.SelectedImageIndex = 138
        TreeNode196.Text = "consumo y producción de punt"
        TreeNode197.ImageIndex = 138
        TreeNode197.Name = "nod_mat_galv"
        TreeNode197.SelectedImageIndex = 138
        TreeNode197.Text = "consumo y produccion galv"
        TreeNode198.ImageIndex = 138
        TreeNode198.Name = "nod_segui_consu"
        TreeNode198.SelectedImageIndex = 138
        TreeNode198.Text = "Seguimiento de consumos"
        TreeNode199.ImageIndex = 142
        TreeNode199.Name = "nod_cambiar_centro"
        TreeNode199.SelectedImageIndex = 142
        TreeNode199.Text = "Cambiar centro (Planta)"
        TreeNode200.ImageIndex = 127
        TreeNode200.Name = "nod_auditoria"
        TreeNode200.SelectedImageIndex = 127
        TreeNode200.Text = "Auditoria"
        TreeNode201.ImageIndex = 94
        TreeNode201.Name = "Raiz_prod"
        TreeNode201.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode201.SelectedImageIndex = 94
        TreeNode201.Text = "Producción"
        TreeNode202.ImageIndex = 138
        TreeNode202.Name = "nod_info_dane"
        TreeNode202.SelectedImageIndex = 138
        TreeNode202.Text = "Informe personal Dane"
        TreeNode203.ImageIndex = 138
        TreeNode203.Name = "nod_informe_pers_activo"
        TreeNode203.SelectedImageIndex = 138
        TreeNode203.Text = "Informe Personal Activo"
        TreeNode204.ImageIndex = 138
        TreeNode204.Name = "nod_info_empleados"
        TreeNode204.SelectedImageIndex = 138
        TreeNode204.Text = "Información de empleados"
        TreeNode205.ImageIndex = 137
        TreeNode205.Name = "nod_informe_ausentismos"
        TreeNode205.SelectedImageIndex = 137
        TreeNode205.Text = "Informe de incapacidades y ausentismos"
        TreeNode206.ImageIndex = 143
        TreeNode206.Name = "nod_dias_vacaciones"
        TreeNode206.SelectedImageIndex = 143
        TreeNode206.Text = "Días de vacaciones"
        TreeNode207.ImageIndex = 132
        TreeNode207.Name = "nod_tiempos_laborados"
        TreeNode207.SelectedImageIndex = 132
        TreeNode207.Text = "Tiempos laborados"
        TreeNode208.ImageIndex = 142
        TreeNode208.Name = "nod_rotacion_personal"
        TreeNode208.SelectedImageIndex = 142
        TreeNode208.Text = "Rotación del personal"
        TreeNode209.ImageIndex = 45
        TreeNode209.Name = "nodReg_personal_maquila"
        TreeNode209.SelectedImageIndex = 45
        TreeNode209.Text = "Registrar personal maquilas"
        TreeNode210.ImageIndex = 137
        TreeNode210.Name = "nod_informe_temporales"
        TreeNode210.SelectedImageIndex = 137
        TreeNode210.Text = "Informe temporales"
        TreeNode211.ImageIndex = 45
        TreeNode211.Name = "Raiz maquila"
        TreeNode211.SelectedImageIndex = 45
        TreeNode211.Text = "Personal maquilas"
        TreeNode212.ImageIndex = 141
        TreeNode212.Name = "nod_liqui_reloj"
        TreeNode212.SelectedImageIndex = 141
        TreeNode212.Text = "Procesar marcaciones"
        TreeNode213.ImageIndex = 71
        TreeNode213.Name = "nod_programacion_turnos"
        TreeNode213.SelectedImageIndex = 71
        TreeNode213.Text = "Programación de turnos"
        TreeNode214.ImageIndex = 107
        TreeNode214.Name = "nod_MaePeriodos"
        TreeNode214.SelectedImageIndex = 107
        TreeNode214.Text = "Gestionar periodos de corte de novedades"
        TreeNode215.ImageIndex = 127
        TreeNode215.Name = "nod_informe_marcaciones"
        TreeNode215.SelectedImageIndex = 127
        TreeNode215.Text = "Informe de inconsistencia en marcaciones"
        TreeNode216.ImageIndex = 71
        TreeNode216.Name = "Nod_consult_compromisos"
        TreeNode216.SelectedImageIndex = 71
        TreeNode216.Text = "Consultar compromisos"
        TreeNode217.ImageIndex = 71
        TreeNode217.Name = "nod_informe_nov_pendientes"
        TreeNode217.SelectedImageIndex = 71
        TreeNode217.Text = "Informe de novedades pendientes"
        TreeNode218.ImageIndex = 138
        TreeNode218.Name = "nod_per_activo"
        TreeNode218.SelectedImageIndex = 138
        TreeNode218.Text = "Personal en Corsan"
        TreeNode219.ImageIndex = 132
        TreeNode219.Name = "Raiz_reloj"
        TreeNode219.SelectedImageIndex = 132
        TreeNode219.Text = "Reloj"
        TreeNode220.ImageIndex = 125
        TreeNode220.Name = "nod_evaluacione_desempeno"
        TreeNode220.SelectedImageIndex = 125
        TreeNode220.Text = "Evaluacion de desempeño"
        TreeNode221.ImageIndex = 136
        TreeNode221.Name = "nod_consultar_eval_desempeno"
        TreeNode221.SelectedImageIndex = 136
        TreeNode221.Text = "Consultar evaluaciónes de desempeño"
        TreeNode222.ImageIndex = 52
        TreeNode222.Name = "nod_permisos_evaluaciones"
        TreeNode222.SelectedImageIndex = 52
        TreeNode222.Text = "Permisos evaluaciones"
        TreeNode223.ImageIndex = 125
        TreeNode223.Name = "Raiz_eval_desempeno"
        TreeNode223.SelectedImageIndex = 125
        TreeNode223.Text = "Evaluaciones de desempeño"
        TreeNode224.ImageIndex = 34
        TreeNode224.Name = "nod_buzon_sugerencias_det"
        TreeNode224.SelectedImageIndex = 34
        TreeNode224.Text = "Buzon de Sugerencias"
        TreeNode225.ImageIndex = 52
        TreeNode225.Name = "nod_buzon_cons_premios"
        TreeNode225.SelectedImageIndex = 52
        TreeNode225.Text = "Consulta Solicitud de Premios"
        TreeNode226.ImageIndex = 37
        TreeNode226.Name = "nod_contrat_dias"
        TreeNode226.SelectedImageIndex = 37
        TreeNode226.Text = "Gestionar contratistas"
        TreeNode227.ImageIndex = 37
        TreeNode227.Name = "nod_contra"
        TreeNode227.SelectedImageIndex = 37
        TreeNode227.Text = "Contratistas"
        TreeNode228.ImageIndex = 44
        TreeNode228.Name = "Raiz_recursos_humanos"
        TreeNode228.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode228.SelectedImageIndex = 44
        TreeNode228.Text = "Recursos humanos"
        TreeNode229.ImageIndex = 136
        TreeNode229.Name = "nodConsultVot"
        TreeNode229.SelectedImageIndex = 136
        TreeNode229.Text = "Consultar votaciónes"
        TreeNode230.ImageIndex = 83
        TreeNode230.Name = "nodGesGrup"
        TreeNode230.SelectedImageIndex = 83
        TreeNode230.Text = "Gestionar grupos votación"
        TreeNode231.ImageIndex = 140
        TreeNode231.Name = "nodIngVot"
        TreeNode231.SelectedImageIndex = 140
        TreeNode231.Text = "Ingresar votación"
        TreeNode232.ImageIndex = 83
        TreeNode232.Name = "RaizAdminVot"
        TreeNode232.SelectedImageIndex = 83
        TreeNode232.Text = "Administrar votación"
        TreeNode233.ImageIndex = 5
        TreeNode233.Name = "nod_constar_eval_prov"
        TreeNode233.SelectedImageIndex = 5
        TreeNode233.Text = "Consultar"
        TreeNode234.ImageIndex = 145
        TreeNode234.Name = "nod_evaluacion_prov"
        TreeNode234.SelectedImageIndex = 145
        TreeNode234.Text = "Evaluación"
        TreeNode235.ImageIndex = 127
        TreeNode235.Name = "nod_graficar_evaluaciones"
        TreeNode235.SelectedImageIndex = 127
        TreeNode235.Text = "Graficar evaluaciones"
        TreeNode236.ImageIndex = 99
        TreeNode236.Name = "nod_maestro_prov_cat"
        TreeNode236.SelectedImageIndex = 99
        TreeNode236.Text = "Maestro proveedor-categoria"
        TreeNode237.ImageIndex = 86
        TreeNode237.Name = "nod_gestionar_tendencias"
        TreeNode237.SelectedImageIndex = 86
        TreeNode237.Text = "Gestionar_tendencias"
        TreeNode238.ImageIndex = 145
        TreeNode238.Name = "Raiz_evaluacion_proveedores"
        TreeNode238.SelectedImageIndex = 145
        TreeNode238.Text = "Evaluación de proveedores"
        TreeNode239.ImageIndex = 69
        TreeNode239.Name = "nod_generar_sol_compra"
        TreeNode239.SelectedImageIndex = 69
        TreeNode239.Text = "Generar solicitud de servicio"
        TreeNode240.ImageIndex = 120
        TreeNode240.Name = "nod_admin_sol_compra"
        TreeNode240.SelectedImageIndex = 120
        TreeNode240.Text = "Administrar solicitudes de servicios"
        TreeNode241.ImageIndex = 136
        TreeNode241.Name = "nod_infor_cant_entre"
        TreeNode241.SelectedImageIndex = 136
        TreeNode241.Text = "Consultar material aut vs reg"
        TreeNode242.ImageIndex = 109
        TreeNode242.Name = "Raiz_sol_servicio"
        TreeNode242.SelectedImageIndex = 109
        TreeNode242.Text = "Solicitudes de servicio"
        TreeNode243.ImageIndex = 144
        TreeNode243.Name = "nod_admin_ord_compra"
        TreeNode243.SelectedImageIndex = 144
        TreeNode243.Text = "Administrar ordenes de compra"
        TreeNode244.ImageIndex = 69
        TreeNode244.Name = "nod_generar_ord_compra"
        TreeNode244.SelectedImageIndex = 69
        TreeNode244.Text = "Generar orden de compra"
        TreeNode245.ImageIndex = 144
        TreeNode245.Name = "RaizSolCompra"
        TreeNode245.SelectedImageIndex = 144
        TreeNode245.Text = "Ordenes de compra"
        TreeNode246.ImageIndex = 147
        TreeNode246.Name = "nod_salida_almacen"
        TreeNode246.SelectedImageIndex = 147
        TreeNode246.Text = "Generar salida de almacen"
        TreeNode247.ImageIndex = 136
        TreeNode247.Name = "nod_consult_salida_almacen"
        TreeNode247.SelectedImageIndex = 136
        TreeNode247.Text = "Consultar salidas de almacen"
        TreeNode248.ImageIndex = 147
        TreeNode248.Name = "RaizSalidaAlmacen"
        TreeNode248.SelectedImageIndex = 147
        TreeNode248.Text = "Salidas de almacen"
        TreeNode249.ImageIndex = 118
        TreeNode249.Name = "nod_salida_alambron"
        TreeNode249.SelectedImageIndex = 118
        TreeNode249.Text = "Salida de alambrón"
        TreeNode250.ImageIndex = 136
        TreeNode250.Name = "nod_consultar_salida_alambron"
        TreeNode250.SelectedImageIndex = 136
        TreeNode250.Text = "Consultar salida de alambrón"
        TreeNode251.ImageIndex = 118
        TreeNode251.Name = "RaizSalidaAlambron"
        TreeNode251.SelectedImageIndex = 118
        TreeNode251.Text = "Salidas de alambrón"
        TreeNode252.ImageIndex = 116
        TreeNode252.Name = "nod_tiquetes_alambron"
        TreeNode252.SelectedImageIndex = 116
        TreeNode252.Text = "Tiquetes de alambrón"
        TreeNode253.ImageIndex = 127
        TreeNode253.Name = "nod_auditoria_tiquete"
        TreeNode253.SelectedImageIndex = 127
        TreeNode253.Text = "Auditoria de ingreso de materia prima"
        TreeNode254.ImageIndex = 78
        TreeNode254.Name = "nod_planillas_cargue"
        TreeNode254.SelectedImageIndex = 78
        TreeNode254.Text = "Planillas de descargue de alambrón"
        TreeNode255.ImageIndex = 105
        TreeNode255.Name = "NodPrincipalHandHeld"
        TreeNode255.SelectedImageIndex = 105
        TreeNode255.Text = "Menú principal Hand-Held"
        TreeNode256.ImageIndex = 152
        TreeNode256.Name = "NodoInhabilitarAlambron"
        TreeNode256.SelectedImageIndex = 152
        TreeNode256.Text = "Inhabilitar tiquetes alambrón"
        TreeNode257.ImageIndex = 118
        TreeNode257.Name = "RaizAlambron"
        TreeNode257.SelectedImageIndex = 118
        TreeNode257.Text = "Gestión de alambrón"
        TreeNode258.ImageIndex = 148
        TreeNode258.Name = "nod_infor_estupe"
        TreeNode258.SelectedImageIndex = 148
        TreeNode258.Text = "Información estupefacientes"
        TreeNode259.ImageIndex = 148
        TreeNode259.Name = "RaizEstupefacientes"
        TreeNode259.SelectedImageIndex = 148
        TreeNode259.Text = "Estupefacientes"
        TreeNode260.ImageIndex = 116
        TreeNode260.Name = "nod_generar_tiquetes_terminado"
        TreeNode260.SelectedImageIndex = 116
        TreeNode260.Text = "Generar tiquetes producto temrinado"
        TreeNode261.ImageIndex = 116
        TreeNode261.Name = "Raiz_generar_tiquetes_terminado"
        TreeNode261.SelectedImageIndex = 116
        TreeNode261.Text = "Tiquetes producto terminado"
        TreeNode262.ImageIndex = 144
        TreeNode262.Name = "Raiz_compras"
        TreeNode262.SelectedImageIndex = 144
        TreeNode262.Text = "Compras"
        TreeNode263.ImageIndex = 136
        TreeNode263.Name = "nod_consultar_proc"
        TreeNode263.SelectedImageIndex = 136
        TreeNode263.Text = "Consultar procedimientos"
        TreeNode264.ImageIndex = 69
        TreeNode264.Name = "nod_gest_proc"
        TreeNode264.SelectedImageIndex = 69
        TreeNode264.Text = "Gestionar procedimientos"
        TreeNode265.ImageIndex = 99
        TreeNode265.Name = "nod_mae_cargos"
        TreeNode265.SelectedImageIndex = 99
        TreeNode265.Text = "Maestro cargos"
        TreeNode266.ImageIndex = 127
        TreeNode266.Name = "nod_auditoria"
        TreeNode266.SelectedImageIndex = 127
        TreeNode266.Text = "Auditoria"
        TreeNode267.ImageIndex = 36
        TreeNode267.Name = "nod_cambio_bod"
        TreeNode267.SelectedImageIndex = 36
        TreeNode267.Text = "Cambiar pedido bodega"
        TreeNode268.ImageIndex = 90
        TreeNode268.Name = "nod_fecha_entrega"
        TreeNode268.SelectedImageIndex = 90
        TreeNode268.Text = "Relación factura-pedido-entrega"
        TreeNode269.ImageIndex = 27
        TreeNode269.Name = "nod_formato_stiker"
        TreeNode269.SelectedImageIndex = 27
        TreeNode269.Text = "Formato impresión etiquetas"
        TreeNode270.ImageIndex = 10
        TreeNode270.Name = "nod_gestionar_no_conforme"
        TreeNode270.SelectedImageIndex = 10
        TreeNode270.Text = "Gestionar producto no conforme"
        TreeNode271.ImageIndex = 150
        TreeNode271.Name = "nod_ppal_despachos"
        TreeNode271.SelectedImageIndex = 150
        TreeNode271.Text = "Traslado de la  B 2 a la 3"
        TreeNode272.ImageIndex = 151
        TreeNode272.Name = "Nod_estado_maquinas"
        TreeNode272.SelectedImageIndex = 151
        TreeNode272.Text = "Control Esatado maquinas"
        TreeNode273.ImageIndex = 89
        TreeNode273.Name = "Raiz_logistica"
        TreeNode273.SelectedImageIndex = 89
        TreeNode273.Text = "Logistica"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode82, TreeNode201, TreeNode228, TreeNode232, TreeNode262, TreeNode266, TreeNode273})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(407, 404)
        Me.TreeView1.TabIndex = 42
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "icoProg.png")
        Me.ImageList1.Images.SetKeyName(1, "1349366316_users.ico")
        Me.ImageList1.Images.SetKeyName(2, "dinero.jpg")
        Me.ImageList1.Images.SetKeyName(3, "est.jpg")
        Me.ImageList1.Images.SetKeyName(4, "usuario1.gif")
        Me.ImageList1.Images.SetKeyName(5, "buscar7.gif")
        Me.ImageList1.Images.SetKeyName(6, "mas1.png")
        Me.ImageList1.Images.SetKeyName(7, "casco.jpg")
        Me.ImageList1.Images.SetKeyName(8, "casco1.jpg")
        Me.ImageList1.Images.SetKeyName(9, "despacho.png")
        Me.ImageList1.Images.SetKeyName(10, "planilla.gif")
        Me.ImageList1.Images.SetKeyName(11, "informe.png")
        Me.ImageList1.Images.SetKeyName(12, "actualizar.png")
        Me.ImageList1.Images.SetKeyName(13, "tool.png")
        Me.ImageList1.Images.SetKeyName(14, "Black_Tools.png")
        Me.ImageList1.Images.SetKeyName(15, "configuracion.png")
        Me.ImageList1.Images.SetKeyName(16, "ficha.png")
        Me.ImageList1.Images.SetKeyName(17, "mobil.ico")
        Me.ImageList1.Images.SetKeyName(18, "ok.png")
        Me.ImageList1.Images.SetKeyName(19, "compras.png")
        Me.ImageList1.Images.SetKeyName(20, "compras1.png")
        Me.ImageList1.Images.SetKeyName(21, "compras2.png")
        Me.ImageList1.Images.SetKeyName(22, "compras4.png")
        Me.ImageList1.Images.SetKeyName(23, "compras5.png")
        Me.ImageList1.Images.SetKeyName(24, "Time_management.png")
        Me.ImageList1.Images.SetKeyName(25, "grafico10.png")
        Me.ImageList1.Images.SetKeyName(26, "ok3.gif")
        Me.ImageList1.Images.SetKeyName(27, "imp.ico")
        Me.ImageList1.Images.SetKeyName(28, "imp.ico")
        Me.ImageList1.Images.SetKeyName(29, "natural.png")
        Me.ImageList1.Images.SetKeyName(30, "maestros.png")
        Me.ImageList1.Images.SetKeyName(31, "maestro_permisos.png")
        Me.ImageList1.Images.SetKeyName(32, "maestro_modulos.png")
        Me.ImageList1.Images.SetKeyName(33, "maestro_operaciones_transaccion.png")
        Me.ImageList1.Images.SetKeyName(34, "gestionar_permisos.png")
        Me.ImageList1.Images.SetKeyName(35, "gestionar_correo_entrante_y_saliente.png")
        Me.ImageList1.Images.SetKeyName(36, "auditoria_de_cambios.png")
        Me.ImageList1.Images.SetKeyName(37, "gestionar_usuarios.png")
        Me.ImageList1.Images.SetKeyName(38, "vendedores_asociados_a_un_coordinador.png")
        Me.ImageList1.Images.SetKeyName(39, "cerrar_aplicaciones_en_una_ruta.png")
        Me.ImageList1.Images.SetKeyName(40, "cerrar_forzado.png")
        Me.ImageList1.Images.SetKeyName(41, "manuales.png")
        Me.ImageList1.Images.SetKeyName(42, "acerca_de.png")
        Me.ImageList1.Images.SetKeyName(43, "oficinas.png")
        Me.ImageList1.Images.SetKeyName(44, "clientes.png")
        Me.ImageList1.Images.SetKeyName(45, "estado_cliente_vend.png")
        Me.ImageList1.Images.SetKeyName(46, "informacion_clientes.png")
        Me.ImageList1.Images.SetKeyName(47, "trazabilidad_clientes_atentidos.png")
        Me.ImageList1.Images.SetKeyName(48, "super_modulo_de_consultas_de_terceros.png")
        Me.ImageList1.Images.SetKeyName(49, "informes.png")
        Me.ImageList1.Images.SetKeyName(50, "pendientes.png")
        Me.ImageList1.Images.SetKeyName(51, "analisis_pendientes.png")
        Me.ImageList1.Images.SetKeyName(52, "auditoria_de_pedidos.png")
        Me.ImageList1.Images.SetKeyName(53, "pendientes_por_ruta.png")
        Me.ImageList1.Images.SetKeyName(54, "seguimiento_pendientes.png")
        Me.ImageList1.Images.SetKeyName(55, "ventas.png")
        Me.ImageList1.Images.SetKeyName(56, "analisis_de_ventas_por_linea_de_produccion.png")
        Me.ImageList1.Images.SetKeyName(57, "analisis_valor_kilo.png")
        Me.ImageList1.Images.SetKeyName(58, "acomulado ventas.png")
        Me.ImageList1.Images.SetKeyName(59, "acum_vtas_vend.png")
        Me.ImageList1.Images.SetKeyName(60, "principales_clientes.png")
        Me.ImageList1.Images.SetKeyName(61, "precios_por_debajo_de.png")
        Me.ImageList1.Images.SetKeyName(62, "programacion_correrias.png")
        Me.ImageList1.Images.SetKeyName(63, "ventas_cliente_linea_prod.png")
        Me.ImageList1.Images.SetKeyName(64, "ventas_cliente_por_ciudad.png")
        Me.ImageList1.Images.SetKeyName(65, "ventas_client_prod.png")
        Me.ImageList1.Images.SetKeyName(66, "ventas_por_zona.png")
        Me.ImageList1.Images.SetKeyName(67, "cartera.png")
        Me.ImageList1.Images.SetKeyName(68, "fecha_vencimiento_cartera.png")
        Me.ImageList1.Images.SetKeyName(69, "recaudos.png")
        Me.ImageList1.Images.SetKeyName(70, "gastos_por_zona.png")
        Me.ImageList1.Images.SetKeyName(71, "contabilidad.png")
        Me.ImageList1.Images.SetKeyName(72, "ajuste_de_contabilidad.png")
        Me.ImageList1.Images.SetKeyName(73, "ingreso_ventas.png")
        Me.ImageList1.Images.SetKeyName(74, "pendientes_problema.png")
        Me.ImageList1.Images.SetKeyName(75, "seguimiento_vendedor.png")
        Me.ImageList1.Images.SetKeyName(76, "cartera.png")
        Me.ImageList1.Images.SetKeyName(77, "pendientes.png")
        Me.ImageList1.Images.SetKeyName(78, "despachos.png")
        Me.ImageList1.Images.SetKeyName(79, "presupuesto_ventas.png")
        Me.ImageList1.Images.SetKeyName(80, "consultarp.png")
        Me.ImageList1.Images.SetKeyName(81, "presupuesto_recaudo.png")
        Me.ImageList1.Images.SetKeyName(82, "sac.png")
        Me.ImageList1.Images.SetKeyName(83, "quejas_y_reclamos.png")
        Me.ImageList1.Images.SetKeyName(84, "encuestas_clientes_nacionales.png")
        Me.ImageList1.Images.SetKeyName(85, "comisiones.png")
        Me.ImageList1.Images.SetKeyName(86, "reglas.png")
        Me.ImageList1.Images.SetKeyName(87, "liquidar_comisiones.png")
        Me.ImageList1.Images.SetKeyName(88, "gestion_de_documentacionp.png")
        Me.ImageList1.Images.SetKeyName(89, "logistica.png")
        Me.ImageList1.Images.SetKeyName(90, "relacion_factura_pedido_entrega.png")
        Me.ImageList1.Images.SetKeyName(91, "formato_impresion_etiquetas.png")
        Me.ImageList1.Images.SetKeyName(92, "gestionar_producto_no_conforme.png")
        Me.ImageList1.Images.SetKeyName(93, "traslado_de_la_B_2_a_la_3.png")
        Me.ImageList1.Images.SetKeyName(94, "produccion.png")
        Me.ImageList1.Images.SetKeyName(95, "calidad.png")
        Me.ImageList1.Images.SetKeyName(96, "recocido.png")
        Me.ImageList1.Images.SetKeyName(97, "ingreso_produccion.png")
        Me.ImageList1.Images.SetKeyName(98, "certificados_de_calidad.png")
        Me.ImageList1.Images.SetKeyName(99, "maestro_fichas_tecnicas.png")
        Me.ImageList1.Images.SetKeyName(100, "pendientes_produccion.png")
        Me.ImageList1.Images.SetKeyName(101, "historico_ventas.png")
        Me.ImageList1.Images.SetKeyName(102, "movimientos_inventario.png")
        Me.ImageList1.Images.SetKeyName(103, "modulo_traslados_de_bodega.png")
        Me.ImageList1.Images.SetKeyName(104, "gestionar_transacciones_sin_stock.png")
        Me.ImageList1.Images.SetKeyName(105, "traslados_de_bodega(handheld).png")
        Me.ImageList1.Images.SetKeyName(106, "maestro_transacion_handheld.png")
        Me.ImageList1.Images.SetKeyName(107, "mantenimiento.png")
        Me.ImageList1.Images.SetKeyName(108, "nuevos_repuestos.png")
        Me.ImageList1.Images.SetKeyName(109, "solicitud_de_correcion.png")
        Me.ImageList1.Images.SetKeyName(110, "presupuesto_de_produccion.png")
        Me.ImageList1.Images.SetKeyName(111, "informe_diferencia_trefilacion.png")
        Me.ImageList1.Images.SetKeyName(112, "presupuesto_de_gastos_y_articulos.png")
        Me.ImageList1.Images.SetKeyName(113, "presupuesto_de_articulos.png")
        Me.ImageList1.Images.SetKeyName(114, "presupuesto.png")
        Me.ImageList1.Images.SetKeyName(115, "gestionar_tornilleria.png")
        Me.ImageList1.Images.SetKeyName(116, "generar_tiquetes_terminado.png")
        Me.ImageList1.Images.SetKeyName(117, "consulta_planilla_separe.png")
        Me.ImageList1.Images.SetKeyName(118, "galvanizado.png")
        Me.ImageList1.Images.SetKeyName(119, "inventaios_fisicos.png")
        Me.ImageList1.Images.SetKeyName(120, "consulta_inventarios_fisicos.png")
        Me.ImageList1.Images.SetKeyName(121, "puntillerias.png")
        Me.ImageList1.Images.SetKeyName(122, "ambiental.png")
        Me.ImageList1.Images.SetKeyName(123, "gestionar_desperdicios.png")
        Me.ImageList1.Images.SetKeyName(124, "inventarios de metereologia.png")
        Me.ImageList1.Images.SetKeyName(125, "transacion_manual_DMS_SPIC.png")
        Me.ImageList1.Images.SetKeyName(126, "empaque_puntilleria.png")
        Me.ImageList1.Images.SetKeyName(127, "trazabilidad_de_transaciones.png")
        Me.ImageList1.Images.SetKeyName(128, "entradas_salidas_diarias.png")
        Me.ImageList1.Images.SetKeyName(129, "salida_materia_prima(2-11 y 11-2).png")
        Me.ImageList1.Images.SetKeyName(130, "orden_de_producion_galv.png")
        Me.ImageList1.Images.SetKeyName(131, "bobinas_detenidas.png")
        Me.ImageList1.Images.SetKeyName(132, "tiempo_trabajo.png")
        Me.ImageList1.Images.SetKeyName(133, "resumen_galvanizado.png")
        Me.ImageList1.Images.SetKeyName(134, "informe_de_paros.png")
        Me.ImageList1.Images.SetKeyName(135, "informe_estado_de_rollos.png")
        Me.ImageList1.Images.SetKeyName(136, "consulta.png")
        Me.ImageList1.Images.SetKeyName(137, "copia_tiquete_recocido.png")
        Me.ImageList1.Images.SetKeyName(138, "person.png")
        Me.ImageList1.Images.SetKeyName(139, "generar_tiquete_nc.png")
        Me.ImageList1.Images.SetKeyName(140, "limite_consumos_alambron.png")
        Me.ImageList1.Images.SetKeyName(141, "velocidades_de_codigos.png")
        Me.ImageList1.Images.SetKeyName(142, "actualizar_saldo_alambron.png")
        Me.ImageList1.Images.SetKeyName(143, "dias_de_vacaciones.png")
        Me.ImageList1.Images.SetKeyName(144, "compras.png")
        Me.ImageList1.Images.SetKeyName(145, "evaluaciones_de_proveedores.png")
        Me.ImageList1.Images.SetKeyName(146, "ordenes_de_compra.png")
        Me.ImageList1.Images.SetKeyName(147, "salidas_de_almacen.png")
        Me.ImageList1.Images.SetKeyName(148, "estupefacientes.png")
        Me.ImageList1.Images.SetKeyName(149, "reporte_inspeccion_calidad.png")
        Me.ImageList1.Images.SetKeyName(150, "traslado_de_la_B_2_a_la_3.png")
        Me.ImageList1.Images.SetKeyName(151, "control_estados_maquinas.png")
        Me.ImageList1.Images.SetKeyName(152, "icons8-eliminar-boleto-48.png")
        Me.ImageList1.Images.SetKeyName(153, "icons8-señal-de-stop-48.png")
        '
        'FrmGestPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 470)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnQuitarMod)
        Me.Controls.Add(Me.btnAddmodulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.listPermisosUsuario)
        Me.Controls.Add(Me.listaTipoUsu)
        Me.Name = "FrmGestPermisos"
        Me.Text = "Gestionar permisos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents listaTipoUsu As System.Windows.Forms.ListBox
    Friend WithEvents listPermisosUsuario As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddmodulo As System.Windows.Forms.Button
    Friend WithEvents btnQuitarMod As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents ImageList1 As ImageList
End Class
