using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_OOP
{
    public class PrintedBook : Book
    {
        public int PageCount { get; set; } 
        public string CoverType { get; set; }

        public PrintedBook(string title, string author, string isbn, int pageCount, string coverType)
            : base(title, author, isbn)
        {
            PageCount = pageCount;
            CoverType = coverType;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nPage Count: {PageCount}\nCover Type: {CoverType}";
        }
    }
}
