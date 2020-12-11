Imports System.IO

Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim lines() As String
        Dim Vals() As String

        Select Case txtUsername.Text
            Case "gilchrist1", "Gilchrist1", "GILCHRIST1"
                If txtPassword.Text = "gilchrist123" Then
                    Me.Hide()
                    Student.Show()
                    FileOpen(1, "12345.txt", OpenMode.Input)
                    Student.txtStudentId.Text = LineInput(1)
                    Student.txtFirstName.Text = LineInput(1)
                    Student.txtLastName.Text = LineInput(1)
                    Student.txtSemester.Text = LineInput(1)
                    Student.txtYear.Text = LineInput(1)
                    Student.txtGpa.Text = LineInput(1)
                    lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\12345courses.txt")
                    For i As Integer = 0 To lines.Length - 1 Step +1
                        Vals = lines(i).ToString().Split(CChar("|"))
                        Dim row(Vals.Length - 1) As String

                        For j As Integer = 0 To Vals.Length - 1 Step +1
                            row(j) = Vals(j).Trim()
                        Next j

                        Student.DataGridView1.Rows.Add(row)
                    Next
                    FileClose(1)
                Else
                    statusBar.Text = "Wrong Password"
                End If

            Case "anh1", "Anh1", "ANH1"
                If txtPassword.Text = "anh123" Then
                    Me.Hide()
                    Student.Show()
                    FileOpen(1, "54321.txt", OpenMode.Input)
                    Student.txtStudentId.Text = LineInput(1)
                    Student.txtFirstName.Text = LineInput(1)
                    Student.txtLastName.Text = LineInput(1)
                    Student.txtSemester.Text = LineInput(1)
                    Student.txtYear.Text = LineInput(1)
                    Student.txtGpa.Text = LineInput(1)
                    lines = File.ReadAllLines("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\54321courses.txt")
                    For i As Integer = 0 To lines.Length - 1 Step +1
                        Vals = lines(i).ToString().Split(CChar("|"))
                        Dim row(Vals.Length - 1) As String

                        For j As Integer = 0 To Vals.Length - 1 Step +1
                            row(j) = Vals(j).Trim()
                        Next j

                        Student.DataGridView1.Rows.Add(row)
                    Next
                    FileClose(1)
                Else
                    statusBar.Text = "Wrong Password"
                End If
            Case "admin", "Admin", "ADMIN"


                If txtPassword.Text = "admin123" Then
                    Me.Hide()
                    Admin.Show()
                    Dim tempInfo(2) As String

                    For i As Integer = 11111 To 99999 Step 1
                        If My.Computer.FileSystem.FileExists("C:\Users\Gilchrist\Documents\courses n exercises\2020\Fall 2020\CS 1408 - Intro to CS with Visual Basics\Visual Basic\Learning Management System\Learning Management System\bin\Debug\" + i.ToString + ".txt") Then
                            FileOpen(1, i.ToString + ".txt", OpenMode.Input)
                            tempInfo(0) = LineInput(1)
                            tempInfo(1) = LineInput(1)
                            tempInfo(2) = LineInput(1)
                            Admin.DataGridView1.Rows.Add(tempInfo)
                            FileClose(1)
                        End If
                    Next
                Else
                        statusBar.Text = "Wrong Password"
                End If
            Case ""
                statusBar.Text = "Please enter a username"
            Case Else
                statusBar.Text = "Please enter a valid username"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowPw_Click(sender As Object, e As EventArgs) Handles btnShowPw.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class


