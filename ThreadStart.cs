// Thread(ThreadStart) initializes a new instance of the Thread class.
// A ThreadStart delegate that represents the methods to be invoked when this thread begins executing.

using System;
using System.Threading;

class Test {
  public static void Main() {
    Thread newThread = new Thread(new ThreadStart(Work.DoWork));
    newThread.Start();
  }
}

class Work {
  Work() {}
  public static void DoWork() {}
}