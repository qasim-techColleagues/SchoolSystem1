using SchoolSystem1.StudentManagement;
using System;
using System.Linq;
using System.Windows;

namespace SchoolSystem1.Exam
{
    /// <summary>
    /// Interaction logic for ExamForm.xaml
    /// </summary>
    public partial class ExamForm : Window
    {
        private Exam _exam;
        private Student _student;

        public ExamForm()
        {
            InitializeComponent();
            DataContext = this;
            Exam = new Exam();
            studentlist1.ItemsSource = StudentList.Students;
        }

        public Exam Exam
        {
            get => _exam;
            set => _exam = value;
        }

        public Student SelectedStudent
        {
            get => _student;
            set
            {
                _student = value;

                if (value != null)
                {
                    var exam = ExamList.Exams.Where(x => x.StudentId == value.StudentId).FirstOrDefault();
                    if (exam != null)
                        Exam.StudentName = exam.StudentName;
                    Exam.InformationTechnology = exam.InformationTechnology;
                    Exam.Science = exam.Science;
                    Exam.Biology = exam.Biology;
                    Exam.Physics = exam.Physics;
                    Exam.Chemistry = exam.Chemistry;
                    Exam.Arithmetic = exam.Arithmetic;
                    Exam.TotalNumber = Exam.InformationTechnology + Exam.Science + Exam.Biology + Exam.Physics + Exam.Chemistry + Exam.Arithmetic;
                }

                else
                {
                    //add
                    Exam.StudentId = SelectedStudent.StudentId;
                    Exam.StudentName = SelectedStudent.StudentName;
                    ExamList.Exams.Add(Exam);
                }

            }
        }
        private void btnAddMarks_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedStudent == null)
                return;

            var exam = ExamList.Exams.Where(x => x.StudentId == SelectedStudent.StudentId).FirstOrDefault();
            if (exam == null)
            {
                //add
                Exam.StudentId = SelectedStudent.StudentId;
                Exam.StudentName = SelectedStudent.StudentName;
                ExamList.Exams.Add(Exam);
            }
            else
            {
                //update
                exam.InformationTechnology = Exam.InformationTechnology;
                exam.Science = Exam.Science;
                exam.Biology = Exam.Biology;
                exam.Physics = Exam.Physics;
                exam.Chemistry = Exam.Chemistry;
                exam.Arithmetic = Exam.Arithmetic;
                Exam.TotalNumber = exam.InformationTechnology + exam.Science + exam.Biology + exam.Physics + exam.Chemistry + exam.Arithmetic;
            }

            this.Close();
        }
    }
}
