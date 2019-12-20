using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise20
{
    /// <summary>
    /// The library must contain a name and a list of books. 
    /// </summary>
    class Library
    {
        private List<Book> bookList;
        public string Name { get; set; }
        public List<Book> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }
        public Library()
        {
            BookList = new List<Book>();
            Name = "Default Name";
        }
        public Library(string name)
        {
            BookList = new List<Book>();
            Name = name;
        }
        public Library(string name, List<Book> bookList)
        {
            BookList = bookList;
            Name = name;
        }

        /// <summary>
        /// Add book to the library
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            this.BookList.Add(book);            
        }
        public void AddBook(string title, string author)
        {
            BookList.Add(new Book(title, author));
        }
        public void AddBook(string title, string author, string publisher, DateTime? releaseDate, string iSBN)
        {
            BookList.Add(new Book(title, author, publisher, releaseDate, iSBN));
        }

        /// <summary>
        /// Delete one book on the library
        /// </summary>
        /// <param name="book"></param>
        public void DeleteBook(Book book)
        {
            if(BookList.Contains(book))
            {
                BookList.Remove(book);
            }           
        }
        /// <summary>
        /// Remove all books from Library
        /// </summary>
        public void ClearLibrary()
        {
            BookList.Clear();
        }
        /// <summary>
        /// Search for a book by a predefined author
        /// </summary>
        /// <param name="author"></param>
        public void SearchBookByAuthor(string author)
        {
            foreach(Book b in BookList)
            {
                if(b.Author.Equals(author,StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(b.ToString());
                }
            }
        }

    }
}
