using BenchmarkDotNet.Running;
using System;

namespace Net5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<CustomerServiceBenchmark>();

            //CustomerServiceBenchmark serviceBenchmark = new CustomerServiceBenchmark();

            //serviceBenchmark.GetOldestCustomerUsingMin();
            //serviceBenchmark.GetOldestCustomerUsingOrderBy();
        }
    }
}
