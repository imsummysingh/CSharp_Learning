//Thread Properties example

class Program
{
    static void Main()
    {
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Current Main Thread";
        Console.WriteLine(mainThread.Name); //Current Main Thread

        ThreadPriority priority=mainThread.Priority;
        Console.WriteLine(priority);    //Normal
  
        Console.WriteLine(mainThread.IsAlive);  //true
        Console.WriteLine(mainThread.IsBackground);  //false
        Console.WriteLine(mainThread.ThreadState);  //running
    }    
}