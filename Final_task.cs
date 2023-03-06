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
        int len = rand.Next(1, 20);
        char[] a = new char[len];
        for (int i = 0; i < len; i++)
        {
            a[i] = (char)rand.Next(0x0410, 0x44F);
        }
        string str = new string(a);
        return str;
    }
     static String[] FinalyStringArray(String[] StartArray)
    {
        byte len =Convert.ToByte(StartArray.Length);
        String[] FinalyArray=new String[1];
        for (byte i = 0; i < len; i++)
        {
            if(StartArray[i].Length<4){
                 Array.Resize(ref FinalyArray, FinalyArray.Length + 1);
                FinalyArray[FinalyArray.Length-1]=StartArray[i];
                
            }
        }
if(FinalyArray.Length==1){
    FinalyArray[0]=" нет подходящих под условие строк";
}
        return FinalyArray;
    }
    public static void Main()
    {
        string[] ArrayString = BuildStartStringArray();
        Console.WriteLine("Исходный массив");
        foreach (string i in ArrayString)
        {
            Console.WriteLine(i);
        }
        string[] FinalyArray=FinalyStringArray(ArrayString);
         Console.WriteLine("Выходной массив");
         foreach (string i in FinalyArray)
        {
            Console.WriteLine(i);
        }
    }
}