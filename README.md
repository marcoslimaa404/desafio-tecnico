# Desafio Técnico — C#

[![CSharp](https://img.shields.io/badge/C%23-.NET%207-blue?logo=c-sharp&logoColor=white)](https://learn.microsoft.com/pt-br/dotnet/)
[![Plataforma](https://img.shields.io/badge/Plataforma-Android%20Mobile-orange?logo=android)]()
[![Editor](https://img.shields.io/badge/Editor-Acode-informational?logo=visualstudiocode)]()
[![Executado no Termux](https://img.shields.io/badge/Execucao-Termux-000000?logo=linux)]()
[![Licença](https://img.shields.io/badge/Licença-MIT-green)](LICENSE)

Este repositório contém a resolução de um desafio técnico para uma vaga de Desenvolvedor, utilizando exclusivamente um celular Android.

## Ambiente de desenvolvimento

O projeto foi inteiramente desenvolvido no mobile, para isso utilizei:

- **Editor de código:** [Acode](https://play.google.com/store/apps/details?id=com.foxdebug.acode)
- **Execução:** [Termux](https://f-droid.org/en/packages/com.termux/) com .NET SDK instalado via CLI  
- **Linguagem:** C# (.NET 7)

## Estrutura do projeto

Cada desafio foi implementado em um arquivo separado, facilitando a leitura e execução individual:

```
desafio-tecnico-csharp/
├── Desafio1_Soma.cs              # Soma incremental de 1 até 13
├── Desafio2_Fibonacci.cs         # Verifica se um número pertence à sequência de Fibonacci
├── Desafio3_JsonFaturamento.cs   # Análise de faturamento diário a partir de um arquivo JSON
├── Desafio4_PercentualEstados.cs # Cálculo de percentual de faturamento por estado
├── Desafio5_InverterString.cs    # Inversão manual de string sem uso de métodos prontos
└── Program.cs                    # Interface interativa para escolher qual desafio executar
```

## Duração do desenvolvimento

Do desenvolvimento à entrega: 20 minutos.

## Como executar

1. Clone o repositório:
```bash
   git clone https://github.com/marcoslimaa404/desafio-tecnico.git
   cd desafio-tecnico
```

2. Compile e execute com o SDK .NET:
```
   dotnet run
```

## Licença

Este projeto está licenciado sob os termos da licença MIT.
