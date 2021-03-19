using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialProgra3.models
{
    class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime YearOfPublication { get; set; }

        public Book()
        {

        }

        public Book(string Id, string Title, string Author, DateTime YearOfPublication)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.YearOfPublication = YearOfPublication;
        }

        public Book(string Id, string Title = "")
        {
            this.Id = Id;
            this.Title = Title;
        }
    }
}
