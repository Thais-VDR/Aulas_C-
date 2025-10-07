using MySqlConnector;

namespace aula_05
{
    //Responsavel pelos metodos de gerenciamento do banco de dados.
    public class AppDbContext: IDisposable
    {
       private readonly MySqlConnection _connection;
        public AppDbContext() {
            var connectionString = GetConnectionString();
            _connection = new MySqlConnection(connectionString);
        }

        private string GetConnectionString()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            IConfiguration configuration = builder.Build();
            return configuration.GetConnectionString("DefaultConnection");

        }

        public void OpenConnection() {

            if (_connection.State != System.Data.ConnectionState.Open) { 

              _connection.Open();
            }
        }
        public void CloseConnection() {
            if (_connection.State != System.Data.ConnectionState.Closed) {

               _connection.Close();
            }

        }

        public MySqlCommand CreateCommand()
        {
            return _connection.CreateCommand();
        }

        public void Dispose() { 
        
            CloseConnection();
            _connection.Dispose();
        }
    }
}
