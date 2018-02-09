using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 本节课学习集合的用法
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
                       
            /*
            // 建立泛型列表，可以自定义其允许容纳的元素的类
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(book1); // 当添加book类的元素时，会报错
            foreach (Car car in myList)
            {
                Console.WriteLine("{0} {1}",car.Make , car.Model);
            }
            */


            /*
            // 建立一个集合名叫"Arrays",这是一个动态集合，可以根据内容实时调整
            // 建这种集合可以方便的进行移除,加入等操作;缺点是如果有不同类的元素，则输出(遍历)时会出错因此不适合用作容纳多种类型元素
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */


            // 建立词典集合，类似于网络搜索，可以按照字母顺序查找元素，并且可以在找到的元素旁看到定义
            // 这种集合只包含键和其值，因此也称为泛型词典集合





            Console.ReadLine();

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
