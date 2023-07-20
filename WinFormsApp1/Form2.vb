Imports System.Numerics
Imports System.Windows.Forms.VisualStyles

Public Class Form2
    'declaracion de verificador
    Public valid As Boolean = False
    'declaracion del Problema 1
    Public capital As String = ""
    Public interes As String = ""
    Public naños As String = ""
    Public resultado As Double
    Public rint As Double
    Public douc As Double
    Public doui As Double
    Public doun As Double
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.Visible = False
        Label5.Visible = False
        TextBox1.MaxLength = 12
        TextBox2.MaxLength = 7
        TextBox3.MaxLength = 2
    End Sub
    'calculos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        capital = TextBox1.Text
        interes = TextBox2.Text
        naños = TextBox3.Text
        Try
            If TextBox1.Text = "" Or TextBox1.Text = "" Or TextBox1.Text = "" Or Convert.ToDouble(TextBox1.Text) > 1000000 Or
                Convert.ToDouble(TextBox2.Text) > 100 Or Convert.ToDouble(TextBox3.Text) > 60 Then
                Label6.Visible = True
                If Convert.ToDouble(TextBox1.Text) > 1000000 Then
                    Label6.Text = vbCrLf & "  Error :" & vbCrLf & "    El valor de capital excede  o es igual a un millon:"
                Else
                    If Convert.ToDouble(TextBox2.Text) > 100 Then
                        Label6.Text = vbCrLf & "  Error :" & vbCrLf & "    El valor excede el 100% de interes"
                    Else
                        If Convert.ToDouble(TextBox3.Text) > 60 Then
                            Label6.Text = vbCrLf & "  Error :" & vbCrLf & "   No se puede ingresar un valor mayor a 60 años."
                        Else
                            Label6.Text = vbCrLf & "  Error :" & vbCrLf & "    Introduzca un valor"
                        End If
                    End If

                End If
            Else
                Label6.Visible = False
                douc = Convert.ToDouble(capital)
                doui = Convert.ToDouble(interes)
                doun = Convert.ToDouble(naños)


                rint = (doui / 100) / 12
                resultado = (douc * rint) / (1 - (1 / 1 + rint) ^ (doun * 12))
                If resultado > 1000 Then
                    Label5.Text = (resultado).ToString("0.0000E+0")
                Else
                    Label5.Text = "B/.  " & (resultado).ToString("#,##0.00")
                End If
                Label5.Visible = True
            End If
        Catch ex As Exception
            Label5.Visible = False
            Label6.Visible = False
            MessageBox.Show("  Error :" & vbCrLf & "    El valor introdcido es incorrecto", "Advertencia")
        End Try
    End Sub
    'Finalizar
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        offp1()
    End Sub
    'limpiar
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limp()
    End Sub
    'datos permitidos en los texbox
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    'funcion limpiar
    Public Sub Limp()
        Label5.Visible = True
        Label5.Text = "campos limpiados"
        Label6.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    'funcion finalizar
    Public Sub offp1()
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar el calculo?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub


    'intento de diseño
End Class