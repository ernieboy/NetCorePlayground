using System;
using System.Threading.Tasks;
using MediatR;

namespace NetCorePlayground.Application.MediatrNotifcations.Student
{
    public class EmailNewStudentHandler : IAsyncNotificationHandler<NewStudentAddedNotification>
    {
        public EmailNewStudentHandler()
        {
        }

        public Task Handle(NewStudentAddedNotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
