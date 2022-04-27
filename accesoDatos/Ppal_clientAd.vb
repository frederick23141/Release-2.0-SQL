Imports System.Data.SqlClient
Public Class Ppal_clientAd
    Private conn As New SqlConnection
    Public Function listar_datatable(ByVal cadena As String) As DataTable
        Dim objConexion As New Conexion
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(cadena, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function

End Class
