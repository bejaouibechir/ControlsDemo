namespace ControlsDemo
{
    public class Animal
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public override string ToString()
        => $"Name: {Name}, Location: {Location} Details: {Details}";
    }
}
