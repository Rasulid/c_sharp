using System;

namespace lesson5 { 

    class Project { 

        static void Main() {
            
            short num = Convert.ToInt16(Console.ReadLine());

            switch (num) {

                case 5 :
                    Console.WriteLine("Number is 5 ");
                    break;
                case 15 :
                    Console.WriteLine("Number is 15 ");
                    break;
                case 20 :
                    Console.WriteLine("Number is 20 ");
                    break;
                case 25 :
                    Console.WriteLine("Number is 25 ");
                    break;
                
                default:
                    Console.WriteLine("number is unknown");
                    break;

            }
        }
    }
}