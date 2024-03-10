using System;

namespace Task3_4;

public class TwoDimArrayInt : TwoDimArray<int>
{
    public TwoDimArrayInt(bool mode = false) : base(mode) 
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
                Array[i, j] = rand.Next(0, 100);
            }
        }
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите элементы двумерного массива (целые числа):"); 
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Array[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

}