using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class ConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory()
        {
            // Coloca aquí tu cadena de conexión a SQL Server
            _connectionString = "Server=localhost;Database=PetMarketDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
