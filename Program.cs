using System;
using cadProd.Entities;

namespace cadProd
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program para Adicionar, Listar e Buscar Produtos em um Estoque");
            Console.Write("Digite o Id do Produto: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Digite o Nome do Produto: ");
            string name = Console.ReadLine();
            Console.Write("Digite o Preço do Produto: ");
            double price = double.Parse(Console.ReadLine());
            Console.Write("Digite a Quantidade que iremos adicionar: ");
            int quantity = int.Parse(Console.ReadLine());

            Product prod = new Product(id, name, price, quantity);
            prod.AddProduct(quantity);

            Console.WriteLine("Estoque Atualizado!");
            Console.WriteLine(prod);


        }
    }
}