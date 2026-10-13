namespace DealershipInventory.Api.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } = "";
        public string Model { get; set; } = "";
        public int Year { get; set; }
        public string Vin { get; set; } = "";
        public int Mileage { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal AskingPrice { get; set; }
    }
}