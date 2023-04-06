using System;

namespace Functions
{
    public class Program
    {
        public static void SayHello() => Console.WriteLine("Hello how are you doing today?");

        public static void SayHelloWithParam(string firstName) => Console.WriteLine($"Hello, {firstName}, how are you doing today?");

        public static void SayHelloWithDefaultValue(string firstName = "buddy")
        {
            Console.WriteLine($"Hey {firstName}");
        }

        public static string SayHelloWithReturn(string firstName = "buddy")
        {
            return $"Hey {firstName}";
        }
       






        public static void Main(string[] args)
        {
            SayHello();
            SayHelloWithParam("Andrew");

            // We can call it without providing any arguments and the default value will be used...
            SayHelloWithDefaultValue();

            // ...or we can call it with an argument and that argument's value will be used
            SayHelloWithDefaultValue("Yoda");

            string greeting;
            greeting = SayHelloWithReturn();
            Console.WriteLine(greeting);
        }
    }
}
