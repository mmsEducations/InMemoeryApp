using InMemoeryApp.Presentation.Data;
using InMemoeryApp.Presentation.Mediaters.Commands.Product;
using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Handlers.Product
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly AppllicationDbContext _context;

        public CreateProductCommandHandler(AppllicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(request.Product);
            var affectedRows = await _context.SaveChangesAsync(cancellationToken);
            return affectedRows;
        }
    }
}
