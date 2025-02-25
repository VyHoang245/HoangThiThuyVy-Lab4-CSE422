using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.Interface
{
     interface IService
    {
        void Add(IBook book);
        void Remove(IBook book);
        IBook GetBookByCategory(string title);
        IBook GetBookByTitle(string title);
    }
}
