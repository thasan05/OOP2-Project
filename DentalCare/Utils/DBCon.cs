using System.Data.SqlClient;
using System.Configuration;

namespace HealthCare_Plus.Utils
{
    class DBCon
    {
        private SqlConnection sqlCon =
            new SqlConnection(ConfigurationManager.ConnectionStrings[
                "HealthCare_Plus.Properties.Settings.HealthcareplusConnectionString"
            ].ConnectionString);

        public SqlConnection SqlConnection
        {
            get { return sqlCon; }
        }
    }
}
