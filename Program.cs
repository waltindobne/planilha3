using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace problema7
{
    class Program
    {
        static void Main(string[] args)
        {
            //este é um construtor
            Investimento investimento = new Investimento();
            investimento.CalcularMontante();
            investimento.CalcularRestante();
            investimento.MostrarTabela();
        }
    }

    public class Investimento
    {
        //propriedades
        public double capital;
        private double taxa;
        private double mes;
        private double dias;
        private double periodo;
        private double montante;
        private int numMes;
        private double retirada;
        private double restante;
        private double resgate;
        private double mesrestante;
        private double montantefinal;


        //construtores
        /*public Investimento()
        {
            capital = double.Parse(Console.ReadLine());
            taxa = double.Parse(Console.ReadLine())/100;
            mes = double.Parse(Console.ReadLine());
            periodo = mes+double.Parse(Console.ReadLine())/30;
            montante = capital * Math.Pow(1 + taxa, periodo);
            retirada = double.Parse(Console.ReadLine());
            restante = montante-retirada;
        }*/
        //metodo
        public void CalcularMontante()
        {
            Console.WriteLine("digite o capital aplicado: ");
            capital = double.Parse(Console.ReadLine());

            Console.Write("Digite a taxa aplicada (%): ");
            taxa = double.Parse(Console.ReadLine())/100;

            Console.WriteLine("Sua aplicação apresenta meses e dias? (se não apresentar dias digite zero nos dias): ");
            Console.WriteLine("digite quantos meses durara a aplição: ");
            mes = double.Parse(Console.ReadLine());
            
            Console.WriteLine("agora os dias: ");
            dias = double.Parse(Console.ReadLine());
            periodo = mes+(dias/30);

            montante = capital * Math.Pow(1 + taxa, periodo);
            resgate = capital * Math.Pow(1 + taxa, numMes);
        }
        //metodo
        public void CalcularRestante()
        {
            Console.WriteLine("Digite o numero do mes que havera resgate: (se não houver resgate digite 0) ");
            numMes = Convert.ToInt32(Console.ReadLine());
            if(numMes>0)
            {
                Console.WriteLine("digite o valor da retirada: ");
                retirada = double.Parse(Console.ReadLine());
                resgate = capital * Math.Pow(1 + taxa, numMes);
                restante = resgate-retirada;
                mesrestante = periodo-numMes;
                montantefinal = restante * Math.Pow(1 + taxa, mesrestante);
            }
        }
        //metodo
        public void MostrarTabela()
        {
            if(numMes==0)
            {
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| periodo total do invetimento            | {mes} meses e {dias} dias");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| montante final previsto (sem retirada)  | {montante:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| valor retirado no mes {numMes}                 | {retirada:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
            }
            if(numMes>0)
            {
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| periodo total do invetimento            | {mes} meses e {dias} dias");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| montante final previsto (sem retirada)  | {montante:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| montante acumulado do mes {numMes}             | {resgate:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| valor retirado no mes {numMes}                 | {retirada:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
                Console.WriteLine($"| saldo liquido da aplicação              | {montantefinal:C}");
                Console.WriteLine( "|---------------------------------------------------------------------|");
            }
        }
    }
    
}