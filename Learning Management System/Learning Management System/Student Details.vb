Public Class Student_Details
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        DataGridView1.Rows.Clear()
        Me.Hide()
        Admin.Show()
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Me.Hide()
        Login.Show()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim tempID As String
        tempID = InputBox("Enter Student ID of 5 digits : ")
        While CInt(tempID) < 10000
            tempID = InputBox("Please enter a valid Student ID of 5 digits : ")
        End While

        FileOpen(1, tempID + ".txt", OpenMode.Output)
        PrintLine(1, tempID)
        PrintLine(1, InputBox("Enter Student's First Name : "))
        PrintLine(1, InputBox("Enter Student's Last Name : "))
        PrintLine(1, InputBox("Enter the semester : "))
        PrintLine(1, InputBox("Enter the year : "))
        PrintLine(1, InputBox("Enter Student's GPA : "))
        MessageBox.Show("Student ID " + tempID.ToString + " successfully added")
        FileClose(1)

    End Sub

    Private Sub btnDropCourse_Click(sender As Object, e As EventArgs) Handles btnDropCourse.Click

    End Sub

    Private Sub btnChangeGrade_Click(sender As Object, e As EventArgs) Handles btnChangeGrade.Click

    End Sub
End Class