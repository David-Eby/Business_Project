Public Class Brain
    Public pageTotal As Decimal
    Public ErrorMessage As String = "Select All Options"

    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Page1_1.groupTotal > 0 AndAlso
        Page1_2.groupTotal > 0 AndAlso
        Page1_3.groupTotal > 0 Then
            pageTotal =
                Page1_1.groupTotal +
                Page1_2.groupTotal +
                Page1_3.groupTotal

            pageTotalText.Text = pageTotal.ToString("c2")
        Else
            pageTotal = 0
            pageTotalText.Text = ErrorMessage
        End If
    End Sub
End Class