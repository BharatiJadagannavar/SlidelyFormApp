<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmission
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
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        hh = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 247)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 20)
        Label1.TabIndex = 0
        Label1.Text = "Stop Watch"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Location = New Point(84, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 20)
        Label3.TabIndex = 2
        Label3.Text = "Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(84, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 3
        Label4.Text = "Email"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        Button1.Font = New Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(131, 329)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 5
        Button1.Text = "Previous"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(410, 329)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Next"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(84, 65)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 20)
        Label6.TabIndex = 7
        Label6.Text = "Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.AppWorkspace
        TextBox1.Location = New Point(255, 247)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(280, 27)
        TextBox1.TabIndex = 8
        TextBox1.Text = "00:01:19"
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.AppWorkspace
        TextBox2.Location = New Point(255, 62)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(280, 27)
        TextBox2.TabIndex = 9
        TextBox2.Text = "John Doe"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.AppWorkspace
        TextBox3.Location = New Point(255, 204)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(280, 27)
        TextBox3.TabIndex = 10
        TextBox3.Text = "1234567890"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = SystemColors.AppWorkspace
        TextBox4.Location = New Point(255, 108)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(280, 27)
        TextBox4.TabIndex = 11
        TextBox4.Text = "john.doe@example.com"
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = SystemColors.AppWorkspace
        TextBox5.Location = New Point(255, 152)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(280, 27)
        TextBox5.TabIndex = 12
        TextBox5.Text = "https://github.com/johndoe/task2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(84, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 20)
        Label5.TabIndex = 13
        Label5.Text = "GitHub"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(84, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 20)
        Label2.TabIndex = 14
        Label2.Text = "Phone"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(92, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 20)
        Label7.TabIndex = 15
        Label7.Text = "Label7"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(255, 19)
        Label8.Name = "Label8"
        Label8.Size = New Size(296, 20)
        Label8.TabIndex = 16
        Label8.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' hh
        ' 
        hh.FormattingEnabled = True
        hh.Items.AddRange(New Object() {"Option 1", "Option 2", "Option 3"})
        hh.Location = New Point(279, 295)
        hh.Name = "hh"
        hh.Size = New Size(200, 28)
        hh.TabIndex = 0
        ' 
        ' ViewSubmission
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(hh)
        Name = "ViewSubmission"
        Text = "ViewSubmision"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Private WithEvents Label6 As Label
    Private WithEvents TextBox1 As TextBox
    Private WithEvents TextBox2 As TextBox
    Private WithEvents TextBox3 As TextBox
    Private WithEvents TextBox4 As TextBox
    Private WithEvents TextBox5 As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents ToolTip1 As ToolTip
    Private WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Private WithEvents Label8 As Label

    Friend WithEvents hh As ComboBox
End Class
