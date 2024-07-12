namespace VueApp.Server.Models.Entitys
{
    public class DataEntity
    {
        public required Guid Id { get; set; }
        
        IEnumerable<CirclesEntity>? Circles { get; set; }
    }
}
