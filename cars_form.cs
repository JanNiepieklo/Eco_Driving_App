using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Eco_Driving_App
{
    public partial class cars_form : Form
    {
        SqlConnection connect = new SqlConnection();
        SQL_connect sqlcon = new SQL_connect();
        SqlCommand command = new SqlCommand();
        Main_Form login = new Main_Form();
        public cars_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            pokazraport();
        }
        public DataTable getraporty()
        {

            string zalogowany = login.get_zalogowany();
            SqlCommand command = new SqlCommand("SELECT TOP 20 marka, model, paliwo, pojemnosc, moc, rok_prod FROM Samochody WHERE wlasciciel = '" + zalogowany + "'", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }
        public void pokazraport()
        {
            dgvsamochody.DataSource = getraporty();
            dgvsamochody.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnanuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Clear()
        {
            txtmarka.Clear();
            txtmodel.Clear();
            cbpaliwo.SelectedIndex = -1;
            txtpojemnosc.Clear();
            txtmoc.Clear();
            txtrok.Clear();
        }
        private void btnwyczysc_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno chcesz dodać nowy samochód?", "Dodawanie samochodu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sprawdz_dane())
                    {
                        string zalogowany = login.get_zalogowany();
                        command = new SqlCommand("INSERT INTO [Samochody](wlasciciel,marka,model,paliwo,pojemnosc,moc,rok_prod,wybrany)VALUES(@wlasciciel,@marka,@model,@paliwo,@pojemnosc,@moc,@rok_prod,@wybrany)", connect);
                        command.Parameters.AddWithValue("@wlasciciel", zalogowany);
                        command.Parameters.AddWithValue("@marka", (txtmarka.Text));
                        command.Parameters.AddWithValue("@model", txtmodel.Text);
                        command.Parameters.AddWithValue("@paliwo", cbpaliwo.Text);
                        command.Parameters.AddWithValue("@pojemnosc", Convert.ToDouble(txtpojemnosc.Text));
                        command.Parameters.AddWithValue("@moc", txtmoc.Text);
                        command.Parameters.AddWithValue("@rok_prod", txtrok.Text);
                        command.Parameters.AddWithValue("@wybrany", "0");
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Samochód został pomyślnie dodany!");
                        Clear();
                        pokazraport();
                    }
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private bool sprawdz_dane()
        {
            bool wynik = true;
            if (txtmarka.Text.Length > 30)
            {
                MessageBox.Show("Wprowadzona marka samochodu musi być ograniczona do 30 znaków!");
                wynik = false;
                return wynik;
            }
            if (txtmodel.Text.Length > 30)
            {
                MessageBox.Show("Wprowadzony model samochodu musi być ograniczony do 30 znaków!");
                wynik = false;
                return wynik;
            }
            double dpojemnosc;
            if (Double.TryParse(txtpojemnosc.Text, out dpojemnosc))
            {
                if (dpojemnosc < 0 || dpojemnosc > 100)
                {
                    MessageBox.Show("Wprowadź poprawną pojemność silnika w litrach!");
                    wynik = false;
                    return wynik;
                }
            }
            else
            {
                MessageBox.Show("Pojemność silnika musi być liczbą!");
                wynik = false;
                return wynik;
            }
            double dmoc;
            if (Double.TryParse(txtmoc.Text, out dmoc))
            {
                if (dmoc < 0 || dmoc > 3000)
                {
                    MessageBox.Show("Wprowadź poprawną moc silnika w koniach mechanicznych!");
                    wynik = false;
                    return wynik;
                }
            }
            else
            {
                MessageBox.Show("Moc silnika musi być liczbą!");
                wynik = false;
                return wynik;
            }
            double drok;
            if (Double.TryParse(txtrok.Text, out drok))
            {
                if (drok < 1900 || drok > 2200)
                {
                    MessageBox.Show("Wprowadź poprawny rok produkcji samochodu!");
                    wynik = false;
                    return wynik;
                }
            }
            else
            {
                MessageBox.Show("Rok produkcji musi być liczbą!");
                wynik = false;
                return wynik;
            }
            return wynik;
        }
        private void txtzaplacone_TextChanged(object sender, EventArgs e)
        {

        }
        private void cars_form_Load(object sender, EventArgs e)
        {

        }
    }    
}
