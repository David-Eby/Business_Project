<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data
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
        Me.ItemSelection2 = New BusinessProject.ItemSelection()
        Me.ItemSelection1 = New BusinessProject.ItemSelection()
        Me.SuspendLayout()
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
        Me.ItemSelection2.Location = New System.Drawing.Point(274, 121)
        Me.ItemSelection2.Name = "ItemSelection2"
        Me.ItemSelection2.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection2.TabIndex = 20
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
        Me.ItemSelection1.Location = New System.Drawing.Point(535, 121)
        Me.ItemSelection1.Name = "ItemSelection1"
        Me.ItemSelection1.Size = New System.Drawing.Size(239, 195)
        Me.ItemSelection1.TabIndex = 19
        '
        'Data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ItemSelection2)
        Me.Controls.Add(Me.ItemSelection1)
        Me.Name = "Data"
        Me.Text = "Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ItemSelection2 As ItemSelection
    Friend WithEvents ItemSelection1 As ItemSelection
End Class
