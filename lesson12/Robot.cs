using System;

namespace lesson12 {

    class Robot{
        // public, protected , private

        // public string name;
        // public int weight;

        // public byte[] coordinates;

        // private - Доступно только в классе 
        private string name;
        private int weight;

        private byte[] coordinates;


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
    }

}