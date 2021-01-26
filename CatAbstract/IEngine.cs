using System;
using System.Collections.Generic;
using System.Text;

namespace CatAbstract
{
    public interface IEngine
    {
        string Name { get; }
        int Power { get;}
        int Moment { get;}
    }
}
