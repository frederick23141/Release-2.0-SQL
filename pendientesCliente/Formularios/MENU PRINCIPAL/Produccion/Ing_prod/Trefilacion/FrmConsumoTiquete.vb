Imports accesoDatos
Imports logicaNegocios

Public Class FrmConsumoTiquete



    Private objOpSimplesLn As New Op_simpesLn
    Private conn As New Conexion

    Dim cod_orden As String
    Dim id_detalle As String
    Dim id_rollo As String

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click

        If (txt_Cod_orden.Text = "" Or txt_id_detalle.Text = "" Or txt_id_rollo.Text = "") Then

            MessageBox.Show("Eror al procesar la solicitud, todos los campos deben ser diligenciados.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            cod_orden = txt_Cod_orden.Text
            id_detalle = txt_id_detalle.Text
            id_rollo = txt_id_rollo.Text

            conn.abrirConexion_prod()

            Dim sql As String = "UPDATE J_rollos_tref SET srec = '1' WHERE cod_orden = " & cod_orden & " and id_detalle = " & id_detalle & " and id_rollo = " & id_rollo & " and srec is null "
            If (objOpSimplesLn.ejecutar(sql, "PRODUCCION")) Then
                MessageBox.Show("Información actualizada en forma exitosa", "Correcto!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_Cod_orden.Text = ""
                txt_id_detalle.Text = ""
                txt_id_rollo.Text = ""
            Else
                MessageBox.Show("Eror al actualizar, el tiquete ya fue consumido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
End Class