using Lab4_SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.BookManagement
{
    class Book : IBook, IGetDetails
    {
        public int Id { get ; set ; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        public Book(int id, string title, string author, string category, int quantity)
        {
            Id = id;
            Title = title;
            Author = author;
            Category = category;
            Quantity = quantity;
        }

        public void Borrow()
        {
            if (Quantity > 0)
            {
                Quantity--;
            }
            else
            {
                Console.WriteLine("The book is out of stock!");
            }
        }

        public void UnBorrow()
        {
            Quantity++;
        }

        public string getDetails()
        {
           return Title +" "+ Author;
        }

    }
}
