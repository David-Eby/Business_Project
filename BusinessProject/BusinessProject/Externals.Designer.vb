<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Externals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pageTotalText = New System.Windows.Forms.TextBox()
        Me.HeaderTB = New System.Windows.Forms.TextBox()
        Me.calcPrice = New System.Windows.Forms.Timer(Me.components)
        Me.Page4_5 = New BusinessProject.ItemSelection()
        Me.Page4_3 = New BusinessProject.ItemSelection()
        Me.Page4_4 = New BusinessProject.ItemSelection()
        Me.Page4_2 = New BusinessProject.ItemSelection()
        Me.Page4_1 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'pageTotalText
        '
        Me.pageTotalText.Location = New System.Drawing.Point(321, 40)
        Me.pageTotalText.Name = "pageTotalText"
        Me.pageTotalText.ReadOnly = True
        Me.pageTotalText.Size = New System.Drawing.Size(158, 22)
        Me.pageTotalText.TabIndex = 26
        Me.pageTotalText.Text = "Select All Options"
        Me.pageTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(363, 12)
        Me.HeaderTB.Name = "HeaderTB"
        Me.HeaderTB.ReadOnly = True
        Me.HeaderTB.Size = New System.Drawing.Size(75, 22)
        Me.HeaderTB.TabIndex = 25
        Me.HeaderTB.Text = "Externals"
        Me.HeaderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'Page4_5
        '
        Me.Page4_5.groupName = "Chairs (Optional)"
        Me.Page4_5.isMultiple = False
        Me.Page4_5.item1Name = "Vitesse"
        Me.Page4_5.item1Price = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.Page4_5.item2Name = "ProHT"
        Me.Page4_5.item2Price = New Decimal(New Integer() {12499, 0, 0, 131072})
        Me.Page4_5.item3Name = "COUGAR Fusion S"
        Me.Page4_5.item3Price = New Decimal(New Integer() {16999, 0, 0, 131072})
        Me.Page4_5.item4Name = "AKRACING"
        Me.Page4_5.item4Price = New Decimal(New Integer() {539, 0, 0, 0})
        Me.Page4_5.item5Name = "Synk X Ultra"
        Me.Page4_5.item5Price = New Decimal(New Integer() {129999, 0, 0, 131072})
        Me.Page4_5.Location = New System.Drawing.Point(280, 135)
        Me.Page4_5.Name = "Page4_5"
        Me.Page4_5.Size = New System.Drawing.Size(239, 195)
        Me.Page4_5.TabIndex = 33
        '
        'Page4_3
        '
        Me.Page4_3.groupName = "Headphones (Optional)"
        Me.Page4_3.isMultiple = False
        Me.Page4_3.item1Name = "XW3"
        Me.Page4_3.item1Price = New Decimal(New Integer() {5440, 0, 0, 131072})
        Me.Page4_3.item2Name = "Logitech G435"
        Me.Page4_3.item2Price = New Decimal(New Integer() {4999, 0, 0, 131072})
        Me.Page4_3.item3Name = "Corsair VOID"
        Me.Page4_3.item3Price = New Decimal(New Integer() {7999, 0, 0, 131072})
        Me.Page4_3.item4Name = "Logitech G733"
        Me.Page4_3.item4Price = New Decimal(New Integer() {14999, 0, 0, 131072})
        Me.Page4_3.item5Name = "CORSAIR VIRTUOSO"
        Me.Page4_3.item5Price = New Decimal(New Integer() {26999, 0, 0, 131072})
        Me.Page4_3.Location = New System.Drawing.Point(12, 222)
        Me.Page4_3.Name = "Page4_3"
        Me.Page4_3.Size = New System.Drawing.Size(239, 195)
        Me.Page4_3.TabIndex = 31
        '
        'Page4_4
        '
        Me.Page4_4.groupName = "Monitors"
        Me.Page4_4.isMultiple = True
        Me.Page4_4.item1Name = "Acer V226HQL"
        Me.Page4_4.item1Price = New Decimal(New Integer() {7415, 0, 0, 131072})
        Me.Page4_4.item2Name = "Z-EDGE"
        Me.Page4_4.item2Price = New Decimal(New Integer() {12999, 0, 0, 131072})
        Me.Page4_4.item3Name = "MSI 27"
        Me.Page4_4.item3Price = New Decimal(New Integer() {21999, 0, 0, 131072})
        Me.Page4_4.item4Name = "MSI MAG"
        Me.Page4_4.item4Price = New Decimal(New Integer() {74999, 0, 0, 131072})
        Me.Page4_4.item5Name = "ASUS 34"
        Me.Page4_4.item5Price = New Decimal(New Integer() {129999, 0, 0, 131072})
        Me.Page4_4.Location = New System.Drawing.Point(549, 222)
        Me.Page4_4.Name = "Page4_4"
        Me.Page4_4.Size = New System.Drawing.Size(239, 195)
        Me.Page4_4.TabIndex = 30
        '
        'Page4_2
        '
        Me.Page4_2.groupName = "Keyboards"
        Me.Page4_2.isMultiple = False
        Me.Page4_2.item1Name = "Logitech K120"
        Me.Page4_2.item1Price = New Decimal(New Integer() {1299, 0, 0, 131072})
        Me.Page4_2.item2Name = "Logitech K400"
        Me.Page4_2.item2Price = New Decimal(New Integer() {2999, 0, 0, 131072})
        Me.Page4_2.item3Name = "SteelSeries"
        Me.Page4_2.item3Price = New Decimal(New Integer() {4999, 0, 0, 131072})
        Me.Page4_2.item4Name = "Razer BlackWidow"
        Me.Page4_2.item4Price = New Decimal(New Integer() {13999, 0, 0, 131072})
        Me.Page4_2.item5Name = "Corsair K100"
        Me.Page4_2.item5Price = New Decimal(New Integer() {24999, 0, 0, 131072})
        Me.Page4_2.Location = New System.Drawing.Point(549, 21)
        Me.Page4_2.Name = "Page4_2"
        Me.Page4_2.Size = New System.Drawing.Size(239, 195)
        Me.Page4_2.TabIndex = 29
        '
        'Page4_1
        '
        Me.Page4_1.groupName = "Mice"
        Me.Page4_1.isMultiple = False
        Me.Page4_1.item1Name = "EVGA X17"
        Me.Page4_1.item1Price = New Decimal(New Integer() {4999, 0, 0, 131072})
        Me.Page4_1.item2Name = "Logitech G502"
        Me.Page4_1.item2Price = New Decimal(New Integer() {5942, 0, 0, 131072})
        Me.Page4_1.item3Name = "Logitech G703"
        Me.Page4_1.item3Price = New Decimal(New Integer() {8999, 0, 0, 131072})
        Me.Page4_1.item4Name = "ASUS ROG"
        Me.Page4_1.item4Price = New Decimal(New Integer() {14999, 0, 0, 131072})
        Me.Page4_1.item5Name = "Roccat Wireless"
        Me.Page4_1.item5Price = New Decimal(New Integer() {19580, 0, 0, 131072})
        Me.Page4_1.Location = New System.Drawing.Point(12, 21)
        Me.Page4_1.Name = "Page4_1"
        Me.Page4_1.Size = New System.Drawing.Size(239, 195)
        Me.Page4_1.TabIndex = 28
        '
        'Externals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Page4_5)
        Me.Controls.Add(Me.Page4_3)
        Me.Controls.Add(Me.Page4_4)
        Me.Controls.Add(Me.Page4_2)
        Me.Controls.Add(Me.Page4_1)
        Me.Controls.Add(Me.pageTotalText)
        Me.Controls.Add(Me.HeaderTB)
        Me.Name = "Externals"
        Me.Text = "Externals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pageTotalText As TextBox
    Friend WithEvents HeaderTB As TextBox
    Friend WithEvents calcPrice As Timer
    Friend WithEvents Page4_2 As ItemSelection
    Friend WithEvents Page4_1 As ItemSelection
    Friend WithEvents Page4_4 As ItemSelection
    Friend WithEvents Page4_3 As ItemSelection
    Friend WithEvents Page4_5 As ItemSelection
End Class
