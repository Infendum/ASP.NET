namespace HWLessonn2.Models
{
    public class Products
    {
        public Products(int Id, string Name, int Price, string Description)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Description = Description;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PathToImage { get; set; }
    }
}
