using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.LibrarySystem
{
    public class Member
    {
        public string MemberId { get; set; }
        public string Name { get; set; }
        public List<LoanRecord> BorrowedBooks { get; set; } = new ();

        public Member(string name, string memberId)
        {
            MemberId = memberId;
            Name = name;
        }
    }

    public class LoanRecord
    {
        public BookItem BookItem { get; set; }
        public Member Borrower { get; set; }
        public DateTime BorrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? ReturnedDate { get; set; }

        public LoanRecord( BookItem bookItem,Member borrower)
        {
            BookItem = bookItem;
            Borrower = borrower;
            BorrowedDate = DateTime.Now;
            DueDate = DateTime.Now.AddDays(14); 
        }
    }

    public class FineCalculator
    {
        int fine = 5;
        public decimal CalculateFine(LoanRecord loanRecord)
        {
            if(!loanRecord.ReturnedDate.HasValue) return 0;

            int delayedDays = (int)(loanRecord.ReturnedDate.Value - loanRecord.DueDate).TotalDays;
            return fine*delayedDays;
        }
    }
}
