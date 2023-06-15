using System;  
using System.Threading;

public class MyThread {
  public void Thread1() {
    for (int i = 0; i < 10; i++) {
      Console.WriteLine(i);
      Thread.Sleep(200);  
    }
  }
}

// MyThread class contains a method called Thread1, which prints numbers from 0 to 9 and pauses for 200 milliseconds.

public class ThreadExample {
  public static void Main() {
    Console.WriteLine("Start of Main");  
    MyThread mt = new MyThread();  
    Thread t1 = new Thread(new ThreadStart(mt.Thread1));  
    Thread t2 = new Thread(new ThreadStart(mt.Thread1));  

    t1.Start();  
    t2.Start();  
    try {
      t1.Abort();
      t2.Abort();
    } catch (ThreadAbortException tae) {
      Console.WriteLine(tae.ToString()); 
    }
  }
}

// In the Main method, Start of Main is printed to the Console first.
// An instance of MyThread class is created called mt.
// Two Thread objects are created and associated with a ThreadStart delegate, which is the Thread1() method.
// Start() is called on two threads, and then the program attempts to abort both threads. 
// ThreadAbortException is thrown during the abort attempt.