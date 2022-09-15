using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        protected string Contents { get; set; }
        protected IDiscMetadata Metadata { get; set; }

        protected BaseDisc(string name, int capacity, int minSpinSpeed, int maxSpinSpeed, string discType)
        {
            Metadata = new DiscMetadata()
            {
                Capacity = capacity,
                DiscType = discType,
                MaxSpinSpeed = maxSpinSpeed,
                MinSpinSpeed = minSpinSpeed,
                Name = name
            };
         
        }
        internal string ReadData()
        {
            return this.Contents;
        }

        internal void WriteData(string data)
        {
            if(data.Length < this.Metadata.Capacity)
            {
                this.Contents = data;
            }
        }

        internal void SpinDisc()
        {
            Console.WriteLine($"A {Metadata.DiscType} spins at a rate of {Metadata.MinSpinSpeed} - {Metadata.MaxSpinSpeed} rpm.");
        }
    }

}
