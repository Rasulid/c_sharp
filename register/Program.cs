using System;

namespace register{
    class Program{
        static void Main(){
            System.Console.WriteLine("Welcome to my register :)");
            System.Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();
            System.Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();
            Register(username, password);
        }
        
        public static void Register(string username , string password){
            using(FileStream data = new FileStream("data.txt", FileMode.Create)){
                byte [] username_array = System.Text.Encoding.Default.GetBytes(username);
                byte [] password_array = System.Text.Encoding.Default.GetBytes(password);

                data.Write(username_array, 0, username_array.Length);
                data.Write(password_array, 0, password_array.Length);
            }
        }

        public static void Check(string username, string password){
            
        }
    }
}