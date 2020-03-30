using System;

namespace latihan4
{
    class Program
    { 
        static void Main(string[] args)
        {
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            CoffeMachine yummyCoffe = new CoffeMachine(coffe, water);
            //1st
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //2nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //3nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //4nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //5nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //6nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}
