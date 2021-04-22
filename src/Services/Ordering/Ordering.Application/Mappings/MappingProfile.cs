using AutoMapper;
using Ordering.Application.Features.Orders.Commands.CheckoutOrder;
using Ordering.Application.Features.Orders.Queries.GetOrderList;
using Ordering.Domain.Entities;

namespace Ordering.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Order, OrdersVm>().ReverseMap();
            this.CreateMap<Order, CheckoutOrderCommand>().ReverseMap();
        }
    }
}
