using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Input;

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
            odczyt_z_bazy();
            sprawdz_tabele();
        }
        public void odczyt_z_bazy()
        {
            try
            {
                command = new SqlCommand("SELECT TOP 1 * FROM Logowanie ORDER BY ID DESC", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    zalogowany = Convert.ToString(reader["Zalogowany"]);
                }
                reader.Close();
                connect.Close();

                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "'", connect);
                connect.Open();
                SqlDataReader reader2 = command.ExecuteReader();

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        cbsamochod.Items.Add(Convert.ToString(reader2["Model"]));
                    }
                }
                reader2.Close();
                connect.Close();

                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                connect.Open();
                SqlDataReader reader3 = command.ExecuteReader();

                if (reader3.HasRows)
                {
                    reader3.Read();
                    model = Convert.ToString(reader3["Model"]);
                }
                reader3.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                connect.Close();
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
        private void button_reports_Click(object sender, EventArgs e)
        {
            add_report_form report = new add_report_form();
            report.ShowDialog();
        }
        private void button_statistics_Click(object sender, EventArgs e)
        {
            statistics_form statistics = new statistics_form();
            statistics.ShowDialog();
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }
        private void cbsamochod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("UPDATE [Samochody] SET wybrany = 0 WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();

                command = new SqlCommand("UPDATE [Samochody] SET wybrany = 1 WHERE wlasciciel = '" + zalogowany + "' AND model = '" + cbsamochod.Text + "'", connect);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();

                command = new SqlCommand("SELECT * FROM Samochody WHERE wlasciciel = '" + zalogowany + "' AND wybrany = 1", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    model = Convert.ToString(reader["Model"]); ;
                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
            txtmodel.Text = model;
            sprawdz_tabele();
        }
        public void sprawdz_tabele()
        {
            try
            {
                double czypusta = 0;
                command = new SqlCommand("SELECT CASE WHEN EXISTS(SELECT 1 FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "') THEN 0 ELSE 1 END AS IsEmpty", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    czypusta = Convert.ToDouble(reader[0]);
                }
                reader.Close();
                connect.Close();
                if (czypusta == 1)
                {
                    button_statistics.Enabled = false;
                }
                else
                {
                    button_statistics.Enabled = true;
                }
                if (cbsamochod.SelectedIndex == -1)
                {
                    button_reports.Enabled = false;
                }
                else
                {
                    button_reports.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
