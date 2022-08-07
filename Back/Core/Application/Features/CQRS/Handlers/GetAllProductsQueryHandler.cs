using AutoMapper;
using Back.Core.Application.Dto;
using Back.Core.Application.Features.CQRS.Queries;
using Back.Core.Application.Interfaces;
using Back.Core.Domain;
using MediatR;

namespace Back.Core.Application.Features.CQRS.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, List<ProductListDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductListDto>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var data =  await _repository.GetAllAsync();
            return _mapper.Map<List<ProductListDto>>(data);
        }
    }
}
