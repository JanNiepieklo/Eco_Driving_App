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
                command = new SqlCommand("SELECT TOP 1 YEAR(data) FROM Tankowanie ORDER BY data ASC", connect);
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
                double przejechane = 0;
                double przebiegmin = 0;
                double przebiegmax = 0;
                double zatankowane = 0;
                double zatankowane1 = 0;
                double spalanie = 0;
                double koszt1 = 0;
                double koszt2 = 0;
                double koszt = 0;
                double koszt1r = 0;

                command = new SqlCommand("SELECT SUM(zaplacone), SUM(zatankowane) FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "'", connect);
                connect.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    koszt1 = Convert.ToDouble(reader[0]);
                    zatankowane = Convert.ToDouble(reader[1]);
                }
                reader.Close();
                connect.Close();
                txtwydane1.Text = String.Format("{0:N2}", koszt1);

                command = new SqlCommand("SELECT SUM(zaplacone) FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND YEAR(data) = '" + rok + "'", connect);
                connect.Open();
                SqlDataReader reader2 = command.ExecuteReader();

                if (reader2.HasRows)
                {
                    reader2.Read();
                    koszt2 = Convert.ToDouble(reader2[0]);
                }
                reader2.Close();
                connect.Close();
                txtwydanewszystkie.Text = String.Format("{0:N2}", koszt2);


                command = new SqlCommand("SELECT TOP 1 przebieg, zatankowane, zaplacone FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "' ORDER BY przebieg ASC", connect);
                connect.Open();
                SqlDataReader reader3 = command.ExecuteReader();

                if (reader3.HasRows)
                {
                    reader3.Read();
                    przebiegmin = Convert.ToDouble(reader3[0]);
                    zatankowane1 = Convert.ToDouble(reader3[1]);
                    koszt1r = Convert.ToDouble(reader3[2]);
                }
                reader3.Close();
                connect.Close();

                command = new SqlCommand("SELECT TOP 1 przebieg FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "' ORDER BY przebieg DESC", connect);
                connect.Open();
                SqlDataReader reader4 = command.ExecuteReader();

                if (reader4.HasRows)
                {
                    reader4.Read();
                    przebiegmax = Convert.ToDouble(reader4[0]);
                }
                reader4.Close();
                connect.Close();

                przejechane = przebiegmax - przebiegmin;
                spalanie = 100 * (zatankowane - zatankowane1) / przejechane;
                txtspalanie.Text = String.Format("{0:N2}", spalanie);
                koszt = 100 * (koszt1 - koszt1r) / przejechane;
                txtkoszt.Text = String.Format("{0:N2}", koszt);

                //command = new SqlCommand("SELECT SUM(zatankowane) FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "'", connect);
                //connect.Open();
                //SqlDataReader reader5 = command.ExecuteReader();

                //if (reader5.HasRows)
                //{
                //    reader5.Read();
                //    zatankowane = Convert.ToDouble(reader5[0]);
                //}
                //reader5.Close();
                //connect.Close();

                //command = new SqlCommand("SELECT TOP 1 zatankowane, zaplacone  FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' AND YEAR(data) = '" + rok + "' ORDER BY przebieg ASC", connect);
                //connect.Open();
                //SqlDataReader reader6 = command.ExecuteReader();

                //if (reader6.HasRows)
                //{
                //    reader6.Read();
                //    zatankowane1 = Convert.ToDouble(reader6[0]);
                //    koszt1r = Convert.ToDouble(reader6[1]);
                //}
                //reader6.Close();
                //connect.Close();


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
