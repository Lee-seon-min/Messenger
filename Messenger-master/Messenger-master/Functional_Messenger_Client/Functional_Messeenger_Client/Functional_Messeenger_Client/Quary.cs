using MySql.Data.MySqlClient;

namespace Functional_Messeenger_Client
{
    class Quary
    {
        static string URL = "server=***.***.***.***; database=***; user=***; password=***; port=***";
        public MySqlConnection connection = new MySqlConnection();
        public MySqlCommand command = new MySqlCommand();
        public MySqlDataReader reader = null;
        public MySqlDataReader other_reader = null;
        
        public Quary()
        {
            connection.ConnectionString = URL;
            command.Connection = connection;
        }
    }
}
