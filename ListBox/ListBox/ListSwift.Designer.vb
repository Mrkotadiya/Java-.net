<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListSwift
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
        Me.lblNo1 = New System.Windows.Forms.Label()
        Me.lstCity2 = New System.Windows.Forms.ListBox()
        Me.lstCity1 = New System.Windows.Forms.ListBox()
        Me.btnShiftRight = New System.Windows.Forms.Button()
        Me.btnAllShift = New System.Windows.Forms.Button()
        Me.btnLeftShift = New System.Windows.Forms.Button()
        Me.btnAllLeftShift = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNo1
        '
        Me.lblNo1.AutoSize = True
        Me.lblNo1.Font = New System.Drawing.Font("Algerian", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo1.Location = New System.Drawing.Point(42, 31)
        Me.lblNo1.Name = "lblNo1"
        Me.lblNo1.Size = New System.Drawing.Size(50, 21)
        Me.lblNo1.TabIndex = 5
        Me.lblNo1.Text = "City"
        '
        'lstCity2
        '
        Me.lstCity2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCity2.FormattingEnabled = True
        Me.lstCity2.ItemHeight = 24
        Me.lstCity2.Location = New System.Drawing.Point(594, 31)
        Me.lstCity2.Name = "lstCity2"
        Me.lstCity2.Size = New System.Drawing.Size(182, 244)
        Me.lstCity2.TabIndex = 4
        '
        'lstCity1
        '
        Me.lstCity1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCity1.FormattingEnabled = True
        Me.lstCity1.ItemHeight = 24
        Me.lstCity1.Items.AddRange(New Object() {"Surat", "Bharuch", "Navsari", "Ahemadabad", "Mumbai"})
        Me.lstCity1.Location = New System.Drawing.Point(120, 31)
        Me.lstCity1.Name = "lstCity1"
        Me.lstCity1.Size = New System.Drawing.Size(225, 244)
        Me.lstCity1.TabIndex = 3
        '
        'btnShiftRight
        '
        Me.btnShiftRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShiftRight.Location = New System.Drawing.Point(378, 74)
        Me.btnShiftRight.Name = "btnShiftRight"
        Me.btnShiftRight.Size = New System.Drawing.Size(75, 52)
        Me.btnShiftRight.TabIndex = 7
        Me.btnShiftRight.Text = ">"
        Me.btnShiftRight.UseVisualStyleBackColor = True
        '
        'btnAllShift
        '
        Me.btnAllShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllShift.Location = New System.Drawing.Point(481, 71)
        Me.btnAllShift.Name = "btnAllShift"
        Me.btnAllShift.Size = New System.Drawing.Size(75, 55)
        Me.btnAllShift.TabIndex = 8
        Me.btnAllShift.Text = ">>"
        Me.btnAllShift.UseVisualStyleBackColor = True
        '
        'btnLeftShift
        '
        Me.btnLeftShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeftShift.Location = New System.Drawing.Point(378, 175)
        Me.btnLeftShift.Name = "btnLeftShift"
        Me.btnLeftShift.Size = New System.Drawing.Size(75, 52)
        Me.btnLeftShift.TabIndex = 9
        Me.btnLeftShift.Text = "<"
        Me.btnLeftShift.UseVisualStyleBackColor = True
        '
        'btnAllLeftShift
        '
        Me.btnAllLeftShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAllLeftShift.Location = New System.Drawing.Point(481, 175)
        Me.btnAllLeftShift.Name = "btnAllLeftShift"
        Me.btnAllLeftShift.Size = New System.Drawing.Size(75, 55)
        Me.btnAllLeftShift.TabIndex = 10
        Me.btnAllLeftShift.Text = "<<"
        Me.btnAllLeftShift.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(275, 308)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(110, 40)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(432, 308)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(110, 40)
        Me.btnRemove.TabIndex = 12
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(46, 314)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(186, 29)
        Me.txtCity.TabIndex = 13
        '
        'ListSwift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 549)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnAllLeftShift)
        Me.Controls.Add(Me.btnLeftShift)
        Me.Controls.Add(Me.btnAllShift)
        Me.Controls.Add(Me.btnShiftRight)
        Me.Controls.Add(Me.lblNo1)
        Me.Controls.Add(Me.lstCity2)
        Me.Controls.Add(Me.lstCity1)
        Me.Name = "ListSwift"
        Me.Text = "ListSwift"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNo1 As System.Windows.Forms.Label
    Friend WithEvents lstCity2 As System.Windows.Forms.ListBox
    Friend WithEvents lstCity1 As System.Windows.Forms.ListBox
    Friend WithEvents btnShiftRight As System.Windows.Forms.Button
    Friend WithEvents btnAllShift As System.Windows.Forms.Button
    Friend WithEvents btnLeftShift As System.Windows.Forms.Button
    Friend WithEvents btnAllLeftShift As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
End Class
