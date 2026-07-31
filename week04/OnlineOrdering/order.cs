using System.Collections.Generic;

namespace OnlineOrdering
{
    // This Order class manages product lists, calculates shipping fees, and generates labels
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        // Required method: Calculates sum of all product costs plus one-time shipping fee
        public double CalculateTotalCost()
        {
            double totalProductCost = 0.0;
            foreach (Product product in _products)
            {
                totalProductCost += product.CalculateTotalCost();
            }

            // Shipping cost: $5 for USA customers, $35 for international customers
            double shippingCost = _customer.LivesInUSA() ? 5.0 : 35.0;
            return totalProductCost + shippingCost;
        }

        // Required method: Generates a packing label with name and product ID
        public string GetPackingLabel()
        {
            string label = "--- PACKING LABEL ---\n";
            foreach (Product product in _products)
            {
                label += $"[ID: {product.GetProductId()}] {product.GetName()}\n";
            }
            return label;
        }

        // Required method: Generates a shipping label with customer name and address
        public string GetShippingLabel()
        {
            string label = "--- SHIPPING LABEL ---\n";
            label += $"Name: {_customer.GetName()}\n";
            label += _customer.GetAddress().GetFormattedAddress();
            return label;
        }
    }
}