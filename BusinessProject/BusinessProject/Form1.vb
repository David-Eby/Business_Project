Public Class Form1
    Dim price As Integer
    Dim count As Integer = 1
    Dim total As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        ' Group 1
        If Group1_1.Checked = True Then
            price = Group1_1.Text
        ElseIf Group1_2.Checked = True Then
            price = Group1_2.Text
        ElseIf Group1_3.Checked = True Then
            price = Group1_3.Text
        End If

        count = Group1Counter.Value

        total = price * count
        Group1SubTotal.Text = total
    End Sub
End Class