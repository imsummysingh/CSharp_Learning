//Thread Interrupt Example

class NumbersCounter
{
    public void CountUp()
    {
        try
        {
            Console.WriteLine("Count Up Started");
            Thread.Sleep(100);
            //i=1to100
            for (int i = 0; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"i = {i}, ");
            }
            Thread.Sleep(100);
            Console.WriteLine("Count Up Completed");
        }
        catch (ThreadInterruptedException ex)
        {

            Console.WriteLine("Count-up Thread Interrupted");
        }
        
    }
    public void CountDown()
    {
        Console.WriteLine("Count Down Started");
        Thread.Sleep(100);
        for (int j = 100; j >= 1; j--)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"j = {j}, ");
        }
        Thread.Sleep(100);
        Console.WriteLine("Count Down Completed");
    }
}
class Program
{
    static void Main()
    {
        //get main thread
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Current Main Thread";
        Console.WriteLine(mainThread.Name + " Started"); //Current Main Thread

        //create object of NumberCounter class
        NumbersCounter nc = new NumbersCounter();

        //create first thread
        //threadstart delegate object
        //we should pass the reference of the method and not call it.
        ThreadStart ts1 = new ThreadStart(nc.CountUp);
        Thread t1 = new Thread(ts1);
        t1.Name = "Count-Up Thread";
        //thread priority
        t1.Priority = ThreadPriority.Highest;
        //invoke count up method
        t1.Start();
        Console.WriteLine($"{t1.Name} ({t1.ManagedThreadId}) is {t1.ThreadState.ToString()}");//running


        //create second thread
        //threadstart delegate object
        //we should pass the reference of the method and not call it.
        ThreadStart ts2 = new ThreadStart(nc.CountDown);
        Thread t2 = new Thread(ts2);
        t2.Name = "Count-Down Thread";
        //thread priority
        t2.Priority = ThreadPriority.BelowNormal;
        //invoke count up method
        t2.Start();
        Console.WriteLine($"{t2.Name} ({t2.ManagedThreadId}) is {t2.ThreadState.ToString()}");//running


        //Join
        //t1.Join();
        //t2.Join();

        //Interrupt method
        Thread.Sleep(100);
        t1.Interrupt();     //thread 1 will stop

        Console.WriteLine(mainThread.Name + " Completed");

    }
}