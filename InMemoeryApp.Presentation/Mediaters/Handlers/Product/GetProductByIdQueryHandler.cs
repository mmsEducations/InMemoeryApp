using InMemoeryApp.Presentation.Data;
using InMemoeryApp.Presentation.Data.Entities;
using InMemoeryApp.Presentation.Mediaters.Queries.Product;
using MediatR;

namespace InMemoeryApp.Presentation.Mediaters.Handlers.Product
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly AppllicationDbContext _context;

        public GetProductByIdQueryHandler(AppllicationDbContext context)
        {
            _context = context;
        }
        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.FindAsync(request.Id);
        }
    }
}
