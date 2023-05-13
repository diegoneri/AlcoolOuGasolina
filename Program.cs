// See https://aka.ms/new-console-template for more information
const double PercentualGasolinaValeAPena = 0.73;

decimal ValorGasolina, ValorEtanol, RazaoEtanolGasolina;
string CombustivelVantajoso;

Func<decimal, decimal, decimal> ObterRazaoEtanolGasolina 
= (decimal ValorEtanol, decimal ValorGasolina) => ValorEtanol / ValorGasolina;

Func<decimal, bool> CalcularSeValeAPenaComGasolina 
= (decimal RazaoEtanolGasolina) => RazaoEtanolGasolina > (decimal) PercentualGasolinaValeAPena;

Console.WriteLine("--- Etanol ou Gasolina? ---\n");
Console.Write("Digite o preço do etanol (R$).....: ");
Decimal.TryParse(Console.ReadLine(), out ValorEtanol);

Console.Write("Digite o preço da gasolina (R$)...: ");
Decimal.TryParse(Console.ReadLine(), out ValorGasolina);

RazaoEtanolGasolina = ObterRazaoEtanolGasolina(ValorEtanol, ValorGasolina);

CombustivelVantajoso = CalcularSeValeAPenaComGasolina(RazaoEtanolGasolina) ? "GASOLINA" : "ETANOL";

Console.WriteLine($"\nO preço do etanol corresponde a {RazaoEtanolGasolina*100:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {CombustivelVantajoso}.");
