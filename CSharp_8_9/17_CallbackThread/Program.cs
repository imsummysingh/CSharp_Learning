//Callback Thread Example

class NumbersUpCounter
{
    public int Count { get; set; }
    public void CountUp(Action<long> callback)
    {
        long sum = 0;
        try
        {
            Console.WriteLine("Count Up Started");
            Thread.Sleep(100);
            for (int i = 0; i <= Count; i++)
            {
                sum += i;
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
        finally
        {
            callback(sum);
        }

    }
}

class NumbersDownCounter
{
    public int Count { get; set; }
    public void CountDown()
    {
        Console.WriteLine("Count Down Started");
        Thread.Sleep(100);
        for (int j = Count; j >= 1; j--)
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

        //create object of NumberUpCounter class
        NumbersUpCounter nuc = new NumbersUpCounter() { Count = 100 };

        //callback method
        Action<long> callback = sum => {
            Console.WriteLine($"\nReturn value from Count-Up Thread is: {sum}");
        };

        //thread 1
        ThreadStart ts1 = new ThreadStart(() => nuc.CountUp(callback));
        Thread t1 = new Thread(ts1);
        t1.Name = "Count-Up Thread";
        t1.Priority = ThreadPriority.Highest;      
        t1.Start();
        Console.WriteLine($"{t1.Name} ({t1.ManagedThreadId}) is {t1.ThreadState.ToString()}");


        


        //create object of NumberDownCounter class
        NumbersDownCounter ndc = new NumbersDownCounter() { Count = 100 };

        //thread 2
        ThreadStart ts2 = new ThreadStart(ndc.CountDown);
        Thread t2 = new Thread(ts2);
        t2.Name = "Count-Down Thread";
        t2.Priority = ThreadPriority.BelowNormal;
        t2.Start();
        Console.WriteLine($"{t2.Name} ({t2.ManagedThreadId}) is {t2.ThreadState.ToString()}");

        //Join
        t1.Join();
        t2.Join();

        //Interrupt method
        //Thread.Sleep(100);
        //t1.Interrupt();     //thread 1 will stop

        Console.WriteLine(mainThread.Name + " Completed");

    }
}