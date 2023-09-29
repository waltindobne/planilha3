using System;
using System.ComponentModel.DataAnnotations.Schema;

class Investimento
{
    static public double c;
    static public double i;
    static public double n;
    static public double d;
    static public int ano;
    static public System.DateTime datainicio;
    static void Main()
    {
        
        Console.Write("Digite o capital aplicado: ");
        Investimento.c = double.Parse(Console.ReadLine());
        Console.Write("Digite a taxa aplicada (%): ");
        Investimento.i = double.Parse(Console.ReadLine());
        i = i/100;
        Console.WriteLine("Sua aplicação apresenta meses e dias? (se não apresentar dias digite zero nos dias): ");
        Console.WriteLine("digite quantos meses durara a aplição: ");
        Investimento.n = double.Parse(Console.ReadLine());
        Console.WriteLine("agora os dias: ");
        Investimento.d = double.Parse(Console.ReadLine());
        Console.WriteLine("em qual mes começou a aplicação: ");
        n = n*30+d;
        n = n/30;
        double m = c * Math.Pow((1 + i), n);
        Console.WriteLine($"O rendimento futuro é: {m:C}");
    }
}
