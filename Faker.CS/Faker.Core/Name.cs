namespace Faker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Faker.Extensions;
    using Faker.Helpers.ResourcesHelper;
    using Faker.Models;
    using Faker.Models.Enums;

    public static class Name
    {
        #region Fields

        private static IEnumerable<PersonModel> persons;

        private static IEnumerable<string> prefix;

        private static IEnumerable<string> suffix;

        #endregion

        #region Constructor

        static Name()
        {
            prefix = new List<string> { "Mr", "Mrs", "Ms", "Miss", "Dr" };
            suffix = new List<string> { "Jr.", "Sr.", "I", "II", "III", "IV", "V", "MD", "DDS", "PhD", "DVM" };

            persons = ResourcesHelper.GetPersonsList();
        }
        #endregion

        #region Public Methods

        public static string FirstName(Gender gender = Gender.None)
        {
            switch (gender)
            {
                case Gender.None:
                    return persons.Random().FirstName;
                case Gender.Male:
                    return persons.Where(person => person.Gender == Gender.Male).Random().FirstName;
                case Gender.Female:
                    return persons.Where(person => person.Gender == Gender.Female).Random().FirstName;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public static string LastName(Gender gender = Gender.None)
        {
            switch (gender)
            {
                case Gender.None:
                    return persons.Random().LastName;
                case Gender.Male:
                    return persons.Where(person => person.Gender == Gender.Male).Random().LastName;
                case Gender.Female:
                    return persons.Where(person => person.Gender == Gender.Female).Random().LastName;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public static string FullName(Gender gender = Gender.None)
        {
            switch (gender)
            {
                case Gender.None:
                    {
                        var name = persons.Random();
                        return string.Join(" ", name.FirstName, name.LastName);
                    }

                case Gender.Male:
                    {
                        var name = persons.Where(person => person.Gender == Gender.Male).Random();
                        return string.Join(" ", name.FirstName, name.LastName);
                    }

                case Gender.Female:
                    {
                        var name = persons.Where(person => person.Gender == Gender.Female).Random();
                        return string.Join(" ", name.FirstName, name.LastName);
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public static string Prefix()
        {
            return prefix.Random();
        }

        public static string Suffix()
        {
            return suffix.Random();
        }

        #endregion
    }
}