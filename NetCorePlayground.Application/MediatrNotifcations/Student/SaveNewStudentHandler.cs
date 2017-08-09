using System.IO;
using System.Threading.Tasks;
using MediatR;
using NetCorePlayground.Domain.AggregateRoots.StudentAggregate;

namespace NetCorePlayground.Application.MediatrNotifcations.Student
{
    public class SaveNewStudentHandler : IAsyncNotificationHandler<NewStudentAddedNotification>
    {
        private IStudentRepository _studentRepository;

        public SaveNewStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Task Handle(NewStudentAddedNotification notification)
        {
			File.AppendAllText("handlers.log", "SaveNewStudentHandler");
			return Task.CompletedTask;
        }
    }
}
