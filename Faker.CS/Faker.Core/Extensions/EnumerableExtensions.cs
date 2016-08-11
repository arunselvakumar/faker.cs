namespace Faker.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Faker.Models;

    public static class EnumerableExtensions
    {
        public static PersonModel Random(this IEnumerable<PersonModel> enumerablePersons)
        {
            var collection = enumerablePersons.ToList();

            if (!collection.Any())
            {
                throw new ArgumentOutOfRangeException();
            }

            return collection[RandomNumber.Next(0, collection.Count())];
        }

        public static AddressModel Random(this IEnumerable<AddressModel> enumerableAddresses)
        {
            var collection = enumerableAddresses.ToList();

            if (!collection.Any())
            {
                throw new ArgumentOutOfRangeException();
            }

            return collection[RandomNumber.Next(0, collection.Count())];
        }

        public static string Random(this IEnumerable<string> enumerableStrings)
        {
            var collection = enumerableStrings.ToList();

            if (!collection.Any())
            {
                throw new ArgumentOutOfRangeException();
            }

            return collection[RandomNumber.Next(0, collection.Count())];
        }
    }
}