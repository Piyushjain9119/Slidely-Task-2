<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F)
        Label1.Location = New Point(168, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 35)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15F)
        Label2.Location = New Point(168, 119)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 35)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15F)
        Label3.Location = New Point(168, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(147, 35)
        Label3.TabIndex = 2
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15F)
        Label4.Location = New Point(168, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(186, 35)
        Label4.TabIndex = 3
        Label4.Text = "Stopwatch time"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(401, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(236, 27)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(401, 127)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(236, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(401, 199)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(236, 27)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(401, 266)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(236, 27)
        TextBox5.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Info
        Button1.Location = New Point(64, 336)
        Button1.Name = "Button1"
        Button1.Size = New Size(273, 41)
        Button1.TabIndex = 9
        Button1.Text = "TOGGLE STOPWATCH(CTRL+C"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 15F)
        Button2.Location = New Point(64, 397)
        Button2.Name = "Button2"
        Button2.Size = New Size(676, 41)
        Button2.TabIndex = 10
        Button2.Text = "SUBMIT(CTRL +S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.InactiveCaption
        TextBox2.Font = New Font("Segoe UI", 15F)
        TextBox2.Location = New Point(523, 336)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(114, 41)
        TextBox2.TabIndex = 11
        TextBox2.Text = "00:00:00"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
End Class
