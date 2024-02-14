using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiDemo
{
    public interface INewAddress
    {
        IStreetAddressSelection ForRecipient(string recipient);
        IBuildingNameSelection ForOfficeRecipient(string recipient);
    }

    public interface IBuildingNameSelection
    {
        IFloorNumberSelection InBuilding(string buildingName);
    }

    public interface IFloorNumberSelection
    {
        IStreetAddressSelection OnFloor(int floorNumber);
    }

    public interface IStreetAddressSelection
    {
        IPostalCodeSelection WithStreetAddress(string addressLine1, string addresssLine2);
    }

    public interface IPostalCodeSelection
    {
        ICitySelection WithPostalCode(string postalCode);
    }

    public interface ICitySelection
    {
        ICountrySelection InCity(string city);
    }

    public interface ICountrySelection : ICompleteAddress
    {
        ICompleteAddress InCountry(string country);
    }

    public interface ICompleteAddress
    {
        AddressLabel Build();
        AddressLabel Build(Action<PrintingConfiguration> printingConfig);
    }
}
