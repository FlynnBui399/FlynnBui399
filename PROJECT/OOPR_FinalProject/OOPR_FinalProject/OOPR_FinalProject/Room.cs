using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPR_FinalProject
{
    public class Room
    {
        private int roomNumber;
        private string roomType;
        private bool isAvailable;

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public bool IsAvailable
        {
            get { return isAvailable; }
            set { isAvailable = value; }
        }

        public Room(int number, string type)
        {
            RoomNumber = number;
            RoomType = type;
            IsAvailable = true;
        }
    }
}