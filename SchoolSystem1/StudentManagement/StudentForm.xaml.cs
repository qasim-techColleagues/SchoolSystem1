using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SchoolSystem1.StudentManagement
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
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
            set
            {
                _student = value;
            }
        }
      
        private void StudentAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Student.StudentName) && !string.IsNullOrEmpty(Student.FatherName))
            {
                var student = new Student(Student.StudentName, Student.FatherName);

                StudentList.Students.Add(student);

                MessageBox.Show("Student added");
                this.Close();                
            }
            else
            {
                MessageBox.Show("Validation error");
            }
        }
    }
}
