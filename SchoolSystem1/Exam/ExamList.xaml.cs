using SchoolSystem1.StudentManagement;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SchoolSystem1.Exam
{
    public partial class ExamList : Page
    {
        static ExamList()
        {
            Exams = new ObservableCollection<Exam>();
        }

        public ExamList()
        {
            InitializeComponent();
            DataContext = this;
            //Exams= new ObservableCollection<Exam>();
        }

        public static ObservableCollection<Exam> Exams { get; set; }

        private void btnExamAdd_Click(object sender, RoutedEventArgs e)
        {
                var exam = new ExamForm();
                exam.ShowDialog();
        }

        private void dgExams_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

            if (dgExams.SelectedItem != null)
            {
                Exam selectedExam = dgExams.SelectedItem as Exam;
                ExamForm examForm = new ExamForm();
                examForm.Exam = selectedExam;
                examForm.SelectedStudent = StudentList.Students.Where(x=>x.StudentId == selectedExam.StudentId).First();
                examForm.ShowDialog();
            }
        }
    }
}
