using System;

namespace lesson4 {
    // if - else 
    class Project {

        static void Main() {

            // int a = 5;
            // bool b = true;

            // if ((a == 5 || b == true) && a > 2) {

            //     // || - или  && - и 

            //     Console.WriteLine("worked");
            // }
            // else if (a != 5){

            //     Console.WriteLine("a != 5");
            // }
            // else {

            //     Console.WriteLine("Else");
            System.Console.Write("Enter a role \n");
            string role = Console.ReadLine();

            if (role == "admin") {
                System.Console.Write("Enter a name \n");
                string name = Console.ReadLine();
                System.Console.Write("Enter a age of {0} \n", name);
                short age = Convert.ToInt16(Console.ReadLine());

                if (age <= 0  || age >= 99) {
                System.Console.Write("Enter a age: \n" );
                age = Convert.ToInt16(Console.ReadLine());


                }if (age <= 0  || age >= 99) {
                    System.Console.Write("Error");}
            }
            else {
                System.Console.Write("You are not a admin !");
            }

            
        }
    }
}