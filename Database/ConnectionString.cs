namespace Database
{
    public static class ConnectionString
    {
        private static string connection = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DbSVE;Data Source=ZEUS";

        public static string Connection { get => connection; } 
    }
}
