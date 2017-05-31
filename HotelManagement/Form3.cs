using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace HotelManagement
{
    public partial class Form3 : Form
    {
        private int Room_Id;
        public Form3(int room_number)
        {
            Room_Id = room_number;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Fill ComboBox: countries
            this.countries.DataSource = Country.GetAll();
            this.countries.DisplayMember = "name";
            this.countries.ValueMember = "id";

            //Fill ComboBox: gender
            gender.Items.Add("Female");
            gender.Items.Add("Male");
        }

        private void client_save_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest();
            guest.Name = name.Text;
            guest.Surname = surname.Text;
            guest.Phone = phone.Text;
            guest.Email = email.Text;
            guest.Birth_Date = birth_date.Value.Date;
            guest.Gender = gender.SelectedText;
            guest.Country = Country.GetById(Convert.ToInt32(countries.SelectedValue));
            guest.City = City.GetById(Convert.ToInt32(cities.SelectedValue));
            guest.Street_Address = street.Text;
            guest.Zip_Code = zip_code.Text;
            guest.Pasport_No = pasport_no.Text;


            guest=guest.Save();
          
            Form form4 = new Form4(guest.Id,Room_Id);
            form4.Show();
            this.Close();
        }

       

        private void countries_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            //fill combobox: cities
            this.cities.DataSource = City.GetByCountryId(Convert.ToInt32(countries.SelectedValue));
            this.cities.DisplayMember = "name";
            this.cities.ValueMember = "id";
            this.cities.Refresh();


        }


    }
}
