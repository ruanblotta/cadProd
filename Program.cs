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
                Console.WriteLine();
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
                            Console.Write("Digite o Preço unitário: ");
                            double price = double.Parse(Console.ReadLine());
                            Console.Write("Digite a Quantidade que iremos adicionar: ");
                            int quantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("---------------------");
                            Product product = new Product(id, name, price, quantity);
                            prod.Add(product);
                            product.AddProduct(product);
                        }
                        break;
                    case 2:
                        Console.WriteLine("--- Estoque --- ");
                        foreach (var prodd in prod)
                        {
                            Console.WriteLine(prodd);
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.Write("Digite o código de Id do produto: ");
                        int searchId = int.Parse(Console.ReadLine());
                        Product findProduct = Product.SearchProductById(searchId);
                        if (findProduct != null)
                        {
                            Console.Write(findProduct);
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Produto não encontrado");
                        }
                        break;
                    case 4:
                        Console.Write("Digite o código de Id do produto: ");
                        searchId = int.Parse(Console.ReadLine());
                        if (Product.RemoveProduct(searchId))
                        {
                            Console.WriteLine("Produto removido do estoque.");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Produto não encontrado");
                        }
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opção Inválida. Digite uma opção válida.");
                        break;
                }
            }
        }
    }
}