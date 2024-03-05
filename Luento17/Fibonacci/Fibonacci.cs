using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// Luento 17, rekursio. 
/// </summary>
public class FibonacciEsimerkki
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        // Fibonaccin luku
        // F(n) = 0              , kun n=0
        //      = 1              , kun n=1
        //      = F(n-1) + F(n-2), kun n > 1
        // Lukujonon ensimmäisiä luvut ovat
        // n    = 0  1  2  3  4  5  6   7   8   9  10
        // F(n) = 0  1  1  2  3  5  8  13  21  34  55 ...

        int i = 0;
        while (i < 20)
        {
            Console.WriteLine($"{i}: {Fibonacci(i)}");
            i++;
        }
        i = 0;
        while (i < 100)
        {
            Console.WriteLine($"{i}: {FibonacciIter(i)}");
            i++;
        }
    }

    /// <summary>
    /// Fibonacci iteratiivisesti (silmukassa). Oleellista tässä on, että välitulokset lasketaan
    /// muuttujiin, eikä Fibonaccin arvoja syötteille n-1 ja n-2 tarvitse laskea uudestaan ja uudestaan.  
    /// </summary>
    /// <param name="n">n</param>
    /// <returns>Fibonacci(n)</returns>
    public static long FibonacciIter(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        long fib_n_1 = 1;
        long fib_n_2 = 0;
        long fib = 1;
        int i = 2;
        while ( i <= n)
        {
            fib = fib_n_1 + fib_n_2;
            fib_n_2 = fib_n_1;
            fib_n_1 = fib;
            i++;
        }
        return fib;
    }
    
    /// <summary>
    /// Fibonaccin luku rekursiivisesti.
    /// F(n) = 0               , kun n = 0
    ///      = 1               , kun n = 1
    ///      = F(n-1) + F(n-2) , kun n > 1
    /// Lukujonon ensimmäiset luvut ovat
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
    /// </summary>
    /// <param name="n">n</param>
    /// <returns>Fibonacci(n)</returns>
    public static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}