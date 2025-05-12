public static class Desafio2_Fibonacci
{
    public static void Executar(int numero)
    {
        int a = 0, b = 1;
        while (a < numero)
        {
            checked
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
        }
        Console.WriteLine(a == numero
            ? $"{numero} pertence à sequência de Fibonacci."
            : $"{numero} não pertence à sequência.");
    }
}