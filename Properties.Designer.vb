<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Properties
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Properties))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Text1 = New System.Windows.Forms.TabPage()
        Me.txtnetwork = New System.Windows.Forms.RichTextBox()
        Me.Text2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.body = New System.Windows.Forms.RichTextBox()
        Me.subject = New System.Windows.Forms.TextBox()
        Me.txtmail = New System.Windows.Forms.TextBox()
        Me.txttomail = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.Text1.SuspendLayout()
        Me.Text2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Text1)
        Me.TabControl1.Controls.Add(Me.Text2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(488, 478)
        Me.TabControl1.TabIndex = 0
        '
        'Text1
        '
        Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Text1.Controls.Add(Me.txtnetwork)
        Me.Text1.Location = New System.Drawing.Point(4, 23)
        Me.Text1.Name = "Text1"
        Me.Text1.Padding = New System.Windows.Forms.Padding(3)
        Me.Text1.Size = New System.Drawing.Size(813, 493)
        Me.Text1.TabIndex = 0
        Me.Text1.Text = "Network"
        Me.Text1.UseVisualStyleBackColor = True
        '
        'txtnetwork
        '
        Me.txtnetwork.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnetwork.Location = New System.Drawing.Point(3, 3)
        Me.txtnetwork.Name = "txtnetwork"
        Me.txtnetwork.Size = New System.Drawing.Size(803, 483)
        Me.txtnetwork.TabIndex = 0
        Me.txtnetwork.Text = ""
        '
        'Text2
        '
        Me.Text2.Controls.Add(Me.Panel1)
        Me.Text2.Location = New System.Drawing.Point(4, 23)
        Me.Text2.Name = "Text2"
        Me.Text2.Padding = New System.Windows.Forms.Padding(3)
        Me.Text2.Size = New System.Drawing.Size(480, 451)
        Me.Text2.TabIndex = 1
        Me.Text2.Text = "Email"
        Me.Text2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.body)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.subject)
        Me.Panel1.Controls.Add(Me.txtmail)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txttomail)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.password)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(-4, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 448)
        Me.Panel1.TabIndex = 21
        '
        'body
        '
        Me.body.Location = New System.Drawing.Point(128, 191)
        Me.body.Name = "body"
        Me.body.Size = New System.Drawing.Size(325, 170)
        Me.body.TabIndex = 17
        Me.body.Text = ""
        '
        'subject
        '
        Me.subject.Location = New System.Drawing.Point(128, 123)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(325, 20)
        Me.subject.TabIndex = 20
        '
        'txtmail
        '
        Me.txtmail.Location = New System.Drawing.Point(128, 12)
        Me.txtmail.Name = "txtmail"
        Me.txtmail.Size = New System.Drawing.Size(325, 20)
        Me.txtmail.TabIndex = 14
        '
        'txttomail
        '
        Me.txttomail.Location = New System.Drawing.Point(128, 50)
        Me.txttomail.Name = "txttomail"
        Me.txttomail.Size = New System.Drawing.Size(325, 20)
        Me.txttomail.TabIndex = 15
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(128, 84)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(325, 20)
        Me.password.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(27, 407)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(426, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Subject"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 14)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Body"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Email"
        '
        'Properties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 478)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Properties"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Properties"
        Me.TabControl1.ResumeLayout(False)
        Me.Text1.ResumeLayout(False)
        Me.Text2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Text2 As System.Windows.Forms.TabPage
    Friend WithEvents Text1 As System.Windows.Forms.TabPage
    Friend WithEvents txtnetwork As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents body As System.Windows.Forms.RichTextBox
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents txttomail As System.Windows.Forms.TextBox
    Friend WithEvents txtmail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents subject As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
