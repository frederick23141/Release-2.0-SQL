Imports entidadNegocios
Imports logicaNegocios
Imports accesoDatos
Imports System.Data.SqlClient

Public Class MainForm

    Private dt_linea As New DataTable
    Dim varconex As New SqlConnection(My.Settings.CORSANConnectionString)
    Public MiReporte As Object
    Public Adaptador As SqlDataAdapter
    Public where_informe As String = " "

    Private objOpSimplesLn As New Op_simpesLn

    Private Sub BunifuButton1_Click(sender As Object, e As EventArgs) Handles BunifuButton1.Click

        If (txtpedinf.Text <> "" And txtpedsup.Text <> "" And txtrefinf.Text <> "" And txtrefsup.Text <> "" And txtvendinf.Text <> "" And
            txtvendsup.Text <> "" And txtnitinf.Text <> "" And txtnitsup.Text <> "" And dateinf.Value.ToString <> "" And datesup.Value.ToString <> "") Then


            where_informe = " where (documentos_ped.numero Between '" & txtpedinf.Text & "' and '" & txtpedsup.Text & "') " &
                " and (documentos_lin_ped.codigo Between '" & txtrefinf.Text & "' And '" & txtrefsup.Text & "')  " &
                " and (documentos_ped.vendedor Between '" & txtvendinf.Text & "' and '" & txtvendsup.Text & "') " &
                " and (documentos_ped.nit Between '" & txtnitinf.Text & "' and '" & txtnitsup.Text & "') "


            '
            Dim fecha_inf As String = objOpSimplesLn.cambiarFormatoFecha(Convert.ToDateTime(dateinf.Value))
            Dim fecha_sup As String = objOpSimplesLn.cambiarFormatoFecha(Convert.ToDateTime(datesup.Value))

            Dim MiForm As New ReporteForm
            MiForm.criterios(txtpedinf.Text, txtpedsup.Text, txtrefinf.Text, txtrefsup.Text, txtvendinf.Text, txtvendsup.Text, txtnitinf.Text, txtnitsup.Text, fecha_inf, fecha_sup)
            MiForm.Show()
        Else
            ''mensaje de faltan datos
            BunifuSnackbar1.Show(Me,
            "Ningun campo debe estar vacio.... validar los datos",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error,
             3000, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter)

        End If


    End Sub

    Private Sub txtpedsup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpedsup.KeyDown
        If e.KeyCode = Keys.F4 Then
            txtpedsup.Text = txtpedinf.Text
        End If
    End Sub

    Private Sub txtrefsup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtrefsup.KeyDown
        If e.KeyCode = Keys.F4 Then
            txtrefsup.Text = txtrefinf.Text
        End If
    End Sub

    Private Sub txtvendsup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtvendsup.KeyDown
        If e.KeyCode = Keys.F4 Then
            txtvendsup.Text = txtvendinf.Text
        End If
    End Sub

    Private Sub txtnitsup_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnitsup.KeyDown
        If e.KeyCode = Keys.F4 Then
            txtnitsup.Text = txtnitinf.Text
        End If
    End Sub
End Class