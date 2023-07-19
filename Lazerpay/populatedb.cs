using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lazerpay
{
    public partial class populatedb : Form
    {
        public populatedb()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                string company, id, from_, to_, flight_type;
                int seats;

                company = company_entry.Text;
                id = id_entry.Text;
                from_ = from_entry.Text;
                to_ = to_entry.Text;
                flight_type = flight_type_entry.Text;
                seats = int.Parse(seats_entry.Text);

                string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=flights;";
                string query = "insert into current_flights values (@company, @id, @from_, @to_, @flight_type, @seats)";
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@company", company);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@from_", from_);
                cmd.Parameters.AddWithValue("@to_", to_);
                cmd.Parameters.AddWithValue("@flight_type", flight_type);
                cmd.Parameters.AddWithValue("@seats", seats);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0) {
                        MessageBox.Show("Added");
                    }
                    else { MessageBox.Show("Unsuccessful"); }

                    conn.Close();
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show("Could not validate"); }
        }

        private bool validate()
        {
            if (company_entry.Text.Trim() == String.Empty || id_entry.Text.Trim() == String.Empty ||
                from_entry.Text.Trim() == String.Empty || to_entry.Text.Trim() == String.Empty ||
                flight_type_entry.Text.Trim() == String.Empty || seats_entry.Text.Trim() == String.Empty) { return false; }
            return true;
        }
    }
}
