using System.ComponentModel;

namespace SchoolSystem1.Exam
{
    public class Exam : INotifyPropertyChanged
    {
        private int _studentId;
        private string _studentName;
        private int _informationTechnology;
        private int _science;
        private int _biology;
        private int _physics;
        private int _chemistry;
        private int _arithmetic;
        private int _totalnumber;

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

        public int InformationTechnology
        {
            get => _informationTechnology;
            set
            {
                if (_informationTechnology != value)
                {
                    _informationTechnology = value;
                    OnPropertyChanged(nameof(InformationTechnology));
                }
            }
        }

        public int Science
        {
            get => _science;
            set
            {
                if (_science != value)
                {
                    _science = value;
                    OnPropertyChanged(nameof(Science));
                }
            }
        }

        public int Biology
        {
            get => _biology;
            set
            {
                if (_biology != value)
                {
                    _biology = value;
                    OnPropertyChanged(nameof(Biology));
                }
            }
        }

        public int Physics
        {
            get => _physics;
            set
            {
                if (_physics != value)
                {
                    _physics = value;
                    OnPropertyChanged(nameof(Physics));
                }
            }
        }

        public int Chemistry
        {
            get => _chemistry;
            set
            {
                if (_chemistry != value)
                {
                    _chemistry = value;
                    OnPropertyChanged(nameof(Chemistry));
                }
            }
        }

        public int Arithmetic
        {
            get => _arithmetic;
            set
            {
                if (_arithmetic != value)
                {
                    _arithmetic = value;
                    OnPropertyChanged(nameof(Arithmetic));
                }
            }
        }

        public int TotalNumber
        {
            get => _totalnumber;
            set
            {
                if (_totalnumber != value)
                {
                    _totalnumber = value;
                    OnPropertyChanged(nameof(TotalNumber));
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
