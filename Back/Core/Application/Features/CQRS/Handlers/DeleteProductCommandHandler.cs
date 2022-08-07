using Back.Core.Application.Features.CQRS.Commands;
using Back.Core.Application.Interfaces;
using Back.Core.Domain;
using MediatR;

namespace Back.Core.Application.Features.CQRS.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest>
    {
        private readonly IRepository<Product> _repository;

        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var deletedEntity = await _repository.GetByIdAsync(request.Id);
            if (deletedEntity != null)
            {
            await _repository.DeleteAsync(deletedEntity);
            }
            return Unit.Value;
        }
    }
}
