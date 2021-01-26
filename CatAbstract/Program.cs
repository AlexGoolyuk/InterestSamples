using System;


/// <summary>
/// Пример работы с большим кол-вом сущностей
/// </summary>
namespace CatAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            var engineV12 = new V12();
            var chassis5Ton = new Chassis5Ton();

            Car opel = new Car(engineV12, chassis5Ton);


            Console.WriteLine(opel.GetEngineParam);
        }
    }
}
