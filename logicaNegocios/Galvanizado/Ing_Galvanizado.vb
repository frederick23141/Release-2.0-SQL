Imports accesoDatos
Imports entidadNegocios
Public Class Ing_Galvanizado

    Private obj_Ing_prodLn As New Ing_prodLn

    Public Function ConsultarRef_22B_Activas() As DataTable
        Dim Sql = "select *  from referencias where codigo like '22B%' AND ref_anulada = 'N'  "
        Return obj_Ing_prodLn.listar_datatable(Sql, "CORSAN")
    End Function

    Public Function ConsultarDestinoGalv() As DataTable
        Dim sql = "select id,descripcion from J_destino_galv"
        Return obj_Ing_prodLn.listar_datatable(Sql, "CORSAN")
    End Function

    Public Function ConsultarDatosPersonal() As DataTable
        Dim sql = "SELECT nit,nombres FROM V_nom_personal_Activo_con_maquila WHERE   nit in (select nit from control.dbo.D_empleados_sin_salida) and centro_planta = 5200  order by nombres"
        Return obj_Ing_prodLn.listar_datatable(sql, "CORSAN")
    End Function

End Class
