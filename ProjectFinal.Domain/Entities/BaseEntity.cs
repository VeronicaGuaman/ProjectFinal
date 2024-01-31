namespace ProjectFinal.Domain.Entities
{
    public class BaseEntity
    {
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public bool Status { get; set; } = true;
    }
}