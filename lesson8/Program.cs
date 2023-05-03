using System;
using System.Collections.Generic;

namespace lesson8 { 

    class Program { 
    // for each , dynamic arrays
        static void Main() { 

            short[,] num = {
                {12,53,56},
                {13,54,55},
                {14,55,56}
            };

            foreach(short i in num){
                // System.Console.WriteLine("El :"+ i);
            }

    // dynamic array

        List<int> numbers = new List<int>(){
            12,13,14
        };
        numbers.Add(15);
        numbers.Add(16);
        numbers.Add(17);

        numbers.Remove(15);
        numbers.Sort();
        numbers.Reverse();


        foreach(int i in numbers){
            System.Console.WriteLine("El :"+ i);
        }


        }

    }


}