Public Class Body
    Public pageTotal As Decimal
    Public ErrorMessage As String = "Select All Options"

    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Page3_1.groupTotal > 0 AndAlso
        Page3_1.groupTotal > 0 AndAlso
        Page3_1.groupTotal > 0 Then
            pageTotal =
                Page3_1.groupTotal +
                Page3_1.groupTotal +
                Page3_1.groupTotal

            pageTotalText.Text = pageTotal.ToString("c2")
        Else
            pageTotalText.Text = ErrorMessage
        End If
    End Sub
End Class