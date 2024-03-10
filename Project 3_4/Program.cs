using Task3_4;

namespace Project_3_4;

internal static class Program
{
    public static void Main(string[] args)
    {
        BaseArray[] arrays =
        [
            new OneDimArrayInt(), 
            new OneDimArrayString(),
            new OneDimArrayBool(), 
            new OneDimArrayDouble(),
            new TwoDimArrayInt(),
            new TwoDimArrayString(), 
            new TwoDimArrayBool(), 
            new TwoDimArrayDouble()
        ];

        foreach (IPrinter arr in arrays)
        {
            arr.Print();
        }
    }
}

    



