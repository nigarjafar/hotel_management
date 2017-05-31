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
    class RoomType
    {
        public int Id;
        public string Type;
        private static string Table = "Room_type";
        

        public RoomType(int id, string type)
        {
            this.Id = id;
            this.Type = type;
        }
        public static DataTable GetAll()
        {
            Database db = new Database();
            DataTable room_types=db.Read("Select * from "+Table);
            return room_types;
        }

        public static RoomType GetById(int id)
        {
            Database db = new Database();
            DataTable dt = db.Read("Select * from "+Table+" WHERE id="+id);
            int obj_id =Convert.ToInt32( dt.Rows[0]["id"]);
            string obj_type = dt.Rows[0]["type"].ToString();
            RoomType room_type = new RoomType(obj_id, obj_type);
            return room_type;
        }


    }
}
