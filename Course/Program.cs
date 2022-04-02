using System;
using System.Globalization; // Biblioteca com a funcao de trocar a virgula para ponto
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    class Program {
        static void Main(string[] args) {
            string nome = Console.ReadLine();
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] vet = Console.ReadLine().Split(' ');
            string name = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("===================================================");
            Console.WriteLine(nome);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(name);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("===================================================");
        }
    }
}
