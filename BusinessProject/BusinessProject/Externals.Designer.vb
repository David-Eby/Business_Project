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
        Me.ItemSelection2 = New BusinessProject.ItemSelection()
        Me.Page4_1 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'pageTotalText
        '
        Me.pageTotalText.Location = New System.Drawing.Point(303, 40)
        Me.pageTotalText.Name = "pageTotalText"
        Me.pageTotalText.ReadOnly = True
        Me.pageTotalText.Size = New System.Drawing.Size(158, 22)
        Me.pageTotalText.TabIndex = 26
        Me.pageTotalText.Text = "Select All Options"
        Me.pageTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(345, 12)
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
        'ItemSelection2
        '
        Me.ItemSelection2.groupName = "Keyboards"
        Me.ItemSelection2.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ItemSelection2.isMultiple = False
        Me.ItemSelection2.item1Name = "Logitech K120"
        Me.ItemSelection2.item1Price = New Decimal(New Integer() {1299, 0, 0, 131072})
        Me.ItemSelection2.item2Name = "Logitech K400"
        Me.ItemSelection2.item2Price = New Decimal(New Integer() {2999, 0, 0, 131072})
        Me.ItemSelection2.item3Name = "SteelSeries"
        Me.ItemSelection2.item3Price = New Decimal(New Integer() {4999, 0, 0, 131072})
        Me.ItemSelection2.item4Name = "Razer BlackWidow"
        Me.ItemSelection2.item4Price = New Decimal(New Integer() {13999, 0, 0, 131072})
        Me.ItemSelection2.item5Name = "Corsair K100"
        Me.ItemSelection2.item5Price = New Decimal(New Integer() {24999, 0, 0, 131072})
        Me.ItemSelection2.Location = New System.Drawing.Point(403, 128)
        Me.ItemSelection2.Name = "ItemSelection2"
        Me.ItemSelection2.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection2.TabIndex = 29
        '
        'Page4_1
        '
        Me.Page4_1.groupName = "Mice"
        Me.Page4_1.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
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
        Me.Page4_1.Location = New System.Drawing.Point(158, 128)
        Me.Page4_1.Name = "Page4_1"
        Me.Page4_1.Size = New System.Drawing.Size(239, 195)
        Me.Page4_1.TabIndex = 28
        '
        'Externals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ItemSelection2)
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
    Friend WithEvents ItemSelection2 As ItemSelection
    Friend WithEvents Page4_1 As ItemSelection
End Class
