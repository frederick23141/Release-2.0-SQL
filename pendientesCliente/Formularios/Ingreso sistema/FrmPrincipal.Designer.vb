<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01002- Maestro permisos", 31, 31)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01003- Maestro módulos", 32, 32)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01004- Maestro operaciones transacción", 33, 33)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01001-Maestros", 30, 30, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01005- Gestionar permisos", 34, 34)
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01006- Gestionar correo entrate y saliente", 35, 35)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01007- Auditoria de cambios", 36, 36)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01008- Gestionar usuarios", 37, 37)
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01009- Vendedores asociados a un coordinador", 38, 38)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01010- Cerrar aplicaciones en una ruta", 39, 39)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01011- Cerrar forzado", 40, 40)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01012-Manuales", 41, 41)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01013- Acerca de", 42, 42)
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("01 - Configuración", 15, 15, New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9, TreeNode10, TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02003- Estado client vend", 45, 45)
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02004- Información clientes", 46, 46)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02005- Trazabilidad clientes atendidos", 47, 47)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02006- Super módulo de consulta de terceros", 48, 48)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02002- Clientes", 44, 44, New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02008- Análisis pendientes", 51, 51)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02009- Auditoria de pedidos", 52, 52)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02010- Pendientes por ruta", 53, 53)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02011- Seguimiento de pendientes", 54, 54)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02012- Super módulo de consulta(PENDIENTES)", 48, 48)
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02013- Informe pendientes")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02007- Pendientes", 50, 50, New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24, TreeNode25})
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02015- Análisis de ventas por linea de producción", 56, 56)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02016- Análisis valor kilo", 57, 57)
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02017- Acumulado ventas", 58, 58)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02018- Acum vtas vend", 59, 59)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02019- Principales clientes", 60, 60)
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02020- Precios por debajo de", 61, 61)
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02021- Programacion correrias", 62, 62)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02022- Ventas cliente linea prod", 63, 63)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02023- Ventas cliente por ciudad", 64, 64)
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02024- Ventas client prod", 65, 65)
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02025- Ventas por zona", 66, 66)
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02026- Ventas cliente linea de producción (por mes)", 47, 47)
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02027- Super módulo  de consultas(Ventas)", 48, 48)
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02014- Ventas", 55, 55, New System.Windows.Forms.TreeNode() {TreeNode27, TreeNode28, TreeNode29, TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35, TreeNode36, TreeNode37, TreeNode38, TreeNode39})
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02029- Super módulo  de consultas(Cartera)", 48, 48)
        Dim TreeNode42 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02030- Fecha vencimiento cartera", 68, 68)
        Dim TreeNode43 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02028- Cartera", 67, 67, New System.Windows.Forms.TreeNode() {TreeNode41, TreeNode42})
        Dim TreeNode44 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02032- Super módulo  de consultas(Recaudos)", 48, 48)
        Dim TreeNode45 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02031- Recaudos", 69, 69, New System.Windows.Forms.TreeNode() {TreeNode44})
        Dim TreeNode46 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02034- Super módulo de consulta Costos por zona", 48, 48)
        Dim TreeNode47 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02033- Gastos por zona", 70, 70, New System.Windows.Forms.TreeNode() {TreeNode46})
        Dim TreeNode48 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02036- Ajuste contabilidad", 72, 72)
        Dim TreeNode49 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02035- Contabilidad", 71, 71, New System.Windows.Forms.TreeNode() {TreeNode48})
        Dim TreeNode50 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02001- Informes", 49, 49, New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode26, TreeNode40, TreeNode43, TreeNode45, TreeNode47, TreeNode49})
        Dim TreeNode51 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02038- Ingreso ventas", 73, 73)
        Dim TreeNode52 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02039- Pendientes problema", 74, 74)
        Dim TreeNode53 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02040- Seg vendedor", 75, 75)
        Dim TreeNode54 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02041- Cartera", 76, 76)
        Dim TreeNode55 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02042- Pendientes", 77, 77)
        Dim TreeNode56 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02043- Despachos", 78, 78)
        Dim TreeNode57 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02044- Movil")
        Dim TreeNode58 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02037- Ingreso ventas", 73, 73, New System.Windows.Forms.TreeNode() {TreeNode51, TreeNode52, TreeNode53, TreeNode54, TreeNode55, TreeNode56, TreeNode57})
        Dim TreeNode59 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02046- Consultar", 80, 80)
        Dim TreeNode60 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02047- Presupuesto ventas", 79, 79)
        Dim TreeNode61 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02045- Presupuesto ventas", 79, 79, New System.Windows.Forms.TreeNode() {TreeNode59, TreeNode60})
        Dim TreeNode62 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02049-Consultar ppto rec", 80, 80)
        Dim TreeNode63 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02050-Presupuesto de recaudo", 81, 81)
        Dim TreeNode64 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02048- Presupuesto recaudo", 81, 81, New System.Windows.Forms.TreeNode() {TreeNode62, TreeNode63})
        Dim TreeNode65 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02052- Seg vendedores", 47, 47)
        Dim TreeNode66 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02053- Seg presupuesto", 75, 75)
        Dim TreeNode67 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02054- Seg Lineas", 75, 75)
        Dim TreeNode68 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02056- Anticipos", 36, 36)
        Dim TreeNode69 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02057- Seguimiento de presupuestos (MES)", 48, 48)
        Dim TreeNode70 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02051- Seguimiento vendedores", 47, 47, New System.Windows.Forms.TreeNode() {TreeNode65, TreeNode66, TreeNode67, TreeNode68, TreeNode69})
        Dim TreeNode71 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02059- Quejas y reclamos", 83, 83)
        Dim TreeNode72 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02060- Encuesta clientes nacionales", 84, 84)
        Dim TreeNode73 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02061- Consultar encuestas", 80, 80)
        Dim TreeNode74 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02058- SAC", 82, 82, New System.Windows.Forms.TreeNode() {TreeNode71, TreeNode72, TreeNode73})
        Dim TreeNode75 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02063- Reglas", 86, 86)
        Dim TreeNode76 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02064- Liquidar comisiones (informe)", 87, 87)
        Dim TreeNode77 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02062- Comisiones", 85, 85, New System.Windows.Forms.TreeNode() {TreeNode75, TreeNode76})
        Dim TreeNode78 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02066- Cambiar Cart-Pend-Terceros de vendedor", 36, 36)
        Dim TreeNode79 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02065- Admisnistrar cambios", 15, 15, New System.Windows.Forms.TreeNode() {TreeNode78})
        Dim TreeNode80 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02067- Gestion de Documentación", 88, 88)
        Dim TreeNode81 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("02 - Oficinas", 43, 43, New System.Windows.Forms.TreeNode() {TreeNode50, TreeNode58, TreeNode61, TreeNode64, TreeNode70, TreeNode74, TreeNode77, TreeNode79, TreeNode80})
        Dim TreeNode82 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03002- Gestionar desperdicios", 123, 123)
        Dim TreeNode83 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03003- Inventarios de metrología", 124, 124)
        Dim TreeNode84 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03001- Ambiental", 122, 122, New System.Windows.Forms.TreeNode() {TreeNode82, TreeNode83})
        Dim TreeNode85 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03005- Recocido", 96, 96)
        Dim TreeNode86 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03006- Reporte Inspeccion calidad", 149, 149)
        Dim TreeNode87 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03004- Calidad", 95, 95, New System.Windows.Forms.TreeNode() {TreeNode85, TreeNode86})
        Dim TreeNode88 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03008- Puntilleria", 97, 97)
        Dim TreeNode89 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03009- Púas", 97, 97)
        Dim TreeNode90 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03010- Galvanizado(forma1)solo consultas", 97, 97)
        Dim TreeNode91 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03011- Galvanizado (forma2)", 97, 97)
        Dim TreeNode92 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03012- Trefilación (Forma 2)", 97, 97)
        Dim TreeNode93 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03013- Trefilación (Forma 3)", 97, 97)
        Dim TreeNode94 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03014- Pulimiento(tambores)", 97, 97)
        Dim TreeNode95 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03015- Galvanizado por baches", 97, 97)
        Dim TreeNode96 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03016- Recocido", 97, 97)
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03017- Tornilleria", 97, 97)
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03018- Tratamientos termicos (Temple)", 97, 97)
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03019- Empaque de puntilleria", 126, 126)
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03020- Transacción manual DMS-SPIC", 125, 125)
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03007- Ingreso de producción", 97, 97, New System.Windows.Forms.TreeNode() {TreeNode88, TreeNode89, TreeNode90, TreeNode91, TreeNode92, TreeNode93, TreeNode94, TreeNode95, TreeNode96, TreeNode97, TreeNode98, TreeNode99, TreeNode100})
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03023- Consultar certificados historicos", 5, 5)
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03024- Generar certificado de calidad", 98, 98)
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03025- Maestro fichas técnicas", 99, 99)
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03022- Certificados de calidad", 98, 98, New System.Windows.Forms.TreeNode() {TreeNode102, TreeNode103, TreeNode104})
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03026- Pendientes producción", 100, 100)
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03027- Historico ventas", 101, 101)
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03028- Movimiento inventario", 102, 102)
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03029- Eficiencias")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03030- Consultar transacciones Dms", 5, 5)
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03031- Trazabilidad de transacciones", 127, 127)
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03032- Informe de máximos y minimos", 127, 127)
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03033- Entradas-salidas-inventarios", 127, 127)
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03034- Entradas_salidas_DIARIO", 128, 128)
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03021- Informes", 49, 49, New System.Windows.Forms.TreeNode() {TreeNode105, TreeNode106, TreeNode107, TreeNode108, TreeNode109, TreeNode110, TreeNode111, TreeNode112, TreeNode113, TreeNode114})
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03036- Gestionar transacciones sin stock", 104, 104)
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03037- Traslado de bodega (handheld)", 105, 105)
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03038- Maestro Transaccion HandHeld", 106, 106)
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03035- Módulo traslados de bodega", 103, 103, New System.Windows.Forms.TreeNode() {TreeNode116, TreeNode117, TreeNode118})
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03040- Nuevos repuestos", 108, 108)
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03041- Solicitud de correción", 109, 109)
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03039- Mantenimiento", 107, 107, New System.Windows.Forms.TreeNode() {TreeNode120, TreeNode121})
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03043- Presupuesto de producción", 110, 110)
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03044- Seguimiento de presupuesto de producción", 127, 127)
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03045- Informe Diferencia Trefilacion", 111, 111)
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03042- Presupuesto de producción", 110, 110, New System.Windows.Forms.TreeNode() {TreeNode123, TreeNode124, TreeNode125})
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03048- Presupuesto de articulos", 113, 113)
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03047- Presupuesto de articulos", 113, 113, New System.Windows.Forms.TreeNode() {TreeNode127})
        Dim TreeNode129 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03049- Presupuesto", 114, 114)
        Dim TreeNode130 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03050- Seguimiento presupuesto de gastos y articulos", 127, 127)
        Dim TreeNode131 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03046- Presupuesto de gastos y articulos", 112, 112, New System.Windows.Forms.TreeNode() {TreeNode128, TreeNode129, TreeNode130})
        Dim TreeNode132 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03052- Generar tiquetes terminado", 116, 116)
        Dim TreeNode133 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03053- Consultar planilla separe", 117, 117)
        Dim TreeNode134 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03051- Gestionar tornilleria", 115, 115, New System.Windows.Forms.TreeNode() {TreeNode132, TreeNode133})
        Dim TreeNode135 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03055- Salida materia de prima (2-11 y 11-2)", 129, 129)
        Dim TreeNode136 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03056- Consulta materia prima (2-11 y 11-2)", 136, 136)
        Dim TreeNode137 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03057- Orden de produción galv", 130, 130)
        Dim TreeNode138 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03058- Informe producción galvanizado", 49, 49)
        Dim TreeNode139 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03059- Informe estado de rollos", 135, 135)
        Dim TreeNode140 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03060- Bobinas detenidas", 131, 131)
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03061- Tiempo trabajo", 132, 132)
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03062- Resumen galvanizado", 133, 133)
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03063- Informe de paros", 134, 134)
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03054- Galvanizado", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode135, TreeNode136, TreeNode137, TreeNode138, TreeNode139, TreeNode140, TreeNode141, TreeNode142, TreeNode143})
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03065- Consultar inventarios fisicos", 119, 119)
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03066- Auditoria Inventario", 127, 127)
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03064- Inventarios fisicos", 119, 119, New System.Windows.Forms.TreeNode() {TreeNode145, TreeNode146})
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03068- Solicitar materia prima", 35, 35)
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03069- Consultar solicitudes", 5, 5)
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03070- Orden de producción", 130, 130)
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03071- Auditoria Puntilleria", 127, 127)
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03067- Puntilleria", 121, 121, New System.Windows.Forms.TreeNode() {TreeNode148, TreeNode149, TreeNode150, TreeNode151})
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03073- Solicitar materia prima", 35, 35)
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03074- Consultar solicitudes", 5, 5)
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03075- Orden de produccion Recocido", 130, 130)
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03076- Auditoria Recocido", 127, 127)
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03077- Auditoria Tref-Rec", 127, 127)
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03078- Copia tiquete recocido", 137, 137)
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03079- Tiquete no conforme", 92, 92)
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03072- Recocido", 96, 96, New System.Windows.Forms.TreeNode() {TreeNode153, TreeNode154, TreeNode155, TreeNode156, TreeNode157, TreeNode158, TreeNode159})
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03081- Solicitar materia prima", 35, 35)
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03082- Consultar solicitudes", 5, 5)
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03083- Orden de producción operario", 130, 130)
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03084- Crear orden puas", 120, 120)
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03085- Producción de puas", 71, 71)
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03086- Informe de paros púas", 134, 134)
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03080- Alambre de Puas", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode161, TreeNode162, TreeNode163, TreeNode164, TreeNode165, TreeNode166})
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03088- Crear proyecto", 69, 69)
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03089- Consultar proyectos", 136, 136)
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03087- Gestionar proyectos", 127, 127, New System.Windows.Forms.TreeNode() {TreeNode168, TreeNode169})
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03091- Solicitud scal", 138, 138)
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03092- Solicitud scae", 138, 138)
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03093- Solicitud sar", 138, 138)
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03094- Solicitud sav", 138, 138)
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03095- Consulta de pedidos scal", 136, 136)
        Dim TreeNode176 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03096- Consulta de pedidos scae", 136, 136)
        Dim TreeNode177 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03097- Consulta de pedidos sar", 136, 136)
        Dim TreeNode178 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03098- Consulta de pedidos sav", 136, 136)
        Dim TreeNode179 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03090- Consumos scal,scae,sar y sav", 138, 138, New System.Windows.Forms.TreeNode() {TreeNode171, TreeNode172, TreeNode173, TreeNode174, TreeNode175, TreeNode176, TreeNode177, TreeNode178})
        Dim TreeNode180 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03100- Ordenes de producción", 130, 130)
        Dim TreeNode181 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03101- Auditoria de alambres", 127, 127)
        Dim TreeNode182 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03102- Generar tiquete tref NC", 139, 139)
        Dim TreeNode183 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03103- Gestionar linea de producción", 94, 94)
        Dim TreeNode184 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03104- Limite consumos alambron", 125, 125)
        Dim TreeNode185 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03105- Velocidades de codigos", 141, 141)
        Dim TreeNode186 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03106- Saldo alambron", 114, 114)
        Dim TreeNode187 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03107- Actualizar alambron", 142, 142)
        Dim TreeNode188 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03108- Consulta tref forma 3", 136, 136)
        Dim TreeNode189 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03109- Consumir Tiquetes Trefilacion", 139, 139)
        Dim TreeNode190 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03110- Detalle paros tref", 153, 153)
        Dim TreeNode191 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03099- Trefilación", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode180, TreeNode181, TreeNode182, TreeNode183, TreeNode184, TreeNode185, TreeNode186, TreeNode187, TreeNode188, TreeNode189, TreeNode190})
        Dim TreeNode192 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03112- Consumo de tornileria", 115, 115)
        Dim TreeNode193 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03111- Tornilleria", 115, 115, New System.Windows.Forms.TreeNode() {TreeNode192})
        Dim TreeNode194 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03115- consumo y producción de tref", 138, 138)
        Dim TreeNode195 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03116- consumo y producción de punt", 138, 138)
        Dim TreeNode196 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03117- consumo y produccion galv", 138, 138)
        Dim TreeNode197 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03114- Seguimiento de consumos", 138, 138, New System.Windows.Forms.TreeNode() {TreeNode194, TreeNode195, TreeNode196})
        Dim TreeNode198 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03118- Cambiar centro (Planta)", 142, 142)
        Dim TreeNode199 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03119- Auditoria", 127, 127)
        Dim TreeNode200 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("03 - Producción", 94, 94, New System.Windows.Forms.TreeNode() {TreeNode84, TreeNode87, TreeNode101, TreeNode115, TreeNode119, TreeNode122, TreeNode126, TreeNode131, TreeNode134, TreeNode144, TreeNode147, TreeNode152, TreeNode160, TreeNode167, TreeNode170, TreeNode179, TreeNode191, TreeNode193, TreeNode197, TreeNode198, TreeNode199})
        Dim TreeNode201 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04001- Informe personal Dane", 138, 138)
        Dim TreeNode202 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04002- Informe Personal Activo", 138, 138)
        Dim TreeNode203 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04003- Información de empleados", 138, 138)
        Dim TreeNode204 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04004- Informe de incapacidades y ausentismos", 137, 137)
        Dim TreeNode205 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04005- Días de vacaciones", 143, 143)
        Dim TreeNode206 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04006- Tiempos laborados", 132, 132)
        Dim TreeNode207 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04007- Rotación del personal", 142, 142)
        Dim TreeNode208 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04010- Registrar personal maquilas", 45, 45)
        Dim TreeNode209 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04011- Informe temporales", 137, 137)
        Dim TreeNode210 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04009- Personal maquilas", 45, 45, New System.Windows.Forms.TreeNode() {TreeNode208, TreeNode209})
        Dim TreeNode211 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04012- Procesar marcaciones", 141, 141)
        Dim TreeNode212 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04013- Programación de turnos", 71, 71)
        Dim TreeNode213 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04014- Gestionar periodos de corte de novedades", 107, 107)
        Dim TreeNode214 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04015- Informe de inconsistencia en marcaciones", 127, 127)
        Dim TreeNode215 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04016- Consultar compromisos", 71, 71)
        Dim TreeNode216 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04017- Informe de novedades pendientes", 71, 71)
        Dim TreeNode217 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04018- Personal en Corsan", 138, 138)
        Dim TreeNode218 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04008- Reloj", 132, 132, New System.Windows.Forms.TreeNode() {TreeNode210, TreeNode211, TreeNode212, TreeNode213, TreeNode214, TreeNode215, TreeNode216, TreeNode217})
        Dim TreeNode219 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04020- Evaluacion de desempeño", 125, 125)
        Dim TreeNode220 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04021- Consultar evaluaciónes de desempeño", 136, 136)
        Dim TreeNode221 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04022- Permisos evaluaciones", 52, 52)
        Dim TreeNode222 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04019- Evaluaciones de desempeño", 125, 125, New System.Windows.Forms.TreeNode() {TreeNode219, TreeNode220, TreeNode221})
        Dim TreeNode223 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04023- Buzon de Sugerencias", 34, 34)
        Dim TreeNode224 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04024- Consulta Solicitud de Premios", 52, 52)
        Dim TreeNode225 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04026- Gestionar contratistas", 37, 37)
        Dim TreeNode226 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04025- Contratistas", 37, 37, New System.Windows.Forms.TreeNode() {TreeNode225})
        Dim TreeNode227 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("04 - Recursos humanos", 44, 44, New System.Windows.Forms.TreeNode() {TreeNode201, TreeNode202, TreeNode203, TreeNode204, TreeNode205, TreeNode206, TreeNode207, TreeNode218, TreeNode222, TreeNode223, TreeNode224, TreeNode226})
        Dim TreeNode228 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("05001- Consultar votaciónes", 136, 136)
        Dim TreeNode229 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("05002- Gestionar grupos votación", 83, 83)
        Dim TreeNode230 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("05003- Ingresar votación", 140, 140)
        Dim TreeNode231 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("05 - Administrar votación", 83, 83, New System.Windows.Forms.TreeNode() {TreeNode228, TreeNode229, TreeNode230})
        Dim TreeNode232 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06002- Consultar", 5, 5)
        Dim TreeNode233 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06003- Evaluación", 145, 145)
        Dim TreeNode234 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06004- Graficar evaluaciones", 127, 127)
        Dim TreeNode235 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06005- Maestro proveedor-categoria", 99, 99)
        Dim TreeNode236 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06006- Gestionar_tendencias", 86, 86)
        Dim TreeNode237 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06001- Evaluación de proveedores", 145, 145, New System.Windows.Forms.TreeNode() {TreeNode232, TreeNode233, TreeNode234, TreeNode235, TreeNode236})
        Dim TreeNode238 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06008- Generar solicitud de servicio", 69, 69)
        Dim TreeNode239 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06009- Administrar solicitudes de servicios", 120, 120)
        Dim TreeNode240 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06010- Consultar material aut vs reg", 136, 136)
        Dim TreeNode241 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06007- Solicitudes de servicio", 109, 109, New System.Windows.Forms.TreeNode() {TreeNode238, TreeNode239, TreeNode240})
        Dim TreeNode242 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06012- Administrar ordenes de compra", 144, 144)
        Dim TreeNode243 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06013- Generar orden de compra", 69, 69)
        Dim TreeNode244 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06011- Ordenes de compra", 144, 144, New System.Windows.Forms.TreeNode() {TreeNode242, TreeNode243})
        Dim TreeNode245 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06015- Generar salida de almacen", 147, 147)
        Dim TreeNode246 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06016- Consultar salidas de almacen", 136, 136)
        Dim TreeNode247 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06014- Salidas de almacen", 147, 147, New System.Windows.Forms.TreeNode() {TreeNode245, TreeNode246})
        Dim TreeNode248 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06018- Salida de alambrón", 118, 118)
        Dim TreeNode249 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06019- Consultar salida de alambrón", 136, 136)
        Dim TreeNode250 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06017- Salidas de alambrón", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode248, TreeNode249})
        Dim TreeNode251 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06021- Tiquetes de alambrón", 116, 116)
        Dim TreeNode252 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06022- Auditoria de ingreso de materia prima", 127, 127)
        Dim TreeNode253 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06024- Planillas de descargue de alambrón", 78, 78)
        Dim TreeNode254 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06025- Menú principal Hand-Held", 105, 105)
        Dim TreeNode255 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06026- Inhabilitar tiquetes alambrón", 152, 152)
        Dim TreeNode256 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06020- Gestión de alambrón", 118, 118, New System.Windows.Forms.TreeNode() {TreeNode251, TreeNode252, TreeNode253, TreeNode254, TreeNode255})
        Dim TreeNode257 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06028- Información estupefacientes", 148, 148)
        Dim TreeNode258 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06027- Estupefacientes", 148, 148, New System.Windows.Forms.TreeNode() {TreeNode257})
        Dim TreeNode259 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06030- Generar tiquetes producto temrinado", 116, 116)
        Dim TreeNode260 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06029- Tiquetes producto terminado", 116, 116, New System.Windows.Forms.TreeNode() {TreeNode259})
        Dim TreeNode261 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("06 - Compras", 144, 144, New System.Windows.Forms.TreeNode() {TreeNode237, TreeNode241, TreeNode244, TreeNode247, TreeNode250, TreeNode256, TreeNode258, TreeNode260})
        Dim TreeNode262 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("07001- Consultar procedimientos", 136, 136)
        Dim TreeNode263 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("07002- Gestionar procedimientos", 69, 69)
        Dim TreeNode264 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("07003- Maestro cargos", 99, 99)
        Dim TreeNode265 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("07 - Auditoria", 127, 127, New System.Windows.Forms.TreeNode() {TreeNode262, TreeNode263, TreeNode264})
        Dim TreeNode266 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08001- Cambiar pedido bodega", 36, 36)
        Dim TreeNode267 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08002- Relación factura-pedido-entrega", 90, 90)
        Dim TreeNode268 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08003- Formato impresión etiquetas", 27, 27)
        Dim TreeNode269 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08004- Gestionar producto no conforme", 10, 10)
        Dim TreeNode270 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08005- Traslado de la  B 2 a la 3", 150, 150)
        Dim TreeNode271 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08006- Control Esatado maquinas", 151, 151)
        Dim TreeNode272 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("08 - Logistica", 89, 89, New System.Windows.Forms.TreeNode() {TreeNode266, TreeNode267, TreeNode268, TreeNode269, TreeNode270, TreeNode271})
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim BorderEdges12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges13 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges14 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges15 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges16 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges17 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges18 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges19 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges20 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges22 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges23 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges24 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges25 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges26 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges27 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges28 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges29 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges30 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim Animation1 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Dim Animation2 As Bunifu.UI.WinForms.BunifuAnimatorNS.Animation = New Bunifu.UI.WinForms.BunifuAnimatorNS.Animation()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.timNotificarCerrarAplicacion = New System.Windows.Forms.Timer(Me.components)
        Me.timCerrarApp = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_db_corsan = New System.Windows.Forms.Label()
        Me.lbl_db_produccion = New System.Windows.Forms.Label()
        Me.lbl_db_control = New System.Windows.Forms.Label()
        Me.autocierre = New System.Windows.Forms.Timer(Me.components)
        Me.groupRutaCerrar = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar_noti = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.btnCerrarGroup = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.tab_men_ppal = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_men_prod = New System.Windows.Forms.TabPage()
        Me.panelPPTO = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtg_consumo_alambron = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblpkg = New System.Windows.Forms.Label()
        Me.lblpptopkg = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BunifuSeparator3 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.lbldiastrab = New System.Windows.Forms.Label()
        Me.lbldiasadd = New System.Windows.Forms.Label()
        Me.lbldiashabiles = New System.Windows.Forms.Label()
        Me.BunifuPictureBox2 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuSeparator2 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgress2 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.lblllevamoscant = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblptocantidad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuImageButton1 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_mes_prod = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.cbo_ano_prod = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.FVanosprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRGPRODUCCIONDataSet2 = New Spic.PRGPRODUCCIONDataSet2()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuSeparator1 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgress1 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.lblcentro = New System.Windows.Forms.Label()
        Me.lblllevamos = New System.Windows.Forms.Label()
        Me.lblpptoprod = New System.Windows.Forms.Label()
        Me.bunitable = New Bunifu.UI.WinForms.BunifuDataGridView()
        Me.GunaWinSwitch1 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.BunifuChartCanvas1 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuButton11 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton10 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton9 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton8 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton7 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton6 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton5 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton4 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton3 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton2 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton1 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.dtd = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.tab_men_gastos = New System.Windows.Forms.TabPage()
        Me.PanelGastos = New Guna.UI2.WinForms.Guna2Panel()
        Me.BunifuCards6 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtgasto = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.txtgastoprod = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel16 = New Guna.UI.WinForms.GunaLabel()
        Me.txtgastoadmin = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuSeparator7 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuSeparator8 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuSeparator9 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.GunaLabel20 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuPictureBox7 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.groupDetalle = New System.Windows.Forms.GroupBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.dtg_detalle = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuPanel2 = New Bunifu.UI.WinForms.BunifuPanel()
        Me.dtg_consulta = New System.Windows.Forms.DataGridView()
        Me.menStripDtg = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itemDetalle = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuImageButton2 = New Bunifu.UI.WinForms.BunifuImageButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgress3 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BunifuDropdown1 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuDropdown2 = New Bunifu.UI.WinForms.BunifuDropdown()
        Me.BunifuCards5 = New Bunifu.Framework.UI.BunifuCards()
        Me.txtporcentajeinherente = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel21 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuRadialGauge1 = New Bunifu.UI.WinForms.BunifuRadialGauge()
        Me.txttotcentro = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuPictureBox6 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuPictureBox5 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuSeparator11 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuPictureBox4 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuSeparator10 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.txtgastocentro = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpptocentro = New Guna.UI.WinForms.GunaLabel()
        Me.labelcentroppto = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuCircleProgress4 = New Bunifu.UI.WinForms.BunifuCircleProgress()
        Me.BunifuCards4 = New Bunifu.Framework.UI.BunifuCards()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpresupuestoprod = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpresupuestoadmin = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuSeparator6 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpresupuesto = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuSeparator5 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.BunifuSeparator4 = New Bunifu.UI.WinForms.BunifuSeparator()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuPictureBox3 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.BunifuChartCanvas3 = New Bunifu.Charts.WinForms.BunifuChartCanvas()
        Me.BunifuButton25 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton30 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton26 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton27 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton28 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton29 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton15 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton16 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton17 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton18 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton19 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton20 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton21 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton22 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton23 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton24 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton14 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton12 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BunifuButton13 = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.lblvariables = New Guna.UI.WinForms.GunaLabel()
        Me.checkvariables = New Guna.UI.WinForms.GunaWinSwitch()
        Me.btn_buzon = New System.Windows.Forms.Button()
        Me.cierre_forzado = New System.Windows.Forms.Timer(Me.components)
        Me.timer_ping_bd = New System.Windows.Forms.Timer(Me.components)
        Me.lblNom = New Guna.UI.WinForms.GunaLabel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.imgSlide3 = New System.Windows.Forms.PictureBox()
        Me.imgSlide2 = New System.Windows.Forms.PictureBox()
        Me.imgSlide1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.imgSlideH = New System.Windows.Forms.PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button7 = New Guna.UI2.WinForms.Guna2Button()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SolidGaugeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SolidGaugeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.BunifuLineChart = New Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(Me.components)
        Me.BunifuTransition1 = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.txtFilterToolIDs = New System.Windows.Forms.TextBox()
        Me.F_V_anos_prodTableAdapter = New Spic.PRGPRODUCCIONDataSet2TableAdapters.F_V_anos_prodTableAdapter()
        Me.BunifuLineChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(Me.components)
        Me.BunifuBarChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.BunifuPieChart1 = New Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(Me.components)
        Me.BunifuBarChartppto = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.BunifuBarChartgasto = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.BunifuTransition2 = New Bunifu.UI.WinForms.BunifuTransition(Me.components)
        Me.groupRutaCerrar.SuspendLayout
        Me.tab_men_ppal.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.tab_men_prod.SuspendLayout
        Me.panelPPTO.SuspendLayout
        CType(Me.dtg_consumo_alambron, System.ComponentModel.ISupportInitialize).BeginInit
        Me.BunifuCards3.SuspendLayout
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.BunifuCards2.SuspendLayout
        CType(Me.FVanosprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PRGPRODUCCIONDataSet2, System.ComponentModel.ISupportInitialize).BeginInit
        Me.BunifuCards1.SuspendLayout
        CType(Me.bunitable, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dtd, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tab_men_gastos.SuspendLayout
        Me.PanelGastos.SuspendLayout
        Me.BunifuCards6.SuspendLayout
        CType(Me.BunifuPictureBox7, System.ComponentModel.ISupportInitialize).BeginInit
        Me.groupDetalle.SuspendLayout
        CType(Me.dtg_detalle, System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip1.SuspendLayout
        Me.BunifuPanel2.SuspendLayout
        CType(Me.dtg_consulta, System.ComponentModel.ISupportInitialize).BeginInit
        Me.menStripDtg.SuspendLayout
        Me.BunifuCards5.SuspendLayout
        CType(Me.BunifuPictureBox6, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BunifuPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit
        Me.BunifuCards4.SuspendLayout
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        Me.guna2CustomGradientPanel1.SuspendLayout
        CType(Me.imgSlide3, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgSlide2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgSlide1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgSlideH, System.ComponentModel.ISupportInitialize).BeginInit
        Me.Guna2Panel1.SuspendLayout
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SolidGaugeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SolidGaugeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        'timNotificarCerrarAplicacion
        '
        Me.timNotificarCerrarAplicacion.Enabled = True
        Me.timNotificarCerrarAplicacion.Interval = 120000
        '
        'timCerrarApp
        '
        Me.timCerrarApp.Interval = 60000
        '
        'lbl_db_corsan
        '
        Me.lbl_db_corsan.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_db_corsan.AutoSize = True
        Me.lbl_db_corsan.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbl_db_corsan, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl_db_corsan, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbl_db_corsan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_db_corsan.ForeColor = System.Drawing.Color.White
        Me.lbl_db_corsan.Location = New System.Drawing.Point(126, 6)
        Me.lbl_db_corsan.Name = "lbl_db_corsan"
        Me.lbl_db_corsan.Size = New System.Drawing.Size(81, 16)
        Me.lbl_db_corsan.TabIndex = 1027
        Me.lbl_db_corsan.Text = "db_corsan"
        '
        'lbl_db_produccion
        '
        Me.lbl_db_produccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_db_produccion.AutoSize = True
        Me.lbl_db_produccion.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbl_db_produccion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl_db_produccion, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbl_db_produccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_db_produccion.ForeColor = System.Drawing.Color.White
        Me.lbl_db_produccion.Location = New System.Drawing.Point(601, 6)
        Me.lbl_db_produccion.Name = "lbl_db_produccion"
        Me.lbl_db_produccion.Size = New System.Drawing.Size(111, 16)
        Me.lbl_db_produccion.TabIndex = 1028
        Me.lbl_db_produccion.Text = "db_produccion"
        '
        'lbl_db_control
        '
        Me.lbl_db_control.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_db_control.AutoSize = True
        Me.lbl_db_control.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbl_db_control, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbl_db_control, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbl_db_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_db_control.ForeColor = System.Drawing.Color.White
        Me.lbl_db_control.Location = New System.Drawing.Point(1150, 6)
        Me.lbl_db_control.Name = "lbl_db_control"
        Me.lbl_db_control.Size = New System.Drawing.Size(81, 16)
        Me.lbl_db_control.TabIndex = 1029
        Me.lbl_db_control.Text = "db_control"
        '
        'autocierre
        '
        Me.autocierre.Interval = 60000
        '
        'groupRutaCerrar
        '
        Me.groupRutaCerrar.BackColor = System.Drawing.Color.Gainsboro
        Me.groupRutaCerrar.Controls.Add(Me.btn_cancelar_noti)
        Me.groupRutaCerrar.Controls.Add(Me.Label1)
        Me.groupRutaCerrar.Controls.Add(Me.txt_ruta)
        Me.groupRutaCerrar.Controls.Add(Me.btnCerrarGroup)
        Me.groupRutaCerrar.Controls.Add(Me.btnEnviar)
        Me.BunifuTransition2.SetDecoration(Me.groupRutaCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.groupRutaCerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.groupRutaCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupRutaCerrar.ForeColor = System.Drawing.Color.Red
        Me.groupRutaCerrar.Location = New System.Drawing.Point(356, 29)
        Me.groupRutaCerrar.Name = "groupRutaCerrar"
        Me.groupRutaCerrar.Size = New System.Drawing.Size(371, 126)
        Me.groupRutaCerrar.TabIndex = 2222223
        Me.groupRutaCerrar.TabStop = False
        Me.groupRutaCerrar.Text = "Ingrese ruta para notificar"
        Me.groupRutaCerrar.Visible = False
        '
        'btn_cancelar_noti
        '
        Me.BunifuTransition1.SetDecoration(Me.btn_cancelar_noti, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn_cancelar_noti, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btn_cancelar_noti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_noti.ForeColor = System.Drawing.Color.Black
        Me.btn_cancelar_noti.Image = CType(resources.GetObject("btn_cancelar_noti.Image"), System.Drawing.Image)
        Me.btn_cancelar_noti.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelar_noti.Location = New System.Drawing.Point(6, 91)
        Me.btn_cancelar_noti.Name = "btn_cancelar_noti"
        Me.btn_cancelar_noti.Size = New System.Drawing.Size(159, 23)
        Me.btn_cancelar_noti.TabIndex = 1187
        Me.btn_cancelar_noti.Text = "Cancelar proceso"
        Me.btn_cancelar_noti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_noti.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.BunifuTransition1.SetDecoration(Me.Label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 13)
        Me.Label1.TabIndex = 1186
        Me.Label1.Text = "Ejemplo: \\sst\Dms_con\AQUI PROGRAMA\SPIC\Oficinas\Debug"
        '
        'txt_ruta
        '
        Me.txt_ruta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ruta.BackColor = System.Drawing.Color.Lime
        Me.BunifuTransition1.SetDecoration(Me.txt_ruta, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.txt_ruta, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txt_ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruta.Location = New System.Drawing.Point(6, 56)
        Me.txt_ruta.MaxLength = 5000
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(354, 20)
        Me.txt_ruta.TabIndex = 1115
        '
        'btnCerrarGroup
        '
        Me.btnCerrarGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.btnCerrarGroup, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btnCerrarGroup, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btnCerrarGroup.ForeColor = System.Drawing.Color.Red
        Me.btnCerrarGroup.Location = New System.Drawing.Point(343, 8)
        Me.btnCerrarGroup.Name = "btnCerrarGroup"
        Me.btnCerrarGroup.Size = New System.Drawing.Size(26, 23)
        Me.btnCerrarGroup.TabIndex = 1185
        Me.btnCerrarGroup.Text = "X"
        Me.btnCerrarGroup.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.BunifuTransition1.SetDecoration(Me.btnEnviar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btnEnviar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.ForeColor = System.Drawing.Color.Black
        Me.btnEnviar.Image = CType(resources.GetObject("btnEnviar.Image"), System.Drawing.Image)
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEnviar.Location = New System.Drawing.Point(201, 91)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(159, 23)
        Me.btnEnviar.TabIndex = 1180
        Me.btnEnviar.Text = "Enviar notificación"
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'tab_men_ppal
        '
        Me.tab_men_ppal.Controls.Add(Me.groupRutaCerrar)
        Me.tab_men_ppal.Controls.Add(Me.TreeView1)
        Me.BunifuTransition2.SetDecoration(Me.tab_men_ppal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.tab_men_ppal, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.tab_men_ppal.Location = New System.Drawing.Point(4, 24)
        Me.tab_men_ppal.Name = "tab_men_ppal"
        Me.tab_men_ppal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_men_ppal.Size = New System.Drawing.Size(1226, 622)
        Me.tab_men_ppal.TabIndex = 2
        Me.tab_men_ppal.Text = "Menù principal"
        Me.tab_men_ppal.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuTransition1.SetDecoration(Me.TreeView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.TreeView1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList1
        Me.TreeView1.ItemHeight = 30
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 31
        TreeNode1.Name = "nodMaestroPermiso"
        TreeNode1.SelectedImageIndex = 31
        TreeNode1.Text = "01002- Maestro permisos"
        TreeNode2.ImageIndex = 32
        TreeNode2.Name = "nodMaestroModulo"
        TreeNode2.SelectedImageIndex = 32
        TreeNode2.Text = "01003- Maestro módulos"
        TreeNode3.ImageIndex = 33
        TreeNode3.Name = "nodOpTransaccion"
        TreeNode3.SelectedImageIndex = 33
        TreeNode3.Text = "01004- Maestro operaciones transacción"
        TreeNode4.ImageIndex = 30
        TreeNode4.Name = "Raiz_maestros"
        TreeNode4.SelectedImageIndex = 30
        TreeNode4.Text = "01001-Maestros"
        TreeNode5.ImageIndex = 34
        TreeNode5.Name = "nodGestPermisos"
        TreeNode5.SelectedImageIndex = 34
        TreeNode5.Text = "01005- Gestionar permisos"
        TreeNode6.ImageIndex = 35
        TreeNode6.Name = "nodMaeIpCorreos"
        TreeNode6.SelectedImageIndex = 35
        TreeNode6.Text = "01006- Gestionar correo entrate y saliente"
        TreeNode7.ImageIndex = 36
        TreeNode7.Name = "nodAuditCambios"
        TreeNode7.SelectedImageIndex = 36
        TreeNode7.Text = "01007- Auditoria de cambios"
        TreeNode8.ImageIndex = 37
        TreeNode8.Name = "nodGestUsu"
        TreeNode8.SelectedImageIndex = 37
        TreeNode8.Text = "01008- Gestionar usuarios"
        TreeNode9.ImageIndex = 38
        TreeNode9.Name = "nodMaeCoordVend"
        TreeNode9.SelectedImageIndex = 38
        TreeNode9.Text = "01009- Vendedores asociados a un coordinador"
        TreeNode10.ImageIndex = 39
        TreeNode10.Name = "nod_cerrar_por_ruta"
        TreeNode10.SelectedImageIndex = 39
        TreeNode10.Text = "01010- Cerrar aplicaciones en una ruta"
        TreeNode11.ImageIndex = 40
        TreeNode11.Name = "nod_cerrar_for"
        TreeNode11.SelectedImageIndex = 40
        TreeNode11.Text = "01011- Cerrar forzado"
        TreeNode12.ImageIndex = 41
        TreeNode12.Name = "nod_manual"
        TreeNode12.SelectedImageIndex = 41
        TreeNode12.Text = "01012-Manuales"
        TreeNode13.ImageIndex = 42
        TreeNode13.Name = "nod_Acerca_de"
        TreeNode13.SelectedImageIndex = 42
        TreeNode13.Text = "01013- Acerca de"
        TreeNode14.ImageIndex = 15
        TreeNode14.Name = "Raiz_config"
        TreeNode14.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode14.SelectedImageIndex = 15
        TreeNode14.Text = "01 - Configuración"
        TreeNode15.ImageIndex = 45
        TreeNode15.Name = "nod_est_clien_vend"
        TreeNode15.SelectedImageIndex = 45
        TreeNode15.Text = "02003- Estado client vend"
        TreeNode16.ImageIndex = 46
        TreeNode16.Name = "nod_info_clientes"
        TreeNode16.SelectedImageIndex = 46
        TreeNode16.Text = "02004- Información clientes"
        TreeNode17.ImageIndex = 47
        TreeNode17.Name = "nod_Trazabilidad_clientes_atendidos"
        TreeNode17.SelectedImageIndex = 47
        TreeNode17.Text = "02005- Trazabilidad clientes atendidos"
        TreeNode18.ImageIndex = 48
        TreeNode18.Name = "nod_super_modulo_consult_terceros"
        TreeNode18.SelectedImageIndex = 48
        TreeNode18.Text = "02006- Super módulo de consulta de terceros"
        TreeNode19.ImageIndex = 44
        TreeNode19.Name = "Raiz_clientes"
        TreeNode19.SelectedImageIndex = 44
        TreeNode19.Text = "02002- Clientes"
        TreeNode20.ImageIndex = 51
        TreeNode20.Name = "nod_an_pend"
        TreeNode20.SelectedImageIndex = 51
        TreeNode20.Text = "02008- Análisis pendientes"
        TreeNode21.ImageIndex = 52
        TreeNode21.Name = "nod_audit_ped"
        TreeNode21.SelectedImageIndex = 52
        TreeNode21.Text = "02009- Auditoria de pedidos"
        TreeNode22.ImageIndex = 53
        TreeNode22.Name = "nod_pend_zona"
        TreeNode22.SelectedImageIndex = 53
        TreeNode22.Text = "02010- Pendientes por ruta"
        TreeNode23.ImageIndex = 54
        TreeNode23.Name = "nod_seg_pendientes"
        TreeNode23.SelectedImageIndex = 54
        TreeNode23.Text = "02011- Seguimiento de pendientes"
        TreeNode24.ImageIndex = 48
        TreeNode24.Name = "nod_super_modulo_consult_pendientes"
        TreeNode24.SelectedImageIndex = 48
        TreeNode24.Text = "02012- Super módulo de consulta(PENDIENTES)"
        TreeNode25.Name = "Nodo_pendientes"
        TreeNode25.Text = "02013- Informe pendientes"
        TreeNode26.ImageIndex = 50
        TreeNode26.Name = "Raiz_pendientes"
        TreeNode26.SelectedImageIndex = 50
        TreeNode26.Text = "02007- Pendientes"
        TreeNode27.ImageIndex = 56
        TreeNode27.Name = "nod_AnalisisVentas"
        TreeNode27.SelectedImageIndex = 56
        TreeNode27.Text = "02015- Análisis de ventas por linea de producción"
        TreeNode28.ImageIndex = 57
        TreeNode28.Name = "nod_anali_vrKilo"
        TreeNode28.SelectedImageIndex = 57
        TreeNode28.Text = "02016- Análisis valor kilo"
        TreeNode29.ImageIndex = 58
        TreeNode29.Name = "nod_acum_vtas"
        TreeNode29.SelectedImageIndex = 58
        TreeNode29.Text = "02017- Acumulado ventas"
        TreeNode30.ImageIndex = 59
        TreeNode30.Name = "nod_acum_vtas_vend"
        TreeNode30.SelectedImageIndex = 59
        TreeNode30.Text = "02018- Acum vtas vend"
        TreeNode31.ImageIndex = 60
        TreeNode31.Name = "nod_ppal_clientes"
        TreeNode31.SelectedImageIndex = 60
        TreeNode31.Text = "02019- Principales clientes"
        TreeNode32.ImageIndex = 61
        TreeNode32.Name = "nodPrecProd"
        TreeNode32.SelectedImageIndex = 61
        TreeNode32.Text = "02020- Precios por debajo de"
        TreeNode33.ImageIndex = 62
        TreeNode33.Name = "nod_correrias"
        TreeNode33.SelectedImageIndex = 62
        TreeNode33.Text = "02021- Programacion correrias"
        TreeNode34.ImageIndex = 63
        TreeNode34.Name = "nod_vtas_client_idCor"
        TreeNode34.SelectedImageIndex = 63
        TreeNode34.Text = "02022- Ventas cliente linea prod"
        TreeNode35.ImageIndex = 64
        TreeNode35.Name = "nod_Vtas_lin_ciuid"
        TreeNode35.SelectedImageIndex = 64
        TreeNode35.Text = "02023- Ventas cliente por ciudad"
        TreeNode36.ImageIndex = 65
        TreeNode36.Name = "nod_vtas_clie_prod"
        TreeNode36.SelectedImageIndex = 65
        TreeNode36.Text = "02024- Ventas client prod"
        TreeNode37.ImageIndex = 66
        TreeNode37.Name = "nod_vtas_zona"
        TreeNode37.SelectedImageIndex = 66
        TreeNode37.Text = "02025- Ventas por zona"
        TreeNode38.ImageIndex = 47
        TreeNode38.Name = "nod_vtas_cliente_linea_mes"
        TreeNode38.SelectedImageIndex = 47
        TreeNode38.Text = "02026- Ventas cliente linea de producción (por mes)"
        TreeNode39.ImageIndex = 48
        TreeNode39.Name = "nod_super_modulo_consult_vtas"
        TreeNode39.SelectedImageIndex = 48
        TreeNode39.Text = "02027- Super módulo  de consultas(Ventas)"
        TreeNode40.ImageIndex = 55
        TreeNode40.Name = "Raiz_ventas"
        TreeNode40.SelectedImageIndex = 55
        TreeNode40.Text = "02014- Ventas"
        TreeNode41.ImageIndex = 48
        TreeNode41.Name = "nod_super_modulo_consult_cartera"
        TreeNode41.SelectedImageIndex = 48
        TreeNode41.Text = "02029- Super módulo  de consultas(Cartera)"
        TreeNode42.ImageIndex = 68
        TreeNode42.Name = "nod_fecha_venc_cartera"
        TreeNode42.SelectedImageIndex = 68
        TreeNode42.Text = "02030- Fecha vencimiento cartera"
        TreeNode43.ImageIndex = 67
        TreeNode43.Name = "Raiz_cartera"
        TreeNode43.SelectedImageIndex = 67
        TreeNode43.Text = "02028- Cartera"
        TreeNode44.ImageIndex = 48
        TreeNode44.Name = "nod_super_modulo_consult_recaudos"
        TreeNode44.SelectedImageIndex = 48
        TreeNode44.Text = "02032- Super módulo  de consultas(Recaudos)"
        TreeNode45.ImageIndex = 69
        TreeNode45.Name = "Raiz_recaudos"
        TreeNode45.SelectedImageIndex = 69
        TreeNode45.Text = "02031- Recaudos"
        TreeNode46.ImageIndex = 48
        TreeNode46.Name = "nod_super_modulo_consult_gastos_vendedor"
        TreeNode46.SelectedImageIndex = 48
        TreeNode46.Text = "02034- Super módulo de consulta Costos por zona"
        TreeNode47.ImageIndex = 70
        TreeNode47.Name = "nod_gastos_zona_ventas"
        TreeNode47.SelectedImageIndex = 70
        TreeNode47.Text = "02033- Gastos por zona"
        TreeNode48.ImageIndex = 72
        TreeNode48.Name = "nod_Ajus_Conts"
        TreeNode48.SelectedImageIndex = 72
        TreeNode48.Text = "02036- Ajuste contabilidad"
        TreeNode49.ImageIndex = 71
        TreeNode49.Name = "nod_Conta_Menu"
        TreeNode49.SelectedImageIndex = 71
        TreeNode49.Text = "02035- Contabilidad"
        TreeNode50.BackColor = System.Drawing.Color.Transparent
        TreeNode50.ForeColor = System.Drawing.Color.Black
        TreeNode50.ImageIndex = 49
        TreeNode50.Name = "Raiz_informes"
        TreeNode50.SelectedImageIndex = 49
        TreeNode50.Text = "02001- Informes"
        TreeNode51.ImageIndex = 73
        TreeNode51.Name = "nod_ing_vtas"
        TreeNode51.SelectedImageIndex = 73
        TreeNode51.Text = "02038- Ingreso ventas"
        TreeNode52.ImageIndex = 74
        TreeNode52.Name = "nod_pend_prob"
        TreeNode52.SelectedImageIndex = 74
        TreeNode52.Text = "02039- Pendientes problema"
        TreeNode53.ImageIndex = 75
        TreeNode53.Name = "nod_seg_vend"
        TreeNode53.SelectedImageIndex = 75
        TreeNode53.Text = "02040- Seg vendedor"
        TreeNode54.ImageIndex = 76
        TreeNode54.Name = "nod_cartera_ing_vtas"
        TreeNode54.SelectedImageIndex = 76
        TreeNode54.Text = "02041- Cartera"
        TreeNode55.ImageIndex = 77
        TreeNode55.Name = "nod_pendientes_vend"
        TreeNode55.SelectedImageIndex = 77
        TreeNode55.Text = "02042- Pendientes"
        TreeNode56.ImageIndex = 78
        TreeNode56.Name = "nod_despachos"
        TreeNode56.SelectedImageIndex = 78
        TreeNode56.Text = "02043- Despachos"
        TreeNode57.Name = "nodIngVtasMovil"
        TreeNode57.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode57.Text = "02044- Movil"
        TreeNode58.ImageIndex = 73
        TreeNode58.Name = "Raiz_ing_vtas"
        TreeNode58.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode58.SelectedImageIndex = 73
        TreeNode58.Text = "02037- Ingreso ventas"
        TreeNode59.ImageIndex = 80
        TreeNode59.Name = "nod_consult_ppto_vtas"
        TreeNode59.SelectedImageIndex = 80
        TreeNode59.Text = "02046- Consultar"
        TreeNode60.ImageIndex = 79
        TreeNode60.Name = "nod_ppto_vtas"
        TreeNode60.SelectedImageIndex = 79
        TreeNode60.Text = "02047- Presupuesto ventas"
        TreeNode61.ImageIndex = 79
        TreeNode61.Name = "Raiz_ppto_vtas"
        TreeNode61.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode61.SelectedImageIndex = 79
        TreeNode61.Text = "02045- Presupuesto ventas"
        TreeNode62.ImageIndex = 80
        TreeNode62.Name = "nod_consul_ppto_rec"
        TreeNode62.SelectedImageIndex = 80
        TreeNode62.Text = "02049-Consultar ppto rec"
        TreeNode63.ImageIndex = 81
        TreeNode63.Name = "nod_ppto_rec"
        TreeNode63.SelectedImageIndex = 81
        TreeNode63.Text = "02050-Presupuesto de recaudo"
        TreeNode64.ImageIndex = 81
        TreeNode64.Name = "Raiz_ppto_rec"
        TreeNode64.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode64.SelectedImageIndex = 81
        TreeNode64.Text = "02048- Presupuesto recaudo"
        TreeNode65.ImageIndex = 47
        TreeNode65.Name = "nod_seg_vend"
        TreeNode65.SelectedImageIndex = 47
        TreeNode65.Text = "02052- Seg vendedores"
        TreeNode66.ImageIndex = 75
        TreeNode66.Name = "nod_seg_ppto"
        TreeNode66.SelectedImageIndex = 75
        TreeNode66.Text = "02053- Seg presupuesto"
        TreeNode67.ImageIndex = 75
        TreeNode67.Name = "nod_seg_grupos"
        TreeNode67.SelectedImageIndex = 75
        TreeNode67.Text = "02054- Seg Lineas"
        TreeNode68.ImageIndex = 36
        TreeNode68.Name = "nod_anticipos"
        TreeNode68.SelectedImageIndex = 36
        TreeNode68.Text = "02056- Anticipos"
        TreeNode69.ImageIndex = 48
        TreeNode69.Name = "nod_seguimiento_ppto_mes"
        TreeNode69.SelectedImageIndex = 48
        TreeNode69.Text = "02057- Seguimiento de presupuestos (MES)"
        TreeNode70.ImageIndex = 47
        TreeNode70.Name = "Raiz_nod_seg_vend"
        TreeNode70.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode70.SelectedImageIndex = 47
        TreeNode70.Text = "02051- Seguimiento vendedores"
        TreeNode71.ImageIndex = 83
        TreeNode71.Name = "nodQuejasRec"
        TreeNode71.SelectedImageIndex = 83
        TreeNode71.Text = "02059- Quejas y reclamos"
        TreeNode72.ImageIndex = 84
        TreeNode72.Name = "nod_encu_clientes"
        TreeNode72.SelectedImageIndex = 84
        TreeNode72.Text = "02060- Encuesta clientes nacionales"
        TreeNode73.ImageIndex = 80
        TreeNode73.Name = "nod_consult_encuesta_cliente"
        TreeNode73.SelectedImageIndex = 80
        TreeNode73.Text = "02061- Consultar encuestas"
        TreeNode73.ToolTipText = "Consultar encuestas"
        TreeNode74.ImageIndex = 82
        TreeNode74.Name = "RaizSac"
        TreeNode74.SelectedImageIndex = 82
        TreeNode74.Text = "02058- SAC"
        TreeNode75.ImageIndex = 86
        TreeNode75.Name = "nod_reglas_comisiones"
        TreeNode75.SelectedImageIndex = 86
        TreeNode75.Text = "02063- Reglas"
        TreeNode76.ImageIndex = 87
        TreeNode76.Name = "nod_liquidacion_com"
        TreeNode76.SelectedImageIndex = 87
        TreeNode76.Text = "02064- Liquidar comisiones (informe)"
        TreeNode77.ImageIndex = 85
        TreeNode77.Name = "Raiz_comisiones"
        TreeNode77.SelectedImageIndex = 85
        TreeNode77.Text = "02062- Comisiones"
        TreeNode78.ImageIndex = 36
        TreeNode78.Name = "nod_cambio_cliente_vendedor"
        TreeNode78.SelectedImageIndex = 36
        TreeNode78.Text = "02066- Cambiar Cart-Pend-Terceros de vendedor"
        TreeNode79.ImageIndex = 15
        TreeNode79.Name = "Raiz_administrar_cambios"
        TreeNode79.SelectedImageIndex = 15
        TreeNode79.Text = "02065- Admisnistrar cambios"
        TreeNode80.ImageIndex = 88
        TreeNode80.Name = "nod_gest_doc"
        TreeNode80.SelectedImageIndex = 88
        TreeNode80.Text = "02067- Gestion de Documentación"
        TreeNode81.ImageIndex = 43
        TreeNode81.Name = "Raiz_ofic"
        TreeNode81.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode81.SelectedImageIndex = 43
        TreeNode81.Text = "02 - Oficinas"
        TreeNode82.ImageIndex = 123
        TreeNode82.Name = "nod_gest_desperdicios"
        TreeNode82.SelectedImageIndex = 123
        TreeNode82.Text = "03002- Gestionar desperdicios"
        TreeNode83.ImageIndex = 124
        TreeNode83.Name = "nod_inv_metrologia"
        TreeNode83.SelectedImageIndex = 124
        TreeNode83.Text = "03003- Inventarios de metrología"
        TreeNode84.ImageIndex = 122
        TreeNode84.Name = "Raiz_ambiental"
        TreeNode84.SelectedImageIndex = 122
        TreeNode84.Text = "03001- Ambiental"
        TreeNode85.ImageIndex = 96
        TreeNode85.Name = "nod_recocido_calidad"
        TreeNode85.SelectedImageIndex = 96
        TreeNode85.Text = "03005- Recocido"
        TreeNode86.ImageIndex = 149
        TreeNode86.Name = "nod_reporte_inspeccion_calidad"
        TreeNode86.SelectedImageIndex = 149
        TreeNode86.Text = "03006- Reporte Inspeccion calidad"
        TreeNode87.ImageIndex = 95
        TreeNode87.Name = "Raiz_calidad"
        TreeNode87.SelectedImageIndex = 95
        TreeNode87.Text = "03004- Calidad"
        TreeNode88.ImageIndex = 97
        TreeNode88.Name = "nod_ing_punt"
        TreeNode88.SelectedImageIndex = 97
        TreeNode88.Text = "03008- Puntilleria"
        TreeNode89.ImageIndex = 97
        TreeNode89.Name = "nod_ing_puas"
        TreeNode89.SelectedImageIndex = 97
        TreeNode89.Text = "03009- Púas"
        TreeNode90.ImageIndex = 97
        TreeNode90.Name = "nod_ing_galv"
        TreeNode90.SelectedImageIndex = 97
        TreeNode90.Text = "03010- Galvanizado(forma1)solo consultas"
        TreeNode91.ImageIndex = 97
        TreeNode91.Name = "nod_galv_f2"
        TreeNode91.SelectedImageIndex = 97
        TreeNode91.Text = "03011- Galvanizado (forma2)"
        TreeNode92.ImageIndex = 97
        TreeNode92.Name = "nodTref3"
        TreeNode92.SelectedImageIndex = 97
        TreeNode92.Text = "03012- Trefilación (Forma 2)"
        TreeNode93.ImageIndex = 97
        TreeNode93.Name = "nod_tref_forma3"
        TreeNode93.SelectedImageIndex = 97
        TreeNode93.Text = "03013- Trefilación (Forma 3)"
        TreeNode94.ImageIndex = 97
        TreeNode94.Name = "nodPulimiento"
        TreeNode94.SelectedImageIndex = 97
        TreeNode94.Text = "03014- Pulimiento(tambores)"
        TreeNode95.ImageIndex = 97
        TreeNode95.Name = "nod_galv_baches"
        TreeNode95.SelectedImageIndex = 97
        TreeNode95.Text = "03015- Galvanizado por baches"
        TreeNode96.ImageIndex = 97
        TreeNode96.Name = "nod_recocido"
        TreeNode96.SelectedImageIndex = 97
        TreeNode96.Text = "03016- Recocido"
        TreeNode97.ImageIndex = 97
        TreeNode97.Name = "nod_IngTornilleria"
        TreeNode97.SelectedImageIndex = 97
        TreeNode97.Text = "03017- Tornilleria"
        TreeNode98.ImageIndex = 97
        TreeNode98.Name = "nod_temple"
        TreeNode98.SelectedImageIndex = 97
        TreeNode98.Text = "03018- Tratamientos termicos (Temple)"
        TreeNode99.ImageIndex = 126
        TreeNode99.Name = "nod_empaque_puntilleria"
        TreeNode99.SelectedImageIndex = 126
        TreeNode99.Text = "03019- Empaque de puntilleria"
        TreeNode100.ImageIndex = 125
        TreeNode100.Name = "nodTranManDmsSpic"
        TreeNode100.SelectedImageIndex = 125
        TreeNode100.Text = "03020- Transacción manual DMS-SPIC"
        TreeNode101.ImageIndex = 97
        TreeNode101.Name = "Raiz_ing_prod"
        TreeNode101.SelectedImageIndex = 97
        TreeNode101.Text = "03007- Ingreso de producción"
        TreeNode102.ImageIndex = 5
        TreeNode102.Name = "nod_consultar_certificados"
        TreeNode102.SelectedImageIndex = 5
        TreeNode102.Text = "03023- Consultar certificados historicos"
        TreeNode103.ImageIndex = 98
        TreeNode103.Name = "nodGenFichasYcertf"
        TreeNode103.SelectedImageIndex = 98
        TreeNode103.Text = "03024- Generar certificado de calidad"
        TreeNode104.ImageIndex = 99
        TreeNode104.Name = "nod_maestro_fichas"
        TreeNode104.SelectedImageIndex = 99
        TreeNode104.Text = "03025- Maestro fichas técnicas"
        TreeNode105.ImageIndex = 98
        TreeNode105.Name = "Raiz_certf_calidad"
        TreeNode105.SelectedImageIndex = 98
        TreeNode105.Text = "03022- Certificados de calidad"
        TreeNode106.ImageIndex = 100
        TreeNode106.Name = "nod_pend_prod"
        TreeNode106.SelectedImageIndex = 100
        TreeNode106.Text = "03026- Pendientes producción"
        TreeNode107.ImageIndex = 101
        TreeNode107.Name = "nod_traz_vtas_linea"
        TreeNode107.SelectedImageIndex = 101
        TreeNode107.Text = "03027- Historico ventas"
        TreeNode108.ImageIndex = 102
        TreeNode108.Name = "nod_aud_inv"
        TreeNode108.SelectedImageIndex = 102
        TreeNode108.Text = "03028- Movimiento inventario"
        TreeNode109.Name = "nod_eficiencias"
        TreeNode109.Text = "03029- Eficiencias"
        TreeNode110.ImageIndex = 5
        TreeNode110.Name = "nodTransDms"
        TreeNode110.SelectedImageIndex = 5
        TreeNode110.Text = "03030- Consultar transacciones Dms"
        TreeNode111.ImageIndex = 127
        TreeNode111.Name = "nod_trazabilidad_transacciones"
        TreeNode111.SelectedImageIndex = 127
        TreeNode111.Text = "03031- Trazabilidad de transacciones"
        TreeNode112.ImageIndex = 127
        TreeNode112.Name = "nod_maximos_minimos"
        TreeNode112.SelectedImageIndex = 127
        TreeNode112.Text = "03032- Informe de máximos y minimos"
        TreeNode113.ImageIndex = 127
        TreeNode113.Name = "nod_entradas_salidas_ref"
        TreeNode113.SelectedImageIndex = 127
        TreeNode113.Text = "03033- Entradas-salidas-inventarios"
        TreeNode114.ImageIndex = 128
        TreeNode114.Name = "nod_entradas_salidas_diarias"
        TreeNode114.SelectedImageIndex = 128
        TreeNode114.Text = "03034- Entradas_salidas_DIARIO"
        TreeNode115.ImageIndex = 49
        TreeNode115.Name = "Raiz_informes_prod"
        TreeNode115.SelectedImageIndex = 49
        TreeNode115.Text = "03021- Informes"
        TreeNode116.ImageIndex = 104
        TreeNode116.Name = "nod_GestTransaSinStock"
        TreeNode116.SelectedImageIndex = 104
        TreeNode116.Text = "03036- Gestionar transacciones sin stock"
        TreeNode117.ImageIndex = 105
        TreeNode117.Name = "nod_tras_bod_hand"
        TreeNode117.SelectedImageIndex = 105
        TreeNode117.Text = "03037- Traslado de bodega (handheld)"
        TreeNode118.ImageIndex = 106
        TreeNode118.Name = "nod_MaestroTransHandHeld"
        TreeNode118.SelectedImageIndex = 106
        TreeNode118.Text = "03038- Maestro Transaccion HandHeld"
        TreeNode119.ImageIndex = 103
        TreeNode119.Name = "Raiz_traslado_bodega"
        TreeNode119.SelectedImageIndex = 103
        TreeNode119.Text = "03035- Módulo traslados de bodega"
        TreeNode120.ImageIndex = 108
        TreeNode120.Name = "nodMaeRepuestos"
        TreeNode120.SelectedImageIndex = 108
        TreeNode120.Text = "03040- Nuevos repuestos"
        TreeNode121.ImageIndex = 109
        TreeNode121.Name = "nodCorreccion"
        TreeNode121.SelectedImageIndex = 109
        TreeNode121.Text = "03041- Solicitud de correción"
        TreeNode122.ImageIndex = 107
        TreeNode122.Name = "RaizMantenimiento"
        TreeNode122.SelectedImageIndex = 107
        TreeNode122.Text = "03039- Mantenimiento"
        TreeNode123.ImageIndex = 110
        TreeNode123.Name = "nod_ppto_produccion"
        TreeNode123.SelectedImageIndex = 110
        TreeNode123.Text = "03043- Presupuesto de producción"
        TreeNode124.ImageIndex = 127
        TreeNode124.Name = "nod_seg_ppto_produccion"
        TreeNode124.SelectedImageIndex = 127
        TreeNode124.Text = "03044- Seguimiento de presupuesto de producción"
        TreeNode125.ImageIndex = 111
        TreeNode125.Name = "nod_dif_pes_tref"
        TreeNode125.SelectedImageIndex = 111
        TreeNode125.Text = "03045- Informe Diferencia Trefilacion"
        TreeNode126.ImageIndex = 110
        TreeNode126.Name = "Raiz_ppto_produccion"
        TreeNode126.SelectedImageIndex = 110
        TreeNode126.Text = "03042- Presupuesto de producción"
        TreeNode127.ImageIndex = 113
        TreeNode127.Name = "nod_ppto_articulos"
        TreeNode127.SelectedImageIndex = 113
        TreeNode127.Text = "03048- Presupuesto de articulos"
        TreeNode128.ImageIndex = 113
        TreeNode128.Name = "Raiz_ppto_articulos"
        TreeNode128.SelectedImageIndex = 113
        TreeNode128.Text = "03047- Presupuesto de articulos"
        TreeNode129.ImageIndex = 114
        TreeNode129.Name = "nod_ppto_gastos"
        TreeNode129.SelectedImageIndex = 114
        TreeNode129.Text = "03049- Presupuesto"
        TreeNode130.ImageIndex = 127
        TreeNode130.Name = "nod_seg_ppto_gastos"
        TreeNode130.SelectedImageIndex = 127
        TreeNode130.Text = "03050- Seguimiento presupuesto de gastos y articulos"
        TreeNode131.ImageIndex = 112
        TreeNode131.Name = "Raiz_ppto_gastos"
        TreeNode131.SelectedImageIndex = 112
        TreeNode131.Text = "03046- Presupuesto de gastos y articulos"
        TreeNode132.ImageIndex = 116
        TreeNode132.Name = "nod_generar_tiquetes_terminado"
        TreeNode132.SelectedImageIndex = 116
        TreeNode132.Text = "03052- Generar tiquetes terminado"
        TreeNode133.ImageIndex = 117
        TreeNode133.Name = "nod_consultar_separe"
        TreeNode133.SelectedImageIndex = 117
        TreeNode133.Text = "03053- Consultar planilla separe"
        TreeNode134.ImageIndex = 115
        TreeNode134.Name = "Raiz_gestionar_tornilleria"
        TreeNode134.SelectedImageIndex = 115
        TreeNode134.Text = "03051- Gestionar tornilleria"
        TreeNode135.ImageIndex = 129
        TreeNode135.Name = "nod_salida_materia_prima_G"
        TreeNode135.SelectedImageIndex = 129
        TreeNode135.Text = "03055- Salida materia de prima (2-11 y 11-2)"
        TreeNode136.ImageIndex = 136
        TreeNode136.Name = "nod_consulta_materia_prima_G"
        TreeNode136.SelectedImageIndex = 136
        TreeNode136.Text = "03056- Consulta materia prima (2-11 y 11-2)"
        TreeNode137.ImageIndex = 130
        TreeNode137.Name = "nod_Orden_produccion_Galvanizado"
        TreeNode137.SelectedImageIndex = 130
        TreeNode137.Text = "03057- Orden de produción galv"
        TreeNode138.ImageIndex = 49
        TreeNode138.Name = "nod_Informe_produccion_Galvanizado"
        TreeNode138.SelectedImageIndex = 49
        TreeNode138.Text = "03058- Informe producción galvanizado"
        TreeNode139.ImageIndex = 135
        TreeNode139.Name = "nod_Informe_estado_rollos"
        TreeNode139.SelectedImageIndex = 135
        TreeNode139.Text = "03059- Informe estado de rollos"
        TreeNode140.ImageIndex = 131
        TreeNode140.Name = "nod_Informe_bobinas_paradas"
        TreeNode140.SelectedImageIndex = 131
        TreeNode140.Text = "03060- Bobinas detenidas"
        TreeNode141.ImageIndex = 132
        TreeNode141.Name = "nod_Informe_tiempo_trabajo"
        TreeNode141.SelectedImageIndex = 132
        TreeNode141.Text = "03061- Tiempo trabajo"
        TreeNode142.ImageIndex = 133
        TreeNode142.Name = "nod_Informe_resumen_galvanizado"
        TreeNode142.SelectedImageIndex = 133
        TreeNode142.Text = "03062- Resumen galvanizado"
        TreeNode143.ImageIndex = 134
        TreeNode143.Name = "nod_paros_galv"
        TreeNode143.SelectedImageIndex = 134
        TreeNode143.Text = "03063- Informe de paros"
        TreeNode144.ImageIndex = 118
        TreeNode144.Name = "nodGalvanizado"
        TreeNode144.SelectedImageIndex = 118
        TreeNode144.Text = "03054- Galvanizado"
        TreeNode145.ImageIndex = 119
        TreeNode145.Name = "nod_consult_inv_fisicos"
        TreeNode145.SelectedImageIndex = 119
        TreeNode145.Text = "03065- Consultar inventarios fisicos"
        TreeNode146.ImageIndex = 127
        TreeNode146.Name = "nod_auditoria_inventario"
        TreeNode146.SelectedImageIndex = 127
        TreeNode146.Text = "03066- Auditoria Inventario"
        TreeNode147.ImageIndex = 119
        TreeNode147.Name = "Raiz_nventarios_fisicos"
        TreeNode147.SelectedImageIndex = 119
        TreeNode147.Text = "03064- Inventarios fisicos"
        TreeNode148.ImageIndex = 35
        TreeNode148.Name = "nod_solicitud_mp_puntilleria"
        TreeNode148.SelectedImageIndex = 35
        TreeNode148.Text = "03068- Solicitar materia prima"
        TreeNode149.ImageIndex = 5
        TreeNode149.Name = "nod_consult_solicitud_mp_punt"
        TreeNode149.SelectedImageIndex = 5
        TreeNode149.Text = "03069- Consultar solicitudes"
        TreeNode150.ImageIndex = 130
        TreeNode150.Name = "nod_orden_prod_punt"
        TreeNode150.SelectedImageIndex = 130
        TreeNode150.Text = "03070- Orden de producción"
        TreeNode151.ImageIndex = 127
        TreeNode151.Name = "nod_auditoria_puntilleria"
        TreeNode151.SelectedImageIndex = 127
        TreeNode151.Text = "03071- Auditoria Puntilleria"
        TreeNode152.ImageIndex = 121
        TreeNode152.Name = "Raiz_puntilleria"
        TreeNode152.SelectedImageIndex = 121
        TreeNode152.Text = "03067- Puntilleria"
        TreeNode153.ImageIndex = 35
        TreeNode153.Name = "nod_solicitud_mp_recocido"
        TreeNode153.SelectedImageIndex = 35
        TreeNode153.Text = "03073- Solicitar materia prima"
        TreeNode154.ImageIndex = 5
        TreeNode154.Name = "nod_consult_solicitud_mp_recocido"
        TreeNode154.SelectedImageIndex = 5
        TreeNode154.Text = "03074- Consultar solicitudes"
        TreeNode155.ImageIndex = 130
        TreeNode155.Name = "nod_orden_produccion_rec"
        TreeNode155.SelectedImageIndex = 130
        TreeNode155.Text = "03075- Orden de produccion Recocido"
        TreeNode156.ImageIndex = 127
        TreeNode156.Name = "nod_auditoria_recocido"
        TreeNode156.SelectedImageIndex = 127
        TreeNode156.Text = "03076- Auditoria Recocido"
        TreeNode157.ImageIndex = 127
        TreeNode157.Name = "nod_auditoria_tref_rec"
        TreeNode157.SelectedImageIndex = 127
        TreeNode157.Text = "03077- Auditoria Tref-Rec"
        TreeNode158.ImageIndex = 137
        TreeNode158.Name = "nod_tiquete_rec_manual"
        TreeNode158.SelectedImageIndex = 137
        TreeNode158.Text = "03078- Copia tiquete recocido"
        TreeNode159.ImageIndex = 92
        TreeNode159.Name = "nod_tiquete_nc"
        TreeNode159.SelectedImageIndex = 92
        TreeNode159.Text = "03079- Tiquete no conforme"
        TreeNode160.ImageIndex = 96
        TreeNode160.Name = "Raiz_Recocido"
        TreeNode160.SelectedImageIndex = 96
        TreeNode160.Text = "03072- Recocido"
        TreeNode161.ImageIndex = 35
        TreeNode161.Name = "nod_solicitud_mp_puas"
        TreeNode161.SelectedImageIndex = 35
        TreeNode161.Text = "03081- Solicitar materia prima"
        TreeNode162.ImageIndex = 5
        TreeNode162.Name = "nod_consult_solicitud_mp_puas"
        TreeNode162.SelectedImageIndex = 5
        TreeNode162.Text = "03082- Consultar solicitudes"
        TreeNode163.ImageIndex = 130
        TreeNode163.Name = "nod_orden_prod_puas"
        TreeNode163.SelectedImageIndex = 130
        TreeNode163.Text = "03083- Orden de producción operario"
        TreeNode164.ImageIndex = 120
        TreeNode164.Name = "nod_crear_orden_puas"
        TreeNode164.SelectedImageIndex = 120
        TreeNode164.Text = "03084- Crear orden puas"
        TreeNode165.ImageIndex = 71
        TreeNode165.Name = "nod_prod_puas"
        TreeNode165.SelectedImageIndex = 71
        TreeNode165.Text = "03085- Producción de puas"
        TreeNode166.ImageIndex = 134
        TreeNode166.Name = "nod_infor_paros_puas"
        TreeNode166.SelectedImageIndex = 134
        TreeNode166.Text = "03086- Informe de paros púas"
        TreeNode167.ImageIndex = 118
        TreeNode167.Name = "raiz_puas"
        TreeNode167.SelectedImageIndex = 118
        TreeNode167.Text = "03080- Alambre de Puas"
        TreeNode168.ImageIndex = 69
        TreeNode168.Name = "nod_proyectos"
        TreeNode168.SelectedImageIndex = 69
        TreeNode168.Text = "03088- Crear proyecto"
        TreeNode169.ImageIndex = 136
        TreeNode169.Name = "nod_consultar_proyecto"
        TreeNode169.SelectedImageIndex = 136
        TreeNode169.Text = "03089- Consultar proyectos"
        TreeNode170.ImageIndex = 127
        TreeNode170.Name = "Raiz_proyectos"
        TreeNode170.SelectedImageIndex = 127
        TreeNode170.Text = "03087- Gestionar proyectos"
        TreeNode171.ImageIndex = 138
        TreeNode171.Name = "nod_solicitud_scal"
        TreeNode171.SelectedImageIndex = 138
        TreeNode171.Text = "03091- Solicitud scal"
        TreeNode172.ImageIndex = 138
        TreeNode172.Name = "nod_solicitud_scae"
        TreeNode172.SelectedImageIndex = 138
        TreeNode172.Text = "03092- Solicitud scae"
        TreeNode173.ImageIndex = 138
        TreeNode173.Name = "nod_solicitud_sar"
        TreeNode173.SelectedImageIndex = 138
        TreeNode173.Text = "03093- Solicitud sar"
        TreeNode174.ImageIndex = 138
        TreeNode174.Name = "nod_solicitud_sav"
        TreeNode174.SelectedImageIndex = 138
        TreeNode174.Text = "03094- Solicitud sav"
        TreeNode175.ImageIndex = 136
        TreeNode175.Name = "nod_consulta_scal"
        TreeNode175.SelectedImageIndex = 136
        TreeNode175.Text = "03095- Consulta de pedidos scal"
        TreeNode176.ImageIndex = 136
        TreeNode176.Name = "nod_consulta_scae"
        TreeNode176.SelectedImageIndex = 136
        TreeNode176.Text = "03096- Consulta de pedidos scae"
        TreeNode177.ImageIndex = 136
        TreeNode177.Name = "nod_consulta_sar"
        TreeNode177.SelectedImageIndex = 136
        TreeNode177.Text = "03097- Consulta de pedidos sar"
        TreeNode178.ImageIndex = 136
        TreeNode178.Name = "nod_consulta_sav"
        TreeNode178.SelectedImageIndex = 136
        TreeNode178.Text = "03098- Consulta de pedidos sav"
        TreeNode179.ImageIndex = 138
        TreeNode179.Name = "nod_scal_scae_sav"
        TreeNode179.SelectedImageIndex = 138
        TreeNode179.Text = "03090- Consumos scal,scae,sar y sav"
        TreeNode180.ImageIndex = 130
        TreeNode180.Name = "nodOrdenProd"
        TreeNode180.SelectedImageIndex = 130
        TreeNode180.Text = "03100- Ordenes de producción"
        TreeNode181.ImageIndex = 127
        TreeNode181.Name = "nod_auditoria_alambres"
        TreeNode181.SelectedImageIndex = 127
        TreeNode181.Text = "03101- Auditoria de alambres"
        TreeNode182.ImageIndex = 139
        TreeNode182.Name = "nod_gen_tiquet_tref"
        TreeNode182.SelectedImageIndex = 139
        TreeNode182.Text = "03102- Generar tiquete tref NC"
        TreeNode183.ImageIndex = 94
        TreeNode183.Name = "nodGesRef"
        TreeNode183.SelectedImageIndex = 94
        TreeNode183.Text = "03103- Gestionar linea de producción"
        TreeNode184.ImageIndex = 125
        TreeNode184.Name = "nod_limite_consumos"
        TreeNode184.SelectedImageIndex = 125
        TreeNode184.Text = "03104- Limite consumos alambron"
        TreeNode185.ImageIndex = 141
        TreeNode185.Name = "nod_cod_vel"
        TreeNode185.SelectedImageIndex = 141
        TreeNode185.Text = "03105- Velocidades de codigos"
        TreeNode186.ImageIndex = 114
        TreeNode186.Name = "nod_sal_alam"
        TreeNode186.SelectedImageIndex = 114
        TreeNode186.Text = "03106- Saldo alambron"
        TreeNode187.ImageIndex = 142
        TreeNode187.Name = "nod_act_alam"
        TreeNode187.SelectedImageIndex = 142
        TreeNode187.Text = "03107- Actualizar alambron"
        TreeNode188.ImageIndex = 136
        TreeNode188.Name = "nod_tref_form3"
        TreeNode188.SelectedImageIndex = 136
        TreeNode188.Text = "03108- Consulta tref forma 3"
        TreeNode189.ImageIndex = 139
        TreeNode189.Name = "nodo_consumir_tiquetes"
        TreeNode189.SelectedImageIndex = 139
        TreeNode189.Text = "03109- Consumir Tiquetes Trefilacion"
        TreeNode190.ImageIndex = 153
        TreeNode190.Name = "Nododetalleparos"
        TreeNode190.SelectedImageIndex = 153
        TreeNode190.Text = "03110- Detalle paros tref"
        TreeNode191.ImageIndex = 118
        TreeNode191.Name = "nod_tref_com"
        TreeNode191.SelectedImageIndex = 118
        TreeNode191.Text = "03099- Trefilación"
        TreeNode192.ImageIndex = 115
        TreeNode192.Name = "nod_cosnu_tornilleria"
        TreeNode192.SelectedImageIndex = 115
        TreeNode192.Text = "03112- Consumo de tornileria"
        TreeNode193.ImageIndex = 115
        TreeNode193.Name = "nod_Mod_Tornilleria"
        TreeNode193.SelectedImageIndex = 115
        TreeNode193.Text = "03111- Tornilleria"
        TreeNode194.ImageIndex = 138
        TreeNode194.Name = "nod_mat_consumida"
        TreeNode194.SelectedImageIndex = 138
        TreeNode194.Text = "03115- consumo y producción de tref"
        TreeNode195.ImageIndex = 138
        TreeNode195.Name = "nod_mat_punt"
        TreeNode195.SelectedImageIndex = 138
        TreeNode195.Text = "03116- consumo y producción de punt"
        TreeNode196.ImageIndex = 138
        TreeNode196.Name = "nod_mat_galv"
        TreeNode196.SelectedImageIndex = 138
        TreeNode196.Text = "03117- consumo y produccion galv"
        TreeNode197.ImageIndex = 138
        TreeNode197.Name = "nod_segui_consu"
        TreeNode197.SelectedImageIndex = 138
        TreeNode197.Text = "03114- Seguimiento de consumos"
        TreeNode198.ImageIndex = 142
        TreeNode198.Name = "nod_cambiar_centro"
        TreeNode198.SelectedImageIndex = 142
        TreeNode198.Text = "03118- Cambiar centro (Planta)"
        TreeNode199.ImageIndex = 127
        TreeNode199.Name = "nod_auditoria"
        TreeNode199.SelectedImageIndex = 127
        TreeNode199.Text = "03119- Auditoria"
        TreeNode200.ImageIndex = 94
        TreeNode200.Name = "Raiz_prod"
        TreeNode200.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode200.SelectedImageIndex = 94
        TreeNode200.Text = "03 - Producción"
        TreeNode201.ImageIndex = 138
        TreeNode201.Name = "nod_info_dane"
        TreeNode201.SelectedImageIndex = 138
        TreeNode201.Text = "04001- Informe personal Dane"
        TreeNode202.ImageIndex = 138
        TreeNode202.Name = "nod_informe_pers_activo"
        TreeNode202.SelectedImageIndex = 138
        TreeNode202.Text = "04002- Informe Personal Activo"
        TreeNode203.ImageIndex = 138
        TreeNode203.Name = "nod_info_empleados"
        TreeNode203.SelectedImageIndex = 138
        TreeNode203.Text = "04003- Información de empleados"
        TreeNode204.ImageIndex = 137
        TreeNode204.Name = "nod_informe_ausentismos"
        TreeNode204.SelectedImageIndex = 137
        TreeNode204.Text = "04004- Informe de incapacidades y ausentismos"
        TreeNode205.ImageIndex = 143
        TreeNode205.Name = "nod_dias_vacaciones"
        TreeNode205.SelectedImageIndex = 143
        TreeNode205.Text = "04005- Días de vacaciones"
        TreeNode206.ImageIndex = 132
        TreeNode206.Name = "nod_tiempos_laborados"
        TreeNode206.SelectedImageIndex = 132
        TreeNode206.Text = "04006- Tiempos laborados"
        TreeNode207.ImageIndex = 142
        TreeNode207.Name = "nod_rotacion_personal"
        TreeNode207.SelectedImageIndex = 142
        TreeNode207.Text = "04007- Rotación del personal"
        TreeNode208.ImageIndex = 45
        TreeNode208.Name = "nodReg_personal_maquila"
        TreeNode208.SelectedImageIndex = 45
        TreeNode208.Text = "04010- Registrar personal maquilas"
        TreeNode209.ImageIndex = 137
        TreeNode209.Name = "nod_informe_temporales"
        TreeNode209.SelectedImageIndex = 137
        TreeNode209.Text = "04011- Informe temporales"
        TreeNode210.ImageIndex = 45
        TreeNode210.Name = "Raiz maquila"
        TreeNode210.SelectedImageIndex = 45
        TreeNode210.Text = "04009- Personal maquilas"
        TreeNode211.ImageIndex = 141
        TreeNode211.Name = "nod_liqui_reloj"
        TreeNode211.SelectedImageIndex = 141
        TreeNode211.Text = "04012- Procesar marcaciones"
        TreeNode212.ImageIndex = 71
        TreeNode212.Name = "nod_programacion_turnos"
        TreeNode212.SelectedImageIndex = 71
        TreeNode212.Text = "04013- Programación de turnos"
        TreeNode213.ImageIndex = 107
        TreeNode213.Name = "nod_MaePeriodos"
        TreeNode213.SelectedImageIndex = 107
        TreeNode213.Text = "04014- Gestionar periodos de corte de novedades"
        TreeNode214.ImageIndex = 127
        TreeNode214.Name = "nod_informe_marcaciones"
        TreeNode214.SelectedImageIndex = 127
        TreeNode214.Text = "04015- Informe de inconsistencia en marcaciones"
        TreeNode215.ImageIndex = 71
        TreeNode215.Name = "Nod_consult_compromisos"
        TreeNode215.SelectedImageIndex = 71
        TreeNode215.Text = "04016- Consultar compromisos"
        TreeNode216.ImageIndex = 71
        TreeNode216.Name = "nod_informe_nov_pendientes"
        TreeNode216.SelectedImageIndex = 71
        TreeNode216.Text = "04017- Informe de novedades pendientes"
        TreeNode217.ImageIndex = 138
        TreeNode217.Name = "nod_per_activo"
        TreeNode217.SelectedImageIndex = 138
        TreeNode217.Text = "04018- Personal en Corsan"
        TreeNode218.ImageIndex = 132
        TreeNode218.Name = "Raiz_reloj"
        TreeNode218.SelectedImageIndex = 132
        TreeNode218.Text = "04008- Reloj"
        TreeNode219.ImageIndex = 125
        TreeNode219.Name = "nod_evaluacione_desempeno"
        TreeNode219.SelectedImageIndex = 125
        TreeNode219.Text = "04020- Evaluacion de desempeño"
        TreeNode220.ImageIndex = 136
        TreeNode220.Name = "nod_consultar_eval_desempeno"
        TreeNode220.SelectedImageIndex = 136
        TreeNode220.Text = "04021- Consultar evaluaciónes de desempeño"
        TreeNode221.ImageIndex = 52
        TreeNode221.Name = "nod_permisos_evaluaciones"
        TreeNode221.SelectedImageIndex = 52
        TreeNode221.Text = "04022- Permisos evaluaciones"
        TreeNode222.ImageIndex = 125
        TreeNode222.Name = "Raiz_eval_desempeno"
        TreeNode222.SelectedImageIndex = 125
        TreeNode222.Text = "04019- Evaluaciones de desempeño"
        TreeNode223.ImageIndex = 34
        TreeNode223.Name = "nod_buzon_sugerencias_det"
        TreeNode223.SelectedImageIndex = 34
        TreeNode223.Text = "04023- Buzon de Sugerencias"
        TreeNode224.ImageIndex = 52
        TreeNode224.Name = "nod_buzon_cons_premios"
        TreeNode224.SelectedImageIndex = 52
        TreeNode224.Text = "04024- Consulta Solicitud de Premios"
        TreeNode225.ImageIndex = 37
        TreeNode225.Name = "nod_contrat_dias"
        TreeNode225.SelectedImageIndex = 37
        TreeNode225.Text = "04026- Gestionar contratistas"
        TreeNode226.ImageIndex = 37
        TreeNode226.Name = "nod_contra"
        TreeNode226.SelectedImageIndex = 37
        TreeNode226.Text = "04025- Contratistas"
        TreeNode227.ImageIndex = 44
        TreeNode227.Name = "Raiz_recursos_humanos"
        TreeNode227.NodeFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreeNode227.SelectedImageIndex = 44
        TreeNode227.Text = "04 - Recursos humanos"
        TreeNode228.ImageIndex = 136
        TreeNode228.Name = "nodConsultVot"
        TreeNode228.SelectedImageIndex = 136
        TreeNode228.Text = "05001- Consultar votaciónes"
        TreeNode229.ImageIndex = 83
        TreeNode229.Name = "nodGesGrup"
        TreeNode229.SelectedImageIndex = 83
        TreeNode229.Text = "05002- Gestionar grupos votación"
        TreeNode230.ImageIndex = 140
        TreeNode230.Name = "nodIngVot"
        TreeNode230.SelectedImageIndex = 140
        TreeNode230.Text = "05003- Ingresar votación"
        TreeNode231.ImageIndex = 83
        TreeNode231.Name = "RaizAdminVot"
        TreeNode231.SelectedImageIndex = 83
        TreeNode231.Text = "05 - Administrar votación"
        TreeNode232.ImageIndex = 5
        TreeNode232.Name = "nod_constar_eval_prov"
        TreeNode232.SelectedImageIndex = 5
        TreeNode232.Text = "06002- Consultar"
        TreeNode233.ImageIndex = 145
        TreeNode233.Name = "nod_evaluacion_prov"
        TreeNode233.SelectedImageIndex = 145
        TreeNode233.Text = "06003- Evaluación"
        TreeNode234.ImageIndex = 127
        TreeNode234.Name = "nod_graficar_evaluaciones"
        TreeNode234.SelectedImageIndex = 127
        TreeNode234.Text = "06004- Graficar evaluaciones"
        TreeNode235.ImageIndex = 99
        TreeNode235.Name = "nod_maestro_prov_cat"
        TreeNode235.SelectedImageIndex = 99
        TreeNode235.Text = "06005- Maestro proveedor-categoria"
        TreeNode236.ImageIndex = 86
        TreeNode236.Name = "nod_gestionar_tendencias"
        TreeNode236.SelectedImageIndex = 86
        TreeNode236.Text = "06006- Gestionar_tendencias"
        TreeNode237.ImageIndex = 145
        TreeNode237.Name = "Raiz_evaluacion_proveedores"
        TreeNode237.SelectedImageIndex = 145
        TreeNode237.Text = "06001- Evaluación de proveedores"
        TreeNode238.ImageIndex = 69
        TreeNode238.Name = "nod_generar_sol_compra"
        TreeNode238.SelectedImageIndex = 69
        TreeNode238.Text = "06008- Generar solicitud de servicio"
        TreeNode239.ImageIndex = 120
        TreeNode239.Name = "nod_admin_sol_compra"
        TreeNode239.SelectedImageIndex = 120
        TreeNode239.Text = "06009- Administrar solicitudes de servicios"
        TreeNode240.ImageIndex = 136
        TreeNode240.Name = "nod_infor_cant_entre"
        TreeNode240.SelectedImageIndex = 136
        TreeNode240.Text = "06010- Consultar material aut vs reg"
        TreeNode241.ImageIndex = 109
        TreeNode241.Name = "Raiz_sol_servicio"
        TreeNode241.SelectedImageIndex = 109
        TreeNode241.Text = "06007- Solicitudes de servicio"
        TreeNode242.ImageIndex = 144
        TreeNode242.Name = "nod_admin_ord_compra"
        TreeNode242.SelectedImageIndex = 144
        TreeNode242.Text = "06012- Administrar ordenes de compra"
        TreeNode243.ImageIndex = 69
        TreeNode243.Name = "nod_generar_ord_compra"
        TreeNode243.SelectedImageIndex = 69
        TreeNode243.Text = "06013- Generar orden de compra"
        TreeNode244.ImageIndex = 144
        TreeNode244.Name = "RaizSolCompra"
        TreeNode244.SelectedImageIndex = 144
        TreeNode244.Text = "06011- Ordenes de compra"
        TreeNode245.ImageIndex = 147
        TreeNode245.Name = "nod_salida_almacen"
        TreeNode245.SelectedImageIndex = 147
        TreeNode245.Text = "06015- Generar salida de almacen"
        TreeNode246.ImageIndex = 136
        TreeNode246.Name = "nod_consult_salida_almacen"
        TreeNode246.SelectedImageIndex = 136
        TreeNode246.Text = "06016- Consultar salidas de almacen"
        TreeNode247.ImageIndex = 147
        TreeNode247.Name = "RaizSalidaAlmacen"
        TreeNode247.SelectedImageIndex = 147
        TreeNode247.Text = "06014- Salidas de almacen"
        TreeNode248.ImageIndex = 118
        TreeNode248.Name = "nod_salida_alambron"
        TreeNode248.SelectedImageIndex = 118
        TreeNode248.Text = "06018- Salida de alambrón"
        TreeNode249.ImageIndex = 136
        TreeNode249.Name = "nod_consultar_salida_alambron"
        TreeNode249.SelectedImageIndex = 136
        TreeNode249.Text = "06019- Consultar salida de alambrón"
        TreeNode250.ImageIndex = 118
        TreeNode250.Name = "RaizSalidaAlambron"
        TreeNode250.SelectedImageIndex = 118
        TreeNode250.Text = "06017- Salidas de alambrón"
        TreeNode251.ImageIndex = 116
        TreeNode251.Name = "nod_tiquetes_alambron"
        TreeNode251.SelectedImageIndex = 116
        TreeNode251.Text = "06021- Tiquetes de alambrón"
        TreeNode252.ImageIndex = 127
        TreeNode252.Name = "nod_auditoria_tiquete"
        TreeNode252.SelectedImageIndex = 127
        TreeNode252.Text = "06022- Auditoria de ingreso de materia prima"
        TreeNode253.ImageIndex = 78
        TreeNode253.Name = "nod_planillas_cargue"
        TreeNode253.SelectedImageIndex = 78
        TreeNode253.Text = "06024- Planillas de descargue de alambrón"
        TreeNode254.ImageIndex = 105
        TreeNode254.Name = "NodPrincipalHandHeld"
        TreeNode254.SelectedImageIndex = 105
        TreeNode254.Text = "06025- Menú principal Hand-Held"
        TreeNode255.ImageIndex = 152
        TreeNode255.Name = "NodoInhabilitarAlambron"
        TreeNode255.SelectedImageIndex = 152
        TreeNode255.Text = "06026- Inhabilitar tiquetes alambrón"
        TreeNode256.ImageIndex = 118
        TreeNode256.Name = "RaizAlambron"
        TreeNode256.SelectedImageIndex = 118
        TreeNode256.Text = "06020- Gestión de alambrón"
        TreeNode257.ImageIndex = 148
        TreeNode257.Name = "nod_infor_estupe"
        TreeNode257.SelectedImageIndex = 148
        TreeNode257.Text = "06028- Información estupefacientes"
        TreeNode258.ImageIndex = 148
        TreeNode258.Name = "RaizEstupefacientes"
        TreeNode258.SelectedImageIndex = 148
        TreeNode258.Text = "06027- Estupefacientes"
        TreeNode259.ImageIndex = 116
        TreeNode259.Name = "nod_generar_tiquetes_terminado"
        TreeNode259.SelectedImageIndex = 116
        TreeNode259.Text = "06030- Generar tiquetes producto temrinado"
        TreeNode260.ImageIndex = 116
        TreeNode260.Name = "Raiz_generar_tiquetes_terminado"
        TreeNode260.SelectedImageIndex = 116
        TreeNode260.Text = "06029- Tiquetes producto terminado"
        TreeNode261.ImageIndex = 144
        TreeNode261.Name = "Raiz_compras"
        TreeNode261.SelectedImageIndex = 144
        TreeNode261.Text = "06 - Compras"
        TreeNode262.ImageIndex = 136
        TreeNode262.Name = "nod_consultar_proc"
        TreeNode262.SelectedImageIndex = 136
        TreeNode262.Text = "07001- Consultar procedimientos"
        TreeNode263.ImageIndex = 69
        TreeNode263.Name = "nod_gest_proc"
        TreeNode263.SelectedImageIndex = 69
        TreeNode263.Text = "07002- Gestionar procedimientos"
        TreeNode264.ImageIndex = 99
        TreeNode264.Name = "nod_mae_cargos"
        TreeNode264.SelectedImageIndex = 99
        TreeNode264.Text = "07003- Maestro cargos"
        TreeNode265.ImageIndex = 127
        TreeNode265.Name = "nod_auditoria"
        TreeNode265.SelectedImageIndex = 127
        TreeNode265.Text = "07 - Auditoria"
        TreeNode266.ImageIndex = 36
        TreeNode266.Name = "nod_cambio_bod"
        TreeNode266.SelectedImageIndex = 36
        TreeNode266.Text = "08001- Cambiar pedido bodega"
        TreeNode267.ImageIndex = 90
        TreeNode267.Name = "nod_fecha_entrega"
        TreeNode267.SelectedImageIndex = 90
        TreeNode267.Text = "08002- Relación factura-pedido-entrega"
        TreeNode268.ImageIndex = 27
        TreeNode268.Name = "nod_formato_stiker"
        TreeNode268.SelectedImageIndex = 27
        TreeNode268.Text = "08003- Formato impresión etiquetas"
        TreeNode269.ImageIndex = 10
        TreeNode269.Name = "nod_gestionar_no_conforme"
        TreeNode269.SelectedImageIndex = 10
        TreeNode269.Text = "08004- Gestionar producto no conforme"
        TreeNode270.ImageIndex = 150
        TreeNode270.Name = "nod_ppal_despachos"
        TreeNode270.SelectedImageIndex = 150
        TreeNode270.Text = "08005- Traslado de la  B 2 a la 3"
        TreeNode271.ImageIndex = 151
        TreeNode271.Name = "Nod_estado_maquinas"
        TreeNode271.SelectedImageIndex = 151
        TreeNode271.Text = "08006- Control Esatado maquinas"
        TreeNode272.ImageIndex = 89
        TreeNode272.Name = "Raiz_logistica"
        TreeNode272.SelectedImageIndex = 89
        TreeNode272.Text = "08 - Logistica"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode81, TreeNode200, TreeNode227, TreeNode231, TreeNode261, TreeNode265, TreeNode272})
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.Size = New System.Drawing.Size(1220, 616)
        Me.TreeView1.TabIndex = 38
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tab_men_ppal)
        Me.TabControl1.Controls.Add(Me.tab_men_prod)
        Me.TabControl1.Controls.Add(Me.tab_men_gastos)
        Me.BunifuTransition2.SetDecoration(Me.TabControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.TabControl1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(113, 30)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1234, 650)
        Me.TabControl1.TabIndex = 39
        '
        'tab_men_prod
        '
        Me.tab_men_prod.Controls.Add(Me.panelPPTO)
        Me.BunifuTransition2.SetDecoration(Me.tab_men_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.tab_men_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.tab_men_prod.Location = New System.Drawing.Point(4, 24)
        Me.tab_men_prod.Name = "tab_men_prod"
        Me.tab_men_prod.Size = New System.Drawing.Size(1226, 622)
        Me.tab_men_prod.TabIndex = 3
        Me.tab_men_prod.Text = "Producción"
        Me.tab_men_prod.UseVisualStyleBackColor = True
        '
        'panelPPTO
        '
        Me.panelPPTO.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelPPTO.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.panelPPTO.Controls.Add(Me.Label12)
        Me.panelPPTO.Controls.Add(Me.dtg_consumo_alambron)
        Me.panelPPTO.Controls.Add(Me.BunifuCards3)
        Me.panelPPTO.Controls.Add(Me.BunifuCards2)
        Me.panelPPTO.Controls.Add(Me.BunifuImageButton1)
        Me.panelPPTO.Controls.Add(Me.Label5)
        Me.panelPPTO.Controls.Add(Me.Label4)
        Me.panelPPTO.Controls.Add(Me.cb_mes_prod)
        Me.panelPPTO.Controls.Add(Me.cbo_ano_prod)
        Me.panelPPTO.Controls.Add(Me.BunifuCards1)
        Me.panelPPTO.Controls.Add(Me.bunitable)
        Me.panelPPTO.Controls.Add(Me.GunaWinSwitch1)
        Me.panelPPTO.Controls.Add(Me.BunifuChartCanvas1)
        Me.panelPPTO.Controls.Add(Me.BunifuButton11)
        Me.panelPPTO.Controls.Add(Me.BunifuButton10)
        Me.panelPPTO.Controls.Add(Me.BunifuButton9)
        Me.panelPPTO.Controls.Add(Me.BunifuButton8)
        Me.panelPPTO.Controls.Add(Me.BunifuButton7)
        Me.panelPPTO.Controls.Add(Me.BunifuButton6)
        Me.panelPPTO.Controls.Add(Me.BunifuButton5)
        Me.panelPPTO.Controls.Add(Me.BunifuButton4)
        Me.panelPPTO.Controls.Add(Me.BunifuButton3)
        Me.panelPPTO.Controls.Add(Me.BunifuButton2)
        Me.panelPPTO.Controls.Add(Me.BunifuButton1)
        Me.panelPPTO.Controls.Add(Me.CartesianChart1)
        Me.panelPPTO.Controls.Add(Me.Label42)
        Me.panelPPTO.Controls.Add(Me.dtd)
        Me.BunifuTransition2.SetDecoration(Me.panelPPTO, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.panelPPTO, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.panelPPTO.Location = New System.Drawing.Point(3, 4)
        Me.panelPPTO.Name = "panelPPTO"
        Me.panelPPTO.Size = New System.Drawing.Size(1220, 615)
        Me.panelPPTO.TabIndex = 2222233
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label12.Location = New System.Drawing.Point(933, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 15)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Ver consumo Alam"
        '
        'dtg_consumo_alambron
        '
        Me.dtg_consumo_alambron.AllowCustomTheming = False
        Me.dtg_consumo_alambron.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dtg_consumo_alambron.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtg_consumo_alambron.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_consumo_alambron.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_consumo_alambron.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_consumo_alambron.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.dtg_consumo_alambron.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_consumo_alambron.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtg_consumo_alambron.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dtg_consumo_alambron.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_consumo_alambron.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtg_consumo_alambron.ColumnHeadersHeight = 40
        Me.dtg_consumo_alambron.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(223, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtg_consumo_alambron.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dtg_consumo_alambron.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtg_consumo_alambron.CurrentTheme.BackColor = System.Drawing.Color.Purple
        Me.dtg_consumo_alambron.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Purple
        Me.dtg_consumo_alambron.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.dtg_consumo_alambron.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtg_consumo_alambron.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtg_consumo_alambron.CurrentTheme.Name = Nothing
        Me.dtg_consumo_alambron.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.dtg_consumo_alambron.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.dtg_consumo_alambron.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.dtg_consumo_alambron.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.BunifuTransition2.SetDecoration(Me.dtg_consumo_alambron, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.dtg_consumo_alambron, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(229, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(178, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_consumo_alambron.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtg_consumo_alambron.EnableHeadersVisualStyles = False
        Me.dtg_consumo_alambron.GridColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.dtg_consumo_alambron.HeaderBackColor = System.Drawing.Color.Purple
        Me.dtg_consumo_alambron.HeaderBgColor = System.Drawing.Color.Empty
        Me.dtg_consumo_alambron.HeaderForeColor = System.Drawing.Color.White
        Me.dtg_consumo_alambron.Location = New System.Drawing.Point(4, 249)
        Me.dtg_consumo_alambron.Margin = New System.Windows.Forms.Padding(1)
        Me.dtg_consumo_alambron.Name = "dtg_consumo_alambron"
        Me.dtg_consumo_alambron.ReadOnly = True
        Me.dtg_consumo_alambron.RowHeadersVisible = False
        Me.dtg_consumo_alambron.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtg_consumo_alambron.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dtg_consumo_alambron.RowTemplate.Height = 40
        Me.dtg_consumo_alambron.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.dtg_consumo_alambron.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_consumo_alambron.Size = New System.Drawing.Size(845, 83)
        Me.dtg_consumo_alambron.TabIndex = 2222267
        Me.dtg_consumo_alambron.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Purple
        Me.dtg_consumo_alambron.Visible = False
        '
        'BunifuCards3
        '
        Me.BunifuCards3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = False
        Me.BunifuCards3.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards3.Controls.Add(Me.lblpkg)
        Me.BunifuCards3.Controls.Add(Me.lblpptopkg)
        Me.BunifuCards3.Controls.Add(Me.Label11)
        Me.BunifuCards3.Controls.Add(Me.Label10)
        Me.BunifuCards3.Controls.Add(Me.BunifuSeparator3)
        Me.BunifuCards3.Controls.Add(Me.lbldiastrab)
        Me.BunifuCards3.Controls.Add(Me.lbldiasadd)
        Me.BunifuCards3.Controls.Add(Me.lbldiashabiles)
        Me.BunifuCards3.Controls.Add(Me.BunifuPictureBox2)
        Me.BunifuCards3.Controls.Add(Me.Label9)
        Me.BunifuCards3.Controls.Add(Me.Label8)
        Me.BunifuCards3.Controls.Add(Me.BunifuPictureBox1)
        Me.BunifuCards3.Controls.Add(Me.Label7)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(970, 391)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = False
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(247, 224)
        Me.BunifuCards3.TabIndex = 2222266
        '
        'lblpkg
        '
        Me.lblpkg.AutoSize = True
        Me.lblpkg.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblpkg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblpkg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblpkg.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpkg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblpkg.Location = New System.Drawing.Point(114, 182)
        Me.lblpkg.Name = "lblpkg"
        Me.lblpkg.Size = New System.Drawing.Size(74, 20)
        Me.lblpkg.TabIndex = 26
        Me.lblpkg.Text = "llevamos"
        '
        'lblpptopkg
        '
        Me.lblpptopkg.AutoSize = True
        Me.lblpptopkg.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblpptopkg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblpptopkg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblpptopkg.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpptopkg.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblpptopkg.Location = New System.Drawing.Point(114, 153)
        Me.lblpptopkg.Name = "lblpptopkg"
        Me.lblpptopkg.Size = New System.Drawing.Size(83, 20)
        Me.lblpptopkg.TabIndex = 26
        Me.lblpptopkg.Text = "ppto prod"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(26, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "P/KG:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(26, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 18)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "ppto P/KG:"
        '
        'BunifuSeparator3
        '
        Me.BunifuSeparator3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator3.BackgroundImage = CType(resources.GetObject("BunifuSeparator3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator3.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator3.LineColor = System.Drawing.Color.DodgerBlue
        Me.BunifuSeparator3.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded
        Me.BunifuSeparator3.LineThickness = 2
        Me.BunifuSeparator3.Location = New System.Drawing.Point(3, 105)
        Me.BunifuSeparator3.Name = "BunifuSeparator3"
        Me.BunifuSeparator3.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator3.Size = New System.Drawing.Size(241, 17)
        Me.BunifuSeparator3.TabIndex = 26
        '
        'lbldiastrab
        '
        Me.lbldiastrab.AutoSize = True
        Me.lbldiastrab.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbldiastrab, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbldiastrab, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbldiastrab.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiastrab.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbldiastrab.Location = New System.Drawing.Point(138, 74)
        Me.lbldiastrab.Name = "lbldiastrab"
        Me.lbldiastrab.Size = New System.Drawing.Size(50, 16)
        Me.lbldiastrab.TabIndex = 27
        Me.lbldiastrab.Text = "XXXXXX"
        '
        'lbldiasadd
        '
        Me.lbldiasadd.AutoSize = True
        Me.lbldiasadd.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbldiasadd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbldiasadd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbldiasadd.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiasadd.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbldiasadd.Location = New System.Drawing.Point(138, 58)
        Me.lbldiasadd.Name = "lbldiasadd"
        Me.lbldiasadd.Size = New System.Drawing.Size(50, 16)
        Me.lbldiasadd.TabIndex = 26
        Me.lbldiasadd.Text = "XXXXXX"
        '
        'lbldiashabiles
        '
        Me.lbldiashabiles.AutoSize = True
        Me.lbldiashabiles.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lbldiashabiles, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lbldiashabiles, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lbldiashabiles.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldiashabiles.ForeColor = System.Drawing.Color.OrangeRed
        Me.lbldiashabiles.Location = New System.Drawing.Point(138, 42)
        Me.lbldiashabiles.Name = "lbldiashabiles"
        Me.lbldiashabiles.Size = New System.Drawing.Size(50, 16)
        Me.lbldiashabiles.TabIndex = 25
        Me.lbldiashabiles.Text = "XXXXXX"
        '
        'BunifuPictureBox2
        '
        Me.BunifuPictureBox2.AllowFocused = False
        Me.BunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox2.AutoSizeHeight = True
        Me.BunifuPictureBox2.BorderRadius = 12
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox2.Image = CType(resources.GetObject("BunifuPictureBox2.Image"), System.Drawing.Image)
        Me.BunifuPictureBox2.IsCircle = True
        Me.BunifuPictureBox2.Location = New System.Drawing.Point(104, 11)
        Me.BunifuPictureBox2.Name = "BunifuPictureBox2"
        Me.BunifuPictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.BunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BunifuPictureBox2.TabIndex = 24
        Me.BunifuPictureBox2.TabStop = False
        Me.BunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(22, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Dias Trabajados:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label8.Location = New System.Drawing.Point(22, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 16)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Dias Adicionales:"
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 16
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(104, 119)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BunifuPictureBox1.TabIndex = 21
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(22, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Dias Hábiles: "
        '
        'BunifuCards2
        '
        Me.BunifuCards2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = False
        Me.BunifuCards2.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards2.Controls.Add(Me.BunifuSeparator2)
        Me.BunifuCards2.Controls.Add(Me.Label6)
        Me.BunifuCards2.Controls.Add(Me.BunifuCircleProgress2)
        Me.BunifuCards2.Controls.Add(Me.lblllevamoscant)
        Me.BunifuCards2.Controls.Add(Me.Label3)
        Me.BunifuCards2.Controls.Add(Me.lblptocantidad)
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(720, 392)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = False
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(247, 224)
        Me.BunifuCards2.TabIndex = 2222265
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.BackgroundImage = CType(resources.GetObject("BunifuSeparator2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.DodgerBlue
        Me.BunifuSeparator2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded
        Me.BunifuSeparator2.LineThickness = 2
        Me.BunifuSeparator2.Location = New System.Drawing.Point(0, 30)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator2.Size = New System.Drawing.Size(253, 15)
        Me.BunifuSeparator2.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(55, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Presupuesto Cantidad"
        '
        'BunifuCircleProgress2
        '
        Me.BunifuCircleProgress2.Animated = False
        Me.BunifuCircleProgress2.AnimationInterval = 1
        Me.BunifuCircleProgress2.AnimationSpeed = 1
        Me.BunifuCircleProgress2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress2.CircleMargin = 13
        Me.BunifuTransition2.SetDecoration(Me.BunifuCircleProgress2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCircleProgress2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCircleProgress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.IsPercentage = False
        Me.BunifuCircleProgress2.LineProgressThickness = 15
        Me.BunifuCircleProgress2.LineThickness = 15
        Me.BunifuCircleProgress2.Location = New System.Drawing.Point(69, 55)
        Me.BunifuCircleProgress2.Maximum = 200
        Me.BunifuCircleProgress2.Name = "BunifuCircleProgress2"
        Me.BunifuCircleProgress2.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress2.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress2.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Arrow
        Me.BunifuCircleProgress2.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.BunifuCircleProgress2.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Flat
        Me.BunifuCircleProgress2.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress2.Size = New System.Drawing.Size(114, 114)
        Me.BunifuCircleProgress2.SubScriptColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress2.SubScriptText = ""
        Me.BunifuCircleProgress2.SuperScriptColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress2.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress2.SuperScriptText = "%"
        Me.BunifuCircleProgress2.TabIndex = 22
        Me.BunifuCircleProgress2.Text = "30"
        Me.BunifuCircleProgress2.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress2.Value = 30
        Me.BunifuCircleProgress2.ValueByTransition = 30
        Me.BunifuCircleProgress2.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'lblllevamoscant
        '
        Me.lblllevamoscant.AutoSize = True
        Me.lblllevamoscant.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblllevamoscant, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblllevamoscant, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblllevamoscant.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblllevamoscant.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblllevamoscant.Location = New System.Drawing.Point(120, 191)
        Me.lblllevamoscant.Name = "lblllevamoscant"
        Me.lblllevamoscant.Size = New System.Drawing.Size(74, 20)
        Me.lblllevamoscant.TabIndex = 24
        Me.lblllevamoscant.Text = "llevamos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "ppto Cant"
        '
        'lblptocantidad
        '
        Me.lblptocantidad.AutoSize = True
        Me.lblptocantidad.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblptocantidad, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblptocantidad, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblptocantidad.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblptocantidad.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblptocantidad.Location = New System.Drawing.Point(120, 165)
        Me.lblptocantidad.Name = "lblptocantidad"
        Me.lblptocantidad.Size = New System.Drawing.Size(83, 20)
        Me.lblptocantidad.TabIndex = 23
        Me.lblptocantidad.Text = "ppto prod"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "LL. Cant"
        '
        'BunifuImageButton1
        '
        Me.BunifuImageButton1.ActiveImage = Nothing
        Me.BunifuImageButton1.AllowAnimations = True
        Me.BunifuImageButton1.AllowBuffering = False
        Me.BunifuImageButton1.AllowToggling = False
        Me.BunifuImageButton1.AllowZooming = True
        Me.BunifuImageButton1.AllowZoomingOnFocus = False
        Me.BunifuImageButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton1.ErrorImage = CType(resources.GetObject("BunifuImageButton1.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton1.FadeWhenInactive = False
        Me.BunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton1.Image = CType(resources.GetObject("BunifuImageButton1.Image"), System.Drawing.Image)
        Me.BunifuImageButton1.ImageActive = Nothing
        Me.BunifuImageButton1.ImageLocation = Nothing
        Me.BunifuImageButton1.ImageMargin = 20
        Me.BunifuImageButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton1.ImageZoomSize = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.InitialImage = CType(resources.GetObject("BunifuImageButton1.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton1.Location = New System.Drawing.Point(843, 0)
        Me.BunifuImageButton1.Name = "BunifuImageButton1"
        Me.BunifuImageButton1.Rotation = 0
        Me.BunifuImageButton1.ShowActiveImage = True
        Me.BunifuImageButton1.ShowCursorChanges = True
        Me.BunifuImageButton1.ShowImageBorders = True
        Me.BunifuImageButton1.ShowSizeMarkers = False
        Me.BunifuImageButton1.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton1.TabIndex = 2222264
        Me.BunifuImageButton1.ToolTipText = ""
        Me.BunifuImageButton1.WaitOnLoad = False
        Me.BunifuImageButton1.Zoom = 20
        Me.BunifuImageButton1.ZoomSpeed = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(691, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 20)
        Me.Label5.TabIndex = 2222263
        Me.Label5.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(528, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Año"
        '
        'cb_mes_prod
        '
        Me.cb_mes_prod.BackColor = System.Drawing.Color.Transparent
        Me.cb_mes_prod.BackgroundColor = System.Drawing.Color.White
        Me.cb_mes_prod.BorderColor = System.Drawing.Color.Silver
        Me.cb_mes_prod.BorderRadius = 8
        Me.cb_mes_prod.Color = System.Drawing.Color.Silver
        Me.BunifuTransition1.SetDecoration(Me.cb_mes_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.cb_mes_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.cb_mes_prod.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cb_mes_prod.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cb_mes_prod.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cb_mes_prod.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cb_mes_prod.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cb_mes_prod.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cb_mes_prod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cb_mes_prod.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cb_mes_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_mes_prod.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_mes_prod.FillDropDown = True
        Me.cb_mes_prod.FillIndicator = False
        Me.cb_mes_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_mes_prod.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_mes_prod.ForeColor = System.Drawing.Color.Black
        Me.cb_mes_prod.FormattingEnabled = True
        Me.cb_mes_prod.Icon = Nothing
        Me.cb_mes_prod.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_mes_prod.IndicatorColor = System.Drawing.Color.Gray
        Me.cb_mes_prod.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cb_mes_prod.ItemBackColor = System.Drawing.Color.White
        Me.cb_mes_prod.ItemBorderColor = System.Drawing.Color.White
        Me.cb_mes_prod.ItemForeColor = System.Drawing.Color.Black
        Me.cb_mes_prod.ItemHeight = 19
        Me.cb_mes_prod.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cb_mes_prod.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cb_mes_prod.Items.AddRange(New Object() {"Seleccione", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cb_mes_prod.ItemTopMargin = 3
        Me.cb_mes_prod.Location = New System.Drawing.Point(726, 9)
        Me.cb_mes_prod.MaxDropDownItems = 12
        Me.cb_mes_prod.Name = "cb_mes_prod"
        Me.cb_mes_prod.Size = New System.Drawing.Size(114, 25)
        Me.cb_mes_prod.TabIndex = 2222262
        Me.cb_mes_prod.Text = Nothing
        Me.cb_mes_prod.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cb_mes_prod.TextLeftMargin = 5
        '
        'cbo_ano_prod
        '
        Me.cbo_ano_prod.BackColor = System.Drawing.Color.Transparent
        Me.cbo_ano_prod.BackgroundColor = System.Drawing.Color.White
        Me.cbo_ano_prod.BorderColor = System.Drawing.Color.Silver
        Me.cbo_ano_prod.BorderRadius = 8
        Me.cbo_ano_prod.Color = System.Drawing.Color.Silver
        Me.cbo_ano_prod.DataSource = Me.FVanosprodBindingSource
        Me.BunifuTransition1.SetDecoration(Me.cbo_ano_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.cbo_ano_prod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.cbo_ano_prod.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.cbo_ano_prod.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbo_ano_prod.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.cbo_ano_prod.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.cbo_ano_prod.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.cbo_ano_prod.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.cbo_ano_prod.DisplayMember = "ano"
        Me.cbo_ano_prod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbo_ano_prod.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.cbo_ano_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ano_prod.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbo_ano_prod.FillDropDown = True
        Me.cbo_ano_prod.FillIndicator = False
        Me.cbo_ano_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_ano_prod.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ano_prod.ForeColor = System.Drawing.Color.Black
        Me.cbo_ano_prod.FormattingEnabled = True
        Me.cbo_ano_prod.Icon = Nothing
        Me.cbo_ano_prod.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbo_ano_prod.IndicatorColor = System.Drawing.Color.Gray
        Me.cbo_ano_prod.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.cbo_ano_prod.ItemBackColor = System.Drawing.Color.White
        Me.cbo_ano_prod.ItemBorderColor = System.Drawing.Color.White
        Me.cbo_ano_prod.ItemForeColor = System.Drawing.Color.Black
        Me.cbo_ano_prod.ItemHeight = 19
        Me.cbo_ano_prod.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.cbo_ano_prod.ItemHighLightForeColor = System.Drawing.Color.White
        Me.cbo_ano_prod.ItemTopMargin = 3
        Me.cbo_ano_prod.Location = New System.Drawing.Point(561, 9)
        Me.cbo_ano_prod.Name = "cbo_ano_prod"
        Me.cbo_ano_prod.Size = New System.Drawing.Size(108, 25)
        Me.cbo_ano_prod.TabIndex = 2222261
        Me.cbo_ano_prod.Text = Nothing
        Me.cbo_ano_prod.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.cbo_ano_prod.TextLeftMargin = 5
        Me.cbo_ano_prod.ValueMember = "ano"
        '
        'FVanosprodBindingSource
        '
        Me.FVanosprodBindingSource.DataMember = "F_V_anos_prod"
        Me.FVanosprodBindingSource.DataSource = Me.PRGPRODUCCIONDataSet2
        '
        'PRGPRODUCCIONDataSet2
        '
        Me.PRGPRODUCCIONDataSet2.DataSetName = "PRGPRODUCCIONDataSet2"
        Me.PRGPRODUCCIONDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuCards1
        '
        Me.BunifuCards1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCards1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = False
        Me.BunifuCards1.color = System.Drawing.Color.DodgerBlue
        Me.BunifuCards1.Controls.Add(Me.BunifuSeparator1)
        Me.BunifuCards1.Controls.Add(Me.Label27)
        Me.BunifuCards1.Controls.Add(Me.Label26)
        Me.BunifuCards1.Controls.Add(Me.BunifuCircleProgress1)
        Me.BunifuCards1.Controls.Add(Me.lblcentro)
        Me.BunifuCards1.Controls.Add(Me.lblllevamos)
        Me.BunifuCards1.Controls.Add(Me.lblpptoprod)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(467, 391)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = False
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(247, 224)
        Me.BunifuCards1.TabIndex = 2222248
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.BackgroundImage = CType(resources.GetObject("BunifuSeparator1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.DodgerBlue
        Me.BunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(0, 32)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator1.Size = New System.Drawing.Size(242, 13)
        Me.BunifuSeparator1.TabIndex = 19
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label27.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(1, 196)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 18)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "llevamos"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label26.Location = New System.Drawing.Point(3, 170)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 18)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "ppto prod"
        '
        'BunifuCircleProgress1
        '
        Me.BunifuCircleProgress1.AccessibleName = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.Animated = False
        Me.BunifuCircleProgress1.AnimationInterval = 1
        Me.BunifuCircleProgress1.AnimationSpeed = 1
        Me.BunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress1.CircleMargin = 13
        Me.BunifuTransition2.SetDecoration(Me.BunifuCircleProgress1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCircleProgress1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCircleProgress1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.IsPercentage = False
        Me.BunifuCircleProgress1.LineProgressThickness = 15
        Me.BunifuCircleProgress1.LineThickness = 15
        Me.BunifuCircleProgress1.Location = New System.Drawing.Point(65, 49)
        Me.BunifuCircleProgress1.Maximum = 200
        Me.BunifuCircleProgress1.Name = "BunifuCircleProgress1"
        Me.BunifuCircleProgress1.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Arrow
        Me.BunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.BunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Flat
        Me.BunifuCircleProgress1.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.BunifuCircleProgress1.Size = New System.Drawing.Size(114, 114)
        Me.BunifuCircleProgress1.SubScriptColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress1.SubScriptText = ""
        Me.BunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress1.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress1.SuperScriptText = "%"
        Me.BunifuCircleProgress1.TabIndex = 16
        Me.BunifuCircleProgress1.Text = "30"
        Me.BunifuCircleProgress1.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress1.Value = 30
        Me.BunifuCircleProgress1.ValueByTransition = 30
        Me.BunifuCircleProgress1.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'lblcentro
        '
        Me.lblcentro.AutoSize = True
        Me.lblcentro.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblcentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblcentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblcentro.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcentro.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblcentro.Location = New System.Drawing.Point(3, 14)
        Me.lblcentro.Name = "lblcentro"
        Me.lblcentro.Size = New System.Drawing.Size(38, 15)
        Me.lblcentro.TabIndex = 6
        Me.lblcentro.Text = "Centro"
        '
        'lblllevamos
        '
        Me.lblllevamos.AutoSize = True
        Me.lblllevamos.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblllevamos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblllevamos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblllevamos.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblllevamos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblllevamos.Location = New System.Drawing.Point(90, 196)
        Me.lblllevamos.Name = "lblllevamos"
        Me.lblllevamos.Size = New System.Drawing.Size(74, 20)
        Me.lblllevamos.TabIndex = 8
        Me.lblllevamos.Text = "llevamos"
        '
        'lblpptoprod
        '
        Me.lblpptoprod.AutoSize = True
        Me.lblpptoprod.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.lblpptoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.lblpptoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblpptoprod.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpptoprod.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblpptoprod.Location = New System.Drawing.Point(92, 171)
        Me.lblpptoprod.Name = "lblpptoprod"
        Me.lblpptoprod.Size = New System.Drawing.Size(83, 20)
        Me.lblpptoprod.TabIndex = 7
        Me.lblpptoprod.Text = "ppto prod"
        '
        'bunitable
        '
        Me.bunitable.AllowCustomTheming = False
        Me.bunitable.AllowUserToAddRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.bunitable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.bunitable.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bunitable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.bunitable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.bunitable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.bunitable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.bunitable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.bunitable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.bunitable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.bunitable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.bunitable.ColumnHeadersHeight = 40
        Me.bunitable.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.bunitable.CurrentTheme.AlternatingRowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bunitable.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.bunitable.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.bunitable.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.bunitable.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunitable.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.bunitable.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunitable.CurrentTheme.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.75!, System.Drawing.FontStyle.Bold)
        Me.bunitable.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.bunitable.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.bunitable.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.bunitable.CurrentTheme.Name = Nothing
        Me.bunitable.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.bunitable.CurrentTheme.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.bunitable.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.bunitable.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.bunitable.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuTransition2.SetDecoration(Me.bunitable, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.bunitable, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.bunitable.DefaultCellStyle = DataGridViewCellStyle7
        Me.bunitable.EnableHeadersVisualStyles = False
        Me.bunitable.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.bunitable.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.bunitable.HeaderBgColor = System.Drawing.Color.Empty
        Me.bunitable.HeaderForeColor = System.Drawing.Color.White
        Me.bunitable.Location = New System.Drawing.Point(8, 76)
        Me.bunitable.Margin = New System.Windows.Forms.Padding(1)
        Me.bunitable.Name = "bunitable"
        Me.bunitable.ReadOnly = True
        Me.bunitable.RowHeadersVisible = False
        Me.bunitable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.bunitable.RowTemplate.Height = 40
        Me.bunitable.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.bunitable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.bunitable.Size = New System.Drawing.Size(1190, 285)
        Me.bunitable.TabIndex = 30
        Me.bunitable.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark
        '
        'GunaWinSwitch1
        '
        Me.GunaWinSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaWinSwitch1.CheckedOffColor = System.Drawing.Color.DeepSkyBlue
        Me.GunaWinSwitch1.CheckedOnColor = System.Drawing.Color.DarkMagenta
        Me.BunifuTransition2.SetDecoration(Me.GunaWinSwitch1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaWinSwitch1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaWinSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaWinSwitch1.Location = New System.Drawing.Point(891, 10)
        Me.GunaWinSwitch1.Name = "GunaWinSwitch1"
        Me.GunaWinSwitch1.Size = New System.Drawing.Size(40, 22)
        Me.GunaWinSwitch1.TabIndex = 61
        '
        'BunifuChartCanvas1
        '
        Me.BunifuChartCanvas1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BunifuChartCanvas1.AnimationDuration = 500
        Me.BunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeInQuad
        Me.BunifuChartCanvas1.AutoScroll = True
        Me.BunifuChartCanvas1.AutoSize = True
        Me.BunifuChartCanvas1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuChartCanvas1.CanvasPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuTransition2.SetDecoration(Me.BunifuChartCanvas1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuChartCanvas1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuChartCanvas1.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec", " ", ""}
        Me.BunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas1.LegendDisplay = True
        Me.BunifuChartCanvas1.LegendFont = New System.Drawing.Font("Arial Narrow", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas1.LegendForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.LegendFullWidth = True
        Me.BunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom
        Me.BunifuChartCanvas1.LegendRevese = False
        Me.BunifuChartCanvas1.LegendRTL = False
        Me.BunifuChartCanvas1.Location = New System.Drawing.Point(8, 392)
        Me.BunifuChartCanvas1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.BunifuChartCanvas1.Name = "BunifuChartCanvas1"
        Me.BunifuChartCanvas1.ShowXAxis = True
        Me.BunifuChartCanvas1.ShowYAxis = True
        Me.BunifuChartCanvas1.Size = New System.Drawing.Size(400, 215)
        Me.BunifuChartCanvas1.TabIndex = 2222260
        Me.BunifuChartCanvas1.Title = ""
        Me.BunifuChartCanvas1.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas1.TitlePadding = 10
        Me.BunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom
        Me.BunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.average
        Me.BunifuChartCanvas1.TooltipsEnabled = True
        Me.BunifuChartCanvas1.XAxesBeginAtZero = True
        Me.BunifuChartCanvas1.XAxesDrawTicks = True
        Me.BunifuChartCanvas1.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.XAxesGridLines = False
        Me.BunifuChartCanvas1.XAxesLabel = ""
        Me.BunifuChartCanvas1.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuChartCanvas1.XAxesLineWidth = 1
        Me.BunifuChartCanvas1.XAxesStacked = True
        Me.BunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.BunifuChartCanvas1.XAxesZeroLineWidth = 5
        Me.BunifuChartCanvas1.YAxesBeginAtZero = True
        Me.BunifuChartCanvas1.YAxesDrawTicks = True
        Me.BunifuChartCanvas1.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.YAxesGridLines = True
        Me.BunifuChartCanvas1.YAxesLabel = ""
        Me.BunifuChartCanvas1.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas1.YAxesLineWidth = 1
        Me.BunifuChartCanvas1.YAxesStacked = True
        Me.BunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas1.YAxesZeroLineWidth = 1
        '
        'BunifuButton11
        '
        Me.BunifuButton11.AllowAnimations = True
        Me.BunifuButton11.AllowMouseEffects = True
        Me.BunifuButton11.AllowToggling = False
        Me.BunifuButton11.AnimationSpeed = 200
        Me.BunifuButton11.AutoGenerateColors = False
        Me.BunifuButton11.AutoRoundBorders = False
        Me.BunifuButton11.AutoSizeLeftIcon = True
        Me.BunifuButton11.AutoSizeRightIcon = True
        Me.BunifuButton11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton11.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton11.BackgroundImage = CType(resources.GetObject("BunifuButton11.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton11.ButtonText = "Puas"
        Me.BunifuButton11.ButtonTextMarginLeft = 0
        Me.BunifuButton11.ColorContrastOnClick = 45
        Me.BunifuButton11.ColorContrastOnHover = 45
        Me.BunifuButton11.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = False
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = False
        BorderEdges1.TopRight = True
        Me.BunifuButton11.CustomizableEdges = BorderEdges1
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton11.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton11.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton11.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton11.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton11.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton11.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton11.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton11.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton11.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton11.IconMarginLeft = 11
        Me.BunifuButton11.IconPadding = 10
        Me.BunifuButton11.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton11.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton11.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton11.IconSize = 25
        Me.BunifuButton11.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.IdleBorderRadius = 10
        Me.BunifuButton11.IdleBorderThickness = 2
        Me.BunifuButton11.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton11.IdleIconLeftImage = Nothing
        Me.BunifuButton11.IdleIconRightImage = Nothing
        Me.BunifuButton11.IndicateFocus = False
        Me.BunifuButton11.Location = New System.Drawing.Point(905, 46)
        Me.BunifuButton11.Name = "BunifuButton11"
        Me.BunifuButton11.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton11.OnDisabledState.BorderRadius = 10
        Me.BunifuButton11.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton11.OnDisabledState.BorderThickness = 2
        Me.BunifuButton11.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton11.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton11.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton11.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton11.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton11.onHoverState.BorderRadius = 10
        Me.BunifuButton11.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton11.onHoverState.BorderThickness = 2
        Me.BunifuButton11.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton11.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton11.onHoverState.IconRightImage = Nothing
        Me.BunifuButton11.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.OnIdleState.BorderRadius = 10
        Me.BunifuButton11.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton11.OnIdleState.BorderThickness = 2
        Me.BunifuButton11.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton11.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton11.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton11.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton11.OnPressedState.BorderRadius = 10
        Me.BunifuButton11.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton11.OnPressedState.BorderThickness = 2
        Me.BunifuButton11.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton11.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton11.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton11.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton11.Size = New System.Drawing.Size(78, 30)
        Me.BunifuButton11.TabIndex = 2222259
        Me.BunifuButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton11.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton11.TextMarginLeft = 0
        Me.BunifuButton11.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton11.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton10
        '
        Me.BunifuButton10.AllowAnimations = True
        Me.BunifuButton10.AllowMouseEffects = True
        Me.BunifuButton10.AllowToggling = False
        Me.BunifuButton10.AnimationSpeed = 200
        Me.BunifuButton10.AutoGenerateColors = False
        Me.BunifuButton10.AutoRoundBorders = False
        Me.BunifuButton10.AutoSizeLeftIcon = True
        Me.BunifuButton10.AutoSizeRightIcon = True
        Me.BunifuButton10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton10.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton10.BackgroundImage = CType(resources.GetObject("BunifuButton10.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton10.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton10.ButtonText = "Tratamientos Termicos"
        Me.BunifuButton10.ButtonTextMarginLeft = 0
        Me.BunifuButton10.ColorContrastOnClick = 45
        Me.BunifuButton10.ColorContrastOnHover = 45
        Me.BunifuButton10.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = False
        BorderEdges2.BottomRight = False
        BorderEdges2.TopLeft = False
        BorderEdges2.TopRight = False
        Me.BunifuButton10.CustomizableEdges = BorderEdges2
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton10.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton10.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton10.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton10.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton10.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton10.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton10.IconMarginLeft = 11
        Me.BunifuButton10.IconPadding = 10
        Me.BunifuButton10.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton10.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton10.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton10.IconSize = 25
        Me.BunifuButton10.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.IdleBorderRadius = 10
        Me.BunifuButton10.IdleBorderThickness = 2
        Me.BunifuButton10.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton10.IdleIconLeftImage = Nothing
        Me.BunifuButton10.IdleIconRightImage = Nothing
        Me.BunifuButton10.IndicateFocus = False
        Me.BunifuButton10.Location = New System.Drawing.Point(758, 46)
        Me.BunifuButton10.Name = "BunifuButton10"
        Me.BunifuButton10.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton10.OnDisabledState.BorderRadius = 10
        Me.BunifuButton10.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton10.OnDisabledState.BorderThickness = 2
        Me.BunifuButton10.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton10.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton10.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton10.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton10.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton10.onHoverState.BorderRadius = 10
        Me.BunifuButton10.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton10.onHoverState.BorderThickness = 2
        Me.BunifuButton10.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton10.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton10.onHoverState.IconRightImage = Nothing
        Me.BunifuButton10.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.OnIdleState.BorderRadius = 10
        Me.BunifuButton10.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton10.OnIdleState.BorderThickness = 2
        Me.BunifuButton10.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton10.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton10.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton10.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton10.OnPressedState.BorderRadius = 10
        Me.BunifuButton10.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton10.OnPressedState.BorderThickness = 2
        Me.BunifuButton10.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton10.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton10.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton10.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton10.Size = New System.Drawing.Size(149, 30)
        Me.BunifuButton10.TabIndex = 2222258
        Me.BunifuButton10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton10.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton10.TextMarginLeft = 0
        Me.BunifuButton10.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton10.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton9
        '
        Me.BunifuButton9.AllowAnimations = True
        Me.BunifuButton9.AllowMouseEffects = True
        Me.BunifuButton9.AllowToggling = False
        Me.BunifuButton9.AnimationSpeed = 200
        Me.BunifuButton9.AutoGenerateColors = False
        Me.BunifuButton9.AutoRoundBorders = False
        Me.BunifuButton9.AutoSizeLeftIcon = True
        Me.BunifuButton9.AutoSizeRightIcon = True
        Me.BunifuButton9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton9.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton9.BackgroundImage = CType(resources.GetObject("BunifuButton9.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton9.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton9.ButtonText = "Empaque Grap"
        Me.BunifuButton9.ButtonTextMarginLeft = 0
        Me.BunifuButton9.ColorContrastOnClick = 45
        Me.BunifuButton9.ColorContrastOnHover = 45
        Me.BunifuButton9.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges3.BottomLeft = False
        BorderEdges3.BottomRight = False
        BorderEdges3.TopLeft = False
        BorderEdges3.TopRight = False
        Me.BunifuButton9.CustomizableEdges = BorderEdges3
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton9.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton9.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton9.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton9.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton9.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton9.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton9.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton9.IconMarginLeft = 11
        Me.BunifuButton9.IconPadding = 10
        Me.BunifuButton9.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton9.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton9.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton9.IconSize = 25
        Me.BunifuButton9.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.IdleBorderRadius = 10
        Me.BunifuButton9.IdleBorderThickness = 2
        Me.BunifuButton9.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton9.IdleIconLeftImage = Nothing
        Me.BunifuButton9.IdleIconRightImage = Nothing
        Me.BunifuButton9.IndicateFocus = False
        Me.BunifuButton9.Location = New System.Drawing.Point(668, 46)
        Me.BunifuButton9.Name = "BunifuButton9"
        Me.BunifuButton9.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton9.OnDisabledState.BorderRadius = 10
        Me.BunifuButton9.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton9.OnDisabledState.BorderThickness = 2
        Me.BunifuButton9.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton9.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton9.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton9.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton9.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton9.onHoverState.BorderRadius = 10
        Me.BunifuButton9.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton9.onHoverState.BorderThickness = 2
        Me.BunifuButton9.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton9.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton9.onHoverState.IconRightImage = Nothing
        Me.BunifuButton9.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.OnIdleState.BorderRadius = 10
        Me.BunifuButton9.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton9.OnIdleState.BorderThickness = 2
        Me.BunifuButton9.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton9.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton9.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton9.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton9.OnPressedState.BorderRadius = 10
        Me.BunifuButton9.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton9.OnPressedState.BorderThickness = 2
        Me.BunifuButton9.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton9.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton9.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton9.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton9.Size = New System.Drawing.Size(92, 30)
        Me.BunifuButton9.TabIndex = 2222257
        Me.BunifuButton9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton9.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton9.TextMarginLeft = 0
        Me.BunifuButton9.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton9.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton8
        '
        Me.BunifuButton8.AllowAnimations = True
        Me.BunifuButton8.AllowMouseEffects = True
        Me.BunifuButton8.AllowToggling = False
        Me.BunifuButton8.AnimationSpeed = 200
        Me.BunifuButton8.AutoGenerateColors = False
        Me.BunifuButton8.AutoRoundBorders = False
        Me.BunifuButton8.AutoSizeLeftIcon = True
        Me.BunifuButton8.AutoSizeRightIcon = True
        Me.BunifuButton8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton8.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton8.BackgroundImage = CType(resources.GetObject("BunifuButton8.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton8.ButtonText = "Grapas"
        Me.BunifuButton8.ButtonTextMarginLeft = 0
        Me.BunifuButton8.ColorContrastOnClick = 45
        Me.BunifuButton8.ColorContrastOnHover = 45
        Me.BunifuButton8.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges4.BottomLeft = False
        BorderEdges4.BottomRight = False
        BorderEdges4.TopLeft = False
        BorderEdges4.TopRight = False
        Me.BunifuButton8.CustomizableEdges = BorderEdges4
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton8.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton8.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton8.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton8.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton8.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton8.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton8.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton8.IconMarginLeft = 11
        Me.BunifuButton8.IconPadding = 10
        Me.BunifuButton8.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton8.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton8.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton8.IconSize = 25
        Me.BunifuButton8.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.IdleBorderRadius = 10
        Me.BunifuButton8.IdleBorderThickness = 2
        Me.BunifuButton8.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton8.IdleIconLeftImage = Nothing
        Me.BunifuButton8.IdleIconRightImage = Nothing
        Me.BunifuButton8.IndicateFocus = False
        Me.BunifuButton8.Location = New System.Drawing.Point(577, 46)
        Me.BunifuButton8.Name = "BunifuButton8"
        Me.BunifuButton8.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton8.OnDisabledState.BorderRadius = 10
        Me.BunifuButton8.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton8.OnDisabledState.BorderThickness = 2
        Me.BunifuButton8.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton8.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton8.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton8.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton8.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton8.onHoverState.BorderRadius = 10
        Me.BunifuButton8.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton8.onHoverState.BorderThickness = 2
        Me.BunifuButton8.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton8.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton8.onHoverState.IconRightImage = Nothing
        Me.BunifuButton8.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.OnIdleState.BorderRadius = 10
        Me.BunifuButton8.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton8.OnIdleState.BorderThickness = 2
        Me.BunifuButton8.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton8.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton8.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton8.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton8.OnPressedState.BorderRadius = 10
        Me.BunifuButton8.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton8.OnPressedState.BorderThickness = 2
        Me.BunifuButton8.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton8.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton8.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton8.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton8.Size = New System.Drawing.Size(92, 30)
        Me.BunifuButton8.TabIndex = 2222256
        Me.BunifuButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton8.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton8.TextMarginLeft = 0
        Me.BunifuButton8.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton8.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton7
        '
        Me.BunifuButton7.AllowAnimations = True
        Me.BunifuButton7.AllowMouseEffects = True
        Me.BunifuButton7.AllowToggling = False
        Me.BunifuButton7.AnimationSpeed = 200
        Me.BunifuButton7.AutoGenerateColors = False
        Me.BunifuButton7.AutoRoundBorders = False
        Me.BunifuButton7.AutoSizeLeftIcon = True
        Me.BunifuButton7.AutoSizeRightIcon = True
        Me.BunifuButton7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton7.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton7.BackgroundImage = CType(resources.GetObject("BunifuButton7.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.ButtonText = "Galvanizado"
        Me.BunifuButton7.ButtonTextMarginLeft = 0
        Me.BunifuButton7.ColorContrastOnClick = 45
        Me.BunifuButton7.ColorContrastOnHover = 45
        Me.BunifuButton7.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges5.BottomLeft = False
        BorderEdges5.BottomRight = False
        BorderEdges5.TopLeft = False
        BorderEdges5.TopRight = False
        Me.BunifuButton7.CustomizableEdges = BorderEdges5
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton7.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton7.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton7.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton7.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton7.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton7.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton7.IconMarginLeft = 11
        Me.BunifuButton7.IconPadding = 10
        Me.BunifuButton7.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton7.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton7.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton7.IconSize = 25
        Me.BunifuButton7.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.IdleBorderRadius = 10
        Me.BunifuButton7.IdleBorderThickness = 2
        Me.BunifuButton7.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton7.IdleIconLeftImage = Nothing
        Me.BunifuButton7.IdleIconRightImage = Nothing
        Me.BunifuButton7.IndicateFocus = False
        Me.BunifuButton7.Location = New System.Drawing.Point(487, 46)
        Me.BunifuButton7.Name = "BunifuButton7"
        Me.BunifuButton7.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.BorderRadius = 10
        Me.BunifuButton7.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnDisabledState.BorderThickness = 2
        Me.BunifuButton7.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton7.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton7.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton7.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton7.onHoverState.BorderRadius = 10
        Me.BunifuButton7.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.onHoverState.BorderThickness = 2
        Me.BunifuButton7.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton7.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton7.onHoverState.IconRightImage = Nothing
        Me.BunifuButton7.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.OnIdleState.BorderRadius = 10
        Me.BunifuButton7.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnIdleState.BorderThickness = 2
        Me.BunifuButton7.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton7.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton7.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton7.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton7.OnPressedState.BorderRadius = 10
        Me.BunifuButton7.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton7.OnPressedState.BorderThickness = 2
        Me.BunifuButton7.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton7.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton7.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton7.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton7.Size = New System.Drawing.Size(92, 30)
        Me.BunifuButton7.TabIndex = 2222255
        Me.BunifuButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton7.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton7.TextMarginLeft = 0
        Me.BunifuButton7.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton7.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton6
        '
        Me.BunifuButton6.AllowAnimations = True
        Me.BunifuButton6.AllowMouseEffects = True
        Me.BunifuButton6.AllowToggling = False
        Me.BunifuButton6.AnimationSpeed = 200
        Me.BunifuButton6.AutoGenerateColors = False
        Me.BunifuButton6.AutoRoundBorders = False
        Me.BunifuButton6.AutoSizeLeftIcon = True
        Me.BunifuButton6.AutoSizeRightIcon = True
        Me.BunifuButton6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton6.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton6.BackgroundImage = CType(resources.GetObject("BunifuButton6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.ButtonText = "Empaque Torn"
        Me.BunifuButton6.ButtonTextMarginLeft = 0
        Me.BunifuButton6.ColorContrastOnClick = 45
        Me.BunifuButton6.ColorContrastOnHover = 45
        Me.BunifuButton6.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges6.BottomLeft = False
        BorderEdges6.BottomRight = False
        BorderEdges6.TopLeft = False
        BorderEdges6.TopRight = False
        Me.BunifuButton6.CustomizableEdges = BorderEdges6
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton6.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton6.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton6.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton6.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton6.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton6.IconMarginLeft = 11
        Me.BunifuButton6.IconPadding = 10
        Me.BunifuButton6.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton6.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton6.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton6.IconSize = 25
        Me.BunifuButton6.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.IdleBorderRadius = 10
        Me.BunifuButton6.IdleBorderThickness = 2
        Me.BunifuButton6.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton6.IdleIconLeftImage = Nothing
        Me.BunifuButton6.IdleIconRightImage = Nothing
        Me.BunifuButton6.IndicateFocus = False
        Me.BunifuButton6.Location = New System.Drawing.Point(396, 46)
        Me.BunifuButton6.Name = "BunifuButton6"
        Me.BunifuButton6.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.BorderRadius = 10
        Me.BunifuButton6.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnDisabledState.BorderThickness = 2
        Me.BunifuButton6.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton6.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton6.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton6.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton6.onHoverState.BorderRadius = 10
        Me.BunifuButton6.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.onHoverState.BorderThickness = 2
        Me.BunifuButton6.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton6.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton6.onHoverState.IconRightImage = Nothing
        Me.BunifuButton6.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.OnIdleState.BorderRadius = 10
        Me.BunifuButton6.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnIdleState.BorderThickness = 2
        Me.BunifuButton6.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton6.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton6.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton6.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton6.OnPressedState.BorderRadius = 10
        Me.BunifuButton6.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton6.OnPressedState.BorderThickness = 2
        Me.BunifuButton6.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton6.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton6.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton6.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton6.Size = New System.Drawing.Size(92, 30)
        Me.BunifuButton6.TabIndex = 2222254
        Me.BunifuButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton6.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton6.TextMarginLeft = 0
        Me.BunifuButton6.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton6.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton5
        '
        Me.BunifuButton5.AllowAnimations = True
        Me.BunifuButton5.AllowMouseEffects = True
        Me.BunifuButton5.AllowToggling = False
        Me.BunifuButton5.AnimationSpeed = 200
        Me.BunifuButton5.AutoGenerateColors = False
        Me.BunifuButton5.AutoRoundBorders = False
        Me.BunifuButton5.AutoSizeLeftIcon = True
        Me.BunifuButton5.AutoSizeRightIcon = True
        Me.BunifuButton5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton5.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton5.BackgroundImage = CType(resources.GetObject("BunifuButton5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.ButtonText = "Tornilleria"
        Me.BunifuButton5.ButtonTextMarginLeft = 0
        Me.BunifuButton5.ColorContrastOnClick = 45
        Me.BunifuButton5.ColorContrastOnHover = 45
        Me.BunifuButton5.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges7.BottomLeft = False
        BorderEdges7.BottomRight = False
        BorderEdges7.TopLeft = False
        BorderEdges7.TopRight = False
        Me.BunifuButton5.CustomizableEdges = BorderEdges7
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton5.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton5.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton5.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton5.IconMarginLeft = 11
        Me.BunifuButton5.IconPadding = 10
        Me.BunifuButton5.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton5.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton5.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton5.IconSize = 25
        Me.BunifuButton5.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.IdleBorderRadius = 10
        Me.BunifuButton5.IdleBorderThickness = 2
        Me.BunifuButton5.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton5.IdleIconLeftImage = Nothing
        Me.BunifuButton5.IdleIconRightImage = Nothing
        Me.BunifuButton5.IndicateFocus = False
        Me.BunifuButton5.Location = New System.Drawing.Point(319, 46)
        Me.BunifuButton5.Name = "BunifuButton5"
        Me.BunifuButton5.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.BorderRadius = 10
        Me.BunifuButton5.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnDisabledState.BorderThickness = 2
        Me.BunifuButton5.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton5.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton5.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton5.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton5.onHoverState.BorderRadius = 10
        Me.BunifuButton5.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.onHoverState.BorderThickness = 2
        Me.BunifuButton5.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton5.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton5.onHoverState.IconRightImage = Nothing
        Me.BunifuButton5.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.OnIdleState.BorderRadius = 10
        Me.BunifuButton5.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnIdleState.BorderThickness = 2
        Me.BunifuButton5.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton5.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton5.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton5.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton5.OnPressedState.BorderRadius = 10
        Me.BunifuButton5.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton5.OnPressedState.BorderThickness = 2
        Me.BunifuButton5.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton5.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton5.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton5.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton5.Size = New System.Drawing.Size(78, 30)
        Me.BunifuButton5.TabIndex = 2222253
        Me.BunifuButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton5.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton5.TextMarginLeft = 0
        Me.BunifuButton5.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton5.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton4
        '
        Me.BunifuButton4.AllowAnimations = True
        Me.BunifuButton4.AllowMouseEffects = True
        Me.BunifuButton4.AllowToggling = False
        Me.BunifuButton4.AnimationSpeed = 200
        Me.BunifuButton4.AutoGenerateColors = False
        Me.BunifuButton4.AutoRoundBorders = False
        Me.BunifuButton4.AutoSizeLeftIcon = True
        Me.BunifuButton4.AutoSizeRightIcon = True
        Me.BunifuButton4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton4.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton4.BackgroundImage = CType(resources.GetObject("BunifuButton4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.ButtonText = "Empaque Punt"
        Me.BunifuButton4.ButtonTextMarginLeft = 0
        Me.BunifuButton4.ColorContrastOnClick = 45
        Me.BunifuButton4.ColorContrastOnHover = 45
        Me.BunifuButton4.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges8.BottomLeft = False
        BorderEdges8.BottomRight = False
        BorderEdges8.TopLeft = False
        BorderEdges8.TopRight = False
        Me.BunifuButton4.CustomizableEdges = BorderEdges8
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton4.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton4.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton4.IconMarginLeft = 11
        Me.BunifuButton4.IconPadding = 10
        Me.BunifuButton4.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton4.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton4.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton4.IconSize = 25
        Me.BunifuButton4.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.IdleBorderRadius = 10
        Me.BunifuButton4.IdleBorderThickness = 2
        Me.BunifuButton4.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton4.IdleIconLeftImage = Nothing
        Me.BunifuButton4.IdleIconRightImage = Nothing
        Me.BunifuButton4.IndicateFocus = False
        Me.BunifuButton4.Location = New System.Drawing.Point(229, 46)
        Me.BunifuButton4.Name = "BunifuButton4"
        Me.BunifuButton4.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.BorderRadius = 10
        Me.BunifuButton4.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnDisabledState.BorderThickness = 2
        Me.BunifuButton4.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton4.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton4.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton4.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton4.onHoverState.BorderRadius = 10
        Me.BunifuButton4.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.onHoverState.BorderThickness = 2
        Me.BunifuButton4.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton4.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton4.onHoverState.IconRightImage = Nothing
        Me.BunifuButton4.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.OnIdleState.BorderRadius = 10
        Me.BunifuButton4.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnIdleState.BorderThickness = 2
        Me.BunifuButton4.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton4.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton4.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton4.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton4.OnPressedState.BorderRadius = 10
        Me.BunifuButton4.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton4.OnPressedState.BorderThickness = 2
        Me.BunifuButton4.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton4.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton4.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton4.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton4.Size = New System.Drawing.Size(92, 30)
        Me.BunifuButton4.TabIndex = 2222252
        Me.BunifuButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton4.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton4.TextMarginLeft = 0
        Me.BunifuButton4.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton4.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton3
        '
        Me.BunifuButton3.AllowAnimations = True
        Me.BunifuButton3.AllowMouseEffects = True
        Me.BunifuButton3.AllowToggling = False
        Me.BunifuButton3.AnimationSpeed = 200
        Me.BunifuButton3.AutoGenerateColors = False
        Me.BunifuButton3.AutoRoundBorders = False
        Me.BunifuButton3.AutoSizeLeftIcon = True
        Me.BunifuButton3.AutoSizeRightIcon = True
        Me.BunifuButton3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton3.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton3.BackgroundImage = CType(resources.GetObject("BunifuButton3.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.ButtonText = "Puntilleria"
        Me.BunifuButton3.ButtonTextMarginLeft = 0
        Me.BunifuButton3.ColorContrastOnClick = 45
        Me.BunifuButton3.ColorContrastOnHover = 45
        Me.BunifuButton3.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges9.BottomLeft = False
        BorderEdges9.BottomRight = False
        BorderEdges9.TopLeft = False
        BorderEdges9.TopRight = False
        Me.BunifuButton3.CustomizableEdges = BorderEdges9
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton3.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton3.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton3.IconMarginLeft = 11
        Me.BunifuButton3.IconPadding = 10
        Me.BunifuButton3.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton3.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton3.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton3.IconSize = 25
        Me.BunifuButton3.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.IdleBorderRadius = 10
        Me.BunifuButton3.IdleBorderThickness = 2
        Me.BunifuButton3.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton3.IdleIconLeftImage = Nothing
        Me.BunifuButton3.IdleIconRightImage = Nothing
        Me.BunifuButton3.IndicateFocus = False
        Me.BunifuButton3.Location = New System.Drawing.Point(153, 46)
        Me.BunifuButton3.Name = "BunifuButton3"
        Me.BunifuButton3.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.BorderRadius = 10
        Me.BunifuButton3.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnDisabledState.BorderThickness = 2
        Me.BunifuButton3.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton3.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton3.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton3.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton3.onHoverState.BorderRadius = 10
        Me.BunifuButton3.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.onHoverState.BorderThickness = 2
        Me.BunifuButton3.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton3.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton3.onHoverState.IconRightImage = Nothing
        Me.BunifuButton3.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.OnIdleState.BorderRadius = 10
        Me.BunifuButton3.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnIdleState.BorderThickness = 2
        Me.BunifuButton3.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton3.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton3.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton3.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton3.OnPressedState.BorderRadius = 10
        Me.BunifuButton3.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton3.OnPressedState.BorderThickness = 2
        Me.BunifuButton3.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton3.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton3.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton3.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton3.Size = New System.Drawing.Size(78, 30)
        Me.BunifuButton3.TabIndex = 2222251
        Me.BunifuButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton3.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton3.TextMarginLeft = 0
        Me.BunifuButton3.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton3.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton2
        '
        Me.BunifuButton2.AllowAnimations = True
        Me.BunifuButton2.AllowMouseEffects = True
        Me.BunifuButton2.AllowToggling = False
        Me.BunifuButton2.AnimationSpeed = 200
        Me.BunifuButton2.AutoGenerateColors = False
        Me.BunifuButton2.AutoRoundBorders = False
        Me.BunifuButton2.AutoSizeLeftIcon = True
        Me.BunifuButton2.AutoSizeRightIcon = True
        Me.BunifuButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton2.BackgroundImage = CType(resources.GetObject("BunifuButton2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.ButtonText = "Hornos Rec"
        Me.BunifuButton2.ButtonTextMarginLeft = 0
        Me.BunifuButton2.ColorContrastOnClick = 45
        Me.BunifuButton2.ColorContrastOnHover = 45
        Me.BunifuButton2.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges10.BottomLeft = False
        BorderEdges10.BottomRight = False
        BorderEdges10.TopLeft = False
        BorderEdges10.TopRight = False
        Me.BunifuButton2.CustomizableEdges = BorderEdges10
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton2.IconMarginLeft = 11
        Me.BunifuButton2.IconPadding = 10
        Me.BunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton2.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton2.IconSize = 25
        Me.BunifuButton2.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.IdleBorderRadius = 10
        Me.BunifuButton2.IdleBorderThickness = 2
        Me.BunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton2.IdleIconLeftImage = Nothing
        Me.BunifuButton2.IdleIconRightImage = Nothing
        Me.BunifuButton2.IndicateFocus = False
        Me.BunifuButton2.Location = New System.Drawing.Point(77, 46)
        Me.BunifuButton2.Name = "BunifuButton2"
        Me.BunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.BorderRadius = 10
        Me.BunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnDisabledState.BorderThickness = 2
        Me.BunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BunifuButton2.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton2.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton2.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.BorderRadius = 10
        Me.BunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.onHoverState.BorderThickness = 2
        Me.BunifuButton2.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton2.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton2.onHoverState.IconRightImage = Nothing
        Me.BunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.OnIdleState.BorderRadius = 10
        Me.BunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnIdleState.BorderThickness = 2
        Me.BunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton2.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.BorderRadius = 10
        Me.BunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton2.OnPressedState.BorderThickness = 2
        Me.BunifuButton2.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton2.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton2.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton2.Size = New System.Drawing.Size(78, 30)
        Me.BunifuButton2.TabIndex = 2222250
        Me.BunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton2.TextMarginLeft = 0
        Me.BunifuButton2.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton2.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton1
        '
        Me.BunifuButton1.AllowAnimations = True
        Me.BunifuButton1.AllowMouseEffects = True
        Me.BunifuButton1.AllowToggling = False
        Me.BunifuButton1.AnimationSpeed = 200
        Me.BunifuButton1.AutoGenerateColors = False
        Me.BunifuButton1.AutoRoundBorders = False
        Me.BunifuButton1.AutoSizeLeftIcon = True
        Me.BunifuButton1.AutoSizeRightIcon = True
        Me.BunifuButton1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton1.BackgroundImage = CType(resources.GetObject("BunifuButton1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.ButtonText = "Trefilación"
        Me.BunifuButton1.ButtonTextMarginLeft = 0
        Me.BunifuButton1.ColorContrastOnClick = 45
        Me.BunifuButton1.ColorContrastOnHover = 45
        Me.BunifuButton1.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges11.BottomLeft = True
        BorderEdges11.BottomRight = False
        BorderEdges11.TopLeft = True
        BorderEdges11.TopRight = False
        Me.BunifuButton1.CustomizableEdges = BorderEdges11
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton1.DisabledBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.DisabledFillColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.DisabledForecolor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton1.IconMarginLeft = 11
        Me.BunifuButton1.IconPadding = 10
        Me.BunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton1.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton1.IconSize = 25
        Me.BunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.IdleBorderRadius = 10
        Me.BunifuButton1.IdleBorderThickness = 2
        Me.BunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton1.IdleIconLeftImage = Nothing
        Me.BunifuButton1.IdleIconRightImage = Nothing
        Me.BunifuButton1.IndicateFocus = False
        Me.BunifuButton1.Location = New System.Drawing.Point(1, 46)
        Me.BunifuButton1.Name = "BunifuButton1"
        Me.BunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnDisabledState.BorderRadius = 10
        Me.BunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnDisabledState.BorderThickness = 2
        Me.BunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.Transparent
        Me.BunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton1.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton1.onHoverState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.BorderRadius = 10
        Me.BunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.onHoverState.BorderThickness = 2
        Me.BunifuButton1.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton1.onHoverState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton1.onHoverState.IconRightImage = Nothing
        Me.BunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.BorderRadius = 10
        Me.BunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnIdleState.BorderThickness = 2
        Me.BunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton1.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.BorderRadius = 10
        Me.BunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton1.OnPressedState.BorderThickness = 2
        Me.BunifuButton1.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BunifuButton1.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton1.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton1.Size = New System.Drawing.Size(78, 30)
        Me.BunifuButton1.TabIndex = 2222249
        Me.BunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton1.TextMarginLeft = 0
        Me.BunifuButton1.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton1.UseDefaultRadiusAndThickness = True
        '
        'CartesianChart1
        '
        Me.CartesianChart1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.CartesianChart1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.CartesianChart1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.CartesianChart1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.CartesianChart1.Location = New System.Drawing.Point(440, 82)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(532, 163)
        Me.CartesianChart1.TabIndex = 0
        Me.CartesianChart1.Text = "CartesianChart1"
        Me.CartesianChart1.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label42, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label42.Location = New System.Drawing.Point(3, 2)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(511, 25)
        Me.Label42.TabIndex = 61
        Me.Label42.Text = "Seguimiento de presupuesto de produción (KG)"
        '
        'dtd
        '
        Me.dtd.AllowUserToAddRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.dtd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dtd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dtd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtd.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.dtd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dtd.ColumnHeadersHeight = 30
        Me.BunifuTransition2.SetDecoration(Me.dtd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.dtd, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtd.DefaultCellStyle = DataGridViewCellStyle10
        Me.dtd.EnableHeadersVisualStyles = False
        Me.dtd.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtd.Location = New System.Drawing.Point(8, 80)
        Me.dtd.Margin = New System.Windows.Forms.Padding(1)
        Me.dtd.Name = "dtd"
        Me.dtd.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(46, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtd.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dtd.RowHeadersVisible = False
        Me.dtd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        Me.dtd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtd.Size = New System.Drawing.Size(910, 270)
        Me.dtd.TabIndex = 30
        Me.dtd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dtd.ThemeStyle.AlternatingRowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White
        Me.dtd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.dtd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White
        Me.dtd.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dtd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.dtd.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dtd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dtd.ThemeStyle.HeaderStyle.Height = 30
        Me.dtd.ThemeStyle.ReadOnly = True
        Me.dtd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dtd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dtd.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtd.ThemeStyle.RowsStyle.Height = 22
        Me.dtd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dtd.Visible = False
        '
        'tab_men_gastos
        '
        Me.tab_men_gastos.Controls.Add(Me.PanelGastos)
        Me.BunifuTransition2.SetDecoration(Me.tab_men_gastos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.tab_men_gastos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.tab_men_gastos.Location = New System.Drawing.Point(4, 24)
        Me.tab_men_gastos.Name = "tab_men_gastos"
        Me.tab_men_gastos.Size = New System.Drawing.Size(1226, 622)
        Me.tab_men_gastos.TabIndex = 4
        Me.tab_men_gastos.Text = "Gastos"
        Me.tab_men_gastos.UseVisualStyleBackColor = True
        '
        'PanelGastos
        '
        Me.PanelGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGastos.BackColor = System.Drawing.Color.White
        Me.PanelGastos.Controls.Add(Me.BunifuCards6)
        Me.PanelGastos.Controls.Add(Me.GunaLabel8)
        Me.PanelGastos.Controls.Add(Me.groupDetalle)
        Me.PanelGastos.Controls.Add(Me.BunifuPanel2)
        Me.PanelGastos.Controls.Add(Me.BunifuImageButton2)
        Me.PanelGastos.Controls.Add(Me.Label13)
        Me.PanelGastos.Controls.Add(Me.BunifuCircleProgress3)
        Me.PanelGastos.Controls.Add(Me.Label14)
        Me.PanelGastos.Controls.Add(Me.BunifuDropdown1)
        Me.PanelGastos.Controls.Add(Me.BunifuDropdown2)
        Me.PanelGastos.Controls.Add(Me.BunifuCards5)
        Me.PanelGastos.Controls.Add(Me.BunifuCards4)
        Me.PanelGastos.Controls.Add(Me.BunifuChartCanvas3)
        Me.PanelGastos.Controls.Add(Me.BunifuButton25)
        Me.PanelGastos.Controls.Add(Me.BunifuButton30)
        Me.PanelGastos.Controls.Add(Me.BunifuButton26)
        Me.PanelGastos.Controls.Add(Me.BunifuButton27)
        Me.PanelGastos.Controls.Add(Me.BunifuButton28)
        Me.PanelGastos.Controls.Add(Me.BunifuButton29)
        Me.PanelGastos.Controls.Add(Me.BunifuButton15)
        Me.PanelGastos.Controls.Add(Me.BunifuButton16)
        Me.PanelGastos.Controls.Add(Me.BunifuButton17)
        Me.PanelGastos.Controls.Add(Me.BunifuButton18)
        Me.PanelGastos.Controls.Add(Me.BunifuButton19)
        Me.PanelGastos.Controls.Add(Me.BunifuButton20)
        Me.PanelGastos.Controls.Add(Me.BunifuButton21)
        Me.PanelGastos.Controls.Add(Me.BunifuButton22)
        Me.PanelGastos.Controls.Add(Me.BunifuButton23)
        Me.PanelGastos.Controls.Add(Me.BunifuButton24)
        Me.PanelGastos.Controls.Add(Me.BunifuButton14)
        Me.PanelGastos.Controls.Add(Me.BunifuButton12)
        Me.PanelGastos.Controls.Add(Me.BunifuButton13)
        Me.PanelGastos.Controls.Add(Me.Label71)
        Me.BunifuTransition2.SetDecoration(Me.PanelGastos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.PanelGastos, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.PanelGastos.Location = New System.Drawing.Point(3, 3)
        Me.PanelGastos.Name = "PanelGastos"
        Me.PanelGastos.Size = New System.Drawing.Size(1227, 616)
        Me.PanelGastos.TabIndex = 2222245
        Me.PanelGastos.Visible = False
        '
        'BunifuCards6
        '
        Me.BunifuCards6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.BunifuCards6.BorderRadius = 5
        Me.BunifuCards6.BottomSahddow = False
        Me.BunifuCards6.color = System.Drawing.Color.Black
        Me.BunifuCards6.Controls.Add(Me.txtgasto)
        Me.BunifuCards6.Controls.Add(Me.GunaLabel14)
        Me.BunifuCards6.Controls.Add(Me.txtgastoprod)
        Me.BunifuCards6.Controls.Add(Me.GunaLabel16)
        Me.BunifuCards6.Controls.Add(Me.txtgastoadmin)
        Me.BunifuCards6.Controls.Add(Me.BunifuSeparator7)
        Me.BunifuCards6.Controls.Add(Me.GunaLabel18)
        Me.BunifuCards6.Controls.Add(Me.BunifuSeparator8)
        Me.BunifuCards6.Controls.Add(Me.BunifuSeparator9)
        Me.BunifuCards6.Controls.Add(Me.GunaLabel20)
        Me.BunifuCards6.Controls.Add(Me.BunifuPictureBox7)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards6.LeftSahddow = False
        Me.BunifuCards6.Location = New System.Drawing.Point(382, 32)
        Me.BunifuCards6.Name = "BunifuCards6"
        Me.BunifuCards6.RightSahddow = False
        Me.BunifuCards6.ShadowDepth = 20
        Me.BunifuCards6.Size = New System.Drawing.Size(236, 116)
        Me.BunifuCards6.TabIndex = 2222343
        '
        'txtgasto
        '
        Me.txtgasto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtgasto.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtgasto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtgasto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtgasto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtgasto.ForeColor = System.Drawing.Color.Black
        Me.txtgasto.Location = New System.Drawing.Point(104, 45)
        Me.txtgasto.Name = "txtgasto"
        Me.txtgasto.Size = New System.Drawing.Size(113, 15)
        Me.txtgasto.TabIndex = 3
        Me.txtgasto.Text = "$ 1.200.000.000.00"
        Me.txtgasto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel14
        '
        Me.GunaLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel14.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel14.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel14.Location = New System.Drawing.Point(3, 98)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel14.TabIndex = 2222338
        Me.GunaLabel14.Text = "Producción"
        '
        'txtgastoprod
        '
        Me.txtgastoprod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtgastoprod.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtgastoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtgastoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtgastoprod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgastoprod.ForeColor = System.Drawing.Color.Black
        Me.txtgastoprod.Location = New System.Drawing.Point(104, 98)
        Me.txtgastoprod.Name = "txtgastoprod"
        Me.txtgastoprod.Size = New System.Drawing.Size(113, 15)
        Me.txtgastoprod.TabIndex = 2222337
        Me.txtgastoprod.Text = "$ 1.200.000.000.00"
        Me.txtgastoprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel16
        '
        Me.GunaLabel16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel16.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel16.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel16.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel16.Location = New System.Drawing.Point(3, 73)
        Me.GunaLabel16.Name = "GunaLabel16"
        Me.GunaLabel16.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel16.TabIndex = 2222336
        Me.GunaLabel16.Text = "Administración"
        '
        'txtgastoadmin
        '
        Me.txtgastoadmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtgastoadmin.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtgastoadmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtgastoadmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtgastoadmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgastoadmin.ForeColor = System.Drawing.Color.Black
        Me.txtgastoadmin.Location = New System.Drawing.Point(104, 73)
        Me.txtgastoadmin.Name = "txtgastoadmin"
        Me.txtgastoadmin.Size = New System.Drawing.Size(113, 15)
        Me.txtgastoadmin.TabIndex = 2222335
        Me.txtgastoadmin.Text = "$ 1.200.000.000.00"
        Me.txtgastoadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuSeparator7
        '
        Me.BunifuSeparator7.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator7.BackgroundImage = CType(resources.GetObject("BunifuSeparator7.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator7.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator7.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator7.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator7.LineThickness = 1
        Me.BunifuSeparator7.Location = New System.Drawing.Point(7, 83)
        Me.BunifuSeparator7.Name = "BunifuSeparator7"
        Me.BunifuSeparator7.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator7.Size = New System.Drawing.Size(214, 18)
        Me.BunifuSeparator7.TabIndex = 2222341
        '
        'GunaLabel18
        '
        Me.GunaLabel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel18.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel18.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel18.Location = New System.Drawing.Point(6, 45)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel18.TabIndex = 4
        Me.GunaLabel18.Text = "Generál"
        '
        'BunifuSeparator8
        '
        Me.BunifuSeparator8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator8.BackgroundImage = CType(resources.GetObject("BunifuSeparator8.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator8.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator8.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator8.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator8.LineThickness = 1
        Me.BunifuSeparator8.Location = New System.Drawing.Point(7, 56)
        Me.BunifuSeparator8.Name = "BunifuSeparator8"
        Me.BunifuSeparator8.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator8.Size = New System.Drawing.Size(214, 16)
        Me.BunifuSeparator8.TabIndex = 2222340
        '
        'BunifuSeparator9
        '
        Me.BunifuSeparator9.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator9.BackgroundImage = CType(resources.GetObject("BunifuSeparator9.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator9.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator9.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator9.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator9.LineThickness = 1
        Me.BunifuSeparator9.Location = New System.Drawing.Point(9, 33)
        Me.BunifuSeparator9.Name = "BunifuSeparator9"
        Me.BunifuSeparator9.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator9.Size = New System.Drawing.Size(212, 14)
        Me.BunifuSeparator9.TabIndex = 2222339
        '
        'GunaLabel20
        '
        Me.GunaLabel20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel20.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel20.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel20.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel20.Location = New System.Drawing.Point(104, 14)
        Me.GunaLabel20.Name = "GunaLabel20"
        Me.GunaLabel20.Size = New System.Drawing.Size(37, 15)
        Me.GunaLabel20.TabIndex = 2222334
        Me.GunaLabel20.Text = "Saldo"
        '
        'BunifuPictureBox7
        '
        Me.BunifuPictureBox7.AllowFocused = False
        Me.BunifuPictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox7.AutoSizeHeight = True
        Me.BunifuPictureBox7.BorderRadius = 15
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox7.Image = CType(resources.GetObject("BunifuPictureBox7.Image"), System.Drawing.Image)
        Me.BunifuPictureBox7.IsCircle = True
        Me.BunifuPictureBox7.Location = New System.Drawing.Point(18, 5)
        Me.BunifuPictureBox7.Name = "BunifuPictureBox7"
        Me.BunifuPictureBox7.Size = New System.Drawing.Size(30, 30)
        Me.BunifuPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox7.TabIndex = 3
        Me.BunifuPictureBox7.TabStop = False
        Me.BunifuPictureBox7.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel8, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel8.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel8.Location = New System.Drawing.Point(6, 6)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(183, 14)
        Me.GunaLabel8.TabIndex = 2222333
        Me.GunaLabel8.Text = "Dashboard Presupuesto general"
        '
        'groupDetalle
        '
        Me.groupDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupDetalle.Controls.Add(Me.btn_cerrar)
        Me.groupDetalle.Controls.Add(Me.dtg_detalle)
        Me.BunifuTransition2.SetDecoration(Me.groupDetalle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.groupDetalle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.groupDetalle.ForeColor = System.Drawing.Color.Black
        Me.groupDetalle.Location = New System.Drawing.Point(697, 291)
        Me.groupDetalle.Name = "groupDetalle"
        Me.groupDetalle.Size = New System.Drawing.Size(427, 314)
        Me.groupDetalle.TabIndex = 2222290
        Me.groupDetalle.TabStop = False
        Me.groupDetalle.Text = "Detalle por centro de costos"
        Me.groupDetalle.Visible = False
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuTransition1.SetDecoration(Me.btn_cerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn_cerrar, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.ForeColor = System.Drawing.Color.Red
        Me.btn_cerrar.Location = New System.Drawing.Point(390, 0)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(37, 23)
        Me.btn_cerrar.TabIndex = 1063
        Me.btn_cerrar.Text = "X"
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'dtg_detalle
        '
        Me.dtg_detalle.AllowUserToAddRows = False
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.dtg_detalle.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dtg_detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_detalle.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_detalle.ContextMenuStrip = Me.ContextMenuStrip1
        Me.BunifuTransition2.SetDecoration(Me.dtg_detalle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.dtg_detalle, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.dtg_detalle.Location = New System.Drawing.Point(9, 29)
        Me.dtg_detalle.Name = "dtg_detalle"
        Me.dtg_detalle.RowHeadersVisible = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        Me.dtg_detalle.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dtg_detalle.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dtg_detalle.Size = New System.Drawing.Size(417, 294)
        Me.dtg_detalle.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.BunifuTransition2.SetDecoration(Me.ContextMenuStrip1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.ContextMenuStrip1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(222, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Spic.My.Resources.Resources.buscar7
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(221, 22)
        Me.ToolStripMenuItem1.Text = "Detalle por centro de costos"
        '
        'BunifuPanel2
        '
        Me.BunifuPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuPanel2.BackgroundImage = CType(resources.GetObject("BunifuPanel2.BackgroundImage"), System.Drawing.Image)
        Me.BunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuPanel2.BorderColor = System.Drawing.Color.Transparent
        Me.BunifuPanel2.BorderRadius = 20
        Me.BunifuPanel2.BorderThickness = 1
        Me.BunifuPanel2.Controls.Add(Me.dtg_consulta)
        Me.BunifuPanel2.Controls.Add(Me.TextBox1)
        Me.BunifuPanel2.Controls.Add(Me.GunaLabel1)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuPanel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPanel2.Location = New System.Drawing.Point(706, 160)
        Me.BunifuPanel2.Name = "BunifuPanel2"
        Me.BunifuPanel2.ShowBorders = True
        Me.BunifuPanel2.Size = New System.Drawing.Size(514, 445)
        Me.BunifuPanel2.TabIndex = 2222330
        '
        'dtg_consulta
        '
        Me.dtg_consulta.AllowUserToAddRows = False
        Me.dtg_consulta.AllowUserToDeleteRows = False
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = "0"
        Me.dtg_consulta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle14
        Me.dtg_consulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtg_consulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_consulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dtg_consulta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.dtg_consulta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtg_consulta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle15.NullValue = "0"
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_consulta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dtg_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_consulta.ContextMenuStrip = Me.menStripDtg
        Me.BunifuTransition2.SetDecoration(Me.dtg_consulta, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.dtg_consulta, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.Format = "N0"
        DataGridViewCellStyle16.NullValue = "0"
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtg_consulta.DefaultCellStyle = DataGridViewCellStyle16
        Me.dtg_consulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dtg_consulta.EnableHeadersVisualStyles = False
        Me.dtg_consulta.GridColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.dtg_consulta.Location = New System.Drawing.Point(3, 53)
        Me.dtg_consulta.Name = "dtg_consulta"
        Me.dtg_consulta.ReadOnly = True
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtg_consulta.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dtg_consulta.RowHeadersVisible = False
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(27, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.Format = "N0"
        DataGridViewCellStyle18.NullValue = "0"
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dtg_consulta.RowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dtg_consulta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtg_consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_consulta.Size = New System.Drawing.Size(505, 389)
        Me.dtg_consulta.TabIndex = 2222253
        '
        'menStripDtg
        '
        Me.BunifuTransition2.SetDecoration(Me.menStripDtg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.menStripDtg, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.menStripDtg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.menStripDtg.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itemDetalle})
        Me.menStripDtg.Name = "ContextMenuStrip1"
        Me.menStripDtg.Size = New System.Drawing.Size(222, 26)
        '
        'itemDetalle
        '
        Me.itemDetalle.Image = Global.Spic.My.Resources.Resources.buscar7
        Me.itemDetalle.Name = "itemDetalle"
        Me.itemDetalle.Size = New System.Drawing.Size(221, 22)
        Me.itemDetalle.Text = "Detalle por centro de costos"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TextBox1.BorderRadius = 10
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuTransition2.SetDecoration(Me.TextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.TextBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.TextBox1.DefaultText = ""
        Me.TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(137, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.PlaceholderText = ""
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.Size = New System.Drawing.Size(359, 26)
        Me.TextBox1.TabIndex = 2222254
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.GunaLabel1.Location = New System.Drawing.Point(22, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(103, 15)
        Me.GunaLabel1.TabIndex = 6
        Me.GunaLabel1.Text = "Filtrar por cuenta"
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.ActiveImage = Nothing
        Me.BunifuImageButton2.AllowAnimations = True
        Me.BunifuImageButton2.AllowBuffering = False
        Me.BunifuImageButton2.AllowToggling = False
        Me.BunifuImageButton2.AllowZooming = True
        Me.BunifuImageButton2.AllowZoomingOnFocus = False
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.BunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuImageButton2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuImageButton2.ErrorImage = CType(resources.GetObject("BunifuImageButton2.ErrorImage"), System.Drawing.Image)
        Me.BunifuImageButton2.FadeWhenInactive = False
        Me.BunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.ImageLocation = Nothing
        Me.BunifuImageButton2.ImageMargin = 20
        Me.BunifuImageButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.BunifuImageButton2.ImageZoomSize = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton2.InitialImage = CType(resources.GetObject("BunifuImageButton2.InitialImage"), System.Drawing.Image)
        Me.BunifuImageButton2.Location = New System.Drawing.Point(1142, 0)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Rotation = 0
        Me.BunifuImageButton2.ShowActiveImage = True
        Me.BunifuImageButton2.ShowCursorChanges = True
        Me.BunifuImageButton2.ShowImageBorders = True
        Me.BunifuImageButton2.ShowSizeMarkers = False
        Me.BunifuImageButton2.Size = New System.Drawing.Size(40, 40)
        Me.BunifuImageButton2.TabIndex = 2222327
        Me.BunifuImageButton2.ToolTipText = ""
        Me.BunifuImageButton2.WaitOnLoad = False
        Me.BunifuImageButton2.Zoom = 20
        Me.BunifuImageButton2.ZoomSpeed = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(973, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 2222326
        Me.Label13.Text = "Mes"
        '
        'BunifuCircleProgress3
        '
        Me.BunifuCircleProgress3.Animated = False
        Me.BunifuCircleProgress3.AnimationInterval = 1
        Me.BunifuCircleProgress3.AnimationSpeed = 1
        Me.BunifuCircleProgress3.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress3.CircleMargin = 10
        Me.BunifuTransition2.SetDecoration(Me.BunifuCircleProgress3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCircleProgress3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCircleProgress3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress3.IsPercentage = False
        Me.BunifuCircleProgress3.LineProgressThickness = 10
        Me.BunifuCircleProgress3.LineThickness = 10
        Me.BunifuCircleProgress3.Location = New System.Drawing.Point(641, 32)
        Me.BunifuCircleProgress3.Maximum = 130
        Me.BunifuCircleProgress3.Name = "BunifuCircleProgress3"
        Me.BunifuCircleProgress3.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress3.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress3.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress3.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress3.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Triangle
        Me.BunifuCircleProgress3.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.BunifuCircleProgress3.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Triangle
        Me.BunifuCircleProgress3.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress3.Size = New System.Drawing.Size(106, 106)
        Me.BunifuCircleProgress3.SubScriptColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress3.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress3.SubScriptText = ".00"
        Me.BunifuCircleProgress3.SuperScriptColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress3.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress3.SuperScriptText = "%"
        Me.BunifuCircleProgress3.TabIndex = 16
        Me.BunifuCircleProgress3.Text = "30"
        Me.BunifuCircleProgress3.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress3.Value = 30
        Me.BunifuCircleProgress3.ValueByTransition = 30
        Me.BunifuCircleProgress3.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition1.SetDecoration(Me.Label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(809, 11)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 20)
        Me.Label14.TabIndex = 2222323
        Me.Label14.Text = "Año"
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BackgroundColor = System.Drawing.Color.White
        Me.BunifuDropdown1.BorderColor = System.Drawing.Color.Silver
        Me.BunifuDropdown1.BorderRadius = 8
        Me.BunifuDropdown1.Color = System.Drawing.Color.Silver
        Me.BunifuTransition1.SetDecoration(Me.BunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuDropdown1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.BunifuDropdown1.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuDropdown1.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuDropdown1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BunifuDropdown1.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.BunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.BunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown1.FillDropDown = True
        Me.BunifuDropdown1.FillIndicator = False
        Me.BunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuDropdown1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.FormattingEnabled = True
        Me.BunifuDropdown1.Icon = Nothing
        Me.BunifuDropdown1.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown1.IndicatorColor = System.Drawing.Color.Gray
        Me.BunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown1.ItemBackColor = System.Drawing.Color.White
        Me.BunifuDropdown1.ItemBorderColor = System.Drawing.Color.White
        Me.BunifuDropdown1.ItemForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.ItemHeight = 19
        Me.BunifuDropdown1.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDropdown1.ItemHighLightForeColor = System.Drawing.Color.White
        Me.BunifuDropdown1.Items.AddRange(New Object() {"Seleccione", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.BunifuDropdown1.ItemTopMargin = 3
        Me.BunifuDropdown1.Location = New System.Drawing.Point(1008, 8)
        Me.BunifuDropdown1.MaxDropDownItems = 12
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.Size = New System.Drawing.Size(114, 25)
        Me.BunifuDropdown1.TabIndex = 2222325
        Me.BunifuDropdown1.Text = Nothing
        Me.BunifuDropdown1.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown1.TextLeftMargin = 5
        '
        'BunifuDropdown2
        '
        Me.BunifuDropdown2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown2.BackgroundColor = System.Drawing.Color.White
        Me.BunifuDropdown2.BorderColor = System.Drawing.Color.Silver
        Me.BunifuDropdown2.BorderRadius = 8
        Me.BunifuDropdown2.Color = System.Drawing.Color.Silver
        Me.BunifuDropdown2.DataSource = Me.FVanosprodBindingSource
        Me.BunifuTransition1.SetDecoration(Me.BunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuDropdown2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuDropdown2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down
        Me.BunifuDropdown2.DisabledBackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuDropdown2.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuDropdown2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.BunifuDropdown2.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BunifuDropdown2.DisabledIndicatorColor = System.Drawing.Color.DarkGray
        Me.BunifuDropdown2.DisplayMember = "ano"
        Me.BunifuDropdown2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.BunifuDropdown2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin
        Me.BunifuDropdown2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BunifuDropdown2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown2.FillDropDown = True
        Me.BunifuDropdown2.FillIndicator = False
        Me.BunifuDropdown2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BunifuDropdown2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuDropdown2.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown2.FormattingEnabled = True
        Me.BunifuDropdown2.Icon = Nothing
        Me.BunifuDropdown2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown2.IndicatorColor = System.Drawing.Color.Gray
        Me.BunifuDropdown2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right
        Me.BunifuDropdown2.ItemBackColor = System.Drawing.Color.White
        Me.BunifuDropdown2.ItemBorderColor = System.Drawing.Color.White
        Me.BunifuDropdown2.ItemForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown2.ItemHeight = 19
        Me.BunifuDropdown2.ItemHighLightColor = System.Drawing.Color.DodgerBlue
        Me.BunifuDropdown2.ItemHighLightForeColor = System.Drawing.Color.White
        Me.BunifuDropdown2.ItemTopMargin = 3
        Me.BunifuDropdown2.Location = New System.Drawing.Point(843, 8)
        Me.BunifuDropdown2.Name = "BunifuDropdown2"
        Me.BunifuDropdown2.Size = New System.Drawing.Size(108, 25)
        Me.BunifuDropdown2.TabIndex = 2222324
        Me.BunifuDropdown2.Text = Nothing
        Me.BunifuDropdown2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left
        Me.BunifuDropdown2.TextLeftMargin = 5
        Me.BunifuDropdown2.ValueMember = "ano"
        '
        'BunifuCards5
        '
        Me.BunifuCards5.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.BunifuCards5.BorderRadius = 5
        Me.BunifuCards5.BottomSahddow = False
        Me.BunifuCards5.color = System.Drawing.Color.Black
        Me.BunifuCards5.Controls.Add(Me.txtporcentajeinherente)
        Me.BunifuCards5.Controls.Add(Me.GunaLabel21)
        Me.BunifuCards5.Controls.Add(Me.BunifuRadialGauge1)
        Me.BunifuCards5.Controls.Add(Me.txttotcentro)
        Me.BunifuCards5.Controls.Add(Me.GunaLabel3)
        Me.BunifuCards5.Controls.Add(Me.BunifuPictureBox6)
        Me.BunifuCards5.Controls.Add(Me.BunifuPictureBox5)
        Me.BunifuCards5.Controls.Add(Me.BunifuSeparator11)
        Me.BunifuCards5.Controls.Add(Me.BunifuPictureBox4)
        Me.BunifuCards5.Controls.Add(Me.BunifuSeparator10)
        Me.BunifuCards5.Controls.Add(Me.txtgastocentro)
        Me.BunifuCards5.Controls.Add(Me.GunaLabel4)
        Me.BunifuCards5.Controls.Add(Me.GunaLabel7)
        Me.BunifuCards5.Controls.Add(Me.txtpptocentro)
        Me.BunifuCards5.Controls.Add(Me.labelcentroppto)
        Me.BunifuCards5.Controls.Add(Me.BunifuCircleProgress4)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards5.LeftSahddow = False
        Me.BunifuCards5.Location = New System.Drawing.Point(111, 160)
        Me.BunifuCards5.Name = "BunifuCards5"
        Me.BunifuCards5.RightSahddow = False
        Me.BunifuCards5.ShadowDepth = 50
        Me.BunifuCards5.Size = New System.Drawing.Size(513, 157)
        Me.BunifuCards5.TabIndex = 2222320
        '
        'txtporcentajeinherente
        '
        Me.txtporcentajeinherente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtporcentajeinherente.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtporcentajeinherente, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtporcentajeinherente, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtporcentajeinherente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentajeinherente.ForeColor = System.Drawing.Color.Black
        Me.txtporcentajeinherente.Location = New System.Drawing.Point(379, 121)
        Me.txtporcentajeinherente.Name = "txtporcentajeinherente"
        Me.txtporcentajeinherente.Size = New System.Drawing.Size(113, 15)
        Me.txtporcentajeinherente.TabIndex = 2222349
        Me.txtporcentajeinherente.Text = "$ 1.200.000.000.00"
        Me.txtporcentajeinherente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel21
        '
        Me.GunaLabel21.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel21.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel21.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel21.Location = New System.Drawing.Point(400, 29)
        Me.GunaLabel21.Name = "GunaLabel21"
        Me.GunaLabel21.Size = New System.Drawing.Size(70, 15)
        Me.GunaLabel21.TabIndex = 2222348
        Me.GunaLabel21.Text = "% Inherente"
        '
        'BunifuRadialGauge1
        '
        Me.BunifuRadialGauge1.AutoGenerateProgressColorWhenHigh = True
        Me.BunifuRadialGauge1.AutoGenerateProgressColorWhenLow = False
        Me.BunifuRadialGauge1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.BunifuRadialGauge1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuRadialGauge1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuRadialGauge1.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.BunifuRadialGauge1.LighteningFactor = 70
        Me.BunifuRadialGauge1.Location = New System.Drawing.Point(378, 32)
        Me.BunifuRadialGauge1.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.BunifuRadialGauge1.Maximum = 50
        Me.BunifuRadialGauge1.Minimum = 0
        Me.BunifuRadialGauge1.Name = "BunifuRadialGauge1"
        Me.BunifuRadialGauge1.Prefix = ""
        Me.BunifuRadialGauge1.ProgressBackColor = System.Drawing.Color.LightBlue
        Me.BunifuRadialGauge1.ProgressBgColor = System.Drawing.Color.LightBlue
        Me.BunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat
        Me.BunifuRadialGauge1.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuRadialGauge1.ProgressColor1 = System.Drawing.Color.DodgerBlue
        Me.BunifuRadialGauge1.ProgressColor2 = System.Drawing.Color.Crimson
        Me.BunifuRadialGauge1.ProgressColorHigh = System.Drawing.Color.Crimson
        Me.BunifuRadialGauge1.ProgressColorLow = System.Drawing.Color.DodgerBlue
        Me.BunifuRadialGauge1.ProgressHighValueMark = 70
        Me.BunifuRadialGauge1.RangeEnd = 50
        Me.BunifuRadialGauge1.RangeLabelsColor = System.Drawing.Color.Black
        Me.BunifuRadialGauge1.RangeLabelsFont = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BunifuRadialGauge1.RangeStart = 0
        Me.BunifuRadialGauge1.ShowRangeLabels = True
        Me.BunifuRadialGauge1.ShowValueLabel = True
        Me.BunifuRadialGauge1.Size = New System.Drawing.Size(120, 90)
        Me.BunifuRadialGauge1.Suffix = "%"
        Me.BunifuRadialGauge1.TabIndex = 2222347
        Me.BunifuRadialGauge1.Thickness = 15
        Me.BunifuRadialGauge1.Value = 40
        Me.BunifuRadialGauge1.ValueByTransition = 40
        Me.BunifuRadialGauge1.ValueLabelColor = System.Drawing.Color.Black
        Me.BunifuRadialGauge1.WarningMark = 70
        '
        'txttotcentro
        '
        Me.txttotcentro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txttotcentro.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txttotcentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txttotcentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txttotcentro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotcentro.ForeColor = System.Drawing.Color.Black
        Me.txttotcentro.Location = New System.Drawing.Point(138, 130)
        Me.txttotcentro.Name = "txttotcentro"
        Me.txttotcentro.Size = New System.Drawing.Size(113, 15)
        Me.txttotcentro.TabIndex = 2222346
        Me.txttotcentro.Text = "$ 1.200.000.000.00"
        Me.txttotcentro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel3.Location = New System.Drawing.Point(56, 130)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(70, 15)
        Me.GunaLabel3.TabIndex = 2222345
        Me.GunaLabel3.Text = "% Inherente"
        '
        'BunifuPictureBox6
        '
        Me.BunifuPictureBox6.AllowFocused = False
        Me.BunifuPictureBox6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox6.AutoSizeHeight = True
        Me.BunifuPictureBox6.BorderRadius = 15
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox6.Image = CType(resources.GetObject("BunifuPictureBox6.Image"), System.Drawing.Image)
        Me.BunifuPictureBox6.IsCircle = True
        Me.BunifuPictureBox6.Location = New System.Drawing.Point(12, 121)
        Me.BunifuPictureBox6.Name = "BunifuPictureBox6"
        Me.BunifuPictureBox6.Size = New System.Drawing.Size(30, 30)
        Me.BunifuPictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox6.TabIndex = 2222344
        Me.BunifuPictureBox6.TabStop = False
        Me.BunifuPictureBox6.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuPictureBox5
        '
        Me.BunifuPictureBox5.AllowFocused = False
        Me.BunifuPictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox5.AutoSizeHeight = True
        Me.BunifuPictureBox5.BorderRadius = 15
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox5.Image = CType(resources.GetObject("BunifuPictureBox5.Image"), System.Drawing.Image)
        Me.BunifuPictureBox5.IsCircle = True
        Me.BunifuPictureBox5.Location = New System.Drawing.Point(12, 77)
        Me.BunifuPictureBox5.Name = "BunifuPictureBox5"
        Me.BunifuPictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.BunifuPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox5.TabIndex = 2222342
        Me.BunifuPictureBox5.TabStop = False
        Me.BunifuPictureBox5.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuSeparator11
        '
        Me.BunifuSeparator11.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator11.BackgroundImage = CType(resources.GetObject("BunifuSeparator11.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator11.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator11, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator11.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator11.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator11.LineThickness = 1
        Me.BunifuSeparator11.Location = New System.Drawing.Point(3, 104)
        Me.BunifuSeparator11.Name = "BunifuSeparator11"
        Me.BunifuSeparator11.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator11.Size = New System.Drawing.Size(247, 18)
        Me.BunifuSeparator11.TabIndex = 2222343
        '
        'BunifuPictureBox4
        '
        Me.BunifuPictureBox4.AllowFocused = False
        Me.BunifuPictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox4.AutoSizeHeight = True
        Me.BunifuPictureBox4.BorderRadius = 15
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox4.Image = CType(resources.GetObject("BunifuPictureBox4.Image"), System.Drawing.Image)
        Me.BunifuPictureBox4.IsCircle = True
        Me.BunifuPictureBox4.Location = New System.Drawing.Point(12, 41)
        Me.BunifuPictureBox4.Name = "BunifuPictureBox4"
        Me.BunifuPictureBox4.Size = New System.Drawing.Size(30, 30)
        Me.BunifuPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox4.TabIndex = 2222341
        Me.BunifuPictureBox4.TabStop = False
        Me.BunifuPictureBox4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuSeparator10
        '
        Me.BunifuSeparator10.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator10.BackgroundImage = CType(resources.GetObject("BunifuSeparator10.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator10.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator10.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator10.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator10.LineThickness = 1
        Me.BunifuSeparator10.Location = New System.Drawing.Point(3, 65)
        Me.BunifuSeparator10.Name = "BunifuSeparator10"
        Me.BunifuSeparator10.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator10.Size = New System.Drawing.Size(247, 16)
        Me.BunifuSeparator10.TabIndex = 2222340
        '
        'txtgastocentro
        '
        Me.txtgastocentro.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtgastocentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtgastocentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtgastocentro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtgastocentro.ForeColor = System.Drawing.Color.Black
        Me.txtgastocentro.Location = New System.Drawing.Point(136, 84)
        Me.txtgastocentro.Name = "txtgastocentro"
        Me.txtgastocentro.Size = New System.Drawing.Size(113, 15)
        Me.txtgastocentro.TabIndex = 3
        Me.txtgastocentro.Text = "$ 1.200.000.000.00"
        Me.txtgastocentro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel4.Location = New System.Drawing.Point(56, 84)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(36, 15)
        Me.GunaLabel4.TabIndex = 1
        Me.GunaLabel4.Text = "Saldo"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel7.Location = New System.Drawing.Point(56, 49)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(72, 15)
        Me.GunaLabel7.TabIndex = 0
        Me.GunaLabel7.Text = "Presupuesto"
        '
        'txtpptocentro
        '
        Me.txtpptocentro.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtpptocentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtpptocentro, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtpptocentro.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtpptocentro.ForeColor = System.Drawing.Color.Black
        Me.txtpptocentro.Location = New System.Drawing.Point(138, 49)
        Me.txtpptocentro.Name = "txtpptocentro"
        Me.txtpptocentro.Size = New System.Drawing.Size(113, 15)
        Me.txtpptocentro.TabIndex = 2
        Me.txtpptocentro.Text = "$ 1.200.000.000.00"
        Me.txtpptocentro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labelcentroppto
        '
        Me.labelcentroppto.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.labelcentroppto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.labelcentroppto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.labelcentroppto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelcentroppto.ForeColor = System.Drawing.Color.DodgerBlue
        Me.labelcentroppto.Location = New System.Drawing.Point(8, 15)
        Me.labelcentroppto.Name = "labelcentroppto"
        Me.labelcentroppto.Size = New System.Drawing.Size(45, 15)
        Me.labelcentroppto.TabIndex = 2222314
        Me.labelcentroppto.Text = "Centro"
        '
        'BunifuCircleProgress4
        '
        Me.BunifuCircleProgress4.Animated = False
        Me.BunifuCircleProgress4.AnimationInterval = 1
        Me.BunifuCircleProgress4.AnimationSpeed = 1
        Me.BunifuCircleProgress4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgress4.CircleMargin = 10
        Me.BunifuTransition2.SetDecoration(Me.BunifuCircleProgress4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCircleProgress4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCircleProgress4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress4.IsPercentage = False
        Me.BunifuCircleProgress4.LineProgressThickness = 10
        Me.BunifuCircleProgress4.LineThickness = 10
        Me.BunifuCircleProgress4.Location = New System.Drawing.Point(263, 32)
        Me.BunifuCircleProgress4.Maximum = 130
        Me.BunifuCircleProgress4.Name = "BunifuCircleProgress4"
        Me.BunifuCircleProgress4.ProgressAnimationSpeed = 200
        Me.BunifuCircleProgress4.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgress4.ProgressColor = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress4.ProgressColor2 = System.Drawing.Color.DodgerBlue
        Me.BunifuCircleProgress4.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Triangle
        Me.BunifuCircleProgress4.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid
        Me.BunifuCircleProgress4.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Triangle
        Me.BunifuCircleProgress4.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgress4.Size = New System.Drawing.Size(105, 105)
        Me.BunifuCircleProgress4.SubScriptColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress4.SubScriptMargin = New System.Windows.Forms.Padding(5, -20, 0, 0)
        Me.BunifuCircleProgress4.SubScriptText = ".00"
        Me.BunifuCircleProgress4.SuperScriptColor = System.Drawing.Color.DeepSkyBlue
        Me.BunifuCircleProgress4.SuperScriptMargin = New System.Windows.Forms.Padding(5, 20, 0, 0)
        Me.BunifuCircleProgress4.SuperScriptText = "%"
        Me.BunifuCircleProgress4.TabIndex = 16
        Me.BunifuCircleProgress4.Text = "30"
        Me.BunifuCircleProgress4.TextMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.BunifuCircleProgress4.Value = 30
        Me.BunifuCircleProgress4.ValueByTransition = 30
        Me.BunifuCircleProgress4.ValueMargin = New System.Windows.Forms.Padding(0, 5, 0, 0)
        '
        'BunifuCards4
        '
        Me.BunifuCards4.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.BunifuCards4.BorderRadius = 5
        Me.BunifuCards4.BottomSahddow = False
        Me.BunifuCards4.color = System.Drawing.Color.Black
        Me.BunifuCards4.Controls.Add(Me.GunaLabel12)
        Me.BunifuCards4.Controls.Add(Me.txtpresupuestoprod)
        Me.BunifuCards4.Controls.Add(Me.GunaLabel10)
        Me.BunifuCards4.Controls.Add(Me.txtpresupuestoadmin)
        Me.BunifuCards4.Controls.Add(Me.BunifuSeparator6)
        Me.BunifuCards4.Controls.Add(Me.GunaLabel2)
        Me.BunifuCards4.Controls.Add(Me.txtpresupuesto)
        Me.BunifuCards4.Controls.Add(Me.BunifuSeparator5)
        Me.BunifuCards4.Controls.Add(Me.BunifuSeparator4)
        Me.BunifuCards4.Controls.Add(Me.GunaLabel9)
        Me.BunifuCards4.Controls.Add(Me.BunifuPictureBox3)
        Me.BunifuTransition2.SetDecoration(Me.BunifuCards4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuCards4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuCards4.LeftSahddow = False
        Me.BunifuCards4.Location = New System.Drawing.Point(105, 32)
        Me.BunifuCards4.Name = "BunifuCards4"
        Me.BunifuCards4.RightSahddow = False
        Me.BunifuCards4.ShadowDepth = 20
        Me.BunifuCards4.Size = New System.Drawing.Size(236, 116)
        Me.BunifuCards4.TabIndex = 2222317
        '
        'GunaLabel12
        '
        Me.GunaLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel12.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel12.Location = New System.Drawing.Point(3, 98)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(68, 15)
        Me.GunaLabel12.TabIndex = 2222338
        Me.GunaLabel12.Text = "Producción"
        '
        'txtpresupuestoprod
        '
        Me.txtpresupuestoprod.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpresupuestoprod.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtpresupuestoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtpresupuestoprod, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtpresupuestoprod.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresupuestoprod.ForeColor = System.Drawing.Color.Black
        Me.txtpresupuestoprod.Location = New System.Drawing.Point(104, 98)
        Me.txtpresupuestoprod.Name = "txtpresupuestoprod"
        Me.txtpresupuestoprod.Size = New System.Drawing.Size(113, 15)
        Me.txtpresupuestoprod.TabIndex = 2222337
        Me.txtpresupuestoprod.Text = "$ 1.200.000.000.00"
        Me.txtpresupuestoprod.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel10.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel10, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel10.Location = New System.Drawing.Point(3, 73)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(88, 15)
        Me.GunaLabel10.TabIndex = 2222336
        Me.GunaLabel10.Text = "Administración"
        '
        'txtpresupuestoadmin
        '
        Me.txtpresupuestoadmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpresupuestoadmin.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtpresupuestoadmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtpresupuestoadmin, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtpresupuestoadmin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresupuestoadmin.ForeColor = System.Drawing.Color.Black
        Me.txtpresupuestoadmin.Location = New System.Drawing.Point(104, 73)
        Me.txtpresupuestoadmin.Name = "txtpresupuestoadmin"
        Me.txtpresupuestoadmin.Size = New System.Drawing.Size(113, 15)
        Me.txtpresupuestoadmin.TabIndex = 2222335
        Me.txtpresupuestoadmin.Text = "$ 1.200.000.000.00"
        Me.txtpresupuestoadmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuSeparator6
        '
        Me.BunifuSeparator6.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator6.BackgroundImage = CType(resources.GetObject("BunifuSeparator6.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator6.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator6.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator6.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator6.LineThickness = 1
        Me.BunifuSeparator6.Location = New System.Drawing.Point(7, 83)
        Me.BunifuSeparator6.Name = "BunifuSeparator6"
        Me.BunifuSeparator6.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator6.Size = New System.Drawing.Size(214, 18)
        Me.BunifuSeparator6.TabIndex = 2222341
        '
        'GunaLabel2
        '
        Me.GunaLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel2.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel2.Location = New System.Drawing.Point(6, 45)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(47, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Generál"
        '
        'txtpresupuesto
        '
        Me.txtpresupuesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtpresupuesto.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.txtpresupuesto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.txtpresupuesto, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtpresupuesto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpresupuesto.ForeColor = System.Drawing.Color.Black
        Me.txtpresupuesto.Location = New System.Drawing.Point(104, 45)
        Me.txtpresupuesto.Name = "txtpresupuesto"
        Me.txtpresupuesto.Size = New System.Drawing.Size(113, 15)
        Me.txtpresupuesto.TabIndex = 2
        Me.txtpresupuesto.Text = "$ 1.200.000.000.00"
        Me.txtpresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BunifuSeparator5
        '
        Me.BunifuSeparator5.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator5.BackgroundImage = CType(resources.GetObject("BunifuSeparator5.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator5.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator5.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator5.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator5.LineThickness = 1
        Me.BunifuSeparator5.Location = New System.Drawing.Point(7, 56)
        Me.BunifuSeparator5.Name = "BunifuSeparator5"
        Me.BunifuSeparator5.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator5.Size = New System.Drawing.Size(214, 16)
        Me.BunifuSeparator5.TabIndex = 2222340
        '
        'BunifuSeparator4
        '
        Me.BunifuSeparator4.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator4.BackgroundImage = CType(resources.GetObject("BunifuSeparator4.BackgroundImage"), System.Drawing.Image)
        Me.BunifuSeparator4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuSeparator4.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat
        Me.BunifuTransition2.SetDecoration(Me.BunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuSeparator4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuSeparator4.LineColor = System.Drawing.Color.Silver
        Me.BunifuSeparator4.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid
        Me.BunifuSeparator4.LineThickness = 1
        Me.BunifuSeparator4.Location = New System.Drawing.Point(9, 33)
        Me.BunifuSeparator4.Name = "BunifuSeparator4"
        Me.BunifuSeparator4.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal
        Me.BunifuSeparator4.Size = New System.Drawing.Size(212, 14)
        Me.BunifuSeparator4.TabIndex = 2222339
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel9.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.GunaLabel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.GunaLabel9, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel9.Location = New System.Drawing.Point(84, 14)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(76, 15)
        Me.GunaLabel9.TabIndex = 2222334
        Me.GunaLabel9.Text = "Presupuesto"
        '
        'BunifuPictureBox3
        '
        Me.BunifuPictureBox3.AllowFocused = False
        Me.BunifuPictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox3.AutoSizeHeight = True
        Me.BunifuPictureBox3.BorderRadius = 15
        Me.BunifuTransition1.SetDecoration(Me.BunifuPictureBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.BunifuPictureBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuPictureBox3.Image = CType(resources.GetObject("BunifuPictureBox3.Image"), System.Drawing.Image)
        Me.BunifuPictureBox3.IsCircle = True
        Me.BunifuPictureBox3.Location = New System.Drawing.Point(18, 5)
        Me.BunifuPictureBox3.Name = "BunifuPictureBox3"
        Me.BunifuPictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.BunifuPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuPictureBox3.TabIndex = 3
        Me.BunifuPictureBox3.TabStop = False
        Me.BunifuPictureBox3.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'BunifuChartCanvas3
        '
        Me.BunifuChartCanvas3.AnimationDuration = 1000
        Me.BunifuChartCanvas3.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart
        Me.BunifuChartCanvas3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuChartCanvas3.CanvasPadding = New System.Windows.Forms.Padding(0, 0, 80, 100)
        Me.BunifuTransition2.SetDecoration(Me.BunifuChartCanvas3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuChartCanvas3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuChartCanvas3.Labels = New String() {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Me.BunifuChartCanvas3.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center
        Me.BunifuChartCanvas3.LegendDisplay = True
        Me.BunifuChartCanvas3.LegendFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuChartCanvas3.LegendForeColor = System.Drawing.Color.DarkGray
        Me.BunifuChartCanvas3.LegendFullWidth = True
        Me.BunifuChartCanvas3.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom
        Me.BunifuChartCanvas3.LegendRevese = False
        Me.BunifuChartCanvas3.LegendRTL = False
        Me.BunifuChartCanvas3.Location = New System.Drawing.Point(105, 385)
        Me.BunifuChartCanvas3.Name = "BunifuChartCanvas3"
        Me.BunifuChartCanvas3.ShowXAxis = True
        Me.BunifuChartCanvas3.ShowYAxis = True
        Me.BunifuChartCanvas3.Size = New System.Drawing.Size(550, 193)
        Me.BunifuChartCanvas3.TabIndex = 2222316
        Me.BunifuChartCanvas3.Title = ""
        Me.BunifuChartCanvas3.TitleLineHeight = 1.2R
        Me.BunifuChartCanvas3.TitlePadding = 10
        Me.BunifuChartCanvas3.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top
        Me.BunifuChartCanvas3.TooltipBackgroundColor = System.Drawing.Color.Black
        Me.BunifuChartCanvas3.TooltipFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas3.TooltipForeColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuChartCanvas3.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest
        Me.BunifuChartCanvas3.TooltipsEnabled = True
        Me.BunifuChartCanvas3.XAxesBeginAtZero = True
        Me.BunifuChartCanvas3.XAxesDrawTicks = True
        Me.BunifuChartCanvas3.XAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas3.XAxesForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas3.XAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas3.XAxesGridLines = False
        Me.BunifuChartCanvas3.XAxesLabel = ""
        Me.BunifuChartCanvas3.XAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas3.XAxesLabelForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas3.XAxesLineWidth = 1
        Me.BunifuChartCanvas3.XAxesStacked = False
        Me.BunifuChartCanvas3.XAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas3.XAxesZeroLineWidth = 1
        Me.BunifuChartCanvas3.YAxesBeginAtZero = True
        Me.BunifuChartCanvas3.YAxesDrawTicks = True
        Me.BunifuChartCanvas3.YAxesFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas3.YAxesForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas3.YAxesGridColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas3.YAxesGridLines = False
        Me.BunifuChartCanvas3.YAxesLabel = ""
        Me.BunifuChartCanvas3.YAxesLabelFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BunifuChartCanvas3.YAxesLabelForeColor = System.Drawing.Color.White
        Me.BunifuChartCanvas3.YAxesLineWidth = 1
        Me.BunifuChartCanvas3.YAxesStacked = True
        Me.BunifuChartCanvas3.YAxesZeroLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuChartCanvas3.YAxesZeroLineWidth = 1
        '
        'BunifuButton25
        '
        Me.BunifuButton25.AllowAnimations = True
        Me.BunifuButton25.AllowMouseEffects = False
        Me.BunifuButton25.AllowToggling = False
        Me.BunifuButton25.AnimationSpeed = 200
        Me.BunifuButton25.AutoGenerateColors = False
        Me.BunifuButton25.AutoRoundBorders = False
        Me.BunifuButton25.AutoSizeLeftIcon = True
        Me.BunifuButton25.AutoSizeRightIcon = True
        Me.BunifuButton25.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton25.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton25.BackgroundImage = CType(resources.GetObject("BunifuButton25.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton25.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton25.ButtonText = "Calidad"
        Me.BunifuButton25.ButtonTextMarginLeft = 0
        Me.BunifuButton25.ColorContrastOnClick = 45
        Me.BunifuButton25.ColorContrastOnHover = 45
        Me.BunifuButton25.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges12.BottomLeft = False
        BorderEdges12.BottomRight = False
        BorderEdges12.TopLeft = False
        BorderEdges12.TopRight = False
        Me.BunifuButton25.CustomizableEdges = BorderEdges12
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton25, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton25.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton25.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton25.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton25.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton25.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton25.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton25.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton25.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton25.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton25.IconMarginLeft = 11
        Me.BunifuButton25.IconPadding = 10
        Me.BunifuButton25.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton25.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton25.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton25.IconSize = 25
        Me.BunifuButton25.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.IdleBorderRadius = 10
        Me.BunifuButton25.IdleBorderThickness = 2
        Me.BunifuButton25.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton25.IdleIconLeftImage = Nothing
        Me.BunifuButton25.IdleIconRightImage = Nothing
        Me.BunifuButton25.IndicateFocus = False
        Me.BunifuButton25.Location = New System.Drawing.Point(-1, 401)
        Me.BunifuButton25.Name = "BunifuButton25"
        Me.BunifuButton25.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnDisabledState.BorderRadius = 10
        Me.BunifuButton25.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton25.OnDisabledState.BorderThickness = 2
        Me.BunifuButton25.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton25.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton25.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton25.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.onHoverState.BorderRadius = 10
        Me.BunifuButton25.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton25.onHoverState.BorderThickness = 2
        Me.BunifuButton25.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton25.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton25.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton25.onHoverState.IconRightImage = Nothing
        Me.BunifuButton25.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnIdleState.BorderRadius = 10
        Me.BunifuButton25.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton25.OnIdleState.BorderThickness = 2
        Me.BunifuButton25.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton25.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton25.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton25.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnPressedState.BorderRadius = 10
        Me.BunifuButton25.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton25.OnPressedState.BorderThickness = 2
        Me.BunifuButton25.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton25.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton25.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton25.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton25.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton25.TabIndex = 2222309
        Me.BunifuButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton25.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton25.TextMarginLeft = 0
        Me.BunifuButton25.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton25.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton30
        '
        Me.BunifuButton30.AllowAnimations = True
        Me.BunifuButton30.AllowMouseEffects = False
        Me.BunifuButton30.AllowToggling = False
        Me.BunifuButton30.AnimationSpeed = 200
        Me.BunifuButton30.AutoGenerateColors = False
        Me.BunifuButton30.AutoRoundBorders = False
        Me.BunifuButton30.AutoSizeLeftIcon = True
        Me.BunifuButton30.AutoSizeRightIcon = True
        Me.BunifuButton30.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton30.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton30.BackgroundImage = CType(resources.GetObject("BunifuButton30.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton30.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton30.ButtonText = "Produccion"
        Me.BunifuButton30.ButtonTextMarginLeft = 0
        Me.BunifuButton30.ColorContrastOnClick = 45
        Me.BunifuButton30.ColorContrastOnHover = 45
        Me.BunifuButton30.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges13.BottomLeft = False
        BorderEdges13.BottomRight = False
        BorderEdges13.TopLeft = False
        BorderEdges13.TopRight = False
        Me.BunifuButton30.CustomizableEdges = BorderEdges13
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton30, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton30.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton30.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton30.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton30.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton30.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton30.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton30.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton30.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton30.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton30.IconMarginLeft = 11
        Me.BunifuButton30.IconPadding = 10
        Me.BunifuButton30.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton30.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton30.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton30.IconSize = 25
        Me.BunifuButton30.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.IdleBorderRadius = 10
        Me.BunifuButton30.IdleBorderThickness = 2
        Me.BunifuButton30.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton30.IdleIconLeftImage = Nothing
        Me.BunifuButton30.IdleIconRightImage = Nothing
        Me.BunifuButton30.IndicateFocus = False
        Me.BunifuButton30.Location = New System.Drawing.Point(-1, 373)
        Me.BunifuButton30.Name = "BunifuButton30"
        Me.BunifuButton30.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnDisabledState.BorderRadius = 10
        Me.BunifuButton30.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton30.OnDisabledState.BorderThickness = 2
        Me.BunifuButton30.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton30.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton30.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton30.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.onHoverState.BorderRadius = 10
        Me.BunifuButton30.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton30.onHoverState.BorderThickness = 2
        Me.BunifuButton30.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton30.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton30.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton30.onHoverState.IconRightImage = Nothing
        Me.BunifuButton30.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnIdleState.BorderRadius = 10
        Me.BunifuButton30.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton30.OnIdleState.BorderThickness = 2
        Me.BunifuButton30.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton30.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton30.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton30.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnPressedState.BorderRadius = 10
        Me.BunifuButton30.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton30.OnPressedState.BorderThickness = 2
        Me.BunifuButton30.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton30.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton30.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton30.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton30.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton30.TabIndex = 2222308
        Me.BunifuButton30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton30.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton30.TextMarginLeft = 0
        Me.BunifuButton30.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton30.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton26
        '
        Me.BunifuButton26.AllowAnimations = True
        Me.BunifuButton26.AllowMouseEffects = False
        Me.BunifuButton26.AllowToggling = False
        Me.BunifuButton26.AnimationSpeed = 200
        Me.BunifuButton26.AutoGenerateColors = False
        Me.BunifuButton26.AutoRoundBorders = False
        Me.BunifuButton26.AutoSizeLeftIcon = True
        Me.BunifuButton26.AutoSizeRightIcon = True
        Me.BunifuButton26.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton26.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton26.BackgroundImage = CType(resources.GetObject("BunifuButton26.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton26.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton26.ButtonText = "Sostenimiento G"
        Me.BunifuButton26.ButtonTextMarginLeft = 0
        Me.BunifuButton26.ColorContrastOnClick = 45
        Me.BunifuButton26.ColorContrastOnHover = 45
        Me.BunifuButton26.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges14.BottomLeft = False
        BorderEdges14.BottomRight = False
        BorderEdges14.TopLeft = False
        BorderEdges14.TopRight = False
        Me.BunifuButton26.CustomizableEdges = BorderEdges14
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton26, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton26.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton26.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton26.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton26.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton26.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton26.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton26.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton26.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton26.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton26.IconMarginLeft = 11
        Me.BunifuButton26.IconPadding = 10
        Me.BunifuButton26.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton26.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton26.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton26.IconSize = 25
        Me.BunifuButton26.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.IdleBorderRadius = 10
        Me.BunifuButton26.IdleBorderThickness = 2
        Me.BunifuButton26.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton26.IdleIconLeftImage = Nothing
        Me.BunifuButton26.IdleIconRightImage = Nothing
        Me.BunifuButton26.IndicateFocus = False
        Me.BunifuButton26.Location = New System.Drawing.Point(-1, 344)
        Me.BunifuButton26.Name = "BunifuButton26"
        Me.BunifuButton26.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnDisabledState.BorderRadius = 10
        Me.BunifuButton26.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton26.OnDisabledState.BorderThickness = 2
        Me.BunifuButton26.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton26.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton26.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton26.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.onHoverState.BorderRadius = 10
        Me.BunifuButton26.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton26.onHoverState.BorderThickness = 2
        Me.BunifuButton26.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton26.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton26.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton26.onHoverState.IconRightImage = Nothing
        Me.BunifuButton26.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnIdleState.BorderRadius = 10
        Me.BunifuButton26.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton26.OnIdleState.BorderThickness = 2
        Me.BunifuButton26.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton26.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton26.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton26.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnPressedState.BorderRadius = 10
        Me.BunifuButton26.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton26.OnPressedState.BorderThickness = 2
        Me.BunifuButton26.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton26.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton26.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton26.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton26.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton26.TabIndex = 2222307
        Me.BunifuButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton26.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton26.TextMarginLeft = 0
        Me.BunifuButton26.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton26.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton27
        '
        Me.BunifuButton27.AllowAnimations = True
        Me.BunifuButton27.AllowMouseEffects = False
        Me.BunifuButton27.AllowToggling = False
        Me.BunifuButton27.AnimationSpeed = 200
        Me.BunifuButton27.AutoGenerateColors = False
        Me.BunifuButton27.AutoRoundBorders = False
        Me.BunifuButton27.AutoSizeLeftIcon = True
        Me.BunifuButton27.AutoSizeRightIcon = True
        Me.BunifuButton27.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton27.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton27.BackgroundImage = CType(resources.GetObject("BunifuButton27.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton27.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton27.ButtonText = "Despachos"
        Me.BunifuButton27.ButtonTextMarginLeft = 0
        Me.BunifuButton27.ColorContrastOnClick = 45
        Me.BunifuButton27.ColorContrastOnHover = 45
        Me.BunifuButton27.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges15.BottomLeft = False
        BorderEdges15.BottomRight = False
        BorderEdges15.TopLeft = False
        BorderEdges15.TopRight = False
        Me.BunifuButton27.CustomizableEdges = BorderEdges15
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton27, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton27.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton27.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton27.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton27.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton27.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton27.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton27.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton27.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton27.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton27.IconMarginLeft = 11
        Me.BunifuButton27.IconPadding = 10
        Me.BunifuButton27.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton27.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton27.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton27.IconSize = 25
        Me.BunifuButton27.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.IdleBorderRadius = 10
        Me.BunifuButton27.IdleBorderThickness = 2
        Me.BunifuButton27.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton27.IdleIconLeftImage = Nothing
        Me.BunifuButton27.IdleIconRightImage = Nothing
        Me.BunifuButton27.IndicateFocus = False
        Me.BunifuButton27.Location = New System.Drawing.Point(-1, 315)
        Me.BunifuButton27.Name = "BunifuButton27"
        Me.BunifuButton27.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnDisabledState.BorderRadius = 10
        Me.BunifuButton27.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton27.OnDisabledState.BorderThickness = 2
        Me.BunifuButton27.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton27.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton27.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton27.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.onHoverState.BorderRadius = 10
        Me.BunifuButton27.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton27.onHoverState.BorderThickness = 2
        Me.BunifuButton27.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton27.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton27.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton27.onHoverState.IconRightImage = Nothing
        Me.BunifuButton27.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnIdleState.BorderRadius = 10
        Me.BunifuButton27.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton27.OnIdleState.BorderThickness = 2
        Me.BunifuButton27.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton27.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton27.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton27.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnPressedState.BorderRadius = 10
        Me.BunifuButton27.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton27.OnPressedState.BorderThickness = 2
        Me.BunifuButton27.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton27.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton27.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton27.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton27.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton27.TabIndex = 2222306
        Me.BunifuButton27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton27.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton27.TextMarginLeft = 0
        Me.BunifuButton27.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton27.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton28
        '
        Me.BunifuButton28.AllowAnimations = True
        Me.BunifuButton28.AllowMouseEffects = False
        Me.BunifuButton28.AllowToggling = False
        Me.BunifuButton28.AnimationSpeed = 200
        Me.BunifuButton28.AutoGenerateColors = False
        Me.BunifuButton28.AutoRoundBorders = False
        Me.BunifuButton28.AutoSizeLeftIcon = True
        Me.BunifuButton28.AutoSizeRightIcon = True
        Me.BunifuButton28.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton28.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton28.BackgroundImage = CType(resources.GetObject("BunifuButton28.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton28.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton28.ButtonText = "Servicios G"
        Me.BunifuButton28.ButtonTextMarginLeft = 0
        Me.BunifuButton28.ColorContrastOnClick = 45
        Me.BunifuButton28.ColorContrastOnHover = 45
        Me.BunifuButton28.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges16.BottomLeft = False
        BorderEdges16.BottomRight = False
        BorderEdges16.TopLeft = False
        BorderEdges16.TopRight = False
        Me.BunifuButton28.CustomizableEdges = BorderEdges16
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton28, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton28.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton28.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton28.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton28.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton28.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton28.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton28.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton28.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton28.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton28.IconMarginLeft = 11
        Me.BunifuButton28.IconPadding = 10
        Me.BunifuButton28.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton28.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton28.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton28.IconSize = 25
        Me.BunifuButton28.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.IdleBorderRadius = 10
        Me.BunifuButton28.IdleBorderThickness = 2
        Me.BunifuButton28.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton28.IdleIconLeftImage = Nothing
        Me.BunifuButton28.IdleIconRightImage = Nothing
        Me.BunifuButton28.IndicateFocus = False
        Me.BunifuButton28.Location = New System.Drawing.Point(-1, 287)
        Me.BunifuButton28.Name = "BunifuButton28"
        Me.BunifuButton28.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnDisabledState.BorderRadius = 10
        Me.BunifuButton28.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton28.OnDisabledState.BorderThickness = 2
        Me.BunifuButton28.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton28.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton28.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton28.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.onHoverState.BorderRadius = 10
        Me.BunifuButton28.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton28.onHoverState.BorderThickness = 2
        Me.BunifuButton28.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton28.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton28.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton28.onHoverState.IconRightImage = Nothing
        Me.BunifuButton28.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnIdleState.BorderRadius = 10
        Me.BunifuButton28.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton28.OnIdleState.BorderThickness = 2
        Me.BunifuButton28.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton28.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton28.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton28.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnPressedState.BorderRadius = 10
        Me.BunifuButton28.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton28.OnPressedState.BorderThickness = 2
        Me.BunifuButton28.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton28.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton28.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton28.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton28.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton28.TabIndex = 2222305
        Me.BunifuButton28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton28.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton28.TextMarginLeft = 0
        Me.BunifuButton28.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton28.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton29
        '
        Me.BunifuButton29.AllowAnimations = True
        Me.BunifuButton29.AllowMouseEffects = False
        Me.BunifuButton29.AllowToggling = False
        Me.BunifuButton29.AnimationSpeed = 200
        Me.BunifuButton29.AutoGenerateColors = False
        Me.BunifuButton29.AutoRoundBorders = False
        Me.BunifuButton29.AutoSizeLeftIcon = True
        Me.BunifuButton29.AutoSizeRightIcon = True
        Me.BunifuButton29.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton29.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton29.BackgroundImage = CType(resources.GetObject("BunifuButton29.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton29.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton29.ButtonText = "Mantenimiento"
        Me.BunifuButton29.ButtonTextMarginLeft = 0
        Me.BunifuButton29.ColorContrastOnClick = 45
        Me.BunifuButton29.ColorContrastOnHover = 45
        Me.BunifuButton29.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges17.BottomLeft = False
        BorderEdges17.BottomRight = False
        BorderEdges17.TopLeft = False
        BorderEdges17.TopRight = False
        Me.BunifuButton29.CustomizableEdges = BorderEdges17
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton29, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton29.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton29.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton29.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton29.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton29.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton29.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton29.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton29.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton29.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton29.IconMarginLeft = 11
        Me.BunifuButton29.IconPadding = 10
        Me.BunifuButton29.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton29.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton29.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton29.IconSize = 25
        Me.BunifuButton29.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.IdleBorderRadius = 10
        Me.BunifuButton29.IdleBorderThickness = 2
        Me.BunifuButton29.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton29.IdleIconLeftImage = Nothing
        Me.BunifuButton29.IdleIconRightImage = Nothing
        Me.BunifuButton29.IndicateFocus = False
        Me.BunifuButton29.Location = New System.Drawing.Point(-1, 258)
        Me.BunifuButton29.Name = "BunifuButton29"
        Me.BunifuButton29.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnDisabledState.BorderRadius = 10
        Me.BunifuButton29.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton29.OnDisabledState.BorderThickness = 2
        Me.BunifuButton29.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton29.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton29.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton29.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.onHoverState.BorderRadius = 10
        Me.BunifuButton29.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton29.onHoverState.BorderThickness = 2
        Me.BunifuButton29.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton29.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton29.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton29.onHoverState.IconRightImage = Nothing
        Me.BunifuButton29.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnIdleState.BorderRadius = 10
        Me.BunifuButton29.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton29.OnIdleState.BorderThickness = 2
        Me.BunifuButton29.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton29.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton29.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton29.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnPressedState.BorderRadius = 10
        Me.BunifuButton29.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton29.OnPressedState.BorderThickness = 2
        Me.BunifuButton29.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton29.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton29.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton29.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton29.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton29.TabIndex = 2222304
        Me.BunifuButton29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton29.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton29.TextMarginLeft = 0
        Me.BunifuButton29.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton29.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton15
        '
        Me.BunifuButton15.AllowAnimations = True
        Me.BunifuButton15.AllowMouseEffects = False
        Me.BunifuButton15.AllowToggling = False
        Me.BunifuButton15.AnimationSpeed = 200
        Me.BunifuButton15.AutoGenerateColors = False
        Me.BunifuButton15.AutoRoundBorders = False
        Me.BunifuButton15.AutoSizeLeftIcon = True
        Me.BunifuButton15.AutoSizeRightIcon = True
        Me.BunifuButton15.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton15.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton15.BackgroundImage = CType(resources.GetObject("BunifuButton15.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton15.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton15.ButtonText = "Puas"
        Me.BunifuButton15.ButtonTextMarginLeft = 0
        Me.BunifuButton15.ColorContrastOnClick = 45
        Me.BunifuButton15.ColorContrastOnHover = 45
        Me.BunifuButton15.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges18.BottomLeft = True
        BorderEdges18.BottomRight = True
        BorderEdges18.TopLeft = False
        BorderEdges18.TopRight = False
        Me.BunifuButton15.CustomizableEdges = BorderEdges18
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton15, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton15.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton15.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton15.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton15.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton15.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton15.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton15.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton15.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton15.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton15.IconMarginLeft = 11
        Me.BunifuButton15.IconPadding = 10
        Me.BunifuButton15.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton15.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton15.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton15.IconSize = 25
        Me.BunifuButton15.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.IdleBorderRadius = 10
        Me.BunifuButton15.IdleBorderThickness = 2
        Me.BunifuButton15.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton15.IdleIconLeftImage = Nothing
        Me.BunifuButton15.IdleIconRightImage = Nothing
        Me.BunifuButton15.IndicateFocus = False
        Me.BunifuButton15.Location = New System.Drawing.Point(-1, 545)
        Me.BunifuButton15.Name = "BunifuButton15"
        Me.BunifuButton15.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnDisabledState.BorderRadius = 10
        Me.BunifuButton15.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton15.OnDisabledState.BorderThickness = 2
        Me.BunifuButton15.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton15.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton15.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton15.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.onHoverState.BorderRadius = 10
        Me.BunifuButton15.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton15.onHoverState.BorderThickness = 2
        Me.BunifuButton15.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton15.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton15.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton15.onHoverState.IconRightImage = Nothing
        Me.BunifuButton15.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnIdleState.BorderRadius = 10
        Me.BunifuButton15.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton15.OnIdleState.BorderThickness = 2
        Me.BunifuButton15.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton15.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton15.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton15.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnPressedState.BorderRadius = 10
        Me.BunifuButton15.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton15.OnPressedState.BorderThickness = 2
        Me.BunifuButton15.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton15.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton15.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton15.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton15.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton15.TabIndex = 2222303
        Me.BunifuButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton15.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton15.TextMarginLeft = 0
        Me.BunifuButton15.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton15.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton16
        '
        Me.BunifuButton16.AllowAnimations = True
        Me.BunifuButton16.AllowMouseEffects = False
        Me.BunifuButton16.AllowToggling = False
        Me.BunifuButton16.AnimationSpeed = 200
        Me.BunifuButton16.AutoGenerateColors = False
        Me.BunifuButton16.AutoRoundBorders = False
        Me.BunifuButton16.AutoSizeLeftIcon = True
        Me.BunifuButton16.AutoSizeRightIcon = True
        Me.BunifuButton16.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton16.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton16.BackgroundImage = CType(resources.GetObject("BunifuButton16.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton16.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton16.ButtonText = "Tratamientos Ter"
        Me.BunifuButton16.ButtonTextMarginLeft = 0
        Me.BunifuButton16.ColorContrastOnClick = 45
        Me.BunifuButton16.ColorContrastOnHover = 45
        Me.BunifuButton16.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges19.BottomLeft = False
        BorderEdges19.BottomRight = False
        BorderEdges19.TopLeft = False
        BorderEdges19.TopRight = False
        Me.BunifuButton16.CustomizableEdges = BorderEdges19
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton16, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton16.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton16.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton16.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton16.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton16.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton16.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton16.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton16.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton16.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton16.IconMarginLeft = 11
        Me.BunifuButton16.IconPadding = 10
        Me.BunifuButton16.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton16.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton16.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton16.IconSize = 25
        Me.BunifuButton16.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.IdleBorderRadius = 10
        Me.BunifuButton16.IdleBorderThickness = 2
        Me.BunifuButton16.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton16.IdleIconLeftImage = Nothing
        Me.BunifuButton16.IdleIconRightImage = Nothing
        Me.BunifuButton16.IndicateFocus = False
        Me.BunifuButton16.Location = New System.Drawing.Point(-1, 516)
        Me.BunifuButton16.Name = "BunifuButton16"
        Me.BunifuButton16.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnDisabledState.BorderRadius = 10
        Me.BunifuButton16.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton16.OnDisabledState.BorderThickness = 2
        Me.BunifuButton16.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton16.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton16.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton16.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.onHoverState.BorderRadius = 10
        Me.BunifuButton16.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton16.onHoverState.BorderThickness = 2
        Me.BunifuButton16.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton16.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton16.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton16.onHoverState.IconRightImage = Nothing
        Me.BunifuButton16.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnIdleState.BorderRadius = 10
        Me.BunifuButton16.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton16.OnIdleState.BorderThickness = 2
        Me.BunifuButton16.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton16.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton16.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton16.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnPressedState.BorderRadius = 10
        Me.BunifuButton16.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton16.OnPressedState.BorderThickness = 2
        Me.BunifuButton16.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton16.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton16.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton16.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton16.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton16.TabIndex = 2222302
        Me.BunifuButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton16.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton16.TextMarginLeft = 0
        Me.BunifuButton16.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton16.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton17
        '
        Me.BunifuButton17.AllowAnimations = True
        Me.BunifuButton17.AllowMouseEffects = False
        Me.BunifuButton17.AllowToggling = False
        Me.BunifuButton17.AnimationSpeed = 200
        Me.BunifuButton17.AutoGenerateColors = False
        Me.BunifuButton17.AutoRoundBorders = False
        Me.BunifuButton17.AutoSizeLeftIcon = True
        Me.BunifuButton17.AutoSizeRightIcon = True
        Me.BunifuButton17.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton17.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton17.BackgroundImage = CType(resources.GetObject("BunifuButton17.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton17.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton17.ButtonText = "Empaque Grap"
        Me.BunifuButton17.ButtonTextMarginLeft = 0
        Me.BunifuButton17.ColorContrastOnClick = 45
        Me.BunifuButton17.ColorContrastOnHover = 45
        Me.BunifuButton17.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges20.BottomLeft = False
        BorderEdges20.BottomRight = False
        BorderEdges20.TopLeft = False
        BorderEdges20.TopRight = False
        Me.BunifuButton17.CustomizableEdges = BorderEdges20
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton17, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton17.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton17.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton17.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton17.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton17.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton17.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton17.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton17.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton17.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton17.IconMarginLeft = 11
        Me.BunifuButton17.IconPadding = 10
        Me.BunifuButton17.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton17.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton17.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton17.IconSize = 25
        Me.BunifuButton17.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.IdleBorderRadius = 10
        Me.BunifuButton17.IdleBorderThickness = 2
        Me.BunifuButton17.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton17.IdleIconLeftImage = Nothing
        Me.BunifuButton17.IdleIconRightImage = Nothing
        Me.BunifuButton17.IndicateFocus = False
        Me.BunifuButton17.Location = New System.Drawing.Point(-1, 488)
        Me.BunifuButton17.Name = "BunifuButton17"
        Me.BunifuButton17.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnDisabledState.BorderRadius = 10
        Me.BunifuButton17.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton17.OnDisabledState.BorderThickness = 2
        Me.BunifuButton17.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton17.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton17.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton17.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.onHoverState.BorderRadius = 10
        Me.BunifuButton17.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton17.onHoverState.BorderThickness = 2
        Me.BunifuButton17.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton17.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton17.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton17.onHoverState.IconRightImage = Nothing
        Me.BunifuButton17.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnIdleState.BorderRadius = 10
        Me.BunifuButton17.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton17.OnIdleState.BorderThickness = 2
        Me.BunifuButton17.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton17.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton17.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton17.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnPressedState.BorderRadius = 10
        Me.BunifuButton17.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton17.OnPressedState.BorderThickness = 2
        Me.BunifuButton17.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton17.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton17.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton17.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton17.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton17.TabIndex = 2222301
        Me.BunifuButton17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton17.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton17.TextMarginLeft = 0
        Me.BunifuButton17.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton17.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton18
        '
        Me.BunifuButton18.AllowAnimations = True
        Me.BunifuButton18.AllowMouseEffects = False
        Me.BunifuButton18.AllowToggling = False
        Me.BunifuButton18.AnimationSpeed = 200
        Me.BunifuButton18.AutoGenerateColors = False
        Me.BunifuButton18.AutoRoundBorders = False
        Me.BunifuButton18.AutoSizeLeftIcon = True
        Me.BunifuButton18.AutoSizeRightIcon = True
        Me.BunifuButton18.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton18.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton18.BackgroundImage = CType(resources.GetObject("BunifuButton18.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton18.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton18.ButtonText = "Grapas"
        Me.BunifuButton18.ButtonTextMarginLeft = 0
        Me.BunifuButton18.ColorContrastOnClick = 45
        Me.BunifuButton18.ColorContrastOnHover = 45
        Me.BunifuButton18.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges21.BottomLeft = False
        BorderEdges21.BottomRight = False
        BorderEdges21.TopLeft = False
        BorderEdges21.TopRight = False
        Me.BunifuButton18.CustomizableEdges = BorderEdges21
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton18, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton18.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton18.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton18.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton18.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton18.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton18.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton18.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton18.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton18.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton18.IconMarginLeft = 11
        Me.BunifuButton18.IconPadding = 10
        Me.BunifuButton18.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton18.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton18.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton18.IconSize = 25
        Me.BunifuButton18.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.IdleBorderRadius = 10
        Me.BunifuButton18.IdleBorderThickness = 2
        Me.BunifuButton18.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton18.IdleIconLeftImage = Nothing
        Me.BunifuButton18.IdleIconRightImage = Nothing
        Me.BunifuButton18.IndicateFocus = False
        Me.BunifuButton18.Location = New System.Drawing.Point(-1, 459)
        Me.BunifuButton18.Name = "BunifuButton18"
        Me.BunifuButton18.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnDisabledState.BorderRadius = 10
        Me.BunifuButton18.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton18.OnDisabledState.BorderThickness = 2
        Me.BunifuButton18.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton18.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton18.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton18.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.onHoverState.BorderRadius = 10
        Me.BunifuButton18.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton18.onHoverState.BorderThickness = 2
        Me.BunifuButton18.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton18.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton18.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton18.onHoverState.IconRightImage = Nothing
        Me.BunifuButton18.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnIdleState.BorderRadius = 10
        Me.BunifuButton18.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton18.OnIdleState.BorderThickness = 2
        Me.BunifuButton18.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton18.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton18.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton18.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnPressedState.BorderRadius = 10
        Me.BunifuButton18.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton18.OnPressedState.BorderThickness = 2
        Me.BunifuButton18.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton18.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton18.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton18.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton18.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton18.TabIndex = 2222300
        Me.BunifuButton18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton18.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton18.TextMarginLeft = 0
        Me.BunifuButton18.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton18.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton19
        '
        Me.BunifuButton19.AllowAnimations = True
        Me.BunifuButton19.AllowMouseEffects = False
        Me.BunifuButton19.AllowToggling = False
        Me.BunifuButton19.AnimationSpeed = 200
        Me.BunifuButton19.AutoGenerateColors = False
        Me.BunifuButton19.AutoRoundBorders = False
        Me.BunifuButton19.AutoSizeLeftIcon = True
        Me.BunifuButton19.AutoSizeRightIcon = True
        Me.BunifuButton19.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton19.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton19.BackgroundImage = CType(resources.GetObject("BunifuButton19.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton19.ButtonText = "Galvanizado"
        Me.BunifuButton19.ButtonTextMarginLeft = 0
        Me.BunifuButton19.ColorContrastOnClick = 45
        Me.BunifuButton19.ColorContrastOnHover = 45
        Me.BunifuButton19.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges22.BottomLeft = False
        BorderEdges22.BottomRight = False
        BorderEdges22.TopLeft = False
        BorderEdges22.TopRight = False
        Me.BunifuButton19.CustomizableEdges = BorderEdges22
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton19, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton19.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton19.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton19.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton19.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton19.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton19.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton19.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton19.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton19.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton19.IconMarginLeft = 11
        Me.BunifuButton19.IconPadding = 10
        Me.BunifuButton19.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton19.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton19.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton19.IconSize = 25
        Me.BunifuButton19.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.IdleBorderRadius = 10
        Me.BunifuButton19.IdleBorderThickness = 2
        Me.BunifuButton19.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton19.IdleIconLeftImage = Nothing
        Me.BunifuButton19.IdleIconRightImage = Nothing
        Me.BunifuButton19.IndicateFocus = False
        Me.BunifuButton19.Location = New System.Drawing.Point(-1, 430)
        Me.BunifuButton19.Name = "BunifuButton19"
        Me.BunifuButton19.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnDisabledState.BorderRadius = 10
        Me.BunifuButton19.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton19.OnDisabledState.BorderThickness = 2
        Me.BunifuButton19.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton19.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton19.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton19.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.onHoverState.BorderRadius = 10
        Me.BunifuButton19.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton19.onHoverState.BorderThickness = 2
        Me.BunifuButton19.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton19.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton19.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton19.onHoverState.IconRightImage = Nothing
        Me.BunifuButton19.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnIdleState.BorderRadius = 10
        Me.BunifuButton19.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton19.OnIdleState.BorderThickness = 2
        Me.BunifuButton19.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton19.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton19.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton19.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnPressedState.BorderRadius = 10
        Me.BunifuButton19.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton19.OnPressedState.BorderThickness = 2
        Me.BunifuButton19.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton19.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton19.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton19.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton19.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton19.TabIndex = 2222299
        Me.BunifuButton19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton19.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton19.TextMarginLeft = 0
        Me.BunifuButton19.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton19.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton20
        '
        Me.BunifuButton20.AllowAnimations = True
        Me.BunifuButton20.AllowMouseEffects = False
        Me.BunifuButton20.AllowToggling = False
        Me.BunifuButton20.AnimationSpeed = 200
        Me.BunifuButton20.AutoGenerateColors = False
        Me.BunifuButton20.AutoRoundBorders = False
        Me.BunifuButton20.AutoSizeLeftIcon = True
        Me.BunifuButton20.AutoSizeRightIcon = True
        Me.BunifuButton20.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton20.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton20.BackgroundImage = CType(resources.GetObject("BunifuButton20.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton20.ButtonText = "Empaque Torn"
        Me.BunifuButton20.ButtonTextMarginLeft = 0
        Me.BunifuButton20.ColorContrastOnClick = 45
        Me.BunifuButton20.ColorContrastOnHover = 45
        Me.BunifuButton20.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges23.BottomLeft = False
        BorderEdges23.BottomRight = False
        BorderEdges23.TopLeft = False
        BorderEdges23.TopRight = False
        Me.BunifuButton20.CustomizableEdges = BorderEdges23
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton20, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton20.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton20.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton20.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton20.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton20.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton20.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton20.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton20.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton20.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton20.IconMarginLeft = 11
        Me.BunifuButton20.IconPadding = 10
        Me.BunifuButton20.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton20.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton20.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton20.IconSize = 25
        Me.BunifuButton20.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.IdleBorderRadius = 10
        Me.BunifuButton20.IdleBorderThickness = 2
        Me.BunifuButton20.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton20.IdleIconLeftImage = Nothing
        Me.BunifuButton20.IdleIconRightImage = Nothing
        Me.BunifuButton20.IndicateFocus = False
        Me.BunifuButton20.Location = New System.Drawing.Point(-1, 229)
        Me.BunifuButton20.Name = "BunifuButton20"
        Me.BunifuButton20.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnDisabledState.BorderRadius = 10
        Me.BunifuButton20.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton20.OnDisabledState.BorderThickness = 2
        Me.BunifuButton20.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton20.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton20.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton20.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.onHoverState.BorderRadius = 10
        Me.BunifuButton20.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton20.onHoverState.BorderThickness = 2
        Me.BunifuButton20.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton20.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton20.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton20.onHoverState.IconRightImage = Nothing
        Me.BunifuButton20.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnIdleState.BorderRadius = 10
        Me.BunifuButton20.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton20.OnIdleState.BorderThickness = 2
        Me.BunifuButton20.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton20.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton20.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton20.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnPressedState.BorderRadius = 10
        Me.BunifuButton20.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton20.OnPressedState.BorderThickness = 2
        Me.BunifuButton20.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton20.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton20.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton20.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton20.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton20.TabIndex = 2222298
        Me.BunifuButton20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton20.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton20.TextMarginLeft = 0
        Me.BunifuButton20.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton20.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton21
        '
        Me.BunifuButton21.AllowAnimations = True
        Me.BunifuButton21.AllowMouseEffects = False
        Me.BunifuButton21.AllowToggling = False
        Me.BunifuButton21.AnimationSpeed = 200
        Me.BunifuButton21.AutoGenerateColors = False
        Me.BunifuButton21.AutoRoundBorders = False
        Me.BunifuButton21.AutoSizeLeftIcon = True
        Me.BunifuButton21.AutoSizeRightIcon = True
        Me.BunifuButton21.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton21.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton21.BackgroundImage = CType(resources.GetObject("BunifuButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton21.ButtonText = "Tornilleria"
        Me.BunifuButton21.ButtonTextMarginLeft = 0
        Me.BunifuButton21.ColorContrastOnClick = 45
        Me.BunifuButton21.ColorContrastOnHover = 45
        Me.BunifuButton21.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges24.BottomLeft = False
        BorderEdges24.BottomRight = False
        BorderEdges24.TopLeft = False
        BorderEdges24.TopRight = False
        Me.BunifuButton21.CustomizableEdges = BorderEdges24
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton21, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton21.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton21.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton21.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton21.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton21.IconMarginLeft = 11
        Me.BunifuButton21.IconPadding = 10
        Me.BunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton21.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton21.IconSize = 25
        Me.BunifuButton21.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.IdleBorderRadius = 10
        Me.BunifuButton21.IdleBorderThickness = 2
        Me.BunifuButton21.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton21.IdleIconLeftImage = Nothing
        Me.BunifuButton21.IdleIconRightImage = Nothing
        Me.BunifuButton21.IndicateFocus = False
        Me.BunifuButton21.Location = New System.Drawing.Point(-1, 201)
        Me.BunifuButton21.Name = "BunifuButton21"
        Me.BunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnDisabledState.BorderRadius = 10
        Me.BunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton21.OnDisabledState.BorderThickness = 2
        Me.BunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton21.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton21.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.onHoverState.BorderRadius = 10
        Me.BunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton21.onHoverState.BorderThickness = 2
        Me.BunifuButton21.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton21.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton21.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton21.onHoverState.IconRightImage = Nothing
        Me.BunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnIdleState.BorderRadius = 10
        Me.BunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton21.OnIdleState.BorderThickness = 2
        Me.BunifuButton21.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton21.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnPressedState.BorderRadius = 10
        Me.BunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton21.OnPressedState.BorderThickness = 2
        Me.BunifuButton21.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton21.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton21.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton21.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton21.TabIndex = 2222297
        Me.BunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton21.TextMarginLeft = 0
        Me.BunifuButton21.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton21.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton22
        '
        Me.BunifuButton22.AllowAnimations = True
        Me.BunifuButton22.AllowMouseEffects = False
        Me.BunifuButton22.AllowToggling = False
        Me.BunifuButton22.AnimationSpeed = 200
        Me.BunifuButton22.AutoGenerateColors = False
        Me.BunifuButton22.AutoRoundBorders = False
        Me.BunifuButton22.AutoSizeLeftIcon = True
        Me.BunifuButton22.AutoSizeRightIcon = True
        Me.BunifuButton22.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton22.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton22.BackgroundImage = CType(resources.GetObject("BunifuButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton22.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton22.ButtonText = "Empaque Punt"
        Me.BunifuButton22.ButtonTextMarginLeft = 0
        Me.BunifuButton22.ColorContrastOnClick = 45
        Me.BunifuButton22.ColorContrastOnHover = 45
        Me.BunifuButton22.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges25.BottomLeft = False
        BorderEdges25.BottomRight = False
        BorderEdges25.TopLeft = False
        BorderEdges25.TopRight = False
        Me.BunifuButton22.CustomizableEdges = BorderEdges25
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton22, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton22.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton22.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton22.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton22.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton22.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton22.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton22.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton22.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton22.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton22.IconMarginLeft = 11
        Me.BunifuButton22.IconPadding = 10
        Me.BunifuButton22.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton22.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton22.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton22.IconSize = 25
        Me.BunifuButton22.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.IdleBorderRadius = 10
        Me.BunifuButton22.IdleBorderThickness = 2
        Me.BunifuButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton22.IdleIconLeftImage = Nothing
        Me.BunifuButton22.IdleIconRightImage = Nothing
        Me.BunifuButton22.IndicateFocus = False
        Me.BunifuButton22.Location = New System.Drawing.Point(-1, 172)
        Me.BunifuButton22.Name = "BunifuButton22"
        Me.BunifuButton22.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnDisabledState.BorderRadius = 10
        Me.BunifuButton22.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton22.OnDisabledState.BorderThickness = 2
        Me.BunifuButton22.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton22.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton22.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton22.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.onHoverState.BorderRadius = 10
        Me.BunifuButton22.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton22.onHoverState.BorderThickness = 2
        Me.BunifuButton22.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton22.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton22.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton22.onHoverState.IconRightImage = Nothing
        Me.BunifuButton22.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnIdleState.BorderRadius = 10
        Me.BunifuButton22.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton22.OnIdleState.BorderThickness = 2
        Me.BunifuButton22.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton22.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton22.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton22.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnPressedState.BorderRadius = 10
        Me.BunifuButton22.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton22.OnPressedState.BorderThickness = 2
        Me.BunifuButton22.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton22.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton22.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton22.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton22.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton22.TabIndex = 2222296
        Me.BunifuButton22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton22.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton22.TextMarginLeft = 0
        Me.BunifuButton22.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton22.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton23
        '
        Me.BunifuButton23.AllowAnimations = True
        Me.BunifuButton23.AllowMouseEffects = False
        Me.BunifuButton23.AllowToggling = False
        Me.BunifuButton23.AnimationSpeed = 200
        Me.BunifuButton23.AutoGenerateColors = False
        Me.BunifuButton23.AutoRoundBorders = False
        Me.BunifuButton23.AutoSizeLeftIcon = True
        Me.BunifuButton23.AutoSizeRightIcon = True
        Me.BunifuButton23.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton23.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton23.BackgroundImage = CType(resources.GetObject("BunifuButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton23.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton23.ButtonText = "Puntilleria"
        Me.BunifuButton23.ButtonTextMarginLeft = 0
        Me.BunifuButton23.ColorContrastOnClick = 45
        Me.BunifuButton23.ColorContrastOnHover = 45
        Me.BunifuButton23.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges26.BottomLeft = False
        BorderEdges26.BottomRight = False
        BorderEdges26.TopLeft = False
        BorderEdges26.TopRight = False
        Me.BunifuButton23.CustomizableEdges = BorderEdges26
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton23, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton23.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton23.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton23.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton23.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton23.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton23.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton23.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton23.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton23.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton23.IconMarginLeft = 11
        Me.BunifuButton23.IconPadding = 10
        Me.BunifuButton23.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton23.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton23.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton23.IconSize = 25
        Me.BunifuButton23.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.IdleBorderRadius = 10
        Me.BunifuButton23.IdleBorderThickness = 2
        Me.BunifuButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton23.IdleIconLeftImage = Nothing
        Me.BunifuButton23.IdleIconRightImage = Nothing
        Me.BunifuButton23.IndicateFocus = False
        Me.BunifuButton23.Location = New System.Drawing.Point(-1, 144)
        Me.BunifuButton23.Name = "BunifuButton23"
        Me.BunifuButton23.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnDisabledState.BorderRadius = 10
        Me.BunifuButton23.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton23.OnDisabledState.BorderThickness = 2
        Me.BunifuButton23.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton23.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton23.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton23.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.onHoverState.BorderRadius = 10
        Me.BunifuButton23.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton23.onHoverState.BorderThickness = 2
        Me.BunifuButton23.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton23.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton23.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton23.onHoverState.IconRightImage = Nothing
        Me.BunifuButton23.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnIdleState.BorderRadius = 10
        Me.BunifuButton23.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton23.OnIdleState.BorderThickness = 2
        Me.BunifuButton23.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton23.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton23.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton23.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnPressedState.BorderRadius = 10
        Me.BunifuButton23.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton23.OnPressedState.BorderThickness = 2
        Me.BunifuButton23.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton23.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton23.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton23.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton23.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton23.TabIndex = 2222295
        Me.BunifuButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton23.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton23.TextMarginLeft = 0
        Me.BunifuButton23.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton23.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton24
        '
        Me.BunifuButton24.AllowAnimations = True
        Me.BunifuButton24.AllowMouseEffects = False
        Me.BunifuButton24.AllowToggling = False
        Me.BunifuButton24.AnimationSpeed = 200
        Me.BunifuButton24.AutoGenerateColors = False
        Me.BunifuButton24.AutoRoundBorders = False
        Me.BunifuButton24.AutoSizeLeftIcon = True
        Me.BunifuButton24.AutoSizeRightIcon = True
        Me.BunifuButton24.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton24.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton24.BackgroundImage = CType(resources.GetObject("BunifuButton24.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton24.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton24.ButtonText = "Hornos Rec"
        Me.BunifuButton24.ButtonTextMarginLeft = 0
        Me.BunifuButton24.ColorContrastOnClick = 45
        Me.BunifuButton24.ColorContrastOnHover = 45
        Me.BunifuButton24.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges27.BottomLeft = False
        BorderEdges27.BottomRight = False
        BorderEdges27.TopLeft = False
        BorderEdges27.TopRight = False
        Me.BunifuButton24.CustomizableEdges = BorderEdges27
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton24, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton24.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton24.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton24.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton24.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton24.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton24.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton24.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton24.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton24.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton24.IconMarginLeft = 11
        Me.BunifuButton24.IconPadding = 10
        Me.BunifuButton24.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton24.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton24.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton24.IconSize = 25
        Me.BunifuButton24.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.IdleBorderRadius = 10
        Me.BunifuButton24.IdleBorderThickness = 2
        Me.BunifuButton24.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton24.IdleIconLeftImage = Nothing
        Me.BunifuButton24.IdleIconRightImage = Nothing
        Me.BunifuButton24.IndicateFocus = False
        Me.BunifuButton24.Location = New System.Drawing.Point(-1, 115)
        Me.BunifuButton24.Name = "BunifuButton24"
        Me.BunifuButton24.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnDisabledState.BorderRadius = 10
        Me.BunifuButton24.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton24.OnDisabledState.BorderThickness = 2
        Me.BunifuButton24.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton24.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton24.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton24.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.onHoverState.BorderRadius = 10
        Me.BunifuButton24.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton24.onHoverState.BorderThickness = 2
        Me.BunifuButton24.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton24.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton24.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton24.onHoverState.IconRightImage = Nothing
        Me.BunifuButton24.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnIdleState.BorderRadius = 10
        Me.BunifuButton24.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton24.OnIdleState.BorderThickness = 2
        Me.BunifuButton24.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton24.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton24.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton24.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnPressedState.BorderRadius = 10
        Me.BunifuButton24.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton24.OnPressedState.BorderThickness = 2
        Me.BunifuButton24.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton24.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton24.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton24.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton24.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton24.TabIndex = 2222294
        Me.BunifuButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton24.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton24.TextMarginLeft = 0
        Me.BunifuButton24.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton24.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton14
        '
        Me.BunifuButton14.AllowAnimations = True
        Me.BunifuButton14.AllowMouseEffects = False
        Me.BunifuButton14.AllowToggling = False
        Me.BunifuButton14.AnimationSpeed = 200
        Me.BunifuButton14.AutoGenerateColors = False
        Me.BunifuButton14.AutoRoundBorders = False
        Me.BunifuButton14.AutoSizeLeftIcon = True
        Me.BunifuButton14.AutoSizeRightIcon = True
        Me.BunifuButton14.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton14.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton14.BackgroundImage = CType(resources.GetObject("BunifuButton14.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton14.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton14.ButtonText = "Trefilacion"
        Me.BunifuButton14.ButtonTextMarginLeft = 0
        Me.BunifuButton14.ColorContrastOnClick = 45
        Me.BunifuButton14.ColorContrastOnHover = 45
        Me.BunifuButton14.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges28.BottomLeft = False
        BorderEdges28.BottomRight = False
        BorderEdges28.TopLeft = False
        BorderEdges28.TopRight = False
        Me.BunifuButton14.CustomizableEdges = BorderEdges28
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton14, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton14.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton14.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton14.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton14.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton14.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton14.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton14.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton14.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton14.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton14.IconMarginLeft = 11
        Me.BunifuButton14.IconPadding = 10
        Me.BunifuButton14.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton14.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton14.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton14.IconSize = 25
        Me.BunifuButton14.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.IdleBorderRadius = 10
        Me.BunifuButton14.IdleBorderThickness = 2
        Me.BunifuButton14.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton14.IdleIconLeftImage = Nothing
        Me.BunifuButton14.IdleIconRightImage = Nothing
        Me.BunifuButton14.IndicateFocus = False
        Me.BunifuButton14.Location = New System.Drawing.Point(-1, 86)
        Me.BunifuButton14.Name = "BunifuButton14"
        Me.BunifuButton14.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnDisabledState.BorderRadius = 10
        Me.BunifuButton14.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton14.OnDisabledState.BorderThickness = 2
        Me.BunifuButton14.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton14.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton14.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton14.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.onHoverState.BorderRadius = 10
        Me.BunifuButton14.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton14.onHoverState.BorderThickness = 2
        Me.BunifuButton14.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton14.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton14.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton14.onHoverState.IconRightImage = Nothing
        Me.BunifuButton14.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnIdleState.BorderRadius = 10
        Me.BunifuButton14.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton14.OnIdleState.BorderThickness = 2
        Me.BunifuButton14.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton14.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton14.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton14.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnPressedState.BorderRadius = 10
        Me.BunifuButton14.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton14.OnPressedState.BorderThickness = 2
        Me.BunifuButton14.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton14.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton14.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton14.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton14.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton14.TabIndex = 2222293
        Me.BunifuButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton14.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton14.TextMarginLeft = 0
        Me.BunifuButton14.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton14.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton12
        '
        Me.BunifuButton12.AllowAnimations = True
        Me.BunifuButton12.AllowMouseEffects = False
        Me.BunifuButton12.AllowToggling = False
        Me.BunifuButton12.AnimationSpeed = 200
        Me.BunifuButton12.AutoGenerateColors = False
        Me.BunifuButton12.AutoRoundBorders = False
        Me.BunifuButton12.AutoSizeLeftIcon = True
        Me.BunifuButton12.AutoSizeRightIcon = True
        Me.BunifuButton12.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton12.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton12.BackgroundImage = CType(resources.GetObject("BunifuButton12.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton12.ButtonText = "Almacen"
        Me.BunifuButton12.ButtonTextMarginLeft = 0
        Me.BunifuButton12.ColorContrastOnClick = 45
        Me.BunifuButton12.ColorContrastOnHover = 45
        Me.BunifuButton12.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges29.BottomLeft = False
        BorderEdges29.BottomRight = False
        BorderEdges29.TopLeft = False
        BorderEdges29.TopRight = False
        Me.BunifuButton12.CustomizableEdges = BorderEdges29
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton12, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton12.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton12.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton12.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton12.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton12.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton12.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton12.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton12.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton12.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton12.IconMarginLeft = 11
        Me.BunifuButton12.IconPadding = 10
        Me.BunifuButton12.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton12.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton12.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton12.IconSize = 25
        Me.BunifuButton12.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.IdleBorderRadius = 10
        Me.BunifuButton12.IdleBorderThickness = 2
        Me.BunifuButton12.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton12.IdleIconLeftImage = Nothing
        Me.BunifuButton12.IdleIconRightImage = Nothing
        Me.BunifuButton12.IndicateFocus = False
        Me.BunifuButton12.Location = New System.Drawing.Point(-1, 59)
        Me.BunifuButton12.Name = "BunifuButton12"
        Me.BunifuButton12.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnDisabledState.BorderRadius = 10
        Me.BunifuButton12.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton12.OnDisabledState.BorderThickness = 2
        Me.BunifuButton12.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton12.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton12.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton12.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.onHoverState.BorderRadius = 10
        Me.BunifuButton12.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton12.onHoverState.BorderThickness = 2
        Me.BunifuButton12.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton12.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton12.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton12.onHoverState.IconRightImage = Nothing
        Me.BunifuButton12.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnIdleState.BorderRadius = 10
        Me.BunifuButton12.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton12.OnIdleState.BorderThickness = 2
        Me.BunifuButton12.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton12.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton12.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton12.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnPressedState.BorderRadius = 10
        Me.BunifuButton12.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton12.OnPressedState.BorderThickness = 2
        Me.BunifuButton12.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton12.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton12.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton12.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton12.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton12.TabIndex = 2222292
        Me.BunifuButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton12.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton12.TextMarginLeft = 0
        Me.BunifuButton12.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton12.UseDefaultRadiusAndThickness = True
        '
        'BunifuButton13
        '
        Me.BunifuButton13.AllowAnimations = True
        Me.BunifuButton13.AllowMouseEffects = False
        Me.BunifuButton13.AllowToggling = False
        Me.BunifuButton13.AnimationSpeed = 200
        Me.BunifuButton13.AutoGenerateColors = False
        Me.BunifuButton13.AutoRoundBorders = False
        Me.BunifuButton13.AutoSizeLeftIcon = True
        Me.BunifuButton13.AutoSizeRightIcon = True
        Me.BunifuButton13.BackColor = System.Drawing.Color.Transparent
        Me.BunifuButton13.BackColor1 = System.Drawing.Color.White
        Me.BunifuButton13.BackgroundImage = CType(resources.GetObject("BunifuButton13.BackgroundImage"), System.Drawing.Image)
        Me.BunifuButton13.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton13.ButtonText = "Compras"
        Me.BunifuButton13.ButtonTextMarginLeft = 0
        Me.BunifuButton13.ColorContrastOnClick = 45
        Me.BunifuButton13.ColorContrastOnHover = 45
        Me.BunifuButton13.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges30.BottomLeft = False
        BorderEdges30.BottomRight = False
        BorderEdges30.TopLeft = True
        BorderEdges30.TopRight = True
        Me.BunifuButton13.CustomizableEdges = BorderEdges30
        Me.BunifuTransition2.SetDecoration(Me.BunifuButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.BunifuButton13, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuButton13.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BunifuButton13.DisabledBorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.DisabledFillColor = System.Drawing.Color.White
        Me.BunifuButton13.DisabledForecolor = System.Drawing.Color.Black
        Me.BunifuButton13.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BunifuButton13.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BunifuButton13.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton13.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton13.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton13.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BunifuButton13.IconMarginLeft = 11
        Me.BunifuButton13.IconPadding = 10
        Me.BunifuButton13.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BunifuButton13.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BunifuButton13.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BunifuButton13.IconSize = 25
        Me.BunifuButton13.IdleBorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.IdleBorderRadius = 10
        Me.BunifuButton13.IdleBorderThickness = 2
        Me.BunifuButton13.IdleFillColor = System.Drawing.Color.White
        Me.BunifuButton13.IdleIconLeftImage = Nothing
        Me.BunifuButton13.IdleIconRightImage = Nothing
        Me.BunifuButton13.IndicateFocus = False
        Me.BunifuButton13.Location = New System.Drawing.Point(-1, 31)
        Me.BunifuButton13.Name = "BunifuButton13"
        Me.BunifuButton13.OnDisabledState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnDisabledState.BorderRadius = 10
        Me.BunifuButton13.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton13.OnDisabledState.BorderThickness = 2
        Me.BunifuButton13.OnDisabledState.FillColor = System.Drawing.Color.White
        Me.BunifuButton13.OnDisabledState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnDisabledState.IconLeftImage = Nothing
        Me.BunifuButton13.OnDisabledState.IconRightImage = Nothing
        Me.BunifuButton13.onHoverState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.onHoverState.BorderRadius = 10
        Me.BunifuButton13.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton13.onHoverState.BorderThickness = 2
        Me.BunifuButton13.onHoverState.FillColor = System.Drawing.Color.White
        Me.BunifuButton13.onHoverState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton13.onHoverState.IconLeftImage = Nothing
        Me.BunifuButton13.onHoverState.IconRightImage = Nothing
        Me.BunifuButton13.OnIdleState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnIdleState.BorderRadius = 10
        Me.BunifuButton13.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton13.OnIdleState.BorderThickness = 2
        Me.BunifuButton13.OnIdleState.FillColor = System.Drawing.Color.White
        Me.BunifuButton13.OnIdleState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnIdleState.IconLeftImage = Nothing
        Me.BunifuButton13.OnIdleState.IconRightImage = Nothing
        Me.BunifuButton13.OnPressedState.BorderColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnPressedState.BorderRadius = 10
        Me.BunifuButton13.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BunifuButton13.OnPressedState.BorderThickness = 2
        Me.BunifuButton13.OnPressedState.FillColor = System.Drawing.Color.White
        Me.BunifuButton13.OnPressedState.ForeColor = System.Drawing.Color.Black
        Me.BunifuButton13.OnPressedState.IconLeftImage = Nothing
        Me.BunifuButton13.OnPressedState.IconRightImage = Nothing
        Me.BunifuButton13.Size = New System.Drawing.Size(100, 30)
        Me.BunifuButton13.TabIndex = 2222291
        Me.BunifuButton13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuButton13.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BunifuButton13.TextMarginLeft = 0
        Me.BunifuButton13.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BunifuButton13.UseDefaultRadiusAndThickness = True
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.Label71, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.Label71, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Label71.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(822, 369)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(58, 19)
        Me.Label71.TabIndex = 21
        Me.Label71.Text = "Active"
        '
        'lblvariables
        '
        Me.lblvariables.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.lblvariables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblvariables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblvariables.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblvariables.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblvariables.Location = New System.Drawing.Point(887, 5)
        Me.lblvariables.Name = "lblvariables"
        Me.lblvariables.Size = New System.Drawing.Size(122, 17)
        Me.lblvariables.TabIndex = 64
        Me.lblvariables.Text = "Mostrar variables"
        Me.lblvariables.Visible = False
        '
        'checkvariables
        '
        Me.checkvariables.BaseColor = System.Drawing.SystemColors.Control
        Me.checkvariables.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.checkvariables.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(178, Byte), Integer), CType(CType(116, Byte), Integer))
        Me.BunifuTransition2.SetDecoration(Me.checkvariables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.checkvariables, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.checkvariables.FillColor = System.Drawing.Color.White
        Me.checkvariables.Location = New System.Drawing.Point(845, 2)
        Me.checkvariables.Name = "checkvariables"
        Me.checkvariables.Size = New System.Drawing.Size(40, 22)
        Me.checkvariables.TabIndex = 63
        Me.checkvariables.Visible = False
        '
        'btn_buzon
        '
        Me.btn_buzon.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.btn_buzon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.btn_buzon, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.btn_buzon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buzon.ForeColor = System.Drawing.Color.White
        Me.btn_buzon.Location = New System.Drawing.Point(113, 1)
        Me.btn_buzon.Name = "btn_buzon"
        Me.btn_buzon.Size = New System.Drawing.Size(190, 26)
        Me.btn_buzon.TabIndex = 2222225
        Me.btn_buzon.Text = "Buzon de Sugerencias"
        Me.btn_buzon.UseVisualStyleBackColor = False
        '
        'cierre_forzado
        '
        Me.cierre_forzado.Interval = 10000
        '
        'timer_ping_bd
        '
        Me.timer_ping_bd.Interval = 300000
        '
        'lblNom
        '
        Me.lblNom.AutoEllipsis = True
        Me.lblNom.AutoSize = True
        Me.BunifuTransition2.SetDecoration(Me.lblNom, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.lblNom, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.lblNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNom.Location = New System.Drawing.Point(309, 5)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(208, 18)
        Me.lblNom.TabIndex = 2222226
        Me.lblNom.Text = "federico.toro@corsan.com.co"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuTransition2.SetDecoration(Me.Guna2CirclePictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2CirclePictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = Global.Spic.My.Resources.Resources.m
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(21, 20)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(53, 48)
        Me.Guna2CirclePictureBox1.TabIndex = 2222227
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'guna2CustomGradientPanel1
        '
        Me.guna2CustomGradientPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.guna2CustomGradientPanel1.BorderRadius = 18
        Me.guna2CustomGradientPanel1.Controls.Add(Me.imgSlide3)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.imgSlide2)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.imgSlide1)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.pictureBox2)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.guna2Button5)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.guna2Button4)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.guna2Button3)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.guna2Button2)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.guna2Button1)
        Me.guna2CustomGradientPanel1.Controls.Add(Me.imgSlideH)
        Me.BunifuTransition2.SetDecoration(Me.guna2CustomGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2CustomGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2CustomGradientPanel1.Location = New System.Drawing.Point(12, 20)
        Me.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1"
        Me.guna2CustomGradientPanel1.Size = New System.Drawing.Size(87, 662)
        Me.guna2CustomGradientPanel1.TabIndex = 1
        '
        'imgSlide3
        '
        Me.BunifuTransition1.SetDecoration(Me.imgSlide3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.imgSlide3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.imgSlide3.Image = CType(resources.GetObject("imgSlide3.Image"), System.Drawing.Image)
        Me.imgSlide3.Location = New System.Drawing.Point(48, 315)
        Me.imgSlide3.Name = "imgSlide3"
        Me.imgSlide3.Size = New System.Drawing.Size(39, 101)
        Me.imgSlide3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSlide3.TabIndex = 2222230
        Me.imgSlide3.TabStop = False
        '
        'imgSlide2
        '
        Me.BunifuTransition1.SetDecoration(Me.imgSlide2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.imgSlide2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.imgSlide2.Image = CType(resources.GetObject("imgSlide2.Image"), System.Drawing.Image)
        Me.imgSlide2.Location = New System.Drawing.Point(48, 241)
        Me.imgSlide2.Name = "imgSlide2"
        Me.imgSlide2.Size = New System.Drawing.Size(39, 101)
        Me.imgSlide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSlide2.TabIndex = 2222229
        Me.imgSlide2.TabStop = False
        '
        'imgSlide1
        '
        Me.BunifuTransition1.SetDecoration(Me.imgSlide1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.imgSlide1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.imgSlide1.Image = CType(resources.GetObject("imgSlide1.Image"), System.Drawing.Image)
        Me.imgSlide1.Location = New System.Drawing.Point(48, 167)
        Me.imgSlide1.Name = "imgSlide1"
        Me.imgSlide1.Size = New System.Drawing.Size(39, 101)
        Me.imgSlide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSlide1.TabIndex = 2222228
        Me.imgSlide1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.BunifuTransition1.SetDecoration(Me.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pictureBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.pictureBox2.Location = New System.Drawing.Point(25, 20)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(45, 42)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'guna2Button5
        '
        Me.guna2Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.guna2Button5.BackColor = System.Drawing.Color.Transparent
        Me.guna2Button5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button5.BorderRadius = 24
        Me.guna2Button5.BorderThickness = 1
        Me.guna2Button5.CheckedState.BorderColor = System.Drawing.Color.White
        Me.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White
        Me.guna2Button5.CheckedState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.guna2Button5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2Button5, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2Button5.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guna2Button5.ForeColor = System.Drawing.Color.White
        Me.guna2Button5.Image = CType(resources.GetObject("guna2Button5.Image"), System.Drawing.Image)
        Me.guna2Button5.Location = New System.Drawing.Point(17, 605)
        Me.guna2Button5.Name = "guna2Button5"
        Me.guna2Button5.Size = New System.Drawing.Size(60, 50)
        Me.guna2Button5.TabIndex = 0
        Me.guna2Button5.UseTransparentBackground = True
        '
        'guna2Button4
        '
        Me.guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button4.BorderRadius = 24
        Me.guna2Button4.BorderThickness = 1
        Me.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.guna2Button4.CheckedState.BorderColor = System.Drawing.Color.White
        Me.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White
        Me.guna2Button4.CheckedState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.guna2Button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2Button4, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guna2Button4.ForeColor = System.Drawing.Color.White
        Me.guna2Button4.Image = CType(resources.GetObject("guna2Button4.Image"), System.Drawing.Image)
        Me.guna2Button4.Location = New System.Drawing.Point(23, 340)
        Me.guna2Button4.Name = "guna2Button4"
        Me.guna2Button4.Size = New System.Drawing.Size(60, 50)
        Me.guna2Button4.TabIndex = 0
        Me.guna2Button4.UseTransparentBackground = True
        '
        'guna2Button3
        '
        Me.guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button3.BorderRadius = 24
        Me.guna2Button3.BorderThickness = 1
        Me.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.guna2Button3.CheckedState.BorderColor = System.Drawing.Color.White
        Me.guna2Button3.CheckedState.FillColor = System.Drawing.Color.White
        Me.guna2Button3.CheckedState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.guna2Button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2Button3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guna2Button3.ForeColor = System.Drawing.Color.White
        Me.guna2Button3.Image = CType(resources.GetObject("guna2Button3.Image"), System.Drawing.Image)
        Me.guna2Button3.Location = New System.Drawing.Point(23, 266)
        Me.guna2Button3.Name = "guna2Button3"
        Me.guna2Button3.Size = New System.Drawing.Size(60, 50)
        Me.guna2Button3.TabIndex = 0
        Me.guna2Button3.UseTransparentBackground = True
        '
        'guna2Button2
        '
        Me.guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button2.BorderRadius = 24
        Me.guna2Button2.BorderThickness = 1
        Me.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.guna2Button2.CheckedState.BorderColor = System.Drawing.Color.White
        Me.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White
        Me.guna2Button2.CheckedState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.guna2Button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2Button2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guna2Button2.ForeColor = System.Drawing.Color.White
        Me.guna2Button2.Image = CType(resources.GetObject("guna2Button2.Image"), System.Drawing.Image)
        Me.guna2Button2.Location = New System.Drawing.Point(23, 192)
        Me.guna2Button2.Name = "guna2Button2"
        Me.guna2Button2.Size = New System.Drawing.Size(60, 50)
        Me.guna2Button2.TabIndex = 0
        Me.guna2Button2.UseTransparentBackground = True
        '
        'guna2Button1
        '
        Me.guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button1.BorderRadius = 24
        Me.guna2Button1.BorderThickness = 1
        Me.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.guna2Button1.Checked = True
        Me.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.White
        Me.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White
        Me.guna2Button1.CheckedState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.guna2Button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.guna2Button1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.guna2Button1.ForeColor = System.Drawing.Color.White
        Me.guna2Button1.Image = CType(resources.GetObject("guna2Button1.Image"), System.Drawing.Image)
        Me.guna2Button1.Location = New System.Drawing.Point(23, 122)
        Me.guna2Button1.Name = "guna2Button1"
        Me.guna2Button1.Size = New System.Drawing.Size(60, 50)
        Me.guna2Button1.TabIndex = 0
        Me.guna2Button1.UseTransparentBackground = True
        '
        'imgSlideH
        '
        Me.BunifuTransition1.SetDecoration(Me.imgSlideH, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.imgSlideH, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.imgSlideH.Image = CType(resources.GetObject("imgSlideH.Image"), System.Drawing.Image)
        Me.imgSlideH.Location = New System.Drawing.Point(48, 97)
        Me.imgSlideH.Name = "imgSlideH"
        Me.imgSlideH.Size = New System.Drawing.Size(39, 101)
        Me.imgSlideH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSlideH.TabIndex = 0
        Me.imgSlideH.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.BorderRadius = 2
        Me.Guna2ControlBox1.CustomIconSize = 20.0!
        Me.BunifuTransition2.SetDecoration(Me.Guna2ControlBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2ControlBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1317, 2)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox1.TabIndex = 2222227
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.lbl_db_corsan)
        Me.Guna2Panel1.Controls.Add(Me.lbl_db_produccion)
        Me.Guna2Panel1.Controls.Add(Me.lbl_db_control)
        Me.BunifuTransition2.SetDecoration(Me.Guna2Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2Panel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 692)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1364, 28)
        Me.Guna2Panel1.TabIndex = 2222228
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.BorderColor = System.Drawing.Color.White
        Me.Guna2Button6.BorderRadius = 24
        Me.Guna2Button6.BorderThickness = 1
        Me.Guna2Button6.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button6.CheckedState.BorderColor = System.Drawing.Color.White
        Me.Guna2Button6.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2Button6.CheckedState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.Guna2Button6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2Button6, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2Button6.FillColor = System.Drawing.Color.White
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.Location = New System.Drawing.Point(1073, 6)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(38, 35)
        Me.Guna2Button6.TabIndex = 2222232
        Me.Guna2Button6.UseTransparentBackground = True
        '
        'Guna2Button7
        '
        Me.Guna2Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button7.BorderColor = System.Drawing.Color.White
        Me.Guna2Button7.BorderRadius = 24
        Me.Guna2Button7.BorderThickness = 1
        Me.Guna2Button7.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.Guna2Button7.CheckedState.BorderColor = System.Drawing.Color.White
        Me.Guna2Button7.CheckedState.FillColor = System.Drawing.Color.White
        Me.Guna2Button7.CheckedState.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.BunifuTransition2.SetDecoration(Me.Guna2Button7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2Button7, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2Button7.FillColor = System.Drawing.Color.White
        Me.Guna2Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button7.ForeColor = System.Drawing.Color.White
        Me.Guna2Button7.Image = CType(resources.GetObject("Guna2Button7.Image"), System.Drawing.Image)
        Me.Guna2Button7.Location = New System.Drawing.Point(1114, 11)
        Me.Guna2Button7.Name = "Guna2Button7"
        Me.Guna2Button7.Size = New System.Drawing.Size(31, 26)
        Me.Guna2Button7.TabIndex = 2222231
        Me.Guna2Button7.UseTransparentBackground = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BackColor = System.Drawing.Color.White
        Me.BunifuTransition1.SetDecoration(Me.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.pictureBox1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.pictureBox1.Image = Global.Spic.My.Resources.Resources.enlaces_de_ejecutivo
        Me.pictureBox1.Location = New System.Drawing.Point(1151, 5)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(30, 39)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox1.TabIndex = 2222230
        Me.pictureBox1.TabStop = False
        '
        'SolidGaugeBindingSource1
        '
        Me.SolidGaugeBindingSource1.DataSource = GetType(LiveCharts.WinForms.SolidGauge)
        '
        'SolidGaugeBindingSource
        '
        Me.SolidGaugeBindingSource.DataSource = GetType(LiveCharts.WinForms.SolidGauge)
        '
        'BunifuLineChart
        '
        Me.BunifuLineChart.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.BunifuLineChart.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt
        Me.BunifuLineChart.BorderColor = System.Drawing.Color.White
        Me.BunifuLineChart.BorderDash = Nothing
        Me.BunifuLineChart.BorderDashOffset = 2.0R
        Me.BunifuLineChart.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Round
        Me.BunifuLineChart.BorderWidth = 2
        Me.BunifuLineChart.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Monotone
        Me.BunifuLineChart.Data = CType(resources.GetObject("BunifuLineChart.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuLineChart.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Start
        Me.BunifuLineChart.Label = "Seguimiento produccion anual"
        Me.BunifuLineChart.LineTension = 1.0R
        Me.BunifuLineChart.Order = 0
        Me.BunifuLineChart.PointBackgroundColor = System.Drawing.Color.White
        Me.BunifuLineChart.PointBorderColor = System.Drawing.Color.Empty
        Me.BunifuLineChart.PointBorderWidth = 1
        Me.BunifuLineChart.PointHitRadius = 1
        Me.BunifuLineChart.PointHoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuLineChart.PointHoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuLineChart.PointHoverBorderWidth = 10
        Me.BunifuLineChart.PointHoverRadius = 1
        Me.BunifuLineChart.PointRadius = 3
        Me.BunifuLineChart.PointRotation = 0
        Me.BunifuLineChart.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Rect
        Me.BunifuLineChart.ShowLine = True
        Me.BunifuLineChart.SpanGaps = True
        Me.BunifuLineChart.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.[False]
        Me.BunifuLineChart.TargetCanvas = Me.BunifuChartCanvas1
        '
        'BunifuTransition1
        '
        Me.BunifuTransition1.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.Leaf
        Me.BunifuTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 1.0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.BunifuTransition1.DefaultAnimation = Animation1
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.BorderRadius = 2
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.CustomIconSize = 20.0!
        Me.BunifuTransition2.SetDecoration(Me.Guna2ControlBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2ControlBox2, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1272, 3)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox2.TabIndex = 2222233
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.Animated = True
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.BorderRadius = 2
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.CustomIconSize = 20.0!
        Me.BunifuTransition2.SetDecoration(Me.Guna2ControlBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition1.SetDecoration(Me.Guna2ControlBox3, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(123, Byte), Integer))
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(1227, 2)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(39, 35)
        Me.Guna2ControlBox3.TabIndex = 2222234
        '
        'txtFilterToolIDs
        '
        Me.BunifuTransition1.SetDecoration(Me.txtFilterToolIDs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me.txtFilterToolIDs, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.txtFilterToolIDs.Location = New System.Drawing.Point(580, 17)
        Me.txtFilterToolIDs.Name = "txtFilterToolIDs"
        Me.txtFilterToolIDs.Size = New System.Drawing.Size(212, 21)
        Me.txtFilterToolIDs.TabIndex = 2222235
        '
        'F_V_anos_prodTableAdapter
        '
        Me.F_V_anos_prodTableAdapter.ClearBeforeFill = True
        '
        'BunifuLineChart1
        '
        Me.BunifuLineChart1.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.BunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt
        Me.BunifuLineChart1.BorderColor = System.Drawing.Color.White
        Me.BunifuLineChart1.BorderDash = Nothing
        Me.BunifuLineChart1.BorderDashOffset = 0R
        Me.BunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter
        Me.BunifuLineChart1.BorderWidth = 1
        Me.BunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.[Default]
        Me.BunifuLineChart1.Data = CType(resources.GetObject("BunifuLineChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Start
        Me.BunifuLineChart1.Label = "0"
        Me.BunifuLineChart1.LineTension = 0.4R
        Me.BunifuLineChart1.Order = 0
        Me.BunifuLineChart1.PointBackgroundColor = System.Drawing.Color.White
        Me.BunifuLineChart1.PointBorderColor = System.Drawing.Color.White
        Me.BunifuLineChart1.PointBorderWidth = 1
        Me.BunifuLineChart1.PointHitRadius = 1
        Me.BunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuLineChart1.PointHoverBorderWidth = 4
        Me.BunifuLineChart1.PointHoverRadius = 1
        Me.BunifuLineChart1.PointRadius = 3
        Me.BunifuLineChart1.PointRotation = 0
        Me.BunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.RectRounded
        Me.BunifuLineChart1.ShowLine = True
        Me.BunifuLineChart1.SpanGaps = False
        Me.BunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.[False]
        Me.BunifuLineChart1.TargetCanvas = Nothing
        '
        'BunifuBarChart1
        '
        Me.BunifuBarChart1.BackgroundColor = CType(resources.GetObject("BunifuBarChart1.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChart1.BorderColor = CType(resources.GetObject("BunifuBarChart1.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChart1.BorderSkipped = Nothing
        Me.BunifuBarChart1.BorderWidth = 0
        Me.BunifuBarChart1.Data = CType(resources.GetObject("BunifuBarChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuBarChart1.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuBarChart1.HoverBorderWidth = 0
        Me.BunifuBarChart1.Label = "Presupuesto"
        Me.BunifuBarChart1.TargetCanvas = Nothing
        '
        'BunifuPieChart1
        '
        Me.BunifuPieChart1.BackgroundColor = CType(resources.GetObject("BunifuPieChart1.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuPieChart1.BorderColor = CType(resources.GetObject("BunifuPieChart1.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuPieChart1.BorderWidth = 0
        Me.BunifuPieChart1.Data = CType(resources.GetObject("BunifuPieChart1.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuPieChart1.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuPieChart1.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuPieChart1.HoverBorderWidth = 0
        Me.BunifuPieChart1.Label = "Presupuesto"
        Me.BunifuPieChart1.TargetCanvas = Nothing
        '
        'BunifuBarChartppto
        '
        Me.BunifuBarChartppto.BackgroundColor = CType(resources.GetObject("BunifuBarChartppto.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChartppto.BorderColor = CType(resources.GetObject("BunifuBarChartppto.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChartppto.BorderSkipped = Nothing
        Me.BunifuBarChartppto.BorderWidth = 0
        Me.BunifuBarChartppto.Data = CType(resources.GetObject("BunifuBarChartppto.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuBarChartppto.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuBarChartppto.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuBarChartppto.HoverBorderWidth = 0
        Me.BunifuBarChartppto.Label = "Presupuesto"
        Me.BunifuBarChartppto.TargetCanvas = Me.BunifuChartCanvas3
        '
        'BunifuBarChartgasto
        '
        Me.BunifuBarChartgasto.BackgroundColor = CType(resources.GetObject("BunifuBarChartgasto.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChartgasto.BorderColor = CType(resources.GetObject("BunifuBarChartgasto.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.BunifuBarChartgasto.BorderSkipped = Nothing
        Me.BunifuBarChartgasto.BorderWidth = 0
        Me.BunifuBarChartgasto.Data = CType(resources.GetObject("BunifuBarChartgasto.Data"), System.Collections.Generic.List(Of Double))
        Me.BunifuBarChartgasto.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.BunifuBarChartgasto.HoverBorderColor = System.Drawing.Color.Empty
        Me.BunifuBarChartgasto.HoverBorderWidth = 0
        Me.BunifuBarChartgasto.Label = "Gasto"
        Me.BunifuBarChartgasto.TargetCanvas = Me.BunifuChartCanvas3
        '
        'BunifuTransition2
        '
        Me.BunifuTransition2.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.VertSlide
        Me.BunifuTransition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.BunifuTransition2.DefaultAnimation = Animation2
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1360, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFilterToolIDs)
        Me.Controls.Add(Me.Guna2ControlBox3)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Guna2Button7)
        Me.Controls.Add(Me.lblvariables)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.checkvariables)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.guna2CustomGradientPanel1)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.btn_buzon)
        Me.Controls.Add(Me.TabControl1)
        Me.BunifuTransition1.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.BunifuTransition2.SetDecoration(Me, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spic"
        Me.groupRutaCerrar.ResumeLayout(False)
        Me.groupRutaCerrar.PerformLayout
        Me.tab_men_ppal.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tab_men_prod.ResumeLayout(False)
        Me.panelPPTO.ResumeLayout(False)
        Me.panelPPTO.PerformLayout
        CType(Me.dtg_consumo_alambron, System.ComponentModel.ISupportInitialize).EndInit
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout
        CType(Me.BunifuPictureBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout
        CType(Me.FVanosprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PRGPRODUCCIONDataSet2, System.ComponentModel.ISupportInitialize).EndInit
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout
        CType(Me.bunitable, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dtd, System.ComponentModel.ISupportInitialize).EndInit
        Me.tab_men_gastos.ResumeLayout(False)
        Me.PanelGastos.ResumeLayout(False)
        Me.PanelGastos.PerformLayout
        Me.BunifuCards6.ResumeLayout(False)
        Me.BunifuCards6.PerformLayout
        CType(Me.BunifuPictureBox7, System.ComponentModel.ISupportInitialize).EndInit
        Me.groupDetalle.ResumeLayout(False)
        CType(Me.dtg_detalle, System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.BunifuPanel2.ResumeLayout(False)
        Me.BunifuPanel2.PerformLayout
        CType(Me.dtg_consulta, System.ComponentModel.ISupportInitialize).EndInit
        Me.menStripDtg.ResumeLayout(False)
        Me.BunifuCards5.ResumeLayout(False)
        Me.BunifuCards5.PerformLayout
        CType(Me.BunifuPictureBox6, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BunifuPictureBox5, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BunifuPictureBox4, System.ComponentModel.ISupportInitialize).EndInit
        Me.BunifuCards4.ResumeLayout(False)
        Me.BunifuCards4.PerformLayout
        CType(Me.BunifuPictureBox3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        Me.guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.imgSlide3, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgSlide2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgSlide1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgSlideH, System.ComponentModel.ISupportInitialize).EndInit
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SolidGaugeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SolidGaugeBindingSource, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(False)
        Me.PerformLayout

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents timNotificarCerrarAplicacion As System.Windows.Forms.Timer
    Friend WithEvents timCerrarApp As System.Windows.Forms.Timer
    Friend WithEvents lbl_db_corsan As System.Windows.Forms.Label
    Friend WithEvents lbl_db_produccion As System.Windows.Forms.Label
    Friend WithEvents lbl_db_control As System.Windows.Forms.Label
    Friend WithEvents autocierre As System.Windows.Forms.Timer
    Friend WithEvents groupRutaCerrar As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_noti As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrarGroup As System.Windows.Forms.Button
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents tab_men_ppal As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btn_buzon As System.Windows.Forms.Button
    Friend WithEvents cierre_forzado As System.Windows.Forms.Timer
    Friend WithEvents timer_ping_bd As System.Windows.Forms.Timer
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents lblNom As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Private WithEvents guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents imgSlideH As PictureBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents imgSlide3 As PictureBox
    Private WithEvents imgSlide2 As PictureBox
    Private WithEvents imgSlide1 As PictureBox
    Private WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents Guna2Button7 As Guna.UI2.WinForms.Guna2Button
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents panelPPTO As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GunaWinSwitch1 As Guna.UI.WinForms.GunaWinSwitch
    Private WithEvents Label42 As Label
    Friend WithEvents lblvariables As Guna.UI.WinForms.GunaLabel
    Friend WithEvents checkvariables As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents SolidGaugeBindingSource1 As BindingSource
    Friend WithEvents SolidGaugeBindingSource As BindingSource
    Friend WithEvents menStripDtg As ContextMenuStrip
    Friend WithEvents itemDetalle As ToolStripMenuItem
    Friend WithEvents PanelGastos As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dtg_consulta As DataGridView
    Private WithEvents Label71 As Label
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtgasto As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpresupuesto As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents groupDetalle As GroupBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents dtg_detalle As DataGridView
    Friend WithEvents tab_men_prod As TabPage
    Friend WithEvents tab_men_gastos As TabPage
    Friend WithEvents dtd As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Private WithEvents lblcentro As Label
    Private WithEvents lblllevamos As Label
    Private WithEvents lblpptoprod As Label
    Friend WithEvents BunifuCircleProgress1 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton11 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton10 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton9 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuSeparator1 As Bunifu.UI.WinForms.BunifuSeparator
    Private WithEvents Label27 As Label
    Private WithEvents Label26 As Label
    Friend WithEvents BunifuChartCanvas1 As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents BunifuLineChart As Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart
    Friend WithEvents BunifuCircleProgress2 As Bunifu.UI.WinForms.BunifuCircleProgress
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label6 As Label
    Private WithEvents lblllevamoscant As Label
    Private WithEvents lblptocantidad As Label
    Friend WithEvents bunitable As Bunifu.UI.WinForms.BunifuDataGridView
    Friend WithEvents cbo_ano_prod As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents cb_mes_prod As Bunifu.UI.WinForms.BunifuDropdown
    Private WithEvents Label4 As Label
    Private WithEvents Label5 As Label
    Friend WithEvents BunifuImageButton1 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuSeparator2 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Private WithEvents Label7 As Label
    Friend WithEvents BunifuPictureBox2 As Bunifu.UI.WinForms.BunifuPictureBox
    Private WithEvents Label9 As Label
    Private WithEvents Label8 As Label
    Friend WithEvents BunifuSeparator3 As Bunifu.UI.WinForms.BunifuSeparator
    Private WithEvents lbldiastrab As Label
    Private WithEvents lbldiasadd As Label
    Private WithEvents lbldiashabiles As Label
    Private WithEvents lblpkg As Label
    Private WithEvents lblpptopkg As Label
    Private WithEvents Label11 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents BunifuTransition1 As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents PRGPRODUCCIONDataSet2 As PRGPRODUCCIONDataSet2
    Friend WithEvents FVanosprodBindingSource As BindingSource
    Friend WithEvents F_V_anos_prodTableAdapter As PRGPRODUCCIONDataSet2TableAdapters.F_V_anos_prodTableAdapter
    Friend WithEvents dtg_consumo_alambron As Bunifu.UI.WinForms.BunifuDataGridView
    Private WithEvents Label12 As Label
    Friend WithEvents BunifuButton14 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton12 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton13 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton15 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton16 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton17 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton18 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton19 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton20 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton21 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton22 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton23 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton24 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton26 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton27 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton28 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton29 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton25 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuButton30 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuLineChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart
    Friend WithEvents BunifuBarChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents BunifuPictureBox3 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuCircleProgress3 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents BunifuPieChart1 As Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart
    Friend WithEvents BunifuChartCanvas3 As Bunifu.Charts.WinForms.BunifuChartCanvas
    Friend WithEvents BunifuBarChartppto As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents BunifuBarChartgasto As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents BunifuCards4 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuTransition2 As Bunifu.UI.WinForms.BunifuTransition
    Friend WithEvents BunifuCards5 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtgastocentro As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuCircleProgress4 As Bunifu.UI.WinForms.BunifuCircleProgress
    Friend WithEvents txtpptocentro As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents labelcentroppto As Guna.UI.WinForms.GunaLabel
    Private WithEvents Label13 As Label
    Private WithEvents Label14 As Label
    Friend WithEvents BunifuDropdown1 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents BunifuDropdown2 As Bunifu.UI.WinForms.BunifuDropdown
    Friend WithEvents BunifuImageButton2 As Bunifu.UI.WinForms.BunifuImageButton
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents BunifuPanel2 As Bunifu.UI.WinForms.BunifuPanel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuSeparator5 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuSeparator4 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpresupuestoprod As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpresupuestoadmin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuSeparator6 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuCards6 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtgastoprod As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel16 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtgastoadmin As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuSeparator7 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuSeparator8 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuSeparator9 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents GunaLabel20 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuPictureBox7 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuSeparator10 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents BunifuPictureBox5 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuPictureBox4 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuPictureBox6 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents BunifuSeparator11 As Bunifu.UI.WinForms.BunifuSeparator
    Friend WithEvents txtporcentajeinherente As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel21 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuRadialGauge1 As Bunifu.UI.WinForms.BunifuRadialGauge
    Friend WithEvents txttotcentro As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtFilterToolIDs As TextBox
    'Friend BunifuButton1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton
End Class
