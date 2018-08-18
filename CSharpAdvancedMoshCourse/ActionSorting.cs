using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class ActionSorting
    {
    
        // Metod som tar den osorterade boken och min delegate
        public static void SortingProcess(Book unSortedBook, Action<Book> bookSorter)
        {            
            bookSorter(unSortedBook);
        }

        public void SortByAuthor(Book book)
        {
            Console.WriteLine("{0} has been sorted by auhtor.", book.BookName);
        }

        public void SortByRelaseDate(Book book)
        {
            Console.WriteLine("{0} has been sorted by its release date.", book.BookName);
        }


    }
}
