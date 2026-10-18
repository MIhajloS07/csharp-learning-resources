using System.Configuration;
namespace Koriscenje_izuzetaka_kod_parametrizovanih_upita
{
    internal class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["MihajloBaza"].ConnectionString;
            }
        }
    }
}
