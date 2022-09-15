using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        IDiscMetadata GetDiscMetadata();
        void Play();
    }
}
