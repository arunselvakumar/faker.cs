namespace Faker.Extensions
{
    using System;

    public static class RandomNumber
    {
        #region Fields

        private static Random random = new Random();
        #endregion

        #region Public Methods

        public static void ResetSeed(int seed)
        {
            random = new Random(seed);
        }

        public static int Next()
        {
            return random.Next();
        }

        public static int Next(int max)
        {
            return random.Next(max);
        }

        public static int Next(int min, int max)
        {
            return random.Next(min, max);
        }
        #endregion
    }
}