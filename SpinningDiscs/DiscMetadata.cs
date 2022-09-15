namespace SpinningDiscs
{
    internal class DiscMetadata : IDiscMetadata
    {
        public int Capacity { get; set; }
        public string DiscType { get; set; }
        public int MaxSpinSpeed { get; set; }
        public string Name { get; set; }
        public int MinSpinSpeed { get; set; }
    }
}