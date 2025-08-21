using Aula18082025.Aeroporto;

namespace Aula18082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício Aeroporto

            Airport a1 = new();
            Airport a2 = new();


            FliyngTransport ft1 = new Gryphon(a1);
            FliyngTransport ft2 = new Helicopter(a1);
            FliyngTransport ft3 = new Airplane(a1);

            ft1.Fly(a2, 100);
            ft1.EuSou();
            Console.WriteLine(a2.Transportes[0]);

            ft1.Fly(a1, 100);
            a1.Transportes[0].EuSou();
            Console.WriteLine("\n\n\n");


            // Gestão de pessoas IBGE
            string idade;
            List<int> idades = [];
            do
            {
                idade = Console.ReadLine() ?? string.Empty;
                if (int.Parse(idade) > 0)
                    idades.Add(int.Parse(idade));
            }
            while (int.Parse(idade) > 0 || idade == "");

            Console.WriteLine($"Faixa A: {Math.Round(IdadeAgrupada(1, 15, idades))}");
            Console.WriteLine($"Faixa B: {Math.Round(IdadeAgrupada(16, 30, idades))}");
            Console.WriteLine($"Faixa C: {Math.Round(IdadeAgrupada(31, 45, idades))}");
            Console.WriteLine($"Faixa D: {Math.Round(IdadeAgrupada(46, 60, idades))}");
            Console.WriteLine($"Faixa E: {Math.Round(IdadeAgrupada(61, 999, idades))}\n\n");



            // Verão Capixaba 01

            Console.WriteLine("Escolha a conversão:");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Fahrenheit para Celsius");
            Console.WriteLine("3 - Celsius para Kelvin");
            Console.WriteLine("4 - Kelvin para Celsius");

            Console.Write("Opção: ");
            int opcao = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.Write("Digite a temperatura: ");
            double temp = double.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine(ConverterTemp(opcao, temp));

            Console.WriteLine("\n\n");



            // Verão Capixaba - Média de Temperaturas
            const int DIAS = 15;
            double soma = 0;
            double temperatura;

            for (int i = 1; i <= DIAS; i++)
            {
                while (true)
                {
                    Console.Write($"Digite a temperatura do dia {i}: ");
                    temperatura = double.Parse(Console.ReadLine() ?? string.Empty);

                    if (temperatura > 28)
                    {
                        soma += temperatura;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Temperatura inválida! No verão capixaba deve ser acima de 28 °C.");
                    }
                }
            }

            double media = soma / DIAS;
            Console.WriteLine($"\nA temperatura média no verão capixaba foi: {Math.Round(media)} °C");



        }

        public static double IdadeAgrupada(int idadeI, int idadeF, List<int> lista)
        {
            double quantidade = 0;
            foreach (var item in lista)
            {
                if (item >= idadeI && item <= idadeF)
                {
                    quantidade++;
                }
            }
            return (quantidade / lista.Count) * 100;
        }

        public static string ConverterTemp(int opcao, double temp)
        {
            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    // Celsius para Fahrenheit
                    resultado = (temp * 9 / 5) + 32;
                    return ($"{temp} °C = {resultado} °F");
                case 2:
                    // Fahrenheit para Celsius
                    resultado = (temp - 32) * 5 / 9;
                    return ($"{temp} °F = {resultado} °C");

                case 3:
                    // Celsius para Kelvin
                    resultado = temp + 273.15;
                    return ($"{temp} °C = {resultado} K");

                case 4:
                    // Kelvin para Celsius
                    resultado = temp - 273.15;
                    return ($"{temp} K = {resultado} °C");

                default:
                    return ("Opção inválida!");
            }
        }
    }
}
