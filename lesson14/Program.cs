using System;

namespace lesson14 {

    class Project {
    // this

        static void Main() {

            Robot r = new Robot("Rasul", 123, new byte[] {3,42,13});
            r.GetValue();
            // r.name = "Robot";
            // r.weight = 123;
            // r.coordinates = new byte[] {0,0,1};

            // System.Console.WriteLine(r.weight);
            
            // Robot r1 = new Random("Rasul");
            // Robot r3 = new Random();

            Robot.count = 30;
            System.Console.WriteLine(Robot.count);

            Robot.Print();

        }

    }

}