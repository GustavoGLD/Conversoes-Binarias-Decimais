using System;
using System.Collections.Generic;

class Program
{
    #region Menu
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Digite 1 de Decimal para Binário");
            Console.WriteLine("Digite 2 de Binário para Decimal");
            int resposta = Convert.ToInt32(Console.ReadLine());

            Lobby(resposta);
        }
    }
     #endregion

    #region Lobby do Decimal para Binario
    public static void Lobby(int code)
    {
        while (true)
        {
            if (code == 1) { ProgramaDec2Bin(); }
            if (code == 2) { ProgramaBin2Dec(); }

            Console.Write("\n\nDeseja continuar? (s/n):  ");
            string resposta = Console.ReadLine();

            Console.Clear();
            if (resposta == "n" || resposta == "N")
            {
                break;
            }
        }
    }
    #endregion

    #region Execução do Decimal para Binário
    public static void ProgramaDec2Bin()
    {
        List<int> restosLista = new List<int>();
        Console.Write("Numero em decimal: ");
        int dividendo = Convert.ToInt32(Console.ReadLine());
        while (true)
        {
            int resto = dividendo % 2;
            Linha(dividendo, resto);

            restosLista.Add(resto);
            dividendo = dividendo / 2;

            if (dividendo == 1) { restosLista.Add(1);  break; }
        }
        Linha(0, 1);
        restosLista.Reverse();
        foreach(int numero in restosLista)
        {
            Console.Write(numero);
        }
    }

    public static void Linha(int dividendo, int resto)
    {
        Console.WriteLine($"{dividendo} | {resto}");
    }
    #endregion

    #region Execução do Binário para Decimal
    public static void ProgramaBin2Dec()
    {
        double resultado = 0;
        Console.Write("Numero Binário: ");
        string binarioTxt = Console.ReadLine();

        for (int count=0; count < binarioTxt.Length; count++)
        {
            char bit = binarioTxt[count];
            int potencia = binarioTxt.Length - count - 1;

            if (bit == '1')
            {
                resultado += Math.Pow(2, potencia);
                LinhaBin2Dec(1, potencia);
            }
            else if (bit == '0')
            {
                LinhaBin2Dec(0, potencia);
            }
        }
        Console.WriteLine("\n\n" + resultado);
    }

    public static void LinhaBin2Dec(int bit, int potencia)
    {
        Console.WriteLine($"{bit} | 2^{potencia} | {Math.Pow(2, potencia) * bit}");
    }
    #endregion
}
