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
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;

namespace Eco_Driving_App
{
    public partial class login_form : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();
        public login_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnzaloguj_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text;
            string haslo = txthaslo.Text;
            DataTable table = gettabela(new SqlCommand("SELECT * FROM Uzytkownicy WHERE wlasciciel = '" + login + "' AND haslo = '" + haslo + "'"));
            if (table.Rows.Count > 0)
            {
                Main_Form main = new Main_Form();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("gosciu zle haslo ERROR ERROR");
            }
        }
        public DataTable gettabela(SqlCommand command)
        {
            command.Connection = connect;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }
        public void Clear()
        {
            txtlogin.Clear();
            txthaslo.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("na pewno?", "Dodawanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO [Uzytkownicy](wlasciciel,haslo)VALUES(@wlasciciel,@haslo)", connect);
                    command.Parameters.AddWithValue("@wlasciciel", txtlogin.Text);
                    command.Parameters.AddWithValue("@haslo", txthaslo.Text);
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("gitarson");
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}

