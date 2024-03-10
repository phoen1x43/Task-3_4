using System;

namespace Task3_4;

public class TwoDimArrayBool : TwoDimArray<bool>
{
    public TwoDimArrayBool(bool mode = false) : base(mode) 
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
                Array[i, j] = (rand.Next(0, 2) != 0);
            }
        }   
    }

    public override void FillByUser()
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Console.WriteLine("Введите элементы двумерного массива (true or false): ");
                Array[i, j] = bool.Parse(Console.ReadLine()??"false");
            }
        }
    }
}