using System;

namespace Homework1;

public class Program
{
    public static void Main()
    {
        Console.Write("Введи свое имя: ");
        string? name = Console.ReadLine(); // "?" указываем, так как string может иметь значение null 
        SayHello(name);                    // Не до конца разобрался, но нашел это здесь: https://metanit.com/sharp/tutorial/2.15.php
    }

    public static void SayHello(string name)
    {
        Console.WriteLine($"Привет, {name}!");
    }

    /*  Если без использования метода, то выглядело бы так:
     * 
     *  Console.Write("Введи свое имя: ");
     *  string? name = Console.ReadLine();
     *  Console.WriteLine("Привет, " + name + "!"); */
}