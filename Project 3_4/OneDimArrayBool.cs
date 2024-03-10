using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Task3_4;

public class OneDimArrayBool : OneDimArray<bool>
{
    public OneDimArrayBool(bool mode = false) : base(mode) 
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
            Array[i] = (rand.Next(0, 2) != 0);
        }
    }

    public override void FillByUser()
    {  
        Console.WriteLine("Введите элементы массива (true or false)"); 
        for (int i = 0; i < Array.Length; i++) 
        { 
            Console.Write(i + " ");
            Array[i] = bool.Parse(Console.ReadLine()??"false");
        }
        Console.WriteLine(); 
    }

}