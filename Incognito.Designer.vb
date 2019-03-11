<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Incognito
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RbNoHisRem = New System.Windows.Forms.RadioButton()
        Me.RbHisRem = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.RbNoHisRem)
        Me.GroupBox1.Controls.Add(Me.RbHisRem)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "History"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "[Incognito Mode On]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "[Incognito Mode Off]"
        '
        'RbNoHisRem
        '
        Me.RbNoHisRem.AutoSize = True
        Me.RbNoHisRem.Location = New System.Drawing.Point(6, 88)
        Me.RbNoHisRem.Name = "RbNoHisRem"
        Me.RbNoHisRem.Size = New System.Drawing.Size(166, 19)
        Me.RbNoHisRem.TabIndex = 1
        Me.RbNoHisRem.TabStop = True
        Me.RbNoHisRem.Text = "Never Remember History"
        Me.RbNoHisRem.UseVisualStyleBackColor = True
        '
        'RbHisRem
        '
        Me.RbHisRem.AutoSize = True
        Me.RbHisRem.Location = New System.Drawing.Point(6, 31)
        Me.RbHisRem.Name = "RbHisRem"
        Me.RbHisRem.Size = New System.Drawing.Size(130, 19)
        Me.RbHisRem.TabIndex = 0
        Me.RbHisRem.TabStop = True
        Me.RbHisRem.Text = "Remember History"
        Me.RbHisRem.UseVisualStyleBackColor = True
        '
        'Incognito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(331, 264)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Incognito"
        Me.Text = "Incognito"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RbNoHisRem As System.Windows.Forms.RadioButton
    Friend WithEvents RbHisRem As System.Windows.Forms.RadioButton
End Class
