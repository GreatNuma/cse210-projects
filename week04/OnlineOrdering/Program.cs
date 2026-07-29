using System;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // ==================== ORDER 1 (USA Customer - $5 Shipping) ====================
            Address address1 = new Address("742 Evergreen Terrace", "Springfield", "OR", "USA");
            Customer customer1 = new Customer("Homer Simpson", address1);
            Order order1 = new Order(customer1);

            order1.AddProduct(new Product("Ergonomic Keyboard", "KBD-101", 65.00, 1));
            order1.AddProduct(new Product("Vertical Mouse", "MSE-202", 30.50, 2));

            // ==================== ORDER 2 (International Customer - $35 Shipping) ====================
            Address address2 = new Address("12 Ahmadu Bello Way", "Abuja", "FCT", "Nigeria");
            Customer customer2 = new Customer("Great Numa", address2);
            Order order2 = new Order(customer2);

            order2.AddProduct(new Product("27-inch 4K Monitor", "MON-303", 299.99, 1));
            order2.AddProduct(new Product("HDMI 2.1 Cable 6ft", "CBL-404", 12.50, 2));
            order2.AddProduct(new Product("USB-C Docking Station", "DCK-505", 85.00, 1));

            // ==================== DISPLAY RESULTS ====================
            Console.WriteLine("==================================================");
            Console.WriteLine("                   ORDER #1                       ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"\nTotal Order Price: ${order1.CalculateTotalCost():F2}\n");

            Console.WriteLine("==================================================");
            Console.WriteLine("                   ORDER #2                       ");
            Console.WriteLine("==================================================");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"\nTotal Order Price: ${order2.CalculateTotalCost():F2}\n");
        }
    }
}