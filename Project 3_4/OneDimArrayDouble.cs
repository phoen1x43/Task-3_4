using System;

namespace Task3_4;

public class OneDimArrayDouble : OneDimArray<double>
{

    public OneDimArrayDouble(bool mode = false) : base(mode) 
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
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = rand.NextDouble() * rand.Next(1, 10);
        }
        
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите элементы массива (вещественные числа):"); 
        for (int i = 0; i < Array.Length; i++) 
        { 
            Array[i] = double.Parse(Console.ReadLine()??"0");
        } 
    }
}
