using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    Baby b1 = new Baby("Noah");
    Baby b2 = new Baby("Olivia");
    Baby b3 = new Baby("Liam");
    Baby b4 = new Baby("Emma");
    Baby b5 = new Baby("Amelia");
    Thread t1 = new Thread(b1.Run);
    Thread t2 = new Thread(b2.Run);
    Thread t3 = new Thread(b3.Run);
    Thread t4 = new Thread(b4.Run);
    Thread t5 = new Thread(b5.Run);
    t1.Start();
    t2.Start();
    t3.Start();
    t4.Start();
    t5.Start();
  }
  class Baby {
    Random rn = new Random();
    public string name;
    public int time;
    public Baby(string n){
      this.name = n;
      this.time = rn.Next(5000);
    }
    public void Run(){
      try{
      Console.WriteLine("My name is " + this.name + " I am going to sleep for " + this.time + "ms");
      Thread.Sleep(this.time);
      Console.WriteLine("My name is " +this.name+ ", I am awake, feed me!!!");
      }
      catch (ThreadInterruptedException tiex){
        Console.WriteLine("Error: " + tiex.Message);
      }
    }
  }
}