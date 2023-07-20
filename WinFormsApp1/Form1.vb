Imports System.Globalization

Public Class Form1

    Dim num1, num2 As Double
    Dim oper As Char

    Private Sub n1_Click(sender As Object, e As EventArgs) Handles n1.Click
        salida.Text = salida.Text & 1
        salida2.Text = salida2.Text & 1
    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        salida.Text = salida.Text & 2
        salida2.Text = salida2.Text & 2
    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        salida.Text = salida.Text & 3
        salida2.Text = salida2.Text & 3
    End Sub

    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        salida.Text = salida.Text & 4
        salida2.Text = salida2.Text & 4
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        salida.Text = salida.Text & 5
        salida2.Text = salida2.Text & 5
    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        salida.Text = salida.Text & 6
        salida2.Text = salida2.Text & 6
    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        salida.Text = salida.Text & 7
        salida2.Text = salida2.Text & 7
    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        salida.Text = salida.Text & 8
        salida2.Text = salida2.Text & 8
    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        salida.Text = salida.Text & 9
        salida2.Text = salida2.Text & 9
    End Sub

    Private Sub n0_Click(sender As Object, e As EventArgs) Handles n0.Click
        salida.Text = salida.Text & 0
        salida2.Text = salida2.Text & 0
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        salida.Clear()
        salida2.Clear()
        num1 = 0
        num2 = 0
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        If salida.Text <> "" Then
            num1 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)
            salida2.Text = salida2.Text & "/"
            salida.Text = ""
            oper = "/"
        Else
            MsgBox("Ingresa un valor para dividir...")
        End If

    End Sub


    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        If salida.Text <> "" Then
            num1 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)
            salida2.Text = salida2.Text & "-"
                salida.Text = ""
            oper = "-"
        Else
                MsgBox("Ingresa un valor para restar...")
        End If

    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        If salida.Text <> "" Then
            num1 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)
            salida2.Text = salida2.Text & "*"
            salida.Text = ""
            oper = "*"
        Else
            MsgBox("Ingresa un valor para multiplicar...")
        End If

    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        If salida.Text <> "" Then
            num1 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)
            salida2.Text = salida2.Text & "+"
            salida.Text = ""
            oper = "+"
        Else
            MsgBox("Ingresa un valor para sumar...")
        End If

    End Sub

    Private Sub btnPorc_Click(sender As Object, e As EventArgs) Handles btnPorc.Click
        If salida.Text <> "" Then
            num1 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)
            salida2.Text = salida2.Text & "%"
            salida.Text = ""
            oper = "%"
        Else
            MsgBox("Ingresa un valor para sacar porcentaje...")
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        offp2()
    End Sub

    Private Sub pDecimal_Click(sender As Object, e As EventArgs) Handles pDecimal.Click
        If salida.Text <> "" Then
            If InStr(salida.Text, ".", CompareMethod.Text) = 0 Then
                salida.Text = salida.Text & "."
                salida2.Text = salida2.Text & "."
            End If
        Else
            MsgBox("No ingresaste un valor")
            salida.Clear()
        End If
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        If salida.Text.Length > 0 And salida2.Text.Length > 0 Then
            salida.Text = salida.Text.Substring(0, salida.Text.Length - 1)
            salida2.Text = salida2.Text.Substring(0, salida2.Text.Length - 1)
        End If
    End Sub

    Private Sub operacion_Click(sender As Object, e As EventArgs) Handles operacion.Click

        If salida.Text <> "" Then

            num2 = Decimal.Parse(salida.Text, CultureInfo.InvariantCulture)

            If num1 = 0 Then
                MsgBox("No se realizó ninguna operación")
            Else
                If oper = "/" Then
                    If num2 <> 0 Then
                        salida2.Text = salida2.Text & " = " & num1 / num2
                    Else
                        salida2.Text = "Error"
                    End If
                End If

                If oper = "-" Then
                    salida2.Text = salida2.Text & " = " & num1 - num2
                End If

                If oper = "*" Then
                    salida2.Text = salida2.Text & " = " & num1 * num2
                End If
                If oper = "+" Then
                    salida2.Text = salida2.Text & " = " & num1 + num2
                End If
                If oper = "%" Then
                    salida2.Text = salida2.Text & " = " & (num1 * num2) / 100
                End If
            End If
        Else
            MsgBox("Indroduce un segundo valor...")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub salida2_TextChanged(sender As Object, e As EventArgs) Handles salida2.TextChanged

    End Sub
    Public Sub offp2()
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea finalizar la calculadora?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
        Else
            Me.Close()
        End If
    End Sub
End Class
