namespace TexnoMarket.Models
{
    public class ViewModel
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Rate { get; set; }
        public string Description { get; set; }
    }
    public class ProductForSingle
    {
        public string Title { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        //public List<ProductCharacteristic> Character { get; set; } 
        public double Rate { get; set; }
        public string Description { get; set; }
        //public List<UserAccounts> UserAccounts { get; set; }
    }
}
