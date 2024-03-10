using System;

namespace Task3_4;

public class TwoDimArrayDouble : TwoDimArray<double>
{

    public TwoDimArrayDouble(bool mode = false) : base(mode) 
    {
        if (mode)
        {
            FillByUser();
        }
        else
        {
            RndFill();
        }
    }
    
    public override void RndFill()
    {   
        Random rand = new Random();
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = rand.NextDouble() * rand.Next(1, 10);
            }
        }
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите элементы двумерного массива (вещественные числа):"); 
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = double.Parse(Console.ReadLine()??"0");
            }
        }
    }
}