using Azure;
using SchoolSystem1.StudentManagement;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

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
            // Exams= new ObservableCollection<Exam>();
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
                examForm.SelectedStudent = StudentList.Students.Where(x => x.StudentId == selectedExam.StudentId).First();
                examForm.ShowDialog();
            }

        }
        private void btnDeleteExam_Click(object sender, RoutedEventArgs e)
        {
            if (dgExams.SelectedItem != null)
            {
                Exam selectedExam = dgExams.SelectedItem as Exam;
                MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this exam?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    Exams.Remove(selectedExam);
                }
            }
        }
            private void PrintButton_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                // Create a FlowDocument to print
                FlowDocument flowDocument = CreateFlowDocument();

                // Create a DocumentPaginator for the FlowDocument
                IDocumentPaginatorSource paginatorSource = flowDocument;
                DocumentPaginator paginator = paginatorSource.DocumentPaginator;

                // Set the paginator for the print document
                printDialog.PrintDocument(paginator, "Print Example");
            }
        }

        private FlowDocument CreateFlowDocument()
        {
            // Create a FlowDocument with some content
            FlowDocument flowDocument = new FlowDocument();

            Paragraph paragraph = new Paragraph(new Run("Hello, this is a sample document for printing in WPF."));
            flowDocument.Blocks.Add(paragraph);

            return flowDocument;
        }
    }
}
