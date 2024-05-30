using MediatR;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.Mediator.Queries
{
    public class GetOrderingByIdQuery : IRequest<GetOrderingByIdQueryResult>
    {
        public GetOrderingByIdQuery(int id)
        {
            OrderingId = id;
        }

        public int OrderingId { get; set; }
    }
}
