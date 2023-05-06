using System;

namespace lesson14 {
    

    class Robot{

        private string name;
        private int weight;
        private byte[] coordinates;

        public Robot(string name, int weight, byte[] coordinates){  // consstructor 
            System.Console.WriteLine("Object has ben created");
            this.SetValue(name, weight, coordinates);
        }

        public Robot(string name){  // consstructor
            System.Console.WriteLine("Object has ben created "+ name);
        }

        public Robot(){     // constructor

        }

        public void SetValue(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }

        public void GetValue(){
            System.Console.WriteLine(name+"weight="+weight+".coordinates");
            foreach(byte b in coordinates){
                System.Console.WriteLine(b);
            }
        }

    public static int count; // static method


    public static void Print(){
        System.Console.WriteLine("Hi bitches!");
    }
    }

}