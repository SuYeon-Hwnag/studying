// Justification: Demonstrating the equivalent operators
#pragma warning disable IDE0054 // Use compound assignment
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_13
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int spaceCount = 0;

            spaceCount = spaceCount + 1; // spacecount = 1
            spaceCount += 1; // ���� ���� ����
            spaceCount++; // ���� ���� ����

            int value = 0;
            System.Console.Write(++value); // 1
            System.Console.Write(++value); // 2
            System.Console.Write(++value); // 3

            System.Console.Write(value++); // 3
            System.Console.Write(value++); // 4
            System.Console.Write(value++); // 5
            // value = 6
        }
    }
}

// ���� ������

/*
 
++Value �� value++
���� ���� �����ڿ� ���� ���� ������

������ ä ���� �� ������ ���� ���� ����


*/