namespace Faker
{
    using System.Collections.Generic;

    using Faker.Extensions;
    using Faker.Helpers;
    using Faker.Models;

    /// <summary>
    /// The address.
    /// </summary>
    public static class Address
    {
        #region Fields

        private static IEnumerable<AddressModel> addresses;

        #endregion

        #region Constructor

        static Address()
        {
            addresses = ResourcesHelper.GetAddressList();
        }
        #endregion

        #region Public Methods

        public static string StreetName()
        {
            return addresses.Random().StreetName;
        }

        public static string City()
        {
            return addresses.Random().City;
        }

        public static string State()
        {
            return addresses.Random().State;
        }

        public static string Phone()
        {
            return addresses.Random().Phone;
        }

        public static double Latitude()
        {
            return addresses.Random().Latitude;
        }

        public static double Longitude()
        {
            return addresses.Random().Longitude;
        }

        public static string StreetAddress()
        {
            return $"{RandomNumber.Next()}, {StreetName()}";
        }
        #endregion
    }
}