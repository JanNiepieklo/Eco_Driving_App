using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Eco_Driving_App
{
    public partial class Main_Form : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();
        string zalogowany;
        string model;
        public Main_Form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            try
            {
                command = new SqlCommand("SELECT TOP 1 * FROM Logowanie ORDER BY ID DESC", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        zalogowany = Convert.ToString(reader["Zalogowany"]);
                    }
                }

                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "'", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cbsamochod.Items.Add(Convert.ToString(reader["Model"]));
                    }
                }

                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model = Convert.ToString(reader["Model"]); ;
                    }
                }

                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            txtuzytkownik.Text = zalogowany;
            txtmodel.Text = model;
        }

        public string get_zalogowany()
        {
            return zalogowany;
        }
        public string get_model()
        {
            return model;
        }

        private void button_cars_Click(object sender, EventArgs e)
        {
            cars_form cars = new cars_form();
            cars.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            add_report_form report = new add_report_form();
            report.ShowDialog();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Exit();
        }

        private void cbsamochod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("UPDATE [Samochody] SET wybrany=@wybrany WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                command.Parameters.AddWithValue("@wybrany", "0");
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                command = new SqlCommand("UPDATE [Samochody] SET wybrany=@wybrany WHERE wlasciciel = '" + zalogowany + "' AND model = '" + cbsamochod.Text + "'", connect);
                command.Parameters.AddWithValue("@wybrany", "1");
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            try
            {
                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        model = Convert.ToString(reader["Model"]); ;
                    }
                }

                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            txtmodel.Text = model;
        }
    }
}
