namespace Faker
{
    using System.Collections.Generic;
    using System.Text;

    using Faker.Extensions;

    public static class Lorem
    {
        #region Fields

        private static IEnumerable<string> lorem;

        #endregion

        #region Constructor

        static Lorem()
        {
            lorem = new List<string>
                        {
                            "lorem", "ipsum", "dolor", "sit", "amet", "consectetuer",
                            "adipiscing", "elit", "sed", "diam", "nonummy", "nibh",
                            "euismod", "tincidunt", "ut", "laoreet", "dolore", "magna"
                        };
        }
        #endregion

        #region Public Methods

        public static string Word()
        {
            return lorem.Random();
        }

        public static string Words(int length = 9)
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                stringBuilder.AppendFormat($"{Word()} ");
            }
            return stringBuilder.ToString();
        }

        public static string Sentences(int length = 9)
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                stringBuilder.AppendFormat($"  {Words(RandomNumber.Next(5, 25))}.");
            }
            return stringBuilder.ToString();
        }

        public static string Paragraph(int length = 9)
        {
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                stringBuilder.AppendLine(Sentences());
            }
            return stringBuilder.ToString();
        }

        #endregion
    }
}