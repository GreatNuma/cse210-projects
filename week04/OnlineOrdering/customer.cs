namespace OnlineOrdering
{
    // This Customer class encapsulates customer details and delegates address checks
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        // Required method: Delegates the check directly to the Address method
        public bool LivesInUSA()
        {
            return _address.IsUSA();
        }

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }
    }
}