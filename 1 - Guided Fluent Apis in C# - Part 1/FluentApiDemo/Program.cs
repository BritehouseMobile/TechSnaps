using System.Diagnostics;

namespace FluentApiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = AddressLabelBuilder
                .NewAddress()
                .ForRecipient("ItsAMe Mario")
                .WithStreetAddress("123 Street", "My Suburb")
                .WithPostalCode("2192")
                .InCity("Johannesburg")
                .InCountry("South Africa")
                .Build();

            Debugger.Break();
        }
    }
}