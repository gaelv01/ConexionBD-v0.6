Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub btnConectar_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Try
            Dim lu As New LUsuarios()
            Dim usuario As String = txtUsuario.Text
            Dim clave As String = txtContrasena.Text

            If validarEspaciosVacios(usuario, clave) = True Then
                If lu.consultarUsuario(usuario, clave) = True Then

                    Me.Hide()
                    Index.Show()

                Else
                    MessageBox.Show("¡El nombre de usuario o la contraseña son incorrectos!")
                    vaciarEspacios()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function validarEspaciosVacios(nombre As String, clave As String) As Boolean
        If nombre = "" Or clave = "" Then
            MessageBox.Show("Por favor, rellene los campos.")
            Return False

        Else
            Return True
        End If
    End Function

    Public Sub vaciarEspacios()
        txtUsuario.Clear()
        txtContrasena.Clear()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
