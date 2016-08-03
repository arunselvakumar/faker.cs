namespace Faker.Helpers.ResourcesHelper
{
    using System.IO;

    public static class ResourcesHelper
    {
        public static string GetNames()
        {
            using (var streamReader = new StreamReader("./Resources/Names.json"))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}