using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        ulong bitValue = ulong.Parse(Console.ReadLine());

        ulong modifiedNumber = (number & ~((ulong)1 << position)) | (bitValue << position);

        Console.WriteLine(modifiedNumber);
    }
}
