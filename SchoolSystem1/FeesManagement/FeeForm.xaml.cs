using SchoolSystem1.StudentManagement;
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

namespace SchoolSystem1.FeesManagement
{
    /// <summary>
    /// Interaction logic for FeeForm.xaml
    /// </summary>
    public partial class FeeForm : Window
    {
        private Fee _fee;
        private Student _student;
        public FeeForm()
        {
            InitializeComponent();
            DataContext = this;
            Fee = new Fee();
            studentNamelist.ItemsSource = StudentList.Students;
        }

        public Fee Fee
        {
            get => _fee;
            set => _fee = value;
        }
        public Student SelectedStudent
        {
            get => _student;
            set
            {
                _student = value;

                if (value != null)
                {
                    var fee =FeeList.Fees.Where(x => x.StudentId == value.StudentId).FirstOrDefault();
                    if (fee != null)
                        Fee = fee;

                }
            }
        }

        private void btn_feesubmit_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedStudent == null)
                return;
            var fee = FeeList.Fees.Where(x => x.StudentId == SelectedStudent.StudentId).FirstOrDefault();
            if (fee == null)
            {
                Fee.Studentname = SelectedStudent.StudentName;
                Fee.StudentId = SelectedStudent.StudentId;
                Fee.StudentFather = SelectedStudent.FatherName;
                FeeList.Fees.Add(Fee);
            }
            else
            {
                fee = Fee;
            }
            this.Close();


        }
    }
}
