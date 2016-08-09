namespace Faker.Models
{
    using Faker.Models.Enums;

    public sealed class PersonModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EMail { get; set; }

        public string Company { get; set; }

        public Gender Gender { get; set; }
    }
}
