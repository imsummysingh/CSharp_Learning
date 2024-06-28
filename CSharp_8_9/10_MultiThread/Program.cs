//Multi Threaded App Example

class NumbersCounter
{
    public void CountUp()
    {
        //i=1to100
        for (int i = 0; i <= 100; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"i = {i}, ");
        }
    }
    public void CountDown()
    {
        for (int j = 100; j >= 1; j--)
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

        //create first thread
        //threadstart delegate object
        //we should pass the reference of the method and not call it.
        ThreadStart ts1 = new ThreadStart(nc.CountUp);
        Thread t1 = new Thread(ts1);
        t1.Name = "Count-Up Thread";
        Console.WriteLine($"{t1.Name} is {t1.ThreadState.ToString()}");//unstarted
        //invoke count up method
        t1.Start();
        Console.WriteLine($"{t1.Name} is {t1.ThreadState.ToString()}");//running


        //create second thread
        //threadstart delegate object
        //we should pass the reference of the method and not call it.
        ThreadStart ts2 = new ThreadStart(nc.CountDown);
        Thread t2 = new Thread(ts2);
        t2.Name = "Count-Down Thread";
        Console.WriteLine($"{t2.Name} is {t2.ThreadState.ToString()}");//unstarted
        //invoke count up method
        t2.Start();
        Console.WriteLine($"{t2.Name} is {t2.ThreadState.ToString()}");//running



        Console.WriteLine(mainThread.Name + " Completed");

    }
}