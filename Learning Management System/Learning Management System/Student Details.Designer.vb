<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Details
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtGpa = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDropCourse = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.btnChangeGrade = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.txtYear = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSemester = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(64, 31)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(94, 20)
        Me.lblFirstName.TabIndex = 26
        Me.lblFirstName.Text = "First Name :"
        '
        'txtGpa
        '
        Me.txtGpa.AutoSize = True
        Me.txtGpa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGpa.Location = New System.Drawing.Point(184, 539)
        Me.txtGpa.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtGpa.Name = "txtGpa"
        Me.txtGpa.Size = New System.Drawing.Size(100, 31)
        Me.txtGpa.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(99, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "GPA :"
        '
        'btnDropCourse
        '
        Me.btnDropCourse.Location = New System.Drawing.Point(322, 420)
        Me.btnDropCourse.Name = "btnDropCourse"
        Me.btnDropCourse.Size = New System.Drawing.Size(174, 52)
        Me.btnDropCourse.TabIndex = 23
        Me.btnDropCourse.Text = "Drop Course"
        Me.btnDropCourse.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoSize = True
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtFirstName.Location = New System.Drawing.Point(183, 31)
        Me.txtFirstName.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(400, 22)
        Me.txtFirstName.TabIndex = 27
        '
        'txtStudentId
        '
        Me.txtStudentId.AutoSize = True
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStudentId.Location = New System.Drawing.Point(183, 100)
        Me.txtStudentId.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(400, 22)
        Me.txtStudentId.TabIndex = 18
        '
        'txtLastName
        '
        Me.txtLastName.AutoSize = True
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtLastName.Location = New System.Drawing.Point(183, 67)
        Me.txtLastName.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(400, 22)
        Me.txtLastName.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Student ID :"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(64, 67)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 20)
        Me.lblLastName.TabIndex = 14
        Me.lblLastName.Text = "Last Name :"
        '
        'btnChangeGrade
        '
        Me.btnChangeGrade.Location = New System.Drawing.Point(536, 420)
        Me.btnChangeGrade.Name = "btnChangeGrade"
        Me.btnChangeGrade.Size = New System.Drawing.Size(174, 52)
        Me.btnChangeGrade.TabIndex = 28
        Me.btnChangeGrade.Text = "Change Grade"
        Me.btnChangeGrade.UseVisualStyleBackColor = True
        '
        'btnAddCourse
        '
        Me.btnAddCourse.Location = New System.Drawing.Point(104, 420)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(174, 52)
        Me.btnAddCourse.TabIndex = 29
        Me.btnAddCourse.Text = "Add Course"
        Me.btnAddCourse.UseVisualStyleBackColor = True
        '
        'txtYear
        '
        Me.txtYear.AutoSize = True
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtYear.Location = New System.Drawing.Point(433, 133)
        Me.txtYear.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(150, 22)
        Me.txtYear.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(370, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Year :"
        '
        'txtSemester
        '
        Me.txtSemester.AutoSize = True
        Me.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSemester.Location = New System.Drawing.Point(183, 133)
        Me.txtSemester.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.Size = New System.Drawing.Size(150, 22)
        Me.txtSemester.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Semester :"
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(1072, 644)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(104, 48)
        Me.btnSignOut.TabIndex = 35
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(950, 644)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(104, 48)
        Me.btnPrevious.TabIndex = 34
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Course, Me.CRN, Me.Exam1, Me.Exam2, Me.Exam3, Me.Grade})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1174, 186)
        Me.DataGridView1.TabIndex = 36
        '
        'Course
        '
        Me.Course.HeaderText = "Course"
        Me.Course.MinimumWidth = 8
        Me.Course.Name = "Course"
        Me.Course.ReadOnly = True
        Me.Course.Width = 200
        '
        'CRN
        '
        Me.CRN.HeaderText = "CRN"
        Me.CRN.MinimumWidth = 8
        Me.CRN.Name = "CRN"
        Me.CRN.ReadOnly = True
        Me.CRN.Width = 150
        '
        'Exam1
        '
        Me.Exam1.HeaderText = "Exam 1"
        Me.Exam1.MinimumWidth = 8
        Me.Exam1.Name = "Exam1"
        Me.Exam1.ReadOnly = True
        Me.Exam1.Width = 150
        '
        'Exam2
        '
        Me.Exam2.HeaderText = "Exam 2"
        Me.Exam2.MinimumWidth = 8
        Me.Exam2.Name = "Exam2"
        Me.Exam2.ReadOnly = True
        Me.Exam2.Width = 150
        '
        'Exam3
        '
        Me.Exam3.HeaderText = "Exam 3"
        Me.Exam3.MinimumWidth = 8
        Me.Exam3.Name = "Exam3"
        Me.Exam3.ReadOnly = True
        Me.Exam3.Width = 150
        '
        'Grade
        '
        Me.Grade.HeaderText = "Grade"
        Me.Grade.MinimumWidth = 8
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.Width = 150
        '
        'Student_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 719)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSemester)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnChangeGrade)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtGpa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnDropCourse)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblLastName)
        Me.Name = "Student_Details"
        Me.Text = "Student Course"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtGpa As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnDropCourse As Button
    Friend WithEvents txtFirstName As Label
    Friend WithEvents txtStudentId As Label
    Friend WithEvents txtLastName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents btnChangeGrade As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents txtYear As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSemester As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents CRN As DataGridViewTextBoxColumn
    Friend WithEvents Exam1 As DataGridViewTextBoxColumn
    Friend WithEvents Exam2 As DataGridViewTextBoxColumn
    Friend WithEvents Exam3 As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
End Class
