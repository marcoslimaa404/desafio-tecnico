using System;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nEscolha um desafio para executar:");
            Console.WriteLine("1 - Soma até índice");
            Console.WriteLine("2 - Verificar número na sequência de Fibonacci");
            Console.WriteLine("3 - Analisar faturamento (JSON)");
            Console.WriteLine("4 - Calcular percentual por estado");
            Console.WriteLine("5 - Inverter string");
            Console.WriteLine("0 - Sair");
            Console.Write("Opção: ");

            string opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Desafio1_Soma.Executar();
                    break;
                case "2":
                    Console.Write("Digite um número para verificar na sequência de Fibonacci: ");
                    if (int.TryParse(Console.ReadLine(), out int numero))
                        Desafio2_Fibonacci.Executar(numero);
                    else
                        Console.WriteLine("Número inválido.");
                    break;
                case "3":
                    Desafio3_JsonFaturamento.Executar();
                    break;
                case "4":
                    Desafio4_PercentualEstados.Executar();
                    break;
                case "5":
                    Console.Write("Digite a string a ser invertida: ");
                    string texto = Console.ReadLine();
                    Console.WriteLine("Invertida: " + Desafio5_InverterString.Executar(texto));
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}