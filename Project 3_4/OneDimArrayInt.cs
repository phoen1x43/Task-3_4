using System;

namespace Task3_4;

public class OneDimArrayInt : OneDimArray<int>
{
    public OneDimArrayInt(bool mode = false) : base(mode) 
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
            Array[i] = rand.Next(1, 100);
        }
    }

    public override void FillByUser()
    {
        Console.WriteLine("Введите элементы массива (целые числа):"); 
        for (int i = 0; i<Array.Length; i++) 
        { 
            Console.Write(i + " ");
            Array[i] = Convert.ToInt32(Console.ReadLine());
        } 
        Console.WriteLine(); 
    }

}