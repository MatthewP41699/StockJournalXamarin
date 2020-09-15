using SQLite;

namespace CrossPlat
{
    public class Stock
    {
        [PrimaryKey, AutoIncrement]
        public string Ticker { get; set; }
    }
}