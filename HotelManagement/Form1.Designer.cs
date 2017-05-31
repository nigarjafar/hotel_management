namespace HotelManagement
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.room_number = new System.Windows.Forms.TextBox();
            this.room_capacity = new System.Windows.Forms.TextBox();
            this.price_per_day = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.room_types = new System.Windows.Forms.ComboBox();
            this.room_save = new System.Windows.Forms.Button();
            this.back_form2 = new System.Windows.Forms.Button();
            this.floor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(131, 32);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter new room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Capacity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Room number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price per day";
            // 
            // room_number
            // 
            this.room_number.Location = new System.Drawing.Point(257, 118);
            this.room_number.Name = "room_number";
            this.room_number.Size = new System.Drawing.Size(121, 20);
            this.room_number.TabIndex = 7;
            // 
            // room_capacity
            // 
            this.room_capacity.Location = new System.Drawing.Point(257, 153);
            this.room_capacity.Name = "room_capacity";
            this.room_capacity.Size = new System.Drawing.Size(121, 20);
            this.room_capacity.TabIndex = 8;
            // 
            // price_per_day
            // 
            this.price_per_day.Location = new System.Drawing.Point(257, 187);
            this.price_per_day.Name = "price_per_day";
            this.price_per_day.Size = new System.Drawing.Size(121, 20);
            this.price_per_day.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Room type";
            // 
            // room_types
            // 
            this.room_types.FormattingEnabled = true;
            this.room_types.Location = new System.Drawing.Point(257, 220);
            this.room_types.Name = "room_types";
            this.room_types.Size = new System.Drawing.Size(121, 21);
            this.room_types.TabIndex = 13;
            // 
            // room_save
            // 
            this.room_save.Location = new System.Drawing.Point(257, 311);
            this.room_save.Name = "room_save";
            this.room_save.Size = new System.Drawing.Size(121, 21);
            this.room_save.TabIndex = 14;
            this.room_save.Text = "Save";
            this.room_save.UseVisualStyleBackColor = true;
            this.room_save.Click += new System.EventHandler(this.room_save_Click);
            // 
            // back_form2
            // 
            this.back_form2.Location = new System.Drawing.Point(25, 428);
            this.back_form2.Name = "back_form2";
            this.back_form2.Size = new System.Drawing.Size(75, 23);
            this.back_form2.TabIndex = 15;
            this.back_form2.Text = "Back";
            this.back_form2.UseVisualStyleBackColor = true;
            this.back_form2.Click += new System.EventHandler(this.back_form2_Click);
            // 
            // floor
            // 
            this.floor.Location = new System.Drawing.Point(257, 252);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(121, 20);
            this.floor.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Floor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.back_form2);
            this.Controls.Add(this.room_save);
            this.Controls.Add(this.room_types);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.price_per_day);
            this.Controls.Add(this.room_capacity);
            this.Controls.Add(this.room_number);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox room_number;
        private System.Windows.Forms.TextBox room_capacity;
        private System.Windows.Forms.TextBox price_per_day;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox room_types;
        private System.Windows.Forms.Button room_save;
        private System.Windows.Forms.Button back_form2;
        private System.Windows.Forms.TextBox floor;
        private System.Windows.Forms.Label label3;
    }
}

