Public Class Frmprincipal
    Dim dts As New DataTable
    Dim dtspantallas As New DataTable

    Dim tiempo_espera As Integer

    Private Sub Frmprincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargar()
        End If
    End Sub

    Private Sub Frmprincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.F5) Then
            cargar()
        End If
    End Sub



    Private Sub Frmprincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TABLA = Me.GetTabla
        Dim lb As String
        Try
            tiempo_espera = GetSetting("SeeSOFT", "SeePOs", "tiempo")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "SeePOs", "tiempo", "8") : tiempo_espera = "8"
        End Try

        dgproductos.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        dgproductos.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable

        dgproductos.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        cFunciones.Llenar_Tabla_Generico("select * from marcas", dtspantallas, GetSetting("seesoft", "seepos", "conexion"))
        Me.cbPantallas.DataSource = dtspantallas
        Me.cbPantallas.DisplayMember = "marca"
        Me.cbPantallas.ValueMember = "codMarca"
        lb = "*** Historial de empaquetado ***"
        Me.lhistorial.Items.Add(lb)
        Call TiempoEjecutar(tiempo_espera)
        cargar()
    End Sub

    Public Sub color_columna()
        For i As Integer = 0 To dts.Rows.Count - 1

            If dts.Rows(i).Item("devoluciones") > 0 Or dts.Rows(i).Item("anulado") = True Then
                dgproductos.Rows(i).DefaultCellStyle.BackColor = Color.Red
            Else
                dgproductos.Rows(i).DefaultCellStyle.BackColor = Color.Orange
            End If

            If dts.Rows(i).Item("Descripcion").ToString.IndexOf("23 KIL") > 0 Then
                dgproductos.Rows(i).DefaultCellStyle.BackColor = Color.Purple
            End If

        Next
    End Sub
    Public Sub imagen_nota()
        For i As Integer = 0 To dts.Rows.Count - 1

            If dts.Rows(i).Item("nota_pantalla") IsNot DBNull.Value Then

                If dts.Rows(i).Item("nota_pantalla") = "0" Or dts.Rows(i).Item("nota_pantalla") = "" Then
                    dgproductos.Rows(i).Cells("nota").Value = My.Resources.no_note
                Else
                    dgproductos.Rows(i).Cells("nota").Value = My.Resources.notas1
                End If
            Else
                dgproductos.Rows(i).Cells("nota").Value = My.Resources.no_note
            End If
        Next
    End Sub

    Public Sub busca_devoluciones()
        For i As Integer = 0 To dts.Rows.Count - 1

            If dts.Rows(i).Item("devoluciones") <> "0" Then
                dgproductos.Rows(i).Cells("cantidad").Value = dts.Rows(i).Item("devoluciones")
                dgproductos.Rows(i).DefaultCellStyle.BackColor = System.Drawing.Color.Red
            End If
        Next
    End Sub

    Private Sub Sonido()
        If Me.dgproductos.Rows.Count > 0 Then
            If IO.File.Exists("C:\Sonido\Sonido.wav") Then
                My.Computer.Audio.Play("C:\Sonido\Sonido.wav", AudioPlayMode.WaitToComplete)
            End If
        End If
    End Sub

    Public Sub cargar()
        Timer1.Enabled = True
        Dim marcaHuber As Integer = Me.GetHuber
        If cbPantallas.Text = "NINGUNA" Then
            Dim marcaQuimicos As Integer = Me.GetQuimicos
            If marcaQuimicos > 0 Or marcaHuber > 0 Then
                cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura ,devoluciones,anulado,nota_pantalla from detalle_empaquetado Where codmarca NOT IN( " & marcaQuimicos & ", " & marcaHuber & ") order by minutos", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            Else
                cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura ,devoluciones,anulado,nota_pantalla from detalle_empaquetado order by minutos order by minutos", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            End If
        Else
            Dim marca As Integer = cbPantallas.SelectedValue
            If marca = marcaHuber Then
                cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura, devoluciones,anulado,nota_pantalla  from detalle_empaquetado where codmarca = " & marca & " order by Num_Factura ", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            Else
                cFunciones.Llenar_Tabla_Generico("select id_venta_detalle, Codarticulo, Descripcion, Cantidad, DATEDIFF(MI, fecha ,GETDATE()) as minutos, cast (0 as bit) as Selección, codmarca, Id_Factura, Num_Factura, devoluciones,anulado,nota_pantalla  from detalle_empaquetado where codmarca = " & marca & " order by minutos ", dts, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
            End If
        End If

        Me.dgproductos.DataSource = dts
        Me.Sonido()

        busca_devoluciones()
        color_columna()
        imagen_nota()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TiempoRestante >= 0 Then
            LblEjecutar.Text = "Actualiza en: " & TiempoRestante
            TiempoRestante = TiempoRestante - 1
            Me.Sonido()
        Else
            Timer1.Enabled = False
            'Ejecuta tu función cuando termina el tiempo
            TiempoEjecutar(tiempo_espera)
            cargar()
        End If
    End Sub
    Private TiempoRestante As Integer
    Public Function TiempoEjecutar(ByVal Tiempo As Integer)
        TiempoEjecutar = ""
        TiempoRestante = Tiempo  ' 1 minutos=60 segundos 
        Timer1.Interval = 1000
        Call TimerOn(1000) ' Hechanos a andar el timer
    End Function
    Public Sub TimerOn(ByRef Interval As Short)
        If Interval > 0 Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub dgproductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgproductos.CellContentClick
        Timer1.Enabled = False
        Dim msj As String
        Try
            If Me.BindingContext(dts, "").Current("nota_pantalla") <> "" And Me.BindingContext(dts, "").Current("nota_pantalla") <> "0" Then
                msj = Me.BindingContext(dts, "").Current("nota_pantalla")
                MsgBox(msj, MsgBoxStyle.Information, "Nota Producto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

   
    Private Sub LblEjecutar_Click(sender As Object, e As EventArgs) Handles LblEjecutar.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    
    Shared Function Pasar_Segundos_a_Horas(ByVal lminutos As Object) As String
        Try
            Dim iMinutos As Integer
            Dim iHoras As Integer
            Dim iSegundos As Integer
            Dim lSegundosHora As Integer = 60

            iHoras = lminutos \ lSegundosHora
            iMinutos = (lminutos Mod lSegundosHora) \ 60
            iSegundos = (lminutos Mod lSegundosHora) Mod 60

            Pasar_Segundos_a_Horas = iHoras & ":" & _
                                      Format(iMinutos, "00")
            Pasar_Segundos_a_Horas = Pasar_Segundos_a_Horas & ":" & _
                                       Format(iSegundos, "00")

        Catch ex As Exception
            Pasar_Segundos_a_Horas = "00:00:00"
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cargar()
    End Sub

    Private Function GetQuimicos() As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from Marcas where Marca like '%quimicos%'", dt, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CodMarca")
        Else
            Return -1
        End If
    End Function

    Private Function GetHuber() As Integer
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from Marcas where Marca like '%Huber%'", dt, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("CodMarca")
        Else
            Return -1
        End If
    End Function

    Public TABLA As String = ""
    Private Function GetTabla() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Identificacion from Seguridad.dbo.Emisor", dt, GetSetting("SeeSOFT", "SeePOs", "Conexion"))
        Select Case dt.Rows(0).Item("Identificacion")
            Case "3101105432" : Return "PreVentas_Detalle"
            Case "3101696098" : Return "PreVentas_Detalle"
            Case "3101340440" : Return "PreVentas_Detalle"
            Case Else : Return "Ventas_Detalle"
        End Select
    End Function

    Public Sub procesar()
        Dim conec As New Conexion
        Dim tiempo As String
        Dim empaquetado As String
        Dim idventa As String
        Dim leyenda As String
        Dim factura As String
        Try
            If verifica_seleccionados() = True Then
                frmteclado.ShowDialog()
                If frmteclado.conectado = True Then
                    For i As Integer = 0 To dts.Rows.Count - 1
                        If dts.Rows(i).Item("Selección") = True Then
                            Dim marca As Integer = cbPantallas.SelectedValue
                            Dim quimico As Integer = Me.GetQuimicos

                            If marca <> quimico And dts.Rows(i).Item("codmarca") = quimico Then
                                dts.Rows(i).Item("Selección") = False
                            Else
                                idventa = dts.Rows(i).Item("id_venta_detalle")
                                tiempo = dts.Rows(i).Item("minutos")
                                factura = dts.Rows(i).Item("id_factura")

                                tiempo = Pasar_Segundos_a_Horas(tiempo)

                                If dts.Rows(i).Item("devoluciones") > 0 Then
                                    conec.AddNewRecord("empaquetado", "id_venta_detalle,nombre,cedula,fecha,timer,factura, tipo", "'" & idventa & "','" & frmteclado.usu & "','" & frmteclado.ced & "','" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "', '" & tiempo & "' ," & factura & ", 'RE'")
                                    leyenda = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " - " & frmteclado.usu & " Recibio : " & dts.Rows(i).Item("cantidad") & " - " & dts.Rows(i).Item("descripcion")
                                    conec.UpdateRecords("articulos_ventas_devueltos", "empaquetado = 1", "Consecutivo = " & idventa)
                                Else
                                    conec.AddNewRecord("empaquetado", "id_venta_detalle,nombre,cedula,fecha,timer,factura, tipo", "'" & idventa & "','" & frmteclado.usu & "','" & frmteclado.ced & "','" & DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & "', '" & tiempo & "' ," & factura & ", 'EN'")
                                    leyenda = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") & " - " & frmteclado.usu & " Empaqueto : " & dts.Rows(i).Item("cantidad") & " - " & dts.Rows(i).Item("descripcion")
                                    conec.UpdateRecords(Me.TABLA, "empaquetado = 1", "id_venta_detalle = " & idventa)
                                End If

                                lhistorial.Items.Add(leyenda)
                                lhistorial.SelectedItem = leyenda
                            End If
                        End If
                    Next
                End If
                cargar()
                Call TiempoEjecutar(tiempo_espera)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function verifica_seleccionados() As Boolean
        For i As Integer = 0 To dts.Rows.Count - 1
            If dts.Rows(i).Item("selección") = True Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        procesar()
    End Sub

    Private Sub dgproductos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgproductos.KeyDown
        If e.KeyCode = Keys.F5 Then
            cargar()
        End If
        If e.KeyCode = Keys.E Then
            Procesar()
        End If
    End Sub

    Private Sub LblEjecutar_DoubleClick(sender As Object, e As EventArgs) Handles LblEjecutar.DoubleClick
        Dim nuevo_tiempo As Double
        nuevo_tiempo = InputBox("ee", "ss", tiempo_espera)
        If nuevo_tiempo <= 0 Then
            MsgBox("El tiempo de actualización debe ser mayor a 0", MsgBoxStyle.Exclamation, "Tiempo de actualización")
        End If
    End Sub
End Class
