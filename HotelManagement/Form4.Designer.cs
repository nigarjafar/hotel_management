namespace HotelManagement
{
    partial class Form4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.room_number_textbox = new System.Windows.Forms.TextBox();
            this.number_of_guests = new System.Windows.Forms.TextBox();
            this.guest_textbox = new System.Windows.Forms.TextBox();
            this.departure_date = new System.Windows.Forms.DateTimePicker();
            this.reserve = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.entry_date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(181, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guest";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of guests";
            // 
            // room_number_textbox
            // 
            this.room_number_textbox.Location = new System.Drawing.Point(199, 56);
            this.room_number_textbox.Name = "room_number_textbox";
            this.room_number_textbox.Size = new System.Drawing.Size(200, 20);
            this.room_number_textbox.TabIndex = 6;
            // 
            // number_of_guests
            // 
            this.number_of_guests.Location = new System.Drawing.Point(199, 137);
            this.number_of_guests.Name = "number_of_guests";
            this.number_of_guests.Size = new System.Drawing.Size(200, 20);
            this.number_of_guests.TabIndex = 8;
            // 
            // guest_textbox
            // 
            this.guest_textbox.Location = new System.Drawing.Point(199, 95);
            this.guest_textbox.Name = "guest_textbox";
            this.guest_textbox.Size = new System.Drawing.Size(200, 20);
            this.guest_textbox.TabIndex = 9;
            // 
            // departure_date
            // 
            this.departure_date.Location = new System.Drawing.Point(199, 240);
            this.departure_date.Name = "departure_date";
            this.departure_date.Size = new System.Drawing.Size(200, 20);
            this.departure_date.TabIndex = 10;
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(199, 285);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(75, 23);
            this.reserve.TabIndex = 11;
            this.reserve.Text = "Reserve";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Entry date";
            // 
            // entry_date
            // 
            this.entry_date.Location = new System.Drawing.Point(199, 208);
            this.entry_date.Name = "entry_date";
            this.entry_date.Size = new System.Drawing.Size(200, 20);
            this.entry_date.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 346);
            this.Controls.Add(this.entry_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.departure_date);
            this.Controls.Add(this.guest_textbox);
            this.Controls.Add(this.number_of_guests);
            this.Controls.Add(this.room_number_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox room_number_textbox;
        private System.Windows.Forms.TextBox number_of_guests;
        private System.Windows.Forms.TextBox guest_textbox;
        private System.Windows.Forms.DateTimePicker departure_date;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker entry_date;
    }
}