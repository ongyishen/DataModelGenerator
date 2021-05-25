namespace DataModelGenerator
{
    public class DBConfig
    {
        public string DbConnString { get; set; }
        public int DbType { get; set; }

        public DBConfig()
        {
            DbConnString = "Server=(local);Database=Northwind;Trusted_Connection=True;";
            DbType = 0;
        }
    }
}
