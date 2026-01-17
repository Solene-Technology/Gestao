using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Data
{
    public class DbConnection
    {
        private static string connectionString =
        "Server=localhost;Database=gestao;Uid=root;Pwd=Bedafama25;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
