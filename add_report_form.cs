using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace Eco_Driving_App
{
    public partial class add_report_form : Form
    {        
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();
        Main_Form login = new Main_Form();

        public add_report_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            pokazraport();
        }
        public DataTable getraporty()
        {
            string zalogowany = login.get_zalogowany();
            string model = login.get_model();
            command = new SqlCommand("SELECT TOP 20 zatankowane, zaplacone, przebieg, paliwo, data, cena, przejechane, spalanie FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' ORDER BY przebieg DESC", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }
        public void pokazraport()
        {
            dgvraporty.DataSource = getraporty();
            dgvraporty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btnanuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void Clear()
        {
            txtzatankowane.Clear();
            txtzaplacone.Clear();
            txtprzebieg.Clear();
            cbpaliwo.SelectedIndex = -1;
            dtdata.Value = DateTime.Now;
            cbdopelna.Checked = false;
        }
        private void btnwyczysc_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void btndodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Czy na pewno chcesz dodać nowy raport?","Dodawanie raportu",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    string zalogowany = login.get_zalogowany();
                    string model = login.get_model();
                    double przejechane = 0;                    
                    try
                    {
                        command = new SqlCommand("SELECT TOP 1 * FROM Tankowanie WHERE wlasciciel = '" + zalogowany + "' AND marka = '" + model + "' ORDER BY ID DESC", connect);
                        connect.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                przejechane = Convert.ToDouble(reader["przebieg"]);
                            }
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
                    command = new SqlCommand("INSERT INTO [Tankowanie](wlasciciel,marka,zatankowane,zaplacone,przebieg,paliwo,data,dopelna,cena,przejechane,spalanie)VALUES(@wlasciciel,@marka,@zatankowane,@zaplacone,@przebieg,@paliwo,@data,@dopelna,@cena,@przejechane,@spalanie)", connect);
                    command.Parameters.AddWithValue("@wlasciciel", zalogowany);
                    command.Parameters.AddWithValue("@marka", model);
                    command.Parameters.AddWithValue("@zatankowane", Convert.ToDouble(txtzatankowane.Text));
                    command.Parameters.AddWithValue("@zaplacone", Convert.ToDouble(txtzaplacone.Text));
                    command.Parameters.AddWithValue("@przebieg", txtprzebieg.Text);
                    command.Parameters.AddWithValue("@paliwo", cbpaliwo.Text);
                    command.Parameters.AddWithValue("@data", dtdata.Value);
                    command.Parameters.AddWithValue("@dopelna", cbdopelna.Checked);
                    command.Parameters.AddWithValue("@cena", Convert.ToDouble(String.Format("{0:N2}", (Convert.ToDouble(txtzaplacone.Text)/ (Convert.ToDouble(txtzatankowane.Text))))));
                    if ((Convert.ToDouble(txtprzebieg.Text) - przejechane) > 30000)
                    {
                        command.Parameters.AddWithValue("@przejechane", 0);
                        command.Parameters.AddWithValue("@spalanie", 0);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@przejechane", Convert.ToDouble(txtprzebieg.Text) - przejechane);
                        command.Parameters.AddWithValue("@spalanie", Convert.ToDouble(String.Format("{0:N2}", (100 * Convert.ToDouble(txtzatankowane.Text) / (Convert.ToDouble(txtprzebieg.Text) - przejechane)))));
                    }
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Raport został pomyślnie wprowadzony!");
                    Clear();
                    pokazraport();
                }
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btn_czyszczenie_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM Tankowanie WHERE marka = 'Civic'", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
        private void dgvraporty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void add_report_form_Load(object sender, EventArgs e)
        {

        }
    }
}
