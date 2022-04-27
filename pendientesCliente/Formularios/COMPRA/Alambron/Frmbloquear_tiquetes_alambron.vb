Imports logicaNegocios
Public Class Frmbloquear_tiquetes_alambron
    Dim objTraslado_bodLn As New traslado_bodLn
    Private obj_Ing_prodLn As New Ing_prodLn
    Private objOpSimplesLn As New Op_simpesLn


    Private Sub txtCodigoLector_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoLector.Enter
        txtCodigoLector.BackColor = Color.Green
        txtCodigoLector.Text = ""
    End Sub

    Private Sub txtCodigoLector_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigoLector.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            txtCodigoLector.Text = Replace(txtCodigoLector.Text, "'", "-")
            validar_rollo()
        ElseIf e.KeyChar = "." Then
            e.KeyChar = "-"
        End If
    End Sub

    Private Sub txtCodigoLector_Leave(sender As Object, e As EventArgs) Handles txtCodigoLector.Leave
        txtCodigoLector.BackColor = Color.Red
    End Sub

    Private Sub validar_rollo()
        Dim nit_proveedor As String = objTraslado_bodLn.extraerDatoCodigoBarrasAlambron("nit_proveedor", txtCodigoLector.Text)
        Dim num_importacion As String = objTraslado_bodLn.extraerDatoCodigoBarrasAlambron("num_importacion", txtCodigoLector.Text)
        Dim id_solicitud_det As String = objTraslado_bodLn.extraerDatoCodigoBarrasAlambron("id_solicitud_det", txtCodigoLector.Text)
        Dim numero_rollo As String = objTraslado_bodLn.extraerDatoCodigoBarrasAlambron("numero_rollo", txtCodigoLector.Text)

        Dim sql As String = "delete  from dbo.J_alambron_importacion_det_rollos " &
                             "WHERE (nit_proveedor = " & nit_proveedor & ") AND (num_importacion = " & num_importacion & ") AND (id_solicitud_det = " & id_solicitud_det & " and numero_rollo = " & numero_rollo & ")"
        If (objOpSimplesLn.ejecutar(sql, "PRODUCCION")) Then
            BunifuSnackbar1.Show(Me, "Tiquete de alambron inhabilitado de forma exitosa.",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 500, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.TopLeft,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner)
            txtCodigoLector.Text = ""
        Else
            BunifuSnackbar1.Show(Me, "ERROR AL INHABILITAR EL TIQUETE DE ALAMBRON",
            Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 500, "",
            Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter,
            Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner)
            txtCodigoLector.Text = ""
        End If


    End Sub

End Class