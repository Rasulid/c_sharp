using System;

namespace lesson11{
    class Project{
    // try-catch
        static void Main() {
            try {
                int num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(num);
            }catch(FormatException){
                System.Console.WriteLine("Failed to convert");
            }catch(Exception){
                System.Console.WriteLine("Failed to convert2");
            }finally{
                System.Console.WriteLine("it's soo fucking good");
            }
        }
    }
}