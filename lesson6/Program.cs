using System;

namespace lesson6 {

    class Project { 

        static void Main() {

            // for (byte i = 0; i < 10; i++) {
            //     Console.WriteLine("Element {0}", i);
            // }

            // bool isHeppy = true;

            // while (isHeppy){

            //     string and = Console.ReadLine();
            //     if (and == "and") {
            //         isHeppy = false;
            //     }
            // }

            byte num = 100;

            do {  // Один раз отработает , Сначало работает потом проверяет 

                Console.WriteLine("Element " + num);

            }while (num < 3);


        }

    }


}