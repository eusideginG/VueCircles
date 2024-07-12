namespace VueApp.Server.Models.DTOs
{
    public class CircleDTO
    {
        public required Guid DataId { get; set; }
        public required DateTime Time { get; set; }
        public required float XAxis { get; set; }
        public required float YAxis { get; set; }
        public required string Color { get; set; }
        public required float Diameter { get; set; }
    }
}
