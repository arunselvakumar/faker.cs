namespace Faker
{
    using System;

    public class Internet
    {
        #region Public Methods

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