
Imports System.Data.SqlClient
Public Class Conexion
    Public sQlconexion As New SqlConnection
    Public SQLStringConexion As String

    Public Function Conectar(Optional ByVal Modulo As String = "SeePOS") As SqlConnection
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSOFT", Modulo, "Conexion")
            sQlconexion.ConnectionString = SQLStringConexion
            If sQlconexion.ConnectionString <> "" Then sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function
    Public Sub DesConectar(ByRef sqlConexion As SqlConnection)
        sqlConexion.Close()
        sqlConexion.Dispose()
    End Sub
    Public Function Conectar1(Optional ByVal Modulo As String = "Hotel") As SqlConnection
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = GetSetting("SeeSOFT", Modulo, "Conexion")
            sQlconexion.ConnectionString = SQLStringConexion
            If sQlconexion.ConnectionString <> "" Then sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    ' DEVUELVE EL DataReader DE LA CONSULTA
    Public Function GetRecorset(ByRef conexion As SqlConnection, ByVal StrQuery As String) As SqlDataReader
        Dim Command As SqlCommand
        Dim SqlDatos As SqlDataReader
        Dim Mensaje As String
        Try
            Command = New SqlCommand(StrQuery, conexion)
            SqlDatos = Command.ExecuteReader
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return SqlDatos
    End Function
    'DEVUELVE  EL RESULTADO DE LA CONSULTA
    Public Function SlqExecuteScalar(ByRef Conexion As SqlConnection, ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing

        End Try
        Return Dato
    End Function
    Public Function SQLExeScalar(ByVal StrQuery As String, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)

        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Dato
    End Function
    Public Function SlqExecute(ByRef conexion As SqlConnection, ByVal strQuery As String) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand(strQuery, conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing

        End Try
        Return Mensaje
    End Function
    Public Function AddNewRecord(ByRef Table As Object, ByRef Campos As Object, ByRef Datos As Object, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)
        Command = New SqlCommand("INSERT INTO " & Table & " (" & Campos & ") VALUES (" & Datos & ")", Conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()

        End Try
        Return Mensaje
    End Function
    Public Function UpdateRecords(ByRef Table As String, ByRef Datos As String, ByRef Condicion As String, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)

        If Condicion <> "" Then
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos & " WHERE " & Condicion, Conexion)
        Else
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos, Conexion)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Mensaje
    End Function
    
    Public Function DeleteRecords(ByRef Table As String, ByRef Condicion As Object, Optional ByVal SubSistema As String = "") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Dim Conexion As SqlConnection
        If SubSistema = "" Then Conexion = Conectar() Else Conexion = Conectar(SubSistema)


        If Condicion = "" Then
            Command = New SqlCommand("DELETE FROM " & Table, Conexion)
        Else
            Command = New SqlCommand("DELETE FROM " & Table & " WHERE " & Condicion, Conexion)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
            Conexion.Close()
            Conexion.Dispose()
        End Try
        Return Mensaje
    End Function
End Class
