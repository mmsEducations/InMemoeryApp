using InMemoeryApp.Presentation.Data;
using InMemoeryApp.Presentation.Mediaters.Commands.Product;
using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Handlers.Product
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, int>
    {
        private readonly AppllicationDbContext _context;

        public DeleteProductCommandHandler(AppllicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products.FindAsync(request.Id);
            int affectedRow = 0;
            if (product != null)
            {
                _context.Products.Remove(product);
                affectedRow = await _context.SaveChangesAsync(cancellationToken);

            }
            return affectedRow;
        }
    }
}
