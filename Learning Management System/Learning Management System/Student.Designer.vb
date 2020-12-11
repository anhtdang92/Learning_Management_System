<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Me.LastName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.Label()
        Me.txtStudentId = New System.Windows.Forms.Label()
        Me.txtSemester = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGpa = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.Label()
        Me.FirstName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.Label()
        Me.btnSignOut = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LastName
        '
        Me.LastName.AutoSize = True
        Me.LastName.Location = New System.Drawing.Point(67, 76)
        Me.LastName.Name = "LastName"
        Me.LastName.Size = New System.Drawing.Size(94, 20)
        Me.LastName.TabIndex = 0
        Me.LastName.Text = "Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Semester :"
        '
        'txtLastName
        '
        Me.txtLastName.AutoSize = True
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtLastName.Location = New System.Drawing.Point(186, 76)
        Me.txtLastName.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(400, 22)
        Me.txtLastName.TabIndex = 3
        '
        'txtStudentId
        '
        Me.txtStudentId.AutoSize = True
        Me.txtStudentId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtStudentId.Location = New System.Drawing.Point(186, 109)
        Me.txtStudentId.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtStudentId.Name = "txtStudentId"
        Me.txtStudentId.Size = New System.Drawing.Size(400, 22)
        Me.txtStudentId.TabIndex = 4
        '
        'txtSemester
        '
        Me.txtSemester.AutoSize = True
        Me.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSemester.Location = New System.Drawing.Point(186, 139)
        Me.txtSemester.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtSemester.Name = "txtSemester"
        Me.txtSemester.Size = New System.Drawing.Size(150, 22)
        Me.txtSemester.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Course, Me.CRN, Me.Exam1, Me.Exam2, Me.Exam3, Me.Grade})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 207)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1174, 186)
        Me.DataGridView1.TabIndex = 6
        '
        'Course
        '
        Me.Course.HeaderText = "Course"
        Me.Course.MinimumWidth = 8
        Me.Course.Name = "Course"
        Me.Course.ReadOnly = True
        Me.Course.Width = 150
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(102, 548)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 29)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "GPA :"
        '
        'txtGpa
        '
        Me.txtGpa.AutoSize = True
        Me.txtGpa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGpa.Location = New System.Drawing.Point(187, 548)
        Me.txtGpa.MinimumSize = New System.Drawing.Size(100, 20)
        Me.txtGpa.Name = "txtGpa"
        Me.txtGpa.Size = New System.Drawing.Size(100, 31)
        Me.txtGpa.TabIndex = 11
        '
        'txtFirstName
        '
        Me.txtFirstName.AutoSize = True
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtFirstName.Location = New System.Drawing.Point(186, 40)
        Me.txtFirstName.MinimumSize = New System.Drawing.Size(400, 20)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(400, 22)
        Me.txtFirstName.TabIndex = 13
        '
        'FirstName
        '
        Me.FirstName.AutoSize = True
        Me.FirstName.Location = New System.Drawing.Point(67, 40)
        Me.FirstName.Name = "FirstName"
        Me.FirstName.Size = New System.Drawing.Size(94, 20)
        Me.FirstName.TabIndex = 12
        Me.FirstName.Text = "First Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(373, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Year :"
        '
        'txtYear
        '
        Me.txtYear.AutoSize = True
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtYear.Location = New System.Drawing.Point(436, 139)
        Me.txtYear.MinimumSize = New System.Drawing.Size(150, 20)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(150, 22)
        Me.txtYear.TabIndex = 15
        '
        'btnSignOut
        '
        Me.btnSignOut.Location = New System.Drawing.Point(1070, 645)
        Me.btnSignOut.Name = "btnSignOut"
        Me.btnSignOut.Size = New System.Drawing.Size(104, 48)
        Me.btnSignOut.TabIndex = 17
        Me.btnSignOut.Text = "Sign Out"
        Me.btnSignOut.UseVisualStyleBackColor = True
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 719)
        Me.Controls.Add(Me.btnSignOut)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.FirstName)
        Me.Controls.Add(Me.txtGpa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtSemester)
        Me.Controls.Add(Me.txtStudentId)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LastName)
        Me.Name = "Student"
        Me.Text = "Student"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LastName As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtLastName As Label
	Friend WithEvents txtStudentId As Label
	Friend WithEvents txtSemester As Label
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents Label6 As Label
	Friend WithEvents txtGpa As Label
	Friend WithEvents txtFirstName As Label
	Friend WithEvents FirstName As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtYear As Label
    Friend WithEvents btnSignOut As Button
    Friend WithEvents Course As DataGridViewTextBoxColumn
    Friend WithEvents CRN As DataGridViewTextBoxColumn
    Friend WithEvents Exam1 As DataGridViewTextBoxColumn
    Friend WithEvents Exam2 As DataGridViewTextBoxColumn
    Friend WithEvents Exam3 As DataGridViewTextBoxColumn
    Friend WithEvents Grade As DataGridViewTextBoxColumn
End Class
