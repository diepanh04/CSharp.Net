// Thread(ParameterizedThreadStart) initializes a new instance of the Thread class, specifying a delegate that
// allows an object to be passed to the thread when the thread is started. 
// ParameterizedThreadStart is a delegate that represents the methods to be invoked when this thread begins executing.

using System;
using System.Threading;

public class Work {
  public static void Main() {
    Thread newThread = new Thread(Work.DoWork);
    newThread.Start(42);

    Work w = new Work();
    newThread = new Thread(w.DoMoreWork);
    newThread.Start("The answer");
  }

  public static void DoWork(object data) {
    Console.WriteLine("Static thread procedure. Data='{0}", data);
  }

  public void DoMoreWork(object data) {
    Console.WriteLine("Instance thread procedure. Data='{0}", data);
  }
}

// Output:
// Static thread procedure. Data='42'
// Instance thread procedure. Data='The answer.'

// In the Main method, a new thread is created by passing the "DoWork" method as the thread procedure
// The thread is then executed using the Start() method
// Another thread is created using the "DoMoreWork" method as the thread procedure
// The thread is then executed using the Start() method

// Since DoMoreWork is an instance method rather than a static method (no static keyword), we need to
// create an instance of the Work class and then call DoMoreWork on it. In contrast, DoWork is a static method
// and is accessible by the class itself. 