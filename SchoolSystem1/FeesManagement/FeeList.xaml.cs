using SchoolSystem1.StudentManagement;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolSystem1.FeesManagement
{
    /// <summary>
    /// Interaction logic for FeeList.xaml
    /// </summary>
    public partial class FeeList : Page
    {
        static FeeList()
        {
            Fees = new ObservableCollection<Fee>();
        }
        public FeeList()
        {
            InitializeComponent();
            DataContext = this;
        }
        public static ObservableCollection<Fee> Fees { get; set; }

        private void addfee_Click(object sender, RoutedEventArgs e)
        {
            var feestudent = new FeeForm();
            feestudent.ShowDialog();

        }

        private void dgfeelist_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgfeelist != null)
            {
                Fee selectedfee = dgfeelist.SelectedItem as Fee;
                FeeForm feeSystem = new FeeForm();
                feeSystem.Fee = selectedfee;
                feeSystem.SelectedStudent = StudentList.Students.Where(x => x.StudentId == selectedfee.StudentId).First();
                feeSystem.ShowDialog();
            }

        }
    }
}
