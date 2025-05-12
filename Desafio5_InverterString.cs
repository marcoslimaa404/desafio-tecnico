public static class Desafio5_InverterString
{
    public static string Executar(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return texto;

        var caracteres = new char[texto.Length];
        for (int i = 0; i < texto.Length; i++)
            caracteres[i] = texto[texto.Length - 1 - i];

        return new string(caracteres);
    }
}