using System;
using System.Windows.Forms;
using System.IO;

namespace Lazerpay
{
    public partial class checkout : Form
    {
        int total_price, child_no, luggage_no, per_sons, window_seat;
        string company, id, date_leaving, from_, to_, time;

        public checkout(int total_price_, int child_no_, int luggage_no_, string company_, string id_, int window_seat_, string date_leaving_, string from__, string to__, int persons_)
        {
            InitializeComponent();
            Random random = new Random();
            total_price = total_price_; child_no = child_no_; luggage_no = luggage_no_; company = company_;
            id = id_; date_leaving = date_leaving_; window_seat = window_seat_; from_ = from__; to_ = to__;
            per_sons = persons_; time = $" {random.Next(0, 24)}:00";

            MessageBox.Show("An Email will be sent to you for confirmation.\nYour ticket will be saved in your Downloads folder");
            price_label.Text = "$" + total_price.ToString();
            child_label.Text = "Child(ren): " + child_no.ToString();
            luggage_label.Text = "Luggage(s): " + luggage_no.ToString();
            plane_name.Text = "Plane: " + company;
            plane_id.Text = "Plane ID: " + id;
            from_label.Text = "Departure Airport: \n" + from_;
            to_label.Text = "Arrival Airport: \n" + to_;
            date_entry.Text = "Departure: " + date_leaving + time;
            persons.Text = "Number of Persons: " + per_sons.ToString();
            window_seats.Text = "Window Seats: " + window_seat.ToString();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string fullname = full_name_entry.Text, email = email_entry.Text, phone_no = phone_no_entry.Text;
                StreamWriter writer;
                writer = File.CreateText($"C:/Users/OGUNDELE/Downloads/{fullname}_{id}_{company}.txt");
                writer.WriteLine($"Lazer Pay Plane Ticket for scheduled flight on {date_leaving} Time: {time}\nCheck your Email For Payment Process");
                writer.WriteLine("----------------------------------------------------------------------------------------");
                writer.WriteLine($"{fullname}\n{phone_no}\n{email}");
                writer.WriteLine("Total Cost: $" + total_price.ToString());
                writer.WriteLine("Child(ren): " + child_no.ToString());
                writer.WriteLine("Luggage(s): " + luggage_no.ToString());
                writer.WriteLine("Plane: " + company);
                writer.WriteLine("Plane ID: " + id);
                writer.WriteLine("Departure Airport: \n" + from_);
                writer.WriteLine("Arrival Airport: \n" + to_);
                writer.WriteLine("Number of Persons: " + per_sons.ToString());
                writer.WriteLine("Window Seats: " + window_seat.ToString());
                writer.WriteLine("----------------------------------------------------------------------------------------");
                writer.WriteLine("Thank you for using LazerPay Airline reservation. Have a wonderful trip!");
                writer.Close();
                MessageBox.Show("Thank you for using Lazer Pay Flight Reservation!\nCheck your downloads folder for your ticket!");
                search_flight search_Flight_window = new search_flight();
                this.Hide();
                search_Flight_window.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("None of the fields must be empty!"); }
        }
        private bool validate()
        {
            if (full_name_entry.Text.Trim() == String.Empty || email_entry.Text.Trim() == String.Empty || phone_no_entry.Text.Trim() == String.Empty)
                return false;
            return true;
        }
    }
}
