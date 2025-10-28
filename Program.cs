using DPatterns.src.LLD.LibrarySystem;
using System;
using System.Drawing;

namespace DPatterns
{
    public class Program
    {
        static void NotMain(string[] args)
        {

            //Library
            var library = new Library();

            var book1 = new Book("ISBN001", "Book1", "Author1", "Publisher1", 2020);
            var book2 = new Book("ISBN002", "Book2", "Author2", "Publisher2", 2021);

            var bookItem1 = new BookItem(book1,"BARCODE001");
            var bookItem2 = new BookItem(book2,"BARCODE002");

            library.AddBook(bookItem1);
            library.AddBook(bookItem2);

            var member1 = new Member("kirito", "MEMBER001");
            var member2 = new Member("ken", "MEMBER002");

            library.AddMember(member1);
            library.AddMember(member2);

            var searchedItem = library.Search("author1");
            Console.WriteLine($"Searched Book : {searchedItem.FirstOrDefault().Book.Title}");

            library.BorrowBooks(member1.MemberId,bookItem1.BarCode);

            library.returnBook(member1.MemberId,bookItem1.BarCode);





            ////Parking System
            //var parkingLot = new ParkingLot(2, 2, 2, 1);
            //var manager = new ParkingManager(parkingLot);

            //var bike = new Bike { LicensePlate = "TN01BU9794", Color = "black" };
            //var car = new Car { LicensePlate = "TN09AB1234", Color = "Red" };

            //manager.ParkVehicle(bike);
            
        }
    }
}
