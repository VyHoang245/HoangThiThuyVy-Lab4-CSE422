
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab4_SOLID.Interface;

namespace Lab4_SOLID.ReaderManagement
{
     class ReaderManagement
    {
        public List<IUser> ReaderList { get; set; }

        public ReaderManagement(List<IUser> readerList)
        {
            ReaderList = readerList;
        }

        public void Add(IUser reader) { 
            ReaderList.Add(reader);
        }
        public void Remove(IUser reader)
        {
            ReaderList.Remove(reader);
        }
    }
}
