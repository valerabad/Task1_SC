using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Desk : RoomObject , IFurniture 
    {
        public string model { get; set; }
        public string manufacturer { get; set; }

        public override void Move()
        {
            Console.WriteLine("Desk was moved");
            base.MoveBase();
        }
    }
}
