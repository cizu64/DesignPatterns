using MediatR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorMediatr.MediatorMediatr
{
    public class CreateCustomerHandler : INotificationHandler<CreateCustomer>
    {
        public async Task Handle(CreateCustomer notification, CancellationToken cancellationToken)
        {
            string result = JsonConvert.SerializeObject(notification);
            Console.WriteLine(result);
        }

    }
}
