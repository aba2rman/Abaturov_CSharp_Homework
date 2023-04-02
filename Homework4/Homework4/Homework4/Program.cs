using System;
using Class;

public static class Program
{
    public static void Main()
    {
        Counter Counter = new Counter();
        Handler1 Handler1 = new Handler1();
        Handler2 Handler2 = new Handler2();

        Counter.CountEvent += Handler1.Message;
        Counter.CountEvent += Handler2.Message;

        Counter.Count();
    }
}