using System.Globalization;

namespace Task3_4;

public class OneDimArrayString : OneDimArray<string>
{
    public OneDimArrayString(bool mode = false) : base(mode) 
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
        Random random = new Random();
        for (int i = 0; i < Array.Length; i++)
        {
            string randomString = GenerateRandomString(1, 10, random);
            Array[i] = randomString;
        }
        
        static string GenerateRandomString(int minLength, int maxLength, Random random)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int length = random.Next(minLength, maxLength + 1);
            char[] randomString = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomString[i] = alphabet[random.Next(alphabet.Length)];
            }
            return new string(randomString);
        }
    }
    public override void FillByUser()
    {  
        Console.WriteLine("Введите элементы массива (строки)"); 
        for (int i = 0; i < Array.Length; i++) 
        { 
            Array[i] = Console.ReadLine()??"";
        }
    }
}
