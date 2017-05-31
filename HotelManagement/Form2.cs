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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        public void Form2_Load(object sender, EventArgs e)
        {
           InitializeRoomGridView();
            this.Width = 1200;
            this.Height = 600;
        }
        private void InitializeRoomGridView()
        {
                // Automatically generate the DataGridView columns.
                rooms_grid.AutoGenerateColumns = true;
                rooms_grid.Width = 1100;         
                rooms_grid.DataSource = Room.GetAll();

                // Automatically resize the visible rows.
                rooms_grid.AutoSizeRowsMode =
                    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

                // Set the DataGridView control's border.
                rooms_grid.BorderStyle = BorderStyle.Fixed3D;

                //Put the cells in edit mode
                rooms_grid.EditMode = DataGridViewEditMode.EditOnEnter;

                // Add delete button
                 this.addDataGridButton("Delete",this.rooms_grid);

                //Add reserve button
                this.addDataGridButton("Reserve", this.rooms_grid);
                
                //Add update button
                this.addDataGridButton("Update", this.rooms_grid);


                rooms_grid.CellClick += new DataGridViewCellEventHandler(rooms_grid_CellClick);

        }



        private void rooms_grid_CellClick(object sender, DataGridViewCellEventArgs e)

        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex <= 6) return;
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                MessageBox.Show(e.RowIndex.ToString());
                string value = rooms_grid[e.ColumnIndex, e.RowIndex].Value.ToString();
                int id = Convert.ToInt32(rooms_grid["id", e.RowIndex].Value);
                DataGridViewRow row = rooms_grid.Rows[e.RowIndex];
                switch (value)
                {
                    case "Delete":
                        DeleteRoom(id);
                        break;
                    case "Reserve":
                        ReserveRoom(id);
                        break;
                    case "Update":
                        UpdateRoom(row);
                        break;
                }

            }

       //     Update grid
            rooms_grid.DataSource = Room.GetAll();
            rooms_grid.Update();

        }

        private void DeleteRoom(int id)
        {
         
            Room room = new Room();
            room.Id = id;
            room.Delete();            
        }

        private void ReserveRoom(int id)
        {
            MessageBox.Show("reserve");
            Room room = Room.GetById(id);
            if (room.isEmpty)
            {
                Form form3 = new Form3(id);
                form3.Show();
            }
            else
            {
                MessageBox.Show("This room is not empty");
            }

        }

        private void UpdateRoom(DataGridViewRow row)
        {
           
            int id = Convert.ToInt32(row.Cells["id"].Value);
          
            Room room = Room.GetById(id);
            room.Room_Number= Convert.ToInt32(row.Cells["room_number"].Value);
            room.Room_Capacity= Convert.ToInt32(row.Cells["room_capacity"].Value);
            room.Price_Per_Day= Convert.ToInt32(row.Cells["price_per_day"].Value);
            room.Floor = Convert.ToInt32(row.Cells["floor"].Value);
            room.Room_Type=RoomType.GetById( Convert.ToInt32(row.Cells["room_type_id"].Value));
            room.isEmpty= Convert.ToBoolean(row.Cells["is_empty"].Value);
            room.Update();
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            //this.Hide();
        }

        private void addDataGridButton(string name, DataGridView datagrid)
        {
            var button = new DataGridViewButtonColumn();
            button.Text = name;
            button.UseColumnTextForButtonValue = true;
            datagrid.Columns.Add(button);
        }

        private void search_Click(object sender, EventArgs e)
        {
            Form form5 = new Form5();
            form5.Show();
        }
    }
}