namespace OnlineOrdering
{
    // The Product class tracks pricing metrics and calculates total item cost
    public class Product
    {
        private string _name;
        private string _productId;
        private double _price;
        private int _quantity;

        public Product(string name, string productId, double price, int quantity)
        {
            _name = name;
            _productId = productId;
            _price = price;
            _quantity = quantity;
        }

        // Required method: Calculates total cost for this product (price * quantity)
        public double CalculateTotalCost()
        {
            return _price * _quantity;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetProductId()
        {
            return _productId;
        }
    }
}