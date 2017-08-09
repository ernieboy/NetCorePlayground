using System;
using System.Threading.Tasks;
using MediatR;
using NetCorePlayground.Application.ViewModels;

namespace NetCorePlayground.Application.CommandHandlers
{
    public class AddNewStudentHandler : IAsyncNotificationHandler<AddNewStudent>
    {
        public AddNewStudentHandler()
        {
            
        }

        public Task Handle(AddNewStudent notification)
        {
            throw new NotImplementedException();
        }
    }
}
