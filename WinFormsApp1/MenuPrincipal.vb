
Imports System.Threading
Imports System.Windows
Imports System.Windows.Forms.DataFormats
Imports WinFormsApp1.Form2
Imports WinFormsApp1.Form1
Imports WinFormsApp1.Soporte


Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Problema1ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema1ToolStripMenuItem1.Click
        Dim mensaje As New Form2
        'verificacion de uso de programa:
        If Application.OpenForms().OfType(Of Form2)().Any And Application.OpenForms().OfType(Of Form1)().Any Then
            ' Form1 and Form2 estan abiertos
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Form2)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Form1)().Any Then
            ' Form3 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Soporte is open
            Soporte.Close()
        Else            ' Si no hay nada abierto
            mensaje.Show()
            mensaje.MdiParent = Me
            Me.Panel1.Controls.Add(mensaje)
        End If
    End Sub

    Private Sub MenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim resultado As MsgBoxResult
        resultado = CType(MessageBox.Show("¿Desea salir de la aplicacion?", " Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub
    'Problema 2-calculadora
    Private Sub Problema2ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Problema2ToolStripMenuItem1.Click
        Dim mensaje2 As New Form1
        'verificacion de uso de programa:
        If Application.OpenForms().OfType(Of Form2)().Any And Application.OpenForms().OfType(Of Form1)().Any Then
            ' Form1 and Form2 estan abiertos
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Form2)().Any Then
            ' Form2 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Form1)().Any Then
            ' Form3 is open
            MessageBox.Show("Debe finalizar el programa actual", " Advertencia")
        ElseIf Application.OpenForms().OfType(Of Soporte)().Any Then
            ' Form3 is open
            Soporte.Close()
        Else
            ' Si no hay nada abierto
            mensaje2.Show()
            mensaje2.MdiParent = Me
            Me.Panel1.Controls.Add(mensaje2)
        End If
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click
        If Application.OpenForms().OfType(Of Form2)().Any And Application.OpenForms().OfType(Of Form1)().Any Then
            ' Form1 and Form2 estan abiertos
            Form1.Close()
        ElseIf Application.OpenForms().OfType(Of Form2)().Any Then
            ' Form2 is open
            Form2.Close()
        End If
        Soporte.Show()
        Soporte.MdiParent = Me
        Me.Panel1.Controls.Add(Soporte)
    End Sub


End Class
