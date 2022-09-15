using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc

    {
        private const int CAPACITY = 750;

        private const int MIN_SPIN_SPEED = 200;

        private const int MAX_SPIN_SPEED = 500;

        private const string DISC_TYPE = "Compact Disc";

        public CD(string name) : base(name, CAPACITY, MIN_SPIN_SPEED, MAX_SPIN_SPEED, DISC_TYPE) 
        { 
        }
 
        public CD(string name, int capacity, int minSpinSpeed, int maxSpinSpeed, string discType) : base(name, capacity, minSpinSpeed, maxSpinSpeed, discType)
        {
        }

        public IDiscMetadata GetDiscMetadata()
        {
            return this.Metadata;
        }

        public void Play()
        {
            Console.WriteLine("The wheels on the bus go round and round");
        }

       
    }
}


// TODO: Implement your custom interface.

// TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
//  need to be declared separately. 