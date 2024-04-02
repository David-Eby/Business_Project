﻿Public Class Body
    Public pageTotal As Decimal
    Public ErrorMessage As String = "Select All Options"

    Private Sub calcPrice_Tick(sender As Object, e As EventArgs) Handles calcPrice.Tick
        If Page3_1.groupTotal > 0 AndAlso
        Page3_2.groupTotal > 0 AndAlso
        Page3_3.groupTotal > 0 Then
            pageTotal =
                Page3_1.groupTotal +
                Page3_2.groupTotal +
                Page3_3.groupTotal

            pageTotalText.Text = pageTotal.ToString("c2")
        Else
            pageTotal = 0
            pageTotalText.Text = ErrorMessage
        End If
    End Sub
End Class