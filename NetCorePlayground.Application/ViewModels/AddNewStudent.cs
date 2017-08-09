using System;
using MediatR;

namespace NetCorePlayground.Application.ViewModels
{
    public class AddNewStudent : INotification
    {
        public AddNewStudent()
        {
        }

        public string FirstName
        {
            get;
            set;
        }
    }
}
