Imports System.Reflection.Emit
Imports System.Windows

Public Class Form1
    Dim total As Decimal

    Dim page As Integer
    Dim maxPages As Integer

    Dim f2 As New Brain

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        total = ItemSelection1.groupTotal + f2.Page1_1.groupTotal
        TotalTextBox.Text = total.ToString("c2")
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        page += 1
        If page > maxPages Then
            page = 1
        End If
    End Sub
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        page -= 1
        If page < 1 Then
            page = maxPages
        End If
    End Sub
    Sub Pages()
        If page = 1 Then
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim brain As New Brain
        group1Total.Text = brain.Page1_1.groupTotal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class