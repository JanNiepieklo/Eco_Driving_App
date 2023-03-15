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
        SqlCommand command1 = new SqlCommand();
        SqlCommand command2 = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();

        public add_report_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            pokazraport();
        }
        private void add_report_form_Load(object sender, EventArgs e)
        {

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            login_form login2 = new login_form();
            try
            {
                if(MessageBox.Show("Czy na pewno chcesz dodać nowy raport?","Dodawanie raportu",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    string zalogowany = " ";
                    double przejechane = 0;
                    try
                    {
                        command1 = new SqlCommand("SELECT TOP 1 * FROM Logowanie ORDER BY ID DESC", connect);
                        connect.Open();
                        SqlDataReader reader = command1.ExecuteReader();

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
                        command2 = new SqlCommand("SELECT TOP 1 * FROM Tankowanie ORDER BY ID DESC", connect);
                        connect.Open();
                        SqlDataReader reader2 = command2.ExecuteReader();

                        if (reader2.HasRows)
                        {
                            while (reader2.Read())
                            {
                                przejechane = Convert.ToDouble(reader2["Przebieg"]);
                            }
                        }

                        reader2.Close();
                        connect.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                    command = new SqlCommand("INSERT INTO [Tankowanie](wlasciciel,zatankowane,zaplacone,przebieg,paliwo,data,dopelna,cena,przejechane,spalanie)VALUES(@wlasciciel,@zatankowane,@zaplacone,@przebieg,@paliwo,@data,@dopelna,@cena,@przejechane,@spalanie)", connect);
                    command.Parameters.AddWithValue("@wlasciciel", zalogowany);
                    command.Parameters.AddWithValue("@zatankowane", Convert.ToDouble(txtzatankowane.Text));
                    command.Parameters.AddWithValue("@zaplacone", Convert.ToDouble(txtzaplacone.Text));
                    command.Parameters.AddWithValue("@przebieg", txtprzebieg.Text);
                    command.Parameters.AddWithValue("@paliwo", cbpaliwo.Text);
                    command.Parameters.AddWithValue("@data", dtdata.Value);
                    command.Parameters.AddWithValue("@dopelna", cbdopelna.Checked);
                    command.Parameters.AddWithValue("@cena", Convert.ToDouble(txtzaplacone.Text)/ (Convert.ToDouble(txtzatankowane.Text)));
                    command.Parameters.AddWithValue("@przejechane", Convert.ToDouble(txtprzebieg.Text)-przejechane);
                    command.Parameters.AddWithValue("@spalanie", 100*Convert.ToDouble(txtzatankowane.Text)/(Convert.ToDouble(txtprzebieg.Text) - przejechane));
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
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        private void btnwyczysc_Click(object sender, EventArgs e)
        {
            txtzatankowane.Clear();
            txtzaplacone.Clear();
            txtprzebieg.Clear();
            txtprzebieg.Clear();
            cbpaliwo.SelectedIndex = 0;
            dtdata.Value = DateTime.Now;
            cbdopelna.Checked = false;
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
            txtprzebieg.Clear();
            cbpaliwo.SelectedIndex = 0;
            dtdata.Value = DateTime.Now;
            cbdopelna.Checked = false;
        }
        public void pokazraport()
        {
            dgvraporty.DataSource = getraporty();
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn = (DataGridViewTextBoxColumn)dgvraporty.Columns[1];
        }
        public DataTable getraporty()
        {
            SqlCommand command2 = new SqlCommand("SELECT TOP 20 * FROM Tankowanie ORDER BY Przebieg DESC", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }

        private void dgvraporty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_czyszczenie_Click(object sender, EventArgs e)
        {
            command = new SqlCommand("DELETE FROM Uzytkownicy", connect);
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
