namespace cadProd.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        private static List<Product> products { get; set; } = new List<Product>();

        public Product()
        {
        }

        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        
        public void AddProduct(Product product)
        {
            products.Add(product);
        }
      
        public static List<Product> ListProduct()
        {
            return products;
        }

        public static Product SearchProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }

        public static bool RemoveProduct(int id)
        {
            var product = SearchProductById(id);
            return product != null ? products.Remove(product) : false;
        }
        public override string ToString()
        {
            return $"ID:({Id})"
                + " -- NOME: "
                + Name
                + " -- Valor unidade R$: "
                + Price
                + " -- "
                + Quantity
                + " unidades em estoque.";
        }
      
    }
}