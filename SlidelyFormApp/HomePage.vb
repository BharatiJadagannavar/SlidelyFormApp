Public Class Form1
    Inherits Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the form
        Me.Text = "Home Page"
        Me.Size = New Size(400, 200)

        ' Create and configure the "View Submissions" button
        Dim btnViewSubmissions As New Button()
        btnViewSubmissions.Text = "View Submissions"
        btnViewSubmissions.Location = New Point(50, 50)
        btnViewSubmissions.Size = New Size(120, 30)
        AddHandler btnViewSubmissions.Click, AddressOf btnViewSubmissions_Click

        ' Create and configure the "Create New Submission" button
        Dim btnCreateSubmission As New Button()
        btnCreateSubmission.Text = "Create New Submission"
        btnCreateSubmission.Location = New Point(200, 50)
        btnCreateSubmission.Size = New Size(120, 30)
        AddHandler btnCreateSubmission.Click, AddressOf btnCreateSubmission_Click

        ' Add buttons to the form
        Me.Controls.Add(btnViewSubmissions)
        Me.Controls.Add(btnCreateSubmission)
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs)
        Dim viewForm As New ViewSubmission()
        viewForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs)
        Dim createForm As New createSubmision
        ()
        createForm.Show()
        Me.Hide()
    End Sub
End Class
