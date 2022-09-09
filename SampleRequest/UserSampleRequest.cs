using FluentValidationDemo.Models;
using Swashbuckle.AspNetCore.Filters;

namespace FluentValidationDemo.SampleRequest
{
    public class UserSampleRequest : IExamplesProvider<User>
    {
        public User GetExamples()
        {
            return new User
            {
                Name = "Ramadoss E",
                Email = "Ramadossrohit2264@gmail.com",
                Age = 31
            };
        }
    }
}
