using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {
        static void Main(string[] args)
        {
            Faker.Name.FirstName();
            var firstName = Faker.Lorem.Words();

            Console.WriteLine(firstName);

            firstName = Faker.Lorem.Words();

            Console.WriteLine(firstName);

            firstName = Faker.Lorem.Words();

            Console.WriteLine(firstName);

            firstName = Faker.Lorem.Words();

            Console.WriteLine(firstName);

            firstName = Faker.Lorem.Words();

            Console.WriteLine(firstName);

            Console.ReadLine();
        }
    }
}
