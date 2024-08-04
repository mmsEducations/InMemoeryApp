using InMemoeryApp.Presentation.Data;
using InMemoeryApp.Presentation.Mediaters.Commands.Product;
using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Handlers.Product
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, int>
    {
        private readonly AppllicationDbContext _context;

        public UpdateProductCommandHandler(AppllicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Update(request.Product);
            var affectedRows = await _context.SaveChangesAsync(cancellationToken);
            return affectedRows;
        }
    }
}
