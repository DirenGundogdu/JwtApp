using Back.Core.Application.Dto;
using MediatR;

namespace Back.Core.Application.Features.CQRS.Queries
{
    public class GetAllProductsQueryRequest : IRequest<List<ProductListDto>>
    {
    }
}
