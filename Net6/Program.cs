using BenchmarkDotNet.Running;
using Net6;

Console.WriteLine("Hello, World!");

BenchmarkRunner.Run<CustomerServiceBenchmark>();

//CustomerServiceBenchmark serviceBenchmark = new CustomerServiceBenchmark();

//serviceBenchmark.GetOldestCustomerUsingMin();
//serviceBenchmark.GetOldestCustomerUsingMInBy();
//serviceBenchmark.GetOldestCustomerUsingOrderBy();
