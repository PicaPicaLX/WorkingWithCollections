using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book book1 = new Book();
            book1.Aythor = "Robert Tabor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0-000-00000-0";
        }
    }

    class Car
    {
        public string Make { get; set; }  
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Aythor { get; set; }
        public string ISBN { get; set; }
    }
}
