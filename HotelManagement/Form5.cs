using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

      

        private void search_Click(object sender, EventArgs e)
        {
            rooms.DataSource = Room.Search(Convert.ToInt32(room_types.SelectedValue),Convert.ToInt32(number_of_people.Text), entry_date.Value.Date, departure_date.Value.Date);
            rooms.Refresh();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //Fill ComboBox: room_types
            this.room_types.DataSource = RoomType.GetAll();
            this.room_types.DisplayMember = "type";
            this.room_types.ValueMember = "id";
        }
    }
}
