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

namespace Komplex
{
    public partial class frmmain : Form
    {


        private static void OpenSqlConnection()
        {
            string connectionString = GetConnectionString();
            string queryString = "SELECT * FROM szemely";
            


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
            }

        }
        static private string GetConnectionString()
        {
            string host = "(localdb)\\MSSQLLocalDB";
            string user = "VEREBELY\\Vizsga006";
            string password = "";


            return "server=" + host
                + "user=" + user
                + "password=" + password;
        }

        public frmmain()
        {
            
        }


        private void frmmain_Load(object sender, EventArgs e)
        {
            //dgv_szemelyek.Sort(, ListSortDirection.Descending;
        }
    }
}
