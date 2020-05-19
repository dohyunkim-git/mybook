using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mybook
{
    class Program
    {
        class Book
        {
            public string irum;
            public string chophan;
            public string jieuni;
            public string pyeonani;
            public string pyenangot;
            public string chackim;
            public string pyeonzip;
            public string gihwick;
            public string design;
        }
        static void Main(string[] args)
        {
            List<Book> book = new List<Book>();
            book.Add(new Book { irum = "PHP 프로그래밍 입문", chophan = "2013년5월20일", jieuni = "황재호", pyeonani = "김태헌", pyenangot = "한빛아카데미(주)", chackim = "김현용", pyeonzip = "김이화", gihwick = "김이화", design = "여동일"});
        }
    }
}