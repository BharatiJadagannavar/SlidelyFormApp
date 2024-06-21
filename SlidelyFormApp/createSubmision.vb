Public Class createSubmision
    ' Constructor to initialize the form and set KeyPreview to True
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    ' Event handler for Label1 click event (if needed)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Code for Label1 click event
    End Sub

    ' Event handler for TextBox5 text changed event (if needed)
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        ' Code for TextBox5 text changed event
    End Sub

    ' Event handler for Button2 click event (Submit button)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Implement submit functionality here
        MessageBox.Show("Submission complete")
    End Sub

    ' Event handler for form keydown event to handle shortcuts
    Private Sub createSubmision_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Button2.PerformClick() ' Trigger Submit button click
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            ToggleStopwatch() ' Call your stopwatch toggle function
        End If
    End Sub

    ' Function to toggle the stopwatch
    Private Sub ToggleStopwatch()
        ' Implement stopwatch toggle functionality here
        MessageBox.Show("Stopwatch toggled")
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
