using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using Faker.Models.Enums;

    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Faker.Name.FullName();
            Console.WriteLine(firstName);

            firstName = Faker.Name.FullName(Gender.Male);
            Console.WriteLine(firstName);

            firstName = Faker.Name.FullName(Gender.Female);
            Console.WriteLine(firstName);

            Console.ReadLine();
        }
    }
}
