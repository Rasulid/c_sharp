using System;
using System.IO;
namespace lesson10{

    class Project{
    // Работа с файлами и строками
        static void Main(){

            // string word = "Hello!";
            // word = String.Concat(word, "!!    ");  // обядиняет строки 
            // System.Console.WriteLine(word); 

            // string name = "John,James,Anders";
            // string [] sp = name.Split(new char[]{','}); // split
            // foreach(string sps in sp){
            //     System.Console.WriteLine(sps);
            // }
            // name = String.Join(" ", sp); // join
            // System.Console.WriteLine(name);

            // System.Console.WriteLine(word.Trim()); // trim dalete the spase after the word ends
            // System.Console.WriteLine(word.Substring(0, word.Length -1));
            // System.Console.WriteLine(word.ToLower());
            // System.Console.WriteLine(word.ToUpper());

            System.Console.WriteLine("Enter the text: ");
            string text = System.Console.ReadLine();
            using(FileStream file = new FileStream("info.txt", FileMode.OpenOrCreate)) {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);

                file.Write(array, 0, array.Length);

            } 

            using(FileStream file = File.OpenRead("info.txt")){
                byte[] array = new byte[file.Length];
                file.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                System.Console.WriteLine(textFromFile);
            }


        }

    }

}