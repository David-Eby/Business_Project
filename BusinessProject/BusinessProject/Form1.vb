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
    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Not f2.pageTotalText.Text = f2.ErrorMessage Then
            brainTotal.Text = f2.pageTotalText.Text
        Else
            brainTotal.Text = "$0.00"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        f2.ShowDialog()
        Me.Show()
    End Sub
End Class