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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.group1Total = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
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
        Me.ItemSelection1.Location = New System.Drawing.Point(549, 40)
        Me.ItemSelection1.Name = "ItemSelection1"
        Me.ItemSelection1.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection1.TabIndex = 14
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "Brain"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'group1Total
        '
        Me.group1Total.Location = New System.Drawing.Point(12, 40)
        Me.group1Total.Name = "group1Total"
        Me.group1Total.ReadOnly = True
        Me.group1Total.Size = New System.Drawing.Size(100, 22)
        Me.group1Total.TabIndex = 16
        Me.group1Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.group1Total)
        Me.Controls.Add(Me.TextBox1)
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents group1Total As TextBox
    Friend WithEvents Timer1 As Timer
End Class
