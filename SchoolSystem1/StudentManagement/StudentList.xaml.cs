using SchoolSystem1.FeesManagement;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace SchoolSystem1.StudentManagement
{
    public partial class StudentList : Page
    {
        static StudentList()
        {
            Students = new ObservableCollection<Student>();
        }

        public StudentList()
        {
            InitializeComponent();
            DataContext = this;

        }
        public static ObservableCollection<Student> Students { get; set; }

        private void btnStudenAdd_Click(object sender, RoutedEventArgs e)
        {
            var studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void dgStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgStudents != null)
            {
                Student selectedStudent = dgStudents.SelectedItem as Student;
                StudentForm Students = new StudentForm();
                Students.Student = selectedStudent;
                Students.ShowDialog();
            }

        }
        private void btnDeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (dgStudents.SelectedItem != null)
            {
                Student seletedStudent = dgStudents.SelectedItem as Student;
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this Fee?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Students.Remove(seletedStudent);
                }
            }
        }

    }
}
