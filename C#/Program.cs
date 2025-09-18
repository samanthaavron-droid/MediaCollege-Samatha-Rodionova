namespace C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the mark of the vechicle?");
        string Mark = Console.ReadLine();
        Console.WriteLine("How many gears does it have?");
        int Gears = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is the frame size?");
        double Frame = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Does it have lights? (true/false)");
        bool Lights = Convert.ToBoolean(Console.ReadLine());

        if (Lights == true)
        {
            Console.WriteLine("The vechicle is a " + Mark + ", it has " + Gears + " gears, the frame size is " + Frame + " and it has lights");
        }
        else
        {
            Console.WriteLine("The vechicle is a " + Mark + ", it has " + Gears + " gears, the frame size is " + Frame + " and it doesn't have lights");
        }
        
    }
}