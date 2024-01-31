namespace ProjectFinal.Domain.Entities
{
    public class ProductEntity : BaseEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public int CategoryId { get; set; }
    }
}