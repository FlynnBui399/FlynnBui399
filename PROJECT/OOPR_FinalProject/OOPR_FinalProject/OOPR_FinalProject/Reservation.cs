using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPR_FinalProject
{
    public class Reservation
    {
        public int Id { get; set; }
        public Room Room { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public Reservation(int id, Room room, DateTime checkIn, DateTime checkOut)
        {
            Id = id;
            Room = room;
            CheckInDate = checkIn;
            CheckOutDate = checkOut;
        }
    }
}