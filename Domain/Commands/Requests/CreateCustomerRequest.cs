using Domain.Commands.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
