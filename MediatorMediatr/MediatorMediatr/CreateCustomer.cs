using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorMediatr.MediatorMediatr
{
    public class CreateCustomer : INotification
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Email { get; private set; }

        public CreateCustomer(string firstname, string lastname, string email)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
        }
    }
}
