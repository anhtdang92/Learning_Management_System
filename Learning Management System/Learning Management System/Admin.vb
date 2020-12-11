Imports System.IO

Public Class Admin
    Dim lines() As String
    Dim Vals() As String
    Dim tempId As Integer


    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        DataGridView1.Rows.Clear()
        Me.Hide()
        Login.Show()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        tempId = Convert.ToInt32(InputBox("Please enter the student ID to update"))
        If tempId = 54321 Then
            Me.Hide()
            Student_Details.Show()
            FileOpen(1, "54321.txt", OpenMode.Input)
            Student_Details.txtStudentId.Text = LineInput(1)
            Student_Details.txtFirstName.Text = LineInput(1)
            Student_Details.txtLastName.Text = LineInput(1)
            Student_Details.txtSemester.Text = LineInput(1)
            Student_Details.txtYear.Text = LineInput(1)
            Student_Details.txtGpa.Text = LineInput(1)

            lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\54321courses.txt")
            For i As Integer = 0 To lines.Length - 1 Step +1
                Vals = lines(i).ToString().Split(CChar("|"))
                Dim row(Vals.Length - 1) As String

                For j As Integer = 0 To Vals.Length - 1 Step +1
                    row(j) = Vals(j).Trim()
                Next j

                Student_Details.DataGridView1.Rows.Add(row)
            Next
            FileClose(1)
        ElseIf tempId = 12345 Then
            Me.Hide()
            Student_Details.Show()
            FileOpen(1, "12345.txt", OpenMode.Input)
            Student_Details.txtStudentId.Text = LineInput(1)
            Student_Details.txtFirstName.Text = LineInput(1)
            Student_Details.txtLastName.Text = LineInput(1)
            Student_Details.txtSemester.Text = LineInput(1)
            Student_Details.txtYear.Text = LineInput(1)
            Student_Details.txtGpa.Text = LineInput(1)

            lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\12345courses.txt")
            For i As Integer = 0 To lines.Length - 1 Step +1
                Vals = lines(i).ToString().Split(CChar("|"))
                Dim row(Vals.Length - 1) As String

                For j As Integer = 0 To Vals.Length - 1 Step +1
                    row(j) = Vals(j).Trim()
                Next j

                Student_Details.DataGridView1.Rows.Add(row)
            Next
            FileClose(1)
        Else
            MessageBox.Show("Student ID not found.")
        End If

    End Sub

    Private Sub btnDropStudent_Click(sender As Object, e As EventArgs) Handles btnDropStudent.Click
        Dim tempID As Integer
        tempID = CInt(InputBox("Please enter the student ID to drop: "))
        My.Computer.FileSystem.DeleteFile(tempID.ToString + ".txt")
        MessageBox.Show("Student ID " + tempID.ToString + " successfully dropped")
    End Sub



    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
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

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        DataGridView1.Rows.Clear()
        Dim tempInfo(2) As String
        For i As Integer = 11111 To 99999 Step 1
            If My.Computer.FileSystem.FileExists("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\" + i.ToString + ".txt") Then
                FileOpen(1, i.ToString + ".txt", OpenMode.Input)
                tempInfo(0) = LineInput(1)
                tempInfo(1) = LineInput(1)
                tempInfo(2) = LineInput(1)
                DataGridView1.Rows.Add(tempInfo)
                FileClose(1)
            End If
        Next
    End Sub
End Class

'temp1 = LineInput(1)
'temp2 = LineInput(1)
'FileClose(1)
'lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\list.txt")

'FileOpen(1, "list.txt", OpenMode.Output)
'WriteLine(1, temp1)
'WriteLine(1, temp2)
'WriteLine(1,)
'"Enter Student ID : ") + " | " +
'InputBox("Enter First Name : ") + " | " +
'InputBox("Enter Last Name : ") + " | " +
'InputBox("Enter Semester : ") + " | " +
'InputBox("Enter Year : ") + " | ")
'FileClose(1)