using System;
using System.IO;
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
			File.AppendAllText("handlers.log", "SaveNewStudentHandler");
			return Task.CompletedTask;
        }
    }
}
