﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.brainTotal = New System.Windows.Forms.TextBox()
        Me.brainButton = New System.Windows.Forms.Button()
        Me.calcPrice = New System.Windows.Forms.Timer(Me.components)
        Me.dataButton = New System.Windows.Forms.Button()
        Me.dataTotal = New System.Windows.Forms.TextBox()
        Me.ItemSelection3 = New BusinessProject.ItemSelection()
        Me.ItemSelection1 = New BusinessProject.ItemSelection()
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
        'brainTotal
        '
        Me.brainTotal.Location = New System.Drawing.Point(12, 40)
        Me.brainTotal.Name = "brainTotal"
        Me.brainTotal.ReadOnly = True
        Me.brainTotal.Size = New System.Drawing.Size(100, 22)
        Me.brainTotal.TabIndex = 16
        Me.brainTotal.Text = "$0.00"
        Me.brainTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'brainButton
        '
        Me.brainButton.Location = New System.Drawing.Point(12, 12)
        Me.brainButton.Name = "brainButton"
        Me.brainButton.Size = New System.Drawing.Size(100, 23)
        Me.brainButton.TabIndex = 17
        Me.brainButton.Text = "Brain"
        Me.brainButton.UseVisualStyleBackColor = True
        '
        'calcPrice
        '
        Me.calcPrice.Enabled = True
        Me.calcPrice.Interval = 50
        '
        'dataButton
        '
        Me.dataButton.Location = New System.Drawing.Point(118, 12)
        Me.dataButton.Name = "dataButton"
        Me.dataButton.Size = New System.Drawing.Size(100, 23)
        Me.dataButton.TabIndex = 20
        Me.dataButton.Text = "Data"
        Me.dataButton.UseVisualStyleBackColor = True
        '
        'dataTotal
        '
        Me.dataTotal.Location = New System.Drawing.Point(118, 40)
        Me.dataTotal.Name = "dataTotal"
        Me.dataTotal.ReadOnly = True
        Me.dataTotal.Size = New System.Drawing.Size(100, 22)
        Me.dataTotal.TabIndex = 21
        Me.dataTotal.Text = "$0.00"
        Me.dataTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.ItemSelection3.Location = New System.Drawing.Point(36, 128)
        Me.ItemSelection3.Name = "ItemSelection3"
        Me.ItemSelection3.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection3.TabIndex = 19
        '
        'ItemSelection1
        '
        Me.ItemSelection1.groupName = "Cases"
        Me.ItemSelection1.groupTotal = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ItemSelection1.isMultiple = False
        Me.ItemSelection1.item1Name = "Montech AIR"
        Me.ItemSelection1.item1Price = New Decimal(New Integer() {6999, 0, 0, 131072})
        Me.ItemSelection1.item2Name = "CORSAIR"
        Me.ItemSelection1.item2Price = New Decimal(New Integer() {8499, 0, 0, 131072})
        Me.ItemSelection1.item3Name = "LIAN LI"
        Me.ItemSelection1.item3Price = New Decimal(New Integer() {10999, 0, 0, 131072})
        Me.ItemSelection1.item4Name = "NZXT H9 Flow"
        Me.ItemSelection1.item4Price = New Decimal(New Integer() {15999, 0, 0, 131072})
        Me.ItemSelection1.item5Name = "SAMA 3509"
        Me.ItemSelection1.item5Price = New Decimal(New Integer() {19999, 0, 0, 131072})
        Me.ItemSelection1.Location = New System.Drawing.Point(293, 128)
        Me.ItemSelection1.Name = "ItemSelection1"
        Me.ItemSelection1.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection1.TabIndex = 22
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ItemSelection1)
        Me.Controls.Add(Me.dataTotal)
        Me.Controls.Add(Me.dataButton)
        Me.Controls.Add(Me.ItemSelection3)
        Me.Controls.Add(Me.brainButton)
        Me.Controls.Add(Me.brainTotal)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "Form1"
        Me.Text = "Custom Computers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents brainTotal As TextBox
    Friend WithEvents brainButton As Button
    Friend WithEvents calcPrice As Timer
    Friend WithEvents ItemSelection3 As ItemSelection
    Friend WithEvents dataButton As Button
    Friend WithEvents dataTotal As TextBox
    Friend WithEvents ItemSelection1 As ItemSelection
End Class
