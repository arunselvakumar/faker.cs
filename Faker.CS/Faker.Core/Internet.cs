namespace Faker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Faker.Extensions;
    using Faker.Helpers.ResourcesHelper;
    using Faker.Models;
    using Faker.Models.Enums;

    public static class Internet
    {
        #region Fields

        private static string urlPrefix;

        private static string alphaNumericChar;

        private static IEnumerable<PersonModel> persons;

        private static IEnumerable<string> freeEmail;

        private static IEnumerable<string> protocols;

        private static IEnumerable<string> domainSuffix;

        #endregion

        #region Constructor

        static Internet()
        {
            urlPrefix = @"http://";
            alphaNumericChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            freeEmail = new List<string> { "gmail", "yahoo", "hotmail", "rediffmail" };
            protocols = new List<string> { "RTPS", "SSH", "SMB", "FTP", "SMTP", "TCP", "Telnet", "HTTP", "HTTPs", "POP", "HTCPCP", "MTP", "SFTP", "SSL", "TLS", "E6", "NTP", "IMAP" };
            domainSuffix = new List<string> { "co.uk", "com", "us", "uk", "ca", "biz", "info" };

            persons = ResourcesHelper.GetPersonsList();
        }
        #endregion

        #region Public Methods

        public static string Url()
        {
            return $"{urlPrefix}.{DomainName()}.{DomainSuffix()}";
        }

        public static string DomainName()
        {
            return persons.Random().Company;
        }

        public static string DomainSuffix()
        {
            return domainSuffix.Random();
        }

        public static string Email(Gender gender = Gender.None)
        {
            switch (gender)
            {
                case Gender.None:
                    return persons.Random().EMail;
                case Gender.Male:
                    return persons.Where(person => person.Gender == Gender.Male).Random().EMail;
                case Gender.Female:
                    return persons.Where(person => person.Gender == Gender.Female).Random().EMail;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public static string FreeEmail(Gender gender = Gender.None, string seperator="_")
        {
            switch (gender)
            {
                case Gender.None:
                    {
                        var randomPerson = persons.Random();
                        var domain = freeEmail.Random();
                        return $"{randomPerson.FirstName.ToLower()}{seperator}{randomPerson.LastName.ToLower()}@{domain}.{DomainSuffix()}";
                    }
                case Gender.Male:
                    {
                        var randomPerson = persons.Where(person => person.Gender == Gender.Male).Random();
                        var domain = freeEmail.Random();
                        return $"{randomPerson.FirstName.ToLower()}{seperator}{randomPerson.LastName.ToLower()}@{domain}.{DomainSuffix()}";
                    }
                case Gender.Female:
                    {
                        var randomPerson = persons.Where(person => person.Gender == Gender.Female).Random();
                        var domain = freeEmail.Random();
                        return $"{randomPerson.FirstName.ToLower()}{seperator}{randomPerson.LastName.ToLower()}@{domain}.{DomainSuffix()}";
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(gender), gender, null);
            }
        }

        public static string UserName()
        {
            return persons.Random().FirstName.ToLowerInvariant();
        }

        public static string Protocol()
        {
            return protocols.Random();
        }

        public static string Password(int length = 8)
        {
            var random = new Random();
            return new string(Enumerable.Repeat(alphaNumericChar, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string IPv4Address()
        {
            var random = new Random();
            var min = 2;
            var max = 255;

            string[] parts =
                {
                    random.Next(min, max).ToString(), random.Next(min, max).ToString(),
                    random.Next(min, max).ToString(), random.Next(min, max).ToString()
                };

            return string.Join(".", parts);
        }

        public static string IPv6Address()
        {
            var random = new Random();
            var min = 0;
            var max = 65536;

            string[] parts =
                {
                    random.Next(min, max).ToString("x"), random.Next(min, max).ToString("x"),
                    random.Next(min, max).ToString("x"), random.Next(min, max).ToString("x"),
                    random.Next(min, max).ToString("x"), random.Next(min, max).ToString("x"),
                    random.Next(min, max).ToString("x"), random.Next(min, max).ToString("x")
                };

            return string.Join(":", parts);
        }

        #endregion
    }
}