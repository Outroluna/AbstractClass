using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsidiary1.TaskBooking
{
    public class HotelBooking:Booking
    {
        public string NameHotel { get; set; }
        public ushort RoomNum { get; set; }
        public HotelBooking(ulong idBooking, string date,  string nameHotel, ushort roomNum):base(idBooking, date)
        {
            NameHotel = nameHotel;
            RoomNum = roomNum;
        }
        public override void MakeReservation()
        {
            Console.WriteLine($"Создана заявка на бронирование: id - {IdBooking}, Отель - {NameHotel}, Комната: {RoomNum}, Дата заезда: {DateBooking}");
        }
        public override void CancelReservation()
        {
            Console.WriteLine();
        }
        public override void ModifyReservation()
        {
            Console.WriteLine();
        }
    }
}
