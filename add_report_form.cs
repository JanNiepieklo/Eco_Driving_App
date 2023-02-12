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
                    command.Parameters.AddWithValue("@zatankowane", txtzatankowane.Text);
                    command.Parameters.AddWithValue("@zaplacone", txtzaplacone.Text);
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

        #region Method
        public void Clear()
        {
            txtprzebieg.Clear();
        }
        #endregion Method
    }
}
