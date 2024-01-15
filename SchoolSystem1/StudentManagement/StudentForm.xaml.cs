using System.Linq;
using System.Windows;

namespace SchoolSystem1.StudentManagement
{
    // ... (other using statements)

    public partial class StudentForm : Window
    {
        private Student _student;

        public StudentForm()
        {
            InitializeComponent();
            DataContext = this;
            Student = new Student();
        }

        public Student Student
        {
            get => _student;
            set => _student = value;
        }

        private void StudentAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Student.StudentName) && !string.IsNullOrEmpty(Student.FatherName))
            {
                var existingStudent = StudentList.Students.FirstOrDefault(s => s.StudentId == Student.StudentId);

                if (existingStudent != null)
                {
                    // Update existing student's name and father's name
                    existingStudent.StudentName = Student.StudentName;
                    existingStudent.FatherName = Student.FatherName;
                    MessageBox.Show("Student information updated");
                }
                else
                {
                    // Add a new student if the ID is not found
                    var newStudent = new Student(Student.StudentName, Student.FatherName);
                    StudentList.Students.Add(newStudent);
                    MessageBox.Show("New student added");
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Validation error");
            }
        }
    }
}
