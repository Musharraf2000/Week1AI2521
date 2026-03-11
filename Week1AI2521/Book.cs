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
        public int ISBN;
        public Author bookAuthor;

        public Book(string title, int iSBN, Author bookAuthor)
        {
            this.title = title;
            ISBN = iSBN;
            this.bookAuthor = bookAuthor;
        }
    }
}
