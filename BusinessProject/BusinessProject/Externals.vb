Public Class Externals
    Public pageTotal As Decimal
    Public ErrorMessage As String = "Select All Options"

    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Page4_1.groupTotal > 0 AndAlso
        Page4_2.groupTotal > 0 AndAlso
        Page4_4.groupTotal > 0 Then
            pageTotal =
                Page4_1.groupTotal +
                Page4_2.groupTotal +
                Page4_3.groupTotal +
                Page4_4.groupTotal

            pageTotalText.Text = pageTotal.ToString("c2")
        Else
            pageTotalText.Text = ErrorMessage
        End If
    End Sub
End Class