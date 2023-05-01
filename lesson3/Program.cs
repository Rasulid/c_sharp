using System;

namespace lesson3 {

    class Project {

        static void Main(){
            //float number;
            //Console.Write("Enter thr number : ");
            // double number;
            // number = Convert.ToDouble(Console.ReadLine());
            //number = float.Parse(Console.ReadLine());
            //float result; 
            //result = number + 10f;
            // result += 10
            // result ++; add +1
            //Console.WriteLine("Add : " + result);
            //result = number - 10f;
            // result -= 10
            // result --; -1
            //Console.WriteLine("Minus : " + result);
            //result = number * 10f;
            // result *= 10
            //Console.WriteLine("Multyplay : " + result);
            //result = number / 10f;
            // result /= 10
            //Console.WriteLine("Delen : " + result);
            //result = number % 10f;
            // result %= 10
            //Console.WriteLine("Ostatok : " + result);
            // Console.WriteLine("Number : " + number);

            // cw - Consloe.Write()

            // Console.WriteLine(Math.PI);
            // Console.WriteLine(Math.Abs(-23)); 
            // Console.WriteLine(Math.Ceiling(4.3f)); // Округляет к большему 
            // Console.WriteLine(Math.Floor(4.99f)); // Округляет к меньшему
            // Console.WriteLine(Math.Round(4.55)); // Round
            // Console.WriteLine(Math.Min(5,1));
            // Console.WriteLine(Math.Max(5, 1));
            // Console.WriteLine(Math.Pow(5, 2));


            Console.Write("Введите радиус круга : ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}" , radius , area);





        }

    }
}