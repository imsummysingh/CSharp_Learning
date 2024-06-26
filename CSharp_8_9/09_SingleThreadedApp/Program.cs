//Single Threaded App Example

class NumbersCounter
{
    public void CountUp()
    {
        //i=1to100
        for(int i = 0; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"i = {i}, ");
        }
    }
    public void CountDown()
    {
        for(int j = 100; j >= 1; j--)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j}, ");
        }
    }
}
class Program
{
    static void Main()
    {
        //get main thread
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Current Main Thread";
        Console.WriteLine(mainThread.Name); //Current Main Thread

        //create object of NumberCounter class
        NumbersCounter nc = new NumbersCounter();
        nc.CountUp();
        nc.CountDown();

        Console.WriteLine(mainThread.Name + " Completed");

    }
}