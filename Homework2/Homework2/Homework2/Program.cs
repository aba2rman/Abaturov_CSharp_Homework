using System;
using System.Drawing;

namespace Homework2;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите размер массива: ");
        int size = ReadInt();
        
        if (size <= 0)  
        {
            Console.WriteLine("Размер массива не может быть отрицательным или равен 0");
        }
        else
        {
            int[] numbers = new int[size];

            Console.WriteLine("\r\nВведите значения элементов массива: ");
            for (int i = 0; i < size; i++)
            {
                numbers[i] = ReadInt(); 
            }

            Array.Sort(numbers);
            Console.WriteLine($"\r\nВторой по величине элемент массива: {numbers[size - 2]}");
        }
            
        
    }
    
    public static int ReadInt()
    {
        if (Int32.TryParse(Console.ReadLine(), out var value))
        {
            return value;
        }
        else
        {
            throw new Exception("Введите целое число");
        }
    }

    //Не смог придумать, как засунуть сюда try-catch, поэтому не отлавливает исключения, когда среди чисел массива есть не int-овые значения
}