using System;  
using System.Threading;  

public class MyThread {
  public void Thread1() {
    for (int i = 0; i < 5; i++) {
      Console.WriteLine(i);  
      Thread.Sleep(200);  
    }
  }
}

public class ThreadExample {
  public static void Main() {
    MyThread mt = new MyThread();
    Thread t1 = new Thread(new ThreadStart(mt.Thread1));  
    Thread t2 = new Thread(new ThreadStart(mt.Thread1));  
    Thread t3 = new Thread(new ThreadStart(mt.Thread1)); 

    t1.Start();
    t1.Join();
    t2.Start();
    t3.Start();
  }
}

// Output:
// 0
// 1
// 2
// 3
// 4
// 0
// 0
// 1
// 1
// 2
// 2
// 3
// 3
// 4
// 4