public static class Desafio4_PercentualEstados
{
    public static void Executar()
    {
        var faturamentos = new Dictionary<string, double>
        {
            ["SP"] = 67836.43,
            ["RJ"] = 36678.66,
            ["MG"] = 29229.88,
            ["ES"] = 27165.48,
            ["Outros"] = 19849.53
        };

        double total = faturamentos.Values.Sum();

        foreach (var (estado, valor) in faturamentos)
        {
            double percentual = (valor / total) * 100;
            Console.WriteLine($"{estado}: {percentual:F2}%");
        }
    }
}