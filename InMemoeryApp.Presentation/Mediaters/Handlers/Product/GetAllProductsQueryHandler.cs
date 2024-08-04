using InMemoeryApp.Presentation.Data;
using InMemoeryApp.Presentation.Mediaters.Queries.Product;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace InMemoeryApp.Presentation.Mediaters.Handlers.Product
{
    //Business
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly AppllicationDbContext _context;

        public GetAllProductsQueryHandler(AppllicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _context.Products.ToListAsync(cancellationToken);
            return products;
        }
    }
}


/*
 : IRequestHandler<request,response>
 : IRequestHandler<query yada command,dönen response>
 */