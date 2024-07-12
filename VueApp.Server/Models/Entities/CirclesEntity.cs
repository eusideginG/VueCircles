namespace VueApp.Server.Models.Entitys
{
    public class CirclesEntity
    {
        public required Guid Id { get; set; }
        public required DateTime Time { get; set; }
        public required float XAxis { get; set; }
        public required float YAxis { get; set; }
        public required string Color { get; set; }
        public required float Diameter { get; set; }

        public Guid DataId { get; set; }
        public DataEntity? Data { get; set; }
    }
}
