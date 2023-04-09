using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectAssignment.Business.Abstract;
using ProjectAssignment.Business.DependencySolvers.Ninject;
using ProjectAssignment.Entities.Concrete;

namespace ProjectAssignment.FormUI
{
    public partial class MainForm : Form
    {
        private readonly IStudentService _studentService;
        private readonly IClassroomService _classroomService;
        private readonly ITeacherService _teacherService;

        public MainForm()
        {
            InitializeComponent();

            _studentService = InstanceFactory.GetInstance<IStudentService>();
            _teacherService = InstanceFactory.GetInstance<ITeacherService>();
            _classroomService = InstanceFactory.GetInstance<IClassroomService>();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadClassroomData();
            LoadTeacherData();
            LoadStudentData();
        }


        private void LoadClassroomData()
        {
            dgwClassroom.DataSource = null;
            var classrooms = _classroomService.GetAll();
            dgwClassroom.DataSource = classrooms;

            cbxTeacherClassroom.DataSource = null;
            cbxTeacherClassroom.DataSource = classrooms;
            cbxTeacherClassroom.DisplayMember = "ClassName";
            cbxTeacherClassroom.ValueMember = "Id";

            cbxStudentClassroom.DataSource = null;
            cbxStudentClassroom.DataSource = classrooms;
            cbxStudentClassroom.DisplayMember = "ClassName";
            cbxStudentClassroom.ValueMember = "Id";
        }
        private void LoadTeacherData()
        {
            dgwTeacher.Rows.Clear();
            var teachers = _teacherService.GetAll();
            foreach (var teacher in teachers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgwTeacher);
                row.Cells[0].Value = teacher.Id;
                row.Cells[1].Value = teacher.FirstName;
                row.Cells[2].Value = teacher.LastName;
                row.Cells[3].Value = teacher.Classroom.ClassName;
                dgwTeacher.Rows.Add(row);
            }
        }
        private void LoadStudentData()
        {
            dgwStudent.Rows.Clear();
            var students = _studentService.GetAll();
            foreach (var student in students)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgwStudent);
                row.Cells[0].Value = student.Classroom.ClassName;
                row.Cells[1].Value = student.Id;
                row.Cells[2].Value = student.FirstName;
                row.Cells[3].Value = student.LastName;
                dgwStudent.Rows.Add(row);
            }
        }


        private void AddClassroom()
        {
            Classroom classroom = new Classroom()
            {
                ClassName = txtClassName.Text,
            };

            _classroomService.Add(classroom);
        }
        private void btnAddClassroom_Click(object sender, EventArgs e)
        {
            if (txtClassName.Text != string.Empty)
            {
                try
                {
                    AddClassroom();
                    LoadClassroomData();
                }
                catch(Exception ex) { MessageBox.Show("Error: " +ex.Message); }
            }
            else
                MessageBox.Show("Lütfen Sınıf Adını Giriniz.");
        }


        private void AddTeacher()
        {
            Teacher teacher = new Teacher()
            {
                FirstName = txtTeacherFirstName.Text,
                LastName = txtTeacherLastName.Text,
                Classroom = _classroomService.GetById(Convert.ToInt32(cbxTeacherClassroom.SelectedValue))
            };

            _teacherService.Add(teacher);
        }
        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            if (txtTeacherFirstName.Text != string.Empty && txtTeacherLastName.Text != string.Empty)
            {
                if (cbxTeacherClassroom.SelectedItem != null)
                {
                    try
                    {
                        AddTeacher();
                        LoadTeacherData();
                    }
                    catch(Exception ex) { MessageBox.Show("Error :" + ex.Message); }
                }
                else
                    MessageBox.Show("Sınıf Bilgisini Giriniz!");
            }
            else
                MessageBox.Show("Öğretmen Bilgilerini Eksiksiz Giriniz!");
        }


        private void AddStudent()
        {
            Student student = new Student()
            {
                FirstName = txtStudentFirstName.Text,
                LastName = txtStudentLastName.Text,
                Classroom = _classroomService.GetById(Convert.ToInt32(cbxStudentClassroom.SelectedValue))
            };

            _studentService.Add(student);
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (txtStudentFirstName.Text != string.Empty && txtStudentLastName.Text != string.Empty)
            {
                if (cbxStudentClassroom.SelectedItem != null)
                {
                    try
                    {
                        AddStudent();
                        LoadStudentData();
                    }
                    catch (Exception ex) { MessageBox.Show("Error :" + ex.Message); }
                }
                else
                    MessageBox.Show("İlk olarak Sınıf Eklemelisiniz");
            }
            else
                MessageBox.Show("Öğrenci Bilgilerini Eksiksiz Giriniz!");
        }

        private void txtSearchStudentById_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtSearchStudentByClassName.Text))
            {
                string className = txtSearchStudentByClassName.Text;
                dgwStudent.Rows.Clear();
                var students = _studentService.GetAllByFilter(s=>s.Classroom.ClassName.StartsWith(className));
                if (students != null)
                {
                    foreach (var student in students)
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        row.CreateCells(dgwStudent);
                        row.Cells[0].Value = student.Classroom.ClassName;
                        row.Cells[1].Value = student.Id;
                        row.Cells[2].Value = student.FirstName;
                        row.Cells[3].Value = student.LastName;
                        dgwStudent.Rows.Add(row);
                    }
                }
            }
            else
                LoadStudentData();
        }
    }
}
