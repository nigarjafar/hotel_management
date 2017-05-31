namespace HotelManagement
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.entry_date = new System.Windows.Forms.DateTimePicker();
            this.departure_date = new System.Windows.Forms.DateTimePicker();
            this.number_of_people = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.room_types = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Room";
            // 
            // entry_date
            // 
            this.entry_date.Location = new System.Drawing.Point(351, 98);
            this.entry_date.Name = "entry_date";
            this.entry_date.Size = new System.Drawing.Size(200, 20);
            this.entry_date.TabIndex = 1;
            // 
            // departure_date
            // 
            this.departure_date.Location = new System.Drawing.Point(606, 98);
            this.departure_date.Name = "departure_date";
            this.departure_date.Size = new System.Drawing.Size(200, 20);
            this.departure_date.TabIndex = 2;
            // 
            // number_of_people
            // 
            this.number_of_people.Location = new System.Drawing.Point(189, 101);
            this.number_of_people.Name = "number_of_people";
            this.number_of_people.Size = new System.Drawing.Size(100, 20);
            this.number_of_people.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of guests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(348, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Entry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(603, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Departure Date";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(731, 152);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 9;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // rooms
            // 
            this.rooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms.Location = new System.Drawing.Point(12, 244);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(823, 238);
            this.rooms.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // room_types
            // 
            this.room_types.FormattingEnabled = true;
            this.room_types.Location = new System.Drawing.Point(15, 96);
            this.room_types.Name = "room_types";
            this.room_types.Size = new System.Drawing.Size(121, 21);
            this.room_types.TabIndex = 12;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 515);
            this.Controls.Add(this.room_types);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.number_of_people);
            this.Controls.Add(this.departure_date);
            this.Controls.Add(this.entry_date);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker entry_date;
        private System.Windows.Forms.DateTimePicker departure_date;
        private System.Windows.Forms.TextBox number_of_people;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridView rooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox room_types;
    }
}