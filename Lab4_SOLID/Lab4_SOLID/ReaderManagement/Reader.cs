using Lab4_SOLID.BookManagement;
using Lab4_SOLID.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.ReaderManagement
{
    class Reader : IGetDetails, IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IBook> Books { get; set; }

        public Reader(int id, string name)
        {
            Id = id;
            Name = name;
            Books = new List<IBook>();
        }

        public string getDetails()
        {
            return Name;
        }

        public void BorrowBook(IBook book)
        {
            if (Books.Count() == 3)
            {
                Console.WriteLine("User just can borrow 3 books");
            }
            else {
                Books.Add(book);
                book.Borrow();
            }
        }

        public void UnBorrowBook(IBook book)
        {
            if (!Books.Contains(book)) { 
                Books.Remove(book);
                book.UnBorrow();
            }
            else
            {
                Console.WriteLine("User did not borrow this book.");
            }
        }
    }
}
