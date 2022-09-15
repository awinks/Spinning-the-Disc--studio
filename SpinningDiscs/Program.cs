using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            var cd = new CD("Happy's dope mixtape");

            cd.SpinDisc();

            var dvd = new DVD("Elf: A Christmas movie");

            dvd.SpinDisc();
            // TODO: Declare and initialize a CD and a DVD object.

            // TODO: Call each CD and DVD method to verify that they work as expected.
        }
    }
}
