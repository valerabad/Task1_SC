using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public abstract class RoomObject
    {
        public Point curentPoints;
        public Point oldPoints;
        private static Random rndm;
        public abstract void Move();
        public Room Room;

        static RoomObject()
        {
            rndm = new Random(); //DateTime.Now.Millisecond                
        }

        public RoomObject() //Room room
        {            
            //this.Room = room;
            this.curentPoints.X = 0;
            this.curentPoints.Y = 0;
        }



        public Point GenerateRandomPlace()
        {
            Point newPoints = new Point(rndm.Next(0,100), rndm.Next(0, 100));
            return newPoints;
        }        
      
        public void MoveBase()
        {
            Point placeCandidate = GenerateRandomPlace();
            if (Room.PlaceIsFree(placeCandidate))
                simpleMove(placeCandidate);
            else
            {
                do
                {
                    placeCandidate = GenerateRandomPlace();
                }
                while (Room.PlaceIsFree(placeCandidate) !=true);
                simpleMove(placeCandidate);
            }

        }

        private void simpleMove(Point newPoints)
        {
            oldPoints = this.curentPoints;        
            this.curentPoints = newPoints; // будет ли коппирование, ссылочные и значимые типы            

            Room.listOfUsedPlace.Add(this.curentPoints);
            Room.listOfUsedPlace.Remove(this.oldPoints);

            Console.WriteLine("Room object {0} was moved in ({1};{2}). Old coordinates ({3};{4})",
                this.GetType().ToString(),
                this.curentPoints.X, this.curentPoints.Y, // to method
                oldPoints.X, oldPoints.Y);
        }

        

        //virtual public void VirtualMove()
        //{
        //    // remake

        //    if (! Room.listOfUsedPlace.Contains(this.curentPoints))
        //    {
        //        move();
        //        Room.listOfUsedPlace.Add(this.curentPoints);
        //        Room.listOfUsedPlace.Remove(this.oldPoints);
        //    }
        //    else
        //    {
        //        //if (!Room.listOfUsedPlace.Contains(this.curentPoints))

        //        {
        //            move();
        //            Console.WriteLine("This plase is used");
        //        }
        //    }            
        //}

        
    }

    //public struct Point
    //{
    //    //bool isFree;      
    //    public string WriteXY()
    //    {
    //        return this.x.ToString() + ";" + this.y.ToString();
    //    }

    //    private int X;
    //    public int x
    //    {
    //        get
    //        {
    //            return X;
    //        }
    //        set
    //        {
    //            if ((value >= 1) & (value <= 100))
    //            {
    //                X = value;
    //            }
    //            else
    //                x = 0;
    //        }
    //    }

    //    private int Y;
    //    public int y
    //    {
    //        get
    //        {
    //            return Y;
    //        }
    //        set
    //        {
    //            if ((value >= 0) && (value <= 100))
    //            {
    //                Y = value;
    //            }
    //        }
    //    }

    //    public Point(int x_, int y_)
    //    {
    //        Random rndm = new Random(DateTime.Now.Millisecond);
    //        this.X = x_;
    //        this.Y = y_;            
    //    }
    //}



    
}
