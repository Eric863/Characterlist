namespace Characterlist.Models
{
    public class Magic
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public string? Bonus { get; set; }
        public required string Effect { get; set; }
        public string? Components { get; set; }
    }
}
