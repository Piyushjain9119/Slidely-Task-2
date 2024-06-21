<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIEW
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(173, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 35)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(173, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 35)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(173, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 35)
        Label3.TabIndex = 2
        Label3.Text = "Phone Number"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(173, 259)
        Label4.Name = "Label4"
        Label4.Size = New Size(260, 35)
        Label4.TabIndex = 3
        Label4.Text = "GitHub Link For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15F)
        Label5.Location = New Point(173, 329)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 35)
        Label5.TabIndex = 4
        Label5.Text = "Stopwatch Timer"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ScrollBar
        TextBox1.Font = New Font("Segoe UI", 12F)
        TextBox1.Location = New Point(454, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(248, 34)
        TextBox1.TabIndex = 5
        TextBox1.Text = "Piyush Jain"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ScrollBar
        TextBox2.Font = New Font("Segoe UI", 9F)
        TextBox2.Location = New Point(454, 150)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(248, 27)
        TextBox2.TabIndex = 6
        TextBox2.Text = "piyushjain1419@gmail.com"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ScrollBar
        TextBox3.Location = New Point(454, 212)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(248, 27)
        TextBox3.TabIndex = 7
        TextBox3.Text = "9310626731"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.ScrollBar
        TextBox4.Location = New Point(454, 259)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(248, 27)
        TextBox4.TabIndex = 8
        TextBox4.Text = "https://github.com"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.ScrollBar
        TextBox5.Location = New Point(454, 329)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(248, 27)
        TextBox5.TabIndex = 9
        TextBox5.Text = "00:01:19"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.Location = New Point(75, 393)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 45)
        Button1.TabIndex = 10
        Button1.Text = "PREVIOUS (CTRL +P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.Location = New Point(454, 393)
        Button2.Name = "Button2"
        Button2.Size = New Size(253, 45)
        Button2.TabIndex = 11
        Button2.Text = "NEXT (CTRL +N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' VIEW
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuBar
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "VIEW"
        Text = "VIEW SUBMISSION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
