using System;
using GrpcServer;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Grpc.Core;

namespace TrainingGrpcService.Services
{
    public class EmployeeService : Employee.EmployeeBase
    {
        private readonly ILogger<EmployeeService> _logger;
        public EmployeeService(ILogger<EmployeeService> logger){
            _logger = logger;
        }

        public override Task<EmployeeModel> GetEmployeeInfo(EmployeeLookUpModel request, ServerCallContext context){
            
            // return base.GetEmployeeInfo(request,context);

            EmployeeModel output = new EmployeeModel();

            if(request.EmployeeId == 1){
                output.FirstName = "Prathmesh";
                output.LastName = "Ghate";
                output.Company = "Carwale";
                output.TrainingProgress = "In Progress";
                output.Team = "Not assigned";
            }
            else if(request.EmployeeId == 2){
                output.FirstName = "Sourav";
                output.LastName = "Kumar";
                output.Company = "Carwale";
                output.TrainingProgress = "In Progress";
                output.Team = "Not assigned";
            }
            else if(request.EmployeeId == 3){
                output.FirstName = "Shridhar";
                output.LastName = "Kaluke";
                output.Company = "Carwale";
                output.TrainingProgress = "Completed";
                output.Team = "Platform - Cartrade";
            }

            return Task.FromResult(output);
        }
    }
}