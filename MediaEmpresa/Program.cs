using System;

class Program
{
    static void Main(string[] args)
    {
        PorcentagemEmpresas();
    }

    public static void PorcentagemEmpresas()
    {
        var faturamentoPorEstado = new List<Faturamento>
        {
            new Faturamento { Estado = "SP", Valor = 67836.43 },
            new Faturamento { Estado = "RJ", Valor = 36678.66 },
            new Faturamento { Estado = "MG", Valor = 29229.88 },
            new Faturamento { Estado = "ES", Valor = 27165.48 },
            new Faturamento { Estado = "Outros", Valor = 19849.53 }
        };

        double somaTotal = 0;
        foreach (var Fatura in faturamentoPorEstado)
        {
            somaTotal += Fatura.Valor;
        }

        foreach(var Fatura in faturamentoPorEstado)
        {
            var porcentagem = (Fatura.Valor / somaTotal) * 100;

            Console.WriteLine($"Estado: {Fatura.Estado}, Porcentagem: {porcentagem:F2}%");
        }
    }

    public class Faturamento
    {
        public string Estado { get; set; }
        public double Valor { get; set; }
    }
}
