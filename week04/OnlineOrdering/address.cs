namespace OnlineOrdering
{
    // The Address class encapsulates location attributes and logic
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;
        }

        // Returns true if country is USA (case-insensitive check)
        public bool IsUSA()
        {
            string countryClean = _country.Trim().ToLower();
            return countryClean == "usa" || countryClean == "united states" || countryClean == "united states of america";
        }

        // Formats all address fields into a single multi-line string
        public string GetFormattedAddress()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }
    }
}