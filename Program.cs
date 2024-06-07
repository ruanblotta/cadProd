using System;
using cadProd.Entities;

namespace cadProd
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Product> prod = new List<Product>();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. Adicionar produtos ao estoque.");
                Console.WriteLine("2. Listar todos os produtos do estoque.");
                Console.WriteLine("3. Buscar produtos pelo Id.");
                Console.WriteLine("4. Remover Produto do estoque.");
                Console.WriteLine("5. Sair.");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Quantos produtos deseja adicionar ao estoque? ");
                        int x = int.Parse(Console.ReadLine());
                        for (int i = 0; i < x; i++)
                        {
                            Console.Write("Digite o Id do Produto: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.Write("Digite o Nome do Produto: ");
                            string name = Console.ReadLine();
                            Console.Write("Digite o Preço do Produto: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Digite a Quantidade que iremos adicionar: ");
                            int quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------");
                            prod.Add(new Product(id, name, price, quantity));
                        }
                        break;
                    case 2:
                        foreach (var p in prod)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Digite uma opção válida.");
                        break;
                }
            }
        }
    }
}