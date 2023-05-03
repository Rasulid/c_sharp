using System;

namespace lesson7 {
    class Project {
        static void Main(){

            // Print("hello world");
            // string word = Console.ReadLine();
            // Print(word);

        //     int s = Sum(12,12);
        //     Print(s.ToString());

        // }

        // public static void Print(string word){
        //     System.Console.WriteLine(word);
        // }

        // public static int Sum(int x, int y){
        //     return x+y;
            byte[] numbers = {4,1,5,3,6,4};
            byte res = Sum(numbers);
            System.Console.WriteLine(res);
        }

        public static byte Sum(byte[] numbers){
            byte count = 0;
            foreach (byte i in numbers)
                count += i;
            return count;

        }


    }
}