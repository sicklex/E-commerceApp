
namespace EcommerceDomain.Entities
{
    public record Products : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
        public int Quantities { get; set; }
        public Category Category { get; set; }



    }
}
