using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_6
{
    struct Books
    {
        int book_id;
        public int Book_id
        {
            get { return book_id; }
            set { book_id = value; }
        }
        public Books(int book_id)
        {
            this.book_id = book_id;
        }
        public void value(int value)
        {
            Console.WriteLine("the book id is " + book_id + " \nthe value of book " + value);
        }
    }
        class InterfaEg
    {
        static void Main()
        {

            IStudent obj = new DayScholar();
            obj.DisplayDetails(1, "vamsikrishna");


            IStudent obj1 = new Resident();
            obj1.DisplayDetails(2, "Krishna vamsi");



            Books book1 = new Books(123);
            book1.value(1000);
            Console.ReadLine();

            Console.ReadLine();
        }
    }
    
    
    
}
