namespace C_;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DateTime label1 = DateTime.Now;
            WriteLine(label1.ToString("HH:mm:ss"));
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
