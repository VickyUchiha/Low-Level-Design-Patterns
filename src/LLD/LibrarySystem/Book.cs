using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPatterns.src.LLD.LibrarySystem
{
    public class Book
    {
        public string IsBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int  PublicationYear { get; set; }

        public Book(string isbn,string title,string author,string publisher,int publicationYear)
        {
            IsBN = isbn;
            Title = title;
            Author = author;
            Publisher = publisher;
            PublicationYear = publicationYear;
            
        }
    }

    public enum BookStatus
    {
        Available,
        Borrowed
    }

    public class BookItem
    {
        public string BarCode { get; set; }
        public Book Book { get; set; }
        public BookStatus Status { get; set; }

        public BookItem(Book book,string barCode)
        {
            Book = book;
            Status = BookStatus.Available;  
            BarCode = barCode;
        }
    }
}
