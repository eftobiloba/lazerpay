namespace Lazerpay
{
    partial class search_flight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_flight));
            this.panel2 = new System.Windows.Forms.Panel();
            this.submit_btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.returning_on_entry = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.to_airport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.leaving_on_entry = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.from_airport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flight_class = new System.Windows.Forms.ComboBox();
            this.no_of_passengers = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.submit_btn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.flight_class);
            this.panel2.Controls.Add(this.no_of_passengers);
            this.panel2.Location = new System.Drawing.Point(35, 159);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 286);
            this.panel2.TabIndex = 1;
            // 
            // submit_btn
            // 
            this.submit_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.ForeColor = System.Drawing.Color.White;
            this.submit_btn.Location = new System.Drawing.Point(549, 218);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(264, 43);
            this.submit_btn.TabIndex = 6;
            this.submit_btn.Text = "Let\'s go";
            this.submit_btn.UseVisualStyleBackColor = false;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.returning_on_entry);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(1027, 87);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 100);
            this.panel5.TabIndex = 5;
            // 
            // returning_on_entry
            // 
            this.returning_on_entry.Location = new System.Drawing.Point(13, 57);
            this.returning_on_entry.Name = "returning_on_entry";
            this.returning_on_entry.Size = new System.Drawing.Size(238, 22);
            this.returning_on_entry.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Returning on?";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.to_airport);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(363, 87);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(316, 100);
            this.panel4.TabIndex = 3;
            // 
            // to_airport
            // 
            this.to_airport.AutoCompleteCustomSource.AddRange(new string[] {
            "Murtala Muhammed International Airport, Lagos",
            "Nnamdi Azikwe International Airport, Abuja",
            "Ibadan International Airport",
            "Kaduna International Airport",
            "Akanu Ibiam International Airport, Enugu",
            "Port Harcourt International Airport"});
            this.to_airport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.to_airport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.to_airport.BackColor = System.Drawing.SystemColors.Control;
            this.to_airport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.to_airport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.to_airport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_airport.ForeColor = System.Drawing.Color.Black;
            this.to_airport.FormattingEnabled = true;
            this.to_airport.Items.AddRange(new object[] {
            "Murtala Muhammed International Airport, Lagos",
            "Nnamdi Azikwe International Airport, Abuja",
            "Ibadan International Airport",
            "Kaduna International Airport",
            "Akanu Ibiam International Airport, Enugu",
            "Port Harcourt International Airport"});
            this.to_airport.Location = new System.Drawing.Point(21, 52);
            this.to_airport.Margin = new System.Windows.Forms.Padding(4);
            this.to_airport.Name = "to_airport";
            this.to_airport.Size = new System.Drawing.Size(272, 28);
            this.to_airport.TabIndex = 8;
            this.to_airport.Text = "Akanu Ibiam International Airport, Enugu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "To where?";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.leaving_on_entry);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(713, 87);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 100);
            this.panel6.TabIndex = 4;
            // 
            // leaving_on_entry
            // 
            this.leaving_on_entry.Location = new System.Drawing.Point(18, 58);
            this.leaving_on_entry.Name = "leaving_on_entry";
            this.leaving_on_entry.Size = new System.Drawing.Size(249, 22);
            this.leaving_on_entry.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Leaving on?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.from_airport);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(14, 87);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(313, 100);
            this.panel3.TabIndex = 2;
            // 
            // from_airport
            // 
            this.from_airport.AutoCompleteCustomSource.AddRange(new string[] {
            "Murtala Muhammed International Airport, Lagos",
            "Nnamdi Azikwe International Airport, Abuja",
            "Ibadan International Airport",
            "Kaduna International Airport",
            "Akanu Ibiam International Airport, Enugu",
            "Port Harcourt International Airport"});
            this.from_airport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.from_airport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.from_airport.BackColor = System.Drawing.SystemColors.Control;
            this.from_airport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.from_airport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.from_airport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_airport.ForeColor = System.Drawing.Color.Black;
            this.from_airport.FormattingEnabled = true;
            this.from_airport.Items.AddRange(new object[] {
            "Murtala Muhammed International Airport, Lagos",
            "Nnamdi Azikwe International Airport, Abuja",
            "Ibadan International Airport",
            "Kaduna International Airport",
            "Akanu Ibiam International Airport, Enugu",
            "Port Harcourt International Airport"});
            this.from_airport.Location = new System.Drawing.Point(19, 52);
            this.from_airport.Margin = new System.Windows.Forms.Padding(4);
            this.from_airport.Name = "from_airport";
            this.from_airport.Size = new System.Drawing.Size(272, 28);
            this.from_airport.TabIndex = 7;
            this.from_airport.Text = "Murtala Muhammed International Airport, Lagos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "From where?";
            // 
            // flight_class
            // 
            this.flight_class.BackColor = System.Drawing.SystemColors.Control;
            this.flight_class.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flight_class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flight_class.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flight_class.ForeColor = System.Drawing.Color.Black;
            this.flight_class.FormattingEnabled = true;
            this.flight_class.Items.AddRange(new object[] {
            "Economy",
            "Business class",
            "Premium economy",
            "First class"});
            this.flight_class.Location = new System.Drawing.Point(243, 30);
            this.flight_class.Margin = new System.Windows.Forms.Padding(4);
            this.flight_class.Name = "flight_class";
            this.flight_class.Size = new System.Drawing.Size(203, 28);
            this.flight_class.TabIndex = 1;
            this.flight_class.Text = "Economy";
            // 
            // no_of_passengers
            // 
            this.no_of_passengers.BackColor = System.Drawing.SystemColors.Control;
            this.no_of_passengers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.no_of_passengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_of_passengers.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_passengers.ForeColor = System.Drawing.Color.Black;
            this.no_of_passengers.FormattingEnabled = true;
            this.no_of_passengers.Items.AddRange(new object[] {
            "1 Passenger",
            "2 Passengers",
            "3 Passenger",
            "4 Passengers"});
            this.no_of_passengers.Location = new System.Drawing.Point(18, 30);
            this.no_of_passengers.Margin = new System.Windows.Forms.Padding(4);
            this.no_of_passengers.Name = "no_of_passengers";
            this.no_of_passengers.Size = new System.Drawing.Size(198, 28);
            this.no_of_passengers.TabIndex = 0;
            this.no_of_passengers.Text = "1 Passenger";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.RoyalBlue;
            this.title.Location = new System.Drawing.Point(104, 107);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(507, 37);
            this.title.TabIndex = 2;
            this.title.Text = "Search and Book Flights in Nigeria";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lazerpay.Properties.Resources.plane_ticket;
            this.pictureBox1.Location = new System.Drawing.Point(35, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // search_flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1375, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "search_flight";
            this.Text = "Search and book Flights";
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox flight_class;
        private System.Windows.Forms.ComboBox no_of_passengers;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.ComboBox to_airport;
        private System.Windows.Forms.ComboBox from_airport;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker returning_on_entry;
        private System.Windows.Forms.DateTimePicker leaving_on_entry;
    }
}

