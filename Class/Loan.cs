using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra3.models
{
    class Loan
    {
        public string StudentId { get; set; }
        public string StudentName { get; set; }
        public string BookId { get; set; }
        public string BookTitle { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Loan()
        {

        }

        public Loan( string StudentId, string StudentName, string BookId, string BookTitle, DateTime LoanDate, DateTime ReturnDate)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.BookId = BookId;
            this.BookTitle = BookTitle;
            this.LoanDate = LoanDate;
            this.ReturnDate = ReturnDate;
        }
    }
}
