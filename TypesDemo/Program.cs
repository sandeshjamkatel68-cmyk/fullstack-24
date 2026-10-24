
using System;

struct NumberBox
{
    public int Value;
}

sealed class ReferenceBox
{
    public int Value;
}

internal class Program
{
    private static void Main()
    {
        StructVsClass();
        DoubleVsDecimal();
        CheckedOverflow();
        StringImmutability();
    }

    private static void StructVsClass()
    {
        Console.WriteLine("=== Struct vs Class Copy Behaviour ===");

        // Struct: copies the value.
        NumberBox structA = new NumberBox { Value = 10 };
        NumberBox structB = structA;

        structB.Value = 20;

        Console.WriteLine($"Struct A: {structA.Value}");
        Console.WriteLine($"Struct B: {structB.Value}");

        // Class: copies the reference.
        ReferenceBox classA = new ReferenceBox { Value = 10 };
        ReferenceBox classB = classA;

        classB.Value = 20;

        Console.WriteLine($"Class A: {classA.Value}");
        Console.WriteLine($"Class B: {classB.Value}");
        Console.WriteLine();
    }

    private static void DoubleVsDecimal()
    {
        Console.WriteLine("=== Double vs Decimal Rounding ===");

        double doubleValue = 2.675;
        decimal decimalValue = 2.675m;

        Console.WriteLine(
            $"Double rounded: {Math.Round(doubleValue, 2)}");

        Console.WriteLine(
            $"Decimal rounded: {Math.Round(decimalValue, 2)}");

        double doubleSum = 0.1 + 0.2;
        decimal decimalSum = 0.1m + 0.2m;

        Console.WriteLine($"Double sum: {doubleSum:R}");
        Console.WriteLine($"Decimal sum: {decimalSum}");
        Console.WriteLine();
    }

    private static void CheckedOverflow()
    {
        Console.WriteLine("=== Checked Overflow ===");

        try
        {
            int max = int.MaxValue;
            int result = checked(max + 1);

            Console.WriteLine($"Result: {result}");
        }
        catch (OverflowException)
        {
            Console.WriteLine(
                "Overflow detected: integer is out of range.");
        }

        Console.WriteLine();
    }

    private static void StringImmutability()
    {
        Console.WriteLine("=== String Immutability ===");

        string original = "Hello";
        string changed = original.Replace("Hello", "World");

        Console.WriteLine($"Original string: {original}");
        Console.WriteLine($"New string: {changed}");

        Console.WriteLine(
            $"Are they the same value? {original == changed}");
    }
}
