using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Room room = new Room();
            RoomObject desk = new Desk();
            RoomObject dog = new Dog();
            RoomObject chair = new Chair();

            ObjectAdder.AddObjectToRoom(desk,room);
            ObjectAdder.AddObjectToRoom(dog, room);
            ObjectAdder.AddObjectToRoom(chair, room);
         
            do
            {
                ObjectMover.Replace(room);
                Console.WriteLine("Enter A+Enter for exit");
                Console.WriteLine();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.A);            

            Console.ReadKey();
        }
    }
}
