// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using Grpc.Net.Client;
using GrpcServer;
using TrainingGrpcService;

namespace TrainingGrpcClient
{
    class program
    {
        static async Task Main(string[] args){

            var channel = GrpcChannel.ForAddress("http://localhost:5104");
            
            var employeeclient =  new Employee.EmployeeClient(channel);
            var employeeRequested = new EmployeeLookUpModel {EmployeeId = 2};
            var employee = await employeeclient.GetEmployeeInfoAsync(employeeRequested);
            
            Console.WriteLine($"Employee {employee.FirstName} {employee.LastName}. His training is {employee.TrainingProgress}, and working in {employee.Team} Team, working in {employee.Company} Company.");
            Console.WriteLine("Press any key to exit..."); 
            Console.ReadKey();
            // var channel = GrpcChannel.ForAddress("http://localhost:5104");
            // var client =  new Greeter.GreeterClient(channel);
            // var reply = await client.SayHelloAsync(
            // new HelloRequest { Name = "Swaminathan Vetri" });
            // Console.WriteLine("Greeting: " + reply.Message);
            // Console.WriteLine("Press any key to exit..."); 
            // Console.ReadKey();

        }

    }

}