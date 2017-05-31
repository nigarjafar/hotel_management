using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    class City
    {
        public int Id;
        public string Name;
        public Country Country;
        public static string TableName = "cities";

        public static DataTable GetByCountryId(int country_id)
        {
            Database db = new Database();
            DataTable cities = db.Read("Select * from " + TableName+" WHERE country_id="+country_id);
                 
            return cities;
        }

        public static City GetById(int id)
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from " + TableName + " WHERE id=" + id);

            City city = new HotelManagement.City();
            var data = dt.Rows[0];
            city.Id = id;
            city.Name = data["name"].ToString();
            city.Country = Country.GetById(Convert.ToInt32(data["country_id"]));


            return city;
        }
    }
}
