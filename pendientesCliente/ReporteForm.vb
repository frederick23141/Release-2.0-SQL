Imports entidadNegocios
Imports logicaNegocios
Imports accesoDatos
Imports System.Data.SqlClient

Public Class ReporteForm

    Private dt_linea As New DataTable
    Dim varconex As New SqlConnection(My.Settings.CORSANConnectionString)
    Public MiReporte As Object
    Public Adaptador As SqlDataAdapter



    Private objOpSimplesLn As New Op_simpesLn
    Dim frm As New MainForm
    Private MainForms As New MainForm


    Dim mun_inf As String = MainForms.txtpedinf.Text
    Dim mun_sup As String = MainForms.txtpedsup.Text
    Dim ref_inf As String = MainForms.txtrefinf.Text
    Dim ref_sup As String = MainForms.txtrefsup.Text
    Dim vend_inf As String = MainForms.txtvendinf.Text
    Dim vend_sup As String = MainForms.txtvendsup.Text
    Dim nit_inf As String = MainForms.txtnitinf.Text
    Dim nit_sup As String = MainForms.txtnitsup.Text
    Dim fecha_inf As String = ""
    Dim fecha_sup As String = ""

    Private Sub ReporteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim DS As New DataTable
        Dim DA As New SqlDataAdapter("SELECT documentos_lin_ped.codigo, documentos_lin_ped.cantidad, documentos_lin_ped.cantidad_despachada, referencias.descripcion, documentos_ped.bodega, documentos_ped.numero, documentos_ped.nit, 
                                         documentos_ped.vendedor, documentos_ped.fecha, documentos_ped.fecha_hora, documentos_ped.notas, documentos_ped.usuario, documentos_ped.pc, documentos_ped.documento, documentos_ped.autorizacion, 
                                         documentos_ped.autoriz_texto, documentos_ped.nota1, terceros.nombres, terceros.direccion, terceros.ciudad, terceros.telefono_1, terceros.bloqueo, terceros.concepto_4, condiciones_pago.descripcion AS cond_pago, 
                                         V_Ptes_Nro_autorizado.fecha AS Fecha_Auto
                FROM            documentos_lin_ped AS documentos_lin_ped INNER JOIN
                                         v_referencias_sto AS v_referencias_sto ON documentos_lin_ped.codigo = v_referencias_sto.codigo LEFT OUTER JOIN
                                         documentos_ped AS documentos_ped ON documentos_lin_ped.bodega = documentos_ped.bodega AND documentos_lin_ped.numero = documentos_ped.numero LEFT OUTER JOIN
                                         referencias AS referencias ON documentos_lin_ped.codigo = referencias.codigo INNER JOIN
                                         condiciones_pago AS condiciones_pago ON documentos_ped.condicion = condiciones_pago.condicion LEFT OUTER JOIN
                                         V_Ptes_Nro_autorizado AS V_Ptes_Nro_autorizado ON documentos_ped.numero = V_Ptes_Nro_autorizado.pedido INNER JOIN
                                         terceros AS terceros ON documentos_ped.nit = terceros.nit 
        WHERE  (documentos_ped.autorizacion <> 'N') and (documentos_ped.numero Between '" & mun_inf & "' and '" & mun_sup & "')  and (documentos_lin_ped.codigo Between '" & ref_inf & "' And '" & ref_sup & "') and (documentos_ped.vendedor Between '" & vend_inf & "' and '" & vend_sup & "') and (documentos_ped.nit Between '" & nit_inf & "' and '" & nit_sup & "')  and ( documentos_ped.fecha Between ' " & fecha_inf & "' and '" & fecha_sup & " 23:59:59'  )
        GROUP BY documentos_lin_ped.codigo, documentos_lin_ped.cantidad, documentos_lin_ped.cantidad_despachada, referencias.descripcion, documentos_ped.bodega, documentos_ped.numero, documentos_ped.nit, 
                                         documentos_ped.vendedor, documentos_ped.fecha, documentos_ped.fecha_hora, documentos_ped.notas, documentos_ped.usuario, documentos_ped.pc, documentos_ped.documento, documentos_ped.autorizacion, 
                                         documentos_ped.autoriz_texto, documentos_ped.nota1, terceros.nombres, terceros.direccion, terceros.ciudad, terceros.telefono_1, terceros.bloqueo, terceros.concepto_4, condiciones_pago.descripcion, 
                                         V_Ptes_Nro_autorizado.fecha 
        ORDER BY terceros.ciudad, terceros.nombres, documentos_ped.numero, documentos_lin_ped.codigo", varconex)
        DA.Fill(DS)
        Dim MiReporteb As New ReportePendientes
        Try
            MiReporteb.Refresh()
            MiReporteb.SetDataSource(DS)
            MiReporteb.Refresh()
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = MiReporteb
            Show()
            Refresh()
        Catch ex As Exception
            MessageBox.Show("no se ha completado " & Err.Description)
        End Try
    End Sub

    Public Sub criterios(ByVal num_i As String, ByVal num_s As String, ByVal ref_i As String, ByVal ref_s As String, ByVal vend_i As String, ByVal vend_s As String, ByVal nit_i As String, ByVal nit_s As String, ByVal fecha_i As String, ByVal fecha_s As String)

        mun_inf = num_i
        mun_sup = num_s
        ref_inf = ref_i
        ref_sup = ref_s
        vend_inf = vend_i
        vend_sup = vend_s
        nit_inf = nit_i
        nit_sup = nit_s
        fecha_inf = fecha_i
        fecha_sup = fecha_s

    End Sub

End Class