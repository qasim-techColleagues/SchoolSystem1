using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

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

    }
}
