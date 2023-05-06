using System;

namespace lesson2 {

    class Program {
    
        static void Main() {
                    
                        // int

            //int age = 10;
            int age;
            age = 100;
            Console.Write("bich " + age + '.');

            uint neg = 10; //  uint only for negative numbers
            Console.WriteLine("Negative " + neg);

            byte b = 255; // more then 255 not support
            Console.WriteLine("byte " + b);

            short sh = 32555; //less them 32000
            Console.WriteLine("Short " + sh);

            long lon = 7568009897780087669; // soo meny numbers
            Console.WriteLine("Long " + lon);


                            // Float


            float f = 123123.123123f; // . and f requared
            Console.WriteLine("Float " + f);

            double dou = 1231231233312312.12312123543415d; // diapazon greater x2 and finish d is req
            Console.WriteLine("Double " + dou);

                            // str                


            // string test = Console.ReadLine();
            // Console.WriteLine( "Input " +test);


            char symbol = 's'; // one simbol
            Console.WriteLine("Symbol " + symbol);
                        

                        // boolean
    
            bool isHappy = false; // or true

            Console.WriteLine("is Happy " + isHappy);


        }
    }

}