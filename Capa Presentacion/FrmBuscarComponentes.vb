Public Class FrmBuscarComponentes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If validarEspacioVacio() Then

            Try

                Dim result = txtBuscar.Text

                If rbtnBuscarID.Checked = True Then
                    Dim resultAsNumber = Convert.ToInt32(result)
                    Dim lc As New LComponentes
                    Dim dt As DataTable = lc.encontrarPorID(resultAsNumber)
                    dgvResultados.DataSource = dt
                End If

                If rbtnBuscarDesc.Checked = True Then
                    Dim lc As New LComponentes
                    Dim dt As DataTable = lc.encontrarPorDesc(result)
                    dgvResultados.DataSource = dt
                End If

                If rbtnBuscarFecha.Checked = True Then
                    If validarLongitudFecha(result) Then
                        Dim dia = result.Substring(0, 2)
                        Dim mes = result.Substring(3, 2)
                        Dim anio = result.Substring(6, 4)
                        Dim resultAsDate = anio + mes + dia

                        Dim lc As New LComponentes
                        Dim dt As DataTable = lc.encontrarPorFecha(resultAsDate)
                        dgvResultados.DataSource = dt
                    Else
                        MsgBox("El formato para introducir la fecha es incorrecto. Verifique su digitación.")
                    End If

                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub


    Public Function validarEspacioVacio() As Boolean
        If txtBuscar.Text = "" Then
            MsgBox("Rellene el campo solicitado")
            Return False
        Else
            Return True
        End If

    End Function

    Public Function validarLongitudFecha(fec As String) As Boolean
        If fec.Length = 10 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub FrmBuscarComponentes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtnBuscarID.Checked = True
    End Sub

    Private Sub rbtnBuscarID_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarID.CheckedChanged
        txtInstruccion.Text = ""
    End Sub

    Private Sub rbtnBuscarDesc_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarDesc.CheckedChanged
        txtInstruccion.Text = ""
    End Sub

    Private Sub rbtnBuscarFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBuscarFecha.CheckedChanged
        txtInstruccion.Text = "Formato de fecha: DD/MM/AAAA" & vbCrLf & "o DD-MM-AAAA"
    End Sub
End Class