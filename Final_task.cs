using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program
{
    static String[] BuildStartStringArray()
    {
        Random rand = new Random();
        int len = rand.Next(20, 50);
        string[] ArrayString = new String[len];
        for (int i = 0; i < len; i++)
        {
            ArrayString[i] = Build_element();
        }

        return ArrayString;
    }
    static String Build_element()
    {
        Random rand = new Random();
        int len = rand.Next(1, 5);
        char[] a = new char[len];
        for (int i = 0; i < len; i++)
        {
            a[i] = (char)rand.Next(0x0410, 0x44F);
        }
        string str = new string(a);
        return str;
    }
    public static void Main()
    {
        string[] ArrayString = BuildStartStringArray();
        Console.WriteLine("Исходный массив");
        foreach (string i in ArrayString)
        {
            Console.WriteLine(i);
        }
    }
}