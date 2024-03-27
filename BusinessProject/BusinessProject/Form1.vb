Imports System.Reflection.Emit
Imports System.Windows

Public Class Form1
    Dim total As Decimal

    Dim f2 As New Brain
    Dim f3 As New Data
    Dim f4 As New Body
    Dim f5 As New Externals

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        If Not f2.pageTotal = 0 AndAlso
        Not f3.pageTotal = 0 AndAlso
        Not f4.pageTotal = 0 AndAlso
        Not f5.pageTotal = 0 Then
            total =
                f2.pageTotal +
                f3.pageTotal +
                f4.pageTotal +
                f5.pageTotal
            TotalTextBox.Text = total.ToString("c2")
        Else
            TotalTextBox.Text = "$0.00"
        End If
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
        If Not f4.pageTotalText.Text = f4.ErrorMessage Then
            bodyTotal.Text = f4.pageTotalText.Text
        Else
            bodyTotal.Text = "$0.00"
        End If
        If Not f5.pageTotalText.Text = f5.ErrorMessage Then
            externalsTotal.Text = f5.pageTotalText.Text
        Else
            externalsTotal.Text = "$0.00"
        End If
    End Sub

    Private Sub brainButton_Click(sender As Object, e As EventArgs) Handles brainButton.Click
        f2.ShowDialog()
    End Sub
    Private Sub dataButton_Click(sender As Object, e As EventArgs) Handles dataButton.Click
        f3.ShowDialog()
    End Sub
    Private Sub bodyButton_Click(sender As Object, e As EventArgs) Handles bodyButton.Click
        f4.ShowDialog()
    End Sub
    Private Sub externalsButton_Click(sender As Object, e As EventArgs) Handles externalsButton.Click
        f5.ShowDialog()
    End Sub
End Class