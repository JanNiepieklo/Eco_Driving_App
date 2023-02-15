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

namespace Eco_Driving_App
{
    public partial class add_report_form : Form
    {
        SqlConnection connect = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SQL_connect sqlcon = new SQL_connect();
        SqlDataReader czytaj;
        public add_report_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
        }

        private void add_report_form_Load(object sender, EventArgs e)
        {

        }

        private void btndodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("na pewno?","Dodawanie raportu",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    command = new SqlCommand("INSERT INTO [Tankowanieee](zatankowane,zaplacone,przebieg,paliwo,data,dopelna,cena)VALUES(@zatankowane,@zaplacone,@przebieg,@paliwo,@data,@dopelna,@cena)", connect);
                    command.Parameters.AddWithValue("@zatankowane", Convert.ToDouble(txtzatankowane.Text));
                    command.Parameters.AddWithValue("@zaplacone", Convert.ToDouble(txtzaplacone.Text));
                    command.Parameters.AddWithValue("@przebieg", txtprzebieg.Text);
                    command.Parameters.AddWithValue("@paliwo", cbpaliwo.Text);
                    command.Parameters.AddWithValue("@data", dtdata.Value);
                    command.Parameters.AddWithValue("@dopelna", cbdopelna.Checked);
                    command.Parameters.AddWithValue("@cena", Convert.ToDouble(txtzaplacone.Text)/ (Convert.ToDouble(txtzatankowane.Text)));
                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("gitarson");
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

        }

        private void btnanuluj_Click(object sender, EventArgs e)
        {

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
            int i = 0;
            dgvraporty.Rows.Clear();
            command = new SqlCommand("SELECT * FROM Tankowanieee WHERE CONCAT(zatankowane,zaplacone,przebieg,paliwo,data,dopelna,cena) LIKE '%" + txtprzebieg.Text + "%'", connect);
            connect.Open();
            czytaj = command.ExecuteReader();
            while(czytaj.Read())
            {
                i++;
                dgvraporty.Rows.Add(i, czytaj[0].ToString(), czytaj[1].ToString(), czytaj[2].ToString(), czytaj[3].ToString(), czytaj[4].ToString(), czytaj[5].ToString(), czytaj[6].ToString());
            }
            czytaj.Close();
            connect.Close();
        }
    }
}
