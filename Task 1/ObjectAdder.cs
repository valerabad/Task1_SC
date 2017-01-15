using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
    static class ObjectAdder
    {             
        static public void AddObjectToRoom(RoomObject roomObject, Room room)
        {
            roomObject.Room = room;
                  
            if (!room.listOfUsedPlace.Contains(roomObject.curentPoints))
            {
                room.listOfUsedPlace.Add(roomObject.curentPoints);
            }
            else
            {
                Point newStartPoints;
                do
                {
                    newStartPoints = roomObject.GenerateRandomPlace();
                }
                while (room.PlaceIsFree(newStartPoints) != true);
                roomObject.curentPoints = newStartPoints;
                room.listOfUsedPlace.Add(newStartPoints);
            }            
            
            room.listObjects.Add(roomObject);
        }

        
                           
    }
}
