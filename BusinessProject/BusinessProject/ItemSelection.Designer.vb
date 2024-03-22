<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemSelection
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Group1 = New System.Windows.Forms.GroupBox()
        Me.subTotalText = New System.Windows.Forms.TextBox()
        Me.Item5 = New System.Windows.Forms.RadioButton()
        Me.Item4 = New System.Windows.Forms.RadioButton()
        Me.Item3 = New System.Windows.Forms.RadioButton()
        Me.Item2 = New System.Windows.Forms.RadioButton()
        Me.Item1 = New System.Windows.Forms.RadioButton()
        Me.Group1Clear = New System.Windows.Forms.Button()
        Me.Item5M = New System.Windows.Forms.CheckBox()
        Me.Item4M = New System.Windows.Forms.CheckBox()
        Me.Item3M = New System.Windows.Forms.CheckBox()
        Me.Item2M = New System.Windows.Forms.CheckBox()
        Me.Item1M = New System.Windows.Forms.CheckBox()
        Me.Group1Counter = New System.Windows.Forms.NumericUpDown()
        Me.brainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Group1.SuspendLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group1
        '
        Me.Group1.Controls.Add(Me.subTotalText)
        Me.Group1.Controls.Add(Me.Item5)
        Me.Group1.Controls.Add(Me.Item4)
        Me.Group1.Controls.Add(Me.Item3)
        Me.Group1.Controls.Add(Me.Item2)
        Me.Group1.Controls.Add(Me.Item1)
        Me.Group1.Controls.Add(Me.Group1Clear)
        Me.Group1.Controls.Add(Me.Item5M)
        Me.Group1.Controls.Add(Me.Item4M)
        Me.Group1.Controls.Add(Me.Item3M)
        Me.Group1.Controls.Add(Me.Item2M)
        Me.Group1.Controls.Add(Me.Item1M)
        Me.Group1.Controls.Add(Me.Group1Counter)
        Me.Group1.Location = New System.Drawing.Point(3, 3)
        Me.Group1.Name = "Group1"
        Me.Group1.Size = New System.Drawing.Size(204, 189)
        Me.Group1.TabIndex = 13
        Me.Group1.TabStop = False
        Me.Group1.Text = "Group"
        '
        'subTotalText
        '
        Me.subTotalText.Location = New System.Drawing.Point(79, 155)
        Me.subTotalText.Name = "subTotalText"
        Me.subTotalText.Size = New System.Drawing.Size(119, 22)
        Me.subTotalText.TabIndex = 13
        Me.subTotalText.Text = "$0.00"
        '
        'Item5
        '
        Me.Item5.AutoSize = True
        Me.Item5.Location = New System.Drawing.Point(7, 128)
        Me.Item5.Name = "Item5"
        Me.Item5.Size = New System.Drawing.Size(65, 20)
        Me.Item5.TabIndex = 12
        Me.Item5.TabStop = True
        Me.Item5.Text = "Name"
        Me.Item5.UseVisualStyleBackColor = True
        '
        'Item4
        '
        Me.Item4.AutoSize = True
        Me.Item4.Location = New System.Drawing.Point(7, 101)
        Me.Item4.Name = "Item4"
        Me.Item4.Size = New System.Drawing.Size(65, 20)
        Me.Item4.TabIndex = 11
        Me.Item4.TabStop = True
        Me.Item4.Text = "Name"
        Me.Item4.UseVisualStyleBackColor = True
        '
        'Item3
        '
        Me.Item3.AutoSize = True
        Me.Item3.Location = New System.Drawing.Point(7, 74)
        Me.Item3.Name = "Item3"
        Me.Item3.Size = New System.Drawing.Size(65, 20)
        Me.Item3.TabIndex = 10
        Me.Item3.TabStop = True
        Me.Item3.Text = "Name"
        Me.Item3.UseVisualStyleBackColor = True
        '
        'Item2
        '
        Me.Item2.AutoSize = True
        Me.Item2.Location = New System.Drawing.Point(7, 47)
        Me.Item2.Name = "Item2"
        Me.Item2.Size = New System.Drawing.Size(65, 20)
        Me.Item2.TabIndex = 9
        Me.Item2.TabStop = True
        Me.Item2.Text = "Name"
        Me.Item2.UseVisualStyleBackColor = True
        '
        'Item1
        '
        Me.Item1.AutoSize = True
        Me.Item1.Location = New System.Drawing.Point(7, 21)
        Me.Item1.Name = "Item1"
        Me.Item1.Size = New System.Drawing.Size(65, 20)
        Me.Item1.TabIndex = 8
        Me.Item1.TabStop = True
        Me.Item1.Text = "Name"
        Me.Item1.UseVisualStyleBackColor = True
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
        'Item5M
        '
        Me.Item5M.AutoSize = True
        Me.Item5M.Location = New System.Drawing.Point(7, 129)
        Me.Item5M.Name = "Item5M"
        Me.Item5M.Size = New System.Drawing.Size(66, 20)
        Me.Item5M.TabIndex = 6
        Me.Item5M.Text = "Name"
        Me.Item5M.UseVisualStyleBackColor = True
        Me.Item5M.Visible = False
        '
        'Item4M
        '
        Me.Item4M.AutoSize = True
        Me.Item4M.Location = New System.Drawing.Point(7, 102)
        Me.Item4M.Name = "Item4M"
        Me.Item4M.Size = New System.Drawing.Size(66, 20)
        Me.Item4M.TabIndex = 5
        Me.Item4M.Text = "Name"
        Me.Item4M.UseVisualStyleBackColor = True
        Me.Item4M.Visible = False
        '
        'Item3M
        '
        Me.Item3M.AutoSize = True
        Me.Item3M.Location = New System.Drawing.Point(7, 75)
        Me.Item3M.Name = "Item3M"
        Me.Item3M.Size = New System.Drawing.Size(66, 20)
        Me.Item3M.TabIndex = 4
        Me.Item3M.Text = "Name"
        Me.Item3M.UseVisualStyleBackColor = True
        Me.Item3M.Visible = False
        '
        'Item2M
        '
        Me.Item2M.AutoSize = True
        Me.Item2M.Location = New System.Drawing.Point(7, 48)
        Me.Item2M.Name = "Item2M"
        Me.Item2M.Size = New System.Drawing.Size(66, 20)
        Me.Item2M.TabIndex = 3
        Me.Item2M.Text = "Name"
        Me.Item2M.UseVisualStyleBackColor = True
        Me.Item2M.Visible = False
        '
        'Item1M
        '
        Me.Item1M.AutoSize = True
        Me.Item1M.Location = New System.Drawing.Point(7, 22)
        Me.Item1M.Name = "Item1M"
        Me.Item1M.Size = New System.Drawing.Size(66, 20)
        Me.Item1M.TabIndex = 2
        Me.Item1M.Text = "Name"
        Me.Item1M.UseVisualStyleBackColor = True
        Me.Item1M.Visible = False
        '
        'Group1Counter
        '
        Me.Group1Counter.Location = New System.Drawing.Point(7, 155)
        Me.Group1Counter.Name = "Group1Counter"
        Me.Group1Counter.Size = New System.Drawing.Size(66, 22)
        Me.Group1Counter.TabIndex = 1
        Me.Group1Counter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'brainTimer
        '
        Me.brainTimer.Enabled = True
        Me.brainTimer.Interval = 50
        '
        'ItemSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Group1)
        Me.Name = "ItemSelection"
        Me.Size = New System.Drawing.Size(210, 195)
        Me.Group1.ResumeLayout(False)
        Me.Group1.PerformLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Group1 As GroupBox
    Friend WithEvents Group1Clear As Button
    Friend WithEvents Item5M As CheckBox
    Friend WithEvents Item4M As CheckBox
    Friend WithEvents Item3M As CheckBox
    Friend WithEvents Item2M As CheckBox
    Friend WithEvents Item1M As CheckBox
    Friend WithEvents Group1Counter As NumericUpDown
    Friend WithEvents Item5 As RadioButton
    Friend WithEvents Item4 As RadioButton
    Friend WithEvents Item3 As RadioButton
    Friend WithEvents Item2 As RadioButton
    Friend WithEvents Item1 As RadioButton
    Friend WithEvents brainTimer As Timer
    Friend WithEvents subTotalText As TextBox
End Class
