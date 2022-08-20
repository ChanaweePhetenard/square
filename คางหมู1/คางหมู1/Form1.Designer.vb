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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_a1 = New System.Windows.Forms.TextBox()
        Me.txt_a2 = New System.Windows.Forms.TextBox()
        Me.txt_high = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(115, 201)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 53)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(291, 201)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 53)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "ล้าง"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(37, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "พื้นที่สี่เหลี่ยมคางหมู = 1/2 x"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(251, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "("
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(315, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 28)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "+"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(383, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = ")"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(407, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 28)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "x"
        '
        'txt_a1
        '
        Me.txt_a1.Location = New System.Drawing.Point(275, 56)
        Me.txt_a1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_a1.Name = "txt_a1"
        Me.txt_a1.Size = New System.Drawing.Size(33, 27)
        Me.txt_a1.TabIndex = 7
        '
        'txt_a2
        '
        Me.txt_a2.Location = New System.Drawing.Point(343, 53)
        Me.txt_a2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_a2.Name = "txt_a2"
        Me.txt_a2.Size = New System.Drawing.Size(33, 27)
        Me.txt_a2.TabIndex = 8
        '
        'txt_high
        '
        Me.txt_high.Location = New System.Drawing.Point(433, 56)
        Me.txt_high.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_high.Name = "txt_high"
        Me.txt_high.Size = New System.Drawing.Size(33, 27)
        Me.txt_high.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(37, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(185, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "พื้นที่สี่เหลี่ยมคางหมู = "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(203, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 28)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "......"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(251, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 28)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ตารางเซนติเมตร"
        '
        'btExit
        '
        Me.btExit.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btExit.Location = New System.Drawing.Point(205, 286)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(103, 57)
        Me.btExit.TabIndex = 13
        Me.btExit.Text = "ออก"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 392)
        Me.ControlBox = False
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_high)
        Me.Controls.Add(Me.txt_a2)
        Me.Controls.Add(Me.txt_a1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_a1 As TextBox
    Friend WithEvents txt_a2 As TextBox
    Friend WithEvents txt_high As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btExit As Button
End Class
