using System;
using System.Collections.Generic;
using System.Text;

namespace CatAbstract
{
    public class Chassis5Ton : IChassis
    {
        public string Name => "Chassis 5 Ton";

        public int NumbOfTiers => 6;

        public int Weight => 5;

        public typeOfTier TierType => typeOfTier.Winter;
    }
}
