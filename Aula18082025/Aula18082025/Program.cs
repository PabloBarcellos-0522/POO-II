using Aula18082025.Aeroporto;

namespace Aula18082025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício Aeroporto

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


            //Gestão de pessoas IBGE

            int idade;
            List<int> idades = [];

            do
            {
                idade = int.Parse(Console.ReadLine());
                if (idade > 0)
                    idades.Add(idade);
            }
            while (idade > 0);
        }
    }
}
