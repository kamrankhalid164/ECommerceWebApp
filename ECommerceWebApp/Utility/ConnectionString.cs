namespace ECommerceWebApp.Utility
{
    public class ConnectionString
    {
        private static string Conn = "Data Source=.; Initial Catalog=StudentManagement;Trusted_Connection=True";
        public static string ConnString
        {
            get => Conn;
        }
    }
}
