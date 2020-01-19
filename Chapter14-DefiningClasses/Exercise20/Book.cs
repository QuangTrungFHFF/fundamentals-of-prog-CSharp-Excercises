using System;
using System.Text;

namespace Exercise20
{
    /// <summary>
    /// The books must contain the title, author, publisher, release date and ISBN-number.
    /// </summary>
    public class Book
    {
        private DateTime? releaseDate;
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate
        {
            get
            {
                return releaseDate?.ToString("d");
            }
            set
            {
                if(value!=null)
                {
                    releaseDate = DateTime.Parse(value);
                }
                else
                {
                    releaseDate = null;
                }
                
            }
        }
            
        public string ISBN { get; set; }
        public Book()
        {
            Title = null;
            Author = null;
            Publisher = null;
            ReleaseDate = null;
            ISBN = null;
        }
        public Book(string title, string author, string publisher, string releaseDate, string iSBN)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = iSBN;
        }
        public Book(string title, string author) : this(title,author,null,null,null)
        {
        }
        public Book(string title, string author, string publisher):this(title,author,publisher,null,null)
        {
        }
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append("Title: " + Title);
            info.Append(Environment.NewLine);
            info.Append("Author: " + Author);
            info.Append(Environment.NewLine);
            info.Append("Publisher: " + Publisher);
            info.Append(Environment.NewLine);
            info.Append("Release date: " + ReleaseDate);
            info.Append(Environment.NewLine);
            info.Append("ISBN: " + ISBN);
            info.Append(Environment.NewLine);
            info.Append("-----------------------------------------------");
            return info.ToString();
        }
    }
}
