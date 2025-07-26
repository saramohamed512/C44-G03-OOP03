using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP03
{
    public class EBook : Book
    {
        public double FileSizeMB { get; set; } 
        public string Format { get; set; }

        public EBook(string title, string author, string isbn, double fileSize, string format)
            : base(title, author, isbn)
        {
            FileSizeMB = fileSize;
            Format = format;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nFile Size: {FileSizeMB} MB\nFormat: {Format}";
        }

    }
}
