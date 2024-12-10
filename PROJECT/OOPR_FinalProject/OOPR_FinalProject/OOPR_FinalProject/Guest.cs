using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPR_FinalProject
{
    public class Guest : Person
    {
        public string MakeReservation(Room room, DateTime checkIn, DateTime checkOut)
        {
            return $"Reservation made for {Name} in room {room.RoomNumber} from {checkIn.ToShortDateString()} to {checkOut.ToShortDateString()}";
        }

        public string RequestService(string service)
        {
            return $"{Name} requested {service}";
        }

        public override string PrintDetails()
        {
            return ($"Guest: {Name}, Contact: {ContactInfo}");
        }
    }
}