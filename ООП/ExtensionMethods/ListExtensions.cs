using System;
using System.Collections.Generic;

public static class ListExtensions
{
    public static List<int> PrimeNumbers(this List<int> numbers)
    {
        var primes = new List<int>();

        foreach (var number in numbers)
        {
            if (IsPrime(number))
                primes.Add(number);
        }

        return primes;
    }

    private static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
