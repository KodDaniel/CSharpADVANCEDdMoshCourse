using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Book
    {
        public string BookName { get; set; }
        public string Auhtor { get; set; }
        public int Pages{ get; set; }
        public int ReleaseYear { get; set; }

        public Book(string bookName)
        {
            this.BookName = bookName;
        }

    }
}
