namespace Characterlist.Models
{
    public class Characterstats
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Vitality { get; set; }
        public int Intelligence { get; set; }
        public int Luck { get; set; }
        public int HP { get; set; }
    }
}