using System;
using System.Threading;

public class Work {
  public static void Main() {
    Thread newThread = new Thread(Work.DoWork);
    newThread.Start(42);

    Work w = new Work();
    newThread = newThread(w.DoMoreWork);
    newThread.Start("The answer");
  }

  public static void DoWork(object data) {
    Console.WriteLine("Static thread procedure. Data='{0}", data);
  }

    public static void DoMoreWork(object data) {
    Console.WriteLine("Instance thread procedure. Data='{0}", data);
  }
}