using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Insira aqui as regras de Negócio

            var result =  new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
