using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.Interface
{
     interface IBook
    {
        int Id { get; set; }
        public string Title { get; set; }
        string Author { get; set; }
        string Category { get; set; }
        int Quantity { get; set; }
        void Borrow();
        void UnBorrow();
    }
}
