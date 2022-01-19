<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreeViewControl
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File1", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("File2")
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.lblNo1 = New System.Windows.Forms.Label()
        Me.lblNo2 = New System.Windows.Forms.Label()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.lblNo3 = New System.Windows.Forms.Label()
        Me.btnNo1 = New System.Windows.Forms.Button()
        Me.btnAddChild = New System.Windows.Forms.Button()
        Me.btnExpand = New System.Windows.Forms.Button()
        Me.btnClearallNodes = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(63, 96)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = ""
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "File1"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = ""
        TreeNode4.Name = "Node3"
        TreeNode4.Text = "File2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
        Me.TreeView1.Size = New System.Drawing.Size(156, 239)
        Me.TreeView1.TabIndex = 0
        '
        'lblNo1
        '
        Me.lblNo1.AutoSize = True
        Me.lblNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo1.Location = New System.Drawing.Point(60, 61)
        Me.lblNo1.Name = "lblNo1"
        Me.lblNo1.Size = New System.Drawing.Size(111, 24)
        Me.lblNo1.TabIndex = 1
        Me.lblNo1.Text = "TreeView1"
        '
        'lblNo2
        '
        Me.lblNo2.AutoSize = True
        Me.lblNo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo2.Location = New System.Drawing.Point(376, 61)
        Me.lblNo2.Name = "lblNo2"
        Me.lblNo2.Size = New System.Drawing.Size(111, 24)
        Me.lblNo2.TabIndex = 2
        Me.lblNo2.Text = "TreeView2"
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(370, 96)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(156, 239)
        Me.TreeView2.TabIndex = 3
        '
        'lblNo3
        '
        Me.lblNo3.AutoSize = True
        Me.lblNo3.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo3.Location = New System.Drawing.Point(294, 22)
        Me.lblNo3.Name = "lblNo3"
        Me.lblNo3.Size = New System.Drawing.Size(282, 21)
        Me.lblNo3.TabIndex = 4
        Me.lblNo3.Text = "Tree view COntrol example"
        '
        'btnNo1
        '
        Me.btnNo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo1.Location = New System.Drawing.Point(701, 96)
        Me.btnNo1.Name = "btnNo1"
        Me.btnNo1.Size = New System.Drawing.Size(167, 41)
        Me.btnNo1.TabIndex = 5
        Me.btnNo1.Text = "Add Root"
        Me.btnNo1.UseVisualStyleBackColor = True
        '
        'btnAddChild
        '
        Me.btnAddChild.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddChild.Location = New System.Drawing.Point(701, 143)
        Me.btnAddChild.Name = "btnAddChild"
        Me.btnAddChild.Size = New System.Drawing.Size(167, 41)
        Me.btnAddChild.TabIndex = 6
        Me.btnAddChild.Text = "Add Child"
        Me.btnAddChild.UseVisualStyleBackColor = True
        '
        'btnExpand
        '
        Me.btnExpand.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpand.Location = New System.Drawing.Point(701, 190)
        Me.btnExpand.Name = "btnExpand"
        Me.btnExpand.Size = New System.Drawing.Size(167, 41)
        Me.btnExpand.TabIndex = 7
        Me.btnExpand.Text = "Expand"
        Me.btnExpand.UseVisualStyleBackColor = True
        '
        'btnClearallNodes
        '
        Me.btnClearallNodes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearallNodes.Location = New System.Drawing.Point(701, 237)
        Me.btnClearallNodes.Name = "btnClearallNodes"
        Me.btnClearallNodes.Size = New System.Drawing.Size(167, 41)
        Me.btnClearallNodes.TabIndex = 8
        Me.btnClearallNodes.Text = "Clear all Nodes"
        Me.btnClearallNodes.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(701, 284)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 41)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Add Root"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(701, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 41)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Add Root"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(701, 378)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(167, 41)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Add Root"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TreeViewControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 446)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnClearallNodes)
        Me.Controls.Add(Me.btnExpand)
        Me.Controls.Add(Me.btnAddChild)
        Me.Controls.Add(Me.btnNo1)
        Me.Controls.Add(Me.lblNo3)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.lblNo2)
        Me.Controls.Add(Me.lblNo1)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "TreeViewControl"
        Me.Text = "TreeViewControl"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lblNo1 As System.Windows.Forms.Label
    Friend WithEvents lblNo2 As System.Windows.Forms.Label
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents lblNo3 As System.Windows.Forms.Label
    Friend WithEvents btnNo1 As System.Windows.Forms.Button
    Friend WithEvents btnAddChild As System.Windows.Forms.Button
    Friend WithEvents btnExpand As System.Windows.Forms.Button
    Friend WithEvents btnClearallNodes As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
