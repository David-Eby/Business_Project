Public Class Brain
    Dim pageTotal As Decimal

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pageTotal = Page1_1.groupTotal + Page1_2.groupTotal + Page1_3.groupTotal

        pageTotalText.Text = pageTotal.ToString("c2")
    End Sub
End Class