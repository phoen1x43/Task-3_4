using System;

namespace Task3_4;

public abstract class TwoDimArray<T> : BaseArray
{
    protected T[,] Array;

    public int GetArrayRows(bool mode)
    {
        if (mode == false)
        {
            Random rand = new Random();
            return rand.Next(1, 10);;       
        }
        else
        {
            Console.WriteLine("Введите количество строк в своем двумерном массиве");
            return Convert.ToInt32(Console.ReadLine());;
        }
    }

    public int GetArrayColumns(bool mode)
    {
        if (mode == false)
        {
            Random rand = new Random();
            return rand.Next(1, 10);      
        }
        else
        {
            Console.WriteLine("Введите количество столбцов в своем двумерном массиве");
            return Convert.ToInt32(Console.ReadLine());
        }
    }

    protected TwoDimArray(bool mode = false)
    {
        int rows = GetArrayRows(mode);
        int columns = GetArrayColumns(mode);
        Array = new T[rows, columns];
    }

    public override void Print()
    {
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Console.Write(Array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}