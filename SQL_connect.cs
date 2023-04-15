namespace Eco_Driving_App
{
    class SQL_connect
    {       
        private string conn;

        public string connection()
        {
            conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Janek\Documents\Studia\SGGW\Praca_dyplomowa\Eco_Driving_App\baza_eco_driving.mdf;Integrated Security=True";
            return conn;
        }
    }
}

//SqlConnection connect = new SqlConnection();
//SqlCommand command = new SqlCommand();
