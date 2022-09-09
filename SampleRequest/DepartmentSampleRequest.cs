using FluentValidationDemo.Models;
using Swashbuckle.AspNetCore.Filters;

namespace FluentValidationDemo.SampleRequest
{
    public class DepartmentSampleRequest : IExamplesProvider<Department>
    {
        public Department GetExamples()
        {
            return new Department
            {
                id = 1,
                Name = "IT"
            };
        }
    }
}
