﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Body
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
        Me.Page3_1 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
        '
        'pageTotalText
        '
        Me.pageTotalText.Location = New System.Drawing.Point(310, 40)
        Me.pageTotalText.Name = "pageTotalText"
        Me.pageTotalText.ReadOnly = True
        Me.pageTotalText.Size = New System.Drawing.Size(158, 22)
        Me.pageTotalText.TabIndex = 26
        Me.pageTotalText.Text = "Select All Options"
        Me.pageTotalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(352, 12)
        Me.HeaderTB.Name = "HeaderTB"
        Me.HeaderTB.ReadOnly = True
        Me.HeaderTB.Size = New System.Drawing.Size(75, 22)
        Me.HeaderTB.TabIndex = 25
        Me.HeaderTB.Text = "Body"
        Me.HeaderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'Page3_1
        '
        Me.Page3_1.groupName = "Group"
        Me.Page3_1.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.isMultiple = False
        Me.Page3_1.item1Name = "Item"
        Me.Page3_1.item1Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.item2Name = "Item"
        Me.Page3_1.item2Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.item3Name = "Item"
        Me.Page3_1.item3Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.item4Name = "Item"
        Me.Page3_1.item4Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.item5Name = "Item"
        Me.Page3_1.item5Price = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Page3_1.Location = New System.Drawing.Point(297, 158)
        Me.Page3_1.Name = "Page3_1"
        Me.Page3_1.Size = New System.Drawing.Size(239, 195)
        Me.Page3_1.TabIndex = 27
        '
        'Body
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Page3_1)
        Me.Controls.Add(Me.pageTotalText)
        Me.Controls.Add(Me.HeaderTB)
        Me.Name = "Body"
        Me.Text = "Body"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pageTotalText As TextBox
    Friend WithEvents HeaderTB As TextBox
    Friend WithEvents calcPrice As Timer
    Friend WithEvents Page3_1 As ItemSelection
End Class
