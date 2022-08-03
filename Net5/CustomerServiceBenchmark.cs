using BenchmarkDotNet.Attributes;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5
{
    public class CustomerServiceBenchmark
    {
        private readonly List<Customer> _customers;

        public CustomerServiceBenchmark()
        {
            var customerFaker = new Faker<Customer>()
                .RuleFor(x => x.Id, faker => faker.IndexFaker)
                .RuleFor(x => x.FullName, faker => faker.Person.FullName)
                .RuleFor(x => x.Email, faker => faker.Person.Email)
                .RuleFor(x => x.DateOfBirth, faker => faker.Person.DateOfBirth);

            _customers = customerFaker.Generate(1000000);
        }

        [Benchmark]
        public Customer GetOldestCustomerUsingMin()
        {
            DateTime earliestDate = _customers.Min(x => x.DateOfBirth);

            Customer oldestCustomer = _customers.First(x => x.DateOfBirth == earliestDate);

            return oldestCustomer;
        }

        [Benchmark]
        public Customer GetOldestCustomerUsingOrderBy()
        {
            Customer customer = _customers.OrderBy(x => x.DateOfBirth).First();

            return customer;
        }
    }
}
