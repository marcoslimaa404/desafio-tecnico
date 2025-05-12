public static class Desafio1_Soma
{
    public static void Executar()
    {
        const int Indice = 13;
        int soma = 0;
        for (int k = 1; k <= Indice; k++)
            soma += k;
        Console.WriteLine($"Soma de 1 até {Indice} = {soma}");
    }
}