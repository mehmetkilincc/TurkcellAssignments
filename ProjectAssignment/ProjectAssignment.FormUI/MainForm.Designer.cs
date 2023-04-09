namespace ProjectAssignment.FormUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.cbxTeacherClassroom = new System.Windows.Forms.ComboBox();
            this.txtTeacherLastName = new System.Windows.Forms.TextBox();
            this.txtTeacherFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStudentClassroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddClassroom = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgwClassroom = new System.Windows.Forms.DataGridView();
            this.dgwTeacher = new System.Windows.Forms.DataGridView();
            this.TeacherId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgwStudent = new System.Windows.Forms.DataGridView();
            this.StudentClassroom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchStudentByClassName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddTeacher);
            this.groupBox2.Controls.Add(this.cbxTeacherClassroom);
            this.groupBox2.Controls.Add(this.txtTeacherLastName);
            this.groupBox2.Controls.Add(this.txtTeacherFirstName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(393, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Teacher";
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(118, 130);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(159, 39);
            this.btnAddTeacher.TabIndex = 8;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // cbxTeacherClassroom
            // 
            this.cbxTeacherClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeacherClassroom.FormattingEnabled = true;
            this.cbxTeacherClassroom.Location = new System.Drawing.Point(118, 100);
            this.cbxTeacherClassroom.Name = "cbxTeacherClassroom";
            this.cbxTeacherClassroom.Size = new System.Drawing.Size(159, 24);
            this.cbxTeacherClassroom.TabIndex = 7;
            // 
            // txtTeacherLastName
            // 
            this.txtTeacherLastName.Location = new System.Drawing.Point(118, 72);
            this.txtTeacherLastName.Name = "txtTeacherLastName";
            this.txtTeacherLastName.Size = new System.Drawing.Size(159, 22);
            this.txtTeacherLastName.TabIndex = 6;
            // 
            // txtTeacherFirstName
            // 
            this.txtTeacherFirstName.Location = new System.Drawing.Point(118, 43);
            this.txtTeacherFirstName.Name = "txtTeacherFirstName";
            this.txtTeacherFirstName.Size = new System.Drawing.Size(159, 22);
            this.txtTeacherFirstName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Classroom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddStudent);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxStudentClassroom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStudentLastName);
            this.groupBox1.Controls.Add(this.txtStudentFirstName);
            this.groupBox1.Location = new System.Drawing.Point(872, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Student";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(113, 127);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(159, 40);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Classroom";
            // 
            // cbxStudentClassroom
            // 
            this.cbxStudentClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStudentClassroom.FormattingEnabled = true;
            this.cbxStudentClassroom.Location = new System.Drawing.Point(113, 97);
            this.cbxStudentClassroom.Name = "cbxStudentClassroom";
            this.cbxStudentClassroom.Size = new System.Drawing.Size(159, 24);
            this.cbxStudentClassroom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(113, 69);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.Size = new System.Drawing.Size(159, 22);
            this.txtStudentLastName.TabIndex = 1;
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(113, 40);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.Size = new System.Drawing.Size(159, 22);
            this.txtStudentFirstName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddClassroom);
            this.groupBox3.Controls.Add(this.txtClassName);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(28, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 181);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Classroom";
            // 
            // btnAddClassroom
            // 
            this.btnAddClassroom.Location = new System.Drawing.Point(98, 70);
            this.btnAddClassroom.Name = "btnAddClassroom";
            this.btnAddClassroom.Size = new System.Drawing.Size(159, 37);
            this.btnAddClassroom.TabIndex = 4;
            this.btnAddClassroom.Text = "Add Classroom";
            this.btnAddClassroom.UseVisualStyleBackColor = true;
            this.btnAddClassroom.Click += new System.EventHandler(this.btnAddClassroom_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(98, 42);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(159, 22);
            this.txtClassName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Class Name";
            // 
            // dgwClassroom
            // 
            this.dgwClassroom.AllowUserToAddRows = false;
            this.dgwClassroom.AllowUserToDeleteRows = false;
            this.dgwClassroom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwClassroom.Location = new System.Drawing.Point(28, 285);
            this.dgwClassroom.Name = "dgwClassroom";
            this.dgwClassroom.ReadOnly = true;
            this.dgwClassroom.RowHeadersWidth = 51;
            this.dgwClassroom.RowTemplate.Height = 24;
            this.dgwClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwClassroom.Size = new System.Drawing.Size(293, 236);
            this.dgwClassroom.TabIndex = 13;
            // 
            // dgwTeacher
            // 
            this.dgwTeacher.AllowUserToAddRows = false;
            this.dgwTeacher.AllowUserToDeleteRows = false;
            this.dgwTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeacher.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeacherId,
            this.TeacherFirstName,
            this.TeacherLastName,
            this.TeacherClassroom});
            this.dgwTeacher.Location = new System.Drawing.Point(371, 285);
            this.dgwTeacher.Name = "dgwTeacher";
            this.dgwTeacher.ReadOnly = true;
            this.dgwTeacher.RowHeadersWidth = 51;
            this.dgwTeacher.RowTemplate.Height = 24;
            this.dgwTeacher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTeacher.Size = new System.Drawing.Size(353, 236);
            this.dgwTeacher.TabIndex = 14;
            // 
            // TeacherId
            // 
            this.TeacherId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherId.HeaderText = "Id";
            this.TeacherId.MinimumWidth = 6;
            this.TeacherId.Name = "TeacherId";
            this.TeacherId.ReadOnly = true;
            // 
            // TeacherFirstName
            // 
            this.TeacherFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherFirstName.HeaderText = "First Name";
            this.TeacherFirstName.MinimumWidth = 6;
            this.TeacherFirstName.Name = "TeacherFirstName";
            this.TeacherFirstName.ReadOnly = true;
            // 
            // TeacherLastName
            // 
            this.TeacherLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherLastName.HeaderText = "Last Name";
            this.TeacherLastName.MinimumWidth = 6;
            this.TeacherLastName.Name = "TeacherLastName";
            this.TeacherLastName.ReadOnly = true;
            // 
            // TeacherClassroom
            // 
            this.TeacherClassroom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeacherClassroom.HeaderText = "Classroom";
            this.TeacherClassroom.MinimumWidth = 6;
            this.TeacherClassroom.Name = "TeacherClassroom";
            this.TeacherClassroom.ReadOnly = true;
            // 
            // dgwStudent
            // 
            this.dgwStudent.AllowUserToAddRows = false;
            this.dgwStudent.AllowUserToDeleteRows = false;
            this.dgwStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentClassroom,
            this.StudentId,
            this.StudentFirstName,
            this.StudentLastName});
            this.dgwStudent.Location = new System.Drawing.Point(783, 285);
            this.dgwStudent.Name = "dgwStudent";
            this.dgwStudent.ReadOnly = true;
            this.dgwStudent.RowHeadersWidth = 51;
            this.dgwStudent.RowTemplate.Height = 24;
            this.dgwStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwStudent.Size = new System.Drawing.Size(508, 236);
            this.dgwStudent.TabIndex = 15;
            // 
            // StudentClassroom
            // 
            this.StudentClassroom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentClassroom.HeaderText = "Classroom";
            this.StudentClassroom.MinimumWidth = 6;
            this.StudentClassroom.Name = "StudentClassroom";
            this.StudentClassroom.ReadOnly = true;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.MinimumWidth = 6;
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Width = 80;
            // 
            // StudentFirstName
            // 
            this.StudentFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentFirstName.HeaderText = "Student Name";
            this.StudentFirstName.MinimumWidth = 6;
            this.StudentFirstName.Name = "StudentFirstName";
            this.StudentFirstName.ReadOnly = true;
            // 
            // StudentLastName
            // 
            this.StudentLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentLastName.HeaderText = "Student Surname";
            this.StudentLastName.MinimumWidth = 6;
            this.StudentLastName.Name = "StudentLastName";
            this.StudentLastName.ReadOnly = true;
            // 
            // txtSearchStudentByClassName
            // 
            this.txtSearchStudentByClassName.Location = new System.Drawing.Point(1191, 257);
            this.txtSearchStudentByClassName.Name = "txtSearchStudentByClassName";
            this.txtSearchStudentByClassName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchStudentByClassName.TabIndex = 16;
            this.txtSearchStudentByClassName.TextChanged += new System.EventHandler(this.txtSearchStudentById_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1104, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "Class Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1324, 613);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtSearchStudentByClassName);
            this.Controls.Add(this.dgwStudent);
            this.Controls.Add(this.dgwTeacher);
            this.Controls.Add(this.dgwClassroom);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High School App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.TextBox txtTeacherLastName;
        private System.Windows.Forms.TextBox txtTeacherFirstName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxStudentClassroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddClassroom;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxTeacherClassroom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgwClassroom;
        private System.Windows.Forms.DataGridView dgwTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherClassroom;
        private System.Windows.Forms.DataGridView dgwStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClassroom;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLastName;
        private System.Windows.Forms.TextBox txtSearchStudentByClassName;
        private System.Windows.Forms.Label label11;
    }
}

