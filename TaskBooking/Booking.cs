using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super.TaskBooking
{
    public abstract class Booking
    {
        protected ulong IdBooking {  get; set; }
        protected string DateBooking { get; set; }

        public Booking(ulong idBooking, string date) 
        {
            IdBooking = idBooking;
            DateBooking = date;
        }
        public abstract void MakeReservation();
        public abstract void CancelReservation();
        public abstract void ModifyReservation();
    }
}
