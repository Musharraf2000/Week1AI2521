using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1AI2521
{
    internal class Book
    {
        public string title;
        public int isbn;
        public Author bookAuthor;

        public Book(string title, int isbn, Author bookAuthor)
        {
            this.title = title;
            this.isbn = isbn;
            this.bookAuthor = bookAuthor;
        }
    }
}
