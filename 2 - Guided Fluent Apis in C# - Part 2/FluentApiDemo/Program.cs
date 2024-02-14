using System.Diagnostics;

namespace FluentApiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = AddressLabelBuilder
                .NewAddress()
                .ForOfficeRecipient("Me")
                .InBuilding("Augusta Building")
                .OnFloor(2)
                .WithStreetAddress("123 Street", "My Suburb")
                .WithPostalCode("2192")
                .InCity("Johannesburg")
                .InCountry("South Africa")
                .Build(config => 
                {
                    config.Copies = 2;
                    config.RightAligned = true;

                });

            Debugger.Break();
        }
    }
}