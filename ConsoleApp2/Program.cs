// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Net.Http.Headers;

class Program
{
    public static void Main (string[] args)
    {
        int floatWeight = 0, intWeight = 0, stringWeight = 0;
        object[] data = new object[args.Length];
        for (var i = 0; i < args.Length; i++)
        {
            var num = args[i];
            Console.WriteLine (num);
            if (int.TryParse(num, out var intVal))
            {
                data[i] = intVal;
            }
            else if (float.TryParse(num, out var floatVal))
            {
                data[i] = floatVal;
            }
            else 
            {
                data[i] = intVal.ToString(); 
            }
        }
        var intArr = new int[intWeight];
        var floatArr = new int[floatWeight];
        var stringArr = new int[stringWeight];
        floatWeight = 0;
        intWeight = 0;
        stringWeight = 0;
        foreach (var num in data)
        {
            if (num is string)
            {
                stringArr[stringWeight] = (string)num;
                stringWeight++;
            }
            else if (num is float)
            {
                floatArr[floatWeight] = (int)(float) num;
                floatWeight++;
            }
            if (num is int)
            {
                intArr[intWeight] = (int)num;
                intWeight++;
            }
        }
    }
}
