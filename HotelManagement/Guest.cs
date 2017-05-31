using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    class Guest
    {

        public int Id;
        public string Name;
        public string Surname;
        public DateTime Birth_Date;
        public string Gender;
        public string Email;
        public string Phone;
        public Country Country;
        public City City;
        public string Street_Address;
        public string Zip_Code;
        public string Pasport_No;
        private static string TableName = "guests";
        private static Random rand = new Random();

        public Guest()
        {

        }
      
        public Guest Save()
        {
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
            
            data["name"] = Name;
            data["surname"] = Surname;
            data["email"] = Email;
            data["phone"] = Phone;
            data["birthDate"]= Birth_Date.ToString("yyyy-MM-dd");
            data["gender"] = Gender;
            data["country_id"] = Country.Id.ToString();
            data["city_id"] = City.Id.ToString();
            data["street_address"] = Street_Address;
            data["zip_code"] = Zip_Code;
            data["pasport_id"] = Pasport_No;

            db.Insert(TableName, data);

            //Solve this part more efficient way
            Database db_1 = new Database();
            DataTable dt = db_1.Read("SELECT MAX(id) FROM " + TableName);
            int id = Convert.ToInt32(dt.Rows[0][0].ToString());
            this.Id = id;
            return this ;

        }

        /*public bool Reserve(int room_id, int number_of_guests, DateTime entryDate, DateTime exitDate)
        {
            Room room = Room.GetById(room_id);

            if (number_of_guests > room.Room_Capacity)
            {
                MessageBox.Show("Sorry , there is not enough space for "+number_of_guests+"!");
                return false;
            }
            Database db = new Database();
            Dictionary<string, string> data = new Dictionary<string, string>();
          
            
            data["room_id"] = room_id.ToString();
            data["guest_id"] = Id.ToString();
            data["reservation_date"] = DateTime.Today.ToString("yyyy-MM-dd HH:mm:ss.fff"); 
            data["exit_date"] = exitDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            data["entry_date"] = entryDate.ToString("yyyy-MM-dd HH:mm:ss.fff"); 
            data["adult_number"] = adult_number.ToString();
            data["children_number"] = children_number.ToString();
            db.Insert("Reservation", data);

            
            room.Reserve();
            return true;
        }
        */

        public static Guest GetById(int id)
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from "+TableName+" WHERE id=" + id);
            //Fill guest info
            DataRow data = dt.Rows[0];
            Guest guest = new Guest();
            guest.Id = id;
            guest.Name = dt.Rows[0]["name"].ToString();
            return guest;
        }
    }
    
}
