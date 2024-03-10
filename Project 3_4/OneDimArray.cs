using System;

namespace Task3_4;

public abstract class OneDimArray<T> : BaseArray
{
    protected T[] Array;

    public int GetArrayLength(bool mode)
    {
        if (mode == false)
        {
            Random rand = new Random();
            return rand.Next(1, 15);
                    
        }
        else
        {
            Console.WriteLine("Введите длину своего массива");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
    
    protected OneDimArray(bool mode = false)
    {
        int length = GetArrayLength(mode);
        Array = new T[length];
    }
    
    public override void Print()
    {
        Console.WriteLine("Одномерный массив:");
        foreach (var i in Array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}