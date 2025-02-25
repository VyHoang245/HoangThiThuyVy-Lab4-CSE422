using Lab4_SOLID.BookManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.Interface
{
     interface IUser
    {
        int Id { get; set; }
       string Name { get; set; }
        List<IBook> Books { get; set; }
        void BorrowBook(IBook book);
        void UnBorrowBook(IBook book);
    }
}
