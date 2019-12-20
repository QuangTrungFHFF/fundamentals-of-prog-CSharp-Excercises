using System;
using System.Linq;
using Exercise20;
/// <summary>
/// Write a test class, which creates an object of type library, adds several books to it and displays information about each of them. 
/// Implement a test functionality, which finds all books authored by Stephen King and deletes them. 
/// Finally, display information for each of the remaining books.
/// </summary>

namespace Exercise21
{
    class TestLibrary
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook("Carrie", "Stephen King");
            library.AddBook("The Long Walk", "Stephen King", "Signet Books",null, "978-0-451-08754-6");
            library.AddBook("And Then There Were None", "Agatha Christie");
            library.AddBook("Cat Among the Pigeons", "Agatha Christie", "William Collins & Sons","27.12.1959", "9788525422392");
            Console.WriteLine("Book in library: ");
            Console.WriteLine("><><><>><><><><><><><><><");
            library.PrintLibraryInfo();
            library.SearchBookByAuthor("Stephen King");
            foreach(Book b in library.BookList.ToList())
            {
                if(b.Author=="Stephen King")
                {
                    library.DeleteBook(b);
                }
            }
            Console.WriteLine("Book in library: ");
            Console.WriteLine("><><><>><><><><><><><><><");
            library.PrintLibraryInfo();
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
