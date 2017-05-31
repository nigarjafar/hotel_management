namespace HotelManagement
{
    partial class Form2
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
            this.rooms_grid = new System.Windows.Forms.DataGridView();
            this.add_new = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rooms_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of rooms";
            // 
            // rooms_grid
            // 
            this.rooms_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rooms_grid.Location = new System.Drawing.Point(12, 56);
            this.rooms_grid.Name = "rooms_grid";
            this.rooms_grid.Size = new System.Drawing.Size(905, 353);
            this.rooms_grid.TabIndex = 2;
            // 
            // add_new
            // 
            this.add_new.Location = new System.Drawing.Point(27, 460);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(140, 36);
            this.add_new.TabIndex = 3;
            this.add_new.Text = "Add new room";
            this.add_new.UseVisualStyleBackColor = true;
            this.add_new.Click += new System.EventHandler(this.add_new_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(240, 460);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(140, 36);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 514);
            this.Controls.Add(this.search);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.rooms_grid);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.rooms_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView rooms_grid;
        private System.Windows.Forms.Button add_new;
        private System.Windows.Forms.Button search;
    }
}