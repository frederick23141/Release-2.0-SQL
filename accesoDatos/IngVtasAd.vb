Imports System.Data.SqlClient
Imports entidadNegocios
Public Class ingVtasAd
    Private conn As New SqlConnection
    Private comando As SqlCommand
    Dim objConexion As New Conexion
    Dim objAnalisisPresEn As New AnalisisPresEn
    Dim objOperacionesDb As New OperacionesDb
    Public Function clientDisponible(ByVal nit As Long, ByVal vend As Double) As Boolean
        comando = New SqlCommand
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.BigInt).Value = nit
        comando.Parameters.Add("@vend", SqlDbType.Int).Value = vend
        sql = "select vendedor  from V_pendientes_por_vendedor where nit = @nit and vendedor = @vend"
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                Return True
            End If
        End If
        comando.Cancel()
        reader.Close()
        comando.CommandType = CommandType.Text
        comando.Connection = conn
        sql = "select vendedor from terceros where nit = " & nit & " and vendedor = " & vend & ""
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                Return True
            End If
        End If
        conn.Close()
        Return False
    End Function
    Public Function listarRef(ByVal strSql As String) As DataTable
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(strSql, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function

    Public Function infoCliente(ByVal nit As Double) As Object()
        Dim vec_datos(7) As Object
        comando = New SqlCommand
        Dim reader As SqlDataReader
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.BigInt).Value = nit
        Dim sql As String = "select nombres ,bloqueo, (SELECT   SUM (saldo)FROM V_cartera_edades_jjv  where nit= @nit and Saldo <>0 )as cartera,(Select Cheques_Dev  from V_SALDO_TER2 where Nit= @nit)as cheq_dev,condicion,(SELECT   SUM (saldo)FROM V_cartera_edades_jjv  where nit= @nit and Saldo <>0 and Dias_Vencido>10)as carteraVenc FROM  terceros WHERE nit = @nit"
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
                vec_datos(0) = ""
            Else
                vec_datos(0) = reader(0)
            End If
            If IsDBNull(reader(1)) Then
                vec_datos(1) = 0
            Else
                vec_datos(1) = reader(1)
            End If
            If IsDBNull(reader(2)) Then
                vec_datos(2) = 0
            Else
                vec_datos(2) = reader(2)
            End If
            If IsDBNull(reader(3)) Then
                vec_datos(3) = 0
            Else
                vec_datos(3) = reader(3)
            End If
            If IsDBNull(reader("condicion")) Then
                vec_datos(3) = 0
            Else
                vec_datos(6) = reader("condicion")
            End If
            If IsDBNull(reader("carteraVenc")) Then
                vec_datos(7) = 0
            Else
                vec_datos(7) = reader("carteraVenc")
            End If
        End If
        comando.Cancel()
        reader.Close()
        comando.CommandType = CommandType.Text
        comando.Connection = conn
        sql = "SELECT distinct codigo,Valor_total ,cupo_credito   FROM  V_pendientes_por_vendedor   where nit = @nit"
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        While (reader.Read)
            If IsDBNull(reader(1)) Then
                vec_datos(4) = 0
            Else
                vec_datos(4) += reader(1)
            End If
            If IsDBNull(reader(2) Or reader(2) <= 0) Then
                vec_datos(5) = cupo_alternativo(nit)
            Else
                vec_datos(5) = reader(2)
            End If

        End While
        comando.Dispose()
        reader.Close()
        vec_datos(5) = cupo_alternativo(nit)

        conn.Close()
        Return vec_datos
    End Function
    Public Function listar_clientes(ByVal strSQL As String) As DataTable
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(strSQL, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function cupo_alternativo(ByVal nit As Double) As Double
        Dim comando1 As SqlCommand
        comando1 = New SqlCommand
        Dim resp As Double = 0
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando1.CommandType = CommandType.Text
        ' conn = objConexion.abrirConexion
        comando1.Connection = conn
        comando1.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        sql = "SELECT cupo_credito FROM terceros where nit= @nit"
        comando1.CommandText = (sql)
        reader = comando1.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                resp = reader(0)
            End If
        End If
        conn.Close()
        Return resp
    End Function
    Public Function descProd(ByVal ref As String) As String
        comando = New SqlCommand
        Dim desc As String = ""
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@ref", SqlDbType.VarChar).Value = ref
        sql = "SELECT descripcion " & _
                 "FROM Referencias " & _
                 "WHERE codigo =@ref AND ref_anulada ='N'"
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                desc = reader(0)
            End If
        End If
        conn.Close()
        Return desc
    End Function
    Public Function consec_ult_ped() As Integer
        Dim consec As Integer
        comando = New SqlCommand
        Dim reader As SqlDataReader
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.CommandText = ("SELECT MAX(siguiente) AS Mayor " & _
                                  "FROM consecutivos  " & _
                                          "WHERE tipo = 'ZPE1'")
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                consec = reader(0)
            End If
        End If
        conn.Close()
        Return consec
    End Function
    Public Function precio_min_vta(ByVal cod As String) As Double
        Dim precio As Double = 0
        comando = New SqlCommand
        Dim reader As SqlDataReader
        Dim sql As String = "select Precio_min_cor " & _
                                  "from referencias  " & _
                                          "where codigo = @codigo "
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                precio = reader(0)
            End If
        End If
        conn.Close()
        Return precio
    End Function
    Public Function costoProducto(ByVal cod As String) As Double
        Dim precio As Double = 0
        comando = New SqlCommand
        Dim reader As SqlDataReader
        Dim sql As String = "select costo_unitario " & _
                                  "from referencias  " & _
                                          "where codigo = @codigo "
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                precio = reader(0)
            End If
        End If
        conn.Close()
        Return precio
    End Function
    Public Function precio_lista(ByVal cod As String, ByVal lista As String) As Double
        Dim precio As Double = 0
        Dim lista_precio As String = ""
        comando = New SqlCommand
        Dim reader As SqlDataReader
        Select Case lista
            Case "1"
                lista_precio = "precio_1"
            Case "2"
                lista_precio = "precio_2"
            Case "3"
                lista_precio = "precio_3"
            Case "4"
                lista_precio = "precio_4"
            Case "5"
                lista_precio = "precio_5"
            Case "6"
                lista_precio = "precio_6"
        End Select
        If lista_precio <> "" Then
            Dim sql As String = "select " & lista_precio & "" & _
                                      " from referencias_pre  " & _
                                              "where codigo = @codigo "
            comando.CommandType = CommandType.Text
            conn = objConexion.abrirConexion
            comando.Connection = conn
            comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod
            comando.CommandText = (sql)
            reader = comando.ExecuteReader
            If (reader.Read) Then
                If IsDBNull(reader(0)) Then
                Else
                    precio = reader(0)
                End If
            End If
            conn.Close()
        End If
        Return precio
    End Function
    Public Function doc_ven(ByVal nit As Double) As String
        comando = New SqlCommand
        Dim resp As String = ""
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        sql = ("SELECT     nit FROM  V_Doc_Vencidos where Dias_Vencido >10 and Nit = @nit")
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                conn.Close()
                Return "V"
            End If
        End If
        conn.Close()
        Return ""
    End Function
    Public Function insertar(ByVal Sql As String) As Integer
        Try
            conn = objConexion.abrirConexion
            Dim comando1 As New System.Data.SqlClient.SqlCommand
            comando1.CommandType = System.Data.CommandType.Text
            comando1.Connection = conn
            comando1.CommandText = Sql
            Return (comando1.ExecuteNonQuery())
        Catch ex As Exception
            MsgBox(ex.Message.ToString & "error")
        Finally

        End Try
        conn.Close()
        Return 0
    End Function
    Public Function get_condicion(ByVal nit As String) As String
        comando = New SqlCommand
        Dim resp As String = ""
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        sql = ("SELECT condicion FROM Terceros where nit = @nit")
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                resp = (reader(0))
            End If
        End If
        conn.Close()
        Return resp
    End Function
    Public Function update(ByVal sql As String) As Integer
        Dim resp As Integer = 0
        Try
            conn = objConexion.abrirConexion
            Dim comando1 As New System.Data.SqlClient.SqlCommand
            comando1.CommandType = System.Data.CommandType.Text
            comando1.Connection = conn
            comando1.CommandText = sql
            resp = comando1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString & "error")
        Finally
        End Try
        conn.Close()
        Return resp
    End Function
    Public Sub eliminar(ByVal sql As String)
        conn = objConexion.abrirConexion
        Dim comando1 As New System.Data.SqlClient.SqlCommand
        comando1.CommandType = System.Data.CommandType.Text
        comando1.Connection = conn
        comando1.CommandText = sql
        comando1.ExecuteNonQuery()
        conn.Close()
    End Sub


    Public Function cons_bloqueo(ByVal nit As Double) As Integer
        comando = New SqlCommand
        Dim resp As Integer = 0
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        sql = ("SELECT bloqueo FROM Terceros where nit = @nit")
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                resp = (reader(0))
            End If
        End If
        conn.Close()
        Return resp
    End Function
    Public Function ingresar_no_reflej(ByVal numero As Double, ByVal notas_aut As String) As Boolean
        Dim listSql As New List(Of Object)
        Dim resp As Boolean = True
        Dim sw = 1
        Dim bodega As Integer
        Dim nit As Double
        Dim condicion As String = ""
        Dim dias_validez As Integer
        Dim tot_neto As Double
        Dim strUsuario As String = ""
        Dim strPC As String = ""
        Dim Sql As String
        Dim vendedor As Integer
        Dim fecha As String = ""
        Dim dateFec As String = ""
        Dim notas As String = ""
        Dim compromiso As String = ""
        Dim nota5 As String = ""
        Dim nota_vta As String = ""
        'Dim nuevo_numero As Double = consec_ult_ped() + 1
        Dim i As Integer = 0
        'update_consec("UPDATE consecutivos " & _
        '          "SET siguiente = " & nuevo_numero & " " & _
        '          "WHERE tipo = 'ZPE1'")
        comando = New SqlCommand
        Dim reader As SqlDataReader
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        '  comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero

        Sql = ("SELECT     sw, bodega, nit, vendedor, fecha, condicion, " & _
                           " dias_validez, descuento_pie, valor_total, " & _
                            "fecha_hora, usuario, pc, duracion, anulado, nit2,notas,notas_aut,notas5,nota_vta " & _
                             "FROM JJV_documentos_ped where numero = " & numero & " ")
        comando.CommandText = (Sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                sw = reader("sw")
                bodega = reader("bodega")
                nit = reader("nit")
                vendedor = reader("vendedor")
                'fecha = fecha & " 00:00:00:500 am"
                fecha = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                dateFec = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                condicion = reader("condicion")
                dias_validez = reader("dias_validez")
                tot_neto = reader("valor_total")
                strUsuario = reader("usuario")
                strPC = reader("pc")
                notas = reader("notas")
                If Not IsDBNull(reader("notas5")) Then
                    nota5 = reader("notas5")
                End If
                If Not IsDBNull(reader("nota_vta")) Then
                    nota_vta = reader("nota_vta")
                End If
                If Not IsDBNull(reader("notas_aut")) Then
                    compromiso = reader("notas_aut")
                End If

            End If
        End If
        conn.Close()
        Sql = "INSERT INTO documentos_ped (sw, bodega, " & _
                  "             numero, nit, vendedor, fecha, condicion, " & _
                  "             dias_validez, descuento_pie, valor_total, " & _
                  "             fecha_hora, usuario, pc, duracion, anulado, nit2,notas,notas_aut,autorizacion,fecha_ingreso,notas5,nota_vta) " & _
                  "VALUES(" & sw & ", " & bodega & ", " & _
                              numero & ", " & nit & ", " & _
                              vendedor & ", GETDATE(),'" & condicion & "', " & _
                              dias_validez & ", 0, " & tot_neto & ",'" & dateFec & "','" & _
                                strUsuario & "', '" & strPC & "', 100, 0, " & nit & ", '" & notas & "','" & notas_aut & "','S','" & dateFec & "','" & nota5 & "','" & nota_vta & "' )"
        listSql.Add(Sql)
        comando.Cancel()
        reader.Close()
        Sql = "SELECT   sw, bodega, numero, codigo, seq,  " & _
       " cantidad, valor_unitario, " & _
        "cantidad_despachada, porcentaje_iva, porcentaje_descuento, und, cantidad_und, " & _
        " despacho_virtual, porc_dcto_2, porc_dcto_3 " & _
         "                 FROM JJV_documentos_lin_ped  where numero =" & numero
        comando.CommandText = (Sql)
        conn = objConexion.abrirConexion
        comando.Connection = conn
        reader = comando.ExecuteReader
        While (reader.Read)
            If IsDBNull(reader(0)) Then
            Else
                Sql = "INSERT INTO documentos_lin_ped " & _
                         "(sw, bodega, numero, codigo, seq, " & _
                         " cantidad, valor_unitario, " & _
                         " cantidad_despachada, porcentaje_iva, porcentaje_descuento, und, cantidad_und, " & _
                         " despacho_virtual, porc_dcto_2, porc_dcto_3) " & _
                         "VALUES(" & sw & ", " & bodega & ", " & numero & ", '" & _
                                     reader("codigo") & "', " & i & ", " & _
                                    reader("cantidad") & ", " & _
                                      reader("valor_unitario") & ", 0, 19, 0, 'UND', 1, " & _
                                       reader("cantidad") & ", 0, 0)"
                listSql.Add(Sql)
            End If
            i += 1
        End While

        conn.Close()
        resp = objOperacionesDb.ExecuteSqlTransaction(listSql)
        Return resp
    End Function
    Public Function anular_no_reflej(ByVal numero As Integer) As Integer
        Dim resp As Integer = 0
        Try
            conn = objConexion.abrirConexion
            Dim comando1 As New System.Data.SqlClient.SqlCommand
            comando1.CommandType = System.Data.CommandType.Text
            comando1.Connection = conn
            Dim stringSql As String = "UPDATE JJV_documentos_ped SET anulado =  1 where numero = " & numero
            comando1.CommandText = stringSql
            resp = comando1.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message.ToString & "error")
            MsgBox("Error desde el update de autorizar")
        Finally
        End Try
        conn.Close()
        Return resp
    End Function
    Public Function listarDatos(ByVal sql As String) As DataTable
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(sql, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function listar_info_ptes(ByVal sql As String) As DataTable
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(sql, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function listar_ptes_problema(ByVal sql As String) As DataTable
        conn = objConexion.abrirConexion
        Dim dt As New DataTable
        Dim DA As New SqlDataAdapter(sql, conn)
        DA.Fill(dt)
        conn.Close()
        Return dt
    End Function
    Public Function vr_total_problem(ByVal min As Integer, ByVal max As Integer) As Integer
        comando = New SqlCommand
        Dim reader As SqlDataReader
        Dim sql As String = ""
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@min", SqlDbType.VarChar).Value = min
        comando.Parameters.Add("@max", SqlDbType.VarChar).Value = max
        sql = ("SELECT SUM (valor_total) FROM JJV_documentos_ped WHERE anulado =0 AND vendedor >= @min and vendedor <= @max")
        comando.CommandText = (sql)
        reader = comando.ExecuteReader
        If (reader.Read) Then
            If IsDBNull(reader(0)) Then
            Else
                Return (reader(0))
            End If
        End If
        conn.Close()
        Return 0
    End Function
    Public Function existePedido(ByVal nit As Double, ByVal numero As Double) As Boolean
        Dim reader As SqlDataReader
        Dim comando1 As New SqlCommand
        comando1.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando1.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        comando1.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
        comando1.Connection = conn
        comando1.CommandText = "SELECT nit FROM documentos_lin WHERE nit =@nit and numero = @numero "
        reader = comando1.ExecuteReader
        If (reader.Read) Then
            conn.Close()
            Return True
        End If
        conn.Close()
        Return False
    End Function
    Public Function existeFact(ByVal nit As Double, ByVal numero As Double) As Boolean
        comando = New SqlCommand
        Dim reader As SqlDataReader
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
        comando.CommandText = "SELECT nit FROM documentos WHERE nit =@nit and numero = @numero "
        reader = comando.ExecuteReader
        If (reader.Read) Then
            conn.Close()
            Return True
        End If
        conn.Close()
        Return False
    End Function
    Public Function existeConsecutivo(ByVal numero As Double) As Boolean
        comando = New SqlCommand
        Dim reader As SqlDataReader
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@numero", SqlDbType.VarChar).Value = numero
        comando.CommandText = "SELECT consecutivo " & _
                                    "FROM Jjv_compromisos " & _
                                            "WHERE consecutivo = @numero "
        reader = comando.ExecuteReader

        If (reader.Read) Then
            conn.Close()
            Return True
        End If
        conn.Close()
        Return False
    End Function
    Public Function mov_180_dias(ByVal nit As Integer) As Boolean
        comando = New SqlCommand
        Dim fec As Date = DateAdd("m", -6, Now.Date)
        'Dim fecha As String = fec.Year & " - " & fec.Month & " - " & fec.Day
        Dim fecha As String = fec.Year & " - " & fec.Month & " - " & fec.Day
        Dim resp As Boolean = False
        Dim reader As SqlDataReader
        Dim sql As String
        comando.CommandType = CommandType.Text
        conn = objConexion.abrirConexion
        comando.Connection = conn
        comando.Parameters.Add("@nit", SqlDbType.VarChar).Value = nit
        sql = "SELECT nit FROM documentos  WHERE  nit = @nit AND sw = 1 AND fecha >='" & fecha & "'"
        comando.CommandText = sql
        reader = comando.ExecuteReader

        If (reader.Read) Then
            resp = True
        End If
        conn.Close()
        Return resp
    End Function


End Class
