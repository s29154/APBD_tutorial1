// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        Console.WriteLine("Sup?");
    }

    static double average(int[] arr)
    {
        double sum = arr.Aggregate<int, double>(0, (current, t) => current + t);
        return sum / arr.Length;
    }
}