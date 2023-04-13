using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Driving_App
{
    public partial class statistics_form : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();
        string zalogowany;
        string model;
        Main_Form login = new Main_Form();
        public statistics_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            zalogowany = login.get_zalogowany();
            model = login.get_model();
            txtmodel.Text = model;
            odczyt_roku();
            cbrok.Text = (DateTime.Now.Year).ToString();
            pokaz_statystyki();
        }
        public void odczyt_roku()
        {
            try
            {
                double rok = DateTime.Now.Year;
                double rok2 = 0;
                command = new SqlCommand("SELECT TOP 1 YEAR(data) FROM Tankowanie ORDER BY DATA ASC", connect);
                connect.Open();
                SqlDataReader reader3 = command.ExecuteReader();

                if (reader3.HasRows)
                {
                    reader3.Read();
                    rok2 = Convert.ToDouble(reader3[0]);
                }
                reader3.Close();
                connect.Close();
                do
                {
                    cbrok.Items.Add(Convert.ToString(rok2));
                    rok2 += 1;
                } while (rok2 <= rok);                
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }

        }
        public void pokaz_statystyki()
        {
            try
            {
                double rok = Convert.ToDouble(cbrok.Text);
                double suma1 = 0;
                command = new SqlCommand("SELECT SUM(zaplacone) FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "'", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    suma1 = Convert.ToDouble(reader[0]);
                }
                reader.Close();
                connect.Close();
                suma1 = Convert.ToDouble(String.Format("{0:N2}", suma1));
                txtwydane1.Text = suma1.ToString();

                double suma2 = 0;
                command = new SqlCommand("SELECT SUM(zaplacone) FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND YEAR(data) = '" + rok + "'", connect);
                connect.Open();
                SqlDataReader reader2 = command.ExecuteReader();

                if (reader2.HasRows)
                {
                    reader2.Read();
                    suma2 = Convert.ToDouble(reader2[0]);
                }
                reader2.Close();
                connect.Close();
                suma2 = Convert.ToDouble(String.Format("{0:N2}", suma2));
                txtwydanewszystkie.Text = suma2.ToString();
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void cbrok_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokaz_statystyki();
        }
    }
}
