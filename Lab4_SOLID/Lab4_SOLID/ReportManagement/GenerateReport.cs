using Lab4_SOLID.BookManagement;
using Lab4_SOLID.Interface;
using Lab4_SOLID.ReaderManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_SOLID.ReportManagement
{
    class GenerateReport : IGenerateReport
    {
        public GenerateReport()
        {
        }

        public void Generate(IBook book, IUser reader)
        {
           // string readerName = reader.getDetails;

            Console.WriteLine(reader.Name + " borrowed "+book.Title);
        }

    }
}
