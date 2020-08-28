namespace dotnet_mongo.Models
{
    public class Address
    {
        public string country { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public string neighborhood { get; set; }
        public string street { get; set; }
        public int street_number { get; set; }
        public int zipcode { get; set; }
    }
}