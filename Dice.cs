namespace DiceRoller.Models
{
    public class Dice
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; } // "standard" or "custom"
        public string? Mode { get; set; } // "number" or "color" for custom dice
        public int Sides { get; set; } // For standard dice (d4, d6, etc.)
        public int Min { get; set; } // For custom number dice
        public int Max { get; set; } // For custom number dice
        public List<string>? Colors { get; set; } // For custom color dice
    }
}