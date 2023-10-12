using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem1.FeesManagement
{
    public class Fee
    {
        private string _studentname;
        private int _studentid;
        private string _studentfather;
        //private int _tuitionfee;
        //private int _examfee;
        //private int _annualfee;
        //private int _sportsfee;
        private int _tuitionfee_remaning_due;
        private int _tuitionfee_paid_due;
        private int _examfee_remaning_due;
        private int _examfee_paid_due;
        private int _sportsfee_remaining_due;
        private int _sportsfee_paid_due;
        private int _annualfee_paid_due;
        private int _annualfee_remaning_due;
        //public int TuitionFee { get => _tuitionfee; set => _tuitionfee = value; }
        //public int ExamFee { get => _examfee; set => _examfee = value; }
        //public int AnnualFee { get => _annualfee; set => _annualfee = value; }
        //public int SportsFee { get => _sportsfee; set => _sportsfee = value; }
        public int StudentId { get => _studentid; set => _studentid = value; }
        public string Studentname { get => _studentname; set => _studentname = value; }
        public string StudentFather { get => _studentfather; set => _studentfather = value; }
        public int Sports_PaidDues { get => _sportsfee_paid_due; set => _sportsfee_paid_due = value; }
        public int Sports_RemainingDues { get => _sportsfee_remaining_due; set => _sportsfee_remaining_due = value; }
        public int Tuition_PaidDues { get => _tuitionfee_paid_due; set => _tuitionfee_paid_due = value; }
        public int Tuition_RemainingDues { get => _tuitionfee_remaning_due; set => _tuitionfee_remaning_due = value; }
        public int Exam_PaidDues { get => _examfee_paid_due; set => _examfee_paid_due = value; }
        public int Exam_RemainingDues { get => _examfee_remaning_due; set => _examfee_remaning_due = value; }
        public int Annual_PaidDues { get => _annualfee_paid_due; set => _annualfee_paid_due = value; }
        public int Annual_RemainingDues { get => _annualfee_remaning_due; set => _annualfee_remaning_due = value; }
    }
}
