using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPR_FinalProject
{
    public class Receptionist : Person
    {
        public string CheckIn(Guest guest, Reservation reservation)
        {
            return ($"Checked in {guest.Name} for reservation {reservation.Id}");
        }

        public string CheckOut(Guest guest, Room room)
        {
            return($"Checked out {guest.Name} from room {room.RoomNumber}");
        }

        public override string PrintDetails()
        {
            return($"Receptionist: {Name}, Contact: {ContactInfo}");
        }
    }

}