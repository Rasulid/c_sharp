using System;

namespace lesson13 {

    class Robot{
        // public, protected , private

        // public string name;
        // public int weight;

        // public byte[] coordinates;

        // private - Доступно только в классе 
        private string name;
        private int weight;

        private byte[] coordinates;

        public Robot(string _name, int _weight, byte[] _coordinates){  // consstructor 
            System.Console.WriteLine("Object has ben created");
            SetValue(_name, _weight, _coordinates);
        }

        public Robot(string _name){  // consstructor
            System.Console.WriteLine("Object has ben created "+ name);
        }

        public Robot(){     // constructor

        }

        public void SetValue(string _name, int _weight, byte[] _coordinates){
            name = _name;
            weight = _weight;
            coordinates = _coordinates;
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