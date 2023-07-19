using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lazerpay
{
    public partial class search_flight : Form
    {
        public search_flight()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(128, 129, 160, 252);
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string from, to, flight_type, leave_date, return_date; int persons;
                from = from_airport.Text;
                to = to_airport.Text;
                flight_type = flight_class.Text;
                persons = int.Parse(no_of_passengers.Text.Substring(0, 1));
                leave_date = leaving_on_entry.Text;
                return_date = returning_on_entry.Text;

                suitable_flights my_flight = new suitable_flights(from, to, flight_type, persons, leave_date, return_date);
                this.Hide();
                my_flight.ShowDialog();
                this.Close();
            }
        }

        private bool validate()
        {
            if (from_airport.Text == to_airport.Text) { return false; }
            return true;
        }
    }
}
