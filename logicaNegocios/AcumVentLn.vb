﻿Imports accesoDatos
Imports entidadNegocios
Public Class AcumVentLn
    '****************************************************************************************************************
    'Se crean las instancias de las clases necesarias****************************************************************
    '****************************************************************************************************************
    Private objAcumVenAd As AcumVentAd

    Public Sub New()
        objAcumVenAd = New AcumVentAd
    End Sub

    Public Function ppalVent_old(ByVal min As Double, ByVal max As Double, ByVal mesIni As Double, ByVal añoIni As Double, ByVal mesFin As Double, ByVal añoFin As Double, ByVal criterio As String) As List(Of AcumVentEn)
        Return objAcumVenAd.Ppal(min, max, mesIni, añoIni, mesFin, añoFin, criterio)
    End Function
    Public Function obtenerTot(ByVal min As Double, ByVal max As Double, ByVal mesIni As Double, ByVal añoIni As Double, ByVal mesFin As Double, ByVal añoFin As Double, ByVal criterio As String) As Double
        Return objAcumVenAd.obtValTot(min, max, mesIni, añoIni, mesFin, añoFin, criterio)
    End Function
    Public Function ppalVent(ByVal min As Double, ByVal max As Double, ByVal mesIni As Double, ByVal añoIni As Double, ByVal mesFin As Double, ByVal añoFin As Double, ByVal criterio As String, ByVal vendedores As String, ByVal vend_hoy As Boolean) As DataTable
        Return objAcumVenAd.listar_consulta(min, max, mesIni, añoIni, mesFin, añoFin, criterio, vendedores, vend_hoy)
    End Function

End Class
