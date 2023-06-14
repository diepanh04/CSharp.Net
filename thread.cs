using System; // using the System namespace
using System.Threading; // using System.Threading namespace, including classes such as Thread, Mutex, Semaphore, Monitor,...

class Program {
  public static void Main() {
    Thread t = new Thread(Worker); // create a new thread

    t.Start(); // start the thread 
    // What is the difference between using Thread.Start() and creating a ThreadStart delegate?

    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Main thread doing some work");
      Thread.Sleep(100); // Sleep is a static method, not an instance method, so we use Thread.Sleep(), not t.Sleep();
    }

    // waiting for the worder thread to complete
    t.Join();
    // and then executing the below line
    Console.WriteLine("Done");
  }

  public static void Worker() {
    for (int i = 0; i < 10; i++) {
      Console.WriteLine("Worker thread doing some work");
      Thread.Sleep(100);
    }
  }
}

// When the Main() method is executed, the main thread is created implicitly and starts executing the statements.
// A new thread "t" is created using the class "Thread" constructor an the "Worker" method is assigned as the target method
// Another way of creating "t":
// Thread t = new Thread(new ThreadStart(Worker));
// t.Start();
// The main thread executes the for loop, printing  "Main thread doing some work" and sleeping for 100 milliseconds in each iteration.
// Meanwhile, the worker thread executes its own for loop, printing "Worker thread doing some work" and sleeping for 100 milliseconds in each iteration.
// After the main thread finishes its loop, it reaches t.Join(), meaning that it will wait for the Worker thread to finish its loop
// and then print "Done".

