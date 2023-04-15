using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

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
        public DataTable gettabela(SqlCommand command)
        {
            command.Connection = connect;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }
        private void btnzaloguj_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text;
            string haslo = txthaslo.Text;
            DataTable table = gettabela(new SqlCommand("SELECT * FROM Uzytkownicy WHERE wlasciciel = '" + login + "' AND haslo = '" + haslo + "'"));
            if (table.Rows.Count > 0)
            {
                command = new SqlCommand("INSERT INTO [Logowanie](zalogowany)VALUES(@zalogowany)", connect);
                command.Parameters.AddWithValue("@zalogowany", txtlogin.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                Clear();
                Main_Form main = new Main_Form();
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Zły login lub hasło, spróbuj ponownie.");
            }
        }        
        public void Clear()
        {
            txtlogin.Clear();
            txthaslo.Clear();
        }
        private void btnzarejestruj_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy na pewno chcesz dodać nowego użytkownika?", "Dodawanie użytkownika", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (sprawdz_dane())
                    {
                        command = new SqlCommand("INSERT INTO [Uzytkownicy](wlasciciel,haslo)VALUES(@wlasciciel,@haslo)", connect);
                        command.Parameters.AddWithValue("@wlasciciel", txtlogin.Text);
                        command.Parameters.AddWithValue("@haslo", txthaslo.Text);
                        connect.Open();
                        command.ExecuteNonQuery();
                        connect.Close();
                        MessageBox.Show("Nowy użytkownik został pomyślnie zarejestrowany!");                        
                    }
                    Clear();
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
        private bool sprawdz_dane()
        {
            bool wynik = true;
            if (txtlogin.Text.Length > 30)
            {
                MessageBox.Show("Wprowadzony login musi być ograniczony do 30 znaków!");
                wynik = false;
                return wynik;
            }
            else if (txtlogin.Text.Length < 5)
            {
                MessageBox.Show("Wprowadzony login nie może być krótszy niż 5 znaków!");
                wynik = false;
                return wynik;
            }
            if (txthaslo.Text.Length > 30)
            {
                MessageBox.Show("Wprowadzone hasło musi być ograniczone do 30 znaków!");
                wynik = false;
                return wynik;
            }
            else if (txthaslo.Text.Length < 5)
            {
                MessageBox.Show("Wprowadzone hasło nie może być krótsze niż 5 znaków!");
                wynik = false;
                return wynik;
            }
            return wynik;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}

