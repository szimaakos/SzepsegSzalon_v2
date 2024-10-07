using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzepsegSzalon
{
    public class AdatbazisKezelo
    {
        private string kapcsolatString = "Server=localhost;Database=szepsegszalon;Username=root;Password=;";


        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(kapcsolatString);
        }

        public DataTable GetUgyfelek()
        {
            using (MySqlConnection kapcsolat = GetConnection())
            {
                kapcsolat.Open();
                string lekérdezes = "SELECT * FROM Ugyfel;";
                MySqlCommand parancs = new MySqlCommand(lekérdezes, kapcsolat);
                MySqlDataAdapter adapter = new MySqlDataAdapter(parancs);
                DataTable adatTabla = new DataTable();
                adapter.Fill(adatTabla);
                return adatTabla;
            }
        }
    }
}
