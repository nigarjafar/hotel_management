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
    public partial class Form4 : Form
    {
        private Guest Guest;
        private Room Room;

        public Form4(int guest_id,int room_id)
        {
            this.Guest=Guest.GetById(guest_id);
            this.Room = Room.GetById(room_id);
            InitializeComponent();
            this.Load += Form4_Load;
        }
        public void Form4_Load(object sender, EventArgs e)
        {
           
           guest_textbox.Text = Guest.Name + " " + Guest.Surname;
           guest_textbox.ReadOnly = true;
           room_number_textbox.Text = Room.Id.ToString();
           room_number_textbox.ReadOnly = true;
            
        }
       

        private void reserve_Click_1(object sender, EventArgs e)
        {

            Reservation reservation = new Reservation();
            reservation.Guest = Guest;
            reservation.Room = Room;
            reservation.Number_of_Guests = Convert.ToInt32(number_of_guests.Text);
            reservation.Entry_Date = entry_date.Value.Date;
            reservation.Departure_Date = departure_date.Value.Date;
            
            bool check = reservation.Check();

            if (check)
            {
                MessageBox.Show("Reservation is saved successfully");
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
            
        }
    }
}
