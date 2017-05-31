using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelManagement
{
    class Room
    {
        public int Id;
        public int Room_Number;
        public int Price_Per_Day;
        public int Floor;
        public int Room_Capacity;
        public RoomType Room_Type;
        public bool isEmpty=true;
        private static string TableName="rooms";
        public Room()
        {

        }
        public Room(int id)
        {
            Id = id;
        }
        public Room Save()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["room_number"] = Room_Number.ToString();
            data["price_per_day"] = Price_Per_Day.ToString();
            data["room_capacity"] = Room_Capacity.ToString();
            data["floor"] = Floor.ToString();
            data["is_empty"] = isEmpty.ToString();
            data["room_type_id"] =Room_Type.Id.ToString();
            db.Insert(TableName, data);

            //Solve this part more efficient way
            Database db_1 = new Database();
            DataTable dt = db_1.Read("SELECT MAX(id) FROM " + TableName);
            int id = Convert.ToInt32(dt.Rows[0][0].ToString());
            return Room.GetById(id);
        }

        public static DataTable GetAll()
        {
            Database db = new Database();
            DataTable rooms = db.Read("Select * from " + TableName);
            return rooms;
        }

        public void Delete()
        {
            Database db = new Database();
            db.Delete(TableName,Id);
        }

        public void Update()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["room_number"] = Room_Number.ToString();
            data["price_per_day"] = Price_Per_Day.ToString();
            data["room_capacity"] = Room_Capacity.ToString();
            data["floor"] = Floor.ToString();
            data["is_empty"] = isEmpty.ToString();
            data["room_type_id"] = Room_Type.Id.ToString();
         
            Dictionary<string,string> where = new Dictionary<string, string>();
            where["id"] = Id.ToString();

            db.Update(TableName, data, where);
        }

        public void Reserve()
        {
    
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            data["is_empty"] = "0";
            Dictionary<string, string> where = new Dictionary<string, string>();
            where["id"] = Id.ToString();
            db.Update(TableName,data,where);

        }

        public static Room GetById(int id)
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from "+TableName+" WHERE id=" + id);

            Room room = new HotelManagement.Room();
            var data = dt.Rows[0];
            room.Id = id;
            room.Price_Per_Day = Convert.ToInt32(data["price_per_day"]);
            room.Room_Capacity = Convert.ToInt32(data["room_capacity"]);
            room.Room_Type = RoomType.GetById(Convert.ToInt32(data["room_type_id"]));
            room.isEmpty = Convert.ToBoolean(data["is_empty"]);

            return room;
        }

        public DataTable GetReservations()
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from " + Reservation.TableName + " WHERE room_id=" + Id);
          
            return dt;
        }

        public static DataTable Search(int room_type,int number_of_people, DateTime entryDate , DateTime departureDate)
        {
            MessageBox.Show("search");
            Database db = new Database();
            DataTable dt = db.Read("Select * from " + TableName + " WHERE room_capacity>=" + number_of_people+" AND room_type_id="+room_type);
         
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                Room room = new HotelManagement.Room(Convert.ToInt32(dt.Rows[i]["id"]));
                bool check = room.CheckForAvialibity(entryDate,departureDate);
                if (!check)
                {
                    dt.Rows[i].Delete();
                    MessageBox.Show(i.ToString());
                }

            }
            

            return dt;
        }

        public bool CheckForAvialibity(DateTime entry, DateTime departure)
        {
            DataTable reservations = this.GetReservations();
            foreach (DataRow row in reservations.Rows)
            {
                DateTime reserv_entry;
                DateTime.TryParse(row["entry_date"].ToString(), out reserv_entry);
                DateTime reserv_departure;
                DateTime.TryParse(row["departure_date"].ToString(), out reserv_departure);
                //These should be -1
                int entry_result_ent = entry.Date.CompareTo(reserv_entry.Date);
                int departure_result_ent = departure.Date.CompareTo(reserv_entry.Date);
                // OR

                //These should be 1
                int entry_result_dep = entry.Date.CompareTo(reserv_departure.Date);
                int departure_result_dep = departure.Date.CompareTo(reserv_departure.Date);


                if (!((entry_result_ent == -1 && departure_result_ent == -1) || (entry_result_dep == 1 && departure_result_dep == 1)))
                {

                   // MessageBox.Show("Sorry, room is not empty during these dates!");
                    return false;
                }

            }

            return true;
        }

    }
}
