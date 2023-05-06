using System;

namespace lesson12 {

    class Project {

        static void Main() {

            Robot r = new Robot();
            r.name = "Robot";
            r.weight = 123;
            r.coordinates = new byte[] {0,0,1};

            System.Console.WriteLine(r.weight);

        }

    }

}