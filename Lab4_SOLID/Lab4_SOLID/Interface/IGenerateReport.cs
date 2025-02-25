using Lab4_SOLID.BookManagement;
using Lab4_SOLID.ReaderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.Interface
{
     interface IGenerateReport
    {
        void Generate(IBook book, IUser reader);
    }
}
