using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Psw = new PasswordGenerator();

            string GetPassword = Psw.Generating();
            Console.WriteLine(GetPassword);
            Console.WriteLine(GetPassword.Length);
        }
    }
}
