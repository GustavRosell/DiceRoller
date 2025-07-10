namespace DiceRoller.Models
{
    public class RollData
    {
        public long Id { get; set; }
        public string? Dice { get; set; }
        public object? Result { get; set; } // Can be int or string (color hex)
        public string? Type { get; set; } // "number" or "color"
        public long Timestamp { get; set; }
    }
}