Public Class Form1
    Dim price(99) As Decimal
    Dim count As Integer = 1
    Dim subTotal2 As Integer
    Dim subTotal1 As Integer = 0

    Dim page As Integer
    Dim maxPages As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        subTotal1 = 0

        ' Group 1
        If Group1_1.Checked = True Then
            price(0) = 28.62
        Else
            price(0) = 0
        End If
        If Group1_2.Checked = True Then
            price(1) = 60.08
        Else
            price(1) = 0
        End If
        If Group1_3.Checked = True Then
            price(2) = 70.99
        Else
            price(2) = 0
        End If
        If Group1_4.Checked = True Then
            price(3) = 181.79
        Else
            price(3) = 0
        End If
        If Group1_5.Checked = True Then
            price(4) = 334.99
        Else
            price(4) = 0
        End If

        ' Group 2
        If Group2_1.Checked = True Then
            price(5) = 139
        ElseIf Group2_2.Checked = True Then
            price(5) = 369
        ElseIf Group2_3.Checked = True Then
            price(5) = 463.23
        ElseIf Group2_4.Checked = True Then
            price(5) = 669
        ElseIf Group2_4.Checked = True Then
            price(5) = 5227
        Else
            price(5) = 0
        End If

        count = Group1Counter.Value

        For priceNum = 0 To 4
            subTotal1 += price(priceNum)
        Next

        subTotal2 = subTotal1 * count
        Group1SubTotal.Text = subTotal2.ToString("c2")
    End Sub

    Private Sub Group1Clear_Click(sender As Object, e As EventArgs)
        Group1_1.Checked = False
        Group1_2.Checked = False
        Group1_3.Checked = False
        Group1_4.Checked = False
        Group1_5.Checked = False
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        page += 1
        If page > maxPages Then

        End If
    End Sub
    Private Sub PreviousButton_Click(sender As Object, e As EventArgs) Handles PreviousButton.Click
        page -= 1
    End Sub
End Class