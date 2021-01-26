using System;
using System.Collections.Generic;
using System.Text;

namespace CatAbstract
{
    public class Car
    {
        IEngine _engine { get; set; }
        IChassis _chassis { get; set; }
        public Car(IEngine engine, IChassis chassis)
        {
            this._engine = engine;
            this._chassis = chassis;
        }
        public string GetEngineParam 
        {
            get
            { 
                return $" {_engine.Name}: {_engine.Power.ToString()}, {_engine.Moment.ToString()}"; 
            }
        }
    }
}
