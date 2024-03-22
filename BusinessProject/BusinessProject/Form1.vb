Public Class Form1
    Dim total As Decimal

    Dim page As Integer
    Dim maxPages As Integer
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        total = ItemSelection1.groupTotal + ItemSelection2.groupTotal
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
End Class