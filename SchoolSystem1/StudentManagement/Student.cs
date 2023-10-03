using System;
using System.ComponentModel;

namespace SchoolSystem1.StudentManagement
{
    public class Student : INotifyPropertyChanged
    {
        private int _studentId;
        private string _studentName;
        private string _fatherName;
        private static int StudentIdCounter = 1;

        public Student(string studentName, string fatherName)
        {
            _studentName = studentName;
            _fatherName = fatherName;
            _studentId = StudentIdCounter++;
        }
        public Student() { }
        public int StudentId
        {
            get => _studentId;
            set
            {
                if (_studentId != value)
                {
                    _studentId = value;
                    OnPropertyChanged(nameof(StudentId));
                }
            }
        }

        public string StudentName
        {
            get => _studentName;
            set
            {
                if (_studentName != value)
                {
                    _studentName = value;
                    OnPropertyChanged(nameof(StudentName));
                }
            }
        }

        public string FatherName
        {
            get => _fatherName;
            set
            {
                if (_fatherName != value)
                {
                    _fatherName = value;
                    OnPropertyChanged(nameof(FatherName));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
