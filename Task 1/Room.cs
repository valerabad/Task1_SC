using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Room
    {
        public List<Point> listOfUsedPlace;
        public List<RoomObject> listObjects;


        public Room()
        {
            listOfUsedPlace = new List<Point>();
            listObjects = new List<RoomObject>();
        }

        public bool PlaceIsFree(Point candidatePlace)
        {          
            if (listOfUsedPlace.Contains(candidatePlace)) return false;
            else
                return true;
        }

        //public void AddObject(RoomObject roomObject)
        //{

        //    if (!listOfUsedPlace.Contains(roomObject.curentPoints))
        //    {
        //        listOfUsedPlace.Add(roomObject.curentPoints);
        //    }
        //    else
        //    {
        //        Point newStartPoints;
        //        do
        //        {
        //            newStartPoints = roomObject.GenerateRandomPlace();
        //        }
        //        while (PlaceIsFree(newStartPoints) != true);
        //        roomObject.curentPoints = newStartPoints;
        //        listOfUsedPlace.Add(newStartPoints);
        //    }
        //    //ObjectMover.listObjects.Add(roomObject);
        //    listObjects.Add(roomObject);
        //}

    }
}
