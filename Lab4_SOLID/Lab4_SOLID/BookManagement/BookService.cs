using Lab4_SOLID.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4_SOLID.BookManagement
{
     class BookService:IService
    {
        public List<IBook> books;

        public BookService(List<IBook> books)
        {
            this.books = books;
        }

        public void Add(IBook book)
        {
            books.Add(book);
        }

        public void Remove(IBook book)
        {
            books.Remove(book);
        }

        public IBook GetBookByCategory(string cate)
        {
            foreach (var item in books)
            {
                string category = item.Category.ToLower();
                if (category.CompareTo(cate.ToLower()) == 0){
                    return item;
                }
            }
            return null;
        }

       public IBook GetBookByTitle(string title)
        {
            foreach (var item in books)
            {
                string category = item.Title.ToLower();
                if (category.CompareTo(title.ToLower()) == 0)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
