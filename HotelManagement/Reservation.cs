using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    class Reservation
    {
        public int Id;
        public Room Room;
        public Guest Guest;
        public int Number_of_Guests;
        public DateTime Entry_Date;
        public DateTime Departure_Date;
        public int Total_Payment;
        public static string TableName = "reservation";

        public bool Save()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["room_id"] = Room.Id.ToString();
            data["guest_id"] = Guest.Id.ToString();
            data["number_of-guests"] = Number_of_Guests.ToString();
            data["entry_date"] = Entry_Date.ToString("yyyy-MM-dd HH:mm:ss.fff");
            data["departure_date"] = Departure_Date.ToString("yyyy-MM-dd HH:mm:ss.fff"); 
           
            db.Insert(TableName, data);
            return true;
        }

        public bool Check()
        {
            if (Room.isEmpty == false)
            {
                MessageBox.Show("This room is not empty!");
                return false;
            }
            else if (Room.Room_Capacity < Number_of_Guests) {
                MessageBox.Show("Sorry, there is not enough space for " + Number_of_Guests + " people!");
                return false;
            }

            DataTable reservations = Room.GetReservations();
            foreach (DataRow row in reservations.Rows)
            {
                DateTime reserv_entry;
                DateTime.TryParse(row["entry_date"].ToString(), out reserv_entry);
                DateTime reserv_departure;
                DateTime.TryParse(row["departure_date"].ToString(), out reserv_departure);
                //These should be -1
                int entry_result_ent = Entry_Date.Date.CompareTo(reserv_entry.Date);
                int departure_result_ent = Departure_Date.Date.CompareTo(reserv_entry.Date);
                // OR

                //These should be 1
                int entry_result_dep = Entry_Date.Date.CompareTo(reserv_departure.Date);
                int departure_result_dep = Departure_Date.Date.CompareTo(reserv_departure.Date);

    
                if (!((entry_result_ent == -1 && departure_result_ent == -1) || (entry_result_dep == 1 && departure_result_dep == 1)))
                {
                   
                    MessageBox.Show("Sorry, room is not empty during these dates!");
                    return false;
                }


            }



            return true;
        }
    }
}
