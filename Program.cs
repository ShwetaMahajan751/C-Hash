using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_Task
{
    class PhotoBook
    {
        public int pg;
        private int numPages;

        public int NumPages
        {
            get { return numPages; }
            set { numPages = value; }
        }
       

    public int GetNumberPages()
        {
            Console.WriteLine("Number of pages are: "+numPages);
           return numPages;
        }

        public PhotoBook()
        {
            Console.WriteLine("The number of pages in album are: 16");
        }

        public PhotoBook(int Pg)
        {
            pg = Pg;
            Console.WriteLine("Number of Pages in photo book is: "+pg);
        }   
    }

    class BigPhotoBook:PhotoBook
    {
        public BigPhotoBook()
        {
            Console.WriteLine("The number of pages are: 64");
        }

    }
    internal class PhotoBookTest
    {
        static void Main(string[] args)
        {

            PhotoBook book = new PhotoBook();
            book.NumPages = 200;
            book.GetNumberPages();
            Console.WriteLine("Enter no. of pages you want in album: ");
            int Pg=Convert.ToInt32(Console.ReadLine());
            PhotoBook a = new PhotoBook(Pg);
            BigPhotoBook b = new BigPhotoBook();

        }
    }
}
