//Thread example ->Accessing the main thread and naming it

class Program
{
    static void Main()
    {
        //Thread class -> OBject of the predefined thread class
        //currentThread gives the name of the current thread

        //current thread reference is stored in mainThread reference variable and then we are accessing it and naming it.
        Thread mainThread = Thread.CurrentThread;
        mainThread.Name = "Current Main Thread";
        Console.WriteLine(mainThread);      //system.threading.thread
        Console.WriteLine(mainThread.Name); //Current Main Thread

        Console.WriteLine("Main Method");
        Method1();
    }
    static void Method1()
    {
        Console.WriteLine("Method1");
    }
}