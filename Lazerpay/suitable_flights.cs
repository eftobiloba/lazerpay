using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lazerpay
{
    public partial class suitable_flights : Form
    {
        string company, from_, to_;
        string id;
        string from_date;
        int child_no = 0;
        int luggage_no = 0;
        int window_seat = 0;
        int total_price = 0;
        int persons;
        public suitable_flights(string from, string to, string flight_type_, int persons_, string leave_date_, string return_date_)
        {
            InitializeComponent();
            from_date = leave_date_;
            string return_date = return_date_;
            from_ = from;
            to_ = to;
            string flight_type = flight_type_;
            persons = persons_;

            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=flights;";
            string query = "select * from all_flights where from_=@from_ and to_=@to_ and flight_type=@flight_type";
            MySqlConnection connection = new MySqlConnection(connectionstring);
            MySqlCommand command = new MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@from_", from_);
            command.Parameters.AddWithValue("@to_", to_);
            command.Parameters.AddWithValue("@flight_type", flight_type);

            connection.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Bind the DataTable to the DataGridView control
            dataGridView1.DataSource = dataTable;

            DataGridViewButtonColumn bookButton = new DataGridViewButtonColumn();
            bookButton.HeaderText = "Book";
            bookButton.Text = "Book";
            bookButton.UseColumnTextForButtonValue = true;
            //bookButton.DefaultCellStyle.BackColor = Color.Navy;
            //bookButton.DefaultCellStyle.ForeColor = Color.White;
            dataGridView1.Columns.Add(bookButton);

            connection.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            search_flight search_Flight = new search_flight();
            this.Hide();
            search_Flight.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is the "Book" button
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // Get the flight details from the row that was clicked
                string price = dataGridView1.Rows[e.RowIndex].Cells["price"].Value.ToString();
                company = dataGridView1.Rows[e.RowIndex].Cells["company"].Value.ToString();
                id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();

                total_price += int.Parse(price) * persons;
                price_label.Text = "$"+total_price.ToString();
            }
        }

        private void add_child_btn_Click(object sender, EventArgs e)
        {
            child_no += 1;
            total_price += 20;
            price_label.Text = "$" + total_price.ToString();
        }

        private void add_luggage_btn_Click(object sender, EventArgs e)
        {
            luggage_no += 1;
            total_price += 5;
            price_label.Text = "$" + total_price.ToString();
        }

        private void book_window_seat_Click(object sender, EventArgs e)
        {
            window_seat += 1;
            total_price += 10;
            price_label.Text = "$" + total_price.ToString();
        }

        private void checkout_btn_Click(object sender, EventArgs e)
        {
            checkout checkout_window = new checkout(total_price, child_no, luggage_no, company, id, window_seat, from_date, from_, to_, persons);
            this.Hide();
            checkout_window.ShowDialog();
            this.Close();
        }
    }
}
