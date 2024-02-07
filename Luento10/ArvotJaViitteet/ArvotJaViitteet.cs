using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author Omanimi
/// @version 07.02.2024
/// <summary>
/// 
/// </summary>
public class ArvotJaViitteet
{
    /// <summary>
    /// 
    /// </summary>
    public static void Main()
    {
        int a = 3;
        int b = a;
        b = b + 1;

        int[] taulukko1 = { 1, 2, 3 };
        int[] taulukko2 = taulukko1;
        taulukko2[1] = 4;
    }
}