namespace ProjectFinal.Domain.Entities
{
    public class CategoryEntity : BaseEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
