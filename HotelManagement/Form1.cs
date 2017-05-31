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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }
        public void Form1_Load(object sender, EventArgs e)
        {
            //Fill ComboBox: room_types
            this.room_types.DataSource = RoomType.GetAll();
            this.room_types.DisplayMember = "type";
            this.room_types.ValueMember = "id";
           
        }


        private void room_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
            //Create new room
            Room room = new Room();
            room.Id = Convert.ToInt32(this.room_number.Text);
            room.Room_Capacity = Convert.ToInt32(this.room_capacity.Text);
            room.Room_Number = Convert.ToInt32(this.room_capacity.Text);
            room.Price_Per_Day = Convert.ToInt32(this.price_per_day.Text);
            room.Floor = Convert.ToInt32(this.floor.Text);
            room.Room_Type =RoomType.GetById( Convert.ToInt32(room_types.SelectedValue));
            room.Save();
            //Form2 form2 = new Form2();
           // form2.Show();
            this.Close();


        }

        private void back_form2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
            
        }

       
    }

}
