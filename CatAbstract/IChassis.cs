using System;
using System.Collections.Generic;
using System.Text;

namespace CatAbstract
{
    public interface IChassis
    {
        string Name { get; }
        int NumbOfTiers { get; }
        int Weight { get; }
        typeOfTier TierType { get; }
        


    }
    public enum typeOfTier
    {
        Summer = 1,
        Winter = 2
    }
}
