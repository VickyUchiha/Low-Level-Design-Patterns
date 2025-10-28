using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.LibrarySystem
{
    public class Library
    {
        private readonly List<BookItem> _books = new List<BookItem>(); 
        private readonly List<Member> _members = new List<Member>(); 
        private readonly List<LoanRecord> _loanRecords = new List<LoanRecord>(); 
        private readonly FineCalculator _fineCalculator = new FineCalculator();

        public void AddBook(BookItem bookItem)
        {
            _books.Add(bookItem);
            Console.WriteLine($"Book : {bookItem.Book.Title}");
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
            Console.WriteLine($"Member : {member.Name}");
        }

        public List<BookItem> Search (string keyword)
        {
            var books = _books.Where(_ => _.Book.Title.Contains(keyword,StringComparison.OrdinalIgnoreCase) || _.Book.Author.Contains(keyword,StringComparison.OrdinalIgnoreCase)).ToList();
            return books;
        }

        public void BorrowBooks(string memberId,string barCode)
        {
            var member = _members.FirstOrDefault(_ => _.MemberId == memberId);
            var bookItem = _books.FirstOrDefault(_ => _.BarCode == barCode);

            if(member == null || bookItem == null)
            {
                Console.WriteLine("Invalid member or book!");
                return;
            }
            else
            {
                if (bookItem.Status == BookStatus.Available)
                {
                    var loanRecord = new LoanRecord(bookItem, member);
                    _loanRecords.Add(loanRecord);
                    member.BorrowedBooks.Add(loanRecord);
                    bookItem.Status = BookStatus.Borrowed;
                    Console.WriteLine($"Borrowed {bookItem.Book.Title} by {member.Name}");
                }
            }

        }

        public void returnBook(string memberId, string barCode)
        {
            var record = _loanRecords.FirstOrDefault(_ => _.BookItem.Equals(barCode));

            if(record == null)
            {
                Console.WriteLine("Invalid book!");
                return;
            }

            record.ReturnedDate = DateTime.Now;
            record.BookItem.Status = BookStatus.Available;

            var fine = _fineCalculator.CalculateFine(record);
            Console.WriteLine($"Returned {record.BookItem.Book.Title} by {record.Borrower.Name}. Fine : {fine}");

        }
    }

}
