using System;

namespace lesson7 { 

    class Project {

        static void Main() {

        // Одномерные массивы 

            // byte[] nums = new byte[5];
            // nums[0] = 123;
            // nums[1] = 12;
            // nums[2] = 125;
            // nums[3] = 122;
            // nums[4] = 112;
            // System.Console.WriteLine("array "+ nums[3]);



            string[] words = new string[] {
                "Rasul",
                "Jovo",
                "Sulton",
                "Novo"
            };


            words[3]= "Qorg'ooo";


            for (byte i=0; i<words.Length; i++){
                System.Console.WriteLine("word "+ words[i]);
            }


            short[] nums = new short[10];
            Random random = new Random();
            short summa = 0;

            for(byte i =0; i<nums.Length; i++){

                nums[i] = Convert.ToInt16(random.Next(-25, 25));
                System.Console.WriteLine("El : "+ nums[i]);

                summa += nums[i];
            }
            System.Console.WriteLine("summa :"+ summa);


        // Многомерные массивы (2,3,4)

            char[,] symbols = new char[2,3];
            symbols[0,0] = 'H';

            System.Console.WriteLine("symbols "+symbols[0,0]);


            int[,] numbers = {
                {1,2,3},
                {2,3,4},
                {3,4,5,}
            };

            numbers[1,2] = 5;

            System.Console.WriteLine("ss : "+ numbers[1,2]);

        }


    }

}