<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Brain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.HeaderTB = New System.Windows.Forms.TextBox()
        Me.pageTotalText = New System.Windows.Forms.TextBox()
        Me.calcPrice = New System.Windows.Forms.Timer(Me.components)
        Me.Page1_3 = New BusinessProject.ItemSelection()
        Me.Page1_2 = New BusinessProject.ItemSelection()
        Me.Page1_1 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(360, 12)
        Me.HeaderTB.Name = "HeaderTB"
        Me.HeaderTB.ReadOnly = True
        Me.HeaderTB.Size = New System.Drawing.Size(75, 22)
        Me.HeaderTB.TabIndex = 18
        Me.HeaderTB.Text = "Brain"
        Me.HeaderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pageTotalText
        '
        Me.pageTotalText.Location = New System.Drawing.Point(318, 40)
        Me.pageTotalText.Name = "pageTotalText"
        Me.pageTotalText.ReadOnly = True
        Me.pageTotalText.Size = New System.Drawing.Size(158, 22)
        Me.pageTotalText.TabIndex = 22
        Me.pageTotalText.Text = "Select All Options"
        Me.pageTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'Page1_3
        '
        Me.Page1_3.groupName = "Motherboards"
        Me.Page1_3.isMultiple = False
        Me.Page1_3.item1Name = "B650M"
        Me.Page1_3.item1Price = New Decimal(New Integer() {14999, 0, 0, 131072})
        Me.Page1_3.item2Name = "B650"
        Me.Page1_3.item2Price = New Decimal(New Integer() {19999, 0, 0, 131072})
        Me.Page1_3.item3Name = "B650-A"
        Me.Page1_3.item3Price = New Decimal(New Integer() {27999, 0, 0, 131072})
        Me.Page1_3.item4Name = "X670E"
        Me.Page1_3.item4Price = New Decimal(New Integer() {34999, 0, 0, 131072})
        Me.Page1_3.item5Name = "X670E-E"
        Me.Page1_3.item5Price = New Decimal(New Integer() {47999, 0, 0, 131072})
        Me.Page1_3.Location = New System.Drawing.Point(538, 111)
        Me.Page1_3.Name = "Page1_3"
        Me.Page1_3.Size = New System.Drawing.Size(239, 195)
        Me.Page1_3.TabIndex = 21
        '
        'Page1_2
        '
        Me.Page1_2.groupName = "GPUs"
        Me.Page1_2.isMultiple = False
        Me.Page1_2.item1Name = "3060"
        Me.Page1_2.item1Price = New Decimal(New Integer() {33384, 0, 0, 131072})
        Me.Page1_2.item2Name = "3070"
        Me.Page1_2.item2Price = New Decimal(New Integer() {46999, 0, 0, 131072})
        Me.Page1_2.item3Name = "4070"
        Me.Page1_2.item3Price = New Decimal(New Integer() {57299, 0, 0, 131072})
        Me.Page1_2.item4Name = "4080"
        Me.Page1_2.item4Price = New Decimal(New Integer() {116999, 0, 0, 131072})
        Me.Page1_2.item5Name = "4090"
        Me.Page1_2.item5Price = New Decimal(New Integer() {293628, 0, 0, 131072})
        Me.Page1_2.Location = New System.Drawing.Point(282, 111)
        Me.Page1_2.Name = "Page1_2"
        Me.Page1_2.Size = New System.Drawing.Size(239, 195)
        Me.Page1_2.TabIndex = 20
        '
        'Page1_1
        '
        Me.Page1_1.groupName = "CPUs"
        Me.Page1_1.isMultiple = False
        Me.Page1_1.item1Name = "6 Core"
        Me.Page1_1.item1Price = New Decimal(New Integer() {139, 0, 0, 0})
        Me.Page1_1.item2Name = "8 Core"
        Me.Page1_1.item2Price = New Decimal(New Integer() {369, 0, 0, 0})
        Me.Page1_1.item3Name = "12 Core"
        Me.Page1_1.item3Price = New Decimal(New Integer() {46323, 0, 0, 131072})
        Me.Page1_1.item4Name = "16 Core"
        Me.Page1_1.item4Price = New Decimal(New Integer() {669, 0, 0, 0})
        Me.Page1_1.item5Name = "Threadripper"
        Me.Page1_1.item5Price = New Decimal(New Integer() {5227, 0, 0, 0})
        Me.Page1_1.Location = New System.Drawing.Point(23, 111)
        Me.Page1_1.Name = "Page1_1"
        Me.Page1_1.Size = New System.Drawing.Size(239, 195)
        Me.Page1_1.TabIndex = 19
        '
        'Brain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumOrchid
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pageTotalText)
        Me.Controls.Add(Me.Page1_3)
        Me.Controls.Add(Me.Page1_2)
        Me.Controls.Add(Me.Page1_1)
        Me.Controls.Add(Me.HeaderTB)
        Me.Name = "Brain"
        Me.Text = "Brain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Page1_3 As ItemSelection
    Friend WithEvents Page1_2 As ItemSelection
    Friend WithEvents Page1_1 As ItemSelection
    Friend WithEvents HeaderTB As TextBox
    Friend WithEvents pageTotalText As TextBox
    Friend WithEvents calcPrice As Timer
End Class
