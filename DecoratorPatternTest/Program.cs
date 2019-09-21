using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern;

namespace DecoratorPatternTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage essp = new Espresso();
            Console.WriteLine(essp.GetDiscription() + "\t" + essp.cost().ToString());

            Beverage houseB = new HouseBlend();
            Console.WriteLine(houseB.GetDiscription() + "\t" + houseB.cost().ToString());

            essp = new Whip(essp);
            Console.WriteLine(essp.GetDiscription() + "\t" + essp.cost().ToString());

            essp = new SteamMilk(essp);
            Console.WriteLine(essp.GetDiscription() + "\t" + essp.cost().ToString());

            houseB = new Soy(houseB);
            Console.WriteLine(houseB.GetDiscription() + "\t" + houseB.cost().ToString());

            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();
            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.BorrowItem("Customer #3");
            borrowvideo.Display();

            borrowvideo.ReturnItem("Customer #1");
            borrowvideo.ReturnItem("Customer #2");
            borrowvideo.Display();

            // Wait for user
            Console.ReadKey();

            while (true)
            {

            }
        }
    }
}
