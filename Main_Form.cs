using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eco_Driving_App
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        private void button_cars_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_reports_Click(object sender, EventArgs e)
        {
            add_report_form report = new add_report_form();
            report.ShowDialog();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }
        public string zalogowany()
        {
            return txtZalogowany.Text;
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Exit();
        }
    }
}
