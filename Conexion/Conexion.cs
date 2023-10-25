using System.Data.SqlClient;

namespace Portafolio_RLG.Conexion
{
    public class Conexion
    {
        private string cadenaSql = string.Empty;
        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                cadenaSql = builder.GetSection("ConnectionStrings:cadenaSql").Value;
        }
        public string getCadenaSql()
        {
            return cadenaSql;
        }
    }
}
