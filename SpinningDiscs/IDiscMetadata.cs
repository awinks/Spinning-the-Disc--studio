namespace SpinningDiscs
{
    public interface IDiscMetadata
    {
        string Name { get; set; }    
        int Capacity { get; set; }
        string DiscType { get; set; }

        int MinSpinSpeed { get; set; }

        int MaxSpinSpeed { get; set; }
    }
}