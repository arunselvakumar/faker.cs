namespace Faker.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Faker.Models;

    public static class IEnumerableExtensions
    {
        public static Name Random(this IEnumerable<Name> enumerableNames)
        {
            var collection = enumerableNames.ToList();
            var randomNumber = new Random();

            if (!collection.Any())
            {
                throw new ArgumentOutOfRangeException();
            }

            return collection[randomNumber.Next(0, collection.Count())];
        }

        public static string Random(this IEnumerable<string> enumerableStrings)
        {
            var collection = enumerableStrings.ToList();
            var randomNumber = new Random();

            if (!collection.Any())
            {
                throw new ArgumentOutOfRangeException();
            }

            return collection[randomNumber.Next(0, collection.Count())];
        }
    }
}