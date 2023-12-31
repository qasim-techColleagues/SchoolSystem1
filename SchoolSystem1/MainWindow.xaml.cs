﻿using SchoolSystem1.Exam;
using SchoolSystem1.FeesManagement;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SchoolSystem1
{
   
  
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
       
        private void btnStudentMenu_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new StudentList();
        }

        private void btnFeeMenu_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new FeeList();

        }

        private void btnExamMenu_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new ExamList();
        }
    }
}
