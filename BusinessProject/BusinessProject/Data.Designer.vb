<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data
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
        Me.Page2_1 = New BusinessProject.ItemSelection()
        Me.Page2_3 = New BusinessProject.ItemSelection()
        Me.Page2_2 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'pageTotalText
        '
        Me.pageTotalText.Location = New System.Drawing.Point(314, 40)
        Me.pageTotalText.Name = "pageTotalText"
        Me.pageTotalText.ReadOnly = True
        Me.pageTotalText.Size = New System.Drawing.Size(158, 22)
        Me.pageTotalText.TabIndex = 24
        Me.pageTotalText.Text = "Select All Options"
        Me.pageTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(356, 12)
        Me.HeaderTB.Name = "HeaderTB"
        Me.HeaderTB.ReadOnly = True
        Me.HeaderTB.Size = New System.Drawing.Size(75, 22)
        Me.HeaderTB.TabIndex = 23
        Me.HeaderTB.Text = "Data"
        Me.HeaderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'Page2_1
        '
        Me.Page2_1.groupName = "Ram"
        Me.Page2_1.isMultiple = False
        Me.Page2_1.item1Name = "16GB"
        Me.Page2_1.item1Price = New Decimal(New Integer() {3599, 0, 0, 131072})
        Me.Page2_1.item2Name = "32GB"
        Me.Page2_1.item2Price = New Decimal(New Integer() {11299, 0, 0, 131072})
        Me.Page2_1.item3Name = "64GB"
        Me.Page2_1.item3Price = New Decimal(New Integer() {18499, 0, 0, 131072})
        Me.Page2_1.item4Name = "96GB"
        Me.Page2_1.item4Price = New Decimal(New Integer() {24999, 0, 0, 131072})
        Me.Page2_1.item5Name = "128GB"
        Me.Page2_1.item5Price = New Decimal(New Integer() {42999, 0, 0, 131072})
        Me.Page2_1.Location = New System.Drawing.Point(32, 128)
        Me.Page2_1.Name = "Page2_1"
        Me.Page2_1.Size = New System.Drawing.Size(239, 195)
        Me.Page2_1.TabIndex = 20
        '
        'Page2_3
        '
        Me.Page2_3.groupName = "Hard Drives"
        Me.Page2_3.isMultiple = True
        Me.Page2_3.item1Name = "500 MB"
        Me.Page2_3.item1Price = New Decimal(New Integer() {2862, 0, 0, 131072})
        Me.Page2_3.item2Name = "1 TB"
        Me.Page2_3.item2Price = New Decimal(New Integer() {6008, 0, 0, 131072})
        Me.Page2_3.item3Name = "2 TB"
        Me.Page2_3.item3Price = New Decimal(New Integer() {7099, 0, 0, 131072})
        Me.Page2_3.item4Name = "10 TB"
        Me.Page2_3.item4Price = New Decimal(New Integer() {18179, 0, 0, 131072})
        Me.Page2_3.item5Name = "18 TB"
        Me.Page2_3.item5Price = New Decimal(New Integer() {33499, 0, 0, 131072})
        Me.Page2_3.Location = New System.Drawing.Point(522, 128)
        Me.Page2_3.Name = "Page2_3"
        Me.Page2_3.Size = New System.Drawing.Size(239, 195)
        Me.Page2_3.TabIndex = 19
        '
        'Page2_2
        '
        Me.Page2_2.groupName = "SSDs"
        Me.Page2_2.isMultiple = True
        Me.Page2_2.item1Name = "512GB"
        Me.Page2_2.item1Price = New Decimal(New Integer() {3699, 0, 0, 131072})
        Me.Page2_2.item2Name = "1TB"
        Me.Page2_2.item2Price = New Decimal(New Integer() {6099, 0, 0, 131072})
        Me.Page2_2.item3Name = "2TB"
        Me.Page2_2.item3Price = New Decimal(New Integer() {9999, 0, 0, 131072})
        Me.Page2_2.item4Name = "4TB"
        Me.Page2_2.item4Price = New Decimal(New Integer() {18999, 0, 0, 131072})
        Me.Page2_2.item5Name = "8TB"
        Me.Page2_2.item5Price = New Decimal(New Integer() {51999, 0, 0, 131072})
        Me.Page2_2.Location = New System.Drawing.Point(277, 128)
        Me.Page2_2.Name = "Page2_2"
        Me.Page2_2.Size = New System.Drawing.Size(239, 195)
        Me.Page2_2.TabIndex = 25
        '
        'Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Page2_2)
        Me.Controls.Add(Me.pageTotalText)
        Me.Controls.Add(Me.HeaderTB)
        Me.Controls.Add(Me.Page2_1)
        Me.Controls.Add(Me.Page2_3)
        Me.Name = "Data"
        Me.Text = "Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Page2_1 As ItemSelection
    Friend WithEvents Page2_3 As ItemSelection
    Friend WithEvents pageTotalText As TextBox
    Friend WithEvents HeaderTB As TextBox
    Friend WithEvents calcPrice As Timer
    Friend WithEvents Page2_2 As ItemSelection
End Class
