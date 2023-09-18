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
            AddDummyData();

        }
        public static ObservableCollection<Student> Students { get; set; }

        private void btnStudenAdd_Click(object sender, RoutedEventArgs e)
        {
            var studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private void AddDummyData()
        {
            Students.Add(new Student("Qasim", "Saleem"));
            Students.Add(new Student("Qasim1", "Saleem"));
        }
    }
}
