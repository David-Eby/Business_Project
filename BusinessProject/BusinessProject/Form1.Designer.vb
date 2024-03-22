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
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Group2_5 = New System.Windows.Forms.RadioButton()
        Me.Group2_4 = New System.Windows.Forms.RadioButton()
        Me.Group2_3 = New System.Windows.Forms.RadioButton()
        Me.Group2_2 = New System.Windows.Forms.RadioButton()
        Me.Group2_1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PreviousButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.HeaderTB = New System.Windows.Forms.TextBox()
        Me.Group1SubTotal = New System.Windows.Forms.TextBox()
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.Group1Clear = New System.Windows.Forms.Button()
        Me.Group1_5 = New System.Windows.Forms.CheckBox()
        Me.Group1_4 = New System.Windows.Forms.CheckBox()
        Me.Group1_3 = New System.Windows.Forms.CheckBox()
        Me.Group1_2 = New System.Windows.Forms.CheckBox()
        Me.Group1_1 = New System.Windows.Forms.CheckBox()
        Me.Group1Counter = New System.Windows.Forms.NumericUpDown()
        Me.ItemSelection1 = New BusinessProject.ItemSelection()
        Me.GroupBox1.SuspendLayout()
        Me.Group1.SuspendLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Group2_5)
        Me.GroupBox1.Controls.Add(Me.Group2_4)
        Me.GroupBox1.Controls.Add(Me.Group2_3)
        Me.GroupBox1.Controls.Add(Me.Group2_2)
        Me.GroupBox1.Controls.Add(Me.Group2_1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 186)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU"
        '
        'Group2_5
        '
        Me.Group2_5.AutoSize = True
        Me.Group2_5.Location = New System.Drawing.Point(6, 126)
        Me.Group2_5.Name = "Group2_5"
        Me.Group2_5.Size = New System.Drawing.Size(153, 20)
        Me.Group2_5.TabIndex = 12
        Me.Group2_5.TabStop = True
        Me.Group2_5.Text = "Threadripper ($5227)"
        Me.Group2_5.UseVisualStyleBackColor = True
        '
        'Group2_4
        '
        Me.Group2_4.AutoSize = True
        Me.Group2_4.Location = New System.Drawing.Point(6, 100)
        Me.Group2_4.Name = "Group2_4"
        Me.Group2_4.Size = New System.Drawing.Size(113, 20)
        Me.Group2_4.TabIndex = 11
        Me.Group2_4.TabStop = True
        Me.Group2_4.Text = "16 Core ($669)"
        Me.Group2_4.UseVisualStyleBackColor = True
        '
        'Group2_3
        '
        Me.Group2_3.AutoSize = True
        Me.Group2_3.Location = New System.Drawing.Point(6, 74)
        Me.Group2_3.Name = "Group2_3"
        Me.Group2_3.Size = New System.Drawing.Size(130, 20)
        Me.Group2_3.TabIndex = 10
        Me.Group2_3.TabStop = True
        Me.Group2_3.Text = "12 Core ($463.23)"
        Me.Group2_3.UseVisualStyleBackColor = True
        '
        'Group2_2
        '
        Me.Group2_2.AutoSize = True
        Me.Group2_2.Location = New System.Drawing.Point(6, 48)
        Me.Group2_2.Name = "Group2_2"
        Me.Group2_2.Size = New System.Drawing.Size(106, 20)
        Me.Group2_2.TabIndex = 9
        Me.Group2_2.TabStop = True
        Me.Group2_2.Text = "8 Core ($369)"
        Me.Group2_2.UseVisualStyleBackColor = True
        '
        'Group2_1
        '
        Me.Group2_1.AutoSize = True
        Me.Group2_1.Location = New System.Drawing.Point(6, 22)
        Me.Group2_1.Name = "Group2_1"
        Me.Group2_1.Size = New System.Drawing.Size(106, 20)
        Me.Group2_1.TabIndex = 8
        Me.Group2_1.TabStop = True
        Me.Group2_1.Text = "6 Core ($139)"
        Me.Group2_1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 76)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
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
        'HeaderTB
        '
        Me.HeaderTB.Location = New System.Drawing.Point(359, 13)
        Me.HeaderTB.Name = "HeaderTB"
        Me.HeaderTB.ReadOnly = True
        Me.HeaderTB.Size = New System.Drawing.Size(75, 22)
        Me.HeaderTB.TabIndex = 11
        Me.HeaderTB.Text = "Brain"
        Me.HeaderTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Group1SubTotal
        '
        Me.Group1SubTotal.Location = New System.Drawing.Point(671, 12)
        Me.Group1SubTotal.Name = "Group1SubTotal"
        Me.Group1SubTotal.ReadOnly = True
        Me.Group1SubTotal.Size = New System.Drawing.Size(117, 22)
        Me.Group1SubTotal.TabIndex = 8
        Me.Group1SubTotal.Text = "$0.00"
        Me.Group1SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.Group1Clear)
        Me.Group1.Controls.Add(Me.Group1_5)
        Me.Group1.Controls.Add(Me.Group1_4)
        Me.Group1.Controls.Add(Me.Group1_3)
        Me.Group1.Controls.Add(Me.Group1_2)
        Me.Group1.Controls.Add(Me.Group1_1)
        Me.Group1.Controls.Add(Me.Group1Counter)
        Me.Group1.Location = New System.Drawing.Point(12, 223)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(200, 186)
        Me.Group1.TabIndex = 12
        Me.Group1.TabStop = False
        Me.Group1.Text = "Hard Drives"
        '
        'Group1Clear
        '
        Me.Group1Clear.Location = New System.Drawing.Point(141, 19)
        Me.Group1Clear.Name = "Group1Clear"
        Me.Group1Clear.Size = New System.Drawing.Size(53, 76)
        Me.Group1Clear.TabIndex = 7
        Me.Group1Clear.Text = "Clear"
        Me.Group1Clear.UseVisualStyleBackColor = True
        '
        'Group1_5
        '
        Me.Group1_5.AutoSize = True
        Me.Group1_5.Location = New System.Drawing.Point(7, 129)
        Me.Group1_5.Name = "Group1_5"
        Me.Group1_5.Size = New System.Drawing.Size(120, 20)
        Me.Group1_5.TabIndex = 6
        Me.Group1_5.Text = "18 TB ($334.99)"
        Me.Group1_5.UseVisualStyleBackColor = True
        '
        'Group1_4
        '
        Me.Group1_4.AutoSize = True
        Me.Group1_4.Location = New System.Drawing.Point(7, 102)
        Me.Group1_4.Name = "Group1_4"
        Me.Group1_4.Size = New System.Drawing.Size(120, 20)
        Me.Group1_4.TabIndex = 5
        Me.Group1_4.Text = "10 TB ($181.79)"
        Me.Group1_4.UseVisualStyleBackColor = True
        '
        'Group1_3
        '
        Me.Group1_3.AutoSize = True
        Me.Group1_3.Location = New System.Drawing.Point(7, 75)
        Me.Group1_3.Name = "Group1_3"
        Me.Group1_3.Size = New System.Drawing.Size(106, 20)
        Me.Group1_3.TabIndex = 4
        Me.Group1_3.Text = "2 TB ($70.99)"
        Me.Group1_3.UseVisualStyleBackColor = True
        '
        'Group1_2
        '
        Me.Group1_2.AutoSize = True
        Me.Group1_2.Location = New System.Drawing.Point(7, 48)
        Me.Group1_2.Name = "Group1_2"
        Me.Group1_2.Size = New System.Drawing.Size(106, 20)
        Me.Group1_2.TabIndex = 3
        Me.Group1_2.Text = "1 TB ($60.08)"
        Me.Group1_2.UseVisualStyleBackColor = True
        '
        'Group1_1
        '
        Me.Group1_1.AutoSize = True
        Me.Group1_1.Location = New System.Drawing.Point(7, 22)
        Me.Group1_1.Name = "Group1_1"
        Me.Group1_1.Size = New System.Drawing.Size(121, 20)
        Me.Group1_1.TabIndex = 2
        Me.Group1_1.Text = "500 GB ($28.62)"
        Me.Group1_1.UseVisualStyleBackColor = True
        '
        'Group1Counter
        '
        Me.Group1Counter.Location = New System.Drawing.Point(7, 155)
        Me.Group1Counter.Name = "Group1Counter"
        Me.Group1Counter.Size = New System.Drawing.Size(128, 22)
        Me.Group1Counter.TabIndex = 1
        Me.Group1Counter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ItemSelection1
        '
        Me.ItemSelection1.groupName = "Hard Drives"
        Me.ItemSelection1.isMultiple = False
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
        Me.ItemSelection1.Location = New System.Drawing.Point(378, 79)
        Me.ItemSelection1.Name = "ItemSelection1"
        Me.ItemSelection1.Size = New System.Drawing.Size(210, 195)
        Me.ItemSelection1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ItemSelection1)
        Me.Controls.Add(Me.Group1)
        Me.Controls.Add(Me.Group1SubTotal)
        Me.Controls.Add(Me.HeaderTB)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Name = "Form1"
        Me.Text = "Custom Computers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Group2_4 As RadioButton
    Friend WithEvents Group2_3 As RadioButton
    Friend WithEvents Group2_2 As RadioButton
    Friend WithEvents Group2_1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Group1SubTotal As TextBox
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents HeaderTB As TextBox
    Friend WithEvents Group2_5 As RadioButton
    Friend WithEvents Group1 As GroupBox
    Friend WithEvents Group1Clear As Button
    Friend WithEvents Group1_5 As CheckBox
    Friend WithEvents Group1_4 As CheckBox
    Friend WithEvents Group1_3 As CheckBox
    Friend WithEvents Group1_2 As CheckBox
    Friend WithEvents Group1_1 As CheckBox
    Friend WithEvents Group1Counter As NumericUpDown
    Friend WithEvents ItemSelection1 As ItemSelection
End Class
