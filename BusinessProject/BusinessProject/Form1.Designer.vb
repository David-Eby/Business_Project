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
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.Group1Clear = New System.Windows.Forms.Button()
        Me.Group1_5 = New System.Windows.Forms.CheckBox()
        Me.Group1_4 = New System.Windows.Forms.CheckBox()
        Me.Group1_3 = New System.Windows.Forms.CheckBox()
        Me.Group1_2 = New System.Windows.Forms.CheckBox()
        Me.Group1_1 = New System.Windows.Forms.CheckBox()
        Me.Group1Counter = New System.Windows.Forms.NumericUpDown()
        Me.Group1SubTotal = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Group2_1 = New System.Windows.Forms.RadioButton()
        Me.Group2_2 = New System.Windows.Forms.RadioButton()
        Me.Group2_3 = New System.Windows.Forms.RadioButton()
        Me.Group2_4 = New System.Windows.Forms.RadioButton()
        Me.Group2_5 = New System.Windows.Forms.RadioButton()
        Me.Group1.SuspendLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Group1.Controls.Add(Me.Group1SubTotal)
        Me.Group1.Location = New System.Drawing.Point(12, 12)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(200, 186)
        Me.Group1.TabIndex = 0
        Me.Group1.TabStop = False
        Me.Group1.Text = "Hard Drives"
        '
        'Group1Clear
        '
        Me.Group1Clear.Location = New System.Drawing.Point(141, 19)
        Me.Group1Clear.Name = "Group1Clear"
        Me.Group1Clear.Size = New System.Drawing.Size(53, 49)
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
        Me.Group1Counter.Size = New System.Drawing.Size(64, 22)
        Me.Group1Counter.TabIndex = 1
        Me.Group1Counter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Group1SubTotal
        '
        Me.Group1SubTotal.AutoSize = True
        Me.Group1SubTotal.Location = New System.Drawing.Point(77, 161)
        Me.Group1SubTotal.Name = "Group1SubTotal"
        Me.Group1SubTotal.Size = New System.Drawing.Size(38, 16)
        Me.Group1SubTotal.TabIndex = 1
        Me.Group1SubTotal.Text = "$0.00"
        Me.Group1SubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(12, 415)
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
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 192)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CPU"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 49)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(7, 155)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(64, 22)
        Me.NumericUpDown1.TabIndex = 1
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "$0.00"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Group2_1
        '
        Me.Group2_1.AutoSize = True
        Me.Group2_1.Location = New System.Drawing.Point(7, 22)
        Me.Group2_1.Name = "Group2_1"
        Me.Group2_1.Size = New System.Drawing.Size(109, 20)
        Me.Group2_1.TabIndex = 8
        Me.Group2_1.TabStop = True
        Me.Group2_1.Text = "RadioButton1"
        Me.Group2_1.UseVisualStyleBackColor = True
        '
        'Group2_2
        '
        Me.Group2_2.AutoSize = True
        Me.Group2_2.Location = New System.Drawing.Point(7, 47)
        Me.Group2_2.Name = "Group2_2"
        Me.Group2_2.Size = New System.Drawing.Size(109, 20)
        Me.Group2_2.TabIndex = 9
        Me.Group2_2.TabStop = True
        Me.Group2_2.Text = "RadioButton2"
        Me.Group2_2.UseVisualStyleBackColor = True
        '
        'Group2_3
        '
        Me.Group2_3.AutoSize = True
        Me.Group2_3.Location = New System.Drawing.Point(7, 75)
        Me.Group2_3.Name = "Group2_3"
        Me.Group2_3.Size = New System.Drawing.Size(109, 20)
        Me.Group2_3.TabIndex = 10
        Me.Group2_3.TabStop = True
        Me.Group2_3.Text = "RadioButton3"
        Me.Group2_3.UseVisualStyleBackColor = True
        '
        'Group2_4
        '
        Me.Group2_4.AutoSize = True
        Me.Group2_4.Location = New System.Drawing.Point(7, 102)
        Me.Group2_4.Name = "Group2_4"
        Me.Group2_4.Size = New System.Drawing.Size(109, 20)
        Me.Group2_4.TabIndex = 11
        Me.Group2_4.TabStop = True
        Me.Group2_4.Text = "RadioButton4"
        Me.Group2_4.UseVisualStyleBackColor = True
        '
        'Group2_5
        '
        Me.Group2_5.AutoSize = True
        Me.Group2_5.Location = New System.Drawing.Point(7, 129)
        Me.Group2_5.Name = "Group2_5"
        Me.Group2_5.Size = New System.Drawing.Size(109, 20)
        Me.Group2_5.TabIndex = 12
        Me.Group2_5.TabStop = True
        Me.Group2_5.Text = "RadioButton5"
        Me.Group2_5.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Group1)
        Me.Name = "Form1"
        Me.Text = "Custom Computers"
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group1 As GroupBox
    Friend WithEvents Group1Counter As NumericUpDown
    Friend WithEvents Group1SubTotal As Label
    Friend WithEvents ConfirmButton As Button
    Friend WithEvents Group1_5 As CheckBox
    Friend WithEvents Group1_4 As CheckBox
    Friend WithEvents Group1_3 As CheckBox
    Friend WithEvents Group1_2 As CheckBox
    Friend WithEvents Group1_1 As CheckBox
    Friend WithEvents Group1Clear As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Group2_5 As RadioButton
    Friend WithEvents Group2_4 As RadioButton
    Friend WithEvents Group2_3 As RadioButton
    Friend WithEvents Group2_2 As RadioButton
    Friend WithEvents Group2_1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
