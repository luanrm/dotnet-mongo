namespace dotnet_mongo
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string Billing { get; set; }
        public string Customer { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
    public interface IDatabaseSettings
    {
        string Billing { get; set; }
        string Customer { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}