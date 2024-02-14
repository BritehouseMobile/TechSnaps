namespace FluentApiDemo
{
    public class AddressLabel
    {
        public string Recipient { get; internal set; }
        public string AddressLine1 { get; internal set; }
        public string AddressLine2 { get; internal set; }
        public string PostalCode { get; internal set; }
        public string City { get; internal set; }
        public string Country { get; internal set; }

        /// <summary>
        /// Can only be constructed internally.
        /// </summary>
        internal AddressLabel() { }
    }
}
