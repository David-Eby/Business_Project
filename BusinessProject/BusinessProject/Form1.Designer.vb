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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Group1Counter = New System.Windows.Forms.NumericUpDown()
        Me.Group1_3 = New System.Windows.Forms.RadioButton()
        Me.Group1_2 = New System.Windows.Forms.RadioButton()
        Me.Group1_1 = New System.Windows.Forms.RadioButton()
        Me.Group1SubTotal = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Group1Counter)
        Me.GroupBox1.Controls.Add(Me.Group1SubTotal)
        Me.GroupBox1.Controls.Add(Me.Group1_3)
        Me.GroupBox1.Controls.Add(Me.Group1_2)
        Me.GroupBox1.Controls.Add(Me.Group1_1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Group1Counter
        '
        Me.Group1Counter.Location = New System.Drawing.Point(7, 102)
        Me.Group1Counter.Name = "Group1Counter"
        Me.Group1Counter.Size = New System.Drawing.Size(120, 22)
        Me.Group1Counter.TabIndex = 1
        Me.Group1Counter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Group1_3
        '
        Me.Group1_3.AutoSize = True
        Me.Group1_3.Location = New System.Drawing.Point(7, 76)
        Me.Group1_3.Name = "Group1_3"
        Me.Group1_3.Size = New System.Drawing.Size(35, 20)
        Me.Group1_3.TabIndex = 2
        Me.Group1_3.TabStop = True
        Me.Group1_3.Text = "7"
        Me.Group1_3.UseVisualStyleBackColor = True
        '
        'Group1_2
        '
        Me.Group1_2.AutoSize = True
        Me.Group1_2.Location = New System.Drawing.Point(7, 49)
        Me.Group1_2.Name = "Group1_2"
        Me.Group1_2.Size = New System.Drawing.Size(42, 20)
        Me.Group1_2.TabIndex = 1
        Me.Group1_2.TabStop = True
        Me.Group1_2.Text = "10"
        Me.Group1_2.UseVisualStyleBackColor = True
        '
        'Group1_1
        '
        Me.Group1_1.AutoSize = True
        Me.Group1_1.Location = New System.Drawing.Point(7, 22)
        Me.Group1_1.Name = "Group1_1"
        Me.Group1_1.Size = New System.Drawing.Size(35, 20)
        Me.Group1_1.TabIndex = 0
        Me.Group1_1.TabStop = True
        Me.Group1_1.Text = "5"
        Me.Group1_1.UseVisualStyleBackColor = True
        '
        'Group1SubTotal
        '
        Me.Group1SubTotal.AutoSize = True
        Me.Group1SubTotal.Location = New System.Drawing.Point(146, 18)
        Me.Group1SubTotal.Name = "Group1SubTotal"
        Me.Group1SubTotal.Size = New System.Drawing.Size(48, 16)
        Me.Group1SubTotal.TabIndex = 1
        Me.Group1SubTotal.Text = "Label1"
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Custom Computers"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Group1Counter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Group1Counter As NumericUpDown
    Friend WithEvents Group1_3 As RadioButton
    Friend WithEvents Group1_2 As RadioButton
    Friend WithEvents Group1_1 As RadioButton
    Friend WithEvents Group1SubTotal As Label
    Friend WithEvents ConfirmButton As Button
End Class
