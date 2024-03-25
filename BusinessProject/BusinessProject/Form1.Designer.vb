<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ItemSelection1 = New BusinessProject.ItemSelection()
        Me.brainTotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.calcPrice = New System.Windows.Forms.Timer(Me.components)
        Me.ItemSelection2 = New BusinessProject.ItemSelection()
        Me.ItemSelection3 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(359, 415)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 2
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'PreviousButton
        '
        Me.PreviousButton.Location = New System.Drawing.Point(12, 415)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(75, 23)
        Me.PreviousButton.TabIndex = 9
        Me.PreviousButton.Text = "Previous"
        Me.PreviousButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(713, 415)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 10
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(671, 12)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(117, 22)
        Me.TotalTextBox.TabIndex = 8
        Me.TotalTextBox.Text = "$0.00"
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ItemSelection1
        '
        Me.ItemSelection1.groupName = "Hard Drives"
        Me.ItemSelection1.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ItemSelection1.isMultiple = True
        Me.ItemSelection1.item1Name = "500 MB"
        Me.ItemSelection1.item1Price = New Decimal(New Integer() {2862, 0, 0, 131072})
        Me.ItemSelection1.item2Name = "1 TB"
        Me.ItemSelection1.item2Price = New Decimal(New Integer() {6008, 0, 0, 131072})
        Me.ItemSelection1.item3Name = "2 TB"
        Me.ItemSelection1.item3Price = New Decimal(New Integer() {7099, 0, 0, 131072})
        Me.ItemSelection1.item4Name = "10 TB"
        Me.ItemSelection1.item4Price = New Decimal(New Integer() {18179, 0, 0, 131072})
        Me.ItemSelection1.item5Name = "18 TB"
        Me.ItemSelection1.item5Price = New Decimal(New Integer() {33499, 0, 0, 131072})
        Me.ItemSelection1.Location = New System.Drawing.Point(542, 128)
        Me.ItemSelection1.Name = "ItemSelection1"
        Me.ItemSelection1.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection1.TabIndex = 14
        '
        'brainTotal
        '
        Me.brainTotal.Location = New System.Drawing.Point(12, 40)
        Me.brainTotal.Name = "brainTotal"
        Me.brainTotal.ReadOnly = True
        Me.brainTotal.Size = New System.Drawing.Size(100, 22)
        Me.brainTotal.TabIndex = 16
        Me.brainTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Brain"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'ItemSelection2
        '
        Me.ItemSelection2.groupName = "Ram"
        Me.ItemSelection2.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ItemSelection2.isMultiple = False
        Me.ItemSelection2.item1Name = "16GB"
        Me.ItemSelection2.item1Price = New Decimal(New Integer() {3599, 0, 0, 131072})
        Me.ItemSelection2.item2Name = "32GB"
        Me.ItemSelection2.item2Price = New Decimal(New Integer() {11299, 0, 0, 131072})
        Me.ItemSelection2.item3Name = "64GB"
        Me.ItemSelection2.item3Price = New Decimal(New Integer() {18499, 0, 0, 131072})
        Me.ItemSelection2.item4Name = "96GB"
        Me.ItemSelection2.item4Price = New Decimal(New Integer() {24999, 0, 0, 131072})
        Me.ItemSelection2.item5Name = "128GB"
        Me.ItemSelection2.item5Price = New Decimal(New Integer() {42999, 0, 0, 131072})
        Me.ItemSelection2.Location = New System.Drawing.Point(281, 128)
        Me.ItemSelection2.Name = "ItemSelection2"
        Me.ItemSelection2.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection2.TabIndex = 18
        '
        'ItemSelection3
        '
        Me.ItemSelection3.groupName = "Power Supplies"
        Me.ItemSelection3.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ItemSelection3.isMultiple = False
        Me.ItemSelection3.item1Name = "600W"
        Me.ItemSelection3.item1Price = New Decimal(New Integer() {4999, 0, 0, 131072})
        Me.ItemSelection3.item2Name = "750W"
        Me.ItemSelection3.item2Price = New Decimal(New Integer() {7499, 0, 0, 131072})
        Me.ItemSelection3.item3Name = "850W"
        Me.ItemSelection3.item3Price = New Decimal(New Integer() {12999, 0, 0, 131072})
        Me.ItemSelection3.item4Name = "1000W"
        Me.ItemSelection3.item4Price = New Decimal(New Integer() {17499, 0, 0, 131072})
        Me.ItemSelection3.item5Name = "1200W"
        Me.ItemSelection3.item5Price = New Decimal(New Integer() {24999, 0, 0, 131072})
        Me.ItemSelection3.Location = New System.Drawing.Point(20, 128)
        Me.ItemSelection3.Name = "ItemSelection3"
        Me.ItemSelection3.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection3.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ItemSelection3)
        Me.Controls.Add(Me.ItemSelection2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.brainTotal)
        Me.Controls.Add(Me.ItemSelection1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "Form1"
        Me.Text = "Custom Computers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents ItemSelection1 As ItemSelection
    Friend WithEvents brainTotal As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents calcPrice As Timer
    Friend WithEvents ItemSelection2 As ItemSelection
    Friend WithEvents ItemSelection3 As ItemSelection
End Class
