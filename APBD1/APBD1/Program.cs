// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        Console.WriteLine("Sup?");
    }

    static double average(int[] arr)
    {
        double sum = 0;
        for (int i =0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum / arr.Length;
    }
}