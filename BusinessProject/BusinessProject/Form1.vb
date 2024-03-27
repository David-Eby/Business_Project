Imports System.Reflection.Emit
Imports System.Windows

Public Class Form1
    Dim total As Decimal

    Dim page As Integer
    Dim maxPages As Integer

    Dim f2 As New Brain
    Dim f3 As New Data

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        total =
            brainTotal.Text + dataTotal.Text
        TotalTextBox.Text = total.ToString("c2")
    End Sub
    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Not f2.pageTotalText.Text = f2.ErrorMessage Then
            brainTotal.Text = f2.pageTotalText.Text
        Else
            brainTotal.Text = "$0.00"
        End If
        If Not f3.pageTotalText.Text = f3.ErrorMessage Then
            dataTotal.Text = f3.pageTotalText.Text
        Else
            dataTotal.Text = "$0.00"
        End If
    End Sub

    Private Sub brainButton_Click(sender As Object, e As EventArgs) Handles brainButton.Click
        f2.ShowDialog()
    End Sub
    Private Sub dataButton_Click(sender As Object, e As EventArgs) Handles dataButton.Click
        f3.ShowDialog()
    End Sub
End Class