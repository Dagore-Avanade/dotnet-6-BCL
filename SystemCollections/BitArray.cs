using System.Collections;

// BitArray: an array of bits which are basically booleans
public class BitArrayExamples
{
    public static void Main()
    {
        BitArray bitArray1 = new BitArray(5);
        Console.WriteLine("Default BitArray");
        PrintEnumerable.PrintValues(bitArray1);
        Console.WriteLine("From array of bytes");
        byte[] byteArray = new byte[1] { 1 };
        BitArray bitArray2 = new BitArray(byteArray);
        PrintEnumerable.PrintValues(bitArray2);
        Console.WriteLine("From array of booleans");
        bool[] boolArray = new bool[5];
        BitArray bitArray3 = new BitArray(boolArray);
        PrintEnumerable.PrintValues(bitArray3);
        Console.WriteLine("With default to true");
        BitArray bitArray4 = new BitArray(5, true);
        PrintEnumerable.PrintValues(bitArray4);
    }
}
