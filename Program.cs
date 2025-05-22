using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Conta c1 = new Conta();
            double v = 10;
            c1.Depositar(v);
            Console.WriteLine(" Deposito efetuado com Sussesso ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }
}


