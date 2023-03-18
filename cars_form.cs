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
        public cars_form()
        {
            InitializeComponent();
            connect = new SqlConnection(sqlcon.connection());
            pokazraport();
        }

        private void cars_form_Load(object sender, EventArgs e)
        {

        }
        public void pokazraport()
        {
            dgvsamochody.DataSource = getraporty();
            DataGridViewTextBoxColumn textColumn = new DataGridViewTextBoxColumn();
            textColumn = (DataGridViewTextBoxColumn)dgvsamochody.Columns[1];
        }
        public DataTable getraporty()
        {
            SqlCommand command = new SqlCommand("SELECT TOP 20 * FROM Samochody", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tabela = new DataTable();
            adapter.Fill(tabela);
            return tabela;
        }

        private void btnanuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void Clear()
        {
            //txtzatankowane.Clear();
            //txtzaplacone.Clear();
            //txtprzebieg.Clear();
            //txtprzebieg.Clear();
            //cbpaliwo.SelectedIndex = 0;
            //dtdata.Value = DateTime.Now;
            //cbdopelna.Checked = false;
        }

        private void btnwyczysc_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
