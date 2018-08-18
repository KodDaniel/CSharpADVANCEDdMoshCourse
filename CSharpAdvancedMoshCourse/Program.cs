using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {       

        static void Main(string[] args)
        {         
          ActionDelegate();    
          //FuncDelegate();
        }

        public static void ActionDelegate()
        {
            // Skapar instans av ActionSorting-klassen
            var sortBook = new ActionSorting();
            // Skapar ny bok
            var newBook = new Book("Skattkammarön");
            // Skapar instans av min delegate och får den att peka mot SortByAuhtor
            Action<Book> bookSorter = sortBook.SortByAuthor;
            // Får min instans av min delegate att peka BÅDE mot SortByAuhtor och SortByRelaseDate
            bookSorter += sortBook.SortByRelaseDate;
            //Testar om min Deleget på allt det kan peka mot en metod jag skapar helt själv (SortByNumberOfPages)
            bookSorter += SortByNumberOfPages;
            //Anropar Sortingprocess-metoden med min delegate-INSTANS och boken som ska sorteras.
            ActionSorting.SortingProcess(newBook, bookSorter);
            Console.ReadLine();
    
        }

        public static void FuncDelegate()
        {
            var sortbook = new FuncSorting();
            // Skapar lista
            var unsortedBookList = new List<Book>();

            // Skapar böcker som ska sorteras
            var book1 = new Book("Pelle Svanslös") { Auhtor = "Göta Knutsson", Pages = 52, ReleaseYear = 1973 };
            var book2 = new Book("Mummintrollet") { Auhtor = "Tove Johansson", Pages = 84, ReleaseYear = 1989 };
            var book3 = new Book("Harry Potter") { Auhtor = "JK Rowling", Pages = 1184, ReleaseYear = 2003 };
            var book4 = new Book("Pippi Långstrump") { Auhtor = "Astrid Lindgren", Pages = 65, ReleaseYear = 1952 };

            // Lägger in böckerna i listan
            unsortedBookList.Add(book1);
            unsortedBookList.Add(book2);
            unsortedBookList.Add(book3);
            unsortedBookList.Add(book4);

            //Func<List<Book>, List<Book>> funcSorter =  sortbook.ReverseBookList(unsortedBookList);
        }

        

        public static void SortByNumberOfPages(Book book)
        {
            Console.WriteLine("{0} has been sorted by the number of pages.", book.BookName);
        }




    }
}
