using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement
{
    class Country
    {
        public int Id;
        public string Name;
        public static string TableName = "countries";

        public static DataTable GetAll()
        {
            Database db = new Database();
            System.Data.DataTable countries = db.Read("Select * from " + TableName);
            return countries;
        }

        public static Country GetById(int id)
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from " + TableName + " WHERE id=" + id);

            Country country = new HotelManagement.Country();
            var data = dt.Rows[0];
            country.Id = id;
            country.Name = data["name"].ToString();
           

            return country;
        }


    }
}
