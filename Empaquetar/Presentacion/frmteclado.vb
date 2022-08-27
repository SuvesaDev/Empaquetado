Public Class frmteclado

    Public Usuario As New Usuario_Logeado
    Public conectado As Boolean
    Public usu As String
    Public ced As String
    Dim dts As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtmemo.Text += Button1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtmemo.Text += Button2.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtmemo.Text += Button3.Text
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtmemo.Text += Button6.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtmemo.Text += Button5.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtmemo.Text += Button4.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtmemo.Text += Button9.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtmemo.Text += Button8.Text
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtmemo.Text += Button7.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtmemo.Text += Button11.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Close()
    End Sub

    Private Sub frmteclado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsUsuario.Usuarios' Puede moverla o quitarla según sea necesario.

        cFunciones.Llenar_Tabla_Generico("select * from usuarios", dts, GetSetting("seesoft", "seepos", "conexion"))

        txtmemo.Text = ""
        txtmemo.Focus()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If txtmemo.Text = "" Then
        Else
            txtmemo.Text = Mid(txtmemo.Text, 1, Len(txtmemo.Text) - 1)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Loggin_Usuario() Then
            Close()
            conectado = True
            Frmprincipal.cargar()
        Else
            conectado = False
        End If
    End Sub
    Function Loggin_Usuario() As Boolean

        Try
            If Me.BindingContext(dts).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow
                Usuario_autorizadores = Me.dts.Select("Clave_Entrada = '" & txtmemo.Text & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    ' Usuario.Nombre = Usua("Nombre")
                    usu = Usua("nombre")
                    ced = Usua("id_usuario")
                    Usuario.Clave_Entrada = Usua("Clave_Entrada")
                    Usuario.Clave_Interna = Usua("Clave_Interna")
                    Me.DialogResult = DialogResult.OK
                    Return True
                Else ' si no existe una contraseña como esta
                    MsgBox("Clave Entrada incorrecta", MsgBoxStyle.Exclamation)
                    txtmemo.Text = ""
                    txtmemo.Focus()
                    Return False
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
                Return False
                txtmemo.Focus()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txtmemo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmemo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
                Close()
                conectado = True
            End If
        End If
    End Sub
End Class