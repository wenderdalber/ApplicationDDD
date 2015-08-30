namespace ApplicationDDD.Domain.Entities
{
    public class Categories
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public virtual Products Product { get; set; }
    }
}
