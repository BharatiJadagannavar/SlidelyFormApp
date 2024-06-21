Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ViewSubmission
    Private Sub hh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hh.SelectedIndexChanged
        ' Placeholder code to update the display when a different submission is selected in the ComboBox
        If TypeOf hh.SelectedItem Is Submission Then
            Dim selectedSubmission = CType(hh.SelectedItem, Submission)
            TextBox2.Text = selectedSubmission.Name
            TextBox5.Text = selectedSubmission.Email
            TextBox4.Text = selectedSubmission.Phone
            TextBox3.Text = $"GitHub Link: {selectedSubmission.GithubLink}{Environment.NewLine}Stopwatch Time: {selectedSubmission.StopwatchTime}"
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Placeholder code to load the next submission details
        Dim selectedIndex As Integer = hh.SelectedIndex
        If selectedIndex < hh.Items.Count - 1 Then
            hh.SelectedIndex = selectedIndex + 1
        End If
    End Sub

    Private Sub hh_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hh.SelectedIndexChanged
        ' Placeholder code to update the display when a different submission is selected in the ComboBox
        If TypeOf hh.SelectedItem Is Submission Then
            Dim selectedSubmission = CType(hh.SelectedItem, Submission)
            TextBox2.Text = selectedSubmission.Name
            TextBox5.Text = selectedSubmission.Email
            TextBox4.Text = selectedSubmission.Phone
            TextBox3.Text = $"GitHub Link: {selectedSubmission.GithubLink}{Environment.NewLine}Stopwatch Time: {selectedSubmission.StopwatchTime}"
        End If
    End Sub


    Private Sub ViewSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Placeholder code to populate the ComboBox with submissions
        ' For demonstration purposes, we'll add some dummy submissions
        hh.Items.Add(New Submission("John Doe", "john@example.com", "1234567890", "https://github.com/johndoe/task2", "00:10:23"))
        hh.Items.Add(New Submission("Jane Smith", "jane@example.com", "0987654321", "https://github.com/janesmith/task2", "00:12:45"))
        hh.DisplayMember = "Name" ' Display the Name property in the ComboBox
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubLink As String
    Public Property StopwatchTime As String

    Public Sub New(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GithubLink = githubLink
        Me.StopwatchTime = stopwatchTime
    End Sub
End Class
