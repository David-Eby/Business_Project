Imports System.Security.Cryptography.X509Certificates

Public Class ItemSelection
    Public Property groupName As String = "Group"

    Public Property item1Name As String = "Item"
    Public Property item1Price As Decimal = 0
    Public Property item2Name As String = "Item"
    Public Property item2Price As Decimal = 0
    Public Property item3Name As String = "Item"
    Public Property item3Price As Decimal = 0
    Public Property item4Name As String = "Item"
    Public Property item4Price As Decimal = 0
    Public Property item5Name As String = "Item"
    Public Property item5Price As Decimal = 0

    Public Property isMultiple As Boolean

    Public Property groupTotal As Decimal

    Private Sub checkPrice_Tick(sender As Object, e As EventArgs) Handles brainTimer.Tick
        Group1.Text = groupName

        Item1.Text =
            item1Name + " (" + item1Price.ToString("c2") + ")"
        Item2.Text =
            item2Name + " (" + item2Price.ToString("c2") + ")"
        Item3.Text =
            item3Name + " (" + item3Price.ToString("c2") + ")"
        Item4.Text =
            item4Name + " (" + item4Price.ToString("c2") + ")"
        Item5.Text =
            item5Name + " (" + item5Price.ToString("c2") + ")"
        Item1M.Text =
            item1Name + " (" + item1Price.ToString("c2") + ")"
        Item2M.Text =
            item2Name + " (" + item2Price.ToString("c2") + ")"
        Item3M.Text =
            item3Name + " (" + item3Price.ToString("c2") + ")"
        Item4M.Text =
            item4Name + " (" + item4Price.ToString("c2") + ")"
        Item5M.Text =
            item5Name + " (" + item5Price.ToString("c2") + ")"

        If isMultiple = True Then
            Item1M.Visible = True
            Item2M.Visible = True
            Item3M.Visible = True
            Item4M.Visible = True
            Item5M.Visible = True
            Group1Counter.Visible = True

            Item1.Visible = False
            Item2.Visible = False
            Item3.Visible = False
            Item4.Visible = False
            Item5.Visible = False
        Else
            Item1.Visible = True
            Item2.Visible = True
            Item3.Visible = True
            Item4.Visible = True
            Item5.Visible = True

            Item1M.Visible = False
            Item2M.Visible = False
            Item3M.Visible = False
            Item4M.Visible = False
            Item5M.Visible = False
            Group1Counter.Visible = False
        End If


        Dim count As Integer
        Dim price(4) As Decimal

        Dim subTotal As Decimal

        If Item1.Checked = True Or Item1M.Checked = True Then
            price(0) = item1Price
        Else
            price(0) = 0
        End If
        If Item2.Checked = True Or Item2M.Checked = True Then
            price(1) = item2Price
        Else
            price(1) = 0
        End If
        If Item3.Checked = True Or Item3M.Checked = True Then
            price(2) = item3Price
        Else
            price(2) = 0
        End If
        If Item4.Checked = True Or Item4M.Checked = True Then
            price(3) = item4Price
        Else
            price(3) = 0
        End If
        If Item5.Checked = True Or Item5M.Checked = True Then
            price(4) = item5Price
        Else
            price(4) = 0
        End If

        subTotal =
            price(0) +
            price(1) +
            price(2) +
            price(3) +
            price(4)

        count = Group1Counter.Value

        groupTotal = count * subTotal
        groupSubTotalText.Text = groupTotal.ToString("c2")
    End Sub

    Private Sub Group1Clear_Click(sender As Object, e As EventArgs) Handles Group1Clear.Click
        Item1.Checked = False
        Item2.Checked = False
        Item3.Checked = False
        Item4.Checked = False
        Item5.Checked = False

        Item1M.Checked = False
        Item2M.Checked = False
        Item3M.Checked = False
        Item4M.Checked = False
        Item5M.Checked = False
        Group1Counter.Value = 1
    End Sub
End Class