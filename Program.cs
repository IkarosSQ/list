using system;

namespace List
{
    class Program
    {
        static void main(string[] args) 
        {
            console.writeline("hello world");





























            if (Console.ReadKey().Key == ConsoleKey.Y) {
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 900);
                Console.Beep(2000, 2000);
            } else if (Console.ReadKey().Key != ConsoleKey.Y) {
                Console.Beep(5000, 1000);
            }           



        }

    }
}