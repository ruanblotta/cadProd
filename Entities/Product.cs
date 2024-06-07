namespace cadProd.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

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

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProuct(int quantity)
        {
            Quantity -= quantity;
        }
        public void ListProduct()
        {

        }

        public void SearchProduct()
        {

        }

        public override string ToString()
        {
            return "ID: "
                + Id
                + " NOME: "
                + Name
                + " Valor: "
                + Price
                + ". "
                + Quantity
                + " unidades em estoque.";
        }
      
    }
}