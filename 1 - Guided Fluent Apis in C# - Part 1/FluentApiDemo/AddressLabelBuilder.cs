namespace FluentApiDemo
{
    public class AddressLabelBuilder : 
        INewAddress,
        IStreetAddressSelection,
        IPostalCodeSelection,
        ICitySelection,
        ICountrySelection,
        ICompleteAddress
    {
        private string _recipient;
        private string _addressLine1;
        private string _addressLine2;
        private string _postalCode;
        private string _city;
        private string _country = "South Africa";

        private AddressLabelBuilder() { }

        public static INewAddress NewAddress()
        {
            return new AddressLabelBuilder();
        }

        public IStreetAddressSelection ForRecipient(string recipient)
        {
            _recipient = recipient;
            return this;
        }

        public IPostalCodeSelection WithStreetAddress(string addressLine1, string addressLine2)
        {
            _addressLine1 = addressLine1;
            _addressLine2 = addressLine2;
            return this;
        }

        public ICitySelection WithPostalCode(string postalCode)
        {
            _postalCode = postalCode;
            return this;
        }

        public ICountrySelection InCity(string city)
        {
            _city = city;
            return this;
        }

        public ICompleteAddress InCountry(string country)
        {
            _country = country;
            return this;
        }

        public AddressLabel Build()
        {
            return new AddressLabel()
            {
                Recipient = _recipient,
                AddressLine1 = _addressLine1,
                AddressLine2 = _addressLine2,
                PostalCode = _postalCode,
                City = _city,
                Country = _country
            };
        }
    }
}