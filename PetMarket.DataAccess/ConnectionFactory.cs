using Microsoft.Data.SqlClient;

namespace PetMarket.DataAccess
{
    public class ConnectionFactory
    {
        // Reemplaza 192.168.x.x con la IP de la laptop servidora
        private readonly string _connectionString =
            "Server=192.168.x.x,1433\\SQLEXPRESS02;Database=PetMarket;User Id=sa;Password=PetMarket123*;TrustServerCertificate=True;";

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}