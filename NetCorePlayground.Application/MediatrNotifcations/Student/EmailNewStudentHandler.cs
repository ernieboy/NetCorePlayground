using System;
using System.IO;
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
            File.AppendAllText("handlers.log", "EmailNewStudentHandler");
            return Task.CompletedTask;
        }
    }
}
