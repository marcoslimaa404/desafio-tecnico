using System.Text.Json;

public static class Desafio3_JsonFaturamento
{
    public static void Executar()
    {
        try
        {
            string jsonPath = "dados.json";
            string jsonContent = File.ReadAllText(jsonPath);
            var dados = JsonSerializer.Deserialize<List<Dado>>(jsonContent);

            var diasValidos = dados!.Where(d => d.Valor > 0).ToList();
            if (!diasValidos.Any())
            {
                Console.WriteLine("Nenhum dia com faturamento registrado.");
                return;
            }

            double menor = diasValidos.Min(d => d.Valor);
            double maior = diasValidos.Max(d => d.Valor);
            double media = diasValidos.Average(d => d.Valor);
            int diasAcimaMedia = diasValidos.Count(d => d.Valor > media);

            Console.WriteLine($"Menor faturamento: {menor:F2}");
            Console.WriteLine($"Maior faturamento: {maior:F2}");
            Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao processar JSON: {ex.Message}");
        }
    }
}