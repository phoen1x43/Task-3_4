using System;

namespace Task3_4;

public class TwoDimArrayString : TwoDimArray<string>
{
    public TwoDimArrayString(bool mode = false) : base(mode) 
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
                Array[i, j] = GenerateRandomString(1, 10, rand);
            }
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
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Console.WriteLine("Введите элементы двумерного массива (строки): ");
                Array[i, j] = Console.ReadLine()??"";
            }
        }
    }

}