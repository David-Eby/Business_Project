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
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.brainTotal = New System.Windows.Forms.TextBox()
        Me.brainButton = New System.Windows.Forms.Button()
        Me.calcPrice = New System.Windows.Forms.Timer(Me.components)
        Me.dataButton = New System.Windows.Forms.Button()
        Me.dataTotal = New System.Windows.Forms.TextBox()
        Me.bodyTotal = New System.Windows.Forms.TextBox()
        Me.bodyButton = New System.Windows.Forms.Button()
        Me.externalsTotal = New System.Windows.Forms.TextBox()
        Me.externalsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'bodyTotal
        '
        Me.bodyTotal.Location = New System.Drawing.Point(224, 40)
        Me.bodyTotal.Name = "bodyTotal"
        Me.bodyTotal.ReadOnly = True
        Me.bodyTotal.Size = New System.Drawing.Size(100, 22)
        Me.bodyTotal.TabIndex = 23
        Me.bodyTotal.Text = "$0.00"
        Me.bodyTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bodyButton
        '
        Me.bodyButton.Location = New System.Drawing.Point(224, 12)
        Me.bodyButton.Name = "bodyButton"
        Me.bodyButton.Size = New System.Drawing.Size(100, 23)
        Me.bodyButton.TabIndex = 22
        Me.bodyButton.Text = "Body"
        Me.bodyButton.UseVisualStyleBackColor = True
        '
        'externalsTotal
        '
        Me.externalsTotal.Location = New System.Drawing.Point(330, 40)
        Me.externalsTotal.Name = "externalsTotal"
        Me.externalsTotal.ReadOnly = True
        Me.externalsTotal.Size = New System.Drawing.Size(100, 22)
        Me.externalsTotal.TabIndex = 25
        Me.externalsTotal.Text = "$0.00"
        Me.externalsTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'externalsButton
        '
        Me.externalsButton.Location = New System.Drawing.Point(330, 12)
        Me.externalsButton.Name = "externalsButton"
        Me.externalsButton.Size = New System.Drawing.Size(100, 23)
        Me.externalsButton.TabIndex = 24
        Me.externalsButton.Text = "Externals"
        Me.externalsButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(618, 91)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Computer Buyer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.externalsTotal)
        Me.Controls.Add(Me.externalsButton)
        Me.Controls.Add(Me.bodyTotal)
        Me.Controls.Add(Me.bodyButton)
        Me.Controls.Add(Me.dataTotal)
        Me.Controls.Add(Me.dataButton)
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
    Friend WithEvents dataButton As Button
    Friend WithEvents dataTotal As TextBox
    Friend WithEvents bodyTotal As TextBox
    Friend WithEvents bodyButton As Button
    Friend WithEvents externalsTotal As TextBox
    Friend WithEvents externalsButton As Button
    Friend WithEvents Label1 As Label
End Class
