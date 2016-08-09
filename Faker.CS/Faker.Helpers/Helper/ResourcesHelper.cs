namespace Faker.Helpers.ResourcesHelper
{
    using System.Collections.Generic;
    using System.IO;

    using Faker.Models;

    using Newtonsoft.Json;

    public static class ResourcesHelper
    {
        public static List<PersonModel> GetPersonsList()
        {
            using (var streamReader = new StreamReader("./Resources/Names.json"))
            {
                var streamInfo = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<PersonModel>>(streamInfo);
            }
        }

        public static List<AddressModel> GetAddressList()
        {
            using (var streamReader = new StreamReader("./Resources/Addresses.json"))
            {
                var streamInfo = streamReader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<AddressModel>>(streamInfo);
            }
        }
    }
}