using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        private const int CAPACITY = 17000;

        private const int MIN_SPIN_SPEED = 570;

        private const int MAX_SPIN_SPEED = 1600;

        private const string DISC_TYPE = "Digital Versatile Disc";

        public DVD(string name) : base(name, CAPACITY, MIN_SPIN_SPEED, MAX_SPIN_SPEED, DISC_TYPE)
        {
        }

        public IDiscMetadata GetDiscMetadata()
        {
            return this.Metadata;
        }

        public void Play()
        {
            Console.WriteLine("Welcome to the main menu of Elf");
        }
    }
}
