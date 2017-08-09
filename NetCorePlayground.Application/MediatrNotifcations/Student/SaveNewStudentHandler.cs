using System;
using System.Threading.Tasks;
using MediatR;

namespace NetCorePlayground.Application.MediatrNotifcations.Student
{
    public class SaveNewStudentHandler : IAsyncNotificationHandler<NewStudentAddedNotification>
    {
        public SaveNewStudentHandler()
        {
        }

        public Task Handle(NewStudentAddedNotification notification)
        {
            throw new NotImplementedException();
        }
    }
}
