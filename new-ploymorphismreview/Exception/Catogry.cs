using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{

    public class Catogry
    {
        public string name { get; set; }
        public List<Book> books = new List<Book>();
        public Book this[int index]
        {
            get
            {
                if (index < books.Count)
                {
                    return books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Error");
                }
            }
            set
            {
                if (index < books.Count)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Error");
                }
            }
        }
    }
}
